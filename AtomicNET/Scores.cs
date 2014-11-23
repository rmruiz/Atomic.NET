//Copyright (C) 2003  Rolando Ruiz C. 
//
//This program is free software; you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation; either version 2 of the License, or
//(at your option) any later version.
//
//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.
//
//You should have received a copy of the GNU General Public License
//along with this program; if not, write to the Free Software
//Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
//
// Contact Author at rolando.ruiz@gmail.com


using System;
using System.Xml;
using System.Text;
using System.Security.Cryptography;

namespace AtomicNET
{
    public class Scores
    {
        private string scoresFilename = "scores.xml";
        private static int MAXLEVELS = 82;

        private struct nivelpos
        {
            public int puntaje;
            public string ganador;
        }

        private nivelpos[,] arreglo = new nivelpos[MAXLEVELS, 4];

        public Scores()
        {
            try
            {
                XmlTextReader reader = new XmlTextReader(scoresFilename);
                reader.WhitespaceHandling = WhitespaceHandling.None;
                // <item level="0" pos="0" score="0" winner="nombre" />
                int level = 0;
                int pos = 0;
                int score = 0;
                string winner = null;
                string complete = null;

                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name.CompareTo("item") == 0)
                    {
                        reader.MoveToNextAttribute();
                        if (reader.Name.CompareTo("level")==0)
                        {
                            level = Int32.Parse(reader.Value);
                            reader.MoveToNextAttribute();
                            if (reader.Name.CompareTo("pos") == 0)
                            {
                                pos = Int32.Parse(reader.Value);
                                reader.MoveToNextAttribute();
                                if (reader.Name.CompareTo("score") == 0)
                                {
                                    score = Int32.Parse(reader.Value);
                                    reader.MoveToNextAttribute();
                                    if (reader.Name.CompareTo("winner") == 0)
                                    {
                                        winner = reader.Value;
                                        this.SetScore(level, pos, score, winner);
                                        complete += level.ToString()+pos.ToString()+score.ToString()+winner;
                                    }
                                }
                            }
                        }
                    }
                    else if (reader.NodeType == XmlNodeType.Element && reader.Name.CompareTo("checksum") == 0)
                    {
                        reader.Read();
                        if (this.MD5(complete).CompareTo(reader.Value) != 0)
                        {
                            reader.Close();
                            throw new Exception();
                        }
                    }
                }
                reader.Close();
            }
            catch
            {
                for (int l = 0; l < MAXLEVELS; l++)
                {
                    for (int p = 0; p < 4; p++)
                    {
                        arreglo[l, p].puntaje = 0;
                        arreglo[l, p].ganador = "";
                    }
                }
                this.saveToXml();
            }
        }
  
        public void InsertScore(int level, int newscore, string winner)
        {
            for (int pos = 3; pos >= 0; pos--)
                if (this.GetScore(level, pos) == 0 || this.GetScore(level, pos) > newscore)
                {
                    if (pos != 3)
                        this.SetScore(level, pos + 1, this.GetScore(level, pos), this.GetWinner(level, pos));
                    this.SetScore(level, pos, newscore, winner);
                }
            this.saveToXml();
        }
        public void SetScore(int level, int pos, int score, string winner)
        {
            if (winner == null) winner = "";
            arreglo[level, pos].puntaje = score;
            arreglo[level, pos].ganador = winner;
        }
        public string GetWinner(int level, int pos)
        {
            return arreglo[level, pos].ganador;
        }
        public int GetScore(int level, int pos)
        {
            return arreglo[level, pos].puntaje;
        }
        public bool IsHiScore(int level, int newscore)
        {
            if (arreglo[level, 3].puntaje == 0 || arreglo[level, 3].puntaje < newscore) 
                return true;
            //else
            return false;
        }
        private void saveToXml()
        {
            XmlTextWriter writer = new XmlTextWriter(scoresFilename, null);
            string complete = null;
            writer.WriteStartElement("scores");
            for (int l = 0; l < MAXLEVELS; l++)
            {
                for (int p = 0; p < 4; p++)
                {
                    writer.WriteStartElement("item");
                    writer.WriteAttributeString("level", l.ToString());
                    complete += l.ToString();
                    writer.WriteAttributeString("pos", p.ToString());
                    complete += p.ToString();
                    writer.WriteAttributeString("score", arreglo[l, p].puntaje.ToString());
                    complete += arreglo[l, p].puntaje.ToString();
                    writer.WriteAttributeString("winner", arreglo[l, p].ganador);
                    complete += arreglo[l, p].ganador;
                    writer.WriteEndElement();
                }
            }
            writer.WriteStartElement("checksum");
            writer.WriteValue(this.MD5(complete));
            writer.WriteEndElement();
            
            writer.WriteEndElement();
            writer.Close(); 
        }

        private string MD5(string value)
        {
            MD5CryptoServiceProvider x = new MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(value);
            bs = x.ComputeHash(bs);
            StringBuilder s = new StringBuilder();
            foreach (byte b in bs)
                s.Append(b.ToString("x2").ToLower());
            return s.ToString();
        }
    }
}

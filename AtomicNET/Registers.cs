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
using System.IO;
using Microsoft.Win32;
using System.Xml;

namespace AtomicNET
{
    public class Settings
    {
        private string filename = "saved.xml";
        private string language = "spa";
        private int speed = 4;
        private string score = null;

        public Registers()
        {
            try
            {
                XmlTextReader reader = new XmlTextReader(filename);
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        switch (reader.Name)
                        {
                            case "speed":
                                reader.Read();
                                this.speed = Int32.Parse(reader.Value);
                                break;
                            case "language":
                                reader.Read();
                                this.language = reader.Value;
                                break;
                            case "score":
                                reader.Read();
                                this.score = reader.Value;
                                break;
                        }
                    }
                }
                reader.Close();
            }
            catch
            {

            }
            
        }
        public int LoadSpeed()
        { 
            return this.speed;
        }
        public void SetSpeed(int speed)
        {
            
        }       
        public string LoadLanguage()
        {
            return this.language;
        }
        public void SetLanguage(string lang)
        {
            
        }
        public void InsertScore(int level, int newscore, string winner)
        {
            //for (int pos = 4; pos >= 0; pos--)
            //    if (this.GetScore(level, pos) == 0 || this.GetScore(level, pos) > newscore)
            //    {
            //        if (pos != 4)
            //            this.SetScore(level, pos + 1, this.GetScore(level, pos), this.GetWinner(level, pos));
            //        this.SetScore(level, pos, newscore, winner);
            //    }
        }
        public void SetScore(int level,int pos, int score, string winner)
        {
            //if (winner == null) winner = "";
            //this.HkAtomicNETscores.SetValue("s_" + level.ToString() + "_" + pos.ToString(), score);
            //this.HkAtomicNETscores.SetValue("w_" + level.ToString() + "_" + pos.ToString(), winner);
        }
        public string GetWinner(int level, int pos)
        {
            //return (string)(this.HkAtomicNETscores.GetValue("w_" + level.ToString() + "_" + pos.ToString()));
            return "rolo";
        }
        public int GetScore(int level, int pos)
        {
            //TODO: error!
            //object x = this.HkAtomicNETscores.GetValue("s_" + level.ToString() + "_" + pos.ToString());
            //return (int)(x);
            return 0;
        }
        public bool IsHiScore(int level, int newscore)
        {
            //int oldscore = this.GetScore(level, 4);
            //if (oldscore == 0 || oldscore > newscore) return true;
            return false;
        }
    }
}

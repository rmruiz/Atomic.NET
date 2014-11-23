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

namespace AtomicNET
{
    public static class Settings
    {
        private static string settingsFilename = "saved.xml";

        private static void saveXML(int speed, string language)
        {
            XmlTextWriter writer = new XmlTextWriter(settingsFilename, null);
                writer.WriteStartElement("settings");
                writer.WriteStartElement("speed");
                writer.WriteValue(speed);
                writer.WriteEndElement();
                writer.WriteStartElement("language");
                writer.WriteValue(language);
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.Close();
        }

        public static int Speed
        {
            get
            {
                try
                {
                    XmlTextReader reader = new XmlTextReader(settingsFilename);
                    while (reader.Read() && reader.NodeType == XmlNodeType.Element && reader.Name.CompareTo("speed") == 0)
                    {
                        reader.Read();
                        return Int32.Parse(reader.Value);
                    }
                    reader.Close();
                }
                catch
                {
                }
                return 3; //default
            }
            set
            {
                string language = "eng";

                XmlTextReader reader = new XmlTextReader(settingsFilename);
                while (reader.Read() && reader.NodeType == XmlNodeType.Element && reader.Name.CompareTo("language") == 0)
                {
                    reader.Read();
                    language = reader.Value;
                }
                reader.Close();

                saveXML(value, language); 
            }
        }

        enum LanguageType {english, spanish, french};
        //TODO: reemplazar los strings del lenguaje por enum

        public static string Language
        {
            get
            {
                try
                {
                    XmlTextReader reader = new XmlTextReader(settingsFilename);
                    while (reader.Read() && reader.NodeType == XmlNodeType.Element && reader.Name.CompareTo("language") == 0)
                    {
                        reader.Read();
                        return reader.Value;
                    }
                    reader.Close();
                }
                catch
                {
                }
                return "eng";
            }
            set
            {
                int speed = 3;
                XmlTextReader reader = new XmlTextReader(settingsFilename);
                while (reader.Read() && reader.NodeType == XmlNodeType.Element && reader.Name.CompareTo("speed") == 0)
                {
                    reader.Read();
                    speed = Int32.Parse(reader.Value);
                }
                reader.Close();
                saveXML(speed, value);
            }
        }
    }
}
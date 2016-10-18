using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace SindaSoft.RegexTester
{
    public class Settings
    {
        public string regularExpression;
        public string testText;
        public bool checkAsType;
        public bool ignoreCase;
        public bool singleLine;
        public bool multiLine;
        public bool rightToLeft;
        public bool ignoreWhitespace;
        public bool ecma;
        public bool cultureInvariant;
        public bool cultureExplicit;

        #region Xml Serialization

        public bool serializeTo(string filename)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Settings));

                TextWriter textWriter = new StreamWriter(filename);
                serializer.Serialize(textWriter, this);
                textWriter.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Settings serializeFrom(string filename)
        {
            try
            {
                FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
                XmlSerializer serializer = new XmlSerializer(typeof(Settings));

                Settings data = (Settings)serializer.Deserialize(stream);
                stream.Close();
                return data;
            }
            catch
            {
                return default(Settings);
            }
        }


        #endregion


    }
}

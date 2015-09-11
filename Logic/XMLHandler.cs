using System;
using System.IO;
using System.Xml.Serialization;
using WhiteCrow.Models;

namespace WhiteCrow.Logic
{
    public static  class XmlHandler
    {
        private const string Filename = "baza.db";

        public static Database GetDB()
        {
            var db = new Database();
            using (TextReader reader = new StreamReader(Filename))
            {
                var s = new XmlSerializer(typeof(Database));
                db = (Database)s.Deserialize(reader);
            }

            return db;
        }


        public static void SaveDB(Database db)
        {
            using (TextWriter writer = new StreamWriter(Filename))
            {
                var b = new XmlSerializer(db.GetType());
                b.Serialize(writer, db);
            }
        }
    }
}

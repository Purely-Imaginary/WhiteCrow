using System;
using System.IO;
using System.Xml.Serialization;
using WhiteCrow.Interfaces;
using WhiteCrow.Models;

namespace WhiteCrow.Logic
{
    public class XmlHandler : IFileHandler
    {
        private const string filename = "baza.db";

        public IDatabase GetDB()
        {
            var db = new Database();
            using (TextReader reader = new StreamReader(filename))
            {
                var s = new XmlSerializer(typeof(Database));
                db = (Database)s.Deserialize(reader);
            }

            return db;
        }

        
        public void SaveDB(IDatabase db)
        {
            using (TextWriter writer = new StreamWriter(filename))
            {
                var b = new XmlSerializer(db.GetType());
                b.Serialize(writer, db);
            }
        }
    }
}

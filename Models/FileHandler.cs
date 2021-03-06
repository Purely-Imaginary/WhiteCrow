﻿using WhiteCrow.Logic;

namespace WhiteCrow.Models
{
    internal class FileHander
    {
        public string Filename { get; set; }

        public Database GetDB()
        {
            var db = XmlHandler.GetDB();
            return db;
        }

        public void SaveDB(Database db)
        {
            XmlHandler.SaveDB(db);
        }
    }
}
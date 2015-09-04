using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WhiteCrow.Interfaces;

namespace WhiteCrow.Models
{
    class FileHander : IFileHandler
    {
        public string Filename { get; set; }


        public IDatabase GetDB()
        {
            IDatabase db = new Database();

            return db;
        }

        public void SaveDB(IDatabase db)
        {
            throw new NotImplementedException();
        }
    }
}

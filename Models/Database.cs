using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WhiteCrow.Interfaces;

namespace WhiteCrow.Models
{
    class Database : IDatabase
    {
        List<IPerson> studentsList { get; set; }

        public List<IPerson> GetStudents()
        {
            return null;
        }  



    }
}

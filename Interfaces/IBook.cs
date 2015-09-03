using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhiteCrow.Interfaces
{
    public interface IBook
    {
        string GetId();

        string GetName();

        DateTime GetBorrowTime();
    }
}

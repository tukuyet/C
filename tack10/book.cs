using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Method
{
    class Book
    {
        String _bookName;
        public string Print()
        {
            return _bookName;
        }
        public void Input(string bkName)
        {
            _bookName = bkName;
        }
    }
}
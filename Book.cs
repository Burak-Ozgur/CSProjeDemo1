using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSProjeDemo1.Enums;

namespace CSProjeDemo1
{
    public class Book
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string YearOfPublication { get; set; }
        public Status Status { get; set; }
    }

}

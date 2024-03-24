using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public interface IMember
    {
        void BorrowBook(Book book);
        void ReturnBook(Book book);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public class Member:IMember
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MemberID { get; set; }
        public List<Book> BorrowedBooks { get; set; }

        public Member(string firstName, string lastName, int memberID)
        {
            FirstName = firstName;
            LastName = lastName;
            MemberID = memberID;
            BorrowedBooks = new List<Book>();
        }

        public void BorrowBook(Book book)
        {
            BorrowedBooks.Add(book);
        }

        public void ReturnBook(Book book)
        {
            BorrowedBooks.Remove(book);
        }
    }
}

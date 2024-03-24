using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSProjeDemo1.Enums;

namespace CSProjeDemo1
{
    public class Library
    {
        private List<Book> books;
        private List<Member> members;

        public Library()
        {
            books = new List<Book>();
            members = new List<Member>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public void AddMember(Member member)
        {
            members.Add(member);
        }

        public void RemoveMember(Member member)
        {
            members.Remove(member);
        }

        public void BorrowBook(Member member, Book book)
        {
            if (books.Contains(book) && book.Status == Status.Available)
            {
                book.Status = Status.Borrowed;
                member.BorrowBook(book);
            }
        }

        public void ReturnBook(Member member, Book book)
        {
            if (member.BorrowedBooks.Contains(book))
            {
                book.Status = Status.Available;
                member.ReturnBook(book);
            }
        }

        public void UpdateBookStatus(Book book, Status status)
        {
            book.Status = status;
        }

    }

}

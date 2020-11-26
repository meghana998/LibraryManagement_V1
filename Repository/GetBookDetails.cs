using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booksearch_API.Repository
{
    
    public class GetBookDetails:IGetBookDetails
    {
        private static readonly List<Book> b1 =new List<Book>() {
            new Book{Bookid=1,Bookname="FristBook",AuthorName="FristAuthor",BookEdition=2},
              new Book{Bookid=2,Bookname="SecondBook",AuthorName="secondAuthor",BookEdition=2},
               new Book{Bookid=3,Bookname="ThirdBook",AuthorName="thirdAuthor",BookEdition=2},
                new Book{Bookid=4,Bookname="fourBook",AuthorName="FourAuthor",BookEdition=2},
        };

      //  public Book GetBookInfo(int id)
       // {
            
        //    var bok = b1.SingleOrDefault(x => x.Bookid == id);
         //   return bok;
        //}
        public IEnumerable<Book> DisplayAllBooks()
        {
            var booklist = from book in b1 select book;
            return booklist.ToList();
        }

    }
}

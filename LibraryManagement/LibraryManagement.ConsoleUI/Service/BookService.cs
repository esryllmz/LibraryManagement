

using LibraryManagement.ConsoleUI.Models;
using LibraryManagement.ConsoleUI.Repository;

namespace LibraryManagement.ConsoleUI.Service
{
    public class BookService
    {

        BookRepository bookRepository= new BookRepository();

        public void GetAll()
        {
            List< Book > books = bookRepository.GetAll();

            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
        }

        public void GellById(int id)
        {
            Book? book = bookRepository.GetById(id);
            if (book == null)
            {
                Console.WriteLine($"Aradığınız ID ye göre kitap bulunamadı : {id}" );
                return;

            }
            Console.WriteLine(book);
        }


        public void Remove(int id)
        {
            Book? deletedBook = bookRepository.GetById(id);
            if(deletedBook == null)
            {
                Console.WriteLine("Aradığınız kitap bulunamadı.(Zaten Yok)");
                return;

            }
            Console.WriteLine(deletedBook);
        }

        public void GetBookByISBN(string isbn)

        {
            Book? boo1 = BookRepository.GetBookByISBN(isbn);

            if(boo1 == null)
            {
                Console.WriteLine("Aradığınız ISBN bulunamadı");
                return;
            }

            Console.WriteLine(book);
        }
    }

}
}

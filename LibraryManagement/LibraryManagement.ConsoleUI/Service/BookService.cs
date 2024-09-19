

using LibraryManagement.ConsoleUI.Models;
using LibraryManagement.ConsoleUI.Models.Dtos;
using LibraryManagement.ConsoleUI.Repository;

namespace LibraryManagement.ConsoleUI.Service
{
    public class BookService
    {

        BookRepository bookRepository = new BookRepository();

        public void GetAll()
        {
            List<Book> books = bookRepository.GetAll();

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
                Console.WriteLine($"Aradığınız ID ye göre kitap bulunamadı : {id}");
                return;

            }
            Console.WriteLine(book);
        }


        public void Remove(int id)
        {
            Book? deletedBook = bookRepository.GetById(id);
            if (deletedBook == null)
            {
                Console.WriteLine("Aradığınız kitap bulunamadı.(Zaten Yok)");
                return;

            }
            Console.WriteLine(deletedBook);
        }

        //public void GetBookByISBN(string isbn)

        //{
        //    Book? book1 = BookRepository.GetBookByISBNFilter(isbn);

        //    if(book1 == null)
        //    {
        //        Console.WriteLine("Aradığınız ISBN bulunamadı");
        //        return;
        //    }

        //    Console.WriteLine(book1);
        //}

        public void Add(Book book)
        {

            Book created = bookRepository.Add(book);
            Console.WriteLine("Kitap Eklendi");
            Console.WriteLine(book);

        }

        //public Book GetAllBooksByPageSize(int min, int max)
        //{
        //    List<Book> books= bookRepository.GetAllBooksByPageSize(min, max);

        //    foreach (Book book in books) 
        //    { 

        //        Console.WriteLine(book);  

        //    }

        //}

        public void GetAllBooksTittleContains(string text)
        {

            List<Book> books = bookRepository.GetAllBooksTittleContains(text);



            foreach (Book book in books)
            {

                Console.WriteLine(book);

            }




        }

        public void GetAllBooksOrderByTittle()
        {
            List<Book> books = bookRepository.GetAllOrderByTittle();

            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
        }

        public void GetAllOrderByDesceningTittle()
        {
            List<Book> books = bookRepository.GetAllOrderByDesceningTittle();

            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
        }

        public void GetBookMaxPageSize()

        {
            List<Book> book = bookRepository.GetBookMaxPageSize();
            Console.WriteLine(book);

            //List<Book> books=bookRepository.GetBookMaxPageSize();

            //Console.WriteLine(books[0]);


        }

        public void GetBookMinPageSize()

        {
            List<Book> book = bookRepository.GetBookMaxPageSize();
            Console.WriteLine(book);

            //List<Book> books = bookRepository.GetBookMinPageSize();

            //Console.WriteLine(books[0]);


        }

        public void GetDetails()
        {
            List<BookDetailDto> books = bookRepository.GetDetails();
            foreach (BookDetailDto bookDetail in books)
            { Console.WriteLine(bookDetail); }

        }
    }
}





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
            Book ? getByIdBook= bookRepository.GetById(book.Id);

            if (getByIdBook!=null)
            {
                Console.WriteLine($"Girmiş olduğunuz kitabın Id alanı benzersiz olmalıdır: {book.Id}");
                return;

            }

            Book ? getByIdISBN= bookRepository.GetBookByISBNFilter(book.ISBN);
            if (getByIdISBN!=null)
            {
                Console.WriteLine($"Girmiş olduğunuz  ISBN alanı benzersiz olmalıdır: {book.ISBN}");
            }


            Book created = bookRepository.Add(book);
            Console.WriteLine("Kitap Eklendi");
            Console.WriteLine(book);

        }

        private

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

        //public void GetDetails()
        //{
        //    List<BookDetailDto> books = bookRepository.GetDetails();
        //    foreach (BookDetailDto bookDetail in books)
        //    { Console.WriteLine(bookDetail); }

        //}

        //public void GetAllBookAndAuthorDetails()
        //{
        //    List<BookDetailDto> details = bookRepository.GetAuthorAndBookDetails();

        //    details.ForEach(x => Console.WriteLine(x));


        //}

        public void GetAllDetailsByCategorId(int categorId)
        {
           List<BookDetailDto> details = bookRepository.GetAllDetailsByCategorId(categorId);

           foreach (BookDetailDto detail in details)
            {
                Console.WriteLine(detail);
            }
        }
    }
}



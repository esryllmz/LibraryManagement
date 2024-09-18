

using LibraryManagement.ConsoleUI.Models;

namespace LibraryManagement.ConsoleUI.Repository;

public class BookRepository
{

    List<Book> books = new List<Book>()
    {
    new Book(1,"Germinal","Kömür Madeni",341, "2012 Myaıs","1111111111111"),
    new Book(2,"Suç ve Ceza","Raskolnikov'un Hayatı",315,"2010 Haziran","2222222222222"),
    new Book(3,"Kumarbaz","Bir Öğretmenin Hayatı",210,"2009 Ocak","3333333333333"),
    new Book(4,"Araba Sevdası","Arabayla alakası olmayan kitap",180,"1999 Ocak","4444444444444"),
    new Book(5,"Ateşten Gömlek","Kurtuluş Savaşını anlatan kitap", 120,"2001 Eylül","5555555555555"),
    new Book(6,"Kaşağı","Okunmaması gereken bir kitap",95,"1993 Ocak","666666666666"),
    new Book(7,"28 Şampiyonluk","Hayal ürünüdür",350,"1907 Ocak","777777777777"),
    new Book(8,"16 Yıl Şampiyonluk","Hayal ürünüdür",255,"1905 Eylül","88888888888888"),
    new Book(9,"Ali Arı","Uyanık CEO hikayesi", 551,"20 Haziran","999999999999")
    };

    public List<Book> GetAll()
    { 
        return books; 
    
    }

    public List<Book> GetAllBooksByPageSize(int min, int max)
    {

        List<Book> filteredBooks= new List<Book>();

        foreach (Book book in books)
        {
            if (book.PageSize <= max && book.PageSize >= min)
            {
                filteredBooks.Add(book);
            }
        }

        return filteredBooks;

    }

    public double PageSizeTotalCalculator()
    {
        double total = books.Sum(book => book.PageSize);
        return total;


    }

    public List<Book> GetAllBooksTittleContains(string text)

    {
        List<Book> filteredBooks = new List<Book>();

        foreach (Book book in books)
        {
            
            if(book.Title.Contains(text,StringComparison.InvariantCultureIgnoreCase))
            {
                filteredBooks.Add(book);
            }

          
        }


        return filteredBooks;

    }

    public Book? GetBookByISBN(string isbn)

    {

        Book book1= null; 

        foreach (Book item in books)
        {
            if (item.ISBN==isbn)
            {
                book1 = item;
               
            }

        }
        //if (book1 == null)

        //{
        //    return null;
        //}
       
        //return book1;

        return book1 is null ? null : book1;
    }

    public Book Add(Book created)
    {
        books.Add(created);
        return created;
    }

    public Book? GetById(int id)
    {
        Book? book1 = null;

        foreach (Book book in books)
        {
            if (book.Id==id)
            {
                book1 =book;
            }
        }

        if (book1 == null)

        {
            return null;
        }

        return book1;

    }

    public Book? Remove(int id)

    {

        Book? deletedBook=GetById(id);

        if (deletedBook is null)
        {
            return null;

        }

        return deletedBook;
    }

   

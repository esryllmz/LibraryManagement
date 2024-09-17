
namespace LibraryManagement.ConsoleUI;

    public record Book(
        
        int Id, 
        string Title,
        string Description,
        int PageSize,
        string PublishDate,
        string ISBN)
{



    public void EkranaYaz()
    {
        Console.WriteLine($"Kitabın Id: {Id} ");
        Console.WriteLine($"Kitabın Başlığı:{Title}");
        Console.WriteLine($"Kitabın Açıklaması:{Description}");
        Console.WriteLine($"Kitabın Sayfa Sayısı:{PageSize} ");
        Console.WriteLine($"Kitabın Basım Tarihi:{PublishDate} ");
        Console.WriteLine($"Kitabın ISBN: {ISBN}");
        
    }


    public void Add(Book book)
    {

        if (books.IndexOf())
        {
            Console.WriteLine("Benzersiz bir kitap girmeniz gerekmektedir");
            return;
        }

        (int id, string title, string desc, int pagesize, int publishdate, int isbn);

        Console.WriteLine("***Kitap eklendi");
        book.EkranaYaz();

    }


    public void Remove(Book book)
    {
        Console.WriteLine("***Kitap silindi");
        book.EkranaYaz();

    }


    public void Update(Book book)
    {
        Console.WriteLine("***Kitap güncellendi");
        book.EkranaYaz();

    }
}









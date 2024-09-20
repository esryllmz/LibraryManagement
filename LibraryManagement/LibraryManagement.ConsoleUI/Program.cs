// (Record) Kitap-> Id,Tittle, Description, PageSize,PublishDate,ISBN,Stok
// (Record) Author-> Id,Name, Surname, 
// (Class) Category-> Id,Name
//----------------------------
//Kitaplar Listesi oluşturunuz.
//Yazarlar Listesi oluşturunuz.
//Kategoriler Listesi oluşturunuz.
//-------------------------------------
//Yazarları ekrana bastıran kodu yazınız.
//Kitapları ekrana bastıran kodu yazınız.
//Kategorileri ekrana bastıran kodu yazınız.
//------------------------------------------
//Kitapları sayfa sayısına göre filtreleyen kodu yazınız.
//Kütüphanedeki tüm kitapların sayfa sayısı toplamını yazınız.
//Kitap başlığına göre filtreleyen işlemleri yapınız.
//Kitap ISBN numarasına göre ilgili kitabı getirinz.
//---------------------------------------------------
//Kitaplar listesine yeni bir kitap ekleyin, sonra listeyi ekran listesi olarak veriniz.(Verileri kullanıcıdan alınız.)
//Kitap eklerken ıd si veya ISBN numarası daha önceki kayıtlı kitapsa "Benzersiz bir kitap girmeniz gerekmektedir" yazısı veriniz.
//---------------------------------------------------------------------------------------------------------------------------------
//Kullanıcı ıd girince silme ve ekleme işlemi yapabilecek
//-------------------------------------------------------
//Kullanıcıdan ilk başta id değeri alıp arama yapınca eğer sistemde yoksa "İlgili id ye ait kitap bulunamadı " yazısını verecek
//Güncellenecek olan değerler kullanıcıdan alınacaktır.
//-----------------------------------------------------
//Kullanıcıdan bir kitap almasını isteyen kodu yazınız.
//Eğer o kitap stok da varsa alındı yazsın
// 1 tane varsa o kitap alınsın ve 0 olursa listeden silinsin.
//----------------------------------------------------
//***Prime Örnekler
//BookDetail adınd bir record oluşturup şu değerler listelenecek
//Kitap Id, Kitap Başlığı, Kitap Açıklaması, Kitap Sayfa Sayısı, ISBN,Yazar Adı, Kategori Adı
//--------------------------------------------------------------------------------------------
//Kullanıcıdan PageIndex ve PageSize değerleri alarak sayfalama desteği getiriniz.


using LibraryManagement.ConsoleUI;
using LibraryManagement.ConsoleUI.Models;
using LibraryManagement.ConsoleUI.Service;
using System.Threading.Channels;



List<Author>  authors= new List<Author>()
{
    new Author(1,"Emile","Zola"),
    new Author(2,"Fyodor","Dostoyevski"),
    new Author(3,"Recaizade Mahmut","Ekrem"),
    new Author(4,"Halide Edib","Adıvar"),
    new Author(5,"Ömer","Seyfettin"),
    new Author(6,"Ali","Koç"),
    new Author(7,"Vız Vız","Ali"),
  
   

};
List<Category> categories = new List<Category>()
{
    new Category(1,"Dünya Klasikleri"),
    new Category(2,"Türk Klasikleri"),
    new Category(3,"Bilim Kurgu"),
   

};

//Console.WriteLine();
//Console.WriteLine("Kitaplar Listesi");
//Console.WriteLine();
//foreach (var item in books)
//{
//    Console.WriteLine(item);
//    Console.WriteLine();
//};
//Console.WriteLine("Yazarlar Listesi ");
//Console.WriteLine();
//foreach (var item in authors)
//{
//    Console.WriteLine(item);
//};
//Console.WriteLine("Kategoriler Listesi ");
//Console.WriteLine();
//foreach (var item in categories)
//{
//    Console.WriteLine(item);
//};

////GetAllBooks();
//GetAllCategories();
//GetAllAuthors();
//GetAllBooksByPageSize();
//PageSizeTotalCalculator();
//GetAllBooksByTittleFilter();
//GetBookByISBN();
//GetAllBooks();
//AddBook();
//Add();
//AddCategory();
//AddAuthor();


BookService bookService = new BookService();
//bookService.GetAll();
//bookService.GellById(1);
//bookService.GetAllBooksByPageSize(100, 150);
//bookService.GetAllBooksTittleContains("K");
//bookService.GetAllBooksOrderByTittle();
//bookService.GetBookMinPageSize();
//bookService.GetBookMaxPageSize();
//bookService.GetDetails();
//bookService.GetAllBookAndAuthorDetails();
bookService.GetAllDetailsByCategorId(3);

//LibraryController controller = new LibraryController();
//controller.Run();

void GetAllCategories()
{

    PrintAyirac("Kategorileri listele:");

    foreach (var item in categories)
    {
        Console.WriteLine(item);
    };
}
void GetAllAuthors()
{
    PrintAyirac("Yazarları listele:");
    
    foreach (var item in authors)
    {
        Console.WriteLine(item);
    };
}
void PrintAyirac(string metin)
{
    Console.WriteLine(metin);
    Console.WriteLine("--------------------------------");
}
//void GetBookByISBN()
//{
//    Console.WriteLine("Lütfen ISBN numarasını giriniz:");
//    string isbn = Console.ReadLine();

//    foreach(Book book in books)

//    {
//        if (book.ISBN == isbn)
//        {
//            Console.WriteLine(book);
//        }
//    }
//}
void Add(Book book)

{
    PrintAyirac("Kitap Ekleme: ");
    Console.WriteLine("Lütfen kitap id sini giriniz: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen kitap başlığını giriniz: ");
    string title = Console.ReadLine();

    Console.WriteLine("Lütfen kitap Açıklamasını giriniz: ");
    string description = Console.ReadLine();

    Console.WriteLine("Lütfen kitap sayfasını giriniz: ");
    int pageSize = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen kitap Yayımlanma Tarihini giriniz: ");
    string publishDate = Console.ReadLine();

    Console.WriteLine("Lütfen kitap ISBN numarasını giriniz: ");
    string isbn = Console.ReadLine();


    //Book book = new Book(id, title, description, pageSize, publishDate, isbn);

    bool isUnique = true;

    //    foreach (Book item in books)
    //    {
    //        if (item.Id==id || item.ISBN==isbn )
    //        {
    //            isUnique = false;
    //            break;
    //        }
    //    }

    //    if (!isUnique)
    //    {
    //        Console.WriteLine("Girmiş olduğunuz kitap benzersiz değildir.");
    //    }

    //    books.Add(book);

    //    foreach(Book item in books)
    //    {
    //        Console.WriteLine(item);
    //    }
    //}
    //Book GetBookInputs2()
    //{
    //    Console.WriteLine("Lütfen kitap id sini giriniz: ");
    //    int id = Convert.ToInt32(Console.ReadLine());

    //    Console.WriteLine("Lütfen kitap başlığını giriniz: ");
    //    string title = Console.ReadLine();

    //    Console.WriteLine("Lütfen kitap Açıklamasını giriniz: ");
    //    string description = Console.ReadLine();

    //    Console.WriteLine("Lütfen kitap sayfasını giriniz: ");
    //    int pageSize = Convert.ToInt32(Console.ReadLine());

    //    Console.WriteLine("Lütfen kitap Yayımlanma Tarihini giriniz: ");
    //    string publishDate = Console.ReadLine();

    //    Console.WriteLine("Lütfen kitap ISBN numarasını giriniz: ");
    //    string isbn = Console.ReadLine();

    //    Book book = new Book(id, 1, 1, title, description, pageSize, publishDate, isbn);
    //    return book;
    //}
    //bool AddBookValidator(Book book)
    //{
    //    bool isUnique = true;

    //    foreach (Book item in books)
    //    {
    //        if (item.Id == book.Id || item.ISBN == book.ISBN)
    //        {
    //            isUnique = false;
    //            break;
    //        }
    //    }

    //    return isUnique;
    //}
    //void AddBook()
    //{

    //    Book book = GetBookInputs2();

    //    bool isUnique = AddBookValidator(book);

    //    if (!isUnique)
    //    {
    //        Console.WriteLine("Girmiş olduğunuz kitap Benzersiz değil.");
    //        return;
    //    }
    //    books.Add(book);

    //}
    //bool AddCategoryValidator(Category category)
    //{
    //    bool isUnique = true;

    //    foreach (Category item in categories)
    //    {
    //        if (item.Id == category.Id || item.Name == category.Name)
    //        {
    //            isUnique = false;
    //            break;
    //        }
    //    }

    //    return isUnique;
    //}


    //Category GetCategoryInputs()
    //{
    //    Console.WriteLine("Lütfen kategori id giriniz: ");
    //    int id = Convert.ToInt32(Console.ReadLine());

    //    Console.WriteLine("Lütfen kategori adı giriniz: ");
    //    string name = Console.ReadLine();


    //    Category category = new Category(id, name);
    //    return category;
    //}

    //void AddAuthor()
    //{

    //    Author author = GetAuthorInputs();

    //    bool isUnique = AddAuthorValidator(author);

    //    if (!isUnique)
    //    {
    //        Console.WriteLine("Girmiş olduğunuz Yazar Benzersiz değil.");
    //        return;
    //    }
    //    authors.Add(author);

    //    GetAllAuthors();

    //}


    //bool AddAuthorValidator(Author author)
    //{
    //    bool isUnique = true;

    //    foreach (Author item in authors)
    //    {
    //        if (item.Id == author.Id)
    //        {
    //            isUnique = false;
    //            break;
    //        }
    //    }

    //    foreach (Author item in authors)
    //    {
    //        if (item.Name == author.Name && item.Surname == author.Surname)
    //        {
    //            isUnique = false;
    //            break;
    //        }
    //    }

    //    return isUnique;
    //}


    //Author GetAuthorInputs()
    //{
    //    Console.WriteLine("Lütfen yazar id giriniz: ");
    //    int id = Convert.ToInt32(Console.ReadLine());

    //    Console.WriteLine("Lütfen yazar adı giriniz: ");
    //    string name = Console.ReadLine();

    //    Console.WriteLine("Lütfen yazar soyadı giriniz: ");
    //    string surnname = Console.ReadLine();

    //    Author author = new Author(id, name, surnname);
    //    return author;
    //}
}





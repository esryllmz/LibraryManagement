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
//*Kitap ISBN numarasına göre ilgili kitabı getirinz.
//---------------------------------------------------
//Kitaplar listesine yeni bir kitap ekleyin, sonra listeyi ekran listesi olarak veriniz.(Verileri kullanıcıdan alınız.)
//Kitap eklerken ıd si veya ISBN numarası daha önceki kayıtlı kitapsa "Benzersiz bir kitap girmeniz gerekmektedir" yazısı veriniz.
//---------------------------------------------------------------------------------------------------------------------------------
//Kullanıcı ıd girince silme ve ekleme işlemi yapabilecek
//-------------------------------------------------------
//Kullanıcıdan ilk başta id değeri alıp arama yapınca eğer sistemde yoksa "İlgili id ye ait kitap bulunamadı " yazısını verecek
//Güncellenecek olan değerler kullanıcıdan alınacaktır.
//-----------------------------------------------------
//Kullanıcıdan bir kitap almasını isteyen kodu yaınız.
//Eğer o kitap stok da varsa alındı yazsın
// 1 tane varsa o kitap alınsın ve 0 olursa listeden silinsin.
//----------------------------------------------------
//***Prime Örnekler
//BookDetail adınd bir record oluşturup şu değerler listelenecek
//Kitap Id, Kitap Başlığı, Kitap Açıklaması, Kitap Sayfa Sayısı, ISBN,Yazar Adı, Kategori Adı
//--------------------------------------------------------------------------------------------
//Kullanıcıdan PageIndex ve PageSize değerleri alarak sayfalama desteği getiriniz.


using LibraryManagement.ConsoleUI;
using System.Linq;

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
Console.WriteLine();

Console.WriteLine("Kitaplar Listesi");
Console.WriteLine("******************");

foreach (var item in books)
{
    Console.WriteLine(item);
    Console.WriteLine();
};

Console.WriteLine("Yazarlar Listesi ");
Console.WriteLine("********************");

foreach (var item in authors)
{
    Console.WriteLine(item);
};

Console.WriteLine("Kategoriler Listesi ");
Console.WriteLine("**********************");

foreach (var item in categories)
{
    Console.WriteLine(item);
};

Console.WriteLine("Kitap Sayfa Listesi");
Console.WriteLine("**********************");

foreach (var item in books)
{
    Console.WriteLine((item.Title) +" Sayfa Sayısı: "+ (item.PageSize));
    
    Console.WriteLine();
};

Console.WriteLine("Toplam Kitap Sayfa Sayısı");
Console.WriteLine("****************************");

Console.WriteLine(books.Sum(x => x.PageSize));
Console.WriteLine();

Console.WriteLine("Kitap Başlıkları");
Console.WriteLine("*******************");

foreach (var item in books)
{
   
    Console.WriteLine(item.Title);

    Console.WriteLine();
};


//Console.WriteLine("İstediğiniz ISBN numarasını giriniz:");
//int isbn = Convert.ToInt32(Console.ReadLine());


//foreach (var item in books)
//{
//    if (books.(item))
//    {
//        Console.WriteLine(item.Title);
//    }
//    else
//    {
//        Console.WriteLine("Böyle kitap bulunmamaktadır.");


//    }
//}

Console.WriteLine("Eklemek istediğiniz kitap Id:");
int id = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Eklemek istediğiniz kitap Adı:");
string  title = Console.ReadLine();

Console.WriteLine("Eklemek istediğiniz kitap Açıklaması:");
string desc = Console.ReadLine();

Console.WriteLine("Eklemek istediğiniz kitap Sayfa sayısı:");
int pagesize = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Eklemek istediğiniz kitap Basım Tarihi:");
int publishdate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Eklemek istediğiniz kitap ISBN:");
int isbn = Convert.ToInt32(Console.ReadLine());




foreach (var item in books)
{
    Console.WriteLine(item);
    Console.WriteLine();
};


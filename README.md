# 📚 LibraryManagement

**LibraryManagement**, C# ile geliştirilmiş basit bir kütüphane yönetim sistemi uygulamasıdır.
Konsol tabanlı olarak çalışır ve kitap, yazar, kategori gibi temel kütüphane bileşenlerinin yönetilmesini sağlar.

## 🚀 Özellikler

* 📖 Kitap ekleme, silme, listeleme
* ✍️ Yazar ekleme, silme, listeleme
* 🗂 Kategori ekleme, silme, listeleme
* 📑 Kitap detaylarını görüntüleme
* Repository & Service katmanlı mimari

## 📂 Proje Yapısı

```
LibraryManagement/
│
├── LibraryManagement.ConsoleUI/        # Konsol arayüzü
│   ├── Models/                          # Temel veri modelleri
│   │   ├── Author.cs
│   │   ├── Book.cs
│   │   ├── Category.cs
│   │   └── Dtos/
│   │       └── BookDetailDto.cs
│   ├── Repository/                      # Veri erişim katmanı
│   │   └── BookRepository.cs
│   ├── Service/                         # İş mantığı katmanı
│   │   └── BookService.cs
│   ├── Program.cs                       # Uygulama başlangıç noktası
│   └── *.csproj                         # Proje yapılandırma dosyası
│
├── LibraryManagement.sln                # Çözüm dosyası
```

## 🛠 Gereksinimler

* [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
* C# 12.0 veya üstü uyumlu derleyici

## 📦 Kurulum & Çalıştırma

1. Depoyu klonlayın:

   ```bash
   git clone https://github.com/kullanici/LibraryManagement.git
   ```
2. Proje dizinine gidin:

   ```bash
   cd LibraryManagement/LibraryManagement.ConsoleUI
   ```
3. Projeyi çalıştırın:

   ```bash
   dotnet run
   ```

## 📌 Kullanım

Uygulama çalıştığında, konsol üzerinden şu işlemleri yapabilirsiniz:

* Yeni kitap ekleme
* Mevcut kitapları listeleme
* Yazar veya kategori ekleme/silme
* Kitap detaylarını görüntüleme

## 🏗 Mimari

Proje, **katmanlı mimari** prensiplerine göre tasarlanmıştır:

* **Models** → Veri yapılarının tanımlandığı katman
* **Repository** → Veri erişim ve yönetim operasyonları
* **Service** → İş mantığı ve doğrulama işlemleri
* **ConsoleUI** → Kullanıcı ile etkileşim katmanı


# 📝 To-Do List Uygulaması

Bu proje, **Sorbil Eğitim Kurumu** için hazırlanmış modern bir To-Do List (Yapılacaklar Listesi) uygulamasıdır. ASP.NET Core 6.0 teknolojisi kullanılarak geliştirilmiştir.

## 🎯 Proje Hakkında

Bu uygulama, kullanıcıların günlük görevlerini organize etmelerine, takip etmelerine ve yönetmelerine olanak sağlayan modern bir web uygulamasıdır. Kullanıcı dostu arayüzü ve güçlü backend yapısı ile profesyonel bir deneyim sunar.

## 🚀 Özellikler

- ✅ **Görev Ekleme**: Yeni görevler kolayca eklenebilir
- 🎯 **Görev Tamamlama**: Görevler tek tıkla tamamlanabilir
- ⭐ **Önemli İşaretleme**: Önemli görevler yıldız ile işaretlenebilir
- 📝 **Açıklama Ekleme**: Görevlere detaylı açıklama eklenebilir
- 🗑️ **Görev Silme**: Gereksiz görevler silinebilir
- 📊 **İstatistikler**: Tamamlanan ve bekleyen görev sayıları
- 🎨 **Modern UI**: Responsive ve kullanıcı dostu arayüz

## 🛠️ Kullanılan Teknolojiler

### Backend Teknolojileri
- **ASP.NET Core 6.0** - Modern web framework
- **C#** - Güçlü nesne yönelimli programlama dili
- **Entity Framework Core 6.0** - ORM (Object-Relational Mapping)
- **SQL Server** - Veritabanı yönetim sistemi

## 🏗️ Mimari Yaklaşım

### MVC (Model-View-Controller) Pattern
- **Model**: Veri yapıları ve iş mantığı
- **View**: Kullanıcı arayüzü
- **Controller**: İş mantığı ve veri akışı

## 📁 Proje Yapısı

```
To-DoListApp/
├── Controllers/          # MVC Controller'ları
│   ├── HomeController.cs
│   └── GorevController.cs
├── Models/              # Veri modelleri
│   ├── Context.cs       # DbContext
│   ├── YapilacakGorev.cs
│   └── ErrorViewModel.cs
├── Views/               # Razor view'ları
│   ├── Home/
│   ├── Gorev/
│   └── Shared/
├── Migrations/          # Entity Framework migrations
├── wwwroot/            # Statik dosyalar
│   ├── css/
│   ├── js/
│   └── To-DoListAppTemplate/
└── Properties/          # Proje ayarları
```

## 📄 Lisans

Bu proje eğitim amaçlı geliştirilmiştir.

## 👨‍💻 Geliştirici

**Sorbil Eğitim Kurumu - Tunahan Cengiz** - Sıfırdan ASP.NET Core Eğitimi


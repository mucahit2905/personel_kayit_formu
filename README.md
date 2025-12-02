# Personel Takip ve Yönetim Sistemi 🚀

C# Windows Forms ve SQL Server mimarisi kullanılarak geliştirilmiş, personel verilerinin kayıt altına alınmasını, düzenlenmesini ve grafiksel olarak raporlanmasını sağlayan masaüstü otomasyon projesi.




## 🎯 Proje Hakkında
Bu proje, kurumsal bir yapıda çalışan personellerin bilgilerini dijital ortamda saklamak ve yönetmek amacıyla geliştirilmiştir. Katmanlı mimari mantığına uygun olarak ve **ADO.NET** teknolojisi kullanılarak veri tabanı bağlantıları gerçekleştirilmiştir.

## ⚙️ Özellikler

Proje içerisinde aşağıdaki temel CRUD işlemleri ve ekstra modüller bulunmaktadır:

* **Personel Yönetimi:**
    * **Ekleme:** Ad, Soyad, Şehir, Maaş, Medeni Durum ve Meslek bilgileriyle kayıt.
    * **Listeleme:** Kayıtlı personelleri DataGridView üzerinde görüntüleme.
    * **Güncelleme:** Mevcut personel bilgilerini düzenleme.
    * **Silme:** İşten ayrılan veya hatalı girilen kayıtları silme.
    * **Temizleme:** Form alanlarını yeni giriş için sıfırlama.

* **Raporlama ve Analiz:**
    * **İstatistikler:** Toplam personel, evli/bekar çalışan sayısı, şehir sayısı, toplam ve ortalama maaş gibi verilerin anlık hesaplanması.
    * **Grafikler:** Verilerin görsel olarak (Chart araçları ile) analiz edilmesi.

## 🛠 Kullanılan Teknolojiler

* **Programlama Dili:** C#
* **Arayüz:** Windows Forms (WinForms) / .NET Framework
* **Veritabanı:** Microsoft SQL Server
* **Veri Erişim:** ADO.NET (SqlClient)
* **IDE:** Visual Studio

## 💻 Kurulum

Projeyi kendi bilgisayarınızda çalıştırmak için:

1.  Bu repoyu klonlayın veya ZIP olarak indirin.
2.  SQL Server'da bir veritabanı oluşturun.
3.  Proje içerisindeki `SqlBaglantisi` sınıfında bulunan bağlantı adresini (Connection String) kendi sunucunuza göre güncelleyin.
4.  Projeyi Visual Studio üzerinden başlatın (`F5`).

---

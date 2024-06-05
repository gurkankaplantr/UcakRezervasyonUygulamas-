# UcakRezervasyonUygulamas-

## Proje Açıklaması
Uçak Rezervasyon Sistemi, kullanıcıların uçak rezervasyonlarını yapabileceği, mevcut rezervasyonlarını yönetebileceği ve uçuş bilgilerini görüntüleyebileceği kapsamlı bir sistemdir. Bu proje, kullanıcı dostu bir arayüz sunarak uçak rezervasyon süreçlerini kolaylaştırmayı amaçlar.

## Özellikler
- **Uçuş Arama:** Kullanıcılar belirli kriterlere göre uçuş arayabilirler.
- **Rezervasyon Yapma:** Seçilen uçuşlar için rezervasyon işlemi gerçekleştirilir.
- **Rezervasyon Yönetimi:** Mevcut rezervasyonlar görüntülenebilir, güncellenebilir veya iptal edilebilir.
- **Uçak ve Lokasyon Yönetimi:** Uçak ve uçuş lokasyonları ile ilgili bilgiler yönetilebilir.

## Kurulum
1. **Depoyu Klonlayın:**
    ```bash
    git clone <repo_url>
    ```

2. **Gerekli Bağımlılıkları Yükleyin:**
    - Bu proje .NET Framework kullanılarak geliştirilmiştir. .NET SDK'nın yüklü olduğundan emin olun.
    - Proje dizininde aşağıdaki komutu çalıştırarak bağımlılıkları yükleyin:
        ```bash
        dotnet restore
        ```

3. **Veritabanı Kurulumu:**
    - Bu proje için Debeever kullanılmıştır. Debeever'ı kurun ve yapılandırın.
    - Veritabanı bağlantı ayarlarını `appsettings.json` dosyasında yapılandırın.
    - Debeever üzerinden gerekli tabloları oluşturun ve yapılandırmaları yapın.

## Kullanım
1. **Proje Dizinine Gidin:**
    ```bash
    cd Ucus-Rezervasyon-main/UcakRezervasyon
    ```

2. **Projeyi Derleyin ve Çalıştırın:**
    ```bash
    dotnet run
    ```

3. **Uygulamayı Kullanma:**
    - Uygulama açıldığında, ana menüde uçuş arama, rezervasyon yapma ve rezervasyon yönetimi seçenekleri bulunacaktır.
    - Kullanıcı, uçuş arama ekranında belirli kriterlere göre uçuşları arayabilir.
    - Rezervasyon yapma ekranında, seçilen uçuş için rezervasyon işlemi gerçekleştirilir.
    - Rezervasyon yönetimi ekranında, mevcut rezervasyonlar görüntülenebilir, güncellenebilir veya iptal edilebilir.

## Proje Yapısı
- **UcakRezervasyon.sln:** Projenin çözüm dosyası.
- **UcakRezervasyon.csproj:** Projenin yapılandırma dosyası.
- **Form1.cs:** Ana form dosyası, kullanıcı arayüzü ve ana fonksiyonları içerir.
- **Lokasyon.cs:** Uçuş lokasyonları ile ilgili işlemleri yönetir.
- **Rezervasyon.cs:** Rezervasyon işlemleri ve bilgilerini yönetir.
- **Ucak.cs:** Uçak bilgilerini ve işlemlerini yönetir.
- **Models:** Proje içindeki veri modellerini içerir.
- **Properties:** Proje ayarları ve kaynak dosyalarını içerir.
- **Resources:** Proje içindeki statik kaynak dosyalarını içerir.

## Katkıda Bulunma
Projeye katkıda bulunmak isterseniz, aşağıdaki adımları izleyin:
1. Bu projeyi forklayın.
2. Yeni bir dal (`feature-branch`) oluşturun.
3. Değişikliklerinizi ekleyin (`git add .`).
4. Commit yapın (`git commit -m 'Add new feature'`).
5. Dalınıza push yapın (`git push origin feature-branch`).
6. Bir Pull Request açın.

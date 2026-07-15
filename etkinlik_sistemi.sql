-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 03 Haz 2026, 03:01:41
-- Sunucu sürümü: 10.4.32-MariaDB
-- PHP Sürümü: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `etkinlik_sistemi`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `etkinlikler`
--

CREATE TABLE `etkinlikler` (
  `id` int(11) NOT NULL,
  `etkinlik_adi` varchar(150) DEFAULT NULL,
  `etkinlik_turu` varchar(50) DEFAULT NULL,
  `kategori` varchar(50) DEFAULT NULL,
  `aciklama` text DEFAULT NULL,
  `etkinlik_tarihi` date DEFAULT NULL,
  `etkinlik_saati` time DEFAULT NULL,
  `sure` varchar(50) DEFAULT NULL,
  `etkinlik_konumu` varchar(200) DEFAULT NULL,
  `kontenjan` int(11) DEFAULT NULL,
  `katilimci_sayisi` int(11) DEFAULT NULL,
  `durum` varchar(50) DEFAULT NULL,
  `katilim_turu` varchar(50) DEFAULT NULL,
  `sorumlu` varchar(100) DEFAULT NULL,
  `iletisim` varchar(100) DEFAULT NULL,
  `fakulte` varchar(100) DEFAULT NULL,
  `one_cikan` tinyint(1) DEFAULT NULL,
  `afis` varchar(255) DEFAULT NULL,
  `olusturma_tarihi` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `etkinlikler`
--

INSERT INTO `etkinlikler` (`id`, `etkinlik_adi`, `etkinlik_turu`, `kategori`, `aciklama`, `etkinlik_tarihi`, `etkinlik_saati`, `sure`, `etkinlik_konumu`, `kontenjan`, `katilimci_sayisi`, `durum`, `katilim_turu`, `sorumlu`, `iletisim`, `fakulte`, `one_cikan`, `afis`, `olusturma_tarihi`) VALUES
(1, 'Bahar Şenliği Konseri', 'Konser', 'Sosyal', 'Üniversite bahar konseri etkinliği.', '2026-05-05', '20:00:00', '2 Saat', 'Başkent Üniversitesi', 500, 320, 'Aktif', 'Ücretsiz', 'Ayşe Yılmaz', 'etkinlik@baskent.edu.tr', 'Güzel Sanatlar Fakültesi', 1, 'images.jpg', '2026-05-25 18:45:47'),
(3, 'Girişimcilik Söyleşisi', 'Söyleşi', 'Kariyer', 'Başarılı girişimcilerle sohbet etkinliği.', '2026-06-17', '15:00:00', '2 Saat', 'Başkent Üniversitesi', 200, 95, 'Aktif', 'Ücretsiz', 'Elif Demir', 'kariyer@baskent.edu.tr', 'İİBF', 0, '', '2026-05-25 18:45:47'),
(4, 'PHP Workshop', 'Workshop', 'Teknoloji', 'PHP ve MySQL eğitimi.', '2026-06-20', '11:00:00', '4 Saat', 'Bilgisayar Laboratuvarı', 100, 70, 'Aktif', 'Ücretsiz', 'Arda Çelik', 'php@baskent.edu.tr', 'Mühendislik Fakültesi', 1, 'php.jpg', '2026-05-25 18:45:47'),
(5, 'Komedi Tiyatrosu', 'Tiyatro', 'Sanat', 'Öğrenci tiyatro gösterisi.', '2026-06-25', '19:00:00', '2 Saat', 'Başkent Üniversitesi', 250, 210, 'Yaklaşıyor', 'Davetiyeli', 'Zeynep Aksoy', 'tiyatro@baskent.edu.tr', 'İletişim Fakültesi', 0, '', '2026-05-25 18:45:47'),
(6, 'Enerji Semineri', 'Seminer', 'Akademik', 'Enerji sistemleri semineri.', '2026-06-28', '14:00:00', '2 Saat', 'Başkent Üniversitesi', 180, 100, 'Aktif', 'Ücretsiz', 'Prof. Dr. Ahmet Koç', 'enerji@baskent.edu.tr', 'Mühendislik Fakültesi', 0, '', '2026-05-25 18:45:47'),
(7, 'Rock Festivali', 'Konser', 'Sosyal', 'Üniversite rock festivali.', '2026-07-01', '21:00:00', '3 Saat', 'Başkent Üniversitesi Açık Alan', 600, 480, 'Aktif', 'Ücretsiz', 'Can Öztürk', 'rock@baskent.edu.tr', 'Güzel Sanatlar Fakültesi', 1, '', '2026-05-25 18:45:47'),
(8, 'Sürdürülebilir Enerji', 'Konferans', 'Akademik', 'Sürdürülebilir enerji konferansı.', '2026-07-03', '10:00:00', '3 Saat', 'Konferans Salonu', 350, 250, 'Yaklaşıyor', 'Ücretsiz', 'Dr. Selin Kara', 'surdurulebilir@baskent.edu.tr', 'Mühendislik Fakültesi', 0, '', '2026-05-25 18:45:47'),
(9, 'Yaz Festivali', 'Festival', 'Sosyal', 'Yaz dönemi öğrenci festivali.', '2026-07-05', '18:00:00', '5 Saat', 'Başkent Üniversitesi', 1000, 750, 'Aktif', 'Ücretsiz', 'Mert Aslan', 'festival@baskent.edu.tr', 'Rektörlük', 1, '', '2026-05-25 18:45:47'),
(10, 'Basketbol Turnuvası', 'Spor', 'Spor', 'Fakülteler arası basketbol turnuvası.', '2026-07-10', '16:00:00', '4 Saat', 'Spor Salonu', 400, 260, 'Aktif', 'Ücretsiz', 'Burak Yıldız', 'spor@baskent.edu.tr', 'Spor Bilimleri Fakültesi', 0, '', '2026-05-25 18:45:47'),
(11, 'Akustik Gece', 'Konser', 'Sosyal', 'Akustik müzik gecesi.', '2026-07-12', '20:30:00', '2 Saat', 'Başkent Üniversitesi', 450, 290, 'Aktif', 'Ücretsiz', 'Deniz Arslan', 'akustik@baskent.edu.tr', 'Güzel Sanatlar Fakültesi', 1, '', '2026-05-25 18:45:47'),
(12, 'Kariyer Günleri', 'Söyleşi', 'Kariyer', 'Kariyer planlama etkinliği.', '2026-07-15', '11:00:00', '3 Saat', 'Başkent Üniversitesi', 220, 140, 'Yaklaşıyor', 'Ücretsiz', 'Buse Yalçın', 'kariyer@baskent.edu.tr', 'İİBF', 0, '', '2026-05-25 18:45:47'),
(13, 'C# Semineri', 'Seminer', 'Teknoloji', 'C# programlama semineri.', '2026-07-18', '13:30:00', '2 Saat', 'Bilgisayar Laboratuvarı', 150, 90, 'Aktif', 'Ücretsiz', 'Emre Çetin', 'csharp@baskent.edu.tr', 'Mühendislik Fakültesi', 0, '', '2026-05-25 18:45:47'),
(14, 'Teknoloji Festivali', 'Festival', 'Teknoloji', 'Teknoloji projeleri festivali.', '2026-07-20', '17:00:00', '5 Saat', 'Başkent Üniversitesi', 900, 600, 'Aktif', 'Ücretsiz', 'Seda Kılıç', 'techfest@baskent.edu.tr', 'Mühendislik Fakültesi', 1, '', '2026-05-25 18:45:47'),
(15, 'Film Gösterimi', 'Sinema', 'Sanat', 'Açık hava film gösterimi.', '2026-07-22', '21:00:00', '2 Saat', 'Açık Hava Alanı', 300, 200, 'Aktif', 'Ücretsiz', 'Ceren Aydın', 'sinema@baskent.edu.tr', 'İletişim Fakültesi', 0, '', '2026-05-25 18:45:47'),
(16, 'Robotik Atölyesi', 'Workshop', 'Teknoloji', 'Robotik kodlama eğitimi.', '2026-07-24', '10:00:00', '4 Saat', 'Mühendislik Laboratuvarı', 80, 55, 'Yaklaşıyor', 'Ücretsiz', 'Murat Demir', 'robotik@baskent.edu.tr', 'Mühendislik Fakültesi', 1, '', '2026-05-25 18:45:47'),
(17, 'Sağlıklı Yaşam', 'Seminer', 'Sağlık', 'Sağlıklı yaşam semineri.', '2026-07-26', '12:00:00', '2 Saat', 'Başkent Üniversitesi', 200, 120, 'Aktif', 'Ücretsiz', 'Dr. Ece Şahin', 'saglik@baskent.edu.tr', 'Sağlık Bilimleri Fakültesi', 0, '', '2026-05-25 18:45:47'),
(18, 'Fotoğrafçılık Eğitimi', 'Workshop', 'Sanat', 'Temel fotoğrafçılık eğitimi.', '2026-07-28', '14:00:00', '3 Saat', 'Başkent Üniversitesi', 100, 65, 'Aktif', 'Ücretsiz', 'Ali Can', 'foto@baskent.edu.tr', 'Güzel Sanatlar Fakültesi', 0, '', '2026-05-25 18:45:47'),
(19, 'Mezunlar Buluşması', 'Söyleşi', 'Kariyer', 'Mezunlarla deneyim paylaşımı.', '2026-07-30', '18:00:00', '2 Saat', 'Başkent Üniversitesi', 350, 230, 'Yaklaşıyor', 'Davetiyeli', 'Nisa Ergin', 'mezun@baskent.edu.tr', 'Rektörlük', 0, '', '2026-05-25 18:45:47'),
(20, 'Manga Konseri', 'Konser', 'Sosyal', 'Kampüs konser etkinliği.', '2026-08-01', '20:00:00', '2 Saat', 'Başkent Üniversitesi Açık Alan', 700, 620, 'Aktif', 'Ücretsiz', 'Eren Koç', 'konser@baskent.edu.tr', 'Rektörlük', 1, '', '2026-05-25 18:45:47'),
(21, 'Veri Bilimi Konferansı', 'Konferans', 'Teknoloji', 'Veri bilimi konferansı.', '2026-08-03', '11:00:00', '3 Saat', 'Konferans Salonu', 320, 180, 'Aktif', 'Ücretsiz', 'Dr. Deniz Mutlu', 'data@baskent.edu.tr', 'Mühendislik Fakültesi', 1, '', '2026-05-25 18:45:47'),
(22, 'Futbol Turnuvası', 'Spor', 'Spor', 'Bölümler arası futbol turnuvası.', '2026-08-05', '17:00:00', '4 Saat', 'Futbol Sahası', 500, 410, 'Yaklaşıyor', 'Ücretsiz', 'Onur Kaya', 'futbol@baskent.edu.tr', 'Spor Bilimleri Fakültesi', 0, '', '2026-05-25 18:45:47'),
(23, 'Diksiyon Eğitimi', 'Workshop', 'Kişisel Gelişim', 'Diksiyon eğitimi etkinliği.', '2026-08-07', '13:00:00', '2 Saat', 'Başkent Üniversitesi', 120, 75, 'Aktif', 'Ücretsiz', 'Melis Güneş', 'diksiyon@baskent.edu.tr', 'İletişim Fakültesi', 0, '', '2026-05-25 18:45:47'),
(24, 'Hukuk Paneli', 'Panel', 'Akademik', 'Hukukta yapay zeka paneli.', '2026-08-09', '15:00:00', '2 Saat', 'Konferans Salonu', 250, 160, 'Yaklaşıyor', 'Ücretsiz', 'Prof. Dr. Kerem Acar', 'hukuk@baskent.edu.tr', 'Hukuk Fakültesi', 0, '', '2026-05-25 18:45:47'),
(25, 'Dans Gösterisi', 'Gösteri', 'Sanat', 'Dans topluluğu gösterisi.', '2026-08-11', '19:30:00', '1.5 Saat', 'Başkent Üniversitesi', 280, 240, 'Aktif', 'Ücretsiz', 'İrem Polat', 'dans@baskent.edu.tr', 'Güzel Sanatlar Fakültesi', 1, '', '2026-05-25 18:45:47'),
(26, 'Siber Güvenlik', 'Seminer', 'Teknoloji', 'Siber güvenlik semineri.', '2026-08-13', '10:30:00', '2 Saat', 'Bilgisayar Laboratuvarı', 160, 110, 'Aktif', 'Ücretsiz', 'Dr. Alper Tunc', 'siber@baskent.edu.tr', 'Mühendislik Fakültesi', 1, '', '2026-05-25 18:45:47'),
(27, 'Kitap Buluşması', 'Söyleşi', 'Kültür', 'Kitap değerlendirme etkinliği.', '2026-08-15', '14:30:00', '1.5 Saat', 'Kütüphane', 100, 45, 'Aktif', 'Ücretsiz', 'Sıla Yıldırım', 'kitap@baskent.edu.tr', 'Fen Edebiyat Fakültesi', 0, '', '2026-05-25 18:45:47'),
(28, 'Kampüs Oryantasyonu', 'Seminer', 'Akademik', 'Yeni öğrenci oryantasyonu.', '2026-08-18', '09:30:00', '3 Saat', 'Başkent Üniversitesi', 800, 500, 'Yaklaşıyor', 'Ücretsiz', 'Öğrenci İşleri', 'oryantasyon@baskent.edu.tr', 'Rektörlük', 1, '', '2026-05-25 18:45:47'),
(29, 'Mobil Uygulama Atölyesi', 'Workshop', 'Teknoloji', 'Mobil uygulama geliştirme eğitimi.', '2026-08-20', '12:00:00', '4 Saat', 'Bilgisayar Laboratuvarı', 90, 60, 'Aktif', 'Ücretsiz', 'Tolga Sarı', 'mobil@baskent.edu.tr', 'Mühendislik Fakültesi', 0, '', '2026-05-25 18:45:47'),
(30, 'Kapanış Festivali', 'Festival', 'Sosyal', 'Dönem sonu festivali.', '2026-08-25', '18:30:00', '5 Saat', 'Başkent Üniversitesi Açık Alan', 1200, 850, 'Yaklaşıyor', 'Ücretsiz', 'Öğrenci Konseyi', 'kapanis@baskent.edu.tr', 'Rektörlük', 1, '', '2026-05-25 18:45:47'),
(32, 'dasda', 'Konferans', 'Akademik', 'dad', '2026-06-03', '15:00:00', '2', 'dsadas', 123, NULL, 'Ücretsiz', 'Aktif, Yaklaşıyor', 'dada', '46565465', 'dasda', 0, '', '2026-06-02 23:14:48'),
(33, 'aa', 'Konser ', 'Sosyal', 'aaa', '2026-06-03', '12:30:00', '2', 'adas', 123, NULL, 'Ücretsiz', 'Aktif, Yaklaşıyor', 'dsad', '123', 'dasda', 0, '', '2026-06-03 00:03:06');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `gorusler`
--

CREATE TABLE `gorusler` (
  `id` int(11) NOT NULL,
  `kullanici_id` int(11) DEFAULT NULL,
  `etkinlik_id` int(11) DEFAULT NULL,
  `gorus` text DEFAULT NULL,
  `puan` int(11) DEFAULT NULL,
  `tarih` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `gorusler`
--

INSERT INTO `gorusler` (`id`, `kullanici_id`, `etkinlik_id`, `gorus`, `puan`, `tarih`) VALUES
(1, 5, 2, 'zeynep', 5, '2026-06-02 14:17:38'),
(2, 2, 32, 'Güzel bir konserdi', 5, '2026-06-03 00:31:43'),
(3, 2, 33, 'Güzel bir etkinlikti', 5, '2026-06-03 00:33:36');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `katilimlar`
--

CREATE TABLE `katilimlar` (
  `id` int(11) NOT NULL,
  `kullanici_id` int(11) DEFAULT NULL,
  `etkinlik_id` int(11) DEFAULT NULL,
  `katilim_tarihi` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `katilimlar`
--

INSERT INTO `katilimlar` (`id`, `kullanici_id`, `etkinlik_id`, `katilim_tarihi`) VALUES
(1, 3, 1, '2026-06-02 11:39:26'),
(2, 5, 2, '2026-06-02 14:17:26'),
(3, 2, 32, '2026-06-02 23:44:48'),
(4, 2, 33, '2026-06-03 00:33:15');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kullanicilar`
--

CREATE TABLE `kullanicilar` (
  `id` int(11) NOT NULL,
  `kullanici_adi` varchar(50) NOT NULL,
  `sifre` varchar(50) NOT NULL,
  `yetki` varchar(30) DEFAULT 'admin'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `kullanicilar`
--

INSERT INTO `kullanicilar` (`id`, `kullanici_adi`, `sifre`, `yetki`) VALUES
(1, 'admin', '12345', 'admin'),
(2, 'zeynep', '12345', 'ogrenci'),
(3, 'ogrenci', '12345', 'ogrenci'),
(4, 'zeynep', '12345', 'ogrenci'),
(5, 'ogrenci2', '12345', 'ogrenci');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `etkinlikler`
--
ALTER TABLE `etkinlikler`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `gorusler`
--
ALTER TABLE `gorusler`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `katilimlar`
--
ALTER TABLE `katilimlar`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `tek_katilim` (`kullanici_id`,`etkinlik_id`);

--
-- Tablo için indeksler `kullanicilar`
--
ALTER TABLE `kullanicilar`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `etkinlikler`
--
ALTER TABLE `etkinlikler`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- Tablo için AUTO_INCREMENT değeri `gorusler`
--
ALTER TABLE `gorusler`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Tablo için AUTO_INCREMENT değeri `katilimlar`
--
ALTER TABLE `katilimlar`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Tablo için AUTO_INCREMENT değeri `kullanicilar`
--
ALTER TABLE `kullanicilar`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

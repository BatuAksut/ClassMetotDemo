
using ClassMetotDemo;



Musteri musteri = new Musteri();

musteri.Ad = "Ahmet";
musteri.Soyad = "Türkoğlu";
musteri.Id = 1;

MusteriManager musteriManager = new MusteriManager();

musteriManager.Ekle(musteri);
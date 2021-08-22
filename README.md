# Proje Yapısı


### 1.Bir filmin sahip olması gereken özellikleri şu şekildedir:

Film Adı,
Film Yılı,
Film Türü,
Yönetmen,
Oyuncular,
Fiyat,
Yönetmenler ve oyuncular ayrı tutulmalıdır. Bir oyuncu aynı zamanda yönetmen de olabilir, ama bunlar iki ayrı yapıdır.
___
### 2.Oyuncuların sahip olması gereken özellikler temelde şu şekildedir :

İsim,
Soyisim,
Oynadığı filmler
Bir filmde birden fazla oyuncu oynayabilir, bir oyuncunun da birden fazla filmi olabilir.
___
### 3.Yönetmenlerin sahip olması gereken özellikler temelde şu şekildedir:

İsim,
Soyisim,
Yönettiği filmler
___
### 4.Uygulama içerisinde bir de Customer rolü olmalıdır. Özellikleri ise temelde şu şekildedir:

İsim,
Soyisim,
Satın aldığı filmler,
Favori türler
Müşterinin birden fazla favori film türü olabilir. Satın aldığı bir türü tekrar satın alabilir. Buraya bir kısıtlama koymaya gerek yok.
___
### 5.Customer için bir login endpoint'i yaratılmalıdır. Yetkisiz kullanıcı uygulama içerisinden satın alma işlemi yapamamalı.
___
### 6.Müşterilerin satın aldıkları filmler siparişlerim gibi bir yapı içerisinde tutulmalıdır. Temel özellikleri ise şu şekilde olmalıdır:

Satın alan müşteri,
Satın alınan film,
Fiyat,
Satın alma tarihi

___
# Uygulama Gereksinimleri
___
### 1.Film Ekleme/Silme/Güncelleme/Listeleme
___
### 2.Müşteri Ekleme/Silme
___
### 3.Oyuncu Ekleme/Silme/Güncelleme/Listeleme
___
### 4.Yönetmen Ekleme/Silme/Güncelleme/Listeleme/
___
### 5.Film Satın Alma
Müşteri istediği bir filmi uygulama üzerinden satın alabilir.
___
### 6.Müşteri bazlı satın alma verisinin listelenmesi. Satın alınan filmler daha sonra sistemden silinebilir. Bu sipariş datasını etkilememeli. Bu durumu sağlamak için film verileri hard olarajk silinmemelidir. Bir Aktif-Pasif özelliği ile yönetilebilir.
___
### 7.Film türleri uygulama çalıştırıldığından varsayılan olarak yaratılabilir. Servisler ile yönetilmesine gerek yoktur.
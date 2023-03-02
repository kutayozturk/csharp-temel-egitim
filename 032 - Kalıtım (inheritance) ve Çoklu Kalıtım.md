### Kalıtım (inheritance)
Nesneler arası ilişki kurmamızı sağlayan bir tekniktir.
Kalıtım ortak özelliklere sahip birden fazla class yapısını birbiri ile ilişkilendirmede kullanılır.

Örneğin;
Bir demirbaş isimli bir class'ımız olsun. Bu class içerisinde demirbaş'a ait özelikler yer alsın.

Kalıtımın Kullanım Ama
```
class Demirbas
{
    private int demirbasNo;
    private string zimmetli;
    private string bina;
    private int odaNo;
}
```
Demirbas isimli class'ta yer alan bu özellikler, aslında demirbaş listesine girmiş
diğer nesneler içinde aynıdır. Örneğin bir **Bilgisayar** ve **Projeksiyon** cihazımız olsun.
Bunlara ayrı ayrı class'lar tanımlayalım.
```
class Kitap
{
    private string ISBN;
    private DataTime basimTarihi;

    private int demirbasNo;
    private string zimmetli;
    private string bina;
    private int odaNo;
}

class Bilgisayar
{
    private int demirbasNo;
    private string zimmetli;
    private string bina;
    private int odaNo;
    
    private DateTime AlinmaTarihi,
    private int ramKapasitesi;
    private string islemci;
}

class Projeksiyon
{
    private int demirbasNo;
    private string zimmetli;
    private string bina;
    private int odaNo;
    
    private string marka;
    private string cozunurluk;
}
```
Yukarıda görüldüğü üzere, **Kitap, Bilgisayar** ve **Projeksiyon** isimler class yapılarının içerisinde aslında **Demirbas** class'ına ait olan özelliklerde eklenmiştir. Bu gibi durumlarda, ortak özellikler Demirbas class'ında toplandığı için, kalıtım uygulanacak olan class'a, katılım özelliklerini içeren class **":"** ifadesi iel bağlanlamılıdır.

yani **class Bilgisayar : Demirbas** şeklinde olmalıdır.

```

class Kitap : Demirbas
{
    private string ISBN;
    private DataTime basimTarihi;
}

class Bilgisayar : Demirbas // Bilgisayar class'ına Demirbas class'ı kalıtım yoluyla aktarılmıştır.
{
    
    private DateTime AlinmaTarihi,
    private int ramKapasitesi;
    private string islemci;
    
}

class Projeksiyon : Demirbas    // Projeksiyon class'ına Demirbas class'ı kalıtım yoluyla aktarılmıştır.
{
    
    private string marka;
    private string cozunurluk;
}
```
Şeklinde tanımlayabiliriz.

![](https://i.imgur.com/seGzg4w.png)

> :warning: **Not:** Bir class'a birden fazla Kalıtım Uygulanamaz.
:x: **class Projeksiyon : Bilgisayar , Demirbas** 
:x: **class Projeksiyon : Bilgisayar : Demirbas** 
gibi ifadeler yanlış bir ifadelerdir ve kullanılamazlar.

---
### Çoklu Kalıtım
:star: C++ ve C# programlama dillerinde **çoklu kalıtım** özelliği aslında vardır.
Örneğin, bir Ev class'ımız olsun ve Ev'in genel özelliklerini içersin.

```
class Ev
{
    public string renk;
    public int odaSayisi;
    public int balkonSayisi;
}
```
***Bu örnekte üyelerin public olduğuna dikkat ediniz. public yapılmak zorunda değildir. Anlaşılması kolay olması açısından public olarak güncelledim.***
Şimdi de farklı ev tiplerimiz olsun, örneğin **Müstakil** ve **Apartman Dairesi** şeklinde.
```
class Mustakil
{
    public bool bahceVarMi;
}

class ApartmanDairesi
{
    public bool asansorVarMi;
}
```
Her iki ev tipi içinde ayrı ayrı class'lar oluşturduk.

Şimdi çoklu kalıtım yoluyla çalışalım.

```
class Mustakil : Ev // Mustakil class'ı EV class'ından miras almıştır.
{
    public bool bahceVarMi;
}

class ApartmanDairesi : Mustakil // Apartman Dairesi class'ı Mustakil class'ından miras almıştır.
{
    public bool asansorVarMi;
}
```
Bu durumda, ApartmanDairesi class'ından **hem Mustakil** class'ına **hem de Ev** class'ına **erişim sağlabilir.**
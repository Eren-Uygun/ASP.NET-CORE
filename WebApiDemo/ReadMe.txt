-Bu projemizde world database üzerinde crud iþlemleri yapýyoruz.
-World db nin içeriði WorldDb.txt dosyasýnda mevcuttur.
-Dikkat edilmesi gereken durum country tablosundaki null alanlar sebebiyle veri çekme durumu çalýþmayacaktýr. Null alanlarý veri tiplerine göre doldurmanýz gerekmektedir.
-.Net 5.0 ile beraber Api Projesi oluþtururken Swagger Api'yi ekleyebiliyoruz.Swagger api ile controller'e yazdýðýmýz







1.Api katmanýmýzý oluþturuyoruz.
1.1-Controllers klasörü yok ise Controllers adýndanda bir klasör oluþturuyoruz.
1.1.1-CitiesController adýnda bir api controller oluþturuyoruz.
1.1.2-CitiesController'in içine Crud metotlarýmýzý yazýyoruz.
1.2-CountriesContoller adýnda bir api controller oluþturuyoruz.
1.2.1-CountriesController'in içine metotlarýmýzý yazýyoruz.
1.3-CountryLanguageController adýnda bir api controller oluþturuyoruz.
1.3.1-CountryLanguageController'in içine metrorlarýmýzý yazýyoruz.


2.DataAccess katmanýmýzý oluþturuyoruz.
2.1-Context adýnda bir dosya oluþturuyoruz.
2.1.1-Context klasörümüzün içine ProjectContext adýnda bir class oluþturuyoruz.
2.1.2-Manage nuget packages bölümünden EntityFrameworkCore.SqlServer paketini yükleyip ProjectContext class'ýmýzý DbContext ile extend ediyoruz.

3.Entities katmanýmýzý oluþturuyoruz.
3.1-Entity Adýnda bir klasör oluþturuyoruz.
3.1.1-Entity klasörü içine city , country ve countrylanguage adlarýnda 3 class oluþturuyoruz.Class içindeki field'larý oluþtururken veri tabanýndaki isimlendirmeler ile ayný olmasýna dikkat ediniz.


4.Business katmanýmýzý oluþturuyoruz.
4.1-BaseRepository adýnda bir klasör oluþturuyoruz.
4.1.1-BaseRepository klasörünün içine Abstract ve concrete dosyalarýný oluþturuyoruz.
4.1.1-Abstract klasörüne IBaseService.cs interface , concrete klasörüne BaseManager class'ý oluþturuyoruz.
4.2-Repository adýnda bir klasör oluþturuyoruz ve içerisine abstract ve concrete adýnda 2 adet dosya oluþturuyoruz.
4.2.1-Abstract içerisine ICityService , ICountryService , ICountryLanguageService adýnda 3 adet interface oluþturuyoruz.bunlara IBaseService den miras veriyoruz.
4.2.2-Concrete dosyasý içerisine CityManager , CountryManager, CountryLanguageManager class'larý oluþturuyoruz. BaseManager dan ve ilgili interfacelerden miras veriyoruz.
4.3-Business katmanýnda oluþturduðumuz interface ve classlarý API katmanýmýzdaki startup.cs klasörüne eklememiz gerekiyor.

5-Projemizi Test ediyoruz.
-Bu projemizde world database �zerinde crud i�lemleri yap�yoruz.
-World db nin i�eri�i WorldDb.txt dosyas�nda mevcuttur.
-Dikkat edilmesi gereken durum country tablosundaki null alanlar sebebiyle veri �ekme durumu �al��mayacakt�r. Null alanlar� veri tiplerine g�re doldurman�z gerekmektedir.
-.Net 5.0 ile beraber Api Projesi olu�tururken Swagger Api'yi ekleyebiliyoruz.Swagger api ile controller'e yazd���m�z







1.Api katman�m�z� olu�turuyoruz.
1.1-Controllers klas�r� yok ise Controllers ad�ndanda bir klas�r olu�turuyoruz.
1.1.1-CitiesController ad�nda bir api controller olu�turuyoruz.
1.1.2-CitiesController'in i�ine Crud metotlar�m�z� yaz�yoruz.
1.2-CountriesContoller ad�nda bir api controller olu�turuyoruz.
1.2.1-CountriesController'in i�ine metotlar�m�z� yaz�yoruz.
1.3-CountryLanguageController ad�nda bir api controller olu�turuyoruz.
1.3.1-CountryLanguageController'in i�ine metrorlar�m�z� yaz�yoruz.


2.DataAccess katman�m�z� olu�turuyoruz.
2.1-Context ad�nda bir dosya olu�turuyoruz.
2.1.1-Context klas�r�m�z�n i�ine ProjectContext ad�nda bir class olu�turuyoruz.
2.1.2-Manage nuget packages b�l�m�nden EntityFrameworkCore.SqlServer paketini y�kleyip ProjectContext class'�m�z� DbContext ile extend ediyoruz.

3.Entities katman�m�z� olu�turuyoruz.
3.1-Entity Ad�nda bir klas�r olu�turuyoruz.
3.1.1-Entity klas�r� i�ine city , country ve countrylanguage adlar�nda 3 class olu�turuyoruz.Class i�indeki field'lar� olu�tururken veri taban�ndaki isimlendirmeler ile ayn� olmas�na dikkat ediniz.


4.Business katman�m�z� olu�turuyoruz.
4.1-BaseRepository ad�nda bir klas�r olu�turuyoruz.
4.1.1-BaseRepository klas�r�n�n i�ine Abstract ve concrete dosyalar�n� olu�turuyoruz.
4.1.1-Abstract klas�r�ne IBaseService.cs interface , concrete klas�r�ne BaseManager class'� olu�turuyoruz.
4.2-Repository ad�nda bir klas�r olu�turuyoruz ve i�erisine abstract ve concrete ad�nda 2 adet dosya olu�turuyoruz.
4.2.1-Abstract i�erisine ICityService , ICountryService , ICountryLanguageService ad�nda 3 adet interface olu�turuyoruz.bunlara IBaseService den miras veriyoruz.
4.2.2-Concrete dosyas� i�erisine CityManager , CountryManager, CountryLanguageManager class'lar� olu�turuyoruz. BaseManager dan ve ilgili interfacelerden miras veriyoruz.
4.3-Business katman�nda olu�turdu�umuz interface ve classlar� API katman�m�zdaki startup.cs klas�r�ne eklememiz gerekiyor.

5-Projemizi Test ediyoruz.
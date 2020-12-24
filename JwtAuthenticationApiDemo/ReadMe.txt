Bu projemizin amac� sisteme login olan bir kullan�c�n�n login oldukdan sonra ald��� token key ile i�lem yapabilmesidir. .Net 5.0'�n avantajlar�ndan biri Swagger api supportu proje ba�lang�c�nda otomatik eklenebiliyor.
Swagger api Controllerdaki actionlar� kolayca test etmemizi sa�layan bir aray�zd�r.Bu Projede rahat test edebilmek i�in swagger api ye Authorize b�l�m� eklenmi�tir.Yani Tokenimizi oraya Bearer TokenName �eklinde yaz�yoruz.Ve authorize gerektiren action method'u kullanabiliyoruz.

1-Models klas�r� olu�turuyoruz.
1.1-Models klas�r� i�ine UserModel ad�nda bir class olu�turuyoruz.
1.1.1-UserModel class'�n�n i�ine Username , Password alanlar� olu�turuyoruz.

2.Controllers dosyas� i�ine authcontroller ad�nda bir api controller a��yoruz.
2.1-Nuget packages �zerinden Microsoft.IdentityModel.JsonWebTokens ve System.IdentityModel.Tokens.jwt paketlerini y�kl�yoruz.
2.2-AuthController'in i�ine UserModel class'�n�n i�indeki alanlar� kullanan ve kullan�c� olarak d�nen bir private metot yaz�yoruz.
2.3-AuthController'in i�ine Jwt Token olarak d�nen bir private metot daha yaz�yoruz.
2.4-AuthController'in i�ine bir login metodu yaz�yoruz.
2.5-AuthController'in i�ine test etmek amac�yla bir post i�lemi yaz�yoruz.

Test ediyoruz.
Bu projemizin amacý sisteme login olan bir kullanýcýnýn login oldukdan sonra aldýðý token key ile iþlem yapabilmesidir. .Net 5.0'ýn avantajlarýndan biri Swagger api supportu proje baþlangýcýnda otomatik eklenebiliyor.
Swagger api Controllerdaki actionlarý kolayca test etmemizi saðlayan bir arayüzdür.Bu Projede rahat test edebilmek için swagger api ye Authorize bölümü eklenmiþtir.Yani Tokenimizi oraya Bearer TokenName þeklinde yazýyoruz.Ve authorize gerektiren action method'u kullanabiliyoruz.

1-Models klasörü oluþturuyoruz.
1.1-Models klasörü içine UserModel adýnda bir class oluþturuyoruz.
1.1.1-UserModel class'ýnýn içine Username , Password alanlarý oluþturuyoruz.

2.Controllers dosyasý içine authcontroller adýnda bir api controller açýyoruz.
2.1-Nuget packages üzerinden Microsoft.IdentityModel.JsonWebTokens ve System.IdentityModel.Tokens.jwt paketlerini yüklüyoruz.
2.2-AuthController'in içine UserModel class'ýnýn içindeki alanlarý kullanan ve kullanýcý olarak dönen bir private metot yazýyoruz.
2.3-AuthController'in içine Jwt Token olarak dönen bir private metot daha yazýyoruz.
2.4-AuthController'in içine bir login metodu yazýyoruz.
2.5-AuthController'in içine test etmek amacýyla bir post iþlemi yazýyoruz.

Test ediyoruz.
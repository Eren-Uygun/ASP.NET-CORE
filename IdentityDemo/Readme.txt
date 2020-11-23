Bu �rne�imizde Identity Entityframework yap�s� kullanarak login ve register i�lemleri yapaca��z.

1-Context ad�nda yeni bir klas�r a��yoruz i�ine ProjectContext ad�nda bir class ekliyoruz.
2-Tools sekmesinden Nuget Manager b�l�m�ne gelip Manage NuGet Package for solution'a t�kl�yoruz.Microsoft.EntityFramework.Core , Microsoft.EntityFramework.Core.SqlServer, Microsoft.EntityFramework.Core.Tools , Microsoft.AspNet.Identity.EntityFrameworkCore paketlerini y�kl�yoruz.
3-Models klas�r�ne AppUser ad�nda bir class olu�turuyoruz ve onu IdentityUser ile extend ediyoruz. IdentityUser class'�nda olmayan �zellikleri eklemek i�in bu yola ba�vurabiliriz.
4-Models klas�r�ne LoginVM ve RegisterVM , RegisterEditVM classlar�n� olu�turuyorup i�lerini dolduruyoruz.Login ve register ve edit i�lemlerinde bu classlara yazd���m�z alanlar� kullanaca��z.
4-ProjetContext klas�r�ne gerid�n�yoruz ve ProjectContext:IdentityDbContext<AppUser> yazarak projemizde Identity toollar�n� appuser class�nda kullanaca��m�z� belirtiyoruz.
5-Startup.cs dosyam�za 'DefaultConnection' adl� bir ba�lant� sat�r�m�z oldu�unu belirtiyoruz.Appsettings.json klas�r�ne veri taban� ba�lant� yolumuzu ad� 'DefaultConnection' olacak �ekilde yaz�yoruz.
6-Add-Migration ve update database yap�p veri taban�m�z� olu�turuyoruz.
7-Controllers dosyas�na AccountController ad�nda bi Controller olu�turuyoruz. Buraya Login , LogOut , Register , Edit i�lemlerimizi yazaca��z.
8-Controllerdaki i�lemlerden sonra Views/Shared klas�r�nde _layout.cshtml dosyam�z� biri login oldu�unda kullan�c� ad�n� ve logout buttonunu , olmad���nda ise login ve Register buttonlar�n� g�sterecek �ekilde ayarl�yoruz.
9-Views dosyas�n�n i�ine Account ad�nda bir klas�r a��yoruz ve i�erisine Login.cshtml,Register.cshtml,Edit.cshtml sayfalar�n� yaz�yoruz.
10-Areas ad�nda bir klas�r olu�turup i�ine User ad�nda yeni bir area olu�turuyoruz ve startup.cs ye girip routing ayarlar�n� yap�yoruz. 3.0 da endpoint sistemi�tir scaffoldingReadMe dosyas�ndaki kod sat�r� �al��maz dikkat !!!
11-Yeni olu�turdu�umuz alanda Controllers klas�r�ne yeni bir contoller olu�uturuyoruz.Olu�turdu�umuz controllerin en �st k�sm�na Controllerin ba�l� oldu�u  [Area("User")]  ve [authorize] Data Annotions lar� ekliyoruz.
12-Views/shared klas�r�nde _layout.cshtml ve _ValidationScriptsPartical.cshml dosyalar�n� User areadaki dosyas�n� Views/Shared klas�r�ne kopyal�yoruz.
13-Views klas�r�ndeki _ViewImports.cshtml ve _ViewStart.cshtml dosyalar�n� userdaki views dosyas�n�n i�ine kopyal�yoruz.
14-Projemizi son defa build edip F5 e bas�yoruz.
15-Register butonuna t�klay�p kay�t oluyoruz.Kay�t oldukdan sonra otomatik olarak login sayfas�na y�nlendirileceksiniz.
16-Bilgilerimizi yaz�p login oluyoruz.
17-Giri� yapt�kdan sonra a��lan sayfada Logout butonunun alt�nda kullan�c� ad�m�za t�klayarak edit sayfas�na y�nlendiriliyoruz.
18-�stersek buradan bilgilerimizi editleyip edit tu�una bas�yoruz ve login sayfas�na y�nlendiriliyoruz.






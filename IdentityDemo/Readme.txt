Bu örneðimizde Identity Entityframework yapýsý kullanarak login ve register iþlemleri yapacaðýz.

1-Context adýnda yeni bir klasör açýyoruz içine ProjectContext adýnda bir class ekliyoruz.
2-Tools sekmesinden Nuget Manager bölümüne gelip Manage NuGet Package for solution'a týklýyoruz.Microsoft.EntityFramework.Core , Microsoft.EntityFramework.Core.SqlServer, Microsoft.EntityFramework.Core.Tools , Microsoft.AspNet.Identity.EntityFrameworkCore paketlerini yüklüyoruz.
3-Models klasörüne AppUser adýnda bir class oluþturuyoruz ve onu IdentityUser ile extend ediyoruz. IdentityUser class'ýnda olmayan özellikleri eklemek için bu yola baþvurabiliriz.
4-Models klasörüne LoginVM ve RegisterVM , RegisterEditVM classlarýný oluþturuyorup içlerini dolduruyoruz.Login ve register ve edit iþlemlerinde bu classlara yazdýðýmýz alanlarý kullanacaðýz.
4-ProjetContext klasörüne geridönüyoruz ve ProjectContext:IdentityDbContext<AppUser> yazarak projemizde Identity toollarýný appuser classýnda kullanacaðýmýzý belirtiyoruz.
5-Startup.cs dosyamýza 'DefaultConnection' adlý bir baðlantý satýrýmýz olduðunu belirtiyoruz.Appsettings.json klasörüne veri tabaný baðlantý yolumuzu adý 'DefaultConnection' olacak þekilde yazýyoruz.
6-Add-Migration ve update database yapýp veri tabanýmýzý oluþturuyoruz.
7-Controllers dosyasýna AccountController adýnda bi Controller oluþturuyoruz. Buraya Login , LogOut , Register , Edit iþlemlerimizi yazacaðýz.
8-Controllerdaki iþlemlerden sonra Views/Shared klasöründe _layout.cshtml dosyamýzý biri login olduðunda kullanýcý adýný ve logout buttonunu , olmadýðýnda ise login ve Register buttonlarýný gösterecek þekilde ayarlýyoruz.
9-Views dosyasýnýn içine Account adýnda bir klasör açýyoruz ve içerisine Login.cshtml,Register.cshtml,Edit.cshtml sayfalarýný yazýyoruz.
10-Areas adýnda bir klasör oluþturup içine User adýnda yeni bir area oluþturuyoruz ve startup.cs ye girip routing ayarlarýný yapýyoruz. 3.0 da endpoint sistemiþtir scaffoldingReadMe dosyasýndaki kod satýrý çalýþmaz dikkat !!!
11-Yeni oluþturduðumuz alanda Controllers klasörüne yeni bir contoller oluþuturuyoruz.Oluþturduðumuz controllerin en üst kýsmýna Controllerin baðlý olduðu  [Area("User")]  ve [authorize] Data Annotions larý ekliyoruz.
12-Views/shared klasöründe _layout.cshtml ve _ValidationScriptsPartical.cshml dosyalarýný User areadaki dosyasýný Views/Shared klasörüne kopyalýyoruz.
13-Views klasöründeki _ViewImports.cshtml ve _ViewStart.cshtml dosyalarýný userdaki views dosyasýnýn içine kopyalýyoruz.
14-Projemizi son defa build edip F5 e basýyoruz.
15-Register butonuna týklayýp kayýt oluyoruz.Kayýt oldukdan sonra otomatik olarak login sayfasýna yönlendirileceksiniz.
16-Bilgilerimizi yazýp login oluyoruz.
17-Giriþ yaptýkdan sonra açýlan sayfada Logout butonunun altýnda kullanýcý adýmýza týklayarak edit sayfasýna yönlendiriliyoruz.
18-Ýstersek buradan bilgilerimizi editleyip edit tuþuna basýyoruz ve login sayfasýna yönlendiriliyoruz.






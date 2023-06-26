# libraryProject
 Asp.net Razor library project

-------------------------------------------------------------------USAGE----------------------------------------------------------------------------
1. Open Visual studio package manager console.
2. write: update-database
3. Open sql server object explorer;
   
![Ekran Görüntüsü (15)](https://github.com/HarunEnsar/libraryProject/assets/99835656/aa0db3b3-3c8d-4003-b0db-da5c4db679f6)

4.Click New Query

![image](https://github.com/HarunEnsar/libraryProject/assets/99835656/1ca4a1ff-47ad-42ab-9f77-6bd389149e01)

5.Copy the code below and execute it.;

---------------------------------------------------------------------------------------------------------------------------------------------------
SET IDENTITY_INSERT [dbo].[kitapVerileri] ON
INSERT INTO [dbo].[kitapVerileri] ([kitap_no], [yazar], [baslik], [konu], [digerDetaylar], [bekletmeDurmu], [ResimYolu]) VALUES (1012, N'J. K. Rowling ', N'Harry Potter ve Felsefe Taşı', N'Yetim bir çocuğun büyülü dünyayı keşfetmesini ve kendini Voldemort''un kötülüklerine karşı savaşırken bulmasını anlatır.', N'Sihirli ve esrarengiz bir dünyanın kapısını aralamaya ne dersiniz?', 0, N'fg1mlrn2.jtc.jpg')

INSERT INTO [dbo].[kitapVerileri] ([kitap_no], [yazar], [baslik], [konu], [digerDetaylar], [bekletmeDurmu], [ResimYolu]) VALUES (1014, N'Ray Bradbury', N'Fahrenheit 451', N'Baskıcı bir gelecek toplumunun anlatıldığı bu kitap aynı zamanda distopya olarak da sınıflandırılabilir.', N'1951''de ilk defa basılan ünlü distopik bir bilimkurgu romanıdır.', 0, N'lju2mgzl.1c3.jpg')

INSERT INTO [dbo].[kitapVerileri] ([kitap_no], [yazar], [baslik], [konu], [digerDetaylar], [bekletmeDurmu], [ResimYolu]) VALUES (1015, N'J. R. R. Tolkien', N'Yüzüklerin Efendisi - I - Yüzük Kardeşliği', N'Bir hobbit''in beklenmedik bir maceraya atılıp, Orta Dünya''yı karanlığın güçlerinden korumak için büyük bir yüzük yolculuğuna çıkması.', N'Bu üçlemeden önce okunması faydalı olabilen Hobbit adlı kitapta Tolkien, Hobbitlerin yaşayışlarını ve Gandalf''ın Bilbo''yla ilk tanışmasını anlatmaktadır.', 0, N'md4xt2js.vhl.jpg')

INSERT INTO [dbo].[kitapVerileri] ([kitap_no], [yazar], [baslik], [konu], [digerDetaylar], [bekletmeDurmu], [ResimYolu]) VALUES (1016, N'Frank Herbert ', N'Dune', N'Dune, çeşitli soylu hanedanların gezegen tımarlarını kontrol ettiği feodal bir yıldızlararası toplumun ortasındaki uzak bir gelecekte geçmektedir. ', N'2003 yılında dünyanın en çok satan bilimkurgu romanı olarak gösterildi.', 0, N'4c1wdful.cxz.jpg')

SET IDENTITY_INSERT [dbo].[kitapVerileri] OFF 

-------------------------------------------------------------------------------------------------------------------------------------------------

6.To see that the data has arrived, click on ViewData as shown in the image below.

![image](https://github.com/HarunEnsar/libraryProject/assets/99835656/1d3694f9-9f50-48f1-a700-5719fb3e32d8)

![image](https://github.com/HarunEnsar/libraryProject/assets/99835656/de58d6d6-44ad-4c43-999f-67e51a5e7f54)

7. The Alıcı Girişi data is in the Model/kişiler.cs, and the Kütüphaneci Girişi data is in the Model/kütüphaneci.cs.

------------------------------------------------------Project screenshots------------------------------------------


![Ekran Görüntüsü (20)](https://github.com/HarunEnsar/libraryProject/assets/99835656/2828be9f-e8d5-49db-8105-9e86cca6acc0)

![Ekran Görüntüsü (21)](https://github.com/HarunEnsar/libraryProject/assets/99835656/16492e23-fc4a-4b9f-95c0-643062f467cb)

![Ekran Görüntüsü (22)](https://github.com/HarunEnsar/libraryProject/assets/99835656/39507740-58c4-44f8-a27d-26aca9aaecc6)

![Ekran Görüntüsü (23)](https://github.com/HarunEnsar/libraryProject/assets/99835656/1d1a51a6-2a3c-401b-91a8-26d55a229934)

![Ekran Görüntüsü (24)](https://github.com/HarunEnsar/libraryProject/assets/99835656/9cfbbfc4-001c-47a6-8557-abf04e0088d8)

![Ekran Görüntüsü (25)](https://github.com/HarunEnsar/libraryProject/assets/99835656/ecf2e9b4-f007-4e7e-b97c-77b2cc8a47f4)

![Ekran Görüntüsü (26)](https://github.com/HarunEnsar/libraryProject/assets/99835656/694b183d-a3b3-4fb1-b91a-c0eb119f76a4)

![Ekran Görüntüsü (27)](https://github.com/HarunEnsar/libraryProject/assets/99835656/1a3ee00a-998d-4a76-86a6-ac223a168531)

![Ekran Görüntüsü (28)](https://github.com/HarunEnsar/libraryProject/assets/99835656/111ccdff-f52b-49be-acdd-8fb0bc974b31)













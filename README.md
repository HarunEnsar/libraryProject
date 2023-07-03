# libraryProject
 Asp.net Razor library project

---------------------------------------------------------USAGE--------------------------------------------------------------
1. Open Visual studio package manager console.
2. Write: update-database
3. Open sql server object explorer;
   
![Ekran Görüntüsü (15)](https://github.com/HarunEnsar/libraryProject/assets/99835656/3b1e29b7-8626-48e6-bcf7-ac94abc8d482)


4.Click New Query

![Ekran Görüntüsü (16)](https://github.com/HarunEnsar/libraryProject/assets/99835656/ebf4ef11-f2b9-41f0-973c-89700759e990)


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

![Ekran Görüntüsü (18)](https://github.com/HarunEnsar/libraryProject/assets/99835656/f69bec45-b0f9-4dcd-8ff9-352a62dbdc06)

![Ekran Görüntüsü (19)](https://github.com/HarunEnsar/libraryProject/assets/99835656/e77ac54a-29ac-4d2c-8d12-4de296a3310c)


7. The Alıcı Girişi data is in the Model/kişiler.cs, and the Kütüphaneci Girişi data is in the Model/kütüphaneci.cs.

------------------------------------------------------Project screenshots------------------------------------------


![Ekran Görüntüsü (20)](https://github.com/HarunEnsar/libraryProject/assets/99835656/f894985e-9983-4734-b104-5f77cfa51022)

![Ekran Görüntüsü (21)](https://github.com/HarunEnsar/libraryProject/assets/99835656/0be27811-0c52-40e3-8a42-57eca5f8c783)
![Ekran Görüntüsü (22)](https://github.com/HarunEnsar/libraryProject/assets/99835656/f2a1cd25-d512-4167-91a0-28cf6f7e1209)
![Ekran Görüntüsü (23)](https://github.com/HarunEnsar/libraryProject/assets/99835656/f8af41e1-dee8-49ce-a2d9-ba74eeb96859)
![Ekran Görüntüsü (24)](https://github.com/HarunEnsar/libraryProject/assets/99835656/a9dd87d9-bd6e-47af-9ad0-fae8c9d5d42d)
![Ekran Görüntüsü (25)](https://github.com/HarunEnsar/libraryProject/assets/99835656/d5a9d73d-49ca-4763-a0a9-8ba4c21fecb0)
![Ekran Görüntüsü (26)](https://github.com/HarunEnsar/libraryProject/assets/99835656/662e6242-e609-4035-92a1-5a08ed9d9598)
![Ekran Görüntüsü (27)](https://github.com/HarunEnsar/libraryProject/assets/99835656/0d7ddbd2-d873-4fd3-ab54-8df7e3fd8d52)
![Ekran Görüntüsü (28)](https://github.com/HarunEnsar/libraryProject/assets/99835656/e840eee4-346c-406f-ab07-b4c0212be169)













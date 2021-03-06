


/****** Object:  Table [dbo].[Alis]    Script Date: 25.02.2022 21:53:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alis](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KitapId] [int] NULL,
	[Adet] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kitap]    Script Date: 25.02.2022 21:53:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kitap](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KitapAdi] [nvarchar](250) NULL,
	[ISBN] [nvarchar](50) NULL,
	[TurId] [int] NULL,
	[YazarId] [int] NULL,
	[RafId] [int] NULL,
	[Aciklama] [nvarchar](1000) NULL,
	[Resim] [nvarchar](250) NULL,
	[Durum] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Odunc]    Script Date: 25.02.2022 21:53:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Odunc](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UyeId] [int] NULL,
	[KitapId] [int] NULL,
	[OduncSuresi] [int] NULL,
	[OduncDurumu] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 25.02.2022 21:53:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](100) NULL,
	[Soyad] [nvarchar](100) NULL,
	[YetkiId] [int] NULL,
	[Sifre] [nvarchar](100) NULL,
	[Durum] [bit] NULL,
 CONSTRAINT [PK__Personel__3214EC07EE009D6D] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Raf]    Script Date: 25.02.2022 21:53:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Raf](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RafAdi] [nvarchar](100) NULL,
	[Durum] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Satis]    Script Date: 25.02.2022 21:53:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Satis](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KitapId] [int] NULL,
	[Adet] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stok]    Script Date: 25.02.2022 21:53:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stok](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KitapId] [int] NULL,
	[Adet] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tur]    Script Date: 25.02.2022 21:53:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tur](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TurAdi] [nvarchar](100) NULL,
	[Durum] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Uye]    Script Date: 25.02.2022 21:53:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uye](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](100) NULL,
	[Soyad] [nvarchar](100) NULL,
	[TcNo] [nvarchar](11) NULL,
	[Email] [nvarchar](200) NULL,
	[Telefon] [nvarchar](11) NULL,
	[Adres] [nvarchar](500) NULL,
	[Resim] [nvarchar](250) NULL,
	[Durum] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yazar]    Script Date: 25.02.2022 21:53:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yazar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](100) NULL,
	[Soyad] [nvarchar](100) NULL,
	[Aciklama] [nvarchar](1000) NULL,
	[Durum] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yetki]    Script Date: 25.02.2022 21:53:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yetki](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Yetki] [nvarchar](20) NULL,
	[Durum] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Kitap] ON 

INSERT [dbo].[Kitap] ([Id], [KitapAdi], [ISBN], [TurId], [YazarId], [RafId], [Aciklama], [Resim], [Durum]) VALUES (4, N'Yaprak Dökümü', N'132456', 1, 1, 1, N'Ferhunde ve Şevket', N'yaprakdokumu.jpg', 1)
INSERT [dbo].[Kitap] ([Id], [KitapAdi], [ISBN], [TurId], [YazarId], [RafId], [Aciklama], [Resim], [Durum]) VALUES (1002, N'Sefiller', N'132465798', 2, 2, 3, N'Sefiller perişanlıktır', N'sefiller.jpg', 1)
SET IDENTITY_INSERT [dbo].[Kitap] OFF
GO
SET IDENTITY_INSERT [dbo].[Odunc] ON 

INSERT [dbo].[Odunc] ([Id], [UyeId], [KitapId], [OduncSuresi], [OduncDurumu]) VALUES (1, 1, 4, 30, N'Verildi')
INSERT [dbo].[Odunc] ([Id], [UyeId], [KitapId], [OduncSuresi], [OduncDurumu]) VALUES (2, 1, 4, 30, N'Verildi')
INSERT [dbo].[Odunc] ([Id], [UyeId], [KitapId], [OduncSuresi], [OduncDurumu]) VALUES (3, 1, 4, 30, N'Verildi')
INSERT [dbo].[Odunc] ([Id], [UyeId], [KitapId], [OduncSuresi], [OduncDurumu]) VALUES (4, 1, 4, 30, N'Verildi')
INSERT [dbo].[Odunc] ([Id], [UyeId], [KitapId], [OduncSuresi], [OduncDurumu]) VALUES (5, 1, 4, 30, N'Verildi')
SET IDENTITY_INSERT [dbo].[Odunc] OFF
GO
SET IDENTITY_INSERT [dbo].[Personel] ON 

INSERT [dbo].[Personel] ([Id], [Ad], [Soyad], [YetkiId], [Sifre], [Durum]) VALUES (1, N'Sezer', N'Varol', 2, N'123', 1)
INSERT [dbo].[Personel] ([Id], [Ad], [Soyad], [YetkiId], [Sifre], [Durum]) VALUES (2, N'Erhan', N'Kaya', 1, N'123', 1)
INSERT [dbo].[Personel] ([Id], [Ad], [Soyad], [YetkiId], [Sifre], [Durum]) VALUES (3, N'Beste', N'Semiz', 3, N'123', 0)
SET IDENTITY_INSERT [dbo].[Personel] OFF
GO
SET IDENTITY_INSERT [dbo].[Raf] ON 

INSERT [dbo].[Raf] ([Id], [RafAdi], [Durum]) VALUES (1, N'Klasikler', 1)
INSERT [dbo].[Raf] ([Id], [RafAdi], [Durum]) VALUES (2, N'Bilim', 1)
INSERT [dbo].[Raf] ([Id], [RafAdi], [Durum]) VALUES (3, N'Piskoloji', 1)
INSERT [dbo].[Raf] ([Id], [RafAdi], [Durum]) VALUES (4, N'Kişisel Gelişim', 1)
SET IDENTITY_INSERT [dbo].[Raf] OFF
GO
SET IDENTITY_INSERT [dbo].[Stok] ON 

INSERT [dbo].[Stok] ([Id], [KitapId], [Adet]) VALUES (1, 4, 1)
INSERT [dbo].[Stok] ([Id], [KitapId], [Adet]) VALUES (2, 1002, 0)
SET IDENTITY_INSERT [dbo].[Stok] OFF
GO
SET IDENTITY_INSERT [dbo].[Tur] ON 

INSERT [dbo].[Tur] ([Id], [TurAdi], [Durum]) VALUES (1, N'Roman', 1)
INSERT [dbo].[Tur] ([Id], [TurAdi], [Durum]) VALUES (2, N'Hikaye', 1)
INSERT [dbo].[Tur] ([Id], [TurAdi], [Durum]) VALUES (3, N'Çizgi Roman', 1)
INSERT [dbo].[Tur] ([Id], [TurAdi], [Durum]) VALUES (4, N'Dergi', 1)
INSERT [dbo].[Tur] ([Id], [TurAdi], [Durum]) VALUES (5, N'Şiir', 1)
INSERT [dbo].[Tur] ([Id], [TurAdi], [Durum]) VALUES (6, N'Deneme', 1)
INSERT [dbo].[Tur] ([Id], [TurAdi], [Durum]) VALUES (7, N'Biyografi', 1)
SET IDENTITY_INSERT [dbo].[Tur] OFF
GO
SET IDENTITY_INSERT [dbo].[Uye] ON 

INSERT [dbo].[Uye] ([Id], [Ad], [Soyad], [TcNo], [Email], [Telefon], [Adres], [Resim], [Durum]) VALUES (1, N'Sevde', N'Yorulmaz', N'12345678901', N'sevde@yorulmaz.com', N'05554443322', N'istanbul', N'yok.jpg', 1)
SET IDENTITY_INSERT [dbo].[Uye] OFF
GO
SET IDENTITY_INSERT [dbo].[Yazar] ON 

INSERT [dbo].[Yazar] ([Id], [Ad], [Soyad], [Aciklama], [Durum]) VALUES (1, N'Reşat Nuri', N'Güntekin', N'Roman Yazarı', 1)
INSERT [dbo].[Yazar] ([Id], [Ad], [Soyad], [Aciklama], [Durum]) VALUES (2, N'Victor', N'Hugo', N'yazar', 1)
INSERT [dbo].[Yazar] ([Id], [Ad], [Soyad], [Aciklama], [Durum]) VALUES (3, N'Halil', N'İnalçık', N'yazar', 0)
SET IDENTITY_INSERT [dbo].[Yazar] OFF
GO
SET IDENTITY_INSERT [dbo].[Yetki] ON 

INSERT [dbo].[Yetki] ([Id], [Yetki], [Durum]) VALUES (1, N'Müdür', 1)
INSERT [dbo].[Yetki] ([Id], [Yetki], [Durum]) VALUES (2, N'Personel', 1)
INSERT [dbo].[Yetki] ([Id], [Yetki], [Durum]) VALUES (3, N'Arşiv', 1)
SET IDENTITY_INSERT [dbo].[Yetki] OFF
GO
ALTER TABLE [dbo].[Alis]  WITH CHECK ADD  CONSTRAINT [FK_Alis_Kitap] FOREIGN KEY([KitapId])
REFERENCES [dbo].[Kitap] ([Id])
GO
ALTER TABLE [dbo].[Alis] CHECK CONSTRAINT [FK_Alis_Kitap]
GO
ALTER TABLE [dbo].[Kitap]  WITH CHECK ADD  CONSTRAINT [FK_Kitap_Raf] FOREIGN KEY([RafId])
REFERENCES [dbo].[Raf] ([Id])
GO
ALTER TABLE [dbo].[Kitap] CHECK CONSTRAINT [FK_Kitap_Raf]
GO
ALTER TABLE [dbo].[Kitap]  WITH CHECK ADD  CONSTRAINT [FK_Kitap_Tur] FOREIGN KEY([TurId])
REFERENCES [dbo].[Tur] ([Id])
GO
ALTER TABLE [dbo].[Kitap] CHECK CONSTRAINT [FK_Kitap_Tur]
GO
ALTER TABLE [dbo].[Kitap]  WITH CHECK ADD  CONSTRAINT [FK_Kitap_Yazar] FOREIGN KEY([YazarId])
REFERENCES [dbo].[Yazar] ([Id])
GO
ALTER TABLE [dbo].[Kitap] CHECK CONSTRAINT [FK_Kitap_Yazar]
GO
ALTER TABLE [dbo].[Odunc]  WITH CHECK ADD  CONSTRAINT [FK_Odunc_Kitap] FOREIGN KEY([KitapId])
REFERENCES [dbo].[Kitap] ([Id])
GO
ALTER TABLE [dbo].[Odunc] CHECK CONSTRAINT [FK_Odunc_Kitap]
GO
ALTER TABLE [dbo].[Odunc]  WITH CHECK ADD  CONSTRAINT [FK_Odunc_Uye] FOREIGN KEY([UyeId])
REFERENCES [dbo].[Uye] ([Id])
GO
ALTER TABLE [dbo].[Odunc] CHECK CONSTRAINT [FK_Odunc_Uye]
GO
ALTER TABLE [dbo].[Personel]  WITH CHECK ADD  CONSTRAINT [FK_Personel_Yetki] FOREIGN KEY([YetkiId])
REFERENCES [dbo].[Yetki] ([Id])
GO
ALTER TABLE [dbo].[Personel] CHECK CONSTRAINT [FK_Personel_Yetki]
GO
ALTER TABLE [dbo].[Satis]  WITH CHECK ADD  CONSTRAINT [FK_Satis_Kitap] FOREIGN KEY([KitapId])
REFERENCES [dbo].[Kitap] ([Id])
GO
ALTER TABLE [dbo].[Satis] CHECK CONSTRAINT [FK_Satis_Kitap]
GO
ALTER TABLE [dbo].[Stok]  WITH CHECK ADD  CONSTRAINT [FK_Stok_Kitap1] FOREIGN KEY([KitapId])
REFERENCES [dbo].[Kitap] ([Id])
GO
ALTER TABLE [dbo].[Stok] CHECK CONSTRAINT [FK_Stok_Kitap1]
GO
/****** Object:  StoredProcedure [dbo].[OduncVer]    Script Date: 25.02.2022 21:53:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[OduncVer]
@PersonelId int,
@UyeId int,
@KitapId int
as
declare @PersonelDurum bit
declare @UyeDurum bit
declare @KitapDurum bit
declare @UyeKitapAdet int
declare @PersonelYetkiId int
declare @KitapStok int
begin
	begin try
		begin tran OduncVerme
			select @PersonelDurum=Durum from Personel where Id=@PersonelId
			select @UyeDurum=Durum from Uye where Id=@UyeId
			select @KitapDurum=Durum from Kitap where Id=@KitapId
			select @UyeKitapAdet=COUNT(Id) from Odunc where UyeId=@UyeId and OduncDurumu='Verildi'
			select @PersonelYetkiId=YetkiId from Personel where Id=@PersonelId
			select @KitapStok=Sum(Adet) from Stok where KitapId=@KitapId
			if @PersonelYetkiId=2 and @PersonelDurum=1 and @UyeDurum=1 and @KitapDurum=1 begin
				if @UyeKitapAdet<5 begin
					if @KitapStok>0 begin
						insert into Odunc(KitapId,UyeId,OduncDurumu,OduncSuresi)
						values(@KitapId,@UyeId,'Verildi',30)
						
						print 'Kitap Odunc Verme Başarılı'
					end
					else begin
						print 'Kitap Stokta Yok'
					end
				end
				else begin
					print 'Bu Uyenin 5 Odunc Kitabı Bulunmakta. Daha Fazla Kitap Alamaz.'
				end
			end
			else begin
				print 'Yetki veya Durumlar Yetersiz. Lütfen Yetkili Biri yada Durum Aktif Olan Kitap Veriniz'
			end
		commit tran OduncVerme
	end try
	begin catch
		rollback tran OduncVerme
		print 'Beklenmedik Bir Hata Oluştu. İşlemler Geri Alındı'
	end catch
end
GO
/****** Object:  Trigger [dbo].[AlisStok]    Script Date: 25.02.2022 21:53:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[AlisStok]
on [dbo].[Alis]
after insert
as
declare @KitapId int
declare @Adet int
select @KitapId=KitapId,@Adet=Adet from inserted
update Stok set Adet+=@Adet where KitapId=@KitapId
GO
ALTER TABLE [dbo].[Alis] ENABLE TRIGGER [AlisStok]
GO
/****** Object:  Trigger [dbo].[AlisStokGuncelle]    Script Date: 25.02.2022 21:53:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[AlisStokGuncelle]
on [dbo].[Alis]
after update
as
declare @KitapId int
declare @oncekiAdet int
declare @sonrakiAdet int

select @KitapId=KitapId,@oncekiAdet=Adet from deleted
select @KitapId=KitapId,@sonrakiAdet=Adet from inserted

update Stok set Adet=Adet-@oncekiAdet+@sonrakiAdet where KitapId=@KitapId
GO
ALTER TABLE [dbo].[Alis] ENABLE TRIGGER [AlisStokGuncelle]
GO
/****** Object:  Trigger [dbo].[KitapSil_Stok_Alis_Satis_Odunc_Sil]    Script Date: 25.02.2022 21:53:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[KitapSil_Stok_Alis_Satis_Odunc_Sil]
on [dbo].[Kitap]
after delete
as
declare @KitapId int
select @KitapId=Id from deleted

delete from Stok where KitapId=@KitapId
delete from Alis where KitapId=@KitapId
delete from Satis where KitapId=@KitapId
delete from Odunc where KitapId=@KitapId
GO
ALTER TABLE [dbo].[Kitap] ENABLE TRIGGER [KitapSil_Stok_Alis_Satis_Odunc_Sil]
GO
/****** Object:  Trigger [dbo].[KitapStok]    Script Date: 25.02.2022 21:53:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[KitapStok]
on [dbo].[Kitap]
after insert
as
declare @KitapId int
select @KitapId=Id from inserted
insert into Stok(KitapId,Adet) values(@KitapId,0)
GO
ALTER TABLE [dbo].[Kitap] ENABLE TRIGGER [KitapStok]
GO
/****** Object:  Trigger [dbo].[OduncGeriStok]    Script Date: 25.02.2022 21:53:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[OduncGeriStok]
on [dbo].[Odunc]
after update
as
declare @KitapId int
declare @SonrakiKitapId int
declare @OncekiOduncDurum nvarchar(20)
declare @SonrakiOduncDurum nvarchar(20)
select @KitapId=KitapId,@OncekiOduncDurum=OduncDurumu from deleted
select @SonrakiKitapId=KitapId,@SonrakiOduncDurum=OduncDurumu from inserted

--OduncDurumu (Verildi-Alindi)
if @OncekiOduncDurum='Verildi' and @SonrakiOduncDurum='Alindi' begin
	update Stok set Adet+=1 where KitapId=@KitapId
end
else if @OncekiOduncDurum='Alindi' and @SonrakiOduncDurum='Verildi' begin
	update Stok set Adet-=1 where KitapId=@KitapId
end
else begin
	if @KitapId!=@SonrakiKitapId begin
		Update Stok set Adet-=1 where KitapId=@SonrakiKitapId
		Update Stok set Adet+=1 where KitapId=@KitapId
	end
end
GO
ALTER TABLE [dbo].[Odunc] ENABLE TRIGGER [OduncGeriStok]
GO
/****** Object:  Trigger [dbo].[OduncStok]    Script Date: 25.02.2022 21:53:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[OduncStok]
on [dbo].[Odunc]
after insert
as
declare @KitapId int
select @KitapId=KitapId from inserted
update Stok set Adet-=1 where KitapId=@KitapId
GO
ALTER TABLE [dbo].[Odunc] ENABLE TRIGGER [OduncStok]
GO
/****** Object:  Trigger [dbo].[SatisStok]    Script Date: 25.02.2022 21:53:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[SatisStok]
on [dbo].[Satis]
after insert
as
declare @KitapId int
declare @Adet int
select @KitapId=KitapId,@Adet=Adet from inserted
update Stok set Adet-=@Adet where KitapId=@KitapId
GO
ALTER TABLE [dbo].[Satis] ENABLE TRIGGER [SatisStok]
GO
/****** Object:  Trigger [dbo].[SatisStokGuncelle]    Script Date: 25.02.2022 21:53:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[SatisStokGuncelle]
on [dbo].[Satis]
after update
as
declare @KitapId int
declare @oncekiAdet int
declare @sonrakiAdet int

select @KitapId=KitapId,@oncekiAdet=Adet from deleted
select @KitapId=KitapId,@sonrakiAdet=Adet from inserted

update Stok set Adet=Adet-@oncekiAdet+@sonrakiAdet where KitapId=@KitapId
GO
ALTER TABLE [dbo].[Satis] ENABLE TRIGGER [SatisStokGuncelle]
GO
USE [master]
GO
ALTER DATABASE [LastLibrary] SET  READ_WRITE 
GO

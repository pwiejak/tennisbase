USE [Inzynierka1]
GO
/****** Object:  Table [dbo].[Stan_Uslug]    Script Date: 01/18/2011 19:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stan_Uslug](
	[ID_Stanu] [int] IDENTITY(1,1) NOT NULL,
	[Nazwa] [nchar](20) NOT NULL,
 CONSTRAINT [PK_Stan_Uslug] PRIMARY KEY CLUSTERED 
(
	[ID_Stanu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Stan_Uslug] ON
INSERT [dbo].[Stan_Uslug] ([ID_Stanu], [Nazwa]) VALUES (1, N'Przyjęto            ')
INSERT [dbo].[Stan_Uslug] ([ID_Stanu], [Nazwa]) VALUES (2, N'W trakcie...        ')
INSERT [dbo].[Stan_Uslug] ([ID_Stanu], [Nazwa]) VALUES (3, N'Zakończono          ')
INSERT [dbo].[Stan_Uslug] ([ID_Stanu], [Nazwa]) VALUES (4, N'Odebrano            ')
SET IDENTITY_INSERT [dbo].[Stan_Uslug] OFF
/****** Object:  Table [dbo].[Pracownicy]    Script Date: 01/18/2011 19:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pracownicy](
	[Id_Pracownika] [int] IDENTITY(1,1) NOT NULL,
	[Nazwisko] [nvarchar](50) NOT NULL,
	[Imie] [nvarchar](50) NOT NULL,
	[Telefon] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Pracownicy] PRIMARY KEY CLUSTERED 
(
	[Id_Pracownika] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Pracownicy] ON
INSERT [dbo].[Pracownicy] ([Id_Pracownika], [Nazwisko], [Imie], [Telefon]) VALUES (1, N'Kimono', N'Franek', N'600100200')
INSERT [dbo].[Pracownicy] ([Id_Pracownika], [Nazwisko], [Imie], [Telefon]) VALUES (2, N'Nowak', N'Jan', N'666100200')
INSERT [dbo].[Pracownicy] ([Id_Pracownika], [Nazwisko], [Imie], [Telefon]) VALUES (3, N'Wiejak', N'Pawel', N'606977769')
INSERT [dbo].[Pracownicy] ([Id_Pracownika], [Nazwisko], [Imie], [Telefon]) VALUES (6, N'asdasd', N'asdasd', N'12345')
INSERT [dbo].[Pracownicy] ([Id_Pracownika], [Nazwisko], [Imie], [Telefon]) VALUES (7, N'nowy', N'nowy', N'123')
INSERT [dbo].[Pracownicy] ([Id_Pracownika], [Nazwisko], [Imie], [Telefon]) VALUES (9, N'asdwqe', N'asdewq', N'2134')
INSERT [dbo].[Pracownicy] ([Id_Pracownika], [Nazwisko], [Imie], [Telefon]) VALUES (10, N'kolejny', N'probny', N'98765')
INSERT [dbo].[Pracownicy] ([Id_Pracownika], [Nazwisko], [Imie], [Telefon]) VALUES (11, N'probny3', N'imie3', N'213123123')
INSERT [dbo].[Pracownicy] ([Id_Pracownika], [Nazwisko], [Imie], [Telefon]) VALUES (14, N'anazwisko', N'aimie', N'726387623')
SET IDENTITY_INSERT [dbo].[Pracownicy] OFF
/****** Object:  Table [dbo].[Kategorie]    Script Date: 01/18/2011 19:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kategorie](
	[ID_Kategorii] [int] NOT NULL,
	[Nazwa] [nvarchar](50) NOT NULL,
	[Opis] [nvarchar](50) NULL,
 CONSTRAINT [PK_Kategorie] PRIMARY KEY CLUSTERED 
(
	[ID_Kategorii] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Kategorie] ([ID_Kategorii], [Nazwa], [Opis]) VALUES (0, N'Brak', N'Brak kategorii')
INSERT [dbo].[Kategorie] ([ID_Kategorii], [Nazwa], [Opis]) VALUES (1, N'M', N'Mężczyźni')
INSERT [dbo].[Kategorie] ([ID_Kategorii], [Nazwa], [Opis]) VALUES (2, N'K', N'Kobiety')
INSERT [dbo].[Kategorie] ([ID_Kategorii], [Nazwa], [Opis]) VALUES (3, N'J', N'Juniorzy')
/****** Object:  Table [dbo].[Katalog_Uslug]    Script Date: 01/18/2011 19:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Katalog_Uslug](
	[ID_Uslugi] [int] IDENTITY(1,1) NOT NULL,
	[Nazwa] [nchar](25) NOT NULL,
 CONSTRAINT [PK_Katalog_Uslug] PRIMARY KEY CLUSTERED 
(
	[ID_Uslugi] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Katalog_Uslug] ON
INSERT [dbo].[Katalog_Uslug] ([ID_Uslugi], [Nazwa]) VALUES (1, N'Wymiana naciągu          ')
INSERT [dbo].[Katalog_Uslug] ([ID_Uslugi], [Nazwa]) VALUES (2, N'Wymiana owijki           ')
INSERT [dbo].[Katalog_Uslug] ([ID_Uslugi], [Nazwa]) VALUES (3, N'Regeneracja torby        ')
INSERT [dbo].[Katalog_Uslug] ([ID_Uslugi], [Nazwa]) VALUES (4, N'regeneracja obuwia       ')
SET IDENTITY_INSERT [dbo].[Katalog_Uslug] OFF
/****** Object:  Table [dbo].[Informacje]    Script Date: 01/18/2011 19:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Informacje](
	[IloscKortow] [int] NOT NULL,
	[GodzinaOtwarcia] [int] NOT NULL,
	[GodzinaZamkniecia] [int] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Informacje] ([IloscKortow], [GodzinaOtwarcia], [GodzinaZamkniecia]) VALUES (4, 6, 22)
INSERT [dbo].[Informacje] ([IloscKortow], [GodzinaOtwarcia], [GodzinaZamkniecia]) VALUES (4, 6, 22)
/****** Object:  Table [dbo].[Uzytkownicy_Kortow]    Script Date: 01/18/2011 19:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uzytkownicy_Kortow](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Typ] [int] NOT NULL,
	[Nazwisko] [nvarchar](50) NOT NULL,
	[Imię] [nvarchar](50) NULL,
	[Telefon] [nvarchar](20) NOT NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_Uzytkownicy_Kortow] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Uzytkownicy_Kortow] ON
INSERT [dbo].[Uzytkownicy_Kortow] ([ID], [Typ], [Nazwisko], [Imię], [Telefon], [Email]) VALUES (1, 1, N'Kowalski', N'Jan', N'999999999', NULL)
INSERT [dbo].[Uzytkownicy_Kortow] ([ID], [Typ], [Nazwisko], [Imię], [Telefon], [Email]) VALUES (2, 1, N'Makumba', N'Franek', N'12345678', NULL)
INSERT [dbo].[Uzytkownicy_Kortow] ([ID], [Typ], [Nazwisko], [Imię], [Telefon], [Email]) VALUES (3, 1, N'Kolejny', N'Klient', N'798987987', NULL)
INSERT [dbo].[Uzytkownicy_Kortow] ([ID], [Typ], [Nazwisko], [Imię], [Telefon], [Email]) VALUES (4, 1, N'Dodany', N'Programem', N'5678923', NULL)
INSERT [dbo].[Uzytkownicy_Kortow] ([ID], [Typ], [Nazwisko], [Imię], [Telefon], [Email]) VALUES (5, 1, N'Wiejak', N'Paweł', N'606333555', NULL)
INSERT [dbo].[Uzytkownicy_Kortow] ([ID], [Typ], [Nazwisko], [Imię], [Telefon], [Email]) VALUES (6, 1, N'Federer', N'Roger', N'500400900', NULL)
SET IDENTITY_INSERT [dbo].[Uzytkownicy_Kortow] OFF
/****** Object:  Table [dbo].[Typy]    Script Date: 01/18/2011 19:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Typy](
	[Nr_Typu] [int] IDENTITY(1,1) NOT NULL,
	[Nazwa] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Typy] PRIMARY KEY CLUSTERED 
(
	[Nr_Typu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Typy] ON
INSERT [dbo].[Typy] ([Nr_Typu], [Nazwa]) VALUES (1, N'Rakiety')
INSERT [dbo].[Typy] ([Nr_Typu], [Nazwa]) VALUES (2, N'Piłki')
INSERT [dbo].[Typy] ([Nr_Typu], [Nazwa]) VALUES (3, N'Koszulki')
INSERT [dbo].[Typy] ([Nr_Typu], [Nazwa]) VALUES (4, N'Spodenki')
INSERT [dbo].[Typy] ([Nr_Typu], [Nazwa]) VALUES (5, N'Dresy')
INSERT [dbo].[Typy] ([Nr_Typu], [Nazwa]) VALUES (6, N'Naciągi')
INSERT [dbo].[Typy] ([Nr_Typu], [Nazwa]) VALUES (7, N'Owijki')
INSERT [dbo].[Typy] ([Nr_Typu], [Nazwa]) VALUES (8, N'Skarpetki')
INSERT [dbo].[Typy] ([Nr_Typu], [Nazwa]) VALUES (9, N'Buty')
INSERT [dbo].[Typy] ([Nr_Typu], [Nazwa]) VALUES (10, N'Bezrękawniki')
INSERT [dbo].[Typy] ([Nr_Typu], [Nazwa]) VALUES (11, N'Akcesoria')
SET IDENTITY_INSERT [dbo].[Typy] OFF
/****** Object:  Table [dbo].[Zawodnicy]    Script Date: 01/18/2011 19:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zawodnicy](
	[ID_Zawodnika] [int] IDENTITY(1,1) NOT NULL,
	[Imie] [nvarchar](50) NOT NULL,
	[Nazwisko] [nvarchar](50) NOT NULL,
	[Telefon] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Zawodnicy] PRIMARY KEY CLUSTERED 
(
	[ID_Zawodnika] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Zawodnicy] ON
INSERT [dbo].[Zawodnicy] ([ID_Zawodnika], [Imie], [Nazwisko], [Telefon], [Email]) VALUES (18, N'1', N'1', N'1', N'1')
INSERT [dbo].[Zawodnicy] ([ID_Zawodnika], [Imie], [Nazwisko], [Telefon], [Email]) VALUES (19, N'2', N'2', N'2', N'2')
SET IDENTITY_INSERT [dbo].[Zawodnicy] OFF
/****** Object:  Table [dbo].[Uzytkownicy_Systemu]    Script Date: 01/18/2011 19:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uzytkownicy_Systemu](
	[ID_Uzytkownika] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[ID_Pracownika] [int] NOT NULL,
	[Haslo] [nvarchar](50) NOT NULL,
	[Uprawnienia] [int] NULL,
 CONSTRAINT [PK_Uzytkownicy_Systemu] PRIMARY KEY CLUSTERED 
(
	[ID_Uzytkownika] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Uzytkownicy_Systemu] ON
INSERT [dbo].[Uzytkownicy_Systemu] ([ID_Uzytkownika], [Login], [ID_Pracownika], [Haslo], [Uprawnienia]) VALUES (1, N'user1', 1, N'user1', 1)
INSERT [dbo].[Uzytkownicy_Systemu] ([ID_Uzytkownika], [Login], [ID_Pracownika], [Haslo], [Uprawnienia]) VALUES (2, N'user2', 2, N'user2', 1)
INSERT [dbo].[Uzytkownicy_Systemu] ([ID_Uzytkownika], [Login], [ID_Pracownika], [Haslo], [Uprawnienia]) VALUES (5, N'asd', 6, N'asd', 0)
INSERT [dbo].[Uzytkownicy_Systemu] ([ID_Uzytkownika], [Login], [ID_Pracownika], [Haslo], [Uprawnienia]) VALUES (6, N'login', 7, N'haslo', 0)
INSERT [dbo].[Uzytkownicy_Systemu] ([ID_Uzytkownika], [Login], [ID_Pracownika], [Haslo], [Uprawnienia]) VALUES (7, N'probny3', 11, N'probny3', 0)
INSERT [dbo].[Uzytkownicy_Systemu] ([ID_Uzytkownika], [Login], [ID_Pracownika], [Haslo], [Uprawnienia]) VALUES (8, N'a', 14, N'a', 1)
SET IDENTITY_INSERT [dbo].[Uzytkownicy_Systemu] OFF
/****** Object:  Table [dbo].[Trenerzy]    Script Date: 01/18/2011 19:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trenerzy](
	[ID_Trenera] [nchar](10) NOT NULL,
	[ID_Osoby] [int] NOT NULL,
	[Poziom] [nvarchar](50) NOT NULL,
	[Max_Osob] [int] NULL,
 CONSTRAINT [PK_Trenerzy] PRIMARY KEY CLUSTERED 
(
	[ID_Trenera] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Klasyfikacje]    Script Date: 01/18/2011 19:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Klasyfikacje](
	[ID_Klasyfikacji] [int] IDENTITY(1,1) NOT NULL,
	[CzyGeneralna] [int] NOT NULL,
	[ID_Turnieju] [int] NOT NULL,
	[Miejsce] [int] NOT NULL,
	[Punkty] [int] NULL,
	[ID_Zawodnika] [int] NOT NULL,
 CONSTRAINT [PK_Klasyfikacje] PRIMARY KEY CLUSTERED 
(
	[ID_Klasyfikacji] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Generalna]    Script Date: 01/18/2011 19:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Generalna](
	[ID_Zawodnika] [int] NOT NULL,
	[Punkty] [int] NOT NULL,
 CONSTRAINT [PK_Generalna] PRIMARY KEY CLUSTERED 
(
	[ID_Zawodnika] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Generalna] ([ID_Zawodnika], [Punkty]) VALUES (18, 0)
INSERT [dbo].[Generalna] ([ID_Zawodnika], [Punkty]) VALUES (19, 0)
/****** Object:  Table [dbo].[Dostepnosc]    Script Date: 01/18/2011 19:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dostepnosc](
	[ID] [int] NOT NULL,
	[Dzien_Tygodnia] [nchar](10) NOT NULL,
	[Godz_Rozpoczecia] [nchar](10) NOT NULL,
	[Godz_Zakonczenia] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sprzet]    Script Date: 01/18/2011 19:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sprzet](
	[ID_Produktu] [int] IDENTITY(1,1) NOT NULL,
	[Typ] [int] NOT NULL,
	[Marka] [varchar](20) NOT NULL,
	[Model] [varchar](50) NOT NULL,
	[Opis] [varchar](100) NULL,
 CONSTRAINT [PK_Sprzet] PRIMARY KEY CLUSTERED 
(
	[ID_Produktu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Sprzet] ON
INSERT [dbo].[Sprzet] ([ID_Produktu], [Typ], [Marka], [Model], [Opis]) VALUES (0, 2, N'Wilson', N'US Open', N'')
INSERT [dbo].[Sprzet] ([ID_Produktu], [Typ], [Marka], [Model], [Opis]) VALUES (2, 2, N'Wilson', N'Practice', N'Pilki treningowe')
INSERT [dbo].[Sprzet] ([ID_Produktu], [Typ], [Marka], [Model], [Opis]) VALUES (5, 1, N'Head', N'Team Pro', N'Rakieta zawodnicza')
INSERT [dbo].[Sprzet] ([ID_Produktu], [Typ], [Marka], [Model], [Opis]) VALUES (6, 1, N'Wilson', N'Pro Tour', N'Rakieta zawodnicza')
INSERT [dbo].[Sprzet] ([ID_Produktu], [Typ], [Marka], [Model], [Opis]) VALUES (7, 6, N'Babolat', N'Hurricane', N'Naciąg do technicznej gry')
INSERT [dbo].[Sprzet] ([ID_Produktu], [Typ], [Marka], [Model], [Opis]) VALUES (8, 1, N'Head', N'Junior', N'Rakieta dziecięca')
INSERT [dbo].[Sprzet] ([ID_Produktu], [Typ], [Marka], [Model], [Opis]) VALUES (9, 1, N'Wilson', N'Comfort', N'Rakieta rekreacyjna')
INSERT [dbo].[Sprzet] ([ID_Produktu], [Typ], [Marka], [Model], [Opis]) VALUES (10, 3, N'Reebok', N'Andy', N'Koszulka bawełniana')
INSERT [dbo].[Sprzet] ([ID_Produktu], [Typ], [Marka], [Model], [Opis]) VALUES (11, 3, N'Wilson', N'Roger', N'Koszulka chłonąca pot')
INSERT [dbo].[Sprzet] ([ID_Produktu], [Typ], [Marka], [Model], [Opis]) VALUES (12, 6, N'Wilson', N'Enduro Pro', N'Silne uderzenie')
INSERT [dbo].[Sprzet] ([ID_Produktu], [Typ], [Marka], [Model], [Opis]) VALUES (13, 6, N'Wilson', N'Enduro Tour', N'Wytrzymałość')
INSERT [dbo].[Sprzet] ([ID_Produktu], [Typ], [Marka], [Model], [Opis]) VALUES (14, 6, N'Wilson', N'Natural', N'Pełna kontrola')
INSERT [dbo].[Sprzet] ([ID_Produktu], [Typ], [Marka], [Model], [Opis]) VALUES (15, 6, N'Head', N'Ultratour', N'Wytrzymały naciąg poliestrowy')
INSERT [dbo].[Sprzet] ([ID_Produktu], [Typ], [Marka], [Model], [Opis]) VALUES (16, 6, N'Head', N'Sonic', N'Kontrola uderzenia i wytrzymałość')
INSERT [dbo].[Sprzet] ([ID_Produktu], [Typ], [Marka], [Model], [Opis]) VALUES (17, 11, N'Wilson', N'Headband', N'Opaska na głowę chłonąca pot')
INSERT [dbo].[Sprzet] ([ID_Produktu], [Typ], [Marka], [Model], [Opis]) VALUES (18, 11, N'Wilson', N'Wristband', N'Napotnik na nadgarstek')
INSERT [dbo].[Sprzet] ([ID_Produktu], [Typ], [Marka], [Model], [Opis]) VALUES (19, 11, N'Adidas', N'Ten Wristbands', N'Paczka 10 napotników na nadgarstki')
INSERT [dbo].[Sprzet] ([ID_Produktu], [Typ], [Marka], [Model], [Opis]) VALUES (20, 11, N'Nike', N'Wristbands', N'Paczka 2 napotników na nadgarstki')
INSERT [dbo].[Sprzet] ([ID_Produktu], [Typ], [Marka], [Model], [Opis]) VALUES (21, 3, N'Adidas', N'Edge', N'Poliestrowa, dobra wentylacja')
INSERT [dbo].[Sprzet] ([ID_Produktu], [Typ], [Marka], [Model], [Opis]) VALUES (22, 3, N'Adidas', N'Competition', N'Dobre odprowadzanie potu i wentylacja')
INSERT [dbo].[Sprzet] ([ID_Produktu], [Typ], [Marka], [Model], [Opis]) VALUES (23, 3, N'Adidas', N'Edge Polo', N'Dobra wentylacja, wersja z kołnierzem')
INSERT [dbo].[Sprzet] ([ID_Produktu], [Typ], [Marka], [Model], [Opis]) VALUES (24, 4, N'Adidas', N'Edge Short Black', N'Przewiewne i wygodne')
INSERT [dbo].[Sprzet] ([ID_Produktu], [Typ], [Marka], [Model], [Opis]) VALUES (25, 4, N'Adidas', N'Competition Short Black', N'Przewiewne i wygodne')
INSERT [dbo].[Sprzet] ([ID_Produktu], [Typ], [Marka], [Model], [Opis]) VALUES (26, 3, N'Nike', N'Dry Fit', N'Przewiewna i wygodna')
INSERT [dbo].[Sprzet] ([ID_Produktu], [Typ], [Marka], [Model], [Opis]) VALUES (27, 3, N'Nike', N'Dry Fit Motion', N'Lekka i przewiewna')
INSERT [dbo].[Sprzet] ([ID_Produktu], [Typ], [Marka], [Model], [Opis]) VALUES (28, 2, N'Slazenger', N'Championship 3', N'Paczka 3 profesjonalnych piłek najlepszej jakości')
INSERT [dbo].[Sprzet] ([ID_Produktu], [Typ], [Marka], [Model], [Opis]) VALUES (29, 2, N'Slazenger', N'Championship 4', N'Paczka 4 profesjonalnych piłek najlepszej jakości')
INSERT [dbo].[Sprzet] ([ID_Produktu], [Typ], [Marka], [Model], [Opis]) VALUES (30, 2, N'Slazenger', N'Wimbledon Ultra 4', N'Paczka 4 oryginalnych piłek z kortów Wimbledonu')
INSERT [dbo].[Sprzet] ([ID_Produktu], [Typ], [Marka], [Model], [Opis]) VALUES (31, 2, N'Tretorn', N'Tournament 4', N'Do gry na każdej nawierzchni, 4 w paczce')
INSERT [dbo].[Sprzet] ([ID_Produktu], [Typ], [Marka], [Model], [Opis]) VALUES (32, 2, N'Tretorn', N'TXT 4', N'Bardzo wytrzymałe piłki, do gry na każdej nawierzchni')
INSERT [dbo].[Sprzet] ([ID_Produktu], [Typ], [Marka], [Model], [Opis]) VALUES (33, 2, N'Tretorn', N'Micro 4', N'Bezciśnieniowe piłki do gry na każdej nawierzchni')
SET IDENTITY_INSERT [dbo].[Sprzet] OFF
/****** Object:  Table [dbo].[Sparingpartnerzy]    Script Date: 01/18/2011 19:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sparingpartnerzy](
	[ID_Sparingpartnera] [nchar](10) NOT NULL,
	[ID_Osoby] [int] NOT NULL,
	[Poziom] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Sparingpartnerzy] PRIMARY KEY CLUSTERED 
(
	[ID_Sparingpartnera] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Serwis]    Script Date: 01/18/2011 19:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Serwis](
	[ID_Zlecenia] [int] IDENTITY(1,1) NOT NULL,
	[ID_Klienta] [int] NOT NULL,
	[Stan] [int] NOT NULL,
	[Usługa] [int] NOT NULL,
	[Data_Przyjecia] [date] NOT NULL,
 CONSTRAINT [PK_Serwis] PRIMARY KEY CLUSTERED 
(
	[ID_Zlecenia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Serwis] ON
INSERT [dbo].[Serwis] ([ID_Zlecenia], [ID_Klienta], [Stan], [Usługa], [Data_Przyjecia]) VALUES (4, 5, 1, 1, CAST(0xCA330B00 AS Date))
INSERT [dbo].[Serwis] ([ID_Zlecenia], [ID_Klienta], [Stan], [Usługa], [Data_Przyjecia]) VALUES (5, 3, 1, 3, CAST(0xCA330B00 AS Date))
INSERT [dbo].[Serwis] ([ID_Zlecenia], [ID_Klienta], [Stan], [Usługa], [Data_Przyjecia]) VALUES (6, 6, 2, 1, CAST(0xCA330B00 AS Date))
INSERT [dbo].[Serwis] ([ID_Zlecenia], [ID_Klienta], [Stan], [Usługa], [Data_Przyjecia]) VALUES (7, 2, 4, 1, CAST(0xCA330B00 AS Date))
INSERT [dbo].[Serwis] ([ID_Zlecenia], [ID_Klienta], [Stan], [Usługa], [Data_Przyjecia]) VALUES (8, 1, 3, 1, CAST(0xCA330B00 AS Date))
SET IDENTITY_INSERT [dbo].[Serwis] OFF
/****** Object:  Table [dbo].[Rezerwacje_Kortow]    Script Date: 01/18/2011 19:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rezerwacje_Kortow](
	[ID_Rezerwacji] [int] IDENTITY(1,1) NOT NULL,
	[Nr_Kortu] [int] NOT NULL,
	[Data] [date] NULL,
	[Dzien_Tygodnia] [int] NULL,
	[Godz_Rozpoczecia] [int] NOT NULL,
	[Godz_Zakonczenia] [int] NOT NULL,
	[ID_Osoby] [int] NOT NULL,
	[Cena] [float] NULL,
	[Id_Pracownika] [int] NOT NULL,
 CONSTRAINT [PK_Rezerwacje_Kortow] PRIMARY KEY CLUSTERED 
(
	[ID_Rezerwacji] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Rezerwacje_Kortow] ON
INSERT [dbo].[Rezerwacje_Kortow] ([ID_Rezerwacji], [Nr_Kortu], [Data], [Dzien_Tygodnia], [Godz_Rozpoczecia], [Godz_Zakonczenia], [ID_Osoby], [Cena], [Id_Pracownika]) VALUES (1, 1, CAST(0x70330B00 AS Date), NULL, 16, 17, 1, 20, 1)
INSERT [dbo].[Rezerwacje_Kortow] ([ID_Rezerwacji], [Nr_Kortu], [Data], [Dzien_Tygodnia], [Godz_Rozpoczecia], [Godz_Zakonczenia], [ID_Osoby], [Cena], [Id_Pracownika]) VALUES (2, 2, CAST(0x70330B00 AS Date), NULL, 8, 10, 1, 20, 1)
INSERT [dbo].[Rezerwacje_Kortow] ([ID_Rezerwacji], [Nr_Kortu], [Data], [Dzien_Tygodnia], [Godz_Rozpoczecia], [Godz_Zakonczenia], [ID_Osoby], [Cena], [Id_Pracownika]) VALUES (3, 3, NULL, 3, 12, 13, 1, 10, 1)
INSERT [dbo].[Rezerwacje_Kortow] ([ID_Rezerwacji], [Nr_Kortu], [Data], [Dzien_Tygodnia], [Godz_Rozpoczecia], [Godz_Zakonczenia], [ID_Osoby], [Cena], [Id_Pracownika]) VALUES (4, 1, CAST(0x71330B00 AS Date), NULL, 17, 20, 1, 30, 1)
INSERT [dbo].[Rezerwacje_Kortow] ([ID_Rezerwacji], [Nr_Kortu], [Data], [Dzien_Tygodnia], [Godz_Rozpoczecia], [Godz_Zakonczenia], [ID_Osoby], [Cena], [Id_Pracownika]) VALUES (5, 2, CAST(0x71330B00 AS Date), NULL, 18, 20, 1, 20, 1)
INSERT [dbo].[Rezerwacje_Kortow] ([ID_Rezerwacji], [Nr_Kortu], [Data], [Dzien_Tygodnia], [Godz_Rozpoczecia], [Godz_Zakonczenia], [ID_Osoby], [Cena], [Id_Pracownika]) VALUES (6, 2, CAST(0x71330B00 AS Date), NULL, 12, 13, 1, 10, 1)
INSERT [dbo].[Rezerwacje_Kortow] ([ID_Rezerwacji], [Nr_Kortu], [Data], [Dzien_Tygodnia], [Godz_Rozpoczecia], [Godz_Zakonczenia], [ID_Osoby], [Cena], [Id_Pracownika]) VALUES (7, 2, CAST(0x72330B00 AS Date), NULL, 12, 13, 1, 10, 1)
INSERT [dbo].[Rezerwacje_Kortow] ([ID_Rezerwacji], [Nr_Kortu], [Data], [Dzien_Tygodnia], [Godz_Rozpoczecia], [Godz_Zakonczenia], [ID_Osoby], [Cena], [Id_Pracownika]) VALUES (8, 1, NULL, 5, 20, 22, 1, 10, 1)
INSERT [dbo].[Rezerwacje_Kortow] ([ID_Rezerwacji], [Nr_Kortu], [Data], [Dzien_Tygodnia], [Godz_Rozpoczecia], [Godz_Zakonczenia], [ID_Osoby], [Cena], [Id_Pracownika]) VALUES (9, 1, NULL, 4, 9, 11, 3, 20, 1)
INSERT [dbo].[Rezerwacje_Kortow] ([ID_Rezerwacji], [Nr_Kortu], [Data], [Dzien_Tygodnia], [Godz_Rozpoczecia], [Godz_Zakonczenia], [ID_Osoby], [Cena], [Id_Pracownika]) VALUES (10, 3, NULL, 5, 9, 11, 2, 20, 1)
INSERT [dbo].[Rezerwacje_Kortow] ([ID_Rezerwacji], [Nr_Kortu], [Data], [Dzien_Tygodnia], [Godz_Rozpoczecia], [Godz_Zakonczenia], [ID_Osoby], [Cena], [Id_Pracownika]) VALUES (11, 2, NULL, NULL, 12, 15, 4, 30, 1)
INSERT [dbo].[Rezerwacje_Kortow] ([ID_Rezerwacji], [Nr_Kortu], [Data], [Dzien_Tygodnia], [Godz_Rozpoczecia], [Godz_Zakonczenia], [ID_Osoby], [Cena], [Id_Pracownika]) VALUES (12, 3, CAST(0x78330B00 AS Date), NULL, 11, 13, 4, 20, 1)
INSERT [dbo].[Rezerwacje_Kortow] ([ID_Rezerwacji], [Nr_Kortu], [Data], [Dzien_Tygodnia], [Godz_Rozpoczecia], [Godz_Zakonczenia], [ID_Osoby], [Cena], [Id_Pracownika]) VALUES (13, 2, CAST(0x79330B00 AS Date), NULL, 15, 17, 3, 20, 1)
INSERT [dbo].[Rezerwacje_Kortow] ([ID_Rezerwacji], [Nr_Kortu], [Data], [Dzien_Tygodnia], [Godz_Rozpoczecia], [Godz_Zakonczenia], [ID_Osoby], [Cena], [Id_Pracownika]) VALUES (14, 3, NULL, 5, 15, 16, 2, 10, 1)
INSERT [dbo].[Rezerwacje_Kortow] ([ID_Rezerwacji], [Nr_Kortu], [Data], [Dzien_Tygodnia], [Godz_Rozpoczecia], [Godz_Zakonczenia], [ID_Osoby], [Cena], [Id_Pracownika]) VALUES (15, 3, CAST(0x96330B00 AS Date), NULL, 15, 17, 3, 20, 14)
INSERT [dbo].[Rezerwacje_Kortow] ([ID_Rezerwacji], [Nr_Kortu], [Data], [Dzien_Tygodnia], [Godz_Rozpoczecia], [Godz_Zakonczenia], [ID_Osoby], [Cena], [Id_Pracownika]) VALUES (16, 2, CAST(0x9C330B00 AS Date), NULL, 13, 15, 4, 20, 14)
INSERT [dbo].[Rezerwacje_Kortow] ([ID_Rezerwacji], [Nr_Kortu], [Data], [Dzien_Tygodnia], [Godz_Rozpoczecia], [Godz_Zakonczenia], [ID_Osoby], [Cena], [Id_Pracownika]) VALUES (17, 2, CAST(0xB1330B00 AS Date), NULL, 13, 15, 1, 20, 14)
INSERT [dbo].[Rezerwacje_Kortow] ([ID_Rezerwacji], [Nr_Kortu], [Data], [Dzien_Tygodnia], [Godz_Rozpoczecia], [Godz_Zakonczenia], [ID_Osoby], [Cena], [Id_Pracownika]) VALUES (18, 1, CAST(0xB1330B00 AS Date), NULL, 15, 17, 4, 20, 14)
INSERT [dbo].[Rezerwacje_Kortow] ([ID_Rezerwacji], [Nr_Kortu], [Data], [Dzien_Tygodnia], [Godz_Rozpoczecia], [Godz_Zakonczenia], [ID_Osoby], [Cena], [Id_Pracownika]) VALUES (19, 2, NULL, 7, 8, 11, 2, 30, 14)
INSERT [dbo].[Rezerwacje_Kortow] ([ID_Rezerwacji], [Nr_Kortu], [Data], [Dzien_Tygodnia], [Godz_Rozpoczecia], [Godz_Zakonczenia], [ID_Osoby], [Cena], [Id_Pracownika]) VALUES (20, 3, CAST(0xAC330B00 AS Date), NULL, 8, 10, 6, 20, 14)
SET IDENTITY_INSERT [dbo].[Rezerwacje_Kortow] OFF
/****** Object:  Table [dbo].[Stan_Magazynowy]    Script Date: 01/18/2011 19:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stan_Magazynowy](
	[ID_Produktu] [int] NOT NULL,
	[Nr_Przedmiotu] [int] IDENTITY(1,1) NOT NULL,
	[Typ_Sprzedazy] [int] NOT NULL,
	[Ilosc] [int] NOT NULL,
	[Rozmiar] [nvarchar](50) NULL,
	[Kolor] [nvarchar](50) NULL,
	[Cena] [float] NOT NULL,
 CONSTRAINT [PK_Stan_Magazynowy] PRIMARY KEY CLUSTERED 
(
	[Nr_Przedmiotu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Stan_Magazynowy] ON
INSERT [dbo].[Stan_Magazynowy] ([ID_Produktu], [Nr_Przedmiotu], [Typ_Sprzedazy], [Ilosc], [Rozmiar], [Kolor], [Cena]) VALUES (2, 1, 1, 6, NULL, NULL, 30)
INSERT [dbo].[Stan_Magazynowy] ([ID_Produktu], [Nr_Przedmiotu], [Typ_Sprzedazy], [Ilosc], [Rozmiar], [Kolor], [Cena]) VALUES (5, 2, 1, 3, NULL, NULL, 500)
INSERT [dbo].[Stan_Magazynowy] ([ID_Produktu], [Nr_Przedmiotu], [Typ_Sprzedazy], [Ilosc], [Rozmiar], [Kolor], [Cena]) VALUES (10, 4, 1, 2, N'M', N'Niebieski', 130)
INSERT [dbo].[Stan_Magazynowy] ([ID_Produktu], [Nr_Przedmiotu], [Typ_Sprzedazy], [Ilosc], [Rozmiar], [Kolor], [Cena]) VALUES (10, 5, 1, 4, N'L', N'Niebieski', 130)
INSERT [dbo].[Stan_Magazynowy] ([ID_Produktu], [Nr_Przedmiotu], [Typ_Sprzedazy], [Ilosc], [Rozmiar], [Kolor], [Cena]) VALUES (10, 6, 1, 3, N'L', N'Czarny', 130)
INSERT [dbo].[Stan_Magazynowy] ([ID_Produktu], [Nr_Przedmiotu], [Typ_Sprzedazy], [Ilosc], [Rozmiar], [Kolor], [Cena]) VALUES (6, 7, 1, 3, N'', N'Black', 500)
INSERT [dbo].[Stan_Magazynowy] ([ID_Produktu], [Nr_Przedmiotu], [Typ_Sprzedazy], [Ilosc], [Rozmiar], [Kolor], [Cena]) VALUES (8, 8, 2, 2, N'Junior', N'Yellow', 20)
INSERT [dbo].[Stan_Magazynowy] ([ID_Produktu], [Nr_Przedmiotu], [Typ_Sprzedazy], [Ilosc], [Rozmiar], [Kolor], [Cena]) VALUES (7, 9, 1, 5, N'50m', N'', 100)
INSERT [dbo].[Stan_Magazynowy] ([ID_Produktu], [Nr_Przedmiotu], [Typ_Sprzedazy], [Ilosc], [Rozmiar], [Kolor], [Cena]) VALUES (12, 10, 1, 2, N'30m', N'', 80)
INSERT [dbo].[Stan_Magazynowy] ([ID_Produktu], [Nr_Przedmiotu], [Typ_Sprzedazy], [Ilosc], [Rozmiar], [Kolor], [Cena]) VALUES (21, 11, 1, 3, N'M', N'czarny', 90)
INSERT [dbo].[Stan_Magazynowy] ([ID_Produktu], [Nr_Przedmiotu], [Typ_Sprzedazy], [Ilosc], [Rozmiar], [Kolor], [Cena]) VALUES (21, 12, 1, 4, N'L', N'Czarny', 90)
INSERT [dbo].[Stan_Magazynowy] ([ID_Produktu], [Nr_Przedmiotu], [Typ_Sprzedazy], [Ilosc], [Rozmiar], [Kolor], [Cena]) VALUES (9, 13, 2, 3, N'', N'', 10)
INSERT [dbo].[Stan_Magazynowy] ([ID_Produktu], [Nr_Przedmiotu], [Typ_Sprzedazy], [Ilosc], [Rozmiar], [Kolor], [Cena]) VALUES (2, 14, 2, 5, N'', N'', 5)
INSERT [dbo].[Stan_Magazynowy] ([ID_Produktu], [Nr_Przedmiotu], [Typ_Sprzedazy], [Ilosc], [Rozmiar], [Kolor], [Cena]) VALUES (31, 15, 2, 5, N'', N'', 5)
SET IDENTITY_INSERT [dbo].[Stan_Magazynowy] OFF
/****** Object:  Table [dbo].[Turnieje]    Script Date: 01/18/2011 19:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turnieje](
	[ID_Turnieju] [int] IDENTITY(1,1) NOT NULL,
	[ID_Klasyfikacji] [int] NULL,
	[Kategoria] [int] NOT NULL,
	[DataRozp] [date] NOT NULL,
	[DataZak] [date] NOT NULL,
	[Opis] [nvarchar](1000) NULL,
	[Nazwa] [nvarchar](50) NULL,
 CONSTRAINT [PK_Turnieje] PRIMARY KEY CLUSTERED 
(
	[ID_Turnieju] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Turnieje] ON
INSERT [dbo].[Turnieje] ([ID_Turnieju], [ID_Klasyfikacji], [Kategoria], [DataRozp], [DataZak], [Opis], [Nazwa]) VALUES (1, NULL, 1, CAST(0xC9330B00 AS Date), CAST(0xD6330B00 AS Date), N'Międzynarodowe tenisowe mistrzostwa Australii, pierwszy z czterech turniejów zaliczanych do Wielkiego Szlema, rozgrywane od 1905 roku.', N'Australian Open')
INSERT [dbo].[Turnieje] ([ID_Turnieju], [ID_Klasyfikacji], [Kategoria], [DataRozp], [DataZak], [Opis], [Nazwa]) VALUES (2, NULL, 2, CAST(0x41340B00 AS Date), CAST(0x54340B00 AS Date), N'Międzynarodowe mistrzostwa Francji w tenisie, jeden z czterech turniejów zaliczanych do Wielkiego Szlema rozgrywany w Paryżu na kortach imienia Rolanda Garrosa na przełomie maja i czerwca.', N'French Open')
INSERT [dbo].[Turnieje] ([ID_Turnieju], [ID_Klasyfikacji], [Kategoria], [DataRozp], [DataZak], [Opis], [Nazwa]) VALUES (3, NULL, 3, CAST(0x63340B00 AS Date), CAST(0xDA330B00 AS Date), N'Najstarszy i najbardziej prestiżowy turniej tenisowy w świecie – The Championships. Rozgrywany jest on od 1877 roku jako mistrzostwa Anglii, zaliczany jest do turniejów Wielkiego Szlema.', N'Wimbledon')
SET IDENTITY_INSERT [dbo].[Turnieje] OFF
/****** Object:  Table [dbo].[Wypozyczone]    Script Date: 01/18/2011 19:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Wypozyczone](
	[ID_Wypozyczenia] [int] IDENTITY(1,1) NOT NULL,
	[ID_Przedmiotu] [int] NOT NULL,
	[Id_Klienta] [int] NOT NULL,
	[Data_Rozpoczecia] [date] NOT NULL,
	[Godzina_Rozpoczecia] [int] NULL,
	[Data_Zakonczenia] [date] NOT NULL,
	[Godzina_Zakonczenia] [int] NULL,
	[Wypozyczono] [bit] NOT NULL,
	[Zwrocono] [bit] NULL,
 CONSTRAINT [PK_Wypozyczone] PRIMARY KEY CLUSTERED 
(
	[ID_Wypozyczenia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Wypozyczone] ON
INSERT [dbo].[Wypozyczone] ([ID_Wypozyczenia], [ID_Przedmiotu], [Id_Klienta], [Data_Rozpoczecia], [Godzina_Rozpoczecia], [Data_Zakonczenia], [Godzina_Zakonczenia], [Wypozyczono], [Zwrocono]) VALUES (1, 2, 1, CAST(0xA1330B00 AS Date), 10, CAST(0xA1330B00 AS Date), 12, 0, NULL)
INSERT [dbo].[Wypozyczone] ([ID_Wypozyczenia], [ID_Przedmiotu], [Id_Klienta], [Data_Rozpoczecia], [Godzina_Rozpoczecia], [Data_Zakonczenia], [Godzina_Zakonczenia], [Wypozyczono], [Zwrocono]) VALUES (2, 2, 1, CAST(0xA3330B00 AS Date), 10, CAST(0xA3330B00 AS Date), 12, 0, NULL)
INSERT [dbo].[Wypozyczone] ([ID_Wypozyczenia], [ID_Przedmiotu], [Id_Klienta], [Data_Rozpoczecia], [Godzina_Rozpoczecia], [Data_Zakonczenia], [Godzina_Zakonczenia], [Wypozyczono], [Zwrocono]) VALUES (3, 2, 1, CAST(0xA4330B00 AS Date), 10, CAST(0xA4330B00 AS Date), 12, 0, NULL)
INSERT [dbo].[Wypozyczone] ([ID_Wypozyczenia], [ID_Przedmiotu], [Id_Klienta], [Data_Rozpoczecia], [Godzina_Rozpoczecia], [Data_Zakonczenia], [Godzina_Zakonczenia], [Wypozyczono], [Zwrocono]) VALUES (4, 2, 1, CAST(0xAB330B00 AS Date), 12, CAST(0xAB330B00 AS Date), 14, 0, NULL)
INSERT [dbo].[Wypozyczone] ([ID_Wypozyczenia], [ID_Przedmiotu], [Id_Klienta], [Data_Rozpoczecia], [Godzina_Rozpoczecia], [Data_Zakonczenia], [Godzina_Zakonczenia], [Wypozyczono], [Zwrocono]) VALUES (5, 2, 1, CAST(0xA6330B00 AS Date), 11, CAST(0xA6330B00 AS Date), 14, 1, NULL)
INSERT [dbo].[Wypozyczone] ([ID_Wypozyczenia], [ID_Przedmiotu], [Id_Klienta], [Data_Rozpoczecia], [Godzina_Rozpoczecia], [Data_Zakonczenia], [Godzina_Zakonczenia], [Wypozyczono], [Zwrocono]) VALUES (6, 2, 1, CAST(0xA6330B00 AS Date), 10, CAST(0xA6330B00 AS Date), 11, 1, 1)
INSERT [dbo].[Wypozyczone] ([ID_Wypozyczenia], [ID_Przedmiotu], [Id_Klienta], [Data_Rozpoczecia], [Godzina_Rozpoczecia], [Data_Zakonczenia], [Godzina_Zakonczenia], [Wypozyczono], [Zwrocono]) VALUES (7, 13, 1, CAST(0xA7330B00 AS Date), 13, CAST(0xA7330B00 AS Date), 16, 0, NULL)
INSERT [dbo].[Wypozyczone] ([ID_Wypozyczenia], [ID_Przedmiotu], [Id_Klienta], [Data_Rozpoczecia], [Godzina_Rozpoczecia], [Data_Zakonczenia], [Godzina_Zakonczenia], [Wypozyczono], [Zwrocono]) VALUES (8, 8, 3, CAST(0xA9330B00 AS Date), 12, CAST(0xA9330B00 AS Date), 14, 0, NULL)
SET IDENTITY_INSERT [dbo].[Wypozyczone] OFF
/****** Object:  Table [dbo].[Mecze]    Script Date: 01/18/2011 19:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mecze](
	[ID_Meczu] [int] IDENTITY(1,1) NOT NULL,
	[ID_Turnieju] [int] NOT NULL,
	[Zawodnik1] [int] NOT NULL,
	[Zawodnik2] [int] NOT NULL,
	[CzyRozegrany] [int] NOT NULL,
	[Set1] [nchar](3) NULL,
	[Set2] [nchar](3) NULL,
	[Set3] [nchar](3) NULL,
	[Set4] [nchar](3) NULL,
	[Set5] [nchar](3) NULL,
 CONSTRAINT [PK_Mecze] PRIMARY KEY CLUSTERED 
(
	[ID_Meczu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListaGraczy]    Script Date: 01/18/2011 19:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListaGraczy](
	[ID_Listy] [int] IDENTITY(1,1) NOT NULL,
	[ID_Turnieju] [int] NOT NULL,
	[ID_Zawodnika] [int] NOT NULL,
 CONSTRAINT [PK_ListaGraczy] PRIMARY KEY CLUSTERED 
(
	[ID_Listy] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ListaGraczy] ON
INSERT [dbo].[ListaGraczy] ([ID_Listy], [ID_Turnieju], [ID_Zawodnika]) VALUES (19, 2, 18)
INSERT [dbo].[ListaGraczy] ([ID_Listy], [ID_Turnieju], [ID_Zawodnika]) VALUES (20, 3, 18)
INSERT [dbo].[ListaGraczy] ([ID_Listy], [ID_Turnieju], [ID_Zawodnika]) VALUES (21, 1, 19)
INSERT [dbo].[ListaGraczy] ([ID_Listy], [ID_Turnieju], [ID_Zawodnika]) VALUES (23, 3, 19)
SET IDENTITY_INSERT [dbo].[ListaGraczy] OFF
/****** Object:  ForeignKey [FK_Dostepnosc_Uzytkownicy_Kortow]    Script Date: 01/18/2011 19:11:18 ******/
ALTER TABLE [dbo].[Dostepnosc]  WITH CHECK ADD  CONSTRAINT [FK_Dostepnosc_Uzytkownicy_Kortow] FOREIGN KEY([ID])
REFERENCES [dbo].[Uzytkownicy_Kortow] ([ID])
GO
ALTER TABLE [dbo].[Dostepnosc] CHECK CONSTRAINT [FK_Dostepnosc_Uzytkownicy_Kortow]
GO
/****** Object:  ForeignKey [FK_Generalna_Zawodnicy]    Script Date: 01/18/2011 19:11:18 ******/
ALTER TABLE [dbo].[Generalna]  WITH CHECK ADD  CONSTRAINT [FK_Generalna_Zawodnicy] FOREIGN KEY([ID_Zawodnika])
REFERENCES [dbo].[Zawodnicy] ([ID_Zawodnika])
GO
ALTER TABLE [dbo].[Generalna] CHECK CONSTRAINT [FK_Generalna_Zawodnicy]
GO
/****** Object:  ForeignKey [FK_Klasyfikacje_Zawodnicy]    Script Date: 01/18/2011 19:11:18 ******/
ALTER TABLE [dbo].[Klasyfikacje]  WITH NOCHECK ADD  CONSTRAINT [FK_Klasyfikacje_Zawodnicy] FOREIGN KEY([ID_Zawodnika])
REFERENCES [dbo].[Zawodnicy] ([ID_Zawodnika])
NOT FOR REPLICATION
GO
ALTER TABLE [dbo].[Klasyfikacje] NOCHECK CONSTRAINT [FK_Klasyfikacje_Zawodnicy]
GO
/****** Object:  ForeignKey [FK_ListaGraczy_Turnieje]    Script Date: 01/18/2011 19:11:18 ******/
ALTER TABLE [dbo].[ListaGraczy]  WITH CHECK ADD  CONSTRAINT [FK_ListaGraczy_Turnieje] FOREIGN KEY([ID_Turnieju])
REFERENCES [dbo].[Turnieje] ([ID_Turnieju])
GO
ALTER TABLE [dbo].[ListaGraczy] CHECK CONSTRAINT [FK_ListaGraczy_Turnieje]
GO
/****** Object:  ForeignKey [FK_ListaGraczy_Zawodnicy]    Script Date: 01/18/2011 19:11:18 ******/
ALTER TABLE [dbo].[ListaGraczy]  WITH CHECK ADD  CONSTRAINT [FK_ListaGraczy_Zawodnicy] FOREIGN KEY([ID_Zawodnika])
REFERENCES [dbo].[Zawodnicy] ([ID_Zawodnika])
GO
ALTER TABLE [dbo].[ListaGraczy] CHECK CONSTRAINT [FK_ListaGraczy_Zawodnicy]
GO
/****** Object:  ForeignKey [FK_Mecze_Turnieje]    Script Date: 01/18/2011 19:11:18 ******/
ALTER TABLE [dbo].[Mecze]  WITH NOCHECK ADD  CONSTRAINT [FK_Mecze_Turnieje] FOREIGN KEY([ID_Turnieju])
REFERENCES [dbo].[Turnieje] ([ID_Turnieju])
NOT FOR REPLICATION
GO
ALTER TABLE [dbo].[Mecze] NOCHECK CONSTRAINT [FK_Mecze_Turnieje]
GO
/****** Object:  ForeignKey [FK_Mecze_Zawodnicy]    Script Date: 01/18/2011 19:11:18 ******/
ALTER TABLE [dbo].[Mecze]  WITH NOCHECK ADD  CONSTRAINT [FK_Mecze_Zawodnicy] FOREIGN KEY([Zawodnik1])
REFERENCES [dbo].[Zawodnicy] ([ID_Zawodnika])
NOT FOR REPLICATION
GO
ALTER TABLE [dbo].[Mecze] NOCHECK CONSTRAINT [FK_Mecze_Zawodnicy]
GO
/****** Object:  ForeignKey [FK_Mecze_Zawodnicy1]    Script Date: 01/18/2011 19:11:18 ******/
ALTER TABLE [dbo].[Mecze]  WITH NOCHECK ADD  CONSTRAINT [FK_Mecze_Zawodnicy1] FOREIGN KEY([Zawodnik2])
REFERENCES [dbo].[Zawodnicy] ([ID_Zawodnika])
NOT FOR REPLICATION
GO
ALTER TABLE [dbo].[Mecze] NOCHECK CONSTRAINT [FK_Mecze_Zawodnicy1]
GO
/****** Object:  ForeignKey [FK_Rezerwacje_Kortow_Pracownicy]    Script Date: 01/18/2011 19:11:18 ******/
ALTER TABLE [dbo].[Rezerwacje_Kortow]  WITH CHECK ADD  CONSTRAINT [FK_Rezerwacje_Kortow_Pracownicy] FOREIGN KEY([Id_Pracownika])
REFERENCES [dbo].[Pracownicy] ([Id_Pracownika])
GO
ALTER TABLE [dbo].[Rezerwacje_Kortow] CHECK CONSTRAINT [FK_Rezerwacje_Kortow_Pracownicy]
GO
/****** Object:  ForeignKey [FK_Rezerwacje_Kortow_Uzytkownicy_Kortow]    Script Date: 01/18/2011 19:11:18 ******/
ALTER TABLE [dbo].[Rezerwacje_Kortow]  WITH CHECK ADD  CONSTRAINT [FK_Rezerwacje_Kortow_Uzytkownicy_Kortow] FOREIGN KEY([ID_Osoby])
REFERENCES [dbo].[Uzytkownicy_Kortow] ([ID])
GO
ALTER TABLE [dbo].[Rezerwacje_Kortow] CHECK CONSTRAINT [FK_Rezerwacje_Kortow_Uzytkownicy_Kortow]
GO
/****** Object:  ForeignKey [FK_Serwis_Katalog_Uslug]    Script Date: 01/18/2011 19:11:18 ******/
ALTER TABLE [dbo].[Serwis]  WITH CHECK ADD  CONSTRAINT [FK_Serwis_Katalog_Uslug] FOREIGN KEY([Usługa])
REFERENCES [dbo].[Katalog_Uslug] ([ID_Uslugi])
GO
ALTER TABLE [dbo].[Serwis] CHECK CONSTRAINT [FK_Serwis_Katalog_Uslug]
GO
/****** Object:  ForeignKey [FK_Serwis_Stan_Uslug]    Script Date: 01/18/2011 19:11:18 ******/
ALTER TABLE [dbo].[Serwis]  WITH CHECK ADD  CONSTRAINT [FK_Serwis_Stan_Uslug] FOREIGN KEY([Stan])
REFERENCES [dbo].[Stan_Uslug] ([ID_Stanu])
GO
ALTER TABLE [dbo].[Serwis] CHECK CONSTRAINT [FK_Serwis_Stan_Uslug]
GO
/****** Object:  ForeignKey [FK_Serwis_Uzytkownicy_Kortow]    Script Date: 01/18/2011 19:11:18 ******/
ALTER TABLE [dbo].[Serwis]  WITH CHECK ADD  CONSTRAINT [FK_Serwis_Uzytkownicy_Kortow] FOREIGN KEY([ID_Klienta])
REFERENCES [dbo].[Uzytkownicy_Kortow] ([ID])
GO
ALTER TABLE [dbo].[Serwis] CHECK CONSTRAINT [FK_Serwis_Uzytkownicy_Kortow]
GO
/****** Object:  ForeignKey [FK_Sparingpartnerzy_Uzytkownicy_Kortow]    Script Date: 01/18/2011 19:11:18 ******/
ALTER TABLE [dbo].[Sparingpartnerzy]  WITH CHECK ADD  CONSTRAINT [FK_Sparingpartnerzy_Uzytkownicy_Kortow] FOREIGN KEY([ID_Osoby])
REFERENCES [dbo].[Uzytkownicy_Kortow] ([ID])
GO
ALTER TABLE [dbo].[Sparingpartnerzy] CHECK CONSTRAINT [FK_Sparingpartnerzy_Uzytkownicy_Kortow]
GO
/****** Object:  ForeignKey [FK_Sprzet_Typy]    Script Date: 01/18/2011 19:11:18 ******/
ALTER TABLE [dbo].[Sprzet]  WITH CHECK ADD  CONSTRAINT [FK_Sprzet_Typy] FOREIGN KEY([Typ])
REFERENCES [dbo].[Typy] ([Nr_Typu])
GO
ALTER TABLE [dbo].[Sprzet] CHECK CONSTRAINT [FK_Sprzet_Typy]
GO
/****** Object:  ForeignKey [FK_Stan_Magazynowy_Sprzet]    Script Date: 01/18/2011 19:11:18 ******/
ALTER TABLE [dbo].[Stan_Magazynowy]  WITH CHECK ADD  CONSTRAINT [FK_Stan_Magazynowy_Sprzet] FOREIGN KEY([ID_Produktu])
REFERENCES [dbo].[Sprzet] ([ID_Produktu])
GO
ALTER TABLE [dbo].[Stan_Magazynowy] CHECK CONSTRAINT [FK_Stan_Magazynowy_Sprzet]
GO
/****** Object:  ForeignKey [FK_Trenerzy_Uzytkownicy_Kortow]    Script Date: 01/18/2011 19:11:18 ******/
ALTER TABLE [dbo].[Trenerzy]  WITH CHECK ADD  CONSTRAINT [FK_Trenerzy_Uzytkownicy_Kortow] FOREIGN KEY([ID_Osoby])
REFERENCES [dbo].[Uzytkownicy_Kortow] ([ID])
GO
ALTER TABLE [dbo].[Trenerzy] CHECK CONSTRAINT [FK_Trenerzy_Uzytkownicy_Kortow]
GO
/****** Object:  ForeignKey [FK_Turnieje_Kategorie1]    Script Date: 01/18/2011 19:11:18 ******/
ALTER TABLE [dbo].[Turnieje]  WITH NOCHECK ADD  CONSTRAINT [FK_Turnieje_Kategorie1] FOREIGN KEY([Kategoria])
REFERENCES [dbo].[Kategorie] ([ID_Kategorii])
NOT FOR REPLICATION
GO
ALTER TABLE [dbo].[Turnieje] NOCHECK CONSTRAINT [FK_Turnieje_Kategorie1]
GO
/****** Object:  ForeignKey [FK_Turnieje_Klasyfikacje]    Script Date: 01/18/2011 19:11:18 ******/
ALTER TABLE [dbo].[Turnieje]  WITH NOCHECK ADD  CONSTRAINT [FK_Turnieje_Klasyfikacje] FOREIGN KEY([ID_Klasyfikacji])
REFERENCES [dbo].[Klasyfikacje] ([ID_Klasyfikacji])
NOT FOR REPLICATION
GO
ALTER TABLE [dbo].[Turnieje] NOCHECK CONSTRAINT [FK_Turnieje_Klasyfikacje]
GO
/****** Object:  ForeignKey [FK_Uzytkownicy_Systemu_Pracownicy1]    Script Date: 01/18/2011 19:11:18 ******/
ALTER TABLE [dbo].[Uzytkownicy_Systemu]  WITH CHECK ADD  CONSTRAINT [FK_Uzytkownicy_Systemu_Pracownicy1] FOREIGN KEY([ID_Pracownika])
REFERENCES [dbo].[Pracownicy] ([Id_Pracownika])
GO
ALTER TABLE [dbo].[Uzytkownicy_Systemu] CHECK CONSTRAINT [FK_Uzytkownicy_Systemu_Pracownicy1]
GO
/****** Object:  ForeignKey [FK_Wypozyczone_Stan_Magazynowy]    Script Date: 01/18/2011 19:11:18 ******/
ALTER TABLE [dbo].[Wypozyczone]  WITH CHECK ADD  CONSTRAINT [FK_Wypozyczone_Stan_Magazynowy] FOREIGN KEY([ID_Przedmiotu])
REFERENCES [dbo].[Stan_Magazynowy] ([Nr_Przedmiotu])
GO
ALTER TABLE [dbo].[Wypozyczone] CHECK CONSTRAINT [FK_Wypozyczone_Stan_Magazynowy]
GO
/****** Object:  ForeignKey [FK_Wypozyczone_Uzytkownicy_Kortow]    Script Date: 01/18/2011 19:11:18 ******/
ALTER TABLE [dbo].[Wypozyczone]  WITH CHECK ADD  CONSTRAINT [FK_Wypozyczone_Uzytkownicy_Kortow] FOREIGN KEY([Id_Klienta])
REFERENCES [dbo].[Uzytkownicy_Kortow] ([ID])
GO
ALTER TABLE [dbo].[Wypozyczone] CHECK CONSTRAINT [FK_Wypozyczone_Uzytkownicy_Kortow]
GO

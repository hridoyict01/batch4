USE [master]
GO
/****** Object:  Database [StudentDBBitm]    Script Date: 6/20/2019 5:09:29 PM ******/
CREATE DATABASE [StudentDBBitm]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StudentDBBitm', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\StudentDBBitm.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'StudentDBBitm_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\StudentDBBitm_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [StudentDBBitm] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StudentDBBitm].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StudentDBBitm] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StudentDBBitm] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StudentDBBitm] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StudentDBBitm] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StudentDBBitm] SET ARITHABORT OFF 
GO
ALTER DATABASE [StudentDBBitm] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [StudentDBBitm] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [StudentDBBitm] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StudentDBBitm] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StudentDBBitm] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StudentDBBitm] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StudentDBBitm] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StudentDBBitm] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StudentDBBitm] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StudentDBBitm] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StudentDBBitm] SET  ENABLE_BROKER 
GO
ALTER DATABASE [StudentDBBitm] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StudentDBBitm] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StudentDBBitm] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StudentDBBitm] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StudentDBBitm] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StudentDBBitm] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StudentDBBitm] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StudentDBBitm] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [StudentDBBitm] SET  MULTI_USER 
GO
ALTER DATABASE [StudentDBBitm] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StudentDBBitm] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StudentDBBitm] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StudentDBBitm] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [StudentDBBitm]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 6/20/2019 5:09:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Departments](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Code] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Districts]    Script Date: 6/20/2019 5:09:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Districts](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Marks]    Script Date: 6/20/2019 5:09:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marks](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [int] NULL,
	[DepartmentId] [int] NULL,
	[SubjectId] [int] NULL,
	[MArks] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Students]    Script Date: 6/20/2019 5:09:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Students](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RollNo] [varchar](10) NULL,
	[Name] [varchar](100) NULL,
	[Age] [int] NULL,
	[Address] [varchar](max) NULL,
	[DistrictID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 6/20/2019 5:09:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Subjects](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Code] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[StudentsView]    Script Date: 6/20/2019 5:09:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[StudentsView]
AS
SELECT s.ID, RollNo, s.Name, Age, Address, DistrictID, d.Name AS District FROM Students AS s
LEFT JOIN Districts AS d ON d.ID = s.DistrictID
GO
SET IDENTITY_INSERT [dbo].[Departments] ON 

INSERT [dbo].[Departments] ([ID], [Name], [Code]) VALUES (1, N'', N'')
INSERT [dbo].[Departments] ([ID], [Name], [Code]) VALUES (2, N'Computer Science & Engineering', N'CSE')
INSERT [dbo].[Departments] ([ID], [Name], [Code]) VALUES (3, N'Electrical & Electronics Engineering', N'EEE')
SET IDENTITY_INSERT [dbo].[Departments] OFF
SET IDENTITY_INSERT [dbo].[Districts] ON 

INSERT [dbo].[Districts] ([ID], [Name]) VALUES (1, N'Dhaka')
INSERT [dbo].[Districts] ([ID], [Name]) VALUES (2, N'Chitagong')
INSERT [dbo].[Districts] ([ID], [Name]) VALUES (3, N'Sylhet')
INSERT [dbo].[Districts] ([ID], [Name]) VALUES (4, N'Pabna')
SET IDENTITY_INSERT [dbo].[Districts] OFF
SET IDENTITY_INSERT [dbo].[Marks] ON 

INSERT [dbo].[Marks] ([ID], [StudentId], [DepartmentId], [SubjectId], [MArks]) VALUES (1, 1, 1, 1, 99)
INSERT [dbo].[Marks] ([ID], [StudentId], [DepartmentId], [SubjectId], [MArks]) VALUES (2, 1, 1, 2, 96)
INSERT [dbo].[Marks] ([ID], [StudentId], [DepartmentId], [SubjectId], [MArks]) VALUES (3, 2, 1, 1, 83)
INSERT [dbo].[Marks] ([ID], [StudentId], [DepartmentId], [SubjectId], [MArks]) VALUES (4, 2, 1, 3, 79)
INSERT [dbo].[Marks] ([ID], [StudentId], [DepartmentId], [SubjectId], [MArks]) VALUES (5, 3, 1, 2, 53)
INSERT [dbo].[Marks] ([ID], [StudentId], [DepartmentId], [SubjectId], [MArks]) VALUES (6, 3, 1, 3, 90)
INSERT [dbo].[Marks] ([ID], [StudentId], [DepartmentId], [SubjectId], [MArks]) VALUES (7, 4, 2, 4, 100)
INSERT [dbo].[Marks] ([ID], [StudentId], [DepartmentId], [SubjectId], [MArks]) VALUES (8, 4, 2, 5, 99)
INSERT [dbo].[Marks] ([ID], [StudentId], [DepartmentId], [SubjectId], [MArks]) VALUES (9, 5, 2, 5, 89)
INSERT [dbo].[Marks] ([ID], [StudentId], [DepartmentId], [SubjectId], [MArks]) VALUES (10, 5, 2, 6, 90)
INSERT [dbo].[Marks] ([ID], [StudentId], [DepartmentId], [SubjectId], [MArks]) VALUES (11, 6, 2, 6, 79)
INSERT [dbo].[Marks] ([ID], [StudentId], [DepartmentId], [SubjectId], [MArks]) VALUES (12, 6, 2, 4, 90)
SET IDENTITY_INSERT [dbo].[Marks] OFF
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([ID], [RollNo], [Name], [Age], [Address], [DistrictID]) VALUES (15, N'CSE001', N'Ali++++***', 21, N'Mirpur', 1)
INSERT [dbo].[Students] ([ID], [RollNo], [Name], [Age], [Address], [DistrictID]) VALUES (16, N'CSE002', N'Arif++', 22, N'Savar', 1)
INSERT [dbo].[Students] ([ID], [RollNo], [Name], [Age], [Address], [DistrictID]) VALUES (17, N'CSE003', N'Kabir++++', 20, N'Dhanmondi', 1)
INSERT [dbo].[Students] ([ID], [RollNo], [Name], [Age], [Address], [DistrictID]) VALUES (18, N'EEE001', N'Araf+++', 21, N'Uttora', 1)
INSERT [dbo].[Students] ([ID], [RollNo], [Name], [Age], [Address], [DistrictID]) VALUES (19, N'EEE002', N'Ali', 21, N'Motijhil', 2)
INSERT [dbo].[Students] ([ID], [RollNo], [Name], [Age], [Address], [DistrictID]) VALUES (20, N'EEE003', N'Snigdha', 21, N'Uttora', 1)
INSERT [dbo].[Students] ([ID], [RollNo], [Name], [Age], [Address], [DistrictID]) VALUES (24, N'ICT02', N'Noor+++', 27, N'Doha', 1)
SET IDENTITY_INSERT [dbo].[Students] OFF
SET IDENTITY_INSERT [dbo].[Subjects] ON 

INSERT [dbo].[Subjects] ([ID], [Name], [Code]) VALUES (1, N'C++', N'CSE101')
INSERT [dbo].[Subjects] ([ID], [Name], [Code]) VALUES (2, N'Java', N'CSE102')
INSERT [dbo].[Subjects] ([ID], [Name], [Code]) VALUES (3, N'OOP', N'CSE103')
INSERT [dbo].[Subjects] ([ID], [Name], [Code]) VALUES (4, N'Electronics', N'EEE101')
INSERT [dbo].[Subjects] ([ID], [Name], [Code]) VALUES (5, N'Phy', N'EEE102')
INSERT [dbo].[Subjects] ([ID], [Name], [Code]) VALUES (6, N'Digital Board', N'EEE102')
SET IDENTITY_INSERT [dbo].[Subjects] OFF
ALTER TABLE [dbo].[Students]  WITH CHECK ADD FOREIGN KEY([DistrictID])
REFERENCES [dbo].[Districts] ([ID])
GO
USE [master]
GO
ALTER DATABASE [StudentDBBitm] SET  READ_WRITE 
GO

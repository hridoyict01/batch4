USE [StudentDBHridoy]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 6/13/2019 2:05:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categories](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 6/13/2019 2:05:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Departments](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Districts]    Script Date: 6/13/2019 2:05:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Districts](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Namr] [varchar](100) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Marks]    Script Date: 6/13/2019 2:05:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marks](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NULL,
	[DepartmentID] [int] NULL,
	[SubjectID] [int] NULL,
	[Mark] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 6/13/2019 2:05:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Products](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[CategoryId] [int] NOT NULL,
	[Price] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Students]    Script Date: 6/13/2019 2:05:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Students](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Roll] [int] NULL,
	[Name] [varchar](100) NULL,
	[Age] [int] NULL,
	[Address] [varchar](150) NULL,
	[DistrictID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 6/13/2019 2:05:21 PM ******/
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
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([ID], [Name]) VALUES (1, N'Fashion')
INSERT [dbo].[Categories] ([ID], [Name]) VALUES (2, N'Electronics')
INSERT [dbo].[Categories] ([ID], [Name]) VALUES (3, N'Mobile')
INSERT [dbo].[Categories] ([ID], [Name]) VALUES (4, N'Computer')
SET IDENTITY_INSERT [dbo].[Categories] OFF
SET IDENTITY_INSERT [dbo].[Departments] ON 

INSERT [dbo].[Departments] ([ID], [Name]) VALUES (1, N'ICT')
INSERT [dbo].[Departments] ([ID], [Name]) VALUES (2, N'CSE')
SET IDENTITY_INSERT [dbo].[Departments] OFF
SET IDENTITY_INSERT [dbo].[Districts] ON 

INSERT [dbo].[Districts] ([ID], [Namr]) VALUES (1, N'Dhaka')
INSERT [dbo].[Districts] ([ID], [Namr]) VALUES (2, N'Comilla')
SET IDENTITY_INSERT [dbo].[Districts] OFF
SET IDENTITY_INSERT [dbo].[Marks] ON 

INSERT [dbo].[Marks] ([ID], [StudentID], [DepartmentID], [SubjectID], [Mark]) VALUES (1, 1109001, 1, 1, 85)
INSERT [dbo].[Marks] ([ID], [StudentID], [DepartmentID], [SubjectID], [Mark]) VALUES (2, 1109001, 1, 2, 90)
INSERT [dbo].[Marks] ([ID], [StudentID], [DepartmentID], [SubjectID], [Mark]) VALUES (3, 1109002, 1, 1, 85)
INSERT [dbo].[Marks] ([ID], [StudentID], [DepartmentID], [SubjectID], [Mark]) VALUES (4, 1109002, 1, 2, 90)
INSERT [dbo].[Marks] ([ID], [StudentID], [DepartmentID], [SubjectID], [Mark]) VALUES (5, 1109003, 2, 4, 79)
INSERT [dbo].[Marks] ([ID], [StudentID], [DepartmentID], [SubjectID], [Mark]) VALUES (6, 1109003, 2, 5, 86)
INSERT [dbo].[Marks] ([ID], [StudentID], [DepartmentID], [SubjectID], [Mark]) VALUES (7, 1109004, 2, 5, 95)
INSERT [dbo].[Marks] ([ID], [StudentID], [DepartmentID], [SubjectID], [Mark]) VALUES (8, 1109004, 2, 6, 86)
INSERT [dbo].[Marks] ([ID], [StudentID], [DepartmentID], [SubjectID], [Mark]) VALUES (9, 1109005, 2, 6, 70)
INSERT [dbo].[Marks] ([ID], [StudentID], [DepartmentID], [SubjectID], [Mark]) VALUES (10, 1109005, 2, 4, 56)
INSERT [dbo].[Marks] ([ID], [StudentID], [DepartmentID], [SubjectID], [Mark]) VALUES (11, 1109006, 2, 5, 82)
INSERT [dbo].[Marks] ([ID], [StudentID], [DepartmentID], [SubjectID], [Mark]) VALUES (12, 1109006, 2, 6, 83)
SET IDENTITY_INSERT [dbo].[Marks] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ID], [Name], [CategoryId], [Price]) VALUES (1, N'SHIRT', 1, 101)
INSERT [dbo].[Products] ([ID], [Name], [CategoryId], [Price]) VALUES (2, N'Washing Machine', 2, 2000)
INSERT [dbo].[Products] ([ID], [Name], [CategoryId], [Price]) VALUES (3, N'Pant', 1, 5000)
INSERT [dbo].[Products] ([ID], [Name], [CategoryId], [Price]) VALUES (4, N'Fan', 2, 1600)
INSERT [dbo].[Products] ([ID], [Name], [CategoryId], [Price]) VALUES (5, N'Samsung s8', 3, 25000)
INSERT [dbo].[Products] ([ID], [Name], [CategoryId], [Price]) VALUES (6, N'Asus Zenfone', 3, 2500)
INSERT [dbo].[Products] ([ID], [Name], [CategoryId], [Price]) VALUES (7, N'Samsung Ram 8gb', 4, 8000)
INSERT [dbo].[Products] ([ID], [Name], [CategoryId], [Price]) VALUES (8, N'Asus 21" monitor', 4, 8589633)
SET IDENTITY_INSERT [dbo].[Products] OFF
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([ID], [Roll], [Name], [Age], [Address], [DistrictID]) VALUES (1, 1109001, N'X', 25, N'Basabo', 1)
INSERT [dbo].[Students] ([ID], [Roll], [Name], [Age], [Address], [DistrictID]) VALUES (2, 1109002, N'Y', 26, N'Shalbon', 2)
INSERT [dbo].[Students] ([ID], [Roll], [Name], [Age], [Address], [DistrictID]) VALUES (3, 1109003, N'Z', 29, N'Taltola', 1)
INSERT [dbo].[Students] ([ID], [Roll], [Name], [Age], [Address], [DistrictID]) VALUES (4, 1109004, N'P', 24, N'Khailgaon', 1)
INSERT [dbo].[Students] ([ID], [Roll], [Name], [Age], [Address], [DistrictID]) VALUES (5, 1109005, N'Q', 25, N'Rani Bazar', 2)
INSERT [dbo].[Students] ([ID], [Roll], [Name], [Age], [Address], [DistrictID]) VALUES (6, 1109006, N'R', 27, N'Kandirpar', 2)
INSERT [dbo].[Students] ([ID], [Roll], [Name], [Age], [Address], [DistrictID]) VALUES (7, 1109007, N'S', 19, N'Oxyzen', 3)
SET IDENTITY_INSERT [dbo].[Students] OFF
SET IDENTITY_INSERT [dbo].[Subjects] ON 

INSERT [dbo].[Subjects] ([ID], [Name], [Code]) VALUES (1, N'Computer Fundamentals', N'ICT-101')
INSERT [dbo].[Subjects] ([ID], [Name], [Code]) VALUES (2, N'Digital Communication', N'ICT-102')
INSERT [dbo].[Subjects] ([ID], [Name], [Code]) VALUES (3, N'Analog Communication', N'ICT-103')
INSERT [dbo].[Subjects] ([ID], [Name], [Code]) VALUES (4, N'Math', N'CSE-101')
INSERT [dbo].[Subjects] ([ID], [Name], [Code]) VALUES (5, N'VLSI', N'CSE-102')
INSERT [dbo].[Subjects] ([ID], [Name], [Code]) VALUES (6, N'Compiler Design', N'CSE-103')
SET IDENTITY_INSERT [dbo].[Subjects] OFF

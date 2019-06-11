USE [StudentDB]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 6/11/2019 3:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Students](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
	[Age] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([ID], [Name], [Age]) VALUES (1, N'Hridoy', 25)
INSERT [dbo].[Students] ([ID], [Name], [Age]) VALUES (2, N'Bancha', 24)
INSERT [dbo].[Students] ([ID], [Name], [Age]) VALUES (3, N'Kamal', 24)
SET IDENTITY_INSERT [dbo].[Students] OFF

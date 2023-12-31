USE [ClientDB]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 2023/06/28 10:39:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ID] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[DateRegistered] [datetime] NULL,
	[Location] [nvarchar](max) NULL,
	[NumberOfUsers] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Clients] ([ID], [Name], [DateRegistered], [Location], [NumberOfUsers]) VALUES (N'7a62988a-6bd7-4957-8784-3e5b175b2b25', N'Tumelo', CAST(N'2023-06-25T00:00:00.000' AS DateTime), N'Midrand', 9)
INSERT [dbo].[Clients] ([ID], [Name], [DateRegistered], [Location], [NumberOfUsers]) VALUES (N'ea83235e-d8ea-4ea9-8d2b-54a8ed57ab7d', N'Tumelo', CAST(N'2023-06-28T00:00:00.000' AS DateTime), N'Clayville', 5)
INSERT [dbo].[Clients] ([ID], [Name], [DateRegistered], [Location], [NumberOfUsers]) VALUES (N'af049609-d697-4e34-9ecb-71978d50eabd', N'Anna', CAST(N'2023-02-24T00:00:00.000' AS DateTime), N'Centurion', 25)
INSERT [dbo].[Clients] ([ID], [Name], [DateRegistered], [Location], [NumberOfUsers]) VALUES (N'96ee0ce4-6c5b-480c-9725-8b7693d10ce1', N'Doctor', CAST(N'2023-07-23T00:00:00.000' AS DateTime), N'Tembisa', 3)
INSERT [dbo].[Clients] ([ID], [Name], [DateRegistered], [Location], [NumberOfUsers]) VALUES (N'd1617c99-15d4-49e0-9492-a4e4eba6d9cf', N'Thabo', CAST(N'2023-06-28T00:00:00.000' AS DateTime), N'Tembisa', 20)
GO

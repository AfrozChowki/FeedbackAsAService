USE [Test]
GO

/****** Object:  Table [dbo].[Feedback]    Script Date: 10-05-2023 14:17:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Feedback](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [varchar](50) NOT NULL,
	[PageURL] [varchar](255) NOT NULL,
	[PageName] [varchar](255) NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[FeedbackMessage] [varchar](max) NOT NULL,
	[Rating] [decimal](18, 0) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[ProjectName] [varchar](100) NOT NULL,
	[Image] [varchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Feedback]  WITH CHECK ADD FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([CategoryId])
GO

ALTER TABLE [dbo].[Feedback]  WITH CHECK ADD FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([CategoryId])
GO



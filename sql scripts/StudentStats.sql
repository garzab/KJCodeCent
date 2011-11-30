USE [DHCDB]
GO

/****** Object:  Table [dbo].[StudentStats]    Script Date: 11/29/2011 18:39:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StudentStats](
	[studentID] [int] NOT NULL,
	[firstYear] [text] NULL,
	[appStatus] [text] NULL,
	[currentCWU] [text] NULL,
	[dateRec] [datetime2](7) NULL,
	[transfer] [text] NULL,
	[qtrEntDhc] [text] NULL,
	[qtrEntCwu] [text] NULL,
	[status] [text] NULL,
	[statusDate] [datetime2](7) NULL,
	[directorAction] [text] NULL,
	[directorDate] [datetime2](7) NULL,
	[coreHybrid] [text] NULL,
	[standing] [text] NULL,
 CONSTRAINT [PK_StudentStats] PRIMARY KEY CLUSTERED 
(
	[studentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


USE [DHCDB]
GO

/****** Object:  Table [dbo].[StudentInfo]    Script Date: 11/29/2011 18:39:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[StudentInfo](
	[studentID] [int] NOT NULL,
	[archived] [varchar](50) NOT NULL,
	[firstName] [varchar](50) NOT NULL,
	[middleInit] [varchar](50) NOT NULL,
	[lastName] [varchar](50) NOT NULL,
	[birthday] [date] NOT NULL,
	[addr] [text] NULL,
	[city] [text] NULL,
	[state] [char](10) NULL,
	[zip] [int] NULL,
	[homePhone] [text] NULL,
	[cellPhone] [text] NOT NULL,
	[stdEmail] [varchar](50) NOT NULL,
	[cwuEmail] [varchar](50) NOT NULL,
	[notes] [text] NULL,
 CONSTRAINT [PK_StudentInfo_1] PRIMARY KEY CLUSTERED 
(
	[studentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


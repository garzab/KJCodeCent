USE [DHCDB]
GO

/****** Object:  Table [dbo].[Grades]    Script Date: 11/29/2011 18:39:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Grades](
	[studentID] [int] NULL,
	[c_dhc140] [nchar](10) NULL,
	[c_dhc141] [nchar](10) NULL,
	[c_dhc150] [nchar](10) NULL,
	[c_dhc151] [nchar](10) NULL,
	[c_dhc160] [nchar](10) NULL,
	[c_dhc161] [nchar](10) NULL,
	[c_dhc250] [nchar](10) NULL,
	[c_dhc251] [nchar](10) NULL,
	[c_dhc260] [nchar](10) NULL,
	[c_dhc261] [nchar](10) NULL,
	[c_dhc270] [nchar](10) NULL,
	[c_dhc301] [nchar](10) NULL,
	[c_dhc380] [nchar](10) NULL,
	[c_dhc399] [nchar](10) NULL,
	[c_dhc401] [nchar](10) NULL,
	[c_dhc497] [nchar](10) NULL,
	[c_shp301] [nchar](10) NULL,
	[c_shp401] [nchar](10) NULL,
	[c_shp497] [nchar](10) NULL,
	[sat] [nchar](10) NULL,
	[act] [nchar](10) NULL,
	[ai] [nchar](10) NULL,
	[collegeGPA] [nchar](10) NULL,
	[priorGPA] [nchar](10) NULL,
	[cumGPA] [nchar](10) NULL
) ON [PRIMARY]

GO




CREATE TABLE [dbo].[AircraftType](
	[aircraftTypeId] [bigint] IDENTITY(1,1) NOT NULL,
	[iataCode] [nvarchar](10) NOT NULL,
	[icaoCode] [nvarchar](10) NULL,
	[name] [nvarchar](80) NOT NULL,
	[dataVersion] [int] NOT NULL,
	[ATTR_28] [nvarchar](max) NULL,
	[ATTR_29] [nvarchar](max) NULL,
	[ATTR_30] [int] NULL,
	[ATTR_34] [int] NULL,
	[ATTR_35] [int] NULL,
	[ATTR_36] [int] NULL,
	[ATTR_37] [int] NULL,
	[ATTR_38] [int] NULL,
	[ATTR_39] [int] NULL,
	[ATTR_190] [float] NULL,
	[ATTR_191] [float] NULL,
	[ATTR_192] [float] NULL,
 CONSTRAINT [AircraftType_PK] PRIMARY KEY NONCLUSTERED 
(
	[aircraftTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 20) ON [PRIMARY],
 CONSTRAINT [uc_AircraftType_IataCode] UNIQUE NONCLUSTERED 
(
	[iataCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 20) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


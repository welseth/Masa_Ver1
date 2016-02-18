CREATE TABLE [dbo].[Members] (
    [Member_refnum] INT            IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (MAX) NULL,
    [Instructor]    BIT            DEFAULT ((0)) NULL,
    [Tow Pilot]     BIT            DEFAULT ((0)) NULL,
    [MASA_Member]   BIT            DEFAULT ((1)) NULL,
    [Guest_Member]  BIT            DEFAULT ((0)) NULL,
    PRIMARY KEY CLUSTERED ([Member_refnum] ASC)
);


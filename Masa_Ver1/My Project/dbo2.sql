CREATE TABLE [dbo].[Aircraft] (
    [Aircraft_refnum]       INT            IDENTITY (1, 1) NOT NULL,
    [Aircraft_name]         NVARCHAR (MAX) NULL,
    [Manufacturer]          NVARCHAR (MAX) NULL,
    [N-number]              NVARCHAR (MAX) NULL,
    [Seats]                 INT            NULL,
    [Glider]                BIT            NULL,
    [TowPlane]              BIT            NULL,
    [Cost_per_hour]         MONEY          NULL,
    [Privately_owned]       BIT            NULL,
    [Total_flight_time]     TIME (0)       NULL,
    [Total_launches]        INT            NULL,
    [Last_annual_performed] DATE           NULL,
    PRIMARY KEY CLUSTERED ([Aircraft_refnum] ASC)
);


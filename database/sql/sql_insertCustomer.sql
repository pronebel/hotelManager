USE [HotelManage]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



--region [dbo].[usp_InsertCustomer]

CREATE PROCEDURE [dbo].[usp_AddCustomer]
	@RoomId nvarchar(50),
	@Name nvarchar(50),
	@Sex nvarchar(50),
	@IdentifyNumber nvarchar(50),
	@Phone nvarchar(50),
	@Charge int,
	@CheckinDate DateTime,
	@CheckoutDate datetime,
	@UserNum int
AS

SET NOCOUNT ON

INSERT INTO [dbo].[Customer] (
	[RoomId],
	[Name],
	[Sex],
	[IdentifyNumber],
	[Phone],
	[Charge],
	[CheckinDate],
	[CheckoutDate],
	[UserNum]
) VALUES (
	@RoomId,
	@Name,
	@Sex,
	@IdentifyNumber,
	@Phone,
	@Charge,
	@CheckinDate,
	@CheckoutDate,
	@UserNum
)

SELECT  @@IDENTITY

--endregion




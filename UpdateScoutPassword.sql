USE [Scouting System]
GO
/****** Object:  StoredProcedure [dbo].[UpdateFAPassword]    Script Date: 21/12/2019 6:46:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE UpdateScoutPassword
	-- Add the parameters for the stored procedure here
	@SID int,
	@password varchar(66)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	Update Scout SET Password = @password where [SID] = @SID 
END

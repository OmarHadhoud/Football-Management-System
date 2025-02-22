USE [Scouting System]
GO
/****** Object:  StoredProcedure [dbo].[Order_search_PlayerForScouts]    Script Date: 14/12/2019 10:34:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[Order_search_PlayerForScouts]
	-- Add the parameters for the stored procedure here
	@orderby	int	,	
	@inputN varchar(50),
	@orderDir bit	
	AS
BEGIN
-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET @orderby = ISNULL(@orderby,0)
    -- Insert statements for procedure here

select PID
	  ,[Fname]
      ,[Lname]
      ,DATEDIFF(YY,Bdate,GETDATE()) As Age
      ,[Position]
      ,[Height]      
      ,[Status]
	  ,club.[Name] as [Club]
  FROM [Player] left join club on (CID=ClubID or CID=YouthClubID) where (@inputN is null )or  Fname Like @inputN+'%'  or Lname Like @inputN + '%' 


	order by 
	
	case WHEN @orderby = 1 AND @orderDir =0 THEN [Fname] end asc,
    case WHEN @orderby = 2 AND @orderDir =0 THEN [Lname] end asc,
	case WHEN @orderby = 3 AND @orderDir =0 THEN DATEDIFF(YY,Bdate,GETDATE()) end asc,
    case WHEN @orderby = 4 AND @orderDir =0 THEN [Position] end asc,
	case WHEN @orderby = 5 AND @orderDir =0 THEN [Height]end asc,
	case WHEN @orderby = 6 AND @orderDir =0 THEN [Status] end asc,

	case WHEN @orderby = 1 AND @orderDir =1 THEN [Fname] end desc,
    case WHEN @orderby = 2 AND @orderDir =1 THEN [Lname] end desc,
	case WHEN @orderby = 3 AND @orderDir =1 THEN DATEDIFF(YY,Bdate,GETDATE()) end desc,
    case WHEN @orderby = 4 AND @orderDir =1 THEN [Position] end desc,
	case WHEN @orderby = 5 AND @orderDir =1 THEN [Height]end desc,
	case WHEN @orderby = 6 AND @orderDir =1 THEN [Status]end desc




END

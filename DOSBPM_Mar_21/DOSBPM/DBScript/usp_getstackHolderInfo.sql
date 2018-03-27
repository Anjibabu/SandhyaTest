CREATE PROCEDURE [dbo].[usp_getstackHolderInfo]
	@SearchStr varchar(50),
	@type varchar(5)
AS
BEGIN
	SELECT 
    ads.[ZIP] AS [ZIP], 
    sh.[StkHoldType_ID] AS [StkHoldType_ID], 
    sh.[StkHoldType_Name] AS [StkHoldType_Name], 
    ii.[IndiInfo_FirstName] AS [IndiInfo_FirstName], 
    ii.[IndiInfo_LastName] AS [IndiInfo_LastName], 
    ii.[Address_ID] AS [Address_ID], 
    ads.[Address_1] AS [Address_1], 
    ads.[Address_2] AS [Address_2], 
    ads.[City] AS [City], 
    ads.[StateName] AS [StateName], 
    ads.[CountryName] AS [CountryName], 
    ads.[County_ID] AS [County_ID], 
    ads.[State_ID] AS [State_ID], 
    ads.[Country_ID] AS [Country_ID], 
    ii.[ContAdd_TelephoneNumber] AS [ContAdd_TelephoneNumber], 
    ii.[ContAdd_EmailID] AS [ContAdd_EmailID]
    FROM   [dbo].[L_StakeHolderType] AS sh
    INNER JOIN [dbo].[T_IndividualInformation] AS ii ON sh.[StkHoldType_ID] = ii.[StkHoldType_ID]
    INNER JOIN [dbo].[T_Address] AS ads ON ii.[Address_ID] = ads.[Address_ID]
    WHERE (ii.[IndiInfo_FirstName] LIKE '%'+@SearchStr+'%') OR (ii.[IndiInfo_LastName] LIKE '%'+@SearchStr+'%')
 
END
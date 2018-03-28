ALTER PROCEDURE [dbo].[usp_getstackHolderInfo]
	@SearchStr varchar(50),
	@type varchar(5)
AS
BEGIN
IF @type= 'ORG'
BEGIN
	SELECT 
		sh.[StkHoldType_ID] , 
		sh.[StkHoldType_Name], 
		CAST(NULL AS VARCHAR) as [IndiInfo_FirstName], 
		CAST(NULL AS VARCHAR) as [IndiInfo_LastName], 
		CAST(NULL AS VARCHAR) as [IndiInfo_MiddleName], 
		CAST(NULL AS VARCHAR) as [IndiInfo_Suffix], 
		CAST(NULL AS VARCHAR) as [ContAdd_TelephoneNumber],
		CAST(NULL AS VARCHAR) as [ContAdd_EmailID],
		oi.OrgInfo_Name,
		oi.OrgInfo_Authority,
		oi.[Address_ID] , 
		ads.[Address_1], 
		ads.[Address_2], 
		ads.[City] , 
		ads.[StateName], 
		ads.[CountryName], 
		ads.[County_ID], 
		ads.[State_ID], 
		ads.[Country_ID], 
		ads.[ZIP] 
    FROM   [dbo].[L_StakeHolderType] AS sh
    INNER JOIN  [dbo].[T_OrganizationInformation]  AS oi ON sh.[StkHoldType_ID] = oi.[StkHoldType_ID]
    INNER JOIN [dbo].[T_Address] AS ads ON oi.[Address_ID] = ads.[Address_ID]
    WHERE (oi.[OrgInfo_Name]  LIKE '%'+@SearchStr+'%') OR (oi.[OrgInfo_Name] LIKE '%'+@SearchStr+'%')
 END
ELSE
BEGIN
		SELECT 
			sh.[StkHoldType_ID] , 
			sh.[StkHoldType_Name], 
			ii.[IndiInfo_FirstName], 
			ii.[IndiInfo_LastName], 
			ii.[IndiInfo_MiddleName], 
			ii.[IndiInfo_Suffix], 
			ii.[ContAdd_TelephoneNumber],
			ii.[ContAdd_EmailID],
			CAST(NULL AS VARCHAR) AS OrgInfo_Name,
			CAST(NULL AS VARCHAR) AS OrgInfo_Authority,
			ii.[Address_ID] , 
			ads.[Address_1], 
			ads.[Address_2], 
			ads.[City] , 
			ads.[StateName], 
			ads.[CountryName], 
			ads.[County_ID], 
			ads.[State_ID], 
			ads.[Country_ID], 
			ads.[ZIP] 
		FROM   [dbo].[L_StakeHolderType] AS sh
		INNER JOIN [dbo].[T_IndividualInformation] AS ii ON sh.[StkHoldType_ID] = ii.[StkHoldType_ID]
		INNER JOIN [dbo].[T_Address] AS ads ON ii.[Address_ID] = ads.[Address_ID]
		WHERE (ii.[IndiInfo_FirstName] LIKE '%'+@SearchStr+'%') OR (ii.[IndiInfo_LastName] LIKE '%'+@SearchStr+'%')
END
END
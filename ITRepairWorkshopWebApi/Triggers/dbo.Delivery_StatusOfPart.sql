CREATE TRIGGER StatusOfPartTrigger
	ON [dbo].[ImpartParts]
	FOR  UPDATE
	AS
	BEGIN
		SET NOCOUNT ON
		Declare @NewStatusOfPart_ImpartPart INT,   @OrginGuid_ImpartPart Varchar(20),
		  @Quantity_ImpartPart INT,@TypeOfPart_ImpartPart INT, @TodoUpdate BIT

		SELECT   @OrginGuid_ImpartPart=PartGuid,@NewStatusOfPart_ImpartPart=StatusOfPart FROM inserted

		SELECT @Quantity_ImpartPart=Quantity, @TypeOfPart_ImpartPart =TypeOfPart
			  FROM ImpartParts WHERE  @NewStatusOfPart_ImpartPart=StatusOfPart AND  @OrginGuid_ImpartPart=PartGuid

			  -- IF STATUS OF PART EQUAL PROPERTY DELIVERY AND DID NOT UPDATE  Previously
		IF @NewStatusOfPart_ImpartPart = 0 AND  @TodoUpdate=1
	 BEGIN
	-- IF GUID IN TABLE PART FIND - UPDATE EXIST
	--COL QUANTITIT IFELSE INSERT A NEW ROW IN THE TABLE PART

		IF EXISTS (SELECT * FROM Parts WHERE @OrginGuid_ImpartPart=Guid AND TypeOfPart = 0)

		UPDATE Parts
		SET Quantity=@Quantity_ImpartPart +Quantity
		WHERE @OrginGuid_ImpartPart=Guid AND TypeOfPart = 0

		ELSE
		 INSERT INTO Parts VALUES(@OrginGuid_ImpartPart,@Quantity_ImpartPart,@Quantity_ImpartPart*60/100,@Quantity_ImpartPart*40/100,NULL,NULL,0)
		-- update also col status equal delivery in the table impartpart
		UPDATE ImpartParts
		SET StatusOfPart=0, TodoUpdate=0
		WHERE @OrginGuid_ImpartPart=PartGuid

     	END
	END
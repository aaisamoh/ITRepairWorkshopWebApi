CREATE TRIGGER DELIVERY_StatusOfPartTrigger
	ON [dbo].[ImpartParts]
	FOR  UPDATE
	AS
	IF UPDATE(StatusOfPart)BEGIN

	
	Declare @NewStatusOfPart int,   @OrginGuid Varchar(20)
	SELECT  @NewStatusOfPart=StatusOfPart, @OrginGuid=PartGuid FROM inserted
	
	IF(@NewStatusOfPart = 0)
	            BEGIN
				PRINT "The COLUMN DELIVERY OF ImpartParts table was update"
	        END
	END
  

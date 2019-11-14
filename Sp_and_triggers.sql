use pharmacy
go

create TRIGGER trigger_remaining_refills
on fullfillment
after insert
AS
    BEGIN
        DECLARE @fulfilled INT(4)
        declare @fulPerscriptionID int(10)
        declare @totalRefills int(4)

        select @fulPerscriptionID = (select perscriptionID from inserted)
        SELECT @fulfilled = (SELECT count(*) from fullfillment where perscriptionID = @fulPerscriptionID)
        select @totalRefills = (select totalRefills from perscription)

        BEGIN
            update perscription
            set remainingRefills = @totalRefills - @fulfilled
            where perscriptionID = @fulPerscriptionID
        END
    END
GO


/*CREATE TRIGGER Trigger_Patient_Visit_Cost
ON VISIT
FOR INSERT
AS
	BEGIN
		DECLARE @insertAmt money
		DECLARE @PATIENTID VARCHAR(7)
		
		SELECT @insertAmt = (SELECT COSTOFVISIT FROM INSERTED)
		SELECT @PATIENTID = (SELECT PATIENT_ID FROM INSERTED)

		IF @insertAmt > 0
			BEGIN
				UPDATE PATIENT
				SET ACCT_BAL = ACCT_BAL + @insertAmt
				WHERE PATIENT_ID = @PATIENTID
			END
	END
GO*/
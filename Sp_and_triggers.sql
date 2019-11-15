use pharmacy
go

create TRIGGER trigger_remaining_refills
on fulfillment
after insert
AS
    BEGIN
        DECLARE @fulfilled INT
        declare @fulPrescriptionID int
        declare @totalRefills int

        select @fulPrescriptionID = (select prescriptionID from inserted)
        SELECT @fulfilled = (SELECT count(*) from fulfillment where prescriptionID = @fulPrescriptionID)
        select @totalRefills = (select totalRefills from prescription)

        BEGIN
            update prescription
            set remainingRefills = @totalRefills - @fulfilled
            where prescriptionID = @fulPrescriptionID
        END
    END
GO


create TRIGGER trigger_remaining_refills_delete
on fulfillment
after delete
AS
    BEGIN
        DECLARE @fulfilled INT
        declare @fulPrescriptionID int
        declare @totalRefills int

        select @fulPrescriptionID = (select prescriptionID from deleted)
        SELECT @fulfilled = (SELECT count(*) from fulfillment where prescriptionID = @fulPrescriptionID)
        select @totalRefills = (select totalRefills from prescription)

        BEGIN
            update prescription
            set remainingRefills = @totalRefills - @fulfilled
            where prescriptionID = @fulPrescriptionID
        END
    END
GO

create TRIGGER trigger_remaining_refills_update
on fulfillment
after update
AS
    BEGIN
        DECLARE @fulfilled INT
        declare @fulPrescriptionID int
        declare @totalRefills int

        select @fulPrescriptionID = (select prescriptionID from inserted)
        SELECT @fulfilled = (SELECT count(*) from fulfillment where prescriptionID = @fulPrescriptionID)
        select @totalRefills = (select totalRefills from prescription)

        BEGIN
            update prescription
            set remainingRefills = @totalRefills - @fulfilled
            where prescriptionID = @fulPrescriptionID
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

/*
Stored Procedures-----------------------
*/

create proc [dbo].[AddPhysician](
	@fName		varchar(25),
	@mInit		char(1),
	@lName		varchar(50),
	@office		varchar(60),
	@phoneNum	char(10),
	@licenseNum	int
)
as	
	BEGIN
		begin transaction
			INSERT into physician(fname, minit, lname, office, phoneNum, Licensenum)
			values (@fname, @mInit, @lName, @office, @phoneNum, @licenseNum)
					IF @@ERROR <> 0
				BEGIN
					ROLLBACK TRANSACTION
					RAISERROR ('Unable to insert record.',16,1)
					RETURN -1
				END
			ELSE
				BEGIN
					COMMIT TRANSACTION
					PRINT 'Record added successfully!'
				END
	END
GO
/*
ALTER PROC [dbo].[SearchStudent2](
    @student_ID varchar(6),
    @fname varchar(25),
    @lname varchar(25)
)
AS
    BEGIN
        SELECT STUDENT_ID, FNAME, LNAME, TOTAL_CREDIT_HOURS
            from STUDENT
            where (upper(lname)like '%' + upper(@lname) + '%' or upper(lname) = '')
            and (upper(fname)like '%' + upper(@fname) + '%' or upper(fname) = '')
            and (upper(STUDENT_ID)like '%' + upper(@student_ID) + '%' or upper(student_id) = '')
    END
    go
create PROC [dbo].[SearchStudent3](
    @student_ID varchar(6)
)
AS
    BEGIN
        SELECT *
            from STUDENT
            where (upper(STUDENT_ID)like '%' + upper(@student_ID) + '%' or upper(student_id) = '')
    END
exec SearchStudent2 @student_ID = '', @fname = '', @lname = '';
*/
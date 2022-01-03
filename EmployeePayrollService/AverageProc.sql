---------------Average---------------------------
create procedure FindAverage
(
@basic_pay decimal
)
as 
begin TRY 
Select AVG(basic_pay) from employee_payroll1 where  gender='F' group by gender
End TRY
BEGIN CATCH
SELECT
ERROR_NUMBER() AS ERRORNumber,
ERROR_STATE() AS ERRORState,
ERROR_PROCEDURE() AS ERRORProcedure,
ERROR_LINE() AS ERRORLine,
ERROR_MESSAGE() AS ERRORMessage;
END CATCH
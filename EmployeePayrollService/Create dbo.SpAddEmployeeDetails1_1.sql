USE [payroll_service1]
GO

/****** Object: SqlProcedure [dbo].[SpAddEmployeeDetails1] Script Date: 30-12-2021 20:24:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc SpAddEmployeeDetails1
@EmployeeName varchar(50),
@PhoneNumber varchar(15),
@Address varchar(100),
@Department varchar(20),
@Gender varchar(1),
@BasicPay money,
@Deductions money,
@TaxablePay money,
@Tax money,
@NetPay money,
@StartDate date

as

insert into employee_payroll1 values (@EmployeeName, @PhoneNumber, @Address, @Department, @Gender, @BasicPay, @Deductions, @TaxablePay, @Tax, @NetPay, @StartDate)

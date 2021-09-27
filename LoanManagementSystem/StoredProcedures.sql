
create procedure ViewPendingCustomers
as
begin
select C.CustomerId,L.LoanAccNumber,C.FirstName,C.LastName,L.LoanStatus from Customer C join LoanDetails L on C.CustomerId=L.CustomerId where L.LoanStatus='Pending'
end
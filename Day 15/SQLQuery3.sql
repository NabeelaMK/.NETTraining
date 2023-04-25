/*Get the records of BanTB in given format
[ACNO] [Account Holder Name] [Balance] [Ref Acno] [Name of Referer]*/


select * from BankTB;

/*Changing the on statement*/

select a.AccountNo as ACNO,
a.Name as [Account Holder Name],
a.Balance,
a.RefAcno as [Ref Acno],
r.Name as [Name of Referer]
from BankTB a left join BankTB r
on a.AccountNo=r.RefAcno;

/*Left outer join*/ 

select a.AccountNo as ACNO,
a.Name as [Account Holder Name],
a.Balance,
a.RefAcno as [Ref Acno],
r.Name as [Name of Referer]
from BankTB a left join BankTB r
on a.RefAcno=r.AccountNo;

/*Right outer join*/

select a.AccountNo as ACNO,
a.Name as [Account Holder Name],
a.Balance,
a.RefAcno as [Ref Acno],
r.Name as [Name of Referer]
from BankTB a right join BankTB r
on a.RefAcno=r.AccountNo;

/*Full outer join*/

select a.AccountNo as ACNO,
a.Name as [Account Holder Name],
a.Balance,
a.RefAcno as [Ref Acno],
r.Name as [Name of Referer]
from BankTB a full join BankTB r
on a.RefAcno=r.AccountNo;

/*By using only join*/

select a.AccountNo as ACNO,
a.Name as [Account Holder Name],
a.Balance,
a.RefAcno as [Ref Acno],
r.Name as [Name of Referer]
from BankTB a join BankTB r
on a.RefAcno=r.AccountNo;



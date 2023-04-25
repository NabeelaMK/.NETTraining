/*Case statement*/

declare  @t int = 45; -- Try assigning 2, -5, 45
select case
	when @t>0 then
		case
			when @t=1 then 'One'
		    when @t=2 then 'Two'
		    else 'not a number required'		
		end
	else 'less than one'
end

/*Using Loop*/

declare @counter int
set @counter=1
while @counter<=10
begin
print @counter
set @counter=@counter + 1
end

             

create trigger Slogin
on Tb_Student 
for insert
as 
declare @sno char(16),@sname varchar(8);
begin 
		select @sno=Sno,@sname=Sname from inserted
		insert into Tb_SLogin values (@sno,@sname,'000')
end

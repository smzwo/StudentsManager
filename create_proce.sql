use 课设
go
--实现对学生表增加、更新信息、删除信息
create procedure Insert_Student @Sno char(16),@Sname varchar(8),@Ssex char(2) ,@Saddress varchar(50),@Stell char(11),@Sqq char(16) ,@rtn int output
as
declare 
	@tmpSno char(16),
	@tmpSname varchar(8),
	@tmpSsex char(2) ,
	@tmpSaddress varchar(50),
	@tmpStell char(11),
	@tmpSqq char(16)
	if exists(select * from Tb_Student where Sno=@Sno)
		if @@OPTIONS=0
			delete from Tb_Student where Sno=@Sno
		else if @@OPTIONS=1
		begin 
			select @tmpSno=Sno,@tmpSname=Sname,@tmpSsex=Ssex,@tmpSaddress=Saddress,@tmpStell=Stell,@tmpSqq=Sqq
			from Tb_Student
			where Sno=@Sno
			if (@tmpSno=@Sno and @tmpSname=@Sname and @tmpSsex=@Ssex and  @tmpSaddress=@Saddress  and @tmpStell=@Stell and @tmpSqq=@Sqq )
				begin
					set @rtn=0
				end
			else 
				begin
					update Tb_Student set Sno=@Sno,Sname=@Sname,Ssex=@Ssex,Saddress=@Saddress,Stell=@Stell,Sqq=@Sqq
					where Sno=@Sno
					set @rtn=2
				end
		end
	else
		begin
			insert into Tb_Student(Sno,Sname,Ssex,Saddress,Stell,Sqq) values(@Sno,@Sname,@Ssex,@Saddress,@Stell ,@Sqq)
			set @rtn=1    --没有相同的数据，进行插入处理
		end


go
--实现对课程信息表增加、更新信息、删除信息
create procedure Insert_Course
	@Cno char(20) ,
	@Cname varchar(40) ,
	@Cyear char(12),
	@Cterm char(4),
	@Ccredit float,
	@Cnature char(8),
	@rtn int output
as
declare
	@tmpCno char(20) ,
	@tmpCname varchar(40) ,
	@tmpCyear char(12),
	@tmpCterm char(4),
	@tmpCcredit float,
	@tmpCnature char(8)
	if exists(select * from Tb_Course where Cno=@Cno)
		if @@OPTIONS=0
			delete from Tb_Course where Cno=@Cno
		else if @@OPTIONS=1
		begin
			select @tmpCno=Cno,@tmpCname=Cname,@tmpCyear=Cyear,@tmpCterm=Cterm,@tmpCcredit=Ccredit,@tmpCnature=Cnature
			from Tb_Course
			where Cno=@Cno
			if (@tmpCno=@Cno and @tmpCname=@Cname and @tmpCyear=@Cyear and @tmpCterm=@Cterm and @tmpCcredit=@Ccredit and @tmpCnature=@Cnature)
				begin
					set @rtn=0
				end
			else 
				begin
					update Tb_Course set Cno=@Cno,Cname=@Cname,Cyear=@Cyear,Cterm=@Cterm,Ccredit=@Ccredit,Cnature=@Cnature where Cno=@Cno
					set @rtn=2
				end
		end
	else
		begin
			insert into Tb_Course values(@tmpCno,@tmpCname,	@tmpCyear,@tmpCterm,@tmpCcredit,@tmpCnature)
			set @rtn=1    --没有相同的数据，进行插入处理
		end
			
go 
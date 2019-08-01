use 课设
--学生信息表
create table Tb_Student 
(
	Sno char(16) primary key,
	Sname varchar(8),
	Ssex char(2),
	--Ssex char(2) check(Ssex in('男','女')),
	/*Sbirthday char(14),
	Snative varchar(40),
	SpoliticalFace nchar(12),*/
	Saddress varchar(50),
	/*SidNum char(18),*/
	Stell char(11) null,
	Sqq char(16) null,
	/*Semail varchar(30) null,
	Spicture varbinary(max) null*/
)
--课程信息表
create table Tb_Course
(
	Cno char(20) primary key,
	Cname varchar(40) ,
	Cyear char(12),
	Cterm char(4),
	Ccredit float,
	Cnature char(8)
)
--选修课程表
create table Tb_Course2
(
	Cno char(20) primary key,
	Cname varchar(40) ,
	Sno_C char(16),
	Cyear char(12),
	Cterm char(4),
	Ccredit float,
	Cscore float,
	foreign key (Sno_C) references Tb_Student(Sno)
)
--学生成绩表
create table Tb_ScoreSt
(
	Cno char(20),
	Sno char(16),
	Score float,
	primary key(Cno,Sno),
	foreign key (Cno) references Tb_Course(Cno),
	foreign key (Sno) references Tb_Student(Sno)
)
--学生登录表
create table Tb_SLogin
(
	Sno char(16) primary key,
	Sname varchar(8) not null,
	Spassword varchar(20) not null,
	foreign key (Sno) references Tb_Student(Sno)
)
--管理员
create table Tb_Admin
(
	id char(5) primary key,
	Password varchar(20) 
)
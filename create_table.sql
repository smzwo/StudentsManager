use ����
--ѧ����Ϣ��
create table Tb_Student 
(
	Sno char(16) primary key,
	Sname varchar(8),
	Ssex char(2),
	--Ssex char(2) check(Ssex in('��','Ů')),
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
--�γ���Ϣ��
create table Tb_Course
(
	Cno char(20) primary key,
	Cname varchar(40) ,
	Cyear char(12),
	Cterm char(4),
	Ccredit float,
	Cnature char(8)
)
--ѡ�޿γ̱�
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
--ѧ���ɼ���
create table Tb_ScoreSt
(
	Cno char(20),
	Sno char(16),
	Score float,
	primary key(Cno,Sno),
	foreign key (Cno) references Tb_Course(Cno),
	foreign key (Sno) references Tb_Student(Sno)
)
--ѧ����¼��
create table Tb_SLogin
(
	Sno char(16) primary key,
	Sname varchar(8) not null,
	Spassword varchar(20) not null,
	foreign key (Sno) references Tb_Student(Sno)
)
--����Ա
create table Tb_Admin
(
	id char(5) primary key,
	Password varchar(20) 
)
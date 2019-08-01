create view ScoreSearch as 
select S.Sno as SNO,C.Cno as CNO,Cname as CNAME,Cyear as CYEAR,Cterm as CTERM,Ccredit as CCREDIT,Cnature as CNATURE,Score as SCORE
from Tb_Course C,Tb_ScoreSt S
where C.Cno=S.Cno
union all
select C2.Sno_C AS SNO,C2.Cno as CNO,Cname as CNAME,Cyear  as CYEAR,Cterm as CTERM ,Ccredit as CCREDIT , null  as CNATURE, CScore as SCORE
from Tb_Course2 C2,Tb_Student S2
where C2.Sno_C=S2.Sno
create database FriendsBook
go
use FriendsBook

go
create table Registration
(loginid int identity primary key,
username varchar(30) not null,
pwd varchar(30) not null,
securityquestion varchar(30) not null,
securityanswer varchar(30) not null
)

go 

create table Friends
(loginid int references Registration(loginid) not null,
fname varchar(30) not null,
lname varchar(30) not null,
email varchar(30) not null,
mobile varchar(30) not null,
dob varchar(30) not null
)
go
select * from Registration
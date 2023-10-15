create database Assignment4
use Assignment4

create table ClientRental(
clientNo varchar(45),
cName varchar(50),
propertyNo varchar(30),
pAddress varchar(50),
rentStart Date,
rentFinish Date,
rent int,
ownerNo varchar(10),
ownerName varchar(15)
)

insert into ClientRental values
('CR76','John Kay','PG4','6 lawerence st.glasgow','1-JUL-00','31-AUG-01',350,'CO40','Tina Murphy'),
('CR76','John Kay','PG16','5 novar dr glasgow','1-SEP-02','1-SEP-03',450,'CO93','Tony Shaw'),
('CR56','Aline Stewart','PG4','6 lawerence st.glasgow','1-SEP-99','10-JUN-00',350,'CO40','Tina Murphy'),
('CR56','Aline Stewart','PG36','2 manor rd.glasgow','10-OCT-00','1-DEC-01',370,'CO93','Tony Shaw'),
('CR56','Aline Stewart','PG16','5 novar dr glasgow','1-NOV-02','1-AUG-03',450,'CO93','Tony Shaw')

select  * from ClientRental

create table Client(
ClientNo varchar(10) primary key,
CName varchar(20)
)

insert into Client values
('CR76','John Kay'),
('CR56','Aline Stewart')

select * from Client

create table Owners(
OwnerNo varchar(35) primary key,
OName varchar(25)
)

insert into Owners values
('C040','Tina Muphy'),
('C093','Tony Shaw')

select * from Owners

create table PropertyOwner(
PropertyNo varchar(10) primary key,
PAddress varchar(30),
Rent int,
OwnerNo varchar(35) foreign key references Owners (OwnerNo)
)

insert into PropertyOwner values
('PG4','6 lawerence st.glasgow',350,'C040'),
('PG16','5 novar dr glasgow',450,'C093'),
('PG36','2 manor rd.glasgow',370,'C093')

select * from PropertyOwner

create table Rental(
ClientNo varchar(10) foreign key references Client (ClientNo),
PropertyNo varchar(10) foreign key references PropertyOwner (PropertyNo),
rentStart Date,
rentFinish Date
)

insert into Rental values
('CR76','PG4','1-JUL-00','31-AUG-01'),
('CR76','PG16','1-SEP-02','1-SEP-03'),
('CR56','PG4','1-SEP-99','10-JUN-00'),
('CR56','PG36','10-OCT-00','1-DEC-01'),
('CR56','PG16','1-NOV-02','1-AUG-03')

select * from Rental


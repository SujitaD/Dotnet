create table customer(id int primary key,firstname varchar(40) not null,lastname varchar(40) not null,
city varchar(40),country varchar(40),phone varchar(40));

insert into customer values (1,'Sujita','Dabekar','Mahad','India',7248990236);
insert into customer values (2,'Dnyaneshwari','Suryavanshi','Sangali','India',7689045721);
insert into customer values (3,'Kamaksha','Auti','Thane','India',8972489903);

select* from customer;

create table orderr(id int primary key,orderdate datetime not null,
ordernumber varchar(10),customerid int foreign key references customer(id)
,totalamount decimal(12,2));

insert into orderr values (3,2000/02/11,'340',1,78.00);
insert into orderr values (4,1999/08/13,'440',2,45.00);
insert into orderr values (5,2013/08/12,'540',3,34.00);

select* from orderr;

select* from customer where country like 'I%';

select* from customer where firstname like '__I%';
create database student;
use student;

create table student(
id int primary key,
name varchar(15),
email varchar(15),
contact_number int,
address varchar(25),
admission_date date,
fees double,
active_status bool
);

desc student;
alter table student modify contact_number varchar(15);
alter table student modify email varchar(20);
alter table student modify active_status boolean;

insert into student values
(1, 'Alice Smith', 'alice@mail.com', 1234567890, '123 Main St', '2023-01-15', 1500.00, TRUE),
(2, 'Bob Johnson', 'bob@mail.com', 2345678901, '456 Oak St', '2023-02-20', 1600.00, TRUE),
(3, 'Charlie Brown', 'charlie@mail.com', 3456789012, '789 Pine St', '2023-03-25', 1400.00, TRUE),
(4, 'Diana Prince', 'diana@mail.com', 4567890123, '101 Maple St', '2023-04-30', 1700.00, FALSE),
(5, 'Ethan Hunt', 'ethan@mail.com', 5678901234, '202 Elm St', '2023-05-10', 1800.00, TRUE),
(6, 'Fiona Gallagher', 'fiona@mail.com', 6789012345, '303 Birch St', '2023-06-15', 1500.00, FALSE);

select * from student;
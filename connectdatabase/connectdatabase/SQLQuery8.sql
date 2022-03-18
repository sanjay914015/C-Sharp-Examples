create database below50;
create database above50;

select name from master.sys.databases;
use below50;
CREATE TABLE male(ID INT PRIMARY KEY, First_Name varchar(20) NOT NULL, Last_Name varchar(20) NOT NULL,Gender varchar(10) NOT NULL); 
CREATE TABLE female(ID INT PRIMARY KEY, First_Name varchar(20) NOT NULL, Last_Name varchar(20) NOT NULL,Gender varchar(10) NOT NULL); 
select * from male;
select * from female;

use above50;
CREATE TABLE male(ID INT PRIMARY KEY, First_Name varchar(20) NOT NULL, Last_Name varchar(20) NOT NULL,Gender varchar(10) NOT NULL); 
CREATE TABLE female(ID INT PRIMARY KEY, First_Name varchar(20) NOT NULL, Last_Name varchar(20) NOT NULL,Gender varchar(10) NOT NULL); 
select * from male;
select * from female;
SELECT sobjects.name
FROM sysobjects sobjects
WHERE sobjects.xtype = 'U'


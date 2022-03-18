create database task1;
use task1;
CREATE TABLE user_details(ID INT PRIMARY KEY identity(1,1), First_Name varchar(20) NOT NULL, Last_Name varchar(20) NOT NULL,Phone varchar(10) NOT NULL); 
SELECT * FROM user_details;

task 1
INSERT INTO user_details(First_Name,Last_Name,Phone) VALUES('sanjay','chauhan','1234556');
INSERT INTO user_details(First_Name,Last_Name,Phone) VALUES('James','Bond','1234556');
INSERT INTO user_details(First_Name,Last_Name,Phone) VALUES('Leo','Sams','1234556');
INSERT INTO user_details(First_Name,Last_Name,Phone) VALUES('Peter','parker','1234556');
INSERT INTO user_details(First_Name,Last_Name,Phone) VALUES('IN','RK','1234556');
SELECT * FROM user_details;
DELETE user_details where ID=3;
SELECT First_Name, Last_Name from user_details;
UPDATE user_details SET Phone='123456789' where ID=2;
SELECT * FROM user_details;
SELECT * FROM user_details WHERE Phone LIKE '%89';
SELECT * FROM user_details WHERE Phone LIKE '123%';
SELECT * FROM user_details ORDER BY Phone ASC;
SELECT DISTINCT Phone FROM user_details;
SELECT * FROM user_details where ID IN (1,2);

TASk 2;
CREATE TABLE user_details1(ID INT PRIMARY KEY identity(1,1), First_Name varchar(20) NOT NULL, Last_Name varchar(20) NOT NULL,Phone varchar(10) NOT NULL); 
CREATE TABLE user_details3(ID INT PRIMARY KEY identity(1,1), First_Name varchar(20) NOT NULL, Last_Name varchar(20) NOT NULL,Phone varchar(10) NOT NULL); 
select name from master.sys.databases;

SELECT sobjects.name
FROM sysobjects sobjects
WHERE sobjects.xtype = 'U'

CREATE TABLE user_details2(ID INT PRIMARY KEY identity(1,1), First_Name varchar(20) NOT NULL, Last_Name varchar(20) NOT NULL,Phone varchar(10) NOT NULL);
CREATE TABLE user_details4(ID INT PRIMARY KEY identity(1,1), First_Name varchar(20) NOT NULL, Last_Name varchar(20) NOT NULL,Phone varchar(10) NOT NULL); 

create trigger user_details1Trigger 




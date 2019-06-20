CREATE TABLE Districts(

ID int IDENTITY (1,1) PRIMARY KEY,

Name VARCHAR(50)

)

CREATE TABLE Students(

ID int IDENTITY (1,1) PRIMARY KEY,

RollNo VARCHAR(10),

Name VARCHAR(100),

Age int,

Address VARCHAR(MAX),

DistrictID int FOREIGN KEY REFERENCES Districts(ID)

)

INSERT INTO  Districts VALUES ('DHAKA')
INSERT INTO  Districts VALUES ('CHITTAGONG')

select *from Districts

INSERT INTO  Students VALUES ('1','Omar','23','Mohakhali','1')

select *from Students


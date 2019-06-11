CREATE TABLE Students (
ID INT PRIMARY KEY IDENTITY,
Roll INT,
Name VARCHAR(100),
Age INT ,
Address VARCHAR(150),
DistrictID int
)

CREATE TABLE Districts (
ID INT IDENTITY,
Namr VARCHAR(100) 
)

CREATE TABLE Departments (
ID INT IDENTITY,
Name VARCHAR(50)
)

CREATE TABLE Subjects (
ID INT IDENTITY,
Name VARCHAR(50),
Code VARCHAR(50)
)

CREATE TABLE Marks (
ID INT IDENTITY,
StudentID INT,
DepartmentID int,
SubjectID int,
Mark int
)

SELECT *FROM Students
INSERT INTO Students VALUES (1109001,'X',25,'Basabo',1)
INSERT INTO Students VALUES (1109002,'Y',26,'Shalbon',2)
INSERT INTO Students VALUES (1109003,'Z',29,'Taltola',1)
INSERT INTO Students VALUES (1109004,'P',24,'Khailgaon',1)
INSERT INTO Students VALUES (1109005,'Q',25,'Rani Bazar',2)
INSERT INTO Students VALUES (1109006,'R',27,'Kandirpar',2)
INSERT INTO Students VALUES (1109007,'S',19,'Oxyzen',3)

SELECT *FROM Districts

INSERT INTO Districts VALUES ('Dhaka')
INSERT INTO Districts VALUES ('Comilla')


select *from departments

INSERT INTO Departments VALUES ('ICT')
INSERT INTO Departments VALUES ('CSE')

SELECT *FROM Subjects

INSERT INTO Subjects VALUES('Computer Fundamentals', 'ICT-101')
INSERT INTO Subjects VALUES('Digital Communication', 'ICT-102')
INSERT INTO Subjects VALUES('Analog Communication', 'ICT-103')

INSERT INTO Subjects VALUES('Math', 'CSE-101')
INSERT INTO Subjects VALUES('VLSI', 'CSE-102')
INSERT INTO Subjects VALUES('Compiler Design', 'CSE-103')

SELECT *FROM Marks

INSERT INTO Marks VALUES ('1109001',1,1,85)
INSERT INTO Marks VALUES ('1109001',1,2,90)
INSERT INTO Marks VALUES ('1109002',1,1,85)
INSERT INTO Marks VALUES ('1109002',1,2,90)

INSERT INTO Marks VALUES ('1109003',2,4,79)
INSERT INTO Marks VALUES ('1109003',2,5,86)
INSERT INTO Marks VALUES ('1109004',2,5,95)
INSERT INTO Marks VALUES ('1109004',2,6,86)


INSERT INTO Marks VALUES ('1109005',2,6,70)
INSERT INTO Marks VALUES ('1109005',2,4,56)
INSERT INTO Marks VALUES ('1109006',2,5,82)
INSERT INTO Marks VALUES ('1109006',2,6,83)

SELECT s.Name, s.DistrictID, d.Namr from Students as s
left outer join Districts as d on d.ID = s.DistrictID


select m.StudentID,s.Name, d.Name,ss.Name, Mark  from Marks as m
left outer join Departments as d 
on m.DepartmentID = d.ID
left outer join Students as s
on s.Roll = m.StudentID
left outer join Subjects as ss
on m.SubjectID = ss.ID

CREATE DATABASE StudentDB

use StudentDB

CREATE TABLE Students (
ID INT IDENTITY(1,1),
Name VARCHAR(100),
Age INT
)

INSERT INTO Students VALUES ('Hridoy',25)
INSERT INTO Students VALUES ('Jamal',24)
INSERT INTO Students VALUES ('Kamal',24)

--DROP TABLE Students

SELECT *FROM Students

UPDATE Students
SET Name = 'Bancha'
WHERE ID = 2


CREATE DATABASE BuildingSafety_DB;
Go

USE BuildingSafety_DB;
Go

CREATE TABLE Buildings (

    BuildingID INT PRIMARY KEY IDENTITY(1,1),
    BuildingName VARCHAR(100) NOT NULL,
    Address VARCHAR(200) NOT NULL,
    Floors INT NOT NULL,
    SafetyScore INT NOT NULL,
    SafetyStatus VARCHAR(50) NOT NULL

);
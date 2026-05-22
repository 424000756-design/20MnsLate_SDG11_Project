USE BuildingSafety_DB;
GO

DROP TABLE IF EXISTS dbo.Buildings;
GO

CREATE TABLE dbo.Buildings (
    BuildingID INT IDENTITY(1,1) PRIMARY KEY,
    BuildingName VARCHAR(100),
    Address VARCHAR(200),
    Floors INT,
    SafetyScore INT,
    SafetyStatus VARCHAR(50)
);
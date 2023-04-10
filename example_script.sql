-- Create a new database named testdb
CREATE DATABASE testdb;

-- Switch to the new database
USE testdb;

-- Create the Room table
CREATE TABLE Room (
  RoomId INT PRIMARY KEY,
  RoomNumber VARCHAR(10) NOT NULL,
  RoomType VARCHAR(50) NOT NULL,
  BedType VARCHAR(50) NOT NULL,
  MaxOccupancy INT NOT NULL,
  PricePerNight DECIMAL(10,2) NOT NULL
);

-- Insert sample data
INSERT INTO Room (RoomId, RoomNumber, RoomType, BedType, MaxOccupancy, PricePerNight)
VALUES
  (1, '101', 'Standard', 'Queen', 2, 99.99),
  (2, '102', 'Standard', 'Queen', 2, 99.99),
  (3, '201', 'Standard', 'King', 2, 109.99),
  (4, '202', 'Standard', 'King', 2, 109.99),
  (5, '301', 'Deluxe', 'King', 2, 129.99),
  (6, '302', 'Deluxe', 'King', 2, 129.99);

  select * from room
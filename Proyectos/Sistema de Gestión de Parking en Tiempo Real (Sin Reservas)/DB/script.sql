CREATE TABLE Vehiculos (
    Matricula NVARCHAR(10) PRIMARY KEY,
    Marca NVARCHAR(50),
    Modelo NVARCHAR(50)
);
CREATE TABLE ParkingActivo (
    Id INT IDENTITY PRIMARY KEY,
    Matricula NVARCHAR(10) FOREIGN KEY REFERENCES Vehiculos(Matricula),
    HoraEntrada DATETIME DEFAULT GETDATE(),
    HoraSalida DATETIME NULL
);
CREATE TABLE Pagos (
    Id INT IDENTITY PRIMARY KEY,
    ParkingId INT FOREIGN KEY REFERENCES ParkingActivo(Id),
    Importe DECIMAL(10,2),
    MetodoPago NVARCHAR(20),
    Fecha DATETIME DEFAULT GETDATE()
);
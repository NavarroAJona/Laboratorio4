﻿CREATE TABLE Planeta(
planetaId INTEGER PRIMARY KEY IDENTITY, 
nombrePlaneta NVARCHAR(MAX) NOT NULL,
 numeroAnillos INTEGER NOT NULL,
tipoPlaneta NVARCHAR(100) NOT NULL,
archivoPlaneta VARBINARY(MAX),
tipoArchivo NVARCHAR(50) 
)
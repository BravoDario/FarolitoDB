use DW_Farolito;

-- Tablas de dimensión

CREATE TABLE DimFecha (
  id INT PRIMARY KEY,
  fecha DATE,
  anio INT,
  mes INT,
  dia INT,
  trimestre INT
);

CREATE TABLE DimUsuario (
  id INT PRIMARY KEY,
  nombre VARCHAR(50),
  apellidoP VARCHAR(45),
  apellidoM VARCHAR(45),
  correo VARCHAR(45),
  rol VARCHAR(45)
);

CREATE TABLE DimComponente (
  id INT PRIMARY KEY,
  nombre VARCHAR(150)
);

CREATE TABLE DimReceta (
  id INT PRIMARY KEY,
  nombre VARCHAR(100)
);

-- Tablas de hechos

CREATE TABLE FactComprasComponentes (
  id INT PRIMARY KEY,
  fecha_id INT,
  usuario_id INT,
  componente_id INT,
  cantidad INT,
  costo FLOAT,
  FOREIGN KEY (fecha_id) REFERENCES DimFecha(id),
  FOREIGN KEY (usuario_id) REFERENCES DimUsuario(id),
  FOREIGN KEY (componente_id) REFERENCES DimComponente(id)
);

CREATE TABLE FactProduccionLamparas (
  id INT PRIMARY KEY,
  fecha_id INT,
  usuario_id INT,
  receta_id INT,
  cantidad INT,
  costo FLOAT,
  FOREIGN KEY (fecha_id) REFERENCES DimFecha(id),
  FOREIGN KEY (usuario_id) REFERENCES DimUsuario(id),
  FOREIGN KEY (receta_id) REFERENCES DimReceta(id)
);

CREATE TABLE FactMermasComponentes (
  id INT PRIMARY KEY,
  fecha_id INT,
  usuario_id INT,
  componente_id INT,
  cantidad INT,
  descripcion VARCHAR(700),
  FOREIGN KEY (fecha_id) REFERENCES DimFecha(id),
  FOREIGN KEY (usuario_id) REFERENCES DimUsuario(id),
  FOREIGN KEY (componente_id) REFERENCES DimComponente(id)
);

CREATE TABLE FactMermasLamparas (
  id INT PRIMARY KEY,
  fecha_id INT,
  usuario_id INT,
  receta_id INT,
  cantidad INT,
  descripcion VARCHAR(700),
  FOREIGN KEY (fecha_id) REFERENCES DimFecha(id),
  FOREIGN KEY (usuario_id) REFERENCES DimUsuario(id),
  FOREIGN KEY (receta_id) REFERENCES DimReceta(id)
);
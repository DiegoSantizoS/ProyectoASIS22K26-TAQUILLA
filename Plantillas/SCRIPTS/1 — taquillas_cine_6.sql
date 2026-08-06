-- =====================================================================
-- BASE DE DATOS
-- =====================================================================
CREATE DATABASE IF NOT EXISTS taquillas_cine
  CHARACTER SET utf8mb4
  COLLATE utf8mb4_unicode_ci;

USE taquillas_cine;

-- =====================================================================
-- GENERO
-- =====================================================================
CREATE TABLE tbl_genero (
    id_genero       INT AUTO_INCREMENT PRIMARY KEY,
    nombre_genero   VARCHAR(50) NOT NULL UNIQUE
) ENGINE=InnoDB;

INSERT INTO tbl_genero (nombre_genero) VALUES
('Acción'), ('Aventura'), ('Comedia'), ('Drama'), ('Terror'),
('Ciencia Ficción'), ('Fantasía'), ('Romance'), ('Suspenso'),
('Animación'), ('Documental'), ('Musical');

-- =====================================================================
-- FORMATO_PELICULA
-- =====================================================================
CREATE TABLE tbl_formato_pelicula (
    id_formato_pelicula      INT AUTO_INCREMENT PRIMARY KEY,
    nombre_formato_pelicula  VARCHAR(20) NOT NULL UNIQUE
) ENGINE=InnoDB;

INSERT INTO tbl_formato_pelicula (nombre_formato_pelicula) VALUES
('2D SUB'),  ('2D DOB'),
('3D SUB'),  ('3D DOB'),
('4D SUB'),  ('4D DOB'),
('IMAX SUB'),('IMAX DOB');

-- =====================================================================
-- CLASIFICACION
-- =====================================================================
CREATE TABLE tbl_clasificacion (
    id_clasificacion      INT AUTO_INCREMENT PRIMARY KEY,
    nombre_clasificacion  VARCHAR(10) NOT NULL UNIQUE
) ENGINE=InnoDB;

INSERT INTO tbl_clasificacion (nombre_clasificacion) VALUES
('A'), ('B'), ('B15'), ('C');

-- =====================================================================
-- ESTADO_PELICULA
-- =====================================================================
CREATE TABLE tbl_estado_pelicula (
    id_estado_pelicula      INT AUTO_INCREMENT PRIMARY KEY,
    nombre_estado_pelicula  VARCHAR(20) NOT NULL UNIQUE
) ENGINE=InnoDB;

INSERT INTO tbl_estado_pelicula (nombre_estado_pelicula) VALUES
('proximamente'), ('en_cartelera'), ('finalizada');

-- =====================================================================
-- PELICULA
-- =====================================================================
CREATE TABLE tbl_pelicula (
    id_pelicula            INT AUTO_INCREMENT PRIMARY KEY,
    id_clasificacion       INT,
    id_estado_pelicula     INT NOT NULL,
    titulo_pelicula        VARCHAR(150) NOT NULL,
    duracion_pelicula      INT NOT NULL,
    director_pelicula      VARCHAR(100),
    descripcion_pelicula   VARCHAR(1000),
    trailer_pelicula       VARCHAR(255),
    fecha_estreno          DATE,
    CONSTRAINT fk_pelicula_clasificacion
        FOREIGN KEY (id_clasificacion) REFERENCES tbl_clasificacion(id_clasificacion)
        ON UPDATE CASCADE ON DELETE RESTRICT,
    CONSTRAINT fk_pelicula_estado
        FOREIGN KEY (id_estado_pelicula) REFERENCES tbl_estado_pelicula(id_estado_pelicula)
        ON UPDATE CASCADE ON DELETE RESTRICT
) ENGINE=InnoDB;

-- =====================================================================
-- PELICULA_GENERO (N:M)
-- =====================================================================
CREATE TABLE tbl_pelicula_genero (
    id_pelicula   INT NOT NULL,
    id_genero     INT NOT NULL,
    PRIMARY KEY (id_pelicula, id_genero),
    CONSTRAINT fk_pg_pelicula
        FOREIGN KEY (id_pelicula) REFERENCES tbl_pelicula(id_pelicula)
        ON UPDATE CASCADE ON DELETE CASCADE,
    CONSTRAINT fk_pg_genero
        FOREIGN KEY (id_genero) REFERENCES tbl_genero(id_genero)
        ON UPDATE CASCADE ON DELETE RESTRICT
) ENGINE=InnoDB;

-- =====================================================================
-- PELICULA_FORMATO_PELICULA (N:M)
-- =====================================================================
CREATE TABLE tbl_pelicula_formatopelicula (
    id_pelicula          INT NOT NULL,
    id_formato_pelicula  INT NOT NULL,
    PRIMARY KEY (id_pelicula, id_formato_pelicula),
    CONSTRAINT fk_pfp_pelicula
        FOREIGN KEY (id_pelicula) REFERENCES tbl_pelicula(id_pelicula)
        ON UPDATE CASCADE ON DELETE CASCADE,
    CONSTRAINT fk_pfp_formato
        FOREIGN KEY (id_formato_pelicula) REFERENCES tbl_formato_pelicula(id_formato_pelicula)
        ON UPDATE CASCADE ON DELETE RESTRICT
) ENGINE=InnoDB;

-- =====================================================================
-- TIPO_SALA
-- =====================================================================
CREATE TABLE tbl_tipo_sala (
    id_tipo_sala       INT AUTO_INCREMENT PRIMARY KEY,
    nombre_tipo_sala   VARCHAR(20) NOT NULL UNIQUE
) ENGINE=InnoDB;

INSERT INTO tbl_tipo_sala (nombre_tipo_sala) VALUES
('2D/3D'), ('4D'), ('IMAX');

-- =====================================================================
-- CIUDAD
-- =====================================================================
CREATE TABLE tbl_ciudad (
    id_ciudad      INT AUTO_INCREMENT PRIMARY KEY,
    nombre_ciudad  VARCHAR(80) NOT NULL UNIQUE
) ENGINE=InnoDB;

-- =====================================================================
-- CINE
-- =====================================================================
CREATE TABLE tbl_cine (
    id_cine       INT AUTO_INCREMENT PRIMARY KEY,
    id_ciudad     INT NOT NULL,
    nombre_cine   VARCHAR(100) NOT NULL,
    CONSTRAINT fk_cine_ciudad
        FOREIGN KEY (id_ciudad) REFERENCES tbl_ciudad(id_ciudad)
        ON UPDATE CASCADE ON DELETE RESTRICT
) ENGINE=InnoDB;

-- =====================================================================
-- SALA
-- =====================================================================
CREATE TABLE tbl_sala (
    id_sala          INT AUTO_INCREMENT PRIMARY KEY,
    id_tipo_sala     INT NOT NULL,
    id_cine          INT NOT NULL,
    numero_sala      INT NOT NULL,
    capacidad_sala   INT NOT NULL,
    CONSTRAINT chk_capacidad_sala CHECK (capacidad_sala >= 20),
    CONSTRAINT fk_sala_tipo
        FOREIGN KEY (id_tipo_sala) REFERENCES tbl_tipo_sala(id_tipo_sala)
        ON UPDATE CASCADE ON DELETE RESTRICT,
    CONSTRAINT fk_sala_cine
        FOREIGN KEY (id_cine) REFERENCES tbl_cine(id_cine)
        ON UPDATE CASCADE ON DELETE RESTRICT
) ENGINE=InnoDB;

-- =====================================================================
-- FUNCION
-- =====================================================================
CREATE TABLE tbl_funcion (
    id_funcion       INT AUTO_INCREMENT PRIMARY KEY,
    id_pelicula      INT NOT NULL,
    id_sala          INT NOT NULL,
    fecha_funcion    DATE NOT NULL,
    hora_funcion     TIME NOT NULL,
    precio_funcion   DECIMAL(6,2) NOT NULL,
    CONSTRAINT fk_funcion_pelicula
        FOREIGN KEY (id_pelicula) REFERENCES tbl_pelicula(id_pelicula)
        ON UPDATE CASCADE ON DELETE RESTRICT,
    CONSTRAINT fk_funcion_sala
        FOREIGN KEY (id_sala) REFERENCES tbl_sala(id_sala)
        ON UPDATE CASCADE ON DELETE RESTRICT
) ENGINE=InnoDB;

-- =====================================================================
-- CLIENTE
-- =====================================================================
CREATE TABLE tbl_cliente (
    id_cliente              INT AUTO_INCREMENT PRIMARY KEY,
    nombre_cliente          VARCHAR(60) NOT NULL,
    apellido_cliente        VARCHAR(60) NOT NULL,
    identificacion_cliente  VARCHAR(20),
    correo_cliente          VARCHAR(100)
) ENGINE=InnoDB;

-- =====================================================================
-- PERFIL
-- =====================================================================
CREATE TABLE tbl_perfil (
    id_perfil       INT AUTO_INCREMENT PRIMARY KEY,
    nombre_perfil   VARCHAR(30) NOT NULL UNIQUE
) ENGINE=InnoDB;

INSERT INTO tbl_perfil (nombre_perfil) VALUES
('admin'), ('taquillero');

-- =====================================================================
-- USUARIO
-- =====================================================================
CREATE TABLE tbl_usuario (
    id_usuario           INT AUTO_INCREMENT PRIMARY KEY,
    id_perfil            INT NOT NULL,
    nombre_usuario       VARCHAR(50) NOT NULL UNIQUE,
    contrasena_usuario   VARCHAR(255) NOT NULL,
    CONSTRAINT fk_usuario_perfil
        FOREIGN KEY (id_perfil) REFERENCES tbl_perfil(id_perfil)
        ON UPDATE CASCADE ON DELETE RESTRICT
) ENGINE=InnoDB;

INSERT INTO tbl_usuario (id_perfil, nombre_usuario, contrasena_usuario)
VALUES (1, 'mishel', SHA2('123', 256));

-- =====================================================================
-- PROMOCION
-- =====================================================================
CREATE TABLE tbl_promocion (
    id_promocion            INT AUTO_INCREMENT PRIMARY KEY,
    nombre_promocion        VARCHAR(100) NOT NULL,
    descripcion_promocion   VARCHAR(255),
    tipo_promocion          VARCHAR(20) NOT NULL,
    valor_promocion         DECIMAL(6,2) NOT NULL,
    fecha_inicio_promocion  DATE NOT NULL,
    fecha_fin_promocion     DATE NOT NULL,
    activa_promocion        BOOLEAN NOT NULL DEFAULT TRUE
) ENGINE=InnoDB;

-- =====================================================================
-- PELICULA_PROMOCION (N:M)
-- =====================================================================
CREATE TABLE tbl_pelicula_promocion (
    id_pelicula      INT NOT NULL,
    id_promocion     INT NOT NULL,
    PRIMARY KEY (id_pelicula, id_promocion),
    CONSTRAINT fk_pp_pelicula
        FOREIGN KEY (id_pelicula) REFERENCES tbl_pelicula(id_pelicula)
        ON UPDATE CASCADE ON DELETE CASCADE,
    CONSTRAINT fk_pp_promocion
        FOREIGN KEY (id_promocion) REFERENCES tbl_promocion(id_promocion)
        ON UPDATE CASCADE ON DELETE CASCADE
) ENGINE=InnoDB;

-- =====================================================================
-- METODO_PAGO
-- =====================================================================
CREATE TABLE tbl_metodo_pago (
    id_metodo_pago      INT AUTO_INCREMENT PRIMARY KEY,
    nombre_metodo_pago  VARCHAR(30) NOT NULL UNIQUE
) ENGINE=InnoDB;

INSERT INTO tbl_metodo_pago (nombre_metodo_pago) VALUES
('efectivo'), ('tarjeta'), ('transferencia');

-- =====================================================================
-- VENTA
-- =====================================================================
CREATE TABLE tbl_venta (
    id_venta                INT AUTO_INCREMENT PRIMARY KEY,
    id_cliente              INT,
    id_promocion            INT,
    id_usuario              INT,
    id_metodo_pago          INT,
    fecha_hora_venta        DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    cantidad_boletos_venta  INT NOT NULL DEFAULT 1,
    total_venta             DECIMAL(8,2) NOT NULL,
    CONSTRAINT chk_cantidad_boletos_venta CHECK (cantidad_boletos_venta >= 1),
    CONSTRAINT fk_venta_cliente
        FOREIGN KEY (id_cliente) REFERENCES tbl_cliente(id_cliente)
        ON UPDATE CASCADE ON DELETE SET NULL,
    CONSTRAINT fk_venta_promocion
        FOREIGN KEY (id_promocion) REFERENCES tbl_promocion(id_promocion)
        ON UPDATE CASCADE ON DELETE SET NULL,
    CONSTRAINT fk_venta_usuario
        FOREIGN KEY (id_usuario) REFERENCES tbl_usuario(id_usuario)
        ON UPDATE CASCADE ON DELETE SET NULL,
    CONSTRAINT fk_venta_metodopago
        FOREIGN KEY (id_metodo_pago) REFERENCES tbl_metodo_pago(id_metodo_pago)
        ON UPDATE CASCADE ON DELETE RESTRICT
) ENGINE=InnoDB;

-- =====================================================================
-- ESTADO_BOLETO
-- =====================================================================
CREATE TABLE tbl_estado_boleto (
    id_estado_boleto      INT AUTO_INCREMENT PRIMARY KEY,
    nombre_estado_boleto  VARCHAR(15) NOT NULL UNIQUE
) ENGINE=InnoDB;

INSERT INTO tbl_estado_boleto (nombre_estado_boleto) VALUES
('vendido'), ('cancelado');

-- =====================================================================
-- BOLETO
-- =====================================================================
CREATE TABLE tbl_boleto (
    id_boleto         INT AUTO_INCREMENT PRIMARY KEY,
    id_funcion        INT NOT NULL,
    id_venta          INT NOT NULL,
    id_estado_boleto  INT NOT NULL,
    numero_boleto     INT NOT NULL,
    CONSTRAINT fk_boleto_funcion
        FOREIGN KEY (id_funcion) REFERENCES tbl_funcion(id_funcion)
        ON UPDATE CASCADE ON DELETE RESTRICT,
    CONSTRAINT fk_boleto_venta
        FOREIGN KEY (id_venta) REFERENCES tbl_venta(id_venta)
        ON UPDATE CASCADE ON DELETE RESTRICT,
    CONSTRAINT fk_boleto_estado
        FOREIGN KEY (id_estado_boleto) REFERENCES tbl_estado_boleto(id_estado_boleto)
        ON UPDATE CASCADE ON DELETE RESTRICT,
    CONSTRAINT uq_boleto_funcion_asiento UNIQUE (id_funcion, numero_boleto)
) ENGINE=InnoDB;

CREATE INDEX idx_boleto_funcion ON tbl_boleto(id_funcion);

-- =====================================================================
-- VISTA: BOLETOS VENDIDOS POR FUNCION
-- =====================================================================
CREATE VIEW vw_boletos_vendidos AS
SELECT
    b.id_funcion,
    b.numero_boleto,
    b.id_estado_boleto
FROM tbl_boleto b
JOIN tbl_estado_boleto e ON e.id_estado_boleto = b.id_estado_boleto
WHERE e.nombre_estado_boleto <> 'cancelado';

-- =====================================================================
-- ACCION_PERMISO
-- =====================================================================
CREATE TABLE tbl_accion_permiso (
    id_accion_permiso      INT AUTO_INCREMENT PRIMARY KEY,
    nombre_accion_permiso  VARCHAR(50) NOT NULL UNIQUE
) ENGINE=InnoDB;

INSERT INTO tbl_accion_permiso (nombre_accion_permiso) VALUES
('mantenimiento'), ('procesos'), ('eliminar'), ('registrar'), ('modificar');

-- =====================================================================
-- APLICACION
-- =====================================================================
CREATE TABLE tbl_aplicacion (
    id_aplicacion      INT AUTO_INCREMENT PRIMARY KEY,
    codigo_aplicacion  VARCHAR(15) NOT NULL UNIQUE,
    nombre_aplicacion  VARCHAR(80) NOT NULL
) ENGINE=InnoDB;

INSERT INTO tbl_aplicacion (codigo_aplicacion, nombre_aplicacion) VALUES
('APL103','Películas'),
('APL104','Funciones'),
('APL105','Salas'),
('APL106','Cines'),
('APL107','Promociones'),
('APL108','Clientes'),
('APL109','Usuarios y perfiles'),
('APL110','Venta de boletos'),
('APL111','Cancelación de boletos'),
('APL112','Reportes');

-- =====================================================================
-- PERMISO
-- =====================================================================
CREATE TABLE tbl_permiso (
    id_permiso          INT AUTO_INCREMENT PRIMARY KEY,
    id_accion_permiso   INT NOT NULL,
    id_aplicacion       INT NOT NULL,
    CONSTRAINT uq_permiso_accion_aplicacion UNIQUE (id_accion_permiso, id_aplicacion),
    CONSTRAINT fk_permiso_accion
        FOREIGN KEY (id_accion_permiso) REFERENCES tbl_accion_permiso(id_accion_permiso)
        ON UPDATE CASCADE ON DELETE RESTRICT,
    CONSTRAINT fk_permiso_aplicacion
        FOREIGN KEY (id_aplicacion) REFERENCES tbl_aplicacion(id_aplicacion)
        ON UPDATE CASCADE ON DELETE RESTRICT
) ENGINE=InnoDB;

-- =====================================================================
-- PERFIL_PERMISO (N:M)
-- =====================================================================
CREATE TABLE tbl_perfil_permiso (
    id_perfil    INT NOT NULL,
    id_permiso   INT NOT NULL,
    PRIMARY KEY (id_perfil, id_permiso),
    CONSTRAINT fk_pp_perfil
        FOREIGN KEY (id_perfil) REFERENCES tbl_perfil(id_perfil)
        ON UPDATE CASCADE ON DELETE CASCADE,
    CONSTRAINT fk_pp_permiso
        FOREIGN KEY (id_permiso) REFERENCES tbl_permiso(id_permiso)
        ON UPDATE CASCADE ON DELETE CASCADE
) ENGINE=InnoDB;

-- =====================================================================
-- NOMBRE_PC
-- =====================================================================
CREATE TABLE tbl_nombre_pc (
    id_nombre_pc   INT AUTO_INCREMENT PRIMARY KEY,
    nombre_pc      VARCHAR(50) NOT NULL UNIQUE
) ENGINE=InnoDB;

-- =====================================================================
-- BITACORA
-- =====================================================================
CREATE TABLE tbl_bitacora (
    id_bitacora    INT AUTO_INCREMENT PRIMARY KEY,
    id_usuario     INT NOT NULL,
    id_permiso     INT,
    id_nombre_pc   INT,
    fecha          DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    ip             VARCHAR(45),
    CONSTRAINT fk_bitacora_usuario
        FOREIGN KEY (id_usuario) REFERENCES tbl_usuario(id_usuario)
        ON UPDATE CASCADE ON DELETE RESTRICT,
    CONSTRAINT fk_bitacora_permiso
        FOREIGN KEY (id_permiso) REFERENCES tbl_permiso(id_permiso)
        ON UPDATE CASCADE ON DELETE SET NULL,
    CONSTRAINT fk_bitacora_nombre_pc
        FOREIGN KEY (id_nombre_pc) REFERENCES tbl_nombre_pc(id_nombre_pc)
        ON UPDATE CASCADE ON DELETE SET NULL
) ENGINE=InnoDB;

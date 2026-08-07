-- =====================================================================
-- BASE DE DATOS taquillas_cine ACTUALIZADO CUARTA ENTREGA (CORREGIDO)
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
-- BITACORA INICIAL
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


USE taquillas_cine;

-- PROCEDURES SEGURIDAD -- MISHEL LOEIZA

-- =====================================================================
-- 1. Asegurar que existan los permisos (registrar/modificar/eliminar)
--    para cada aplicación que vamos a vigilar.
-- =====================================================================
INSERT IGNORE INTO tbl_permiso (id_accion_permiso, id_aplicacion)
SELECT ap.id_accion_permiso, apl.id_aplicacion
FROM tbl_accion_permiso ap
JOIN tbl_aplicacion apl ON apl.codigo_aplicacion IN
    ('APL103','APL104','APL105','APL106','APL107','APL108','APL109','APL110','APL111')
WHERE ap.nombre_accion_permiso IN ('registrar','modificar','eliminar');

-- =====================================================================
-- 2. Procedimiento reutilizable: inserta el renglón en tbl_bitacora
--    usando las variables de sesión que Conexion.cs establece.
--    (version inicial; se reemplaza mas abajo tras normalizar columnas)
-- =====================================================================
DROP PROCEDURE IF EXISTS sp_bitacora_registrar;

DELIMITER $$
CREATE PROCEDURE sp_bitacora_registrar(
    IN p_accion VARCHAR(50),
    IN p_codigo_app VARCHAR(15)
)
BEGIN
    DECLARE v_permiso INT;

    SELECT p.id_permiso INTO v_permiso
    FROM tbl_permiso p
    JOIN tbl_accion_permiso a ON a.id_accion_permiso = p.id_accion_permiso
    JOIN tbl_aplicacion ap ON ap.id_aplicacion = p.id_aplicacion
    WHERE a.nombre_accion_permiso = p_accion
      AND ap.codigo_aplicacion = p_codigo_app
    LIMIT 1;

    IF @bitacora_usuario IS NOT NULL THEN
        INSERT INTO tbl_bitacora (id_usuario, id_permiso, id_nombre_pc, ip, fecha)
        VALUES (@bitacora_usuario, v_permiso, @bitacora_pc, @bitacora_ip, NOW());
    END IF;
END$$
DELIMITER ;

-- =====================================================================
-- 3. Triggers por tabla  -- MISHEL LOEIZA -- MANEJO DE ACCIÓN
-- =====================================================================

-- ---------- PELICULA (APL103) ----------
DROP TRIGGER IF EXISTS trg_pelicula_insert;
DROP TRIGGER IF EXISTS trg_pelicula_update;
DROP TRIGGER IF EXISTS trg_pelicula_delete;

DELIMITER $$
CREATE TRIGGER trg_pelicula_insert AFTER INSERT ON tbl_pelicula
FOR EACH ROW BEGIN CALL sp_bitacora_registrar('registrar', 'APL103'); END$$
CREATE TRIGGER trg_pelicula_update AFTER UPDATE ON tbl_pelicula
FOR EACH ROW BEGIN CALL sp_bitacora_registrar('modificar', 'APL103'); END$$
CREATE TRIGGER trg_pelicula_delete AFTER DELETE ON tbl_pelicula
FOR EACH ROW BEGIN CALL sp_bitacora_registrar('eliminar', 'APL103'); END$$
DELIMITER ;

-- ---------- FUNCION (APL104) ----------
DROP TRIGGER IF EXISTS trg_funcion_insert;
DROP TRIGGER IF EXISTS trg_funcion_update;
DROP TRIGGER IF EXISTS trg_funcion_delete;

DELIMITER $$
CREATE TRIGGER trg_funcion_insert AFTER INSERT ON tbl_funcion
FOR EACH ROW BEGIN CALL sp_bitacora_registrar('registrar', 'APL104'); END$$
CREATE TRIGGER trg_funcion_update AFTER UPDATE ON tbl_funcion
FOR EACH ROW BEGIN CALL sp_bitacora_registrar('modificar', 'APL104'); END$$
CREATE TRIGGER trg_funcion_delete AFTER DELETE ON tbl_funcion
FOR EACH ROW BEGIN CALL sp_bitacora_registrar('eliminar', 'APL104'); END$$
DELIMITER ;

-- ---------- SALA (APL105) ----------
DROP TRIGGER IF EXISTS trg_sala_insert;
DROP TRIGGER IF EXISTS trg_sala_update;
DROP TRIGGER IF EXISTS trg_sala_delete;

DELIMITER $$
CREATE TRIGGER trg_sala_insert AFTER INSERT ON tbl_sala
FOR EACH ROW BEGIN CALL sp_bitacora_registrar('registrar', 'APL105'); END$$
CREATE TRIGGER trg_sala_update AFTER UPDATE ON tbl_sala
FOR EACH ROW BEGIN CALL sp_bitacora_registrar('modificar', 'APL105'); END$$
CREATE TRIGGER trg_sala_delete AFTER DELETE ON tbl_sala
FOR EACH ROW BEGIN CALL sp_bitacora_registrar('eliminar', 'APL105'); END$$
DELIMITER ;

-- ---------- CINE (APL106) ----------
DROP TRIGGER IF EXISTS trg_cine_insert;
DROP TRIGGER IF EXISTS trg_cine_update;
DROP TRIGGER IF EXISTS trg_cine_delete;

DELIMITER $$
CREATE TRIGGER trg_cine_insert AFTER INSERT ON tbl_cine
FOR EACH ROW BEGIN CALL sp_bitacora_registrar('registrar', 'APL106'); END$$
CREATE TRIGGER trg_cine_update AFTER UPDATE ON tbl_cine
FOR EACH ROW BEGIN CALL sp_bitacora_registrar('modificar', 'APL106'); END$$
CREATE TRIGGER trg_cine_delete AFTER DELETE ON tbl_cine
FOR EACH ROW BEGIN CALL sp_bitacora_registrar('eliminar', 'APL106'); END$$
DELIMITER ;

-- ---------- PROMOCION (APL107) ----------
DROP TRIGGER IF EXISTS trg_promocion_insert;
DROP TRIGGER IF EXISTS trg_promocion_update;
DROP TRIGGER IF EXISTS trg_promocion_delete;

DELIMITER $$
CREATE TRIGGER trg_promocion_insert AFTER INSERT ON tbl_promocion
FOR EACH ROW BEGIN CALL sp_bitacora_registrar('registrar', 'APL107'); END$$
CREATE TRIGGER trg_promocion_update AFTER UPDATE ON tbl_promocion
FOR EACH ROW BEGIN CALL sp_bitacora_registrar('modificar', 'APL107'); END$$
CREATE TRIGGER trg_promocion_delete AFTER DELETE ON tbl_promocion
FOR EACH ROW BEGIN CALL sp_bitacora_registrar('eliminar', 'APL107'); END$$
DELIMITER ;

-- ---------- CLIENTE (APL108) ----------
DROP TRIGGER IF EXISTS trg_cliente_insert;
DROP TRIGGER IF EXISTS trg_cliente_update;
DROP TRIGGER IF EXISTS trg_cliente_delete;

DELIMITER $$
CREATE TRIGGER trg_cliente_insert AFTER INSERT ON tbl_cliente
FOR EACH ROW BEGIN CALL sp_bitacora_registrar('registrar', 'APL108'); END$$
CREATE TRIGGER trg_cliente_update AFTER UPDATE ON tbl_cliente
FOR EACH ROW BEGIN CALL sp_bitacora_registrar('modificar', 'APL108'); END$$
CREATE TRIGGER trg_cliente_delete AFTER DELETE ON tbl_cliente
FOR EACH ROW BEGIN CALL sp_bitacora_registrar('eliminar', 'APL108'); END$$
DELIMITER ;

-- ---------- USUARIO (APL109) ----------
DROP TRIGGER IF EXISTS trg_usuario_insert;
DROP TRIGGER IF EXISTS trg_usuario_update;
DROP TRIGGER IF EXISTS trg_usuario_delete;

DELIMITER $$
CREATE TRIGGER trg_usuario_insert AFTER INSERT ON tbl_usuario
FOR EACH ROW BEGIN CALL sp_bitacora_registrar('registrar', 'APL109'); END$$
CREATE TRIGGER trg_usuario_update AFTER UPDATE ON tbl_usuario
FOR EACH ROW BEGIN CALL sp_bitacora_registrar('modificar', 'APL109'); END$$
CREATE TRIGGER trg_usuario_delete AFTER DELETE ON tbl_usuario
FOR EACH ROW BEGIN CALL sp_bitacora_registrar('eliminar', 'APL109'); END$$
DELIMITER ;

-- ---------- VENTA (APL110) — solo se registra ----------
DROP TRIGGER IF EXISTS trg_venta_insert;

DELIMITER $$
CREATE TRIGGER trg_venta_insert AFTER INSERT ON tbl_venta
FOR EACH ROW BEGIN CALL sp_bitacora_registrar('registrar', 'APL110'); END$$
DELIMITER ;

-- ---------- BOLETO (APL111) — solo cuando cambia a "cancelado" ----------
DROP TRIGGER IF EXISTS trg_boleto_cancelar;

DELIMITER $$
CREATE TRIGGER trg_boleto_cancelar AFTER UPDATE ON tbl_boleto
FOR EACH ROW
BEGIN
    IF NEW.id_estado_boleto <> OLD.id_estado_boleto THEN
        CALL sp_bitacora_registrar('eliminar', 'APL111');
    END IF;
END$$
DELIMITER ;

-- DIEGO PROMOCION-- CAMBIOS Y ACTUALIZACION
CREATE TABLE tbl_tipo_promocion (
    id_tipo_promocion     INT AUTO_INCREMENT PRIMARY KEY,
    codigo_tipo_promocion VARCHAR(20) NOT NULL UNIQUE,
    nombre_tipo_promocion VARCHAR(50) NOT NULL
) ENGINE=InnoDB;

INSERT INTO tbl_tipo_promocion (codigo_tipo_promocion, nombre_tipo_promocion) VALUES
    ('PORCENTAJE',   'Descuento por porcentaje'),
    ('MONTO_FIJO',   'Descuento de monto fijo'),
    ('2X1',          'Lleva dos paga uno'),
    ('ENVIO_GRATIS', 'Envío gratis');


ALTER TABLE tbl_promocion
    DROP COLUMN tipo_promocion,
    ADD COLUMN id_tipo_promocion INT NOT NULL AFTER descripcion_promocion,
    ADD CONSTRAINT fk_promocion_tipo
        FOREIGN KEY (id_tipo_promocion)
        REFERENCES tbl_tipo_promocion (id_tipo_promocion);


USE taquillas_cine;

-- =====================================================================
-- NORMALIZACION DE BITACORA -- MISHEL LOEIZA
-- (bloque unico)
-- =====================================================================

-- columna vieja 'fecha', renombrada
ALTER TABLE tbl_bitacora
CHANGE COLUMN fecha fecha_bitacora DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP;

-- columna vieja 'ip', renombrada
ALTER TABLE tbl_bitacora
CHANGE COLUMN ip ip_bitacora VARCHAR(45) AFTER id_nombre_pc;

-- nueva columna hora_bitacora (se llena via trigger o procedimiento)
ALTER TABLE tbl_bitacora
ADD COLUMN hora_bitacora TIME AFTER fecha_bitacora;

DROP TRIGGER IF EXISTS trg_bitacora_hora;

DELIMITER //
CREATE TRIGGER trg_bitacora_hora
BEFORE INSERT ON tbl_bitacora
FOR EACH ROW
BEGIN
  SET NEW.hora_bitacora = CURTIME();
END;
//
DELIMITER ;

-- =====================================================================
-- Procedimiento actualizado de bitacora (usa columnas normalizadas)
-- =====================================================================
DROP PROCEDURE IF EXISTS sp_bitacora_registrar;

DELIMITER $$
CREATE PROCEDURE sp_bitacora_registrar(
    IN p_accion VARCHAR(50),
    IN p_codigo_app VARCHAR(15)
)
BEGIN
    DECLARE v_permiso INT;

    SELECT p.id_permiso INTO v_permiso
    FROM tbl_permiso p
    JOIN tbl_accion_permiso a ON a.id_accion_permiso = p.id_accion_permiso
    JOIN tbl_aplicacion ap ON ap.id_aplicacion = p.id_aplicacion
    WHERE a.nombre_accion_permiso = p_accion
      AND ap.codigo_aplicacion = p_codigo_app
    LIMIT 1;

    IF @bitacora_usuario IS NOT NULL THEN
        INSERT INTO tbl_bitacora (id_usuario, id_permiso, id_nombre_pc, ip_bitacora, fecha_bitacora, hora_bitacora)
        VALUES (@bitacora_usuario, v_permiso, @bitacora_pc, @bitacora_ip, NOW(), CURTIME());
    END IF;
END$$
DELIMITER ;


-- =====================================================================
-- PROCEDURES CARTELERA -- CARLOS
-- =====================================================================
DROP PROCEDURE IF EXISTS sp_cartelera;
DELIMITER $$

CREATE PROCEDURE sp_cartelera()
BEGIN
    SELECT
        p.id_pelicula AS idPelicula,
        p.titulo_pelicula AS Titulo,
        p.duracion_pelicula AS Duración,
        c.nombre_clasificacion AS clasificacion,

        GROUP_CONCAT(DISTINCT g.nombre_genero
                     ORDER BY g.nombre_genero
                     SEPARATOR ', ') AS Generos,

        GROUP_CONCAT(DISTINCT fp.nombre_formato_pelicula
                     ORDER BY fp.nombre_formato_pelicula
                     SEPARATOR ', ') AS Formatos,
                     p.trailer_pelicula AS Trailer

    FROM tbl_pelicula p

    INNER JOIN tbl_estado_pelicula ep
        ON p.id_estado_pelicula = ep.id_estado_pelicula

    LEFT JOIN tbl_clasificacion c
        ON p.id_clasificacion = c.id_clasificacion

    LEFT JOIN tbl_pelicula_genero pg
        ON p.id_pelicula = pg.id_pelicula

    LEFT JOIN tbl_genero g
        ON pg.id_genero = g.id_genero

    LEFT JOIN tbl_pelicula_formatopelicula pfp
        ON p.id_pelicula = pfp.id_pelicula

    LEFT JOIN tbl_formato_pelicula fp
        ON pfp.id_formato_pelicula = fp.id_formato_pelicula

    WHERE ep.id_estado_pelicula = 1

    GROUP BY
        p.id_pelicula,
        p.titulo_pelicula,
        p.descripcion_pelicula,
        p.duracion_pelicula,
        p.director_pelicula,
        p.fecha_estreno,
        c.nombre_clasificacion

    ORDER BY p.titulo_pelicula;
END$$

DELIMITER ;

DROP PROCEDURE IF EXISTS sp_filtrar_cartelera;
DELIMITER $$

CREATE PROCEDURE sp_filtrar_cartelera(
    IN p_id_formato INT,
    IN p_id_ciudad INT,
    IN p_id_cine INT
)
BEGIN

    SELECT
        p.id_pelicula AS idPelicula,
        p.titulo_pelicula AS Titulo,
        p.duracion_pelicula AS Duracion,
        c.nombre_clasificacion AS Clasificacion,

        GROUP_CONCAT(DISTINCT g.nombre_genero
            ORDER BY g.nombre_genero
            SEPARATOR ', ') AS Generos,

        GROUP_CONCAT(DISTINCT fp.nombre_formato_pelicula
            ORDER BY fp.nombre_formato_pelicula
            SEPARATOR ', ') AS Formatos,

        p.trailer_pelicula AS Trailer

    FROM tbl_pelicula p

    INNER JOIN tbl_estado_pelicula ep
        ON p.id_estado_pelicula = ep.id_estado_pelicula

    INNER JOIN tbl_funcion f
        ON p.id_pelicula = f.id_pelicula

    INNER JOIN tbl_sala s
        ON f.id_sala = s.id_sala

    INNER JOIN tbl_cine ci
        ON s.id_cine = ci.id_cine

    INNER JOIN tbl_ciudad cd
        ON ci.id_ciudad = cd.id_ciudad

    LEFT JOIN tbl_clasificacion c
        ON p.id_clasificacion = c.id_clasificacion

    LEFT JOIN tbl_pelicula_genero pg
        ON p.id_pelicula = pg.id_pelicula

    LEFT JOIN tbl_genero g
        ON pg.id_genero = g.id_genero

    LEFT JOIN tbl_pelicula_formatopelicula pfp
        ON p.id_pelicula = pfp.id_pelicula

    LEFT JOIN tbl_formato_pelicula fp
        ON pfp.id_formato_pelicula = fp.id_formato_pelicula

    WHERE ep.id_estado_pelicula = 1
      AND (p_id_formato = 0 OR fp.id_formato_pelicula = p_id_formato)
      AND (p_id_ciudad = 0 OR cd.id_ciudad = p_id_ciudad)
      AND (p_id_cine = 0 OR ci.id_cine = p_id_cine)

    GROUP BY
        p.id_pelicula,
        p.titulo_pelicula,
        p.duracion_pelicula,
        c.nombre_clasificacion,
        p.trailer_pelicula

    ORDER BY p.titulo_pelicula;

END$$

DELIMITER ;
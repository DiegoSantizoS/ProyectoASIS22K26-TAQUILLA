-- =====================================================================
-- 
--   2. Se separan en catálogos los campos que estaban como VARCHAR:
--        - VENTA.metodo_pago_venta       -> tabla METODO_PAGO
--        - PELICULA.clasificacion_pelicula -> tabla CLASIFICACION
--   3. Se agrega a VENTA el campo cantidad_boletos_venta, ya que en
--      una venta se pueden comprar varios boletos.
--   4. Se documenta la cardinalidad y las reglas ON UPDATE / ON DELETE
--      de cada relación (ver comentarios junto a cada FK).
-- =====================================================================

CREATE DATABASE IF NOT EXISTS taquillas_cine
  CHARACTER SET utf8mb4
  COLLATE utf8mb4_unicode_ci;

USE taquillas_cine;

-- -----------------------------------------------------
-- Tabla: GENERO (catálogo)
-- -----------------------------------------------------
CREATE TABLE tbl_genero (
    id_genero       INT AUTO_INCREMENT PRIMARY KEY,
    nombre_genero   VARCHAR(50) NOT NULL UNIQUE
) ENGINE=InnoDB;

-- -----------------------------------------------------
-- Tabla: TIPO_PELICULA (catálogo)
-- -----------------------------------------------------
CREATE TABLE tbl_tipo_pelicula (
    id_tipo_pelicula      INT AUTO_INCREMENT PRIMARY KEY,
    nombre_tipo_pelicula  VARCHAR(20) NOT NULL UNIQUE
) ENGINE=InnoDB;

INSERT INTO tbl_tipo_pelicula (nombre_tipo_pelicula) VALUES
('2D SUB'),  ('2D DOB'),
('3D SUB'),  ('3D DOB'),
('4D SUB'),  ('4D DOB'),
('IMAX SUB'),('IMAX DOB');

-- -----------------------------------------------------
-- Tabla: CLASIFICACION (catálogo)
-- CORRECCIÓN: antes era VARCHAR(10) dentro de PELICULA.
-- Se separa en tabla propia para evitar datos inconsistentes
-- (ej. "PG-13" vs "PG13") y facilitar mantenimiento.
-- -----------------------------------------------------
CREATE TABLE tbl_clasificacion (
    id_clasificacion      INT AUTO_INCREMENT PRIMARY KEY,
    nombre_clasificacion  VARCHAR(10) NOT NULL UNIQUE  -- 'A', 'B', 'B15', 'C'
) ENGINE=InnoDB;

INSERT INTO tbl_clasificacion (nombre_clasificacion) VALUES
('A'), ('B'), ('B15'), ('C');

-- -----------------------------------------------------
-- Tabla: PELICULA
-- -----------------------------------------------------
CREATE TABLE tbl_pelicula (
    id_pelicula             INT AUTO_INCREMENT PRIMARY KEY,
    titulo_pelicula         VARCHAR(150) NOT NULL,
    duracion_pelicula       INT NOT NULL,
    id_clasificacion        INT,                      -- FK -> CLASIFICACION (antes VARCHAR)
    id_genero               INT,
    id_tipo_pelicula        INT,
    director_pelicula       VARCHAR(100),
    trailer_pelicula        VARCHAR(255),
    imagen_pelicula         VARCHAR(255),
    estado_pelicula         VARCHAR(20) NOT NULL DEFAULT 'proximamente',
    fecha_estreno           DATE,
    CONSTRAINT chk_estado_pelicula
        CHECK (estado_pelicula IN ('cartelera', 'proximamente')),
    -- Cardinalidad: 1 CLASIFICACION : N PELICULA. RESTRICT: no se borra
    -- una clasificación si hay películas usándola.
    CONSTRAINT fk_pelicula_clasificacion
        FOREIGN KEY (id_clasificacion) REFERENCES tbl_clasificacion(id_clasificacion)
        ON UPDATE CASCADE ON DELETE RESTRICT,
    -- Cardinalidad: 1 GENERO : N PELICULA. RESTRICT: no se borra un
    -- género con películas asociadas.
    CONSTRAINT fk_pelicula_genero
        FOREIGN KEY (id_genero) REFERENCES tbl_genero(id_genero)
        ON UPDATE CASCADE ON DELETE RESTRICT,
    -- Cardinalidad: 1 TIPO_PELICULA : N PELICULA. RESTRICT: no se borra
    -- un tipo de película con películas asociadas.
    CONSTRAINT fk_pelicula_tipopelicula
        FOREIGN KEY (id_tipo_pelicula) REFERENCES tbl_tipo_pelicula(id_tipo_pelicula)
        ON UPDATE CASCADE ON DELETE RESTRICT
) ENGINE=InnoDB;

-- -----------------------------------------------------
-- Tabla: TIPO_SALA (catálogo) - 3 opciones fijas.
-- -----------------------------------------------------
CREATE TABLE tbl_tipo_sala (
    id_tipo_sala       INT AUTO_INCREMENT PRIMARY KEY,
    nombre_tipo_sala   VARCHAR(20) NOT NULL UNIQUE
) ENGINE=InnoDB;

INSERT INTO tbl_tipo_sala (nombre_tipo_sala) VALUES
('2D/3D'), ('4D'), ('IMAX');

-- -----------------------------------------------------
-- Tabla: CIUDAD
-- -----------------------------------------------------
CREATE TABLE tbl_ciudad (
    id_ciudad      INT AUTO_INCREMENT PRIMARY KEY,
    nombre_ciudad  VARCHAR(80) NOT NULL UNIQUE
) ENGINE=InnoDB;

-- -----------------------------------------------------
-- Tabla: CINE
-- -----------------------------------------------------
CREATE TABLE tbl_cine (
    id_cine         INT AUTO_INCREMENT PRIMARY KEY,
    id_ciudad       INT NOT NULL,
    nombre_cine     VARCHAR(100) NOT NULL,
    -- Cardinalidad: 1 CIUDAD : N CINE. RESTRICT: no se borra una ciudad
    -- si tiene cines registrados.
    CONSTRAINT fk_cine_ciudad
        FOREIGN KEY (id_ciudad) REFERENCES tbl_ciudad(id_ciudad)
        ON UPDATE CASCADE ON DELETE RESTRICT
) ENGINE=InnoDB;

-- -----------------------------------------------------
-- Tabla: SALA
-- capacidad_sala es dinámica: el admin la actualiza
-- directamente cuando quiere cambiar cuántas butacas tiene
-- la sala (UPDATE tbl_sala SET capacidad_sala = X WHERE id_sala = ?).
-- -----------------------------------------------------
CREATE TABLE tbl_sala (
    id_sala          INT AUTO_INCREMENT PRIMARY KEY,
    numero_sala      INT NOT NULL,
    capacidad_sala   INT NOT NULL,
    id_tipo_sala     INT NOT NULL,
    id_cine          INT NOT NULL,
    CONSTRAINT chk_capacidad_sala
        CHECK (capacidad_sala >= 20),
    -- Cardinalidad: 1 TIPO_SALA : N SALA. RESTRICT: no se borra un tipo
    -- de sala si hay salas de ese tipo.
    CONSTRAINT fk_sala_tipo
        FOREIGN KEY (id_tipo_sala) REFERENCES tbl_tipo_sala(id_tipo_sala)
        ON UPDATE CASCADE ON DELETE RESTRICT,
    -- Cardinalidad: 1 CINE : N SALA. RESTRICT: no se borra un cine si
    -- tiene salas registradas.
    CONSTRAINT fk_sala_cine
        FOREIGN KEY (id_cine) REFERENCES tbl_cine(id_cine)
        ON UPDATE CASCADE ON DELETE RESTRICT
) ENGINE=InnoDB;

-- -----------------------------------------------------
-- Tabla: TIPO_FUNCION (catálogo)
-- Formatos de proyección: 2D, 3D, 4D, IMAX, etc.
-- -----------------------------------------------------
CREATE TABLE tbl_tipo_funcion (
    id_tipo_funcion       INT AUTO_INCREMENT PRIMARY KEY,
    nombre_tipo_funcion   VARCHAR(20) NOT NULL UNIQUE -- '2D', '3D', '4D', 'IMAX'
) ENGINE=InnoDB;

INSERT INTO tbl_tipo_funcion (nombre_tipo_funcion) VALUES
('2D'), ('3D'), ('4D'), ('IMAX');

-- -----------------------------------------------------
-- Tabla: FUNCION
-- -----------------------------------------------------
CREATE TABLE tbl_funcion (
    id_funcion       INT AUTO_INCREMENT PRIMARY KEY,
    id_pelicula      INT NOT NULL,
    id_sala          INT NOT NULL,
    id_tipo_funcion  INT NOT NULL,
    fecha_funcion    DATE NOT NULL,
    hora_funcion     TIME NOT NULL,
    precio_funcion   DECIMAL(6,2) NOT NULL,
    -- Cardinalidad: 1 PELICULA : N FUNCION. RESTRICT: no se puede
    -- borrar una película con funciones programadas.
    CONSTRAINT fk_funcion_pelicula
        FOREIGN KEY (id_pelicula) REFERENCES tbl_pelicula(id_pelicula)
        ON UPDATE CASCADE ON DELETE RESTRICT,
    -- Cardinalidad: 1 SALA : N FUNCION. RESTRICT: no se puede borrar
    -- una sala con funciones programadas.
    CONSTRAINT fk_funcion_sala
        FOREIGN KEY (id_sala) REFERENCES tbl_sala(id_sala)
        ON UPDATE CASCADE ON DELETE RESTRICT,
    -- Cardinalidad: 1 TIPO_FUNCION : N FUNCION. RESTRICT: no se puede
    -- borrar un tipo de función en uso.
    CONSTRAINT fk_funcion_tipo
        FOREIGN KEY (id_tipo_funcion) REFERENCES tbl_tipo_funcion(id_tipo_funcion)
        ON UPDATE CASCADE ON DELETE RESTRICT
) ENGINE=InnoDB;

-- -----------------------------------------------------
-- Tabla: CLIENTE
-- -----------------------------------------------------
CREATE TABLE tbl_cliente (
    id_cliente              INT AUTO_INCREMENT PRIMARY KEY,
    nombre_cliente          VARCHAR(60) NOT NULL,
    apellido_cliente        VARCHAR(60) NOT NULL,
    identificacion_cliente  VARCHAR(20),
    correo_cliente          VARCHAR(100)
) ENGINE=InnoDB;

-- -----------------------------------------------------
-- Tabla: PERFIL (catálogo) - roles del sistema
-- -----------------------------------------------------
CREATE TABLE tbl_perfil (
    id_perfil       INT AUTO_INCREMENT PRIMARY KEY,
    nombre_perfil   VARCHAR(30) NOT NULL UNIQUE
) ENGINE=InnoDB;

INSERT INTO tbl_perfil (nombre_perfil) VALUES
('admin'), ('taquillero');

-- -----------------------------------------------------
-- Tabla: USUARIO
-- Login (nombre + contraseña) + su perfil/puesto asignado.
-- contraseña en sha
-- -----------------------------------------------------
CREATE TABLE tbl_usuario (
    id_usuario           INT AUTO_INCREMENT PRIMARY KEY,
    id_perfil            INT NOT NULL,
    nombre_usuario       VARCHAR(50) NOT NULL UNIQUE,   -- username de login
    contrasena_usuario   VARCHAR(255) NOT NULL,         -- hash (SHA2/bcrypt), no texto plano
    -- Cardinalidad: 1 PERFIL : N USUARIO. RESTRICT: no se borra un
    -- perfil si hay usuarios asignados a él.
    CONSTRAINT fk_usuario_perfil
        FOREIGN KEY (id_perfil) REFERENCES tbl_perfil(id_perfil)
        ON UPDATE CASCADE ON DELETE RESTRICT
) ENGINE=InnoDB;

-- -----------------------------------------------------
-- Tabla: PROMOCION
-- -----------------------------------------------------
CREATE TABLE tbl_promocion (
    id_promocion            INT AUTO_INCREMENT PRIMARY KEY,
    nombre_promocion        VARCHAR(100) NOT NULL,
    descripcion_promocion   VARCHAR(255),
    tipo_promocion          VARCHAR(20) NOT NULL,   -- 'porcentaje' o 'monto_fijo'
    valor_promocion         DECIMAL(6,2) NOT NULL,  -- ej: 20.00 (%) o 15.00 (Q)
    fecha_inicio_promocion  DATE NOT NULL,
    fecha_fin_promocion     DATE NOT NULL,
    activa_promocion        BOOLEAN NOT NULL DEFAULT TRUE
) ENGINE=InnoDB;

-- -----------------------------------------------------
-- Tabla: PELICULA_PROMOCION (relación N:M)
-- -----------------------------------------------------
CREATE TABLE tbl_pelicula_promocion (
    id_pelicula      INT NOT NULL,
    id_promocion     INT NOT NULL,
    PRIMARY KEY (id_pelicula, id_promocion),
    -- Cardinalidad: N a M entre PELICULA y PROMOCION.
    -- CASCADE: si se borra la película, se elimina su relación con promociones.
    CONSTRAINT fk_pp_pelicula
        FOREIGN KEY (id_pelicula) REFERENCES tbl_pelicula(id_pelicula)
        ON UPDATE CASCADE ON DELETE CASCADE,
    -- CASCADE: si se borra la promoción, se elimina su relación con películas.
    CONSTRAINT fk_pp_promocion
        FOREIGN KEY (id_promocion) REFERENCES tbl_promocion(id_promocion)
        ON UPDATE CASCADE ON DELETE CASCADE
) ENGINE=InnoDB;

-- -----------------------------------------------------
-- Tabla: METODO_PAGO (catálogo)
-- CORRECCIÓN: antes era VARCHAR(20) dentro de VENTA
-- (metodo_pago_venta). Se separa en tabla propia según
-- lo solicitado en el informe de revisión.
-- -----------------------------------------------------
CREATE TABLE tbl_metodo_pago (
    id_metodo_pago      INT AUTO_INCREMENT PRIMARY KEY,
    nombre_metodo_pago  VARCHAR(30) NOT NULL UNIQUE  -- 'efectivo', 'tarjeta', 'transferencia'
) ENGINE=InnoDB;

INSERT INTO tbl_metodo_pago (nombre_metodo_pago) VALUES
('efectivo'), ('tarjeta'), ('transferencia');

-- -----------------------------------------------------
-- Tabla: VENTA
-- id_usuario identifica qué taquillero/admin realizó la venta.
-- CORRECCIÓN: se agrega cantidad_boletos_venta, ya que en una
-- venta se pueden comprar varios boletos.
-- -----------------------------------------------------
CREATE TABLE tbl_venta (
    id_venta               INT AUTO_INCREMENT PRIMARY KEY,
    id_cliente              INT,
    id_promocion             INT,
    id_usuario               INT,
    id_metodo_pago            INT,                     -- FK -> METODO_PAGO (antes VARCHAR)
    fecha_hora_venta         DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    cantidad_boletos_venta    INT NOT NULL DEFAULT 1,   -- cantidad de boletos comprados en la venta
    total_venta               DECIMAL(8,2) NOT NULL,
    CONSTRAINT chk_cantidad_boletos_venta
        CHECK (cantidad_boletos_venta >= 1),
    -- Cardinalidad: 1 CLIENTE : N VENTA. SET NULL: si se borra el
    -- cliente, la venta queda sin cliente asociado (se conserva histórico).
    CONSTRAINT fk_venta_cliente
        FOREIGN KEY (id_cliente) REFERENCES tbl_cliente(id_cliente)
        ON UPDATE CASCADE ON DELETE SET NULL,
    -- Cardinalidad: 1 PROMOCION : N VENTA. SET NULL: si se borra la
    -- promoción, la venta conserva su registro sin promoción asociada.
    CONSTRAINT fk_venta_promocion
        FOREIGN KEY (id_promocion) REFERENCES tbl_promocion(id_promocion)
        ON UPDATE CASCADE ON DELETE SET NULL,
    -- Cardinalidad: 1 USUARIO : N VENTA. SET NULL: si se borra el
    -- usuario, la venta conserva su registro sin usuario asociado.
    CONSTRAINT fk_venta_usuario
        FOREIGN KEY (id_usuario) REFERENCES tbl_usuario(id_usuario)
        ON UPDATE CASCADE ON DELETE SET NULL,
    -- Cardinalidad: 1 METODO_PAGO : N VENTA. RESTRICT: no se borra un
    -- método de pago si existen ventas registradas con él.
    CONSTRAINT fk_venta_metodopago
        FOREIGN KEY (id_metodo_pago) REFERENCES tbl_metodo_pago(id_metodo_pago)
        ON UPDATE CASCADE ON DELETE RESTRICT
) ENGINE=InnoDB;

-- -----------------------------------------------------
-- Tabla: BOLETO
-- La butaca vive como numero_boleto (cada fila tiene siempre
-- 10 butacas, así que con el número solo ya se identifica).
-- La unicidad por (id_funcion, numero_boleto) es lo que impide
-- vender dos veces la misma butaca en la misma función.
-- -----------------------------------------------------
CREATE TABLE tbl_boleto (
    id_boleto        INT AUTO_INCREMENT PRIMARY KEY,
    id_funcion       INT NOT NULL,
    numero_boleto    INT NOT NULL,
    id_venta         INT NOT NULL,
    estado_boleto    VARCHAR(15) NOT NULL DEFAULT 'vendido',  -- vendido / cancelado
    -- Cardinalidad: 1 FUNCION : N BOLETO. RESTRICT: no se puede
    -- borrar una función con boletos vendidos.
    CONSTRAINT fk_boleto_funcion
        FOREIGN KEY (id_funcion) REFERENCES tbl_funcion(id_funcion)
        ON UPDATE CASCADE ON DELETE RESTRICT,
    -- Cardinalidad: 1 VENTA : N BOLETO. RESTRICT: no se puede borrar
    -- una venta que tiene boletos asociados.
    CONSTRAINT fk_boleto_venta
        FOREIGN KEY (id_venta) REFERENCES tbl_venta(id_venta)
        ON UPDATE CASCADE ON DELETE RESTRICT,
    CONSTRAINT uq_boleto_funcion_asiento UNIQUE (id_funcion, numero_boleto)
) ENGINE=InnoDB;

CREATE INDEX idx_boleto_funcion ON BOLETO(id_funcion);

-- =====================================================
-- VISTA: boletos vendidos por función
-- Para saber qué butacas están libres, el backend debe
-- generar el rango (1 a capacidad_sala) y restarle lo que
-- ya aparece aquí.
-- =====================================================
CREATE VIEW vw_boletos_vendidos AS
SELECT
    b.id_funcion,
    b.numero_boleto,
    b.estado_boleto
FROM tbl_boleto b
WHERE b.estado_boleto <> 'cancelado';

-- Ejemplo de uso: ver qué butacas ya están vendidas en la función 5
-- SELECT * FROM vw_boletos_vendidos WHERE id_funcion = 5;

-- =====================================================
-- Ejemplo de uso para prueba
-- =====================================================

-- Cambiar la capacidad de una sala (dinámico):
-- UPDATE tbl_sala SET capacidad_sala = 25 WHERE id_sala = 1;

-- Vender boletos (ejemplo: venta de 2 boletos en una sola compra):
-- INSERT INTO tbl_venta (id_cliente, id_metodo_pago, cantidad_boletos_venta, total_venta, id_usuario)
-- VALUES (1, 2, 2, 90.00, 1);

-- INSERT INTO tbl_boleto (id_funcion, numero_boleto, id_venta) VALUES (5, 23, LAST_INSERT_ID());
-- INSERT INTO tbl_boleto (id_funcion, numero_boleto, id_venta) VALUES (5, 24, LAST_INSERT_ID());
-- Si alguien intenta vender otra vez el número 23 en la misma
-- función 5, la restricción uq_boleto_funcion_asiento lo rechaza.

-- Inserción de usuario (contraseña encriptada con SHA2,
-- nunca en texto plano). id_perfil = 1 es 'admin', 2 es 'taquillero':

-- INSERT INTO tbl_usuario (id_perfil, nombre_usuario, contrasena_usuario)
-- VALUES (1, 'admin1', SHA2('123', 256));

-- usuario Mishel con perfil admin, contraseña "123"

INSERT INTO tbl_usuario (id_perfil, nombre_usuario, contrasena_usuario)
VALUES (1, 'mishel', SHA2('123', 256));

-- Verificación, mostrando el nombre del perfil:
-- SELECT u.id_usuario, u.nombre_usuario, p.nombre_perfil
-- FROM tbl_usuario u JOIN tbl_perfil p ON p.id_perfil = u.id_perfil
-- WHERE u.nombre_usuario = 'mishel';

-- Ejemplo de verificación de login (usar SIEMPRE con parámetros
-- preparados desde el backend, nunca concatenando el input):
-- SELECT id_usuario, nombre_usuario FROM USUARIO
-- WHERE nombre_usuario = ? AND contrasena_usuario = SHA2(?, 256);

---------------------------------------------------------------------------
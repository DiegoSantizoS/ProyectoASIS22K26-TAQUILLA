-- =====================================================================
-- CORRECCIÓN — taquillas_cine_6
-- =====================================================================


USE taquillas_cine;

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

ALTER TABLE tbl_bitacora
    CHANGE COLUMN fecha fecha_bitacora DATE NOT NULL DEFAULT (CURRENT_DATE),
    CHANGE COLUMN ip ip_bitacora VARCHAR(45);

ALTER TABLE tbl_bitacora
    ADD COLUMN hora_bitacora TIME NOT NULL DEFAULT (CURRENT_TIME) AFTER fecha_bitacora;
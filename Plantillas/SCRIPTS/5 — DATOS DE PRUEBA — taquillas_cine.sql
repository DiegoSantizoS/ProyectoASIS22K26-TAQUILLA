-- =====================================================================
-- 5 — DATOS DE PRUEBA — taquillas_cine
-- =====================================================================

USE taquillas_cine;

-- =====================================================================
-- CIUDADES
-- =====================================================================
INSERT INTO tbl_ciudad (nombre_ciudad) VALUES
('Guatemala'),
('Antigua Guatemala'),
('Zacapa');

-- =====================================================================
-- CINES
-- =====================================================================
INSERT INTO tbl_cine (id_ciudad, nombre_cine)
SELECT c.id_ciudad, v.nombre
FROM (
    SELECT 'Guatemala'         AS ciudad, 'Cinema Miraflores'    AS nombre
    UNION ALL SELECT 'Guatemala',         'Cinema Oakland Mall'
    UNION ALL SELECT 'Guatemala',         'Cinema Portales'
    UNION ALL SELECT 'Antigua Guatemala', 'Cinema Antigua Plaza'
    UNION ALL SELECT 'Zacapa',            'Cinema Zacapa Centro'
) v
JOIN tbl_ciudad c ON c.nombre_ciudad = v.ciudad;

-- =====================================================================
-- SALAS
-- La capacidad debe ser multiplo de 10, porque el formulario de butacas
-- distribuye los asientos en filas de diez columnas.
-- =====================================================================
INSERT INTO tbl_sala (id_tipo_sala, id_cine, numero_sala, capacidad_sala)
SELECT ts.id_tipo_sala, ci.id_cine, v.numero, v.capacidad
FROM (
    SELECT 'Cinema Miraflores'    AS cine, 1 AS numero, 60 AS capacidad, '2D/3D' AS tipo
    UNION ALL SELECT 'Cinema Miraflores',    2, 80,  'IMAX'
    UNION ALL SELECT 'Cinema Oakland Mall',  1, 60,  '2D/3D'
    UNION ALL SELECT 'Cinema Oakland Mall',  2, 50,  '4D'
    UNION ALL SELECT 'Cinema Portales',      1, 70,  '2D/3D'
    UNION ALL SELECT 'Cinema Portales',      2, 100, 'IMAX'
    UNION ALL SELECT 'Cinema Antigua Plaza', 1, 50,  '2D/3D'
    UNION ALL SELECT 'Cinema Antigua Plaza', 2, 40,  '4D'
    UNION ALL SELECT 'Cinema Zacapa Centro', 1, 60,  '2D/3D'
    UNION ALL SELECT 'Cinema Zacapa Centro', 2, 40,  '2D/3D'
) v
JOIN tbl_cine     ci ON ci.nombre_cine     = v.cine
JOIN tbl_tipo_sala ts ON ts.nombre_tipo_sala = v.tipo;

-- =====================================================================
-- PELICULAS
-- Los enlaces de trailer son marcadores de prueba. Deben sustituirse por
-- las direcciones reales antes de la entrega final.
-- =====================================================================
INSERT INTO tbl_pelicula
    (id_clasificacion, id_estado_pelicula, titulo_pelicula, duracion_pelicula,
     director_pelicula, descripcion_pelicula, trailer_pelicula, fecha_estreno)
SELECT cl.id_clasificacion, ep.id_estado_pelicula, v.titulo, v.duracion,
       v.director, v.descripcion, v.trailer, v.estreno
FROM (
    SELECT 'Dune: Parte Dos' AS titulo, 166 AS duracion, 'B' AS clasif, 'en_cartelera' AS estado,
           'Denis Villeneuve' AS director,
           'Paul Atreides se une a los Fremen para vengar a su familia y evitar un futuro terrible.' AS descripcion,
           'https://www.youtube.com/results?search_query=Dune+Parte+Dos+trailer' AS trailer,
           DATE_SUB(CURDATE(), INTERVAL 20 DAY) AS estreno

    UNION ALL SELECT 'Intensa-Mente 2', 96, 'A', 'en_cartelera',
           'Kelsey Mann',
           'Riley entra en la adolescencia y nuevas emociones llegan al centro de control.',
           'https://www.youtube.com/results?search_query=Intensamente+2+trailer',
           DATE_SUB(CURDATE(), INTERVAL 12 DAY)

    UNION ALL SELECT 'Deadpool y Lobezno', 128, 'C', 'en_cartelera',
           'Shawn Levy',
           'Wade Wilson recluta a un reticente Lobezno para una mision que altera el multiverso.',
           'https://www.youtube.com/results?search_query=Deadpool+y+Lobezno+trailer',
           DATE_SUB(CURDATE(), INTERVAL 8 DAY)

    UNION ALL SELECT 'Godzilla y Kong: El Nuevo Imperio', 115, 'B', 'en_cartelera',
           'Adam Wingard',
           'Los dos titanes enfrentan una amenaza colosal oculta en el interior del planeta.',
           'https://www.youtube.com/results?search_query=Godzilla+y+Kong+El+Nuevo+Imperio+trailer',
           DATE_SUB(CURDATE(), INTERVAL 15 DAY)

    UNION ALL SELECT 'Kung Fu Panda 4', 94, 'A', 'en_cartelera',
           'Mike Mitchell',
           'Po debe encontrar y entrenar al proximo Guerrero Dragon antes de asumir un nuevo rol.',
           'https://www.youtube.com/results?search_query=Kung+Fu+Panda+4+trailer',
           DATE_SUB(CURDATE(), INTERVAL 25 DAY)

    UNION ALL SELECT 'Un Lugar en Silencio: Dia Uno', 99, 'B15', 'en_cartelera',
           'Michael Sarnoski',
           'La invasion silenciosa comienza en Nueva York y la ciudad debe aprender a callar.',
           'https://www.youtube.com/results?search_query=Un+Lugar+en+Silencio+Dia+Uno+trailer',
           DATE_SUB(CURDATE(), INTERVAL 5 DAY)

    UNION ALL SELECT 'Mi Villano Favorito 4', 95, 'A', 'en_cartelera',
           'Chris Renaud',
           'Gru enfrenta a un nuevo villano mientras se adapta a la llegada de Gru Junior.',
           'https://www.youtube.com/results?search_query=Mi+Villano+Favorito+4+trailer',
           DATE_SUB(CURDATE(), INTERVAL 3 DAY)

    UNION ALL SELECT 'Twisters', 122, 'B', 'en_cartelera',
           'Lee Isaac Chung',
           'Un grupo de cazadores de tormentas pone a prueba una tecnologia experimental.',
           'https://www.youtube.com/results?search_query=Twisters+trailer',
           DATE_SUB(CURDATE(), INTERVAL 2 DAY)

    UNION ALL SELECT 'Mufasa: El Rey Leon', 118, 'A', 'proximamente',
           'Barry Jenkins',
           'La historia del origen de Mufasa y su ascenso como rey de las tierras del reino.',
           'https://www.youtube.com/results?search_query=Mufasa+El+Rey+Leon+trailer',
           DATE_ADD(CURDATE(), INTERVAL 20 DAY)

    UNION ALL SELECT 'Sonic 3: La Pelicula', 110, 'A', 'proximamente',
           'Jeff Fowler',
           'Sonic y sus amigos enfrentan a un adversario inesperado de gran poder.',
           'https://www.youtube.com/results?search_query=Sonic+3+trailer',
           DATE_ADD(CURDATE(), INTERVAL 35 DAY)
) v
JOIN tbl_clasificacion   cl ON cl.nombre_clasificacion   = v.clasif
JOIN tbl_estado_pelicula ep ON ep.nombre_estado_pelicula = v.estado;

-- =====================================================================
-- GENEROS POR PELICULA (relacion N:M)
-- =====================================================================
INSERT INTO tbl_pelicula_genero (id_pelicula, id_genero)
SELECT p.id_pelicula, g.id_genero
FROM (
    SELECT 'Dune: Parte Dos' AS titulo, 'Ciencia Ficción' AS genero
    UNION ALL SELECT 'Dune: Parte Dos',                    'Aventura'
    UNION ALL SELECT 'Intensa-Mente 2',                    'Animación'
    UNION ALL SELECT 'Intensa-Mente 2',                    'Comedia'
    UNION ALL SELECT 'Deadpool y Lobezno',                 'Acción'
    UNION ALL SELECT 'Deadpool y Lobezno',                 'Comedia'
    UNION ALL SELECT 'Godzilla y Kong: El Nuevo Imperio',  'Acción'
    UNION ALL SELECT 'Godzilla y Kong: El Nuevo Imperio',  'Ciencia Ficción'
    UNION ALL SELECT 'Kung Fu Panda 4',                    'Animación'
    UNION ALL SELECT 'Kung Fu Panda 4',                    'Aventura'
    UNION ALL SELECT 'Un Lugar en Silencio: Dia Uno',      'Terror'
    UNION ALL SELECT 'Un Lugar en Silencio: Dia Uno',      'Suspenso'
    UNION ALL SELECT 'Mi Villano Favorito 4',              'Animación'
    UNION ALL SELECT 'Mi Villano Favorito 4',              'Comedia'
    UNION ALL SELECT 'Twisters',                           'Acción'
    UNION ALL SELECT 'Twisters',                           'Drama'
    UNION ALL SELECT 'Mufasa: El Rey Leon',                'Animación'
    UNION ALL SELECT 'Sonic 3: La Pelicula',               'Animación'
) v
JOIN tbl_pelicula p ON p.titulo_pelicula = v.titulo
JOIN tbl_genero   g ON g.nombre_genero   = v.genero;

-- =====================================================================
-- FORMATOS POR PELICULA (relacion N:M)
-- Cubre el filtrado por formato (2D/3D) e idioma (subtitulado/doblado)
-- que exige el documento de requerimientos.
-- =====================================================================
INSERT INTO tbl_pelicula_formatopelicula (id_pelicula, id_formato_pelicula)
SELECT p.id_pelicula, fp.id_formato_pelicula
FROM (
    SELECT 'Dune: Parte Dos' AS titulo, '2D SUB' AS formato
    UNION ALL SELECT 'Dune: Parte Dos',                   'IMAX SUB'
    UNION ALL SELECT 'Intensa-Mente 2',                   '2D DOB'
    UNION ALL SELECT 'Intensa-Mente 2',                   '3D DOB'
    UNION ALL SELECT 'Deadpool y Lobezno',                '2D SUB'
    UNION ALL SELECT 'Deadpool y Lobezno',                '2D DOB'
    UNION ALL SELECT 'Godzilla y Kong: El Nuevo Imperio', '3D SUB'
    UNION ALL SELECT 'Godzilla y Kong: El Nuevo Imperio', '4D DOB'
    UNION ALL SELECT 'Kung Fu Panda 4',                   '2D DOB'
    UNION ALL SELECT 'Kung Fu Panda 4',                   '3D DOB'
    UNION ALL SELECT 'Un Lugar en Silencio: Dia Uno',     '2D SUB'
    UNION ALL SELECT 'Mi Villano Favorito 4',             '2D DOB'
    UNION ALL SELECT 'Mi Villano Favorito 4',             '4D DOB'
    UNION ALL SELECT 'Twisters',                          '2D SUB'
    UNION ALL SELECT 'Twisters',                          'IMAX SUB'
    UNION ALL SELECT 'Mufasa: El Rey Leon',               '2D DOB'
    UNION ALL SELECT 'Sonic 3: La Pelicula',              '2D DOB'
) v
JOIN tbl_pelicula          p  ON p.titulo_pelicula          = v.titulo
JOIN tbl_formato_pelicula  fp ON fp.nombre_formato_pelicula = v.formato;

-- =====================================================================
-- FUNCIONES
-- Se generan para los proximos siete dias, en tres horarios diarios.
-- Cada pelicula se programa en las salas de paridad coincidente, para
-- que no todas las peliculas aparezcan en todas las salas.
-- El precio depende del tipo de sala.
-- =====================================================================
INSERT INTO tbl_funcion (id_pelicula, id_sala, fecha_funcion, hora_funcion, precio_funcion)
SELECT
    p.id_pelicula,
    s.id_sala,
    DATE_ADD(CURDATE(), INTERVAL d.n DAY),
    h.hora,
    CASE ts.nombre_tipo_sala
        WHEN 'IMAX'  THEN 85.00
        WHEN '4D'    THEN 75.00
        ELSE               55.00
    END
FROM tbl_pelicula p
JOIN tbl_estado_pelicula ep
      ON ep.id_estado_pelicula = p.id_estado_pelicula
     AND ep.nombre_estado_pelicula = 'en_cartelera'
JOIN tbl_sala      s  ON MOD(p.id_pelicula + s.id_sala, 2) = 0
JOIN tbl_tipo_sala ts ON ts.id_tipo_sala = s.id_tipo_sala
CROSS JOIN (
    SELECT 0 AS n UNION ALL SELECT 1 UNION ALL SELECT 2 UNION ALL SELECT 3
    UNION ALL SELECT 4 UNION ALL SELECT 5 UNION ALL SELECT 6
) d
CROSS JOIN (
    SELECT '14:00:00' AS hora
    UNION ALL SELECT '17:30:00'
    UNION ALL SELECT '20:45:00'
) h;

-- =====================================================================
-- VENTA DE PRUEBA
-- Genera butacas ya ocupadas en la primera funcion, para verificar que
-- el selector las muestre bloqueadas y que el control de concurrencia
-- rechace un intento de compra sobre las mismas.
-- =====================================================================
INSERT INTO tbl_cliente (nombre_cliente, apellido_cliente, identificacion_cliente, correo_cliente)
VALUES ('Cliente', 'De Prueba', '1234567890101', 'cliente.prueba@correo.com');

INSERT INTO tbl_venta
    (id_cliente, id_promocion, id_usuario, id_metodo_pago,
     fecha_hora_venta, cantidad_boletos_venta, total_venta)
SELECT
    (SELECT id_cliente FROM tbl_cliente WHERE correo_cliente = 'cliente.prueba@correo.com'),
    NULL,
    NULL,
    (SELECT id_metodo_pago FROM tbl_metodo_pago WHERE nombre_metodo_pago = 'tarjeta'),
    NOW(),
    4,
    220.00;

INSERT INTO tbl_boleto (id_funcion, id_venta, id_estado_boleto, numero_boleto)
SELECT
    (SELECT MIN(id_funcion) FROM tbl_funcion),
    (SELECT MAX(id_venta)   FROM tbl_venta),
    (SELECT id_estado_boleto FROM tbl_estado_boleto WHERE nombre_estado_boleto = 'vendido'),
    v.numero
FROM (
    SELECT 1 AS numero
    UNION ALL SELECT 2
    UNION ALL SELECT 11
    UNION ALL SELECT 12
) v;

-- =====================================================================
-- VERIFICACION
-- La columna "esperado" indica el valor correcto. Si algun conteo sale
-- en cero, lo mas probable es que el archivo se haya guardado con una
-- codificacion distinta de UTF-8 y las uniones por nombre con tilde
-- (Accion, Animacion, Ciencia Ficcion) no hayan encontrado coincidencia.
-- =====================================================================
SELECT 'Ciudades'            AS tabla, COUNT(*) AS registros, 3   AS esperado FROM tbl_ciudad
UNION ALL SELECT 'Cines',              COUNT(*), 5   FROM tbl_cine
UNION ALL SELECT 'Salas',              COUNT(*), 10  FROM tbl_sala
UNION ALL SELECT 'Peliculas',          COUNT(*), 10  FROM tbl_pelicula
UNION ALL SELECT 'Generos x pelicula', COUNT(*), 18  FROM tbl_pelicula_genero
UNION ALL SELECT 'Formatos x pelicula',COUNT(*), 17  FROM tbl_pelicula_formatopelicula
UNION ALL SELECT 'Funciones',          COUNT(*), 840 FROM tbl_funcion
UNION ALL SELECT 'Boletos vendidos',   COUNT(*), 4   FROM tbl_boleto
UNION ALL SELECT 'Usuarios',           COUNT(*), 1   FROM tbl_usuario;

-- Funciones disponibles del dia de hoy:
-- SELECT f.id_funcion, p.titulo_pelicula, c.nombre_cine, s.numero_sala,
--        f.fecha_funcion, f.hora_funcion, f.precio_funcion
-- FROM tbl_funcion f
-- JOIN tbl_pelicula p ON p.id_pelicula = f.id_pelicula
-- JOIN tbl_sala     s ON s.id_sala     = f.id_sala
-- JOIN tbl_cine     c ON c.id_cine     = s.id_cine
-- WHERE f.fecha_funcion = CURDATE()
-- ORDER BY c.nombre_cine, f.hora_funcion;
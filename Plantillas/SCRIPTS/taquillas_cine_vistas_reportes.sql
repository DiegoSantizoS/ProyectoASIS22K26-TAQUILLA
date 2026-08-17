-- =====================================================================
-- VISTAS DE REPORTES DE TAQUILLA
-- =====================================================================

USE taquillas_cine;

-- =====================================================================
-- Recaudación por boleto válido (no cancelado)
-- =====================================================================
CREATE OR REPLACE VIEW vw_recaudacion_boleto AS
SELECT
    b.id_boleto,
    f.id_pelicula,
    p.titulo_pelicula,
    f.fecha_funcion,
    f.precio_funcion
FROM tbl_boleto b
JOIN tbl_estado_boleto eb ON eb.id_estado_boleto = b.id_estado_boleto
JOIN tbl_funcion f        ON f.id_funcion       = b.id_funcion
JOIN tbl_pelicula p       ON p.id_pelicula      = f.id_pelicula
WHERE eb.nombre_estado_boleto <> 'cancelado';

-- =====================================================================
-- PELÍCULAS MÁS TAQUILLERAS POR SEMANA
-- =====================================================================
CREATE OR REPLACE VIEW vw_peliculas_taquilleras_semana AS
SELECT
    YEARWEEK(fecha_funcion, 3)                                        AS anio_semana,
    MIN(DATE_SUB(fecha_funcion, INTERVAL WEEKDAY(fecha_funcion) DAY)) AS inicio_semana, 
    id_pelicula,
    titulo_pelicula,
    COUNT(*)                                                          AS boletos_vendidos,
    SUM(precio_funcion)                                               AS recaudacion,
    RANK() OVER (
        PARTITION BY YEARWEEK(fecha_funcion, 3)
        ORDER BY SUM(precio_funcion) DESC
    )                                                                 AS posicion
FROM vw_recaudacion_boleto
GROUP BY anio_semana, id_pelicula, titulo_pelicula
ORDER BY anio_semana, posicion;

-- =====================================================================
-- PELÍCULAS MÁS TAQUILLERAS POR MES
-- =====================================================================
CREATE OR REPLACE VIEW vw_peliculas_taquilleras_mes AS
SELECT
    DATE_FORMAT(fecha_funcion, '%Y-%m') AS anio_mes,   -- p.ej. 2025-07
    YEAR(fecha_funcion)                 AS anio,
    MONTH(fecha_funcion)                AS mes,
    id_pelicula,
    titulo_pelicula,
    COUNT(*)                            AS boletos_vendidos,
    SUM(precio_funcion)                 AS recaudacion,
    RANK() OVER (
        PARTITION BY DATE_FORMAT(fecha_funcion, '%Y-%m')
        ORDER BY SUM(precio_funcion) DESC
    )                                   AS posicion
FROM vw_recaudacion_boleto
GROUP BY anio_mes, anio, mes, id_pelicula, titulo_pelicula
ORDER BY anio_mes, posicion;

-- =====================================================================
-- 2a. GANANCIAS POR SEMANA (total de taquilla de todas las películas)
-- =====================================================================
CREATE OR REPLACE VIEW vw_ganancias_semana AS
SELECT
    YEARWEEK(fecha_funcion, 3)                                        AS anio_semana,
    MIN(DATE_SUB(fecha_funcion, INTERVAL WEEKDAY(fecha_funcion) DAY)) AS inicio_semana,
    COUNT(*)                                                          AS boletos_vendidos,
    COUNT(DISTINCT id_pelicula)                                       AS peliculas_distintas,
    SUM(precio_funcion)                                               AS ganancia_total
FROM vw_recaudacion_boleto
GROUP BY anio_semana
ORDER BY anio_semana;

-- =====================================================================
-- 2b. GANANCIAS POR MES (total de taquilla de todas las películas)
-- =====================================================================
CREATE OR REPLACE VIEW vw_ganancias_mes AS
SELECT
    DATE_FORMAT(fecha_funcion, '%Y-%m') AS anio_mes,
    YEAR(fecha_funcion)                 AS anio,
    MONTH(fecha_funcion)                AS mes,
    COUNT(*)                            AS boletos_vendidos,
    COUNT(DISTINCT id_pelicula)         AS peliculas_distintas,
    SUM(precio_funcion)                 AS ganancia_total
FROM vw_recaudacion_boleto
GROUP BY anio_mes, anio, mes
ORDER BY anio_mes;
DELIMITER $$
DROP PROCEDURE IF EXISTS sp_cartelera;

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

DELIMITER $$
DROP PROCEDURE IF EXISTS sp_filtrar_cartelera;

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
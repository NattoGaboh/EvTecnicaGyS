--Created on MySQL
DELIMITER //
CREATE PROCEDURE `sp_InsertClient`(
IN v_cod varchar(10),
IN v_nomcomp varchar(200),
IN v_nomcort varchar(40),
IN v_abrev varchar(40),
IN v_ruc varchar(11),
IN v_estado char(1),
IN v_grupofact varchar(100),
IN v_inactivo datetime,
IN v_codSap varchar(20),
OUT message varchar(20))
BEGIN
	IF NOT EXISTS(SELECT 1 FROM adm.client WHERE CodCliente=v_cod) THEN
		INSERT INTO adm.client (CodCliente, NombreCompleto, NombreCorto, Abreviatura, Ruc, Estado, GrupoFacturacion, InactivoDesde, CodigoSAP) 
				VALUES (v_cod, v_nomcomp, v_nomcort, v_abrev, v_ruc, v_estado, v_grupofact, v_inactivo, v_codSap);
		SET message = "Registro Guardado.";
    ELSE
		SET message = "Registro existente";
    END IF;
	SELECT message;
END //


DELIMITER //
CREATE PROCEDURE `sp_UpdateClient`(
IN v_cod varchar(10),
IN v_nomcomp varchar(200),
IN v_nomcort varchar(40),
IN v_abrev varchar(40),
IN v_ruc varchar(11),
IN v_estado char(1),
IN v_grupofact varchar(100),
IN v_inactivo datetime,
IN v_codSap varchar(20),
OUT message varchar(20))
BEGIN
	IF NOT EXISTS(SELECT 1 FROM adm.client WHERE CodCliente=v_cod) THEN
		SET message = "Registro no existe.";
    ELSE
		UPDATE adm.client SET NombreCompleto=v_nomcomp,
							NombreCorto=v_nomcort,
							Abreviatura=v_abrev,
							Ruc=v_ruc,
							Estado=v_estado,
							GrupoFacturacion=v_grupofact,
							InactivoDesde=v_inactivo,
							CodigoSAP=v_codsap 
						WHERE CodCliente = v_cod;
		SET message = "Registro Guardado.";
	END IF;
	SELECT message;
END //



DELIMITER //
CREATE PROCEDURE `sp_ListClientByCod`(
IN v_cod varchar(10))
BEGIN
	SELECT * FROM adm.client WHERE CodCliente=v_cod;
END //



DELIMITER //
CREATE PROCEDURE `sp_DeleteClient`(
IN v_cod varchar(10),
OUT message varchar(20))
BEGIN
	IF NOT EXISTS(SELECT 1 FROM adm.client WHERE CodCliente=v_cod) THEN
		SET message = "Registro no existe";
    ELSE
		UPDATE adm.client SET Estado="0" WHERE CodCliente=v_cod;
		SET message = "Registro Eliminado";
    END IF;
SELECT message;
END //
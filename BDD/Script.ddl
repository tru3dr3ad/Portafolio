-- Generado por Oracle SQL Developer Data Modeler 19.2.0.182.1216
--   en:        2020-06-22 03:19:50 CLT
--   sitio:      Oracle Database 12c
--   tipo:      Oracle Database 12c

DROP SEQUENCE seq_rubro;
DROP SEQUENCE seq_tipo_cliente;
DROP SEQUENCE seq_orden_pedido;
DROP SEQUENCE seq_id_proveedor;
DROP SEQUENCE seq_estado_orden;
DROP SEQUENCE seq_estado_fiado;
DROP SEQUENCE seq_detalle_orden;
DROP SEQUENCE seq_detalle_boleta;
DROP SEQUENCE seq_boleta;
DROP SEQUENCE seq_abono;
DROP SEQUENCE seq_categoria;


DROP TABLE abono CASCADE CONSTRAINTS;

DROP TABLE boleta CASCADE CONSTRAINTS;

DROP TABLE categoria CASCADE CONSTRAINTS;

DROP TABLE cliente CASCADE CONSTRAINTS;

DROP TABLE detalle_boleta CASCADE CONSTRAINTS;

DROP TABLE detalle_pedido CASCADE CONSTRAINTS;

DROP TABLE estado_boleta CASCADE CONSTRAINTS;

DROP TABLE estado_fiado CASCADE CONSTRAINTS;

DROP TABLE estado_orden CASCADE CONSTRAINTS;

DROP TABLE medio_pago CASCADE CONSTRAINTS;

DROP TABLE orden_pedido CASCADE CONSTRAINTS;

DROP TABLE producto CASCADE CONSTRAINTS;

DROP TABLE proveedor CASCADE CONSTRAINTS;

DROP TABLE tipo_cliente CASCADE CONSTRAINTS;

DROP TABLE tipo_rubro CASCADE CONSTRAINTS;

DROP TABLE tipo_usuario CASCADE CONSTRAINTS;

DROP TABLE usuario CASCADE CONSTRAINTS;

CREATE TABLE abono (
    idabono               INTEGER NOT NULL,
    boleta_numeroboleta   INTEGER NOT NULL,
    total                 FLOAT NOT NULL,
    fechaabono            DATE NOT NULL,
    fechalimite           DATE NOT NULL
);

ALTER TABLE abono ADD CONSTRAINT abono_pk PRIMARY KEY ( idabono );

CREATE TABLE boleta (
    numeroboleta             INTEGER NOT NULL,
    fechacreacion            DATE NOT NULL,
    total                    FLOAT NOT NULL,
    medio_pago_idmedio       INTEGER NOT NULL,
    cliente_runcliente       INTEGER NOT NULL,
    usuario_runusuario       INTEGER NOT NULL,
    estado_boleta_idestado   INTEGER NOT NULL
);

ALTER TABLE boleta ADD CONSTRAINT boleta_pk PRIMARY KEY ( numeroboleta );

CREATE TABLE categoria (
    idcategoria   INTEGER NOT NULL,
    descripcion   VARCHAR2(70 CHAR) NOT NULL
);

ALTER TABLE categoria ADD CONSTRAINT categoria_pk PRIMARY KEY ( idcategoria );

CREATE TABLE cliente (
    runcliente              INTEGER NOT NULL,
    dv                      CHAR(1 CHAR) NOT NULL,
    nombre                  VARCHAR2(70 CHAR) NOT NULL,
    apellido                VARCHAR2(70 CHAR) NOT NULL,
    fechanacimiento         DATE NOT NULL,
    direccion               VARCHAR2(150 CHAR) NOT NULL,
    telefono                NUMBER(9) NOT NULL,
    estado_fiado_idestado   INTEGER NOT NULL,
    tipo_cliente_idtipo     INTEGER NOT NULL
);

ALTER TABLE cliente ADD CONSTRAINT cliente_pk PRIMARY KEY ( runcliente );

CREATE TABLE detalle_boleta (
    iddetalleb            INTEGER NOT NULL,
    producto_codigo       VARCHAR2(17 CHAR) NOT NULL,
    boleta_numeroboleta   INTEGER NOT NULL,
    cantidad              INTEGER NOT NULL
);

ALTER TABLE detalle_boleta
    ADD CONSTRAINT detalle_boleta_pk PRIMARY KEY ( producto_codigo,
                                                   boleta_numeroboleta,
                                                   iddetalleb );

CREATE TABLE detalle_pedido (
    iddetalleo                 INTEGER NOT NULL,
    orden_pedido_numeroorden   INTEGER NOT NULL,
    producto_codigo            VARCHAR2(17 CHAR) NOT NULL,
    cantidad                   INTEGER NOT NULL
);

ALTER TABLE detalle_pedido
    ADD CONSTRAINT detalle_pedido_pk PRIMARY KEY ( orden_pedido_numeroorden,
                                                   producto_codigo,
                                                   iddetalleo );

CREATE TABLE estado_boleta (
    idestado      INTEGER NOT NULL,
    descripcion   VARCHAR2(70 CHAR) NOT NULL
);

ALTER TABLE estado_boleta ADD CONSTRAINT estado_boleta_pk PRIMARY KEY ( idestado );

CREATE TABLE estado_fiado (
    idestado      INTEGER NOT NULL,
    descripcion   VARCHAR2(50 CHAR) NOT NULL
);

ALTER TABLE estado_fiado ADD CONSTRAINT estado_fiado_pk PRIMARY KEY ( idestado );

CREATE TABLE estado_orden (
    idestado      INTEGER NOT NULL,
    descripcion   VARCHAR2(70 CHAR) NOT NULL
);

ALTER TABLE estado_orden ADD CONSTRAINT estado_orden_pk PRIMARY KEY ( idestado );

CREATE TABLE medio_pago (
    idmedio       INTEGER NOT NULL,
    descripcion   VARCHAR2(70 CHAR) NOT NULL
);

ALTER TABLE medio_pago ADD CONSTRAINT medio_pago_pk PRIMARY KEY ( idmedio );

CREATE TABLE orden_pedido (
    numeroorden             INTEGER NOT NULL,
    fechacreacion           DATE NOT NULL,
    total                   FLOAT NOT NULL,
    fecharecepcion          DATE NOT NULL,
    proveedor_rut           INTEGER NOT NULL,
    estado_orden_idestado   INTEGER NOT NULL,
    usuario_runusuario      INTEGER NOT NULL
);

ALTER TABLE orden_pedido ADD CONSTRAINT orden_pedido_pk PRIMARY KEY ( numeroorden );

CREATE TABLE producto (
    codigo                  VARCHAR2(17 CHAR) NOT NULL,
    nombre                  VARCHAR2(70 CHAR) NOT NULL,
    descripcion             VARCHAR2(250 CHAR) NOT NULL,
    precioventa             FLOAT NOT NULL,
    preciocompra            FLOAT NOT NULL,
    stock                   INTEGER NOT NULL,
    stockcritico            INTEGER NOT NULL,
    fechavencimiento        DATE NOT NULL,
    estado                  CHAR(1 CHAR) NOT NULL,
    categoria_idcategoria   INTEGER NOT NULL
);

ALTER TABLE producto ADD CONSTRAINT producto_pk PRIMARY KEY ( codigo );

CREATE TABLE proveedor (
    rut                  INTEGER NOT NULL,
    dv                   CHAR(1 CHAR) NOT NULL,
    id                   INTEGER NOT NULL,
    nombre               VARCHAR2(70 CHAR) NOT NULL,
    correo               VARCHAR2(250 CHAR) NOT NULL,
    telefono             NUMBER(9) NOT NULL,
    direccion            VARCHAR2(150 CHAR) NOT NULL,
    tipo_rubro_idrubro   INTEGER NOT NULL
);

ALTER TABLE proveedor ADD CONSTRAINT proveedor_pk PRIMARY KEY ( rut );

CREATE TABLE tipo_cliente (
    idtipo        INTEGER NOT NULL,
    descripcion   VARCHAR2(70 CHAR) NOT NULL
);

ALTER TABLE tipo_cliente ADD CONSTRAINT tipo_cliente_pk PRIMARY KEY ( idtipo );

CREATE TABLE tipo_rubro (
    idrubro       INTEGER NOT NULL,
    descripcion   VARCHAR2(70 CHAR) NOT NULL
);

ALTER TABLE tipo_rubro ADD CONSTRAINT tipo_rubro_pk PRIMARY KEY ( idrubro );

CREATE TABLE tipo_usuario (
    idtipo        INTEGER NOT NULL,
    descripcion   VARCHAR2(70 CHAR) NOT NULL
);

ALTER TABLE tipo_usuario ADD CONSTRAINT tipo_usuario_pk PRIMARY KEY ( idtipo );

CREATE TABLE usuario (
    runusuario            INTEGER NOT NULL,
    dv                    CHAR(1 CHAR) NOT NULL,
    nombre                VARCHAR2(70 CHAR) NOT NULL,
    apellido              VARCHAR2(70 CHAR) NOT NULL,
    contrasena            VARCHAR2(70 CHAR) NOT NULL,
    fechanacimiento       DATE NOT NULL,
    fechacreacion         DATE NOT NULL,
    direccion             VARCHAR2(250 CHAR) NOT NULL,
    telefono              NUMBER NOT NULL,
    correo                VARCHAR2(250 CHAR) NOT NULL,
    tipo_usuario_idtipo   INTEGER NOT NULL
);

ALTER TABLE usuario ADD CONSTRAINT usuario_pk PRIMARY KEY ( runusuario );

ALTER TABLE abono
    ADD CONSTRAINT abono_boleta_fk FOREIGN KEY ( boleta_numeroboleta )
        REFERENCES boleta ( numeroboleta );

ALTER TABLE boleta
    ADD CONSTRAINT boleta_cliente_fk FOREIGN KEY ( cliente_runcliente )
        REFERENCES cliente ( runcliente );

ALTER TABLE boleta
    ADD CONSTRAINT boleta_estado_boleta_fk FOREIGN KEY ( estado_boleta_idestado )
        REFERENCES estado_boleta ( idestado );

ALTER TABLE boleta
    ADD CONSTRAINT boleta_medio_pago_fk FOREIGN KEY ( medio_pago_idmedio )
        REFERENCES medio_pago ( idmedio );

ALTER TABLE boleta
    ADD CONSTRAINT boleta_usuario_fk FOREIGN KEY ( usuario_runusuario )
        REFERENCES usuario ( runusuario );

ALTER TABLE cliente
    ADD CONSTRAINT cliente_estado_fiado_fk FOREIGN KEY ( estado_fiado_idestado )
        REFERENCES estado_fiado ( idestado );

ALTER TABLE cliente
    ADD CONSTRAINT cliente_tipo_cliente_fk FOREIGN KEY ( tipo_cliente_idtipo )
        REFERENCES tipo_cliente ( idtipo );

ALTER TABLE detalle_boleta
    ADD CONSTRAINT detalle_boleta_boleta_fk FOREIGN KEY ( boleta_numeroboleta )
        REFERENCES boleta ( numeroboleta );

ALTER TABLE detalle_boleta
    ADD CONSTRAINT detalle_boleta_producto_fk FOREIGN KEY ( producto_codigo )
        REFERENCES producto ( codigo );

ALTER TABLE detalle_pedido
    ADD CONSTRAINT detalle_pedido_orden_pedido_fk FOREIGN KEY ( orden_pedido_numeroorden )
        REFERENCES orden_pedido ( numeroorden );

ALTER TABLE detalle_pedido
    ADD CONSTRAINT detalle_pedido_producto_fk FOREIGN KEY ( producto_codigo )
        REFERENCES producto ( codigo );

ALTER TABLE orden_pedido
    ADD CONSTRAINT orden_pedido_estado_orden_fk FOREIGN KEY ( estado_orden_idestado )
        REFERENCES estado_orden ( idestado );

ALTER TABLE orden_pedido
    ADD CONSTRAINT orden_pedido_proveedor_fk FOREIGN KEY ( proveedor_rut )
        REFERENCES proveedor ( rut );

ALTER TABLE orden_pedido
    ADD CONSTRAINT orden_pedido_usuario_fk FOREIGN KEY ( usuario_runusuario )
        REFERENCES usuario ( runusuario );

ALTER TABLE producto
    ADD CONSTRAINT producto_categoria_fk FOREIGN KEY ( categoria_idcategoria )
        REFERENCES categoria ( idcategoria );

ALTER TABLE proveedor
    ADD CONSTRAINT proveedor_tipo_rubro_fk FOREIGN KEY ( tipo_rubro_idrubro )
        REFERENCES tipo_rubro ( idrubro );

ALTER TABLE usuario
    ADD CONSTRAINT usuario_tipo_usuario_fk FOREIGN KEY ( tipo_usuario_idtipo )
        REFERENCES tipo_usuario ( idtipo );

CREATE SEQUENCE seq_abono START WITH 1 MINVALUE 1 NOCACHE ORDER;

CREATE OR REPLACE TRIGGER abono_idabono_trg BEFORE
    INSERT ON abono
    FOR EACH ROW
    WHEN ( new.idabono IS NULL )
BEGIN
    :new.idabono := seq_abono.nextval;
END;
/

CREATE SEQUENCE seq_boleta START WITH 1 MINVALUE 1 NOCACHE ORDER;

CREATE OR REPLACE TRIGGER boleta_numeroboleta_trg BEFORE
    INSERT ON boleta
    FOR EACH ROW
    WHEN ( new.numeroboleta IS NULL )
BEGIN
    :new.numeroboleta := seq_boleta.nextval;
END;
/

CREATE SEQUENCE seq_categoria START WITH 1 MINVALUE 1 NOCACHE ORDER;

CREATE OR REPLACE TRIGGER categoria_idcategoria_trg BEFORE
    INSERT ON categoria
    FOR EACH ROW
    WHEN ( new.idcategoria IS NULL )
BEGIN
    :new.idcategoria := seq_categoria.nextval;
END;
/

CREATE SEQUENCE seq_detalle_boleta START WITH 1 MINVALUE 1 NOCACHE ORDER;

CREATE OR REPLACE TRIGGER detalle_boleta_iddetalleb_trg BEFORE
    INSERT ON detalle_boleta
    FOR EACH ROW
    WHEN ( new.iddetalleb IS NULL )
BEGIN
    :new.iddetalleb := seq_detalle_boleta.nextval;
END;
/

CREATE SEQUENCE seq_detalle_orden START WITH 1 MINVALUE 1 NOCACHE ORDER;

CREATE OR REPLACE TRIGGER detalle_pedido_iddetalleo_trg BEFORE
    INSERT ON detalle_pedido
    FOR EACH ROW
    WHEN ( new.iddetalleo IS NULL )
BEGIN
    :new.iddetalleo := seq_detalle_orden.nextval;
END;
/

CREATE SEQUENCE seq_estado_fiado START WITH 1 MINVALUE 1 NOCACHE ORDER;

CREATE OR REPLACE TRIGGER estado_fiado_idestado_trg BEFORE
    INSERT ON estado_fiado
    FOR EACH ROW
    WHEN ( new.idestado IS NULL )
BEGIN
    :new.idestado := seq_estado_fiado.nextval;
END;
/

CREATE SEQUENCE seq_estado_orden START WITH 1 MINVALUE 1 NOCACHE ORDER;

CREATE OR REPLACE TRIGGER estado_orden_idestado_trg BEFORE
    INSERT ON estado_orden
    FOR EACH ROW
    WHEN ( new.idestado IS NULL )
BEGIN
    :new.idestado := seq_estado_orden.nextval;
END;
/

CREATE SEQUENCE seq_orden_pedido START WITH 1 MINVALUE 1 NOCACHE ORDER;

CREATE OR REPLACE TRIGGER orden_pedido_numeroorden_trg BEFORE
    INSERT ON orden_pedido
    FOR EACH ROW
    WHEN ( new.numeroorden IS NULL )
BEGIN
    :new.numeroorden := seq_orden_pedido.nextval;
END;
/

CREATE SEQUENCE seq_id_proveedor START WITH 100 MINVALUE 100 MAXVALUE 999 NOCACHE ORDER;

CREATE OR REPLACE TRIGGER proveedor_id_trg BEFORE
    INSERT ON proveedor
    FOR EACH ROW
    WHEN ( new.id IS NULL )
BEGIN
    :new.id := seq_id_proveedor.nextval;
END;
/

CREATE SEQUENCE seq_tipo_cliente START WITH 1 MINVALUE 1 NOCACHE ORDER;

CREATE OR REPLACE TRIGGER tipo_cliente_idtipo_trg BEFORE
    INSERT ON tipo_cliente
    FOR EACH ROW
    WHEN ( new.idtipo IS NULL )
BEGIN
    :new.idtipo := seq_tipo_cliente.nextval;
END;
/

CREATE SEQUENCE seq_rubro START WITH 1 MINVALUE 1 NOCACHE ORDER;

CREATE OR REPLACE TRIGGER tipo_rubro_idrubro_trg BEFORE
    INSERT ON tipo_rubro
    FOR EACH ROW
    WHEN ( new.idrubro IS NULL )
BEGIN
    :new.idrubro := seq_rubro.nextval;
END;
/



-- Informe de Resumen de Oracle SQL Developer Data Modeler: 
-- 
-- CREATE TABLE                            17
-- CREATE INDEX                             0
-- ALTER TABLE                             34
-- CREATE VIEW                              0
-- ALTER VIEW                               0
-- CREATE PACKAGE                           0
-- CREATE PACKAGE BODY                      0
-- CREATE PROCEDURE                         0
-- CREATE FUNCTION                          0
-- CREATE TRIGGER                          11
-- ALTER TRIGGER                            0
-- CREATE COLLECTION TYPE                   0
-- CREATE STRUCTURED TYPE                   0
-- CREATE STRUCTURED TYPE BODY              0
-- CREATE CLUSTER                           0
-- CREATE CONTEXT                           0
-- CREATE DATABASE                          0
-- CREATE DIMENSION                         0
-- CREATE DIRECTORY                         0
-- CREATE DISK GROUP                        0
-- CREATE ROLE                              0
-- CREATE ROLLBACK SEGMENT                  0
-- CREATE SEQUENCE                         11
-- CREATE MATERIALIZED VIEW                 0
-- CREATE MATERIALIZED VIEW LOG             0
-- CREATE SYNONYM                           0
-- CREATE TABLESPACE                        0
-- CREATE USER                              0
-- 
-- DROP TABLESPACE                          0
-- DROP DATABASE                            0
-- 
-- REDACTION POLICY                         0
-- TSDP POLICY                              0
-- 
-- ORDS DROP SCHEMA                         0
-- ORDS ENABLE SCHEMA                       0
-- ORDS ENABLE OBJECT                       0
-- 
-- ERRORS                                   0
-- WARNINGS                                 0

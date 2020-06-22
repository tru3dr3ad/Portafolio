--2----ESTADO_BOLETA--
INSERT INTO ESTADO_BOLETA VALUES (1, 'ACTIVA');
INSERT INTO ESTADO_BOLETA VALUES (2, 'ANULADA');


--2----ESTADO_FIADO--

INSERT INTO ESTADO_FIADO VALUES (1, 'NO DEBE');
INSERT INTO ESTADO_FIADO VALUES (2, 'DEBE');
INSERT INTO ESTADO_FIADO VALUES (3, 'MOROSO');
INSERT INTO ESTADO_FIADO VALUES (4, 'NO FIAR MAS');

--3--TIPO_CLIENTE--
INSERT INTO TIPO_CLIENTE VALUES (1, 'FIADOR');
INSERT INTO TIPO_CLIENTE VALUES (2, 'NO FIAR');

--CLIENTE--
INSERT INTO CLIENTE VALUES(11111111,1,'SINNOMBRE','SINAPELLIDO','17/10/1992','LAS AYALAS 420',11111111,1,1);
INSERT INTO CLIENTE VALUES(18333710,6,'MARIO','GONZALEZ','17/10/1992','MEXICO 3124',28748123,1,1);
INSERT INTO CLIENTE VALUES(12364431,'K','ALEJANDRO','PRIETO','02/04/1972','CHICAUMA 6540',28126785,2,1);
INSERT INTO CLIENTE VALUES(20244872,0,'CAMILA','ROJAS','13/12/1999','APOSTOL PABLO 223',934567234,2,1);
INSERT INTO CLIENTE VALUES(15098334,2,'LUCAS','CORTES','26/08/1990','PEÑON 3124',99765342,3,1);

--6----MEDIO_PAGO--

INSERT INTO MEDIO_PAGO VALUES (1, 'EFECTIVO');
INSERT INTO MEDIO_PAGO VALUES (2, 'CREDITO');
INSERT INTO MEDIO_PAGO VALUES (3, 'DEBITO');
INSERT INTO MEDIO_PAGO VALUES (4, 'FIADO');

--7----TIPO_USUARIO--

INSERT INTO TIPO_USUARIO VALUES (1, 'ADMINISTRADOR');
INSERT INTO TIPO_USUARIO VALUES (2, 'VENDEDOR');

--8----USUARIO--
INSERT INTO USUARIO VALUES(19419104,9,'KRISTAL','ROJAS','A665A45920422F9D417E4867EFDC4FB8A04A1F3FFF1FA07E998E86F7F7A27AE3','01/02/1997','27/05/2020','CALLE FALSA 2244',92371271,'KR.ROJAS@ALUMNOS.DUOC.CL',1);
INSERT INTO USUARIO VALUES(7769287,1,'JUANA','REYES','A665A45920422F9D417E4867EFDC4FB8A04A1F3FFF1FA07E998E86F7F7A27AE3','25/10/1950','09/05/2020','RUKALHUE 3144',92371271,'KR.ROJAS@ALUMNOS.DUOC.CL',2);

--10----CATEGORIA--

INSERT INTO CATEGORIA VALUES (1, 'LACTEOS' );
INSERT INTO CATEGORIA VALUES (2, 'DESPENSA');
INSERT INTO CATEGORIA VALUES (3, 'LIMPIEZA');
INSERT INTO CATEGORIA VALUES (4, 'PAPELERIA');

--11----PRODUCTO--

INSERT INTO PRODUCTO VALUES ('10020021002021111','ARROZ','ARROZ PRE GRANEADO TUCAPEL','700','450','100','5',TO_DATE('21/08/21','DD/MM/RR'),'1','2');
INSERT INTO PRODUCTO VALUES ('10010014002020110','LECHE BLANCA','LECHE BLANCA ENTERA COLUN','850','600','100','5',TO_DATE('14/08/20','DD/MM/RR'),'1','1');
INSERT INTO PRODUCTO VALUES ('10010014002020112','LECHE CONDENSADA','LECHE CONDENSADA 500ML','850','600','100','5',TO_DATE('14/08/20','DD/MM/RR'),'1','1');
INSERT INTO PRODUCTO VALUES ('10030014002020113','DETERGENTE','DETERGENTE LIQUIDO ARIEL','1200','1000','50','5',TO_DATE('14/08/20','DD/MM/RR'),'1','3');
INSERT INTO PRODUCTO VALUES ('10040014002020114','LAPICE DE COLORES','CAJA DE LAPICES DE COLORES FABERCASTELL','1000','750','30','5',TO_DATE('14/08/20','DD/MM/RR'),'1','4');
INSERT INTO PRODUCTO VALUES ('10010014002020115','LECHE CHOCOLATE','LECHE CHOCOLATADA DESCREMADA','850','600','100','5',TO_DATE('14/08/20','DD/MM/RR'),'1','1');
INSERT INTO PRODUCTO VALUES ('10020021002021116','FIDEOS DE ARROZ','FIDEOS DE ARROZ 1 KILO','500','350','100','5',TO_DATE('21/08/21','DD/MM/RR'),'1','2');
INSERT INTO PRODUCTO VALUES ('10130014002020117','CHOCMAN','DETERGENTE LIQUIDO ARIEL','250','150','50','5',TO_DATE('14/08/20','DD/MM/RR'),'1','3');
INSERT INTO PRODUCTO VALUES ('10140014002020118','VANISH','SOBRE DE VANISH QUITA MANCHAS PARA LA ROPA','1000','750','30','5',TO_DATE('14/08/20','DD/MM/RR'),'1','4');
INSERT INTO PRODUCTO VALUES ('10120021002021119','AZUCAR IANSA','AZUCAR 1 KILO IANSA','700','450','100','5',TO_DATE('21/08/21','DD/MM/RR'),'1','2');
INSERT INTO PRODUCTO VALUES ('10240014002020120','LAVALOZA','LA GOTITA PARA PLATOS','1000','750','30','5',TO_DATE('14/08/20','DD/MM/RR'),'1','4');
INSERT INTO PRODUCTO VALUES ('10230014002020121','HARINA SIN POLVOS','DETERGENTE LIQUIDO ARIEL','1200','1000','50','5',TO_DATE('14/08/20','DD/MM/RR'),'1','3');



--12----TIPO_RUBRO--

INSERT INTO TIPO_RUBRO VALUES (0001, 'DETERGENTE'); 
INSERT INTO TIPO_RUBRO VALUES (0002, 'ARROZ');
INSERT INTO TIPO_RUBRO VALUES (0003, 'LECHE');
INSERT INTO TIPO_RUBRO VALUES (0004, 'LAPICES'); 

--13----PROVEEDOR--

INSERT INTO PROVEEDOR VALUES (10257620,9, SEQ_ID_PROVEEDOR.NEXTVAL, 'TUCAPEL', 'TUCAPEL@GMAIL.COM', 967132398, 'AV.PROVIDENCIA 6372', 0002);
INSERT INTO PROVEEDOR VALUES (14428648,0, SEQ_ID_PROVEEDOR.NEXTVAL, 'COLUN','COLUN@GMAIL.COM' ,942921860, 'ESMERALDA 641', 0003);
INSERT INTO PROVEEDOR VALUES (15370428,7, SEQ_ID_PROVEEDOR.NEXTVAL, 'P Y G', 'PYGCHILE@GMAIL', 953834079,'AV. PRESIDENTE RIESCO 5335', 0001);
INSERT INTO PROVEEDOR VALUES (10453787,1, SEQ_ID_PROVEEDOR.NEXTVAL, 'FABER-CASTELL', 'FABERCASTELLCH@GMAIL.COM', 986564321, 'QUILICURA 1025', 0004);

--14----ESTADO_ORDEN--
INSERT INTO ESTADO_ORDEN VALUES (1, 'GUARDADA');
INSERT INTO ESTADO_ORDEN VALUES (2, 'ENVIADA');
INSERT INTO ESTADO_ORDEN VALUES (3, 'PEDIDO RECHAZADO');
INSERT INTO ESTADO_ORDEN VALUES (4, 'RECEPCIONADA');
INSERT INTO ESTADO_ORDEN VALUES (5, 'INCOMPLETA');
INSERT INTO ESTADO_ORDEN VALUES (6, 'ANULADA');


--15----ORDEN_PEDIDO--




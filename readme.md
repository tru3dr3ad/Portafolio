# Tecnologias Utilizadas
- Oracle 18c XE
- Visual Studio 2019
- EntityFramework v6.4.4
- iTextSharp v5.5.13.1
- Microsoft.ReportingServices.ReportViewerControl.Winforms v150.1404.0
- Newtonsoft.Json v12.0.3
- Oracle.ManagedDataAccess v19.7.0
- Oracle.ManagedDataAccess.EntityFramework v19.7.0

## Installation
- [Oracle Developer Tools for Visual Studio 2019](https://www.oracle.com/database/technologies/dotnet-odtvsix-vs2019-downloads.html)
- [ODAC Oracle Universal Installer](https://www.oracle.com/database/technologies/dotnet-odacdev-downloads.html)
- [ODAC Runtimes](https://www.oracle.com/database/technologies/dotnet-odacdeploy-downloads.html)

**Luego de instalar: Al iniciar Visual Studio aparecerá un mensaje que dice "No se ha realizado instalacion correctamente. ¿Desea volver a instalar?" pulsar que si.**

En la carpeta de BDD se encuentran disponibles los scripts para su funcionamiento. El orden de ejecucion es: 
  - Script.dll
  - VistasYProcedimientosEtc.sql
  - Poblamiento.sql

Al actualizar el modelo de datos desde la aplicacion de visual studio, debe de cambiar las siguientes propiedades StoreGeneratedPattern a Identity,  Escala en 1, esto se debe hacer en cada atributo que sea autoincremental.
Aplique el cambio en las siguientes tablas:
- Categoria(Id)
- Rubro(Id) 
- Orden_pedido(Numero)
- Boleta(Numero)
- Detalle_Pedido(IdDetalleP)
- Detalle_Boleta(IdDetalleB)
- Abono(Id)
- Proveedor(Id)

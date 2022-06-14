# EvTecnicaGyS

## Aplicacion Web API
Se eligió lo siguiente:
1. Gestor de BD: MySQL
2. ORM: Entity Framework enfoque CodeFirst 
3. Storage: Bucket S3-AWS

### Consideraciones
Editar el ConnectionString en el archivo [appsettings.json](https://github.com/NattoGaboh/EvTecnicaGyS/blob/master/appsettings.json)

### Generar la BD
Para preparar la migración, en la consola del Administrador de paquetes Nuget ingresar:
~~~
Add-Migration Migrate
~~~

Para migrar al gestor de base de datos:
~~~
Update-database
~~~


Ejemplo de GET: https://<<localhost:PORT>>/api/Client/

Ejemplo de POST: https://<<localhost:PORT>>/api/Client/
~~~
{
    "CodCliente": "0000000001",
    "NombreCompleto": "Renato Gabriel Renato Gabriel",
    "NombreCorto":"renato",
    "Abreviatura":"rgvl",
    "Ruc":"0012345678",
    "Estado":"1",
    "GrupoFacturacion":"002911",
    "InactivoDesde":"2022-06-13",
    "CodigoSAP":"01010"
}
~~~

Ejemplo de PUT: https://<<localhost:PORT>>/api/Client/0000000001
~~~
{
    "CodCliente": "0000000001",
    "NombreCompleto": "Renato Gabriel Renato Gabriel",
    "NombreCorto":"renato",
    "Abreviatura":"rgvl",
    "Ruc":"0012345678",
    "Estado":"1",
    "GrupoFacturacion":"002911",
    "InactivoDesde":"2022-06-13",
    "CodigoSAP":"01010"
}
~~~


Ejemplo de DELETE: https://<<localhost:PORT>>/api/Client/0000000001


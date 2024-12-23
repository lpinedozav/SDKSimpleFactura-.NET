# SDK SimpleFactura

El **SDK SimpleFactura** es una solución en C# diseñada para facilitar la integración con los servicios de **SimpleFactura**, parte de ChileSystems. Este SDK provee un conjunto de clases y métodos que permiten realizar operaciones como facturación, gestión de productos, proveedores, clientes, sucursales, folios, configuración y boletas de honorarios.

## Características principales

- Simplifica la interacción con los servicios de SimpleFactura.
- Proporciona interfaces específicas para operaciones como:
  - **Facturación:** Generación y gestión de documentos tributarios electrónicos.
  - **Gestión de productos, proveedores y clientes.**
  - **Gestión folios.**
  - **Emisión de boletas de honorarios.**
- Compatible con aplicaciones en .NET Standard 2.0.

## Requisitos

### Dependencias
Al instalar el SDK a través de NuGet, las dependencias se gestionarán automáticamente. Las principales son:

- **Microsoft.Extensions.DependencyInjection**
- **Newtonsoft.Json 13.0.1**
- **NETStandard.Library 2.0.3**

### Plataforma
El SDK es compatible con proyectos que soporten **.NET Standard 2.0**.

## Instalación

### Usando NuGet CLI

```bash
nuget install SDKSimpleFactura
```
### Desde Package Manager en Visual Studio

```bash
PM> Install-Package SDKSimpleFactura
```

### Usando .NET CLI
```bash
dotnet add package SDKSimpleFactura
```

### Desde Visual Studio:

1. Abrir el explorador de soluciones.
2. Clic derecho en un proyecto dentro de tu solución.
3. Clic en Administrar paquetes NuGet.
4. Clic en la pestaña Examinar y busque `SDKSimpleFactura`
5. Clic en el paquete `SDKSimpleFactura`, seleccione la versión que desea utilizar y finalmente selecciones instalar.


### Configuración de SDK
Para usar el SDK, asegúrate de configurar tus credenciales y la URL base de la API en tu archivo de configuración. Este es un ejemplo de cómo configurarlo en `appsettings.json`:
```ruby
{
  "SDKSettings": {
    "Username": "demo@chilesystems.com",
    "Password": "Rv8Il4eV",
    "BaseUrl": "https://api.simplefactura.cl"
  }
}
```
### Configuración del archivo `appsettings.json`
Para garantizar que el archivo `appsettings.json` esté disponible en tiempo de ejecución, debes configurar las propiedades del archivo en Visual Studio de la siguiente manera:

1. Haz clic derecho en el archivo appsettings.json en el Explorador de Soluciones.
2. Selecciona Propiedades.
3. En la ventana de propiedades, establece:
   - **Copiar en el directorio de salida:** Copiar siempre.
  

Esto asegurará que el archivo appsettings.json se copie al directorio de salida (bin) durante la compilación.


### Cómo empezar
Para utilizar el SDK, simplemente inicializa la clase SimpleFacturaClient proporcionando tu nombre de usuario y contraseña:
```ruby
using SDKSimpleFactura;

class Program
{
    static void Main()
    {
        var SimpleFacturaClient = new SimpleFacturaClient();
        // Ejemplo: Uso de los servicios
        var facturacionService = SimpleFacturaClient.Facturacion;
        var productosService = SimpleFacturaClient.Productos;
        var proveedoresService = SimpleFacturaClient.Proveedores;
        var clientesService = SimpleFacturaClient.Clientes;
        var sucursalService = SimpleFacturaClient.Sucursal;
        var folioService = SimpleFacturaClient.Folio;
        var configuracionService = SimpleFacturaClient.Configuracion;
        var boletaHonorariosService = SimpleFacturaClient.BoletasHonorarios;
    }
}
```

### Documentación
La documentación relevante para usar este SDK es:

- Sitio oficial:
  [Sitio Simple Factura](https://www.simplefactura.cl/).
- Documentacion de APIs [Postman](https://documentacion.simplefactura.cl/).

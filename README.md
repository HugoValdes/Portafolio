# Proyecto portafolio simple con ASP .NET Core (.NET 6) 
Por: Hugo Eduardo Valdés Flores

----------
## Pre-requisitos

Para el uso del proyecto se debe contar con un ambiente de desarrollo para ASP .NET Core

**Windows** bastará solamente con ingresar al [sitio web oficial](https://visualstudio.microsoft.com/vs/) y descargar la versión 2022 Community.
**Windows** Opcionalmente puede descargar el editor de texto [Visual Studio Code](https://code.visualstudio.com/).

NOTA 1: Para macOS también hay una versión llamada Visual Studio for Mac.
NOTA 2: Para Linux, no hay una versión del IDE pero se podrá programar con el editor de texto [Visual Studio Code](https://code.visualstudio.com/).
 
- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/)
- [.NET SDK 6.0]([https://www.microsoft.com/net/download/all](https://dotnet.microsoft.com/es-es/download/dotnet/6.0))

**Instalación** (VS 2022 Community)
Al ejecutar el instalador en Windows por primera vez, el instalador realizará una validación inicial y después presentará una serie de opciones para instalar. Se seleccionarán las siguientes:

![ASP.NET and web development (en Web & Cloud)](https://paper-attachments.dropbox.com/s_89174DDDF7262C2B179DB61DFC52A1A64FDD6201EFF8F1A2E8B37CACA5FC093E_1554350941271_image.png)

![.NET Core cross-platform development (en Other Toolsets)](https://paper-attachments.dropbox.com/s_89174DDDF7262C2B179DB61DFC52A1A64FDD6201EFF8F1A2E8B37CACA5FC093E_1554350961113_image.png)

Y procedemos a ejecutar la instalación.

**Este proyecto no requiere instalar motor de base de datos**

## Abra el proyecto en VS Code o VS 2022

Este proyecto cuenta adicionalmente con envio de correos por Sendgrid, para ello debe crear una cuenta y una API Key, actualmente Sendgrid solo aprueba en el envio de correos por medio de dominios comprobados, si en el archivo **appsetings.json** deja los campos de configuración de Sendgrid vacios, se omitirá el envio de correos desde el formulario de contacto:

```json
{
  "SENDGRID_API_KEY": "HERE SENDGRID APY KEY",
  "SENDGRID_EMAIL_FROM": "HERE FROM EMAIL",
  "SENDGRID_NAME_FROM": "HERE FROM NAME",
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```

**Happy Coding!!**

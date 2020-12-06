# MailTo

`MailTo` es un programa para envío masivo de mails desde múltiples servidores SMTP. Está diseñado para el uso desde la línea de
comandos u llamado desde otros sistemas. Utiliza el formato de Thunderbird [(info)](http://kb.mozillazine.org/Command_line_arguments_-_Thunderbird)
y se agrega nuevas opciones para controlar el estado del envío.

Los mensajes se envían al azar entre 5 y 15 segundos seleccionando, también al azar (random round-robin) entre el grupo de servidores SMTP.

### Requerimientos

.NET Framework [4.7.2](https://dotnet.microsoft.com/download/dotnet-framework/net472) o superior

### Uso.

Agregar un nuevo mensaje

```
MailTo.exe -compose "to='john@example.com,kathy@example.com',subject='dinner',body='How about dinner tonight?',attachment='C:\temp\info.doc,C:\temp\food.doc'"
```

Iniciar el envío

```
MailTo.exe start
```

Pausar el envío

```
MailTo.exe pause
```







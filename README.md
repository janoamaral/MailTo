# MailTo

`MailTo` es un programa para env�o masivo de mails desde m�ltiples servidores SMTP. Est� dise�ado para el uso desde la l�nea de
comandos u llamado desde otros sistemas. Utiliza el formato de Thunderbird [(info)](http://kb.mozillazine.org/Command_line_arguments_-_Thunderbird)
y se agrega nuevas opciones para controlar el estado del env�o.

Los mensajes se env�an al azar entre 5 y 15 segundos seleccionando, tambi�n al azar (random round-robin) entre el grupo de servidores SMTP.

### Requerimientos

.NET Framework [4.7.2](https://dotnet.microsoft.com/download/dotnet-framework/net472) o superior

### Uso.

Agregar un nuevo mensaje

```
MailTo.exe -compose "to='john@example.com,kathy@example.com',subject='dinner',body='How about dinner tonight?',attachment='C:\temp\info.doc,C:\temp\food.doc'"
```

Iniciar el env�o

```
MailTo.exe start
```

Pausar el env�o

```
MailTo.exe pause
```







# Paquete de entrega - Pruebas unitarias MsrBack API

## Contenido

- `Documento/Informe_Pruebas_Unitarias_MsrBack_APA7.docx`: informe principal editable en formato Word.
- `Documento/Informe_Pruebas_Unitarias_MsrBack_APA7.pdf`: version PDF exportada del informe.
- `MsrBack.Tests/`: proyecto xUnit con las pruebas unitarias.
- `Evidencias/resultado-pruebas.txt`: salida de consola de la ejecucion de pruebas.
- `Evidencias/unit-tests.trx`: archivo de resultados generado por `dotnet test`.
- `Evidencias/captura_resultado_pruebas.png`: evidencia visual para anexar o presentar.
- `VideoPitch/Guion_Video_Pitch.md`: guion sugerido para grabar el video pitch.

## Comando para ejecutar las pruebas

Desde esta carpeta:

```powershell
dotnet test .\MsrBack.Tests\MsrBack.Tests.csproj --logger "trx;LogFileName=unit-tests.trx" --results-directory .\Evidencias
```

## Resultado validado

- Total de pruebas: 4
- Pruebas aprobadas: 4
- Pruebas fallidas: 0
- Pruebas omitidas: 0

## Pendiente antes de entregar

Completar en la portada del informe:

- Nombre de los integrantes.
- Institucion educativa.
- Programa o asignatura.
- Nombre del docente.


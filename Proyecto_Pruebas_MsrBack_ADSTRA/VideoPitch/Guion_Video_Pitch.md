# Guion sugerido para video pitch

Duracion sugerida: 2 a 3 minutos.

## 1. Presentacion

Buenos dias. En este video presentamos el diseño y ejecucion de pruebas unitarias para la validacion de software, tomando como sistema evaluado la API MsrBack de ADSTRA TECH.

## 2. Sistema seleccionado

MsrBack es una API backend desarrollada en ASP.NET Core y .NET 8. El sistema cuenta con una arquitectura por capas compuesta por MsrBack, MsrBack.Core y MsrBack.Infrastructure. Para esta actividad se selecciono el modulo de autenticacion y seguridad porque contiene funciones criticas para el acceso al sistema.

## 3. Tipo de prueba seleccionado

El tipo de prueba seleccionado fue prueba unitaria. Se eligio este tipo de prueba porque permite validar funciones especificas de manera aislada, rapida y repetible, sin depender de la base de datos ni de ejecutar toda la API.

## 4. Casos de prueba

Se documentaron y ejecutaron cuatro casos principales:

1. Generacion de hash y salt para una contrasena valida.
2. Verificacion de una contrasena correcta.
3. Rechazo de una contrasena incorrecta.
4. Generacion de un token JWT con claims esperados.

## 5. Resultado

Las pruebas fueron ejecutadas con xUnit y dotnet test. El resultado fue satisfactorio: cuatro pruebas aprobadas, cero fallidas y cero omitidas. Esto evidencia que los componentes evaluados cumplen con los criterios definidos para el manejo seguro de contrasenas y generacion de token.

## 6. Analisis y cierre

Como analisis critico, se identifico que el proyecto compila correctamente, pero presenta advertencias de nulabilidad y documentacion XML. Se recomienda ampliar la cobertura de pruebas hacia la logica AuthBLL, controladores protegidos y pruebas de integracion con una base de datos de prueba. En conclusion, el proceso de pruebas permite reducir riesgos antes de la implementacion final y fortalece la calidad del software.


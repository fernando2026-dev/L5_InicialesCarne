using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using static System.Runtime.InteropServices.JavaScript.JSType;

class PanelAcceso
{
    static void Main()
    {
        Console.WriteLine("===== Ejercicio 1 =====");
        
        Console.WriteLine("");

        // PIn del usuario
        Console.Write("Ingrese su ID de usuario : ");
        int IDUsuario = int.Parse(Console.ReadLine());

        // PIn del usuario
        Console.Write("Ingrese su PIN : ");
        int PINUsuario = int.Parse(Console.ReadLine());

        //Token de seguridad
        Console.Write("Ingrese su token de seguridad : ");
        int TokenSeguridad = int.Parse(Console.ReadLine());

        //Activar o desactivar modo seguro
        Console.Write("Desea activar el modo seguro (1 = Si , 0 = No) :");
        int ModoSeguro = int.Parse(Console.ReadLine());

        Console.WriteLine("");

        //A) Verificar su ID
        if (IDUsuario == 2026)
            Console.WriteLine("Usuario reconocido");
        else 
            Console.WriteLine("Usuario no reconocido");

        //B) Verificación de PIN
        if (PINUsuario == 1234)
            Console.WriteLine("PIN correcto");
        else
            Console.WriteLine("PIN incorrecto");

        //C) Verificacion de Token
        if (TokenSeguridad == 777)
            Console.WriteLine("Token válido");
        else
            Console.WriteLine("Token inválido");

        //D) Verificacion de modo seguro 
        if (ModoSeguro == 1)
            Console.WriteLine("Modo seguro activado: se aplican reglas extra.");
        else
            Console.WriteLine("Modo seguro desactivado");

        //E) Acceso total al contenido 
        if (IDUsuario == 2026 && PINUsuario == 1234 && TokenSeguridad == 777)
            Console.WriteLine("Acceso total concedido");
        else
            Console.WriteLine("Acceso total denegado");

        Console.WriteLine("");

        //F) Regla extra
        if (ModoSeguro == 1)
        {
            if (TokenSeguridad >= 700)
                Console.WriteLine("Regla extra aprobada");
            else
                Console.WriteLine("Regla extra fallida");
        }
          
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("===== Ejercicio 2 =====");

        Console.WriteLine("");

        Console.Write("Ingrese su numero de PIN: ");
        int PIN = int.Parse(Console.ReadLine());

        Console.WriteLine("");

        //A) VERIFICAR EL PIN
        if (PIN >= 1000 && PIN <= 9999)
            Console.WriteLine("PIN de 4 dígitos: OK");
        else
            Console.WriteLine("PIN inválido: debe tener 4 dígitos");

        //B) Verificar si el PIN es par o impar
        if (PIN % 2 == 0)
            Console.WriteLine("PIN par");

        else 
            Console.WriteLine("PIN impar");

        //C) Verificar si el PIN es múltiplo de 5
        if (PIN % 5 == 0)
            Console.WriteLine("Múltiplo de 5");
        else
            Console.WriteLine("No es múltiplo de 5");

        //D) Verificar si el PIN cumple la regla de seguridad
        if (PIN >= 1000 && PIN <= 9999 && PIN % 2 == 0 && PIN % 5 == 0)
            Console.WriteLine("PIN aceptado por política");
        else
            Console.WriteLine("PIN rechazado por política");

        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("===== Ejercicio 3 =====");

        Console.WriteLine("");

        Console.Write("Ingrese número de activación:  ");
        int NumeroActivacion = int.Parse(Console.ReadLine());


        Console.Write("Ingrese su edad: ");
        int Edad = int.Parse(Console.ReadLine());


        Console.Write("¿Aceptó términos y condiciones? (1 = Si / 0 = No): ");
        int Terminos = int.Parse(Console.ReadLine());


        Console.Write("¿Activó verificación en dos pasos (2FA) (1 = Si / 0 = No): ");
        int Verificacion = int.Parse(Console.ReadLine());


        Console.Write("Puntaje: ");
        int Puntaje = int.Parse(Console.ReadLine());

        Console.WriteLine("");

        //A) Verificar si el codigo es correcto
        if (NumeroActivacion == 2026)
            Console.WriteLine("Codigo correcto");
        else
            Console.WriteLine("Codigo incorrecto");

        //B) Verificar la edad del usuario
        if (Edad >= 18)
            Console.WriteLine("Edad válida");
        else
            Console.WriteLine("Edad invalida");

        // C) Verificar si el usuario aceptó los términos y condiciones
        if (Terminos == 1)
            Console.WriteLine("Terminos aceptados");
        else
            Console.WriteLine("Debe aceptar terminos");

        //D) Verificar que 2FA esté activado
        if (Verificacion == 1)
            Console.WriteLine("2FA activado");
        else
            Console.WriteLine("2FA no activado");

        //E) Verificar el puntaje del usuario
        if (Puntaje >= 70)
            Console.WriteLine("Puntaje suficiente");
        else
            Console.WriteLine("Puntaje insuficiente");

        //F) Activar cuenta si se cumplen todas las condiciones
       if (NumeroActivacion == 2026 && Edad >= 18 && Terminos == 1 && Verificacion == 1 && Puntaje >= 70)
            Console.WriteLine("Cuenta activada exitosamente");
        else
            Console.WriteLine("“Cuenta NO activada");

        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("===== Ejercicio Final =====");

        Console.WriteLine("");

        Console.Write("Ingrese nota previa (0 a 100): ");
        int NotaPrevia = int.Parse(Console.ReadLine());

        Console.Write("Ingrese minutos de llegada tarde: ");
        int MinutosTarde = int.Parse(Console.ReadLine());

        Console.Write("¿Tiene solvencia de pagos? (1 = Si / 0 = No): ");
        int Solvencia = int.Parse(Console.ReadLine());

        Console.Write("¿Trae identificación física? (1 = Si / 0 = No): ");
        int Identificacion = int.Parse(Console.ReadLine());

        Console.Write("¿Trae calculadora permitida? (1 = Si / 0 = No):");
        int Calculadora = int.Parse(Console.ReadLine());

        Console.WriteLine("");

        //A) Verificar la nota previa
        if (NotaPrevia >= 61)
            Console.WriteLine("Requisito académico aprobado");
        else
            Console.WriteLine("Requisito académico NO aprobado");

        //B) Verificar la puntualidad
        if (MinutosTarde <= 10)
            Console.WriteLine("Hora válida");
        else
            Console.WriteLine("Llegada tarde: fuera de tiempo");

        //C) Verificar la solvencia de pagos
        if (Solvencia == 1)
            Console.WriteLine("Solvencia validada");
        else
            Console.WriteLine("Sin solvencia");

        //D) Verificar la identificación física
        if (Identificacion == 1)
            Console.WriteLine("Identificación validada");
        else
            Console.WriteLine("Sin identificación");

        //E) Verificar la calculadora permitida
        if (Calculadora == 1)
            Console.WriteLine("Calculadora permitida: OK");
        else
            Console.WriteLine("Sin calculadora permitida");

        //F) Verificar si el estudiante cumple todos los requisitos para rendir el examen
        if (NotaPrevia >= 61 && MinutosTarde <= 10 && Solvencia == 1 && Identificacion == 1 && Calculadora == 1)
            Console.WriteLine("Acceso a sala de examen concedido");
        else
            Console.WriteLine("Acceso denegado");

        //G) Regla adicional
        if (MinutosTarde > 0 && MinutosTarde <= 10)
            Console.WriteLine("Llegó tarde pero dentro del tiempo permitido.");

        Console.WriteLine("");  
        Console.WriteLine(""); 

        Console.Write("===== Ejercicio Bonus San Valentin =====");

        Console.WriteLine("");

        Console.Write("Ingrese su nombre: ");
        string NombrePersona = Console.ReadLine();

        Console.Write("Ingrese su nivel de valentia (0 a 100): ");
        int Valentia = int.Parse(Console.ReadLine());

        Console.Write("¿Le gusta la programación? (1 = Si / 0 = No): ");
        int Programacion = int.Parse(Console.ReadLine()); 

        Console.Write("¿Le gustan los memes técnicos? (1 = Si / 0 = No): ");
        int MemesTecnicos = int.Parse(Console.ReadLine());

        Console.Write("Nivel de interes (0 a 100): ");
        int Interes = int.Parse(Console.ReadLine());

        Console.Write("¿Está soltera/o? (1 = Si / 0 = No): ");
        int Solteria = int.Parse(Console.ReadLine());

        Console.WriteLine("");

        //1) INTERES
        if (Interes >= 70)
            Console.WriteLine("Interes alto detectado");
        else
            Console.WriteLine("Interés insuficiente. Riesgo de friend zone elevado");

        //2) VALENTIA
        if (Valentia >= 70)
            Console.WriteLine("Valentía favorable. Confía en sí mismo(a)");
        else
            Console.WriteLine("Nivel de valentía bajo. Actualización de hardware requerida (vaya al gym)");

        //3) Estado Sentimental
        if (Solteria == 1)
            Console.WriteLine("Estado sentimental favorable… aunque lo esté, no le crea: todos/todas mienten");
        else
            Console.WriteLine("Estado sentimental comprometido, no es recomendable hackear esa relación");

        if (Programacion == 1 && MemesTecnicos == 1)
            Console.WriteLine("Compatibilidad geek detectada.");
        else
            Console.WriteLine("Compatibilidad parcial o inexistente.");

        // Decisión Final
        if (Interes >= 70 && Solteria == 1 && Programacion == 1 && MemesTecnicos == 1 && Valentia >= 70)
            Console.WriteLine("DECLARACIÓN APROBADA. Proceder con chocolates y flores.");
        else if (Interes >= 70 && Solteria == 1 && Programacion == 1 && MemesTecnicos == 1 && Valentia < 70)
            Console.WriteLine("No le tenga miedo al éxito que vida solo hay 1.");
        else
            Console.WriteLine($"{NombrePersona}, no te ama..por ahora.");


    }
}
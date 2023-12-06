using CalculadoraDeIndiceDeMasaCorporal.Models;
using System;

string? nombre;
decimal peso;
decimal estatura;
decimal imc;

Persona persona;
string estadoNutricional;
Console.WriteLine("Programa que calcula el índice de masa corporal de una persona.");

try
{
    // Entrada de datos
    Console.Write("Proporcione el nombre de la persona: ");
    nombre = Console.ReadLine();
    peso = ReadDecimal("Peso de la persona en kilogramos: ");
    estatura = ReadDecimal("Estatura de la persona en metros: ");
    // Procesamiento
    persona = new Persona(nombre, peso, estatura);
    //imc = CalculadoraDeIndiceDeMasaCorporal.IndiceDeMasaCorporal(persona.Peso, persona.Estatura);
    imc = CalculadoraDeIndiceDeMasaCorporal.Models.CalculadoraDeIndiceDeMasaCorporal.IndiceDeMasaCorporal(persona.Peso, persona.Estatura);
    estadoNutricional = SituacionNutricionalComoTexto(imc);
    // Salida de datos
    Console.WriteLine();
    Console.WriteLine($"{persona.Nombre} pesa {persona.Peso} kilogramos y mide {persona.Estatura} metros.\n");
    Console.WriteLine($"{persona.Nombre} tiene un índice de masa corporal de {imc} kg/m2.");
    Console.WriteLine($"La situación nutricional de {persona.Nombre} es {estadoNutricional}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
decimal ReadDecimal(string s)
{
    decimal numero;
    Console.Write(s);
    string? entrada = Console.ReadLine();
    if (!decimal.TryParse(entrada, out numero))
    {
        throw new FormatException("El valor proporcionado no es un número.");
    }
    return numero;
}
string SituacionNutricionalComoTexto(decimal imc)
{
    CalculadoraDeIndiceDeMasaCorporal.Models.CalculadoraDeIndiceDeMasaCorporal.EstadoNutricional estadoNutricional =
    CalculadoraDeIndiceDeMasaCorporal.Models.CalculadoraDeIndiceDeMasaCorporal.SituacionNutricional(imc);
    switch (estadoNutricional)
    {
        case CalculadoraDeIndiceDeMasaCorporal.Models.CalculadoraDeIndiceDeMasaCorporal.EstadoNutricional.PesoBajo:
            return "Peso Bajo";
        case CalculadoraDeIndiceDeMasaCorporal.Models.CalculadoraDeIndiceDeMasaCorporal.EstadoNutricional.PesoNormal:
            return "Peso Normal";
        case CalculadoraDeIndiceDeMasaCorporal.Models.CalculadoraDeIndiceDeMasaCorporal.EstadoNutricional.SobrePeso:
            return "Sobrepeso";
        case CalculadoraDeIndiceDeMasaCorporal.Models.CalculadoraDeIndiceDeMasaCorporal.EstadoNutricional.Obesidad:
            return "Obesidad";
        case
   CalculadoraDeIndiceDeMasaCorporal.Models.CalculadoraDeIndiceDeMasaCorporal.EstadoNutricional.ObesidadExtrema:
            return "Obesidad extrema";
        default:
            return string.Empty;
    }
}

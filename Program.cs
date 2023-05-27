﻿string entradaT, entradaP, entradaR;
bool sensorT, sensorP, sensorR, luzAdvertenciaW;

Console.WriteLine("--- Simulador de Luz de Advertência ---\n");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("[A]tivado,");

Console.ForegroundColor = ConsoleColor.Red;
Console.Write("[D]esativado\n");
Console.ResetColor();

Console.Write("Sensor de temperatura...: ");
entradaT = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();

if (entradaT != "A" && entradaT != "D")
{
    Console.WriteLine("Valor inválido.");
    return;
}
sensorT = entradaT == "A";

Console.Write("Sensor de pressão.......: ");
entradaP = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();

if (entradaP != "A" && entradaP != "D")
{
    Console.WriteLine("Valor inválido.");
    return;
}
sensorP = entradaP == "A";

Console.Write("Sensor de rotação.......: ");
entradaR = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();

if (entradaR != "A" && entradaR != "D")
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Valor inválido.");
    Console.ResetColor();
    return;
}
sensorR = entradaR == "A";

luzAdvertenciaW = sensorT && (sensorP || !sensorR);

Console.WriteLine($"\nA luz de advertência estará {(luzAdvertenciaW ? "ATIVADA" : "DESATIVADA")}.");
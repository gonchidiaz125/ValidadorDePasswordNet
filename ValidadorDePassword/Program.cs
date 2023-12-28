// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var validador = new ValidadorDePassword.ValidadorDePassword();

var password = "123";
var resultado = validador.ValidarLargoMinimo(password);
Console.WriteLine($"Validar largo minimo de <{password}>: {resultado}");

Console.WriteLine();

password = "12";
resultado = validador.ValidarLargoMinimo(password);
Console.WriteLine($"Validar largo minimo de <{password}>: {resultado}");

Console.WriteLine();


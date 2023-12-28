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

password = "validar largo maximo";
resultado = validador.ValidarLargoMaximo(password);
Console.WriteLine($"Validar largo maximo de <{password}>: {resultado}");

Console.WriteLine();

password = "validar largo maximo!! validar largo maximo!!";
resultado = validador.ValidarLargoMaximo(password);
Console.WriteLine($"Validar largo maximo de <{password}>: {resultado}");

Console.WriteLine();

password = "1234";
resultado = validador.ValidarDebeContenerAlgunNumero(password);
Console.WriteLine($"Validar que contenga un numero <{password}>: {resultado}");

Console.WriteLine();

password = "abcd";
resultado = validador.ValidarDebeContenerAlgunNumero(password);
Console.WriteLine($"Validar que contenga un numero <{password}>: {resultado}");

Console.WriteLine();

password = "aBCD";
resultado = validador.ValidarDebeContenerAlgunaMinuscula(password);
Console.WriteLine($"Validar que contenga alguna minuscula <{password}>: {resultado}");

Console.WriteLine();

password = "ABCD";
resultado = validador.ValidarDebeContenerAlgunaMinuscula(password);
Console.WriteLine($"Validar que contenga alguna minuscula <{password}>: {resultado}");

Console.WriteLine();
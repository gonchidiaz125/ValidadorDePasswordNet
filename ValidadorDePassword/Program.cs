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

password = "ABCD";
resultado = validador.ValidarDebeContenerAlgunaMayuscula(password);
Console.WriteLine($"Validar que contenga alguna mayuscula <{password}>: {resultado}");

Console.WriteLine();

password = "abcd";
resultado = validador.ValidarDebeContenerAlgunaMayuscula(password);
Console.WriteLine($"Validar que contenga alguna mayuscula <{password}>: {resultado}");

Console.WriteLine();

password = "abd!!";
resultado = validador.ValidarDebeContenerAlgunCaracterEspecial(password);
Console.WriteLine($"Validar que contenga algun caracter especial <{password}>: {resultado}");

Console.WriteLine();

password = "abcd";
resultado = validador.ValidarDebeContenerAlgunCaracterEspecial(password);
Console.WriteLine($"Validar que contenga algun caracter especial <{password}>: {resultado}");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("VALIDAMOS TODAS LAS REGLAS JUNTAS");
Console.WriteLine();

password = "Abc1!";

var listaDePassword = new List<string>();
listaDePassword.Add("ab");
listaDePassword.Add("01234567890123456789000");
listaDePassword.Add("abcde");
listaDePassword.Add("ABCDE");
listaDePassword.Add("abcDEF");
listaDePassword.Add("abcDEF123");
listaDePassword.Add("abcDEF123!!!");

foreach (var p in listaDePassword)
{
    password = p;
    var res = validador.ValidarPasswordConTodasSusReglas(password);
    Console.WriteLine($"Validacion General <{password}>: {res.Valida}");

    foreach (var c in res.Reglas)
    {
        Console.WriteLine($"{c.Valida} - Regla {c.Regla}");
    }
    Console.WriteLine("");
}
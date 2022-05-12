//    var no = Console.ReadLine();
//}
//else if (no == "N")
//{
//    Console.WriteLine("Programa Finalizado Correctamente");
//}
//else
//{
//    Console.WriteLine("Opcion No valida");
//}

//Console.Clear();
//Console.WriteLine("Ingrese su nombre: ");
//    var nombre = Console.ReadLine();
//    Console.WriteLine("¡Hola " + nombre + "!");
//    Console.WriteLine("¿Desea Continuar? S/N");
//    var respuesta = Console.ReadLine();

//if (respuesta.ToUpper() == "S")
//{
//    Console.WriteLine("Ingrese su nombre: ");
//    var nombre2 = Console.ReadLine();
//    Console.WriteLine("¡Hola " + nombre2 + "!");
//    Console.WriteLine("¿Desea Continuar? S/N");
//    var respuesta2 = Console.ReadLine();
//}
//else if (respuesta.ToUpper() == "N")
//{
//    Console.WriteLine("Programa Finalizado Correctamente");
//}
//else
//{
//    Console.WriteLine("Opcion no valida");
//}

Console.Clear();
while (true)
{
    Console.WriteLine("Ingrese su nombre: ");
    var nombre = Console.ReadLine();
    Console.WriteLine("¡Hola " + nombre + "!");
    Console.WriteLine("¿Desea Continuar? S/N");
    var respuesta = Console.ReadLine();
    if (respuesta.ToUpper() == "S")
    {
    }
    else if (respuesta.ToUpper() == "N")
    {
        Console.WriteLine("Programa finalizado correctamente");
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Opcion no valida");
        Environment.Exit(0);
    }
}
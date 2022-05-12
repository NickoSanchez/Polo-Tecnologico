//// See https://aka.ms/new-console-template for more information
//Console.WriteLine(" Test ");
//int numeroUno;
//int otroNumero;
//Console.WriteLine("Escriba un numero: ");
//numeroUno = Convert.ToInt16 (Console.ReadLine());
//Console.WriteLine("Escriba otro numero: ");
//otroNumero = Convert.ToInt16 (Console.ReadLine());
//Console.WriteLine(numeroUno + otroNumero);

//Console.Clear();

//if (si == "S")
//{
//    Console.WriteLine("Ingrese su nombre: ");
//    var nombre = Console.ReadLine();
//    Console.WriteLine("¡Hola " + nombre + "!");
//    Console.WriteLine("¿Desea Continuar? S/N");
//    var si = Console.ReadLine();
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





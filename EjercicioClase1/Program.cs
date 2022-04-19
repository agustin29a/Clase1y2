//EJERCICIO 1
string ejercicioUno(int valor) => valor > 100 ? "El valor es mayor que 100" : "";

//EJERCICIO 2
string ejercicioDos()
{
    string resultado;
    Console.WriteLine("Ingrese un numero");
    int num = int.Parse(Console.ReadLine());

    resultado = (num % 2 == 0) ? "Es par" : "Es impar";

    return resultado;

};

//EJERCICIO 3

string ejercicioTres(int valor)
{
    float num = ((float)valor / 2 );
    int resultado = (int)num;
    string respuesta;
    respuesta = (num % resultado == 0.0 && num % 2 != 0) ? "Cumple con la condicion" : "No cumple con la condicion";
    
    return respuesta;

};

//EJECICIO 4
string ejercicioCuatro(int valor)
{
    string[] numeros = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X"};
    return numeros[valor - 1];
}


//EJERCICIO 5
string ejercicioCinco()
{
    string resultado;
    int n = 0;
    string [] nombres = new string[2];
    int [] edad = new int[2];
    
    while (n < 2)
    {
        Console.WriteLine("Ingrese el nombre nº: " + (n+1));
        nombres[n] = Console.ReadLine();
        Console.WriteLine("Ingrese su edad");
        edad[n] = int.Parse(Console.ReadLine());
        n++; 
    }

    if (edad[0] < edad[1])
    {
        resultado = nombres[1] + "es mayor que " + nombres[0];
    } 
    else if (edad[1] < edad[0])
    {
        resultado = nombres[0] + "es mayor que " + nombres[1];
    }
    else
    {
        resultado = "Ambos tinen la misma edad";
    }

    return resultado;

};

//EJERCICIO 6
string ejercicioSeis(int valor1, int valor2, int valor3)
{
    int[] lados = { valor1, valor2, valor3 };
    int lado = valor1;
    int cantidad = 0;
    string resultado; 
    
    foreach (int element in lados)
    {
        if (element == lado)
        {
            cantidad++;
        }
    }

    switch (cantidad)
    {
        case 1:
            resultado = "Es un triangulo escaleno";
            break;
        case 2:
            resultado = "Es un triangulo isosceles";
            break;
        default:
            resultado = "Es un triangulo equilatero";
            break;
    }

    return resultado;

}

//EJERCICIO 7
void ejercicioSiete(int valor)
{
    int billete1000 = 0;
    int resultado;
    int[,] billetes = { { 1000, 0 },{ 500, 0 },{ 100, 0 },{ 50, 0 },{ 20, 0 },{ 10, 0 },{ 5, 0 },{ 2, 0 },{ 1, 0 } };


    for (int i = 0; i < billetes.GetLength(0); i++)
    {
        resultado = valor / billetes[i,0];
        if (resultado > 0)
        {
            billetes[i,1] = resultado;
            valor = valor - (resultado * billetes[i,0]);
        }
    }

    for(int i = 0; i < billetes.GetLength(0); i++)
    {
        Console.WriteLine(billetes[i,1] + " billetes de " + billetes[i,0]);

    }


}


//EJERCICIO 8
void ejercicioOcho()
{
    int numero;
    Console.WriteLine("Ingrese un numero");
    numero = int.Parse(Console.ReadLine());

    for (int i = 1; i < numero + 1; i++)
    {
        Console.WriteLine(i);

    }

};

//EJERCICIO 9
void ejercicioNueve()
{
    int numero, acumulador, n;
    acumulador = 0;
    n = 1;

    while (n < 16)
    {
        Console.WriteLine("Ingrese un numero");
        numero = int.Parse(Console.ReadLine());
        acumulador = acumulador + numero;
        n++;
    }

    Console.WriteLine("La suma es " + acumulador);

};

//EJERCICIO 10
void ejercicioDiez()
{
    int numero, n;
    n = 1;

    while (n < 6)
    {
        Console.WriteLine("Ingrese un numero");
        numero = int.Parse(Console.ReadLine());
        if (numero % 3 == 0)
        {
           Console.WriteLine(numero + " es multiplo de 3.");
        }
     
    }

};


//EJERCICIO 11
void ejercicioOnce()
{

    Console.WriteLine("Ingrese su contraseña");
    string contraseña = Console.ReadLine();

    Console.WriteLine("Ingrese de nuevo su contraseña");
    string nuevaContraseña = Console.ReadLine();


    while (contraseña != nuevaContraseña)
    {
        Console.WriteLine("Ingrese de nuevo su contraseña");
        nuevaContraseña = Console.ReadLine();

    }

};


//EJERCICIO 12
void ejercicioDoce()
{
    int n = 0;
    
    Console.WriteLine("Ingrese su contraseña");
    string contraseña = Console.ReadLine();

    Console.WriteLine("Ingrese de nuevo su contraseña");
    string nuevaContraseña = Console.ReadLine();


    while (contraseña != nuevaContraseña && n < 3)
    {
        Console.WriteLine("Ingrese de nuevo su contraseña");
        nuevaContraseña = Console.ReadLine();
        n++;

    }

    if (n >= 3)
    {
        Console.WriteLine("Supero el limite de intentos");
    }

};


//EJERCICIO 13
void ejercicioTrece()
{
    Random rnd = new Random();
    int n = rnd.Next(1, 10);
   
    Console.WriteLine("Ingrese un numero");
    int numero = int.Parse(Console.ReadLine());

   
    if (n == numero)
    {
        Console.WriteLine("Acertaste!");
    };

};

//EJERCICIO 14
void ejercicioCatorce()
{
    
    Random rnd = new Random();
    int n = rnd.Next(1, 10);
    int intentos = 0;
    
    Console.WriteLine("Ingrese un numero");
    int numero = int.Parse(Console.ReadLine());


    while (n != numero && intentos < 2)
    {
        
        if (n < numero)
        {
            Console.WriteLine("El numero es menor al que ingresaste. Vuelve a ingresarlo ");
            numero = int.Parse(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("El numero es mayor al que ingresaste. Vuelve a ingresarlo ");
            numero = int.Parse(Console.ReadLine());

        }

        intentos++;
    };

    if (n == numero)
    {
        Console.WriteLine("Acertaste!");
    }
    else
    {
        Console.WriteLine("Sorry!");
    }

};


//EJERCICIO 15
void ejercicioQuince()
{
    Console.WriteLine("Ingrese un numero");
    string stNumero = Console.ReadLine();
    int n, acumulador;
    bool isNumeric;
    acumulador = 0;
    n = 0;

    while (stNumero != "fin")
    {
        isNumeric = int.TryParse(stNumero, out n);

        if (isNumeric)
        {
            acumulador = acumulador + n;
        }
        
        Console.WriteLine("Ingrese otro numero");
        stNumero = Console.ReadLine();
       
    }

    Console.WriteLine("la sumatoria es " + acumulador);

};


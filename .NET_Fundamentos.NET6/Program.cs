// // See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, .NET6");


List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");

for (int i = 0; i < listaString.Count; i++)
{
    System.Console.WriteLine($"Posicao No {i} - {listaString[i]} ");
}

System.Console.WriteLine("--------------------\n");

int contadorForeach = 0;
foreach (string item in listaString)
{
   System.Console.WriteLine($"Posicao N {contadorForeach} - {item}"); 
   contadorForeach++;
}

// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;


// int[] arrayDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayDobrado, arrayInteiros.Length);

// int iArrayDobrado =0;
// foreach (int item in arrayDobrado)
// {
//     System.Console.WriteLine($"Posicao No {iArrayDobrado} - {item}");
//     iArrayDobrado++;
// }



// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

//Percorrendo array com for
// for (int i = 0; i < arrayInteiros.Length; i++)
// {
//     System.Console.WriteLine($"Posicao No {i} - {arrayInteiros[i]}");
// }






// System.Console.WriteLine("-------------------------\n");

// //Percorrendo array com foreach + contador

// int contadorForeach = 0;
// foreach (int valor in arrayInteiros)
// {
//     System.Console.WriteLine($"Posicao N {contadorForeach} - {valor}");
//     contadorForeach++;
// }



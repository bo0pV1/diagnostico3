
//diagnostico 3 pepepe


using System.Net.Http.Headers;

int sel=1;

while (sel != 0){
Console.WriteLine("MENU DEL DIAGNOSTICO - seleccione que punto desea ver");
Console.WriteLine("1- 5nombres while");
Console.WriteLine("2- el 1 con for");
Console.WriteLine("3- nombre y edad while");
Console.WriteLine("4- el 3 pero con for");
Console.WriteLine("5 - numero y suma vector");
Console.WriteLine("0- salir");

 sel = int.Parse(Console.ReadLine());
    Console.Clear();
    switch (sel) {

        case 1:

            int nomingresados=0;
            string nombres;
            string[] nombrescancion = new string[5];
            while (nomingresados < 5)
            {
                Console.WriteLine("ingrese el nombre de 5 canciones!");
                nombres = Console.ReadLine();
                nombrescancion[nomingresados] = nombres;
                nomingresados++;
            }
            Console.WriteLine("los datos ingresados han sido guardados!");
            Console.ReadKey();
            break;
        case 2:
            string nombres2;
            string[] nombrescancion2 = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ingrese el nombre de 5 canciones!");
                nombres2 = Console.ReadLine();
                nombrescancion2[i]= nombres2;

            }
            Console.WriteLine("los datos ingresados han sido guardados!");
            Console.ReadKey();

            break;
        case 3:
            int[] edades = new int[5];
            string[] nombre = new string[5];
            string nom;
            int vecesrepetidas=0,edad;
            while (vecesrepetidas < 5)
            {
                Console.WriteLine("ingrese el nombre de la persona");
                nom= Console.ReadLine();
                nombre[vecesrepetidas] = nom;
                Console.WriteLine("ingrese la edad de esta persona");
                edad = int.Parse(Console.ReadLine());
                edades[vecesrepetidas] = edad;

            }
            Console.WriteLine("todos los datos han sido guardados!");
            Console.ReadKey();

            break;
        case 4:
            int[] edades2 = new int[5];
            string[] nombre2 = new string[5];
            string nom2;
            int  edad2;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ingrese el nombre de la persona");
                nom2 = Console.ReadLine();
                nombre2[i] = nom2;
                Console.WriteLine("ingrese la edad de esta persona");
                edad2 = int.Parse(Console.ReadLine());
                edades2[i] = edad2;

            }
            Console.WriteLine("todos los datos han sido guardados!");
            Console.ReadKey();

            break;
        case 5:
            int[] NUM1 = new int[5];
            int[] NUM2 = new int[5];
            int[] SUMA = new int[5];
            int num1, num2,resultado;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ingrese el primer numero");
                num1 = int.Parse(Console.ReadLine());
                NUM1[i] = num1;
                Console.WriteLine("ingrese el segundo numero");
                num2 = int.Parse(Console.ReadLine());
                NUM2[i] = num2;
                resultado = NUM1[i] + NUM2[i];
                SUMA[i] = resultado;
            }
            Console.Clear();
            for (int f = 0; f < 5; f++)
            {
                Console.WriteLine("la suma en la posicion "+f+" dio como resultado = " + SUMA[f]);

            }
            Console.ReadKey ();
           
            break;

     }

}
Console.ReadKey();
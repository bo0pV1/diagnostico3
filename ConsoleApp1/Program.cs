
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
            while (nomingresados >= 5)
            {
                Console.WriteLine("ingrese el nombre de 5 canciones!");
                nombres = Console.ReadLine();
                nombrescancion[nomingresados] = nombres;
                nomingresados++;
            }
            Console.WriteLine("cancion 1:" + nombrescancion[1]);
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
            break;

     }
}
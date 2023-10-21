using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
public class Gerrero
{
    public string player { get; set;}

    public int  vida{ get; set;}
     
    public Gerrero ( string name ,int heart)
    {
        player=name;
        vida=heart;
         
    }
  //cree este atributo para que la batalla sea completamente ramdom utilizando un arreglo y el metodo ramdom.next
    public int fuerzaGolpe ()
    {
        
        int[] opciones = new[] { 10, 30, 60, 100 };
       Random fuerza = new Random();
        return opciones[fuerza.Next(0, 4)];
        
    }

    public void RecibeAtaque( int ataque)
    {
       vida-= ataque;
    }
  //use estos metodos para quee se me hiciese mas ficil entender el codigo 
     public int getVida()
    {
        return vida;
    }
    public string getplayer()
    {
        return player;
    }
}
class Enfrentamiento 
{
    public void Iniciar (Gerrero guerrero1,Gerrero guerrero2)
    {
        Console.WriteLine($"comienza el enfrentamiento entre "+ guerrero1.getplayer()+ " y " +guerrero2.getplayer() );
      /*use este buble while para inicar el proceso de batalla */
        while( guerrero1.getVida() > 0 && guerrero2.getVida() > 0) 
        {
            int guerrero1kd = guerrero1.fuerzaGolpe();
            int guerrero2kd = guerrero2.fuerzaGolpe();
        
        guerrero1.RecibeAtaque(guerrero2kd);
        guerrero2.RecibeAtaque(guerrero1kd);

        Console.WriteLine(guerrero1.getplayer() + "ataca a "+ guerrero2.getplayer()+ " y le hace "+ guerrero1kd + "de danio");
        Console.WriteLine(guerrero2.getplayer() + "ataca a "+ guerrero1.getplayer()+ " y le hace "+ guerrero2kd + "de danio");
        Console.WriteLine( guerrero1.getplayer()+ "tiene "+ guerrero1.getVida()+ " restante ");
        Console.WriteLine( guerrero2.getplayer()+ "tiene "+ guerrero2.getVida()+ " restante ");
                   
     }
     if ( guerrero1.getVida() >= 0 && guerrero2.getVida()>= 0)
     {
        Console.WriteLine("hambos guerreros calleron es un empate");
     }
        else if ( guerrero1.getVida()<=0 )
        {
            Console.WriteLine(guerrero2.getplayer()+ " es el ganador de la batalla");
        }
        else 
        {
            Console.WriteLine( guerrero1.getplayer()+ " es el ganador de la batalla");
        }
    }
}
public class Program 
{
    static public void Main()
    {
      //por ultimo tenemos las cualidades de los gerreros 
        Gerrero gerrero1 = new Gerrero("piccaso", 100);
        Gerrero gerrero2 = new Gerrero("neruda", 98);

        Enfrentamiento enfrentamiento = new Enfrentamiento();
        enfrentamiento.Iniciar( gerrero1,gerrero2);

    }
}

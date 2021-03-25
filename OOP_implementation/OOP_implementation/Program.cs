using System;

namespace OOP_implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstraccion y Encapsulacion.
            Bicicleta trek=new Bicicleta();
            Console.WriteLine(trek.Tamnio(17.5));
            Console.WriteLine(trek.Transmision(27)); 

            trek.Comprar();

            Console.WriteLine(trek.EmisionesCO2()); 

            //Herencia y Polimorfismo.
            MedioTransporte medioTransporte= new Bicicleta();
            ITransporteEcologico transporteEcologico=new Bicicleta();

            Console.WriteLine(medioTransporte.Frenar()); 
        }
    }
}

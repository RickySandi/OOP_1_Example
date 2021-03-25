using System;
namespace OOP_implementation
{
    public class Bicicleta: MedioTransporte, ITransporteEcologico
    {
        //Atributos
        private double _precio;

        public double Talla=0;
        public double Peso;
        public int Velocidades=0;
        public double KmHora;
        public bool vendida = false; 


        public Bicicleta()   //Constructor 
        {
            _precio = 1500;
        }
        public string Tamnio (double tam)
        {
            return "Esta bici es de talla " + tam;

        }
        public string Transmision(int vel)
        {

            return "Esta bici tiene velocidades = " +vel;

        }
        public string Comprar()
        {
            vendida = true; 
            return "Gracias por su compra";
        }
       public  string EmisionesCO2()
        {
            return "No emite CO2";
        }
    }
}

using System;
namespace Ejercicio.models
{
    public class Car
    {
        public String marca { get; set; }
        public String modelo { get; set; }
        public String anio { get; set; }

        public override string ToString()
        {
            return marca;
        }
    }
}

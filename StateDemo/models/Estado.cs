using System;
using System.Collections.Generic;
using System.Text;

namespace StateDemo.models
{
    public abstract class Estado
    {
        protected Agua agua;
        protected double temperaturaActual;
        protected double temperaturaMinima;
        protected double temperaturaMaxima;

        public Agua Agua
        {
            set { agua = value; }
            get { return agua; }
        }

        public double TemperaturaActual
        {
            set { temperaturaActual = value; }
            get { return temperaturaActual; }
        }

        public abstract void SubirTemperatura(double temperatura);
        public abstract void BajarTemperatura(double temperatura);
    }
}

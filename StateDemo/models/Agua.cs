using System;
using System.Collections.Generic;
using System.Text;

namespace StateDemo.models
{
    public class Agua
    {
        private Estado _estado;

        public Estado EstadoActual
        {
            set { _estado = value; }
            get { return _estado; }
        }

        public Agua()
        {
            this._estado = new Solido(0, this);
        }

        public void SubirTemperatura(double temperatura)
        {
            _estado.SubirTemperatura(temperatura);
            Console.WriteLine($"Incrementar Temperatura en {temperatura}");
            Console.WriteLine($"Temperatura Actual: {_estado.TemperaturaActual}");
            Console.WriteLine($"Estado Actual: {EstadoActual.GetType().Name}");
            Console.WriteLine($"");
        }
        public void BajarTemperatura(double temperatura)
        {
            _estado.BajarTemperatura(temperatura);
            Console.WriteLine($"Decrementar Temperatura en {temperatura}");
            Console.WriteLine($"Temperatura Actual: {_estado.TemperaturaActual}");
            Console.WriteLine($"Estado Actual: {EstadoActual.GetType().Name}");
            Console.WriteLine($"");
        }
    }
}

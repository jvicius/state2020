using System;
using System.Collections.Generic;
using System.Text;

namespace StateDemo.models
{
    public class Gaseoso : Estado
    {
        public Gaseoso(double temperaturaActual, Agua agua)
        {
            this.temperaturaActual = temperaturaActual;
            this.agua = agua;
            this.temperaturaMinima = 101;
            this.temperaturaMaxima = 1000;
        }
        public override void BajarTemperatura(double temperatura)
        {
            temperaturaActual -= temperatura;
            if(temperaturaActual< temperaturaMinima)
            {
                agua.EstadoActual = new Liquido(temperaturaActual, agua);
            }
        }

        public override void SubirTemperatura(double temperatura)
        {
            temperaturaActual += temperatura;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace StateDemo.models
{
    public class Liquido : Estado
    {
        public Liquido(double temperaturaActual, Agua agua)
        {
            this.temperaturaActual = temperaturaActual;
            this.agua = agua;
            this.temperaturaMinima = 1;
            this.temperaturaMaxima = 100;
        }

        public override void BajarTemperatura(double temperatura)
        {
            temperaturaActual -= temperatura;
            if(temperaturaActual < temperaturaMinima)
            {
                agua.EstadoActual = new Solido(temperaturaActual, agua);
            }
        }

        public override void SubirTemperatura(double temperatura)
        {
            temperaturaActual += temperatura;
            if (temperaturaActual>temperaturaMaxima)
            {
                agua.EstadoActual = new Gaseoso(temperaturaActual, agua);
            }
        }
    }
}

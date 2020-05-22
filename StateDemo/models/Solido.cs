using System;
using System.Collections.Generic;
using System.Text;

namespace StateDemo.models
{
    public class Solido : Estado
    {
        public Solido(double temperaturaActual, Agua agua)
        {
            this.temperaturaActual = temperaturaActual;
            this.agua = agua;
            this.temperaturaMinima = -273;
            this.temperaturaMaxima = 0;
        }

        public override void BajarTemperatura(double temperatura)
        {
            temperaturaActual -= temperatura;
        }

        public override void SubirTemperatura(double temperatura)
        {
            temperaturaActual += temperatura;
            if (temperaturaActual > temperaturaMaxima)
            {
                agua.EstadoActual = new Liquido(temperaturaActual, agua);
            }
        }
    }
}

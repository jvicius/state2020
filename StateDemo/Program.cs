using StateDemo.models;
using System;

namespace StateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var agua = new Agua();
            agua.BajarTemperatura(10);
            agua.SubirTemperatura(20);
            agua.SubirTemperatura(20);
            agua.SubirTemperatura(20);
            agua.SubirTemperatura(20);
            agua.SubirTemperatura(20);
            agua.SubirTemperatura(20);
            agua.SubirTemperatura(20);
            agua.SubirTemperatura(20);
            agua.SubirTemperatura(20);
            agua.SubirTemperatura(20);
            agua.BajarTemperatura(20);
            agua.BajarTemperatura(20);
            agua.BajarTemperatura(20);
            agua.BajarTemperatura(20);
            agua.BajarTemperatura(20);
            agua.BajarTemperatura(20);

        }
    }
}

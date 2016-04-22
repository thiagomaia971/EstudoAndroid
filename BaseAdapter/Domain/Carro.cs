using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Carro
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Image { get; set; }

        public Carro(string modelo, string marca, int image)
        {
            Modelo = modelo;
            Marca = marca;
            Image = image;
        }
    }
}

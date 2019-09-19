using System;
using System.Collections.Generic;
using System.Text;

namespace trabprog1
{
    class Carro
    {
        public string ID { get; set; }
        public string Modelo { get; set; }
        public string Quilometragem { get; set; }
        public string Ano { get; set; }
        public float Juros { get; set; }
        public string Data { get; set; }


        public override string ToString()
        {
            return "ID: " + ID + ", Modelo: " + Modelo 
                + ", Quilometragem: " + Quilometragem + ", Ano: " + Ano 
                + ", Juros à prazo: " + Juros + "%" + ", Data de acesso: " + Data;
        }
    }
}

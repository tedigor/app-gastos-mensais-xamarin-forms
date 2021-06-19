using System;
using System.Collections.Generic;
using System.Text;

namespace App_Gastos_Mensais.Models
{
    public class Compra
    {
        public DateTime DataDeRegistro { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }

        public Compra(double preco, string descricao)
        {
            Preco = preco;
            Descricao = descricao;
            DataDeRegistro = DateTime.Now;
        }
    }
}

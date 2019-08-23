using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploWebAPI.Models
{
    public class Cliente
    {
        public string Nome { get; set; }

        public Cliente(string texto)
        {
            this.Nome = texto;

        }
    }
}

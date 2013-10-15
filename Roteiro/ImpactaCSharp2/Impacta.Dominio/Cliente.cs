using System;
using System.Runtime.CompilerServices;

namespace Impacta.Dominio
{
    //[TypeForwardedTo(typeof(Impacta.Infra.))]
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Impacta.Repositorios.Ef.Designer
{
    using System;
    using System.Collections.Generic;
    
    public partial class PessoaEnderecos
    {
        public int Id { get; set; }
        public int Tipo { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
    
        public virtual Cidade Cidade { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
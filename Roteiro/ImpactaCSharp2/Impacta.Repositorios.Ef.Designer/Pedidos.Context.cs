﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PedidosEntities : DbContext
    {
        public PedidosEntities()
            : base("name=PedidosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<ItensPedido> ItensPedido { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<PessoaDocumentos> PessoaDocumentos { get; set; }
        public DbSet<PessoaEnderecos> PessoaEnderecos { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<TipoProduto> TipoProduto { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
    }
}

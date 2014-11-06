using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Impacta.Dominio;

namespace Impacta.Repositorios.Ef.Designer.Testes
{
    [TestClass]
    public class ClienteRepositorioTestes
    {
        [TestMethod]
        public void InserirTeste()
        {
            using (var db = new PedidosEntities())
            {
                var cliente = new Cliente();

                var pessoa = new Pessoa();
                pessoa.Email = "avelino.vitor@gmail.com";
                pessoa.Nome = "Vítor";

                cliente.Pessoa = pessoa;

                db.Clientes.Add(cliente);
                db.SaveChanges();
            }
        }

        [TestMethod]
        public void AtualizarTeste()
        {
            using (var db = new PedidosEntities())
            {
                var cliente = db.Clientes.Single(c => c.Id == 3);

                var documento = new PessoaDocumento();
                documento.Numero = "12845662858";
                documento.Tipo = (int)TipoDocumento.Cpf;

                cliente.Pessoa.PessoaDocumentos.Add(documento);
                cliente.Pessoa.Nome = "Vítor Avelino";

                db.SaveChanges();
            }
        }

        [TestMethod]
        public void SelecionarTeste()
        {
            using (var db = new PedidosEntities())
            {
                var clientes = db.Clientes.Where(c => c.Pessoa.Nome.Contains("v"));

                foreach (var cliente in clientes)
                {
                    Console.WriteLine(cliente.Pessoa.Nome);
                }

                var documentos = db.PessoaDocumentos.Where(pd => pd.Numero == "12845662858");

                foreach (var documento in documentos)
                {
                    Console.WriteLine(documento.Pessoa.Nome);
                }
            }
        }

        [TestMethod]
        public void ExcluirTeste()
        {
            using (var db = new PedidosEntities())
            {
                var cliente = db.Clientes.Single(c => c.Id == 8);
                var pessoa = cliente.Pessoa;

                db.Clientes.Remove(cliente);
                db.Pessoas.Remove(pessoa);

                db.SaveChanges();
            }
        }
    }
}
using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Impacta.Dominio;
using System.Transactions;

namespace Impacta.Repositorios.Ef.Designer.Testes
{
    [TestClass]
    public class ClienteRepositorioTestes
    {
        [TestMethod]
        public void InserirTeste()
        {
            using (var contexto = new PedidosEntities())
            {
                var cliente = new Cliente();

                var pessoa = new Pessoa();
                pessoa.Email = "avelino.vitor@gmail.com";
                pessoa.Nome = "Vítor";

                cliente.Pessoa = pessoa;

                contexto.Cliente.Add(cliente);
                contexto.SaveChanges();
            }
        }

        [TestMethod]
        public void AtualizarTeste()
        {
            using (var db = new PedidosEntities())
            {
                var cliente = db.Cliente.Single(c => c.Id == 1);

                var documento = new PessoaDocumentos();
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
                var clientes = db.Cliente.Where(c => c.Pessoa.Nome.Contains("v"));

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
                var cliente = db.Cliente.Single(c => c.Id == 8);
                var pessoa = cliente.Pessoa;

                db.Cliente.Remove(cliente);
                db.Pessoa.Remove(pessoa);

                db.SaveChanges();
            }
        }

        [TestMethod]
        public void AtualizarComTransacao()
        {
            using (var contexto = new PedidosEntities())
            {
                //contexto.SaveChanges() é transacionado com READ COMMITED.

                using (var transacao = new TransactionScope(TransactionScopeOption.Required,
                    new TransactionOptions { IsolationLevel = IsolationLevel.Serializable }))
                {
                    var vendedor = new Vendedor();

                    var pessoa = new Pessoa();
                    pessoa.Email = "avelino.vitor@gmail.com";
                    pessoa.Nome = "Outro Vendedor";
                    
                    vendedor.Pessoa = pessoa;

                    contexto.Vendedor.Add(vendedor);

                    //throw new Exception();
                    //rollback: transacao.Dispose();

                    vendedor.Pessoa.PessoaDocumentos.Add(new PessoaDocumentos { Numero = "1745", Tipo = (int)TipoDocumento.Cpf });

                    contexto.SaveChanges();

                    transacao.Complete();
                }
            }
        }
    }
}
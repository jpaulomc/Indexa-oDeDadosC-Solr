using CommonServiceLocator;
using Domain.Entities.Documentos;
using SolrNet;
using SolrNet.Commands.Parameters;
using System;

namespace ConsoleApplicationSolr
{
    class Program
    {
        static void Main(string[] args)
        {

            //Inicializando a instância do solr.
            Startup.Init<CustomerDocument>("http://localhost:8983/solr/CustomerCollection02");

            //Recuperando a instância do solr.
            var customerSolr = ServiceLocator.Current.GetInstance<ISolrOperations<CustomerDocument>>();

            //Definindo os parâmetros de consulta.
            var queryOptions = new QueryOptions();
            queryOptions = new QueryOptions();
            queryOptions.Rows = 100;
            queryOptions.StartOrCursor = new StartOrCursor.Start(0);



            //Criação do objeto cliente para teste.
            var cliente = new CustomerDocument()
            {
                ID = 1,
                PersonID = 1,
                TerritoryID = 3,
                AccountNumber = "A151DAS515",
                RowGuid = new Guid(),
                ModifiedDate = DateTime.Now
            };


            //Adicionando o objeto a collection no Solr.
            customerSolr.Add(cliente);
            customerSolr.Commit();

            //Consultando os dados no solr
            var resultado = customerSolr.Query(SolrQuery.All, queryOptions);


            //Exibindo os dados.
            Console.WriteLine(resultado);

        }
    }
}

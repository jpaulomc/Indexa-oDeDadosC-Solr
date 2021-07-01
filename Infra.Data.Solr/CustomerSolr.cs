using Domain.Entities.Documentos;
using Domain.Interfaces.Solr;
using SolrNet;

namespace Infra.Data.Solr
{
    public class CustomerSolr : SolrDocumentBase<CustomerDocument>, ICustomerSolr
    {
        public CustomerSolr(ISolrOperations<CustomerDocument> solr) : base(solr)
        {
        }
    }
}

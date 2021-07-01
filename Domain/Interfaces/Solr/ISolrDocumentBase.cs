using Domain.Entities.Documentos;
using SolrNet;
using SolrNet.Commands.Parameters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Solr
{
    public interface ISolrDocumentBase<TD> where TD : DocumentBase
    {
        Task AdicionarAsync(IEnumerable<TD> documents);
        Task AdicionarAsync(TD document);
        Task DeleteAsync(TD document);
        void Delete(TD document);
        void Commit();
        Task CommitAsync();
        Task<SolrQueryResults<TD>> QueryAsync(ISolrQuery query, QueryOptions queryOptions);
    }
}

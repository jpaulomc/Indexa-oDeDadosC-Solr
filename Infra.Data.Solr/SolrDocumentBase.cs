using Domain.Entities.Documentos;
using Domain.Interfaces.Solr;
using SolrNet;
using SolrNet.Commands.Parameters;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Data.Solr
{
    public abstract class SolrDocumentBase<TD> : ISolrDocumentBase<TD> where TD : DocumentBase
    {
        protected readonly ISolrOperations<TD> _solr;

        public SolrDocumentBase(ISolrOperations<TD> solr)
        {
            _solr = solr;
        }

        public async Task AdicionarAsync(IEnumerable<TD> documents)
        {
            await _solr.AddRangeAsync(documents);
        }

        public async Task AdicionarAsync(TD document)
        {
            await _solr.AddAsync(document);
        }

        public void Commit()
        {
            _solr.Commit();
        }

        public async Task CommitAsync()
        {
            await _solr.CommitAsync();
        }

        public void Delete(TD document)
        {
            _solr.Delete(document);
        }

        public async Task DeleteAsync(TD document)
        {
            await _solr.DeleteAsync(document);
        }

        public async Task<SolrQueryResults<TD>> QueryAsync(ISolrQuery query, QueryOptions queryOptions)
        {
            var resultado = await _solr.QueryAsync(query, queryOptions);
            return resultado;
        }
    }
}

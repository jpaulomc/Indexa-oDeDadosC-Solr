using SolrNet.Attributes;
using System;

namespace Domain.Entities.Documentos
{
    public class CustomerDocument : DocumentBase
    {
        [SolrField("Customer_ID")]
        public override int ID { get; set; }

        [SolrField("Customer_PersonID")]
        public int PersonID { get; set; }

        [SolrField("Customer_StoreID")]
        public int StoreID { get; set; }

        [SolrField("Customer_TerritoryID")]
        public int TerritoryID { get; set; }

        [SolrField("Customer_AccountNumber")]
        public string AccountNumber { get; set; }

        [SolrField("Customer_RowGuid")]
        public Guid RowGuid { get; set; }

        [SolrField("Customer_ModifiedDate")]
        public DateTime ModifiedDate { get; set; }
    }
}

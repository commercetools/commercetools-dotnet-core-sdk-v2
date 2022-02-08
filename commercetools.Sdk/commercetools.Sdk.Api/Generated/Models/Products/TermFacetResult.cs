using System.Collections.Generic;


namespace commercetools.Api.Models.Products
{
    public partial class TermFacetResult : ITermFacetResult
    {
        public IFacetTypes Type { get; set; }

        public ITermFacetResultType DataType { get; set; }

        public long Missing { get; set; }

        public long Total { get; set; }

        public long Other { get; set; }

        public List<IFacetTerm> Terms { get; set; }
        public TermFacetResult()
        {
            this.Type = IFacetTypes.FindEnum("terms");
        }
    }
}

using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class TermFacetResult : ITermFacetResult
    {
        public IFacetTypes Type { get; set; }

        public ITermFacetResultType DataType { get; set; }

        public long Missing { get; set; }

        public long Total { get; set; }

        public long Other { get; set; }

        public IList<IFacetTerm> Terms { get; set; }
        public IEnumerable<IFacetTerm> TermsEnumerable { set => Terms = value.ToList(); }

        public TermFacetResult()
        {
            this.Type = IFacetTypes.FindEnum("terms");
        }
    }
}

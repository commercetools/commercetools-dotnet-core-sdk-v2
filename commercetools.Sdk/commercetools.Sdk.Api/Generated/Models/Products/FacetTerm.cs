using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class FacetTerm : IFacetTerm
    {
        public Object Term { get; set; }

        public long Count { get; set; }

        public long? ProductCount { get; set; }
    }
}

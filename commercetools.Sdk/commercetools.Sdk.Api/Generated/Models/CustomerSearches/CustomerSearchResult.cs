using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.CustomerSearches
{

    public partial class CustomerSearchResult : ICustomerSearchResult
    {
        public string Id { get; set; }

        public decimal Relevance { get; set; }
    }
}

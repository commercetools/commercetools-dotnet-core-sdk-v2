using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.CustomerSearches
{

    public partial class CustomerIndexingProgress : ICustomerIndexingProgress
    {
        public int Indexed { get; set; }

        public int Failed { get; set; }

        public int EstimatedTotal { get; set; }
    }
}

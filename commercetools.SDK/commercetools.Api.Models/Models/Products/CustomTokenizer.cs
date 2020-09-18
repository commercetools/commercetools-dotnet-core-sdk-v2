using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("custom")]
    public class CustomTokenizer : SuggestTokenizer
    {
        public List<string> Inputs { get; set;}
    }
}

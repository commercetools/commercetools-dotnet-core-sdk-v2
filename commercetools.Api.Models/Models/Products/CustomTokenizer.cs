using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Products
{
    public class CustomTokenizer : SuggestTokenizer
    {
        public List<string> Inputs { get; set;}
    }
}

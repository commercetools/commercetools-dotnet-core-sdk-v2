using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("whitespace")]
    public partial class WhitespaceTokenizer : SuggestTokenizer
    {
        public WhitespaceTokenizer()
        { 
           this.Type = "whitespace";
        }
    }
}

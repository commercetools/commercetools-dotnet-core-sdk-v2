using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("custom")]
    public partial class CustomTokenizer : SuggestTokenizer
    {
        public List<string> Inputs { get; set;}
        public CustomTokenizer()
        { 
           this.Type = "custom";
        }
    }
}

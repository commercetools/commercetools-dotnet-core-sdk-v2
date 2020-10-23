using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public  partial class WhitespaceTokenizer : IWhitespaceTokenizer
    {
        public string Type { get; set;}
        public WhitespaceTokenizer()
        { 
           this.Type = "whitespace";
        }
    }
}

using commercetools.ImportApi.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Products
{
    public partial class CustomTokenizer : ICustomTokenizer
    {
        public string Type { get; set;}
        
        public List<string> Inputs { get; set;}
        public CustomTokenizer()
        { 
           this.Type = "custom";
        }
    }
}

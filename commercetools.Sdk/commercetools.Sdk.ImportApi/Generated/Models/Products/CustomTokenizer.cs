using commercetools.Sdk.ImportApi.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Products
{

    public partial class CustomTokenizer : ICustomTokenizer
    {
        public string Type { get; set; }

        public IList<string> Inputs { get; set; }
        public IEnumerable<string> InputsEnumerable { set => Inputs = value.ToList(); }

        public CustomTokenizer()
        {
            this.Type = "custom";
        }
    }
}

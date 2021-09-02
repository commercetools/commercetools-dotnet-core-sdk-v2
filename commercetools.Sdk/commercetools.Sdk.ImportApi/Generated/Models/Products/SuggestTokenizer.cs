using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Products
{
    public partial class SuggestTokenizer : ISuggestTokenizer
    {
        public string Type { get; set; }
    }
}

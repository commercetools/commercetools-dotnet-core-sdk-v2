using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public partial class SearchKeyword 
    {
        public string Text { get; set;}
        
        public Object SuggestTokenizer { get; set;}
    }
}

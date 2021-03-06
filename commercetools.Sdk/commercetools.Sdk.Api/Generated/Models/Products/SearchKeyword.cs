using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public partial class SearchKeyword : ISearchKeyword
    {
        public string Text { get; set;}
        
        public ISuggestTokenizer SuggestTokenizer { get; set;}
    }
}

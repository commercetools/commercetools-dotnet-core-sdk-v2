using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Products
{
    public class SearchKeyword 
    {
        public string Text { get; set;}
        
        public Object SuggestTokenizer { get; set;}
    }
}

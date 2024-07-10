using commercetools.Sdk.ImportApi.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Products
{

    public partial class SearchKeyword : ISearchKeyword
    {
        public string Text { get; set; }

        public ISuggestTokenizer SuggestTokenizer { get; set; }
    }
}

using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    public partial class SearchKeyword : ISearchKeyword
    {
        public string Text { get; set;}
        
        public ISuggestTokenizer SuggestTokenizer { get; set;}
    }
}

using commercetools.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
{
    public  partial class TaxCategoryPagedQueryResponse : ITaxCategoryPagedQueryResponse
    {
        public long Limit { get; set;}
        
        public long Count { get; set;}
        
        public long? Total { get; set;}
        
        public long Offset { get; set;}
        
        public List<ITaxCategory> Results { get; set;}
    }
}

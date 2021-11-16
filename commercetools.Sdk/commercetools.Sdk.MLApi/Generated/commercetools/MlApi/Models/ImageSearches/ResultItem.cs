using commercetools.MLApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.ImageSearches
{
    public partial class ResultItem : IResultItem
    {
        public string ImageUrl { get; set;}
        
        public List<IProductVariant> ProductVariants { get; set;}
    }
}

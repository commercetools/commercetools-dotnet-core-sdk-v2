using commercetools.Ml.Models.GeneralCategoryRecommendations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.GeneralCategoryRecommendations
{
    public partial class GeneralCategoryRecommendationPagedQueryResponse : IGeneralCategoryRecommendationPagedQueryResponse
    {
        public long Count { get; set;}
        
        public long Total { get; set;}
        
        public long Offset { get; set;}
        
        public List<IGeneralCategoryRecommendation> Results { get; set;}
    }
}

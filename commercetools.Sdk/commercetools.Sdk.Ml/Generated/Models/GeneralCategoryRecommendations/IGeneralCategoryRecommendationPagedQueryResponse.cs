using commercetools.Ml.Models.GeneralCategoryRecommendations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.GeneralCategoryRecommendations
{
    [DeserializeAs(typeof(commercetools.Ml.Models.GeneralCategoryRecommendations.GeneralCategoryRecommendationPagedQueryResponse))]
    public partial interface IGeneralCategoryRecommendationPagedQueryResponse 
    {
        long Count { get; set;}
        
        long Total { get; set;}
        
        long Offset { get; set;}
        
        List<IGeneralCategoryRecommendation> Results { get; set;}
    }
}

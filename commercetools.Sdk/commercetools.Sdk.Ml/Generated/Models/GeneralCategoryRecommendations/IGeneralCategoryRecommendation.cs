using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.GeneralCategoryRecommendations
{
    [DeserializeAs(typeof(commercetools.Ml.Models.GeneralCategoryRecommendations.GeneralCategoryRecommendation))]
    public partial interface IGeneralCategoryRecommendation 
    {
        string CategoryName { get; set;}
        
        double Confidence { get; set;}
    }
}

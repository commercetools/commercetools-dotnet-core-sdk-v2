using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.GeneralCategoryRecommendations
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.GeneralCategoryRecommendations.GeneralCategoryRecommendation))]
    public partial interface IGeneralCategoryRecommendation 
    {
        string CategoryName { get; set;}
        
        double Confidence { get; set;}
    }
}

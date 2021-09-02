using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.GeneralCategoryRecommendations
{
    public partial class GeneralCategoryRecommendation : IGeneralCategoryRecommendation
    {
        public string CategoryName { get; set; }

        public double Confidence { get; set; }
    }
}

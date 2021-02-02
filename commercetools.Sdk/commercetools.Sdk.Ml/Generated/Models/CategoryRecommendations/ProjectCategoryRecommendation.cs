using commercetools.Ml.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.CategoryRecommendations
{
    public partial class ProjectCategoryRecommendation : IProjectCategoryRecommendation
    {
        public ICategoryReference Category { get; set;}
        
        public double Confidence { get; set;}
        
        public string Path { get; set;}
    }
}

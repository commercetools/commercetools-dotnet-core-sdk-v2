using commercetools.MLApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.CategoryRecommendations
{
    public partial class ProjectCategoryRecommendation : IProjectCategoryRecommendation
    {
        public ICategoryReference Category { get; set;}
        
        public double Confidence { get; set;}
        
        public string Path { get; set;}
    }
}

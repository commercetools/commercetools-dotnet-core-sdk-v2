using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.CategoryRecommendations
{
    public partial class ProjectCategoryRecommendationMeta : IProjectCategoryRecommendationMeta
    {
        public string ProductName { get; set; }

        public string ProductImageUrl { get; set; }

        public List<string> GeneralCategoryNames { get; set; }
    }
}

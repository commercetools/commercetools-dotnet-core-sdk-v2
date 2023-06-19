using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.MLApi.Models.GeneralCategoryRecommendations
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.GeneralCategoryRecommendations.GeneralCategoryRecommendationPagedQueryResponse))]
    public partial interface IGeneralCategoryRecommendationPagedQueryResponse
    {
        long Count { get; set; }

        long Total { get; set; }

        long Offset { get; set; }

        IList<IGeneralCategoryRecommendation> Results { get; set; }
        IEnumerable<IGeneralCategoryRecommendation> ResultsEnumerable { set => Results = value.ToList(); }


    }
}

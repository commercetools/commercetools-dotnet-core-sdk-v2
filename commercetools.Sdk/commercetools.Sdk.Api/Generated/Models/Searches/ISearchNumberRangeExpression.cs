using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Searches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Searches.SearchNumberRangeExpression))]
    public partial interface ISearchNumberRangeExpression : ISearchQueryExpression
    {
        ISearchNumberRangeValue Range { get; set; }

    }
}

using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnitSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnitSearches.BusinessUnitIndexingProgress))]
    public partial interface IBusinessUnitIndexingProgress
    {
        int Indexed { get; set; }

        int Failed { get; set; }

        int EstimatedTotal { get; set; }

    }
}

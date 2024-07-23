using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitResourceIdentifier))]
    public partial interface IBusinessUnitResourceIdentifier : IResourceIdentifier
    {
        new string Id { get; set; }

        new string Key { get; set; }

    }
}

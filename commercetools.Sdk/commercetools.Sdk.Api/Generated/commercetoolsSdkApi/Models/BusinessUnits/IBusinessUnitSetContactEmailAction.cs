using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetContactEmailAction))]
    public partial interface IBusinessUnitSetContactEmailAction : IBusinessUnitUpdateAction
    {
        string ContactEmail { get; set; }

    }
}

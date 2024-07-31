using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetAddressCustomFieldAction))]
    public partial interface IBusinessUnitSetAddressCustomFieldAction : IBusinessUnitUpdateAction
    {
        string AddressId { get; set; }

        string Name { get; set; }

        Object Value { get; set; }

    }
}

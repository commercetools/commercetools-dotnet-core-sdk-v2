using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitSetAddressCustomFieldAction))]
    public partial interface IMyBusinessUnitSetAddressCustomFieldAction : IMyBusinessUnitUpdateAction
    {
        string AddressId { get; set; }

        string Name { get; set; }

        Object Value { get; set; }

    }
}

using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitSetCustomFieldAction))]
    public partial interface IBusinessUnitSetCustomFieldAction : IBusinessUnitUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}

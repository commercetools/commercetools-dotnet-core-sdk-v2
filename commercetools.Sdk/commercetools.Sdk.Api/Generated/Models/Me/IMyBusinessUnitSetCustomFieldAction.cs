using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitSetCustomFieldAction))]
    public partial interface IMyBusinessUnitSetCustomFieldAction : IMyBusinessUnitUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}

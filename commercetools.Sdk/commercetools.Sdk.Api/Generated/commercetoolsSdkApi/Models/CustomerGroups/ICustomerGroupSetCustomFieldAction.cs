using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CustomerGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupSetCustomFieldAction))]
    public partial interface ICustomerGroupSetCustomFieldAction : ICustomerGroupUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}

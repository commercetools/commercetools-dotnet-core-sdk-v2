using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditSetCustomFieldAction))]
    public partial interface IOrderEditSetCustomFieldAction : IOrderEditUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}

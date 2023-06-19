using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCartSetCustomFieldAction))]
    public partial interface IMyCartSetCustomFieldAction : IMyCartUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}

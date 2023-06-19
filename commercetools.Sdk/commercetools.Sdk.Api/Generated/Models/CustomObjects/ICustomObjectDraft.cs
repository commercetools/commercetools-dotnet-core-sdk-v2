using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CustomObjects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CustomObjects.CustomObjectDraft))]
    public partial interface ICustomObjectDraft
    {
        string Container { get; set; }

        string Key { get; set; }

        Object Value { get; set; }

        long? Version { get; set; }

    }
}

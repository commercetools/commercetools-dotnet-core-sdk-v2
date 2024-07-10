using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

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

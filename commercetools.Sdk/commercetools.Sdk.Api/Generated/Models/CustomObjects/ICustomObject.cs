using commercetools.Sdk.Api.Models.Common;
using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CustomObjects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CustomObjects.CustomObject))]
    public partial interface ICustomObject : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        ICreatedBy CreatedBy { get; set; }

        string Container { get; set; }

        string Key { get; set; }

        Object Value { get; set; }

    }
}

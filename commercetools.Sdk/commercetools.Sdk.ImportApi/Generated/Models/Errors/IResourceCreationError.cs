using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Errors.ResourceCreationError))]
    public partial interface IResourceCreationError : IErrorObject
    {
        Object Resource { get; set; }

    }
}

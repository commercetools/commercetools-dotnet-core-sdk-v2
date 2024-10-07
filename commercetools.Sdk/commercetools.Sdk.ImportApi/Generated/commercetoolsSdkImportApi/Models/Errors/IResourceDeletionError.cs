using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Errors.ResourceDeletionError))]
    public partial interface IResourceDeletionError : IErrorObject
    {
        Object Resource { get; set; }

    }
}

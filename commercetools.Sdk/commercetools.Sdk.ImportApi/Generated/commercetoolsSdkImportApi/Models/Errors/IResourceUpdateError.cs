using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Errors.ResourceUpdateError))]
    public partial interface IResourceUpdateError : IErrorObject
    {
        Object Resource { get; set; }

    }
}

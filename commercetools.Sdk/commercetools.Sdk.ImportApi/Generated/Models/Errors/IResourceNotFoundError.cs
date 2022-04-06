using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Errors.ResourceNotFoundError))]
    public partial interface IResourceNotFoundError : IErrorObject
    {
        Object Resource { get; set; }
    }
}

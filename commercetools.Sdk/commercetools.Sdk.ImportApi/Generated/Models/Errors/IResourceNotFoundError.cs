using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Errors.ResourceNotFoundError))]
    public partial interface IResourceNotFoundError : IErrorObject
    {
        Object Resource { get; set;}
    }
}

using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Errors.ResourceCreationError))]
    public partial interface IResourceCreationError : IErrorObject
    {
        Object Resource { get; set;}
    }
}

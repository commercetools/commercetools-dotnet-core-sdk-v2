using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Errors.ResourceUpdateError))]
    public partial interface IResourceUpdateError : IErrorObject
    {
        Object Resource { get; set;}
    }
}

using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Errors.ResourceDeletionError))]
    public partial interface IResourceDeletionError : IErrorObject
    {
        Object Resource { get; set; }
    }
}

using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Extensions.ExtensionPagedQueryResponse))]
    public partial interface IExtensionPagedQueryResponse 
    {
        long Limit { get; set;}
        
        long Count { get; set;}
        
        long? Total { get; set;}
        
        long Offset { get; set;}
        
        List<IExtension> Results { get; set;}
    }
}

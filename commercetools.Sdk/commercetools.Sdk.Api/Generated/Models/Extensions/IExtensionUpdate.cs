using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Extensions.ExtensionUpdate))]
    public partial interface IExtensionUpdate 
    {
        long Version { get; set;}
        
        List<IExtensionUpdateAction> Actions { get; set;}
    }
}

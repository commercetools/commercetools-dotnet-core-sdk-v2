using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Extensions.ExtensionInput))]
    public partial interface IExtensionInput 
    {
        IExtensionAction Action { get; set;}
        
        IReference Resource { get; set;}
    }
}

using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionInput))]
    public partial interface IExtensionInput
    {
        IExtensionAction Action { get; set; }

        IReference Resource { get; set; }
    }
}

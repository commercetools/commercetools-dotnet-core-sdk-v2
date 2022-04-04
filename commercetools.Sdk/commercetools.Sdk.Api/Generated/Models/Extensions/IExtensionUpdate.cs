using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionUpdate))]
    public partial interface IExtensionUpdate
    {
        long Version { get; set; }

        List<IExtensionUpdateAction> Actions { get; set; }
    }
}

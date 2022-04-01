using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionTrigger))]
    public partial interface IExtensionTrigger
    {
        IExtensionResourceTypeId ResourceTypeId { get; set; }

        List<IExtensionAction> Actions { get; set; }
    }
}

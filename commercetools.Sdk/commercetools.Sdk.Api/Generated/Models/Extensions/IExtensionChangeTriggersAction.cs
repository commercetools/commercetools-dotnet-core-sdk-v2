using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Extensions.ExtensionChangeTriggersAction))]
    public partial interface IExtensionChangeTriggersAction : IExtensionUpdateAction
    {
        List<IExtensionTrigger> Triggers { get; set; }
    }
}

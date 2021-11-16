using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Extensions.ExtensionDraft))]
    public partial interface IExtensionDraft
    {
        string Key { get; set; }

        IExtensionDestination Destination { get; set; }

        List<IExtensionTrigger> Triggers { get; set; }

        int? TimeoutInMs { get; set; }
    }
}

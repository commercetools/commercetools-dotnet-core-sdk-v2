using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.Extensions.ExtensionUpdateAction))]
    [SubTypeDiscriminator("changeDestination", typeof(commercetools.Api.Models.Extensions.ExtensionChangeDestinationAction))]
    [SubTypeDiscriminator("changeTriggers", typeof(commercetools.Api.Models.Extensions.ExtensionChangeTriggersAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Api.Models.Extensions.ExtensionSetKeyAction))]
    [SubTypeDiscriminator("setTimeoutInMs", typeof(commercetools.Api.Models.Extensions.ExtensionSetTimeoutInMsAction))]
    public partial interface IExtensionUpdateAction
    {
        string Action { get; set; }
    }
}

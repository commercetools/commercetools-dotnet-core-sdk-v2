using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.Extensions.ExtensionHttpDestinationAuthentication))]
    [SubTypeDiscriminator("AuthorizationHeader", typeof(commercetools.Api.Models.Extensions.ExtensionAuthorizationHeaderAuthentication))]
    [SubTypeDiscriminator("AzureFunctions", typeof(commercetools.Api.Models.Extensions.ExtensionAzureFunctionsAuthentication))]
    public partial interface IExtensionHttpDestinationAuthentication 
    {
        string Type { get; set;}
    }
}

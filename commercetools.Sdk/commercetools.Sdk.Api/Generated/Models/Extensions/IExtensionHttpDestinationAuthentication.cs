using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [TypeDiscriminator(nameof(Type))]
    [SubTypeDiscriminator("AzureFunctions", typeof(commercetools.Api.Models.Extensions.ExtensionAzureFunctionsAuthentication))]
    [SubTypeDiscriminator("AuthorizationHeader", typeof(commercetools.Api.Models.Extensions.ExtensionAuthorizationHeaderAuthentication))]
    public interface IExtensionHttpDestinationAuthentication 
    {
        string Type { get; set;}
    }
}

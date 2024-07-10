using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Extensions
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Extensions.HttpDestinationAuthentication))]
    [SubTypeDiscriminator("AuthorizationHeader", typeof(commercetools.Sdk.Api.Models.Extensions.AuthorizationHeaderAuthentication))]
    [SubTypeDiscriminator("AzureFunctions", typeof(commercetools.Sdk.Api.Models.Extensions.AzureFunctionsAuthentication))]
    public partial interface IHttpDestinationAuthentication
    {
        string Type { get; set; }

        static commercetools.Sdk.Api.Models.Extensions.AuthorizationHeaderAuthentication AuthorizationHeader(Action<commercetools.Sdk.Api.Models.Extensions.AuthorizationHeaderAuthentication> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Extensions.AuthorizationHeaderAuthentication();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Extensions.AzureFunctionsAuthentication AzureFunctions(Action<commercetools.Sdk.Api.Models.Extensions.AzureFunctionsAuthentication> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Extensions.AzureFunctionsAuthentication();
            init?.Invoke(t);
            return t;
        }
    }
}

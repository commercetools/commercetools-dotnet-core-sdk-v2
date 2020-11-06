using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [TypeDiscriminator(nameof(Type))]
    [SubTypeDiscriminator("HTTP", typeof(commercetools.Api.Models.Extensions.ExtensionHttpDestination))]
    [SubTypeDiscriminator("AWSLambda", typeof(commercetools.Api.Models.Extensions.ExtensionAWSLambdaDestination))]
    public partial interface IExtensionDestination 
    {
        string Type { get; set;}
    }
}

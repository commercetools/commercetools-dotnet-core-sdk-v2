using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [TypeDiscriminator(nameof(Type))]
    [SubTypeDiscriminator("AWSLambda", typeof(commercetools.Api.Models.Extensions.ExtensionAWSLambdaDestination))]
    [SubTypeDiscriminator("HTTP", typeof(commercetools.Api.Models.Extensions.ExtensionHttpDestination))]
    public partial interface IExtensionDestination 
    {
        string Type { get; set;}
    }
}

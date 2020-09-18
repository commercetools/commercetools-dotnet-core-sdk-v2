using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [DiscriminatorValue("AWSLambda")]
    public class ExtensionAWSLambdaDestination : ExtensionDestination
    {
        public string Arn { get; set;}
        
        public string AccessKey { get; set;}
        
        public string AccessSecret { get; set;}
    }
}

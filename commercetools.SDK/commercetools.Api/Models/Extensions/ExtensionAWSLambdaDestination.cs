using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [DiscriminatorValue("AWSLambda")]
    public partial class ExtensionAWSLambdaDestination : ExtensionDestination
    {
        public string Arn { get; set;}
        
        public string AccessKey { get; set;}
        
        public string AccessSecret { get; set;}
        public ExtensionAWSLambdaDestination()
        { 
           this.Type = "AWSLambda";
        }
    }
}

using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Extensions
{
    public class ExtensionAWSLambdaDestination : ExtensionDestination
    {
        public string Arn { get; set;}
        
        public string AccessKey { get; set;}
        
        public string AccessSecret { get; set;}
    }
}

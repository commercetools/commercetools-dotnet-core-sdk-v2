using commercetools.Sdk.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Extensions
{

    public partial class AWSLambdaDestination : IAWSLambdaDestination
    {
        public string Type { get; set; }

        public string Arn { get; set; }

        public string AccessKey { get; set; }

        public string AccessSecret { get; set; }
        public AWSLambdaDestination()
        {
            this.Type = "AWSLambda";
        }
    }
}

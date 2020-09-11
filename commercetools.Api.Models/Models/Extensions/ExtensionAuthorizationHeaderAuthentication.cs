using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Extensions
{
    public class ExtensionAuthorizationHeaderAuthentication : ExtensionHttpDestinationAuthentication
    {
        public string HeaderValue { get; set;}
    }
}

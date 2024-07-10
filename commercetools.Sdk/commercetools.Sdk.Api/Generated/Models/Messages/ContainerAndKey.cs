using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ContainerAndKey : IContainerAndKey
    {
        public string Key { get; set; }

        public string Container { get; set; }
    }
}

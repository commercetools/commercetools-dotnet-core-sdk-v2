using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class UserProvidedIdentifiers : IUserProvidedIdentifiers
    {
        public string Key { get; set; }

        public string ExternalId { get; set; }

        public string OrderNumber { get; set; }

        public string CustomerNumber { get; set; }

        public string Sku { get; set; }

        public ILocalizedString Slug { get; set; }

        public IContainerAndKey ContainerAndKey { get; set; }
    }
}

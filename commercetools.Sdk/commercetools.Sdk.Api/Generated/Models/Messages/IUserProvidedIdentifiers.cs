using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.UserProvidedIdentifiers))]
    public partial interface IUserProvidedIdentifiers
    {
        string Key { get; set; }

        string ExternalId { get; set; }

        string OrderNumber { get; set; }

        string CustomerNumber { get; set; }

        string Sku { get; set; }

        ILocalizedString Slug { get; set; }
    }
}

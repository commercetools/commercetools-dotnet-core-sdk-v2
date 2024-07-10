using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductPriceCustomFieldsSetMessage))]
    public partial interface IProductPriceCustomFieldsSetMessage : IMessage
    {
        string PriceId { get; set; }

        long VariantId { get; set; }

        bool Staged { get; set; }

        ICustomFields CustomField { get; set; }

        string OldTypeId { get; set; }

    }
}

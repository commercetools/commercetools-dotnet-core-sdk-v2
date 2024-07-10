using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductPricesSetMessage))]
    public partial interface IProductPricesSetMessage : IMessage
    {
        long VariantId { get; set; }

        IList<IPrice> Prices { get; set; }
        IEnumerable<IPrice> PricesEnumerable { set => Prices = value.ToList(); }


        bool Staged { get; set; }

    }
}

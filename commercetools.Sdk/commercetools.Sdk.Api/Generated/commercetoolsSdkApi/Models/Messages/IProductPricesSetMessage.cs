using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
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

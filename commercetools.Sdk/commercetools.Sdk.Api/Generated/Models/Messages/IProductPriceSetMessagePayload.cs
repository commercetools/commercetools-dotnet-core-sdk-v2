using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductPriceSetMessagePayload))]
    public partial interface IProductPriceSetMessagePayload : IMessagePayload
    {
        long VariantId { get; set; }

        IList<IPrice> Prices { get; set; }
        IEnumerable<IPrice> PricesEnumerable { set => Prices = value.ToList(); }


        bool Staged { get; set; }

    }
}

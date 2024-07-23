using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductPriceDiscountsSetMessagePayload))]
    public partial interface IProductPriceDiscountsSetMessagePayload : IMessagePayload
    {
        IList<IProductPriceDiscountsSetUpdatedPrice> UpdatedPrices { get; set; }
        IEnumerable<IProductPriceDiscountsSetUpdatedPrice> UpdatedPricesEnumerable { set => UpdatedPrices = value.ToList(); }


    }
}

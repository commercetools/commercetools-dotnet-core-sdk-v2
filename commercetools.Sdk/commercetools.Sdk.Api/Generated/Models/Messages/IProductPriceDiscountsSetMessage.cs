using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductPriceDiscountsSetMessage))]
    public partial interface IProductPriceDiscountsSetMessage : IMessage
    {
        IList<IProductPriceDiscountsSetUpdatedPrice> UpdatedPrices { get; set; }
        IEnumerable<IProductPriceDiscountsSetUpdatedPrice> UpdatedPricesEnumerable { set => UpdatedPrices = value.ToList(); }


    }
}

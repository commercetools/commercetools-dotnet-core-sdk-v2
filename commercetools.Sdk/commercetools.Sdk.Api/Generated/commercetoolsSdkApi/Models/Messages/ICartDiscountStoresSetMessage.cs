using commercetools.Sdk.Api.Models.Stores;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CartDiscountStoresSetMessage))]
    public partial interface ICartDiscountStoresSetMessage : IMessage
    {
        IList<IStoreKeyReference> Stores { get; set; }

        IEnumerable<IStoreKeyReference> StoresEnumerable { set => Stores = value.ToList(); }

    }
}

using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class DeliveryDraft : IDeliveryDraft
    {
        public List<IDeliveryItem> Items { get; set; }

        public List<IParcelDraft> Parcels { get; set; }

        public IAddressDraft Address { get; set; }

        public ICustomFieldsDraft Custom { get; set; }
    }
}

using commercetools.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderAddDeliveryAction : IOrderAddDeliveryAction
    {
        public string Action { get; set; }

        public List<IDeliveryItem> Items { get; set; }

        public IBaseAddress Address { get; set; }

        public List<IParcelDraft> Parcels { get; set; }
        public OrderAddDeliveryAction()
        {
            this.Action = "addDelivery";
        }
    }
}

using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderAddDeliveryAction : IStagedOrderAddDeliveryAction
    {
        public string Action { get; set; }

        public string DeliveryKey { get; set; }

        public IList<IDeliveryItem> Items { get; set; }
        public IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }


        public IBaseAddress Address { get; set; }

        public IList<IParcelDraft> Parcels { get; set; }
        public IEnumerable<IParcelDraft> ParcelsEnumerable { set => Parcels = value.ToList(); }


        public ICustomFieldsDraft Custom { get; set; }
        public StagedOrderAddDeliveryAction()
        {
            this.Action = "addDelivery";
        }
    }
}

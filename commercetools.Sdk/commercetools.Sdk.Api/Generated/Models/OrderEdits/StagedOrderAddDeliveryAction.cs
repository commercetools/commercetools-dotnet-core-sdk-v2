using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System.Collections.Generic;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderAddDeliveryAction : IStagedOrderAddDeliveryAction
    {
        public string Action { get; set;}
        
        public List<IDeliveryItem> Items { get; set;}
        
        public IBaseAddress Address { get; set;}
        
        public List<IParcelDraft> Parcels { get; set;}
        public StagedOrderAddDeliveryAction()
        { 
           this.Action = "addDelivery";
        }
    }
}

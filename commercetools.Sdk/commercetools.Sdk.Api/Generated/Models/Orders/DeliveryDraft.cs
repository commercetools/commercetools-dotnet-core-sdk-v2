using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class DeliveryDraft : IDeliveryDraft
    {
        public string Key { get; set; }

        public IList<IDeliveryItem> Items { get; set; }
        public IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }


        public IList<IParcelDraft> Parcels { get; set; }
        public IEnumerable<IParcelDraft> ParcelsEnumerable { set => Parcels = value.ToList(); }


        public IAddressDraft Address { get; set; }

        public ICustomFieldsDraft Custom { get; set; }
    }
}

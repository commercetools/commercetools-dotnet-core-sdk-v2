using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class OrderEditDraft : IOrderEditDraft
    {
        public string Key { get; set; }

        public IOrderReference Resource { get; set; }

        public List<IStagedOrderUpdateAction> StagedActions { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public string Comment { get; set; }

        public bool? DryRun { get; set; }
    }
}

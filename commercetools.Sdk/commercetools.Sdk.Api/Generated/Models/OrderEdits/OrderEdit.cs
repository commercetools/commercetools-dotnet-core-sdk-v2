using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.OrderEdits;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class OrderEdit : IOrderEdit
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public string Key { get; set; }

        public IOrderReference Resource { get; set; }

        public IList<IStagedOrderUpdateAction> StagedActions { get; set; }
        public IEnumerable<IStagedOrderUpdateAction> StagedActionsEnumerable { set => StagedActions = value.ToList(); }


        public IOrderEditResult Result { get; set; }

        public string Comment { get; set; }

        public ICustomFields Custom { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }
    }
}

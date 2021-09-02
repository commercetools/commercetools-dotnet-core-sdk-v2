using commercetools.Api.Models.Common;
using commercetools.Api.Models.OrderEdits;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.OrderEdit))]
    public partial interface IOrderEdit : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        ICreatedBy CreatedBy { get; set; }

        string Key { get; set; }

        IOrderReference Resource { get; set; }

        List<IStagedOrderUpdateAction> StagedActions { get; set; }

        ICustomFields Custom { get; set; }

        IOrderEditResult Result { get; set; }

        string Comment { get; set; }
    }
}

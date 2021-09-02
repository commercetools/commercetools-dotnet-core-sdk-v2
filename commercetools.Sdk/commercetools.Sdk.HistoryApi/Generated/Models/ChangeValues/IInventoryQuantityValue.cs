using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.ChangeValues.InventoryQuantityValue))]
    public partial interface IInventoryQuantityValue
    {
        int QuantityOnStock { get; set; }

        int AvailableQuantity { get; set; }
    }
}

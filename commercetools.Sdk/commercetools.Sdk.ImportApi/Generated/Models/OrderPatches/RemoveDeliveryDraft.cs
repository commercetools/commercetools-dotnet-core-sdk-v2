using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.OrderPatches
{
    public partial class RemoveDeliveryDraft : IRemoveDeliveryDraft
    {
        public string Id { get; set;}
    }
}

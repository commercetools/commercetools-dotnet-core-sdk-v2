using commercetools.Sdk.ImportApi.Models.OrderPatches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.OrderPatches
{

    public partial class ReturnInfo : IReturnInfo
    {
        public IList<IReturnItemDraft> Items { get; set; }
        public IEnumerable<IReturnItemDraft> ItemsEnumerable { set => Items = value.ToList(); }


        public string ReturnTrackingId { get; set; }

        public DateTime? ReturnDate { get; set; }
    }
}

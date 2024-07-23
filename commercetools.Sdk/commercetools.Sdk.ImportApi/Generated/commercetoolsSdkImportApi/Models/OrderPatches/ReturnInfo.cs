using System;
using System.Collections.Generic;
using System.Linq;


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

using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeCartDiscountsChange : IChangeCartDiscountsChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<IReference> PreviousValue { get; set; }
        public IEnumerable<IReference> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        public IList<IReference> NextValue { get; set; }
        public IEnumerable<IReference> NextValueEnumerable { set => NextValue = value.ToList(); }

        public ChangeCartDiscountsChange()
        {
            this.Type = "ChangeCartDiscountsChange";
        }
    }
}

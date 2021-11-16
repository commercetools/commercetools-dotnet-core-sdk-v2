using commercetools.HistoryApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    public partial class ChangeValueAbsoluteChangeValue : IChangeValueAbsoluteChangeValue
    {
        public string Type { get; set;}
        
        public List<IMoney> Money { get; set;}
        public ChangeValueAbsoluteChangeValue()
        { 
           this.Type = "absolute";
        }
    }
}

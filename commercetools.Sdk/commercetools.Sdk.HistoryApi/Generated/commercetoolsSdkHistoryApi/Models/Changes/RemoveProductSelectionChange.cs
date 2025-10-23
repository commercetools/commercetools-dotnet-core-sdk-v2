using commercetools.Sdk.HistoryApi.Models.Common;
using System;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class RemoveProductSelectionChange : IRemoveProductSelectionChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IProductSelectionSetting PreviousValue { get; set; }
        public RemoveProductSelectionChange()
        {
            this.Type = "RemoveProductSelectionChange";
        }
    }
}

using commercetools.Sdk.HistoryApi.Models.Common;
using System;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class AddProductSelectionChange : IAddProductSelectionChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IProductSelectionSetting PreviousValue { get; set; }

        public IProductSelectionSetting NextValue { get; set; }
        public AddProductSelectionChange()
        {
            this.Type = "AddProductSelectionChange";
        }
    }
}

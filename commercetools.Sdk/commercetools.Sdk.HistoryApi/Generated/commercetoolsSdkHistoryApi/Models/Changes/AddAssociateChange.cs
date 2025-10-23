using commercetools.Sdk.HistoryApi.Models.Common;
using System;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class AddAssociateChange : IAddAssociateChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IAssociate NextValue { get; set; }
        public AddAssociateChange()
        {
            this.Type = "AddAssociateChange";
        }
    }
}

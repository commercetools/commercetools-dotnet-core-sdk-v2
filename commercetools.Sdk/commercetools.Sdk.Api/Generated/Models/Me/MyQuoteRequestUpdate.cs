using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyQuoteRequestUpdate : IMyQuoteRequestUpdate
    {
        public long Version { get; set; }

        public List<IMyQuoteRequestUpdateAction> Actions { get; set; }
    }
}

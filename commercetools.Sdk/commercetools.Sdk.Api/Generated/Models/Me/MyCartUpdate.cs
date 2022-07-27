using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCartUpdate : IMyCartUpdate
    {
        public long Version { get; set; }

        public List<IMyCartUpdateAction> Actions { get; set; }
    }
}

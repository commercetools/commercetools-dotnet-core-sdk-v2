using System.Collections.Generic;


namespace commercetools.Api.Models.Common
{
    public partial class Update : IUpdate
    {
        public long Version { get; set; }

        public List<IUpdateAction> Actions { get; set; }
    }
}

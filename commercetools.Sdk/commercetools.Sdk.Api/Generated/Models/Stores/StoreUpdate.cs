using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Stores
{

    public partial class StoreUpdate : IStoreUpdate
    {
        public long Version { get; set; }

        public IList<IStoreUpdateAction> Actions { get; set; }
        public IEnumerable<IStoreUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}

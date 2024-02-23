using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.States
{

    public partial class StatePagedQueryResponse : IStatePagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IState> Results { get; set; }
        public IEnumerable<IState> ResultsEnumerable { set => Results = value.ToList(); }

    }
}

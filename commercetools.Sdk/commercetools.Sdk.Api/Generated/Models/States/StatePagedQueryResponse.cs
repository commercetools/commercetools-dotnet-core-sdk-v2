using System.Collections.Generic;


namespace commercetools.Api.Models.States
{
    public partial class StatePagedQueryResponse : IStatePagedQueryResponse
    {
        public long Limit { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public long Offset { get; set; }

        public List<IState> Results { get; set; }
    }
}

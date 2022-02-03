using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.States
{
    [DeserializeAs(typeof(commercetools.Api.Models.States.StatePagedQueryResponse))]
    public partial interface IStatePagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        List<IState> Results { get; set; }
    }
}

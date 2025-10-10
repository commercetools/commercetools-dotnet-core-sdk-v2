using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.CheckoutApi.Models.Applications
{

    public partial class AllowedOrigins : IAllowedOrigins
    {
        public bool AllowAll { get; set; }

        public IList<string> Origins { get; set; }

        public IEnumerable<string> OriginsEnumerable { set => Origins = value.ToList(); }
    }
}

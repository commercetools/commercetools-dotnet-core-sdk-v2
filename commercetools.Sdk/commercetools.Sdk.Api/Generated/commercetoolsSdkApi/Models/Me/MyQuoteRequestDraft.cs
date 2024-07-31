

namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyQuoteRequestDraft : IMyQuoteRequestDraft
    {
        public string CartId { get; set; }

        public long CartVersion { get; set; }

        public string Comment { get; set; }
    }
}

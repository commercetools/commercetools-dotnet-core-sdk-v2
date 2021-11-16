namespace commercetools.MLApi.Models.Common
{
    public partial class Money : IMoney
    {
        public long CentAmount { get; set; }

        public string CurrencyCode { get; set; }
    }
}

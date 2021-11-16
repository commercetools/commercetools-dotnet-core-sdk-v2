namespace commercetools.HistoryApi.Models.Common
{
    public partial class Price : IPrice
    {
        public string Id { get; set; }

        public IMoney Value { get; set; }
    }
}

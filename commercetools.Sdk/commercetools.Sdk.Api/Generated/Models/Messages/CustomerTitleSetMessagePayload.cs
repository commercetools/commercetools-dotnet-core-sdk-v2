namespace commercetools.Api.Models.Messages
{
    public partial class CustomerTitleSetMessagePayload : ICustomerTitleSetMessagePayload
    {
        public string Type { get; set; }

        public string Title { get; set; }
        public CustomerTitleSetMessagePayload()
        {
            this.Type = "CustomerTitleSet";
        }
    }
}

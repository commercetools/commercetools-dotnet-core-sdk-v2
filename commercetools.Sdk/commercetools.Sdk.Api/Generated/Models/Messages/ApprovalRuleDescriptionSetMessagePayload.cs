namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ApprovalRuleDescriptionSetMessagePayload : IApprovalRuleDescriptionSetMessagePayload
    {
        public string Type { get; set; }

        public string Description { get; set; }

        public string OldDescription { get; set; }
        public ApprovalRuleDescriptionSetMessagePayload()
        {
            this.Type = "ApprovalRuleDescriptionSet";
        }
    }
}

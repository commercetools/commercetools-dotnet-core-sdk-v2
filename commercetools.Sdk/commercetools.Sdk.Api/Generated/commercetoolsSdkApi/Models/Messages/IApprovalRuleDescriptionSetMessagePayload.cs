using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ApprovalRuleDescriptionSetMessagePayload))]
    public partial interface IApprovalRuleDescriptionSetMessagePayload : IMessagePayload
    {
        string Description { get; set; }

        string OldDescription { get; set; }

    }
}

using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.RecurrencePolicies
{

    public partial class RecurrencePolicyDraft : IRecurrencePolicyDraft
    {
        public string Key { get; set; }

        public ILocalizedString Name { get; set; }

        public ILocalizedString Description { get; set; }

        public IRecurrencePolicyScheduleDraft Schedule { get; set; }
    }
}

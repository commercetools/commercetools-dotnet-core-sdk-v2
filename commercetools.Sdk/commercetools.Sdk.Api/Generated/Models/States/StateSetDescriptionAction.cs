using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.States
{
    public partial class StateSetDescriptionAction : IStateSetDescriptionAction
    {
        public string Action { get; set; }

        public ILocalizedString Description { get; set; }
        public StateSetDescriptionAction()
        {
            this.Action = "setDescription";
        }
    }
}

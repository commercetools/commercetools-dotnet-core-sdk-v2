using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.States
{
    public partial class StateSetNameAction : IStateSetNameAction
    {
        public string Action { get; set; }

        public ILocalizedString Name { get; set; }
        public StateSetNameAction()
        {
            this.Action = "setName";
        }
    }
}

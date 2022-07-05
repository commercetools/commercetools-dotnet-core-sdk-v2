namespace commercetools.Sdk.Api.Models.States
{

    public partial class StateChangeKeyAction : IStateChangeKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public StateChangeKeyAction()
        {
            this.Action = "changeKey";
        }
    }
}

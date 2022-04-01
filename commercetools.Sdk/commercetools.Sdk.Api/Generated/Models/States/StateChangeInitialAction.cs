namespace commercetools.Sdk.Api.Models.States
{
    public partial class StateChangeInitialAction : IStateChangeInitialAction
    {
        public string Action { get; set; }

        public bool Initial { get; set; }
        public StateChangeInitialAction()
        {
            this.Action = "changeInitial";
        }
    }
}

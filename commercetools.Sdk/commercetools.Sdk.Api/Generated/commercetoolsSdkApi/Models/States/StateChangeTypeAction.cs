

namespace commercetools.Sdk.Api.Models.States
{

    public partial class StateChangeTypeAction : IStateChangeTypeAction
    {
        public string Action { get; set; }

        public IStateTypeEnum Type { get; set; }
        public StateChangeTypeAction()
        {
            this.Action = "changeType";
        }
    }
}

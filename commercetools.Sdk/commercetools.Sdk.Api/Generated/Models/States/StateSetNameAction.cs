using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.States
{
    public partial class StateSetNameAction : IStateSetNameAction
    {
        public string Action { get; set;}
        
        public ILocalizedString Name { get; set;}
        public StateSetNameAction()
        { 
           this.Action = "setName";
        }
    }
}

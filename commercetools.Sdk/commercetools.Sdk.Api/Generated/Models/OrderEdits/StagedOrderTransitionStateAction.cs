using commercetools.Api.Models.States;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderTransitionStateAction : IStagedOrderTransitionStateAction
    {
        public string Action { get; set;}
        
        public IStateResourceIdentifier State { get; set;}
        
        public bool? Force { get; set;}
        public StagedOrderTransitionStateAction()
        { 
           this.Action = "transitionState";
        }
    }
}

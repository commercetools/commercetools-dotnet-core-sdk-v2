using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.States
{
    public partial class StateReference : IStateReference
    {
        public IReferenceTypeId TypeId { get; set;}
        
        public string Id { get; set;}
        
        public IState Obj { get; set;}
        public StateReference()
        { 
           this.TypeId = IReferenceTypeId.FindEnum("state");
        }
    }
}

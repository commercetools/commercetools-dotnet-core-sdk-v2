using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.States
{
    public partial class StateResourceIdentifier : IStateResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public StateResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("state");
        }
    }
}

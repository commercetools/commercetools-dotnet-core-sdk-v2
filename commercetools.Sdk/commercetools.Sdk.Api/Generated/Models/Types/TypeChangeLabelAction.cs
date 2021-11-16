using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Types
{
    public partial class TypeChangeLabelAction : ITypeChangeLabelAction
    {
        public string Action { get; set;}
        
        public string FieldName { get; set;}
        
        public ILocalizedString Label { get; set;}
        public TypeChangeLabelAction()
        { 
           this.Action = "changeLabel";
        }
    }
}

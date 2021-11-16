using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Types
{
    public partial class TypeSetDescriptionAction : ITypeSetDescriptionAction
    {
        public string Action { get; set;}
        
        public ILocalizedString Description { get; set;}
        public TypeSetDescriptionAction()
        { 
           this.Action = "setDescription";
        }
    }
}

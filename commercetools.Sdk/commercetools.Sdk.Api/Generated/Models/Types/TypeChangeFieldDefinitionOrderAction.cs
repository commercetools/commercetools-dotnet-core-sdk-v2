using System.Collections.Generic;


namespace commercetools.Api.Models.Types
{
    public partial class TypeChangeFieldDefinitionOrderAction : ITypeChangeFieldDefinitionOrderAction
    {
        public string Action { get; set; }

        public List<string> FieldNames { get; set; }
        public TypeChangeFieldDefinitionOrderAction()
        {
            this.Action = "changeFieldDefinitionOrder";
        }
    }
}

using commercetools.ImportApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.ImportApi.Models.Customfields
{
    public partial class ReferenceSetField : IReferenceSetField
    {
        public string Type { get; set;}
        
        public List<IKeyReference> Value { get; set;}
        public ReferenceSetField()
        { 
           this.Type = "ReferenceSet";
        }
    }
}

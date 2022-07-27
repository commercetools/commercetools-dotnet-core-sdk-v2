using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{

    public partial class ReferenceSetField : IReferenceSetField
    {
        public string Type { get; set; }

        public List<IKeyReference> Value { get; set; }
        public ReferenceSetField()
        {
            this.Type = "ReferenceSet";
        }
    }
}

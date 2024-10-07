using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.ImportApi.Models.Customfields
{

    public partial class ReferenceSetField : IReferenceSetField
    {
        public string Type { get; set; }

        public IList<IKeyReference> Value { get; set; }

        public IEnumerable<IKeyReference> ValueEnumerable { set => Value = value.ToList(); }
        public ReferenceSetField()
        {
            this.Type = "ReferenceSet";
        }
    }
}

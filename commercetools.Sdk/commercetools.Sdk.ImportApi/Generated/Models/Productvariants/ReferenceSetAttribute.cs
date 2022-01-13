using commercetools.ImportApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.ImportApi.Models.Productvariants
{
    public partial class ReferenceSetAttribute : IReferenceSetAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public List<IKeyReference> Value { get; set; }
        public ReferenceSetAttribute()
        {
            this.Type = "reference-set";
        }
    }
}

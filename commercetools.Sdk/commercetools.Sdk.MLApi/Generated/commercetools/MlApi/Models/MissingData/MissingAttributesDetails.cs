using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.MissingData
{
    public partial class MissingAttributesDetails : IMissingAttributesDetails
    {
        public int Total { get; set; }

        public int MissingAttributeNames { get; set; }

        public int MissingAttributeValues { get; set; }
    }
}

using commercetools.Sdk.ImportApi.Models.Producttypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Producttypes
{

    public partial class AttributeDateType : IAttributeDateType
    {
        public string Name { get; set; }
        public AttributeDateType()
        {
            this.Name = "date";
        }
    }
}

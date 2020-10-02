using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [Discriminator(nameof(Name))]
    public abstract partial class FieldType 
    {
        public string Name { get; set;}
    }
}

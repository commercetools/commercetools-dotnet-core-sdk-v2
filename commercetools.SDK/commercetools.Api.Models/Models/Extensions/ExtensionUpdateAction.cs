using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [Discriminator(nameof(Action))]
    public abstract partial class ExtensionUpdateAction 
    {
        public string Action { get; set;}
    }
}

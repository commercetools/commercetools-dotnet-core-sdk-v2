using commercetools.Api.Models.Common;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DiscriminatorValue("setName")]
    public partial class StoreSetNameAction : StoreUpdateAction
    {
        public LocalizedString Name { get; set;}
        public StoreSetNameAction()
        { 
           this.Action = "setName";
        }
    }
}

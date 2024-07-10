using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Producttypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Producttypes
{

    public partial class AttributeDefinition : IAttributeDefinition
    {
        public IAttributeType Type { get; set; }

        public string Name { get; set; }

        public ILocalizedString Label { get; set; }

        public bool IsRequired { get; set; }

        public IAttributeConstraintEnum AttributeConstraint { get; set; }

        public ILocalizedString InputTip { get; set; }

        public ITextInputHint InputHint { get; set; }

        public bool? IsSearchable { get; set; }
    }
}

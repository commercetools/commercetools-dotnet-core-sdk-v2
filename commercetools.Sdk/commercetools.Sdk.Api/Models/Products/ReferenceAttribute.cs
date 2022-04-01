using System;
using commercetools.Sdk.Api.Models.Common;

namespace commercetools.Sdk.Api.Models.Products
{
    public class ReferenceAttribute : Attribute, IGenericAttribute<IReference>
    {
        public Type GetValueType() => typeof(IReference);

        public IReference GetValue() => (IReference)Value;
    }
}
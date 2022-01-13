using System;
using commercetools.Api.Models.Common;

namespace commercetools.Api.Models.Products
{
    public class ReferenceAttribute : Attribute, IGenericAttribute<IReference>
    {
        public Type GetValueType() => typeof(IReference);

        public IReference GetValue() => (IReference)Value;
    }
}
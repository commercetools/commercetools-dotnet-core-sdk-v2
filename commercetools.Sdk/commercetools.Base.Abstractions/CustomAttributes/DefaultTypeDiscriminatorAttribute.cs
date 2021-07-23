using System;

namespace commercetools.Base.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
    public class DefaultTypeDiscriminatorAttribute
        : Attribute
    {
        public DefaultTypeDiscriminatorAttribute(Type defaultType)
        {
            this.DefaultType = defaultType;
        }

        public Type DefaultType { get; set; }

    }
}
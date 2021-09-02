using System;

namespace commercetools.Base.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
    public class SubTypeDiscriminatorAttribute
        : Attribute
    {
        public SubTypeDiscriminatorAttribute(string value, Type subType)
        {
            this.Value = value;
            this.SubType = subType;
        }

        public string Value { get; }

        public Type SubType { get; set; }

    }
}
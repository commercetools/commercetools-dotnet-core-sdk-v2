using System;

namespace commercetools.Base.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Class, AllowMultiple = false)]
    public class DeserializeAsAttribute
        : Attribute
    {
        public DeserializeAsAttribute(Type deserializeType)
        {
            this.DeserializedType = deserializeType;
        }
        
        public Type DeserializedType { get; }

    }
}
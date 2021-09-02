using System;

namespace commercetools.Base.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false)]
    public class EnumInterfaceCreatorAttribute
        : Attribute
    {
        public EnumInterfaceCreatorAttribute(Type type, string method)
        {
            this.Type = type;
            this.Method = method;
        }

        public Type Type { get; }

        public string Method { get; }

        public Delegate Creator()
        {
            return Type.GetMethod(Method)?.CreateDelegate(typeof(Func<string, object>));
        }
    }
}
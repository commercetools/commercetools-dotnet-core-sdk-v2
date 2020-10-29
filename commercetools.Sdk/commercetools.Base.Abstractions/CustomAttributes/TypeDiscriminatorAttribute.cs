using System;

namespace commercetools.Base.CustomAttributes
{
    /// <summary>
    /// Represents the <see cref="System.Attribute"/> used to indicate the property used to discriminate derived types of the marked class
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
    public class TypeDiscriminatorAttribute
        : Attribute
    {

        /// <summary>
        /// Initializes a new <see cref="TypeDiscriminatorAttribute"/>
        /// </summary>
        /// <param name="property">The name of the property used to discriminate derived types of the class marked by the <see cref="TypeDiscriminatorAttribute"/></param>
        public TypeDiscriminatorAttribute(string property)
        {
            this.Property = property;
        }

        /// <summary>
        /// Gets the name of the property used to discriminate derived types of the class marked by the <see cref="TypeDiscriminatorAttribute"/>
        /// </summary>
        public string Property { get; }
    }
}
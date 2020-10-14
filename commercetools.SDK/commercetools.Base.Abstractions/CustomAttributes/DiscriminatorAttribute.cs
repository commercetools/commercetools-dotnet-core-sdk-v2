using System;

namespace commercetools.Base.Abstractions.CustomAttributes
{
    /// <summary>
    /// Represents the <see cref="System.Attribute"/> used to indicate the property used to discriminate derived types of the marked class
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class DiscriminatorAttribute
        : Attribute
    {

        /// <summary>
        /// Initializes a new <see cref="DiscriminatorAttribute"/>
        /// </summary>
        /// <param name="property">The name of the property used to discriminate derived types of the class marked by the <see cref="DiscriminatorAttribute"/></param>
        public DiscriminatorAttribute(string property)
        {
            this.Property = property;
        }

        /// <summary>
        /// Gets the name of the property used to discriminate derived types of the class marked by the <see cref="DiscriminatorAttribute"/>
        /// </summary>
        public string Property { get; }

    }
}
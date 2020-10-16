using System;

namespace commercetools.Base.CustomAttributes
{
    /// <summary>
    /// Represents the <see cref="System.Attribute"/> used to indicate the discriminator value of a derived type
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class DiscriminatorValueAttribute
        : Attribute
    {

        /// <summary>
        /// Initializes a new <see cref="DiscriminatorValueAttribute"/>
        /// </summary>
        /// <param name="value">The value used to discriminate the derived type marked by the <see cref="DiscriminatorValueAttribute"/></param>
        public DiscriminatorValueAttribute(object value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the value used to discriminate the derived type marked by the <see cref="DiscriminatorValueAttribute"/>
        /// </summary>
        public object Value { get; }

    }
}
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    public enum AttributeConstraintEnum
    {
        [Description("None")]
        None,

        [Description("Unique")]
        Unique,

        [Description("CombinationUnique")]
        CombinationUnique,

        [Description("SameForAll")]
        SameForAll
    }

    public class AttributeConstraintEnumWrapper : IAttributeConstraintEnum
    {
        public string JsonName { get; internal set; }
        public AttributeConstraintEnum? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public new IEnumerator<char> GetEnumerator()
        {
            return JsonName.GetEnumerator();
        }
    }

    [EnumInterfaceCreator(typeof(IAttributeConstraintEnum), "FindEnum")]
    public interface IAttributeConstraintEnum : IJsonName, IEnumerable<char>
    {
        public static IAttributeConstraintEnum None = new AttributeConstraintEnumWrapper
        { Value = AttributeConstraintEnum.None, JsonName = "None" };

        public static IAttributeConstraintEnum Unique = new AttributeConstraintEnumWrapper
        { Value = AttributeConstraintEnum.Unique, JsonName = "Unique" };

        public static IAttributeConstraintEnum CombinationUnique = new AttributeConstraintEnumWrapper
        { Value = AttributeConstraintEnum.CombinationUnique, JsonName = "CombinationUnique" };

        public static IAttributeConstraintEnum SameForAll = new AttributeConstraintEnumWrapper
        { Value = AttributeConstraintEnum.SameForAll, JsonName = "SameForAll" };

        AttributeConstraintEnum? Value { get; }

        static IAttributeConstraintEnum[] Values()
        {
            return new[]
            {
                 None ,
                 Unique ,
                 CombinationUnique ,
                 SameForAll
             };
        }
        static IAttributeConstraintEnum FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new AttributeConstraintEnumWrapper() { JsonName = value };
        }
    }
}

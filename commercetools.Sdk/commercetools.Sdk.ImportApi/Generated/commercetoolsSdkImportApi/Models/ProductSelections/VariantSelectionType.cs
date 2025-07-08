using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.ProductSelections
{
    public enum VariantSelectionType
    {
        [Description("includeOnly")]
        IncludeOnly,

        [Description("includeAllExcept")]
        IncludeAllExcept
    }

    public class VariantSelectionTypeWrapper : IVariantSelectionType
    {
        public string JsonName { get; internal set; }
        public VariantSelectionType? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IVariantSelectionType), "FindEnum")]
    public interface IVariantSelectionType : IJsonName, IEnumerable<char>
    {
        public static IVariantSelectionType IncludeOnly = new VariantSelectionTypeWrapper
        { Value = VariantSelectionType.IncludeOnly, JsonName = "includeOnly" };

        public static IVariantSelectionType IncludeAllExcept = new VariantSelectionTypeWrapper
        { Value = VariantSelectionType.IncludeAllExcept, JsonName = "includeAllExcept" };

        VariantSelectionType? Value { get; }

        static IVariantSelectionType[] Values()
        {
            return new[]
            {
                 IncludeOnly ,
                 IncludeAllExcept
             };
        }
        static IVariantSelectionType FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new VariantSelectionTypeWrapper() { JsonName = value };
        }
    }
}

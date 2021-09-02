using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Api.Models.ProductTypes
{
    public enum AttributeConstraintEnumDraft
    {
        [Description("None")]
        None
    }

    public class AttributeConstraintEnumDraftWrapper : IAttributeConstraintEnumDraft
    {
        public string JsonName { get; internal set; }
        public AttributeConstraintEnumDraft? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }
    }

    [EnumInterfaceCreator(typeof(IAttributeConstraintEnumDraft), "FindEnum")]
    public interface IAttributeConstraintEnumDraft : IJsonName
    {
        public static IAttributeConstraintEnumDraft None = new AttributeConstraintEnumDraftWrapper
        { Value = AttributeConstraintEnumDraft.None, JsonName = "None" };

        AttributeConstraintEnumDraft? Value { get; }

        static IAttributeConstraintEnumDraft[] Values()
        {
            return new[]
            {
                 None
             };
        }
        static IAttributeConstraintEnumDraft FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new AttributeConstraintEnumDraftWrapper() { JsonName = value };
        }
    }
}

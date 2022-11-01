using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.Api.Models.Types
{
    public enum TypeTextInputHint
    {
        [Description("SingleLine")]
        SingleLine,

        [Description("MultiLine")]
        MultiLine
    }

    public class TypeTextInputHintWrapper : ITypeTextInputHint
    {
        public string JsonName { get; internal set; }
        public TypeTextInputHint? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<char> GetEnumerator()
        {
            return JsonName.GetEnumerator();
        }
    }

    [EnumInterfaceCreator(typeof(ITypeTextInputHint), "FindEnum")]
    public interface ITypeTextInputHint : IJsonName, IEnumerable<char>
    {
        public static ITypeTextInputHint SingleLine = new TypeTextInputHintWrapper
        { Value = TypeTextInputHint.SingleLine, JsonName = "SingleLine" };

        public static ITypeTextInputHint MultiLine = new TypeTextInputHintWrapper
        { Value = TypeTextInputHint.MultiLine, JsonName = "MultiLine" };

        TypeTextInputHint? Value { get; }

        static ITypeTextInputHint[] Values()
        {
            return new[]
            {
                 SingleLine ,
                 MultiLine
             };
        }
        static ITypeTextInputHint FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new TypeTextInputHintWrapper() { JsonName = value };
        }
    }
}

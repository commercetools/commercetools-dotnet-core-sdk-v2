using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.Api.Models.Extensions
{
    public enum ExtensionAction
    {
        [Description("Create")]
        Create,

        [Description("Update")]
        Update
    }

    public class ExtensionActionWrapper : IExtensionAction
    {
        public string JsonName { get; internal set; }
        public ExtensionAction? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IExtensionAction), "FindEnum")]
    public interface IExtensionAction : IJsonName, IEnumerable<char>
    {
        public static IExtensionAction Create = new ExtensionActionWrapper
        { Value = ExtensionAction.Create, JsonName = "Create" };

        public static IExtensionAction Update = new ExtensionActionWrapper
        { Value = ExtensionAction.Update, JsonName = "Update" };

        ExtensionAction? Value { get; }

        static IExtensionAction[] Values()
        {
            return new[]
            {
                 Create ,
                 Update
             };
        }
        static IExtensionAction FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ExtensionActionWrapper() { JsonName = value };
        }
    }
}

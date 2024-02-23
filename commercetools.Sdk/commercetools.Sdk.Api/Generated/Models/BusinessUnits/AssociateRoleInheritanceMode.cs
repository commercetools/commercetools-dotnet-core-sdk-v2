using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    public enum AssociateRoleInheritanceMode
    {
        [Description("Enabled")]
        Enabled,

        [Description("Disabled")]
        Disabled
    }

    public class AssociateRoleInheritanceModeWrapper : IAssociateRoleInheritanceMode
    {
        public string JsonName { get; internal set; }
        public AssociateRoleInheritanceMode? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IAssociateRoleInheritanceMode), "FindEnum")]
    public interface IAssociateRoleInheritanceMode : IJsonName, IEnumerable<char>
    {
        public static IAssociateRoleInheritanceMode Enabled = new AssociateRoleInheritanceModeWrapper
        { Value = AssociateRoleInheritanceMode.Enabled, JsonName = "Enabled" };

        public static IAssociateRoleInheritanceMode Disabled = new AssociateRoleInheritanceModeWrapper
        { Value = AssociateRoleInheritanceMode.Disabled, JsonName = "Disabled" };

        AssociateRoleInheritanceMode? Value { get; }

        static IAssociateRoleInheritanceMode[] Values()
        {
            return new[]
            {
                 Enabled ,
                 Disabled
             };
        }
        static IAssociateRoleInheritanceMode FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new AssociateRoleInheritanceModeWrapper() { JsonName = value };
        }
    }
}

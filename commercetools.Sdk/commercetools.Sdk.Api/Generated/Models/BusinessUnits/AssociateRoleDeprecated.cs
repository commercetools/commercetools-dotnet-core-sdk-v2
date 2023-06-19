using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    public enum AssociateRoleDeprecated
    {
        [Description("Admin")]
        Admin,

        [Description("Buyer")]
        Buyer
    }

    public class AssociateRoleDeprecatedWrapper : IAssociateRoleDeprecated
    {
        public string JsonName { get; internal set; }
        public AssociateRoleDeprecated? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IAssociateRoleDeprecated), "FindEnum")]
    public interface IAssociateRoleDeprecated : IJsonName, IEnumerable<char>
    {
        public static IAssociateRoleDeprecated Admin = new AssociateRoleDeprecatedWrapper
        { Value = AssociateRoleDeprecated.Admin, JsonName = "Admin" };

        public static IAssociateRoleDeprecated Buyer = new AssociateRoleDeprecatedWrapper
        { Value = AssociateRoleDeprecated.Buyer, JsonName = "Buyer" };

        AssociateRoleDeprecated? Value { get; }

        static IAssociateRoleDeprecated[] Values()
        {
            return new[]
            {
                 Admin ,
                 Buyer
             };
        }
        static IAssociateRoleDeprecated FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new AssociateRoleDeprecatedWrapper() { JsonName = value };
        }
    }
}

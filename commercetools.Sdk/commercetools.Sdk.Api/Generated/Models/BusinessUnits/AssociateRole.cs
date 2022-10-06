using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    public enum AssociateRole
    {
        [Description("Admin")]
        Admin,

        [Description("Buyer")]
        Buyer
    }

    public class AssociateRoleWrapper : IAssociateRole
    {
        public string JsonName { get; internal set; }
        public AssociateRole? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IAssociateRole), "FindEnum")]
    public interface IAssociateRole : IJsonName, IEnumerable<char>
    {
        public static IAssociateRole Admin = new AssociateRoleWrapper
        { Value = AssociateRole.Admin, JsonName = "Admin" };

        public static IAssociateRole Buyer = new AssociateRoleWrapper
        { Value = AssociateRole.Buyer, JsonName = "Buyer" };

        AssociateRole? Value { get; }

        static IAssociateRole[] Values()
        {
            return new[]
            {
                 Admin ,
                 Buyer
             };
        }
        static IAssociateRole FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new AssociateRoleWrapper() { JsonName = value };
        }
    }
}

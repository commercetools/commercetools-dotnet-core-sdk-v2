using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.Api.Models.AssociateRoles
{
    public enum BusinessUnitPermission
    {
        [Description("AddChildUnits")]
        AddChildUnits,

        [Description("UpdateAssociates")]
        UpdateAssociates,

        [Description("UpdateBusinessUnitDetails")]
        UpdateBusinessUnitDetails,

        [Description("UpdateParentUnit")]
        UpdateParentUnit
    }

    public class BusinessUnitPermissionWrapper : IBusinessUnitPermission
    {
        public string JsonName { get; internal set; }
        public BusinessUnitPermission? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IBusinessUnitPermission), "FindEnum")]
    public interface IBusinessUnitPermission : IJsonName, IEnumerable<char>
    {
        public static IBusinessUnitPermission AddChildUnits = new BusinessUnitPermissionWrapper
        { Value = BusinessUnitPermission.AddChildUnits, JsonName = "AddChildUnits" };

        public static IBusinessUnitPermission UpdateAssociates = new BusinessUnitPermissionWrapper
        { Value = BusinessUnitPermission.UpdateAssociates, JsonName = "UpdateAssociates" };

        public static IBusinessUnitPermission UpdateBusinessUnitDetails = new BusinessUnitPermissionWrapper
        { Value = BusinessUnitPermission.UpdateBusinessUnitDetails, JsonName = "UpdateBusinessUnitDetails" };

        public static IBusinessUnitPermission UpdateParentUnit = new BusinessUnitPermissionWrapper
        { Value = BusinessUnitPermission.UpdateParentUnit, JsonName = "UpdateParentUnit" };

        BusinessUnitPermission? Value { get; }

        static IBusinessUnitPermission[] Values()
        {
            return new[]
            {
                 AddChildUnits ,
                 UpdateAssociates ,
                 UpdateBusinessUnitDetails ,
                 UpdateParentUnit
             };
        }
        static IBusinessUnitPermission FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new BusinessUnitPermissionWrapper() { JsonName = value };
        }
    }
}

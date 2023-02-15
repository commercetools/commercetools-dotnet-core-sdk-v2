using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.Api.Models.AssociateRoles
{
    public enum CartPermission
    {
        [Description("CreateMyCarts")]
        CreateMyCarts,

        [Description("CreateOthersCarts")]
        CreateOthersCarts,

        [Description("DeleteMyCarts")]
        DeleteMyCarts,

        [Description("DeleteOthersCarts")]
        DeleteOthersCarts,

        [Description("UpdateMyCarts")]
        UpdateMyCarts,

        [Description("UpdateOthersCarts")]
        UpdateOthersCarts,

        [Description("ViewMyCarts")]
        ViewMyCarts,

        [Description("ViewOthersCarts")]
        ViewOthersCarts
    }

    public class CartPermissionWrapper : ICartPermission
    {
        public string JsonName { get; internal set; }
        public CartPermission? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(ICartPermission), "FindEnum")]
    public interface ICartPermission : IJsonName, IEnumerable<char>
    {
        public static ICartPermission CreateMyCarts = new CartPermissionWrapper
        { Value = CartPermission.CreateMyCarts, JsonName = "CreateMyCarts" };

        public static ICartPermission CreateOthersCarts = new CartPermissionWrapper
        { Value = CartPermission.CreateOthersCarts, JsonName = "CreateOthersCarts" };

        public static ICartPermission DeleteMyCarts = new CartPermissionWrapper
        { Value = CartPermission.DeleteMyCarts, JsonName = "DeleteMyCarts" };

        public static ICartPermission DeleteOthersCarts = new CartPermissionWrapper
        { Value = CartPermission.DeleteOthersCarts, JsonName = "DeleteOthersCarts" };

        public static ICartPermission UpdateMyCarts = new CartPermissionWrapper
        { Value = CartPermission.UpdateMyCarts, JsonName = "UpdateMyCarts" };

        public static ICartPermission UpdateOthersCarts = new CartPermissionWrapper
        { Value = CartPermission.UpdateOthersCarts, JsonName = "UpdateOthersCarts" };

        public static ICartPermission ViewMyCarts = new CartPermissionWrapper
        { Value = CartPermission.ViewMyCarts, JsonName = "ViewMyCarts" };

        public static ICartPermission ViewOthersCarts = new CartPermissionWrapper
        { Value = CartPermission.ViewOthersCarts, JsonName = "ViewOthersCarts" };

        CartPermission? Value { get; }

        static ICartPermission[] Values()
        {
            return new[]
            {
                 CreateMyCarts ,
                 CreateOthersCarts ,
                 DeleteMyCarts ,
                 DeleteOthersCarts ,
                 UpdateMyCarts ,
                 UpdateOthersCarts ,
                 ViewMyCarts ,
                 ViewOthersCarts
             };
        }
        static ICartPermission FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new CartPermissionWrapper() { JsonName = value };
        }
    }
}

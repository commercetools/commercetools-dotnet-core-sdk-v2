using System.Collections.Generic;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Client
{
    public interface ISecured_by_manage_import_containersTrait<T> where T : ISecured_by_manage_import_containersTrait<T>
    {



        ISecured_by_manage_import_containersTrait<T> AsSecured_by_manage_import_containersTrait()
        {
            return this;
        }

        T AsSecured_by_manage_import_containersTraitToBaseType()
        {
            return (T)this;
        }
    }
}

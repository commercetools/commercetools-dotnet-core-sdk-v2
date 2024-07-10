using System.Collections.Generic;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Client
{
    public interface ISecured_by_manage_typesTrait<T> where T : ISecured_by_manage_typesTrait<T>
    {



        ISecured_by_manage_typesTrait<T> AsSecured_by_manage_typesTrait()
        {
            return this;
        }

        T AsSecured_by_manage_typesTraitToBaseType()
        {
            return (T)this;
        }
    }
}

using System.Collections.Generic;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Client
{
    public interface ISecured_by_manage_productsTrait<T> where T : ISecured_by_manage_productsTrait<T>
    {



        ISecured_by_manage_productsTrait<T> AsSecured_by_manage_productsTrait()
        {
            return this;
        }

        T AsSecured_by_manage_productsTraitToBaseType()
        {
            return (T)this;
        }
    }
}

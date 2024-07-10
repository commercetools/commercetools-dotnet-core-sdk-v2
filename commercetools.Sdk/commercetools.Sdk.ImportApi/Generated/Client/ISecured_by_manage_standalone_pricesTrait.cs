using System.Collections.Generic;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Client
{
    public interface ISecured_by_manage_standalone_pricesTrait<T> where T : ISecured_by_manage_standalone_pricesTrait<T>
    {



        ISecured_by_manage_standalone_pricesTrait<T> AsSecured_by_manage_standalone_pricesTrait()
        {
            return this;
        }

        T AsSecured_by_manage_standalone_pricesTraitToBaseType()
        {
            return (T)this;
        }
    }
}

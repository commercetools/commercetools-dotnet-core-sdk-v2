using System.Collections.Generic;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client
{
    public interface ISupplychannelfilteringTrait<T> where T : ISupplychannelfilteringTrait<T>
    {
        List<string> GetFilterSupplyChannels();

        /**
         * set filterSupplyChannels with the specificied value
         */
        T WithFilterSupplyChannels(string filterSupplyChannels);


        ISupplychannelfilteringTrait<T> AsSupplychannelfilteringTrait()
        {
            return this;
        }

        T AsSupplychannelfilteringTraitToBaseType()
        {
            return (T)this;
        }
    }
}

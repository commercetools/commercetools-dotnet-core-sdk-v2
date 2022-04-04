using System.Collections.Generic;

namespace commercetools.Sdk.Api.Models
{
    public interface IResourceUpdate<out TUpdate, TAction> where TUpdate : IResourceUpdate<TUpdate, TAction>
                                          where TAction : IResourceUpdateAction<TAction>
    {
        public long Version { get; set; }

        public List<TAction> Actions { get; set; }

        TUpdate Get()
        {
            return (TUpdate)this;
        }
    }
}
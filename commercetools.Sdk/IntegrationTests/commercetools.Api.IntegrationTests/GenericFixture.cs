using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Api.Models.Common;
using commercetools.Base.Client;

namespace commercetools.Api.IntegrationTests
{
    public static class GenericFixture
    {
        public static string DefaultProjectKey { get; set; }
        
        public static async Task WithAsync<T, TDraft>(
            IClient client,
            TDraft draft,
            Func<TDraft, TDraft> draftAction,
            Func<T, Task> func,
            Func<IClient, TDraft, Task<T>> createFunc,
            Func<IClient, T, Task> deleteFunc
        ) 
        {
            var buildDraft = draftAction.Invoke(draft);
            var resource = await createFunc(client, buildDraft);
            try
            {
                await func(resource);
            }
            finally
            {
                await deleteFunc(client, resource);
            }
        }
        
        public static async Task With<T, TDraft>(
            IClient client,
            TDraft draft,
            Func<TDraft, TDraft> draftAction,
            Action<T> func,
            Func<IClient, TDraft, Task<T>> createFunc,
            Func<IClient, T, Task> deleteFunc)
        {

            var buildDraft = draftAction.Invoke(draft);

            var resource = await createFunc(client, buildDraft);

            try
            {
                func(resource);
            }
            finally
            {
                await deleteFunc(client, resource);
            }
        }
        
        public static async Task WithListAsync<T, TDraft>(
            IClient client,
            TDraft draft,
            Func<TDraft, TDraft> draftAction,
            Func<List<T>, Task> func,
            int count,
            Func<IClient, TDraft, Task<T>> createFunc,
            Func<IClient, T, Task> deleteFunc
        )
        {
            var resourcesList = new List<T>();
            for (int i = 1; i <= count; i++)
            {
                var buildDraft = draftAction.Invoke(draft);
                var resource = await createFunc(client, buildDraft);
                resourcesList.Add(resource);
            }

            try
            {
                await func(resourcesList);
            }
            finally
            {
                foreach (var resource in resourcesList)
                {
                    await deleteFunc(client, resource);   
                }
            }
        }
        
        public static async Task WithUpdateableAsync<T, TDraft>(
            IClient client,
            TDraft draft,
            Func<TDraft, TDraft> draftAction,
            Func<T, Task<T>> func,
            Func<IClient, TDraft, Task<T>> createFunc,
            Func<IClient, T, Task> deleteFunc) where T : IBaseResource
        {

            var buildDraft = draftAction.Invoke(draft);

            var resource = await createFunc(client, buildDraft);

            var updatedResource = default(T);

            try
            {
                updatedResource = await func(resource);
            }
            finally
            {
                await deleteFunc(client, updatedResource!=null ? updatedResource : resource);
            }
        }
    }

}
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.Client;
using commercetools.Sdk.Api.Client;

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
                await deleteFunc(client, updatedResource != null ? updatedResource : resource);
            }
        }

        public static async Task WithAsync<T, TDraft>(
            ProjectApiRoot apiRoot,
            TDraft draft,
            Func<TDraft, TDraft> draftAction,
            Func<T, Task> func,
            Func<ProjectApiRoot, TDraft, Task<T>> createFunc,
            Func<ProjectApiRoot, T, Task> deleteFunc
        )
        {
            var buildDraft = draftAction.Invoke(draft);
            var resource = await createFunc(apiRoot, buildDraft);
            try
            {
                await func(resource);
            }
            finally
            {
                await deleteFunc(apiRoot, resource);
            }
        }

        public static async Task With<T, TDraft>(
            ProjectApiRoot apiRoot,
            TDraft draft,
            Func<TDraft, TDraft> draftAction,
            Action<T> func,
            Func<ProjectApiRoot, TDraft, Task<T>> createFunc,
            Func<ProjectApiRoot, T, Task> deleteFunc)
        {

            var buildDraft = draftAction.Invoke(draft);

            var resource = await createFunc(apiRoot, buildDraft);

            try
            {
                func(resource);
            }
            finally
            {
                await deleteFunc(apiRoot, resource);
            }
        }

        public static async Task WithListAsync<T, TDraft>(
            ProjectApiRoot apiRoot,
            TDraft draft,
            Func<TDraft, TDraft> draftAction,
            Func<List<T>, Task> func,
            int count,
            Func<ProjectApiRoot, TDraft, Task<T>> createFunc,
            Func<ProjectApiRoot, T, Task> deleteFunc
        )
        {
            var resourcesList = new List<T>();
            for (int i = 1; i <= count; i++)
            {
                var buildDraft = draftAction.Invoke(draft);
                var resource = await createFunc(apiRoot, buildDraft);
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
                    await deleteFunc(apiRoot, resource);
                }
            }
        }

        public static async Task WithUpdateableAsync<T, TDraft>(
            ProjectApiRoot client,
            TDraft draft,
            Func<TDraft, TDraft> draftAction,
            Func<T, Task<T>> func,
            Func<ProjectApiRoot, TDraft, Task<T>> createFunc,
            Func<ProjectApiRoot, T, Task> deleteFunc) where T : IBaseResource
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
                await deleteFunc(client, updatedResource != null ? updatedResource : resource);
            }
        }
        
        public static async Task AssertEventuallyAsync(Func<Task> runnableBlock, int maxWaitTimeSecond = 300,
            int waitBeforeRetryMilliseconds = 100)
        {
            var maxWaitTime = TimeSpan.FromSeconds(maxWaitTimeSecond);
            var waitBeforeRetry = TimeSpan.FromMilliseconds(waitBeforeRetryMilliseconds);
            await AssertEventuallyAsync(maxWaitTime, waitBeforeRetry, runnableBlock);
        }

        private static async Task AssertEventuallyAsync(TimeSpan maxWaitTime, TimeSpan waitBeforeRetry, Func<Task> runnableBlock)
        {
            long timeOutAt = (int)DateTime.Now.TimeOfDay.TotalMilliseconds + (int)maxWaitTime.TotalMilliseconds;
            while (true)
            {
                try
                {
                    await runnableBlock.Invoke();
                    // the block executed without throwing an exception, return
                    return;
                }
                catch (Exception)
                {
                    if ((int)DateTime.Now.TimeOfDay.TotalMilliseconds > timeOutAt) //if it's timeout
                    {
                        throw;
                    }
                }

                try
                {
                    Task.Delay((int)waitBeforeRetry.TotalMilliseconds).Wait();
                }
                catch (ThreadInterruptedException e)
                {
                    throw new SystemException(e.Message);
                }
            }
        }

    }

}
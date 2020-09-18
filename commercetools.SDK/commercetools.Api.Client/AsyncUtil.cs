using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;

namespace commercetools.Api.Client
{
    /// <summary>
    /// Helper class to run async methods within a sync process.
    /// </summary>
    [SuppressMessage("ReSharper", "CA2008", Justification = "library api")]
    public static class AsyncUtil
    {
        private static readonly TaskFactory TaskFactory = new
            TaskFactory(
                CancellationToken.None,
                TaskCreationOptions.None,
                TaskContinuationOptions.None,
                TaskScheduler.Default);

        /// <summary>
        /// Executes an async Task method which has a void return value synchronously
        /// USAGE: AsyncUtil.RunSync(() => AsyncMethod());
        /// </summary>
        /// <param name="task">Task method to execute</param>
        public static void RunSync(Func<Task> task)
            => TaskFactory.StartNew(task)
                .Unwrap()
                .GetAwaiter()
                .GetResult();

        /// <summary>
        /// Executes an async Task<T> method which has a T return type synchronously
        /// USAGE: T result = AsyncUtil.RunSync(() => AsyncMethod<T>());
        /// </summary>
        /// <typeparam name="TResult">Return Type</typeparam>
        /// <param name="task">Task<T> method to execute</param>
        /// <returns>TResult</returns>
        public static TResult RunSync<TResult>(Func<Task<TResult>> task)
            => TaskFactory.StartNew(task)
                .Unwrap()
                .GetAwaiter()
                .GetResult();
    }
}

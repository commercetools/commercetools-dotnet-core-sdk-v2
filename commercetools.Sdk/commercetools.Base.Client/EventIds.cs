using Microsoft.Extensions.Logging;

namespace commercetools.Base.Client
{
    internal static class EventIds
    {
        public static readonly EventId PipelineStart = new EventId(100, "RequestPipelineStart");
        public static readonly EventId PipelineEnd = new EventId(101, "RequestPipelineEnd");
    }
}
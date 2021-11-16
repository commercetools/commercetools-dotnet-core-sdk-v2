using System;


namespace commercetools.ImportApi.Models.Errors
{
    public partial class ConcurrentModificationError : IConcurrentModificationError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public long? SpecifiedVersion { get; set; }

        public long CurrentVersion { get; set; }

        public Object ConflictedResource { get; set; }
        public ConcurrentModificationError()
        {
            this.Code = "ConcurrentModification";
        }
    }
}

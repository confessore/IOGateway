using IOGateway.Enums;

namespace IOGateway.Models
{
    public class PipelineStatus
    {
        public Status Status { get; set; }
        public string GlobalId { get; set; }
        public long NumberOfRequests { get; set; }
    }
}

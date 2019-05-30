namespace IOGateway.Models
{
    public class NodeInfo
    {
        public string AppName { get; set; }
        public string AppVersion { get; set; }
        public int Duration { get; set; }
        public long JreAvailableProcessors { get; set; }
        public long JreAvailableMemory { get; set; }
        public long JreMaxMemory { get; set; }
        public long JreTotalMemory { get; set; }
        public string LatestMilestone { get; set; }
        public int LatestMilestoneIndex { get; set; }
        public string LatestSolidSubtangleMilestone { get; set; }
        public int LatestSolidSubtangleMilestoneIndex { get; set; }
        public int Neighbors { get; set; }
        public int PacketsQueueSize { get; set; }
        public long Time { get; set; }
        public int Tips { get; set; }
        public int TransactionsToRequest { get; set; }
    }
}

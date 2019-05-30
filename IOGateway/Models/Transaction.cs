namespace IOGateway.Models
{
    public class Transaction
    {
        public Address Address { get; set; }
        public long AttachmentTimestamp { get; set; }
        public long AttachmentTimestampLowerBound { get; set; }
        public long AttachmentTimestampUpperBound { get; set; }
        public Hash BranchTransaction { get; set; }
        public Hash BundleHash { get; set; }
        public int CurrentIndex { get; set; }
        public Fragment Fragment { get; set; }
        public Hash Hash { get; set; }
        public bool IsTail { get; set; }
        public int LastIndex { get; set; }
        public Tag Nonce { get; set; }
        public Tag ObsoleteTag { get; set; }
        public Tag Tag { get; set; }
        public long Timestamp { get; set; }
        public Hash TrunkTransaction { get; set; }
        public long Value { get; set; }
    }
}

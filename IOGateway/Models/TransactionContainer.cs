using IOGateway.Enums;

namespace IOGateway.Models
{
    public class TransactionContainer
    {
        public Transaction Transaction { get; set; }
        public bool IsConfirmed { get; set; }
        public string DecodedMessage { get; set; }
        public long Timestamp { get; set; }
        public TransactionType TransactionType { get; set; }
    }
}

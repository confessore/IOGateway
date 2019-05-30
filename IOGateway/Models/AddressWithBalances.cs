namespace IOGateway.Models
{
    public class AddressWithBalances
    {
        public Address[] Addresses { get; set; }
        public int Duration { get; set; }
        public int MilestoneIndex { get; set; }
        public TryteString[] References { get; set; }
    }
}

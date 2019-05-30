namespace IOGateway.Models
{
    public class Address
    {
        public long Balance { get; set; }
        public Checksum Checksum { get; set; }
        public int KeyIndex { get; set; }
        public AbstractPrivateKey PrivateKey { get; set; }
        public int SecurityLevel { get; set; }
        public bool SpentFrom { get; set; }
        public int TrytesLength { get; set; }
        public string Value { get; set; }
    }
}

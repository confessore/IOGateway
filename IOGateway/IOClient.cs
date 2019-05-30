using IOGateway.Enums;
using IOGateway.Models;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace IOGateway
{
    public class IOClient
    {
        readonly string baseAddress = "https://api.iogateway.cloud/";
        readonly string coreStatus = "api/Core/Status/";
        readonly string coreApiMapCalls = "api/Core/ApiMapCalls/";
        readonly string nodeGetNodeInfo = "api/Node/GetNodeInfo/";
        readonly string nodeGetLatestMilestoneIndex = "api/Node/GetLatestMilestoneIndex/";
        readonly string tangleAddress = "api/Tangle/address/";
        readonly string tangleBundle = "api/Tangle/bundle/";
        readonly string transactions = "/transactions/";
        readonly string transactionsDetails = "/transactions/details";
        readonly string tangleTransaction = "api/Tangle/transaction/";
        readonly string balance = "/balance/";

        public GatewayStatus CoreQueryStatus() =>
            CoreQueryStatusAsync().Result;

        public async Task<GatewayStatus> CoreQueryStatusAsync() =>
            JsonConvert.DeserializeObject<GatewayStatus>(await GetUrlAsync(baseAddress + coreStatus).ConfigureAwait(false));

        public NodeTree CoreQueryApiMapCalls() =>
            CoreQueryApiMapCallsAsync().Result;

        public async Task<NodeTree> CoreQueryApiMapCallsAsync() =>
            JsonConvert.DeserializeObject<NodeTree>(await GetUrlAsync(baseAddress + coreApiMapCalls).ConfigureAwait(false));

        public NodeInfo NodeQueryNodeInfo() =>
            NodeQueryNodeInfoAsync().Result;

        public async Task<NodeInfo> NodeQueryNodeInfoAsync() =>
            JsonConvert.DeserializeObject<NodeInfo>(await GetUrlAsync(baseAddress + nodeGetNodeInfo).ConfigureAwait(false));

        public int NodeQueryLatestMilestoneIndex() =>
            NodeQueryLatestMilestoneIndexAsync().Result;

        public async Task<int> NodeQueryLatestMilestoneIndexAsync() =>
            JsonConvert.DeserializeObject<int>(await GetUrlAsync(baseAddress + nodeGetLatestMilestoneIndex).ConfigureAwait(false));

        public string[] TangleQueryAddressTransactions(string address) =>
            TangleQueryAddressTransactionsAsync(address).Result;

        public async Task<string[]> TangleQueryAddressTransactionsAsync(string address) =>
            JsonConvert.DeserializeObject<string[]>(await GetUrlAsync(baseAddress + tangleAddress + address + transactions).ConfigureAwait(false));

        public string[] TangleQueryBundleTransactions(string hash) =>
            TangleQueryBundleTransactionsAsync(hash).Result;

        public async Task<string[]> TangleQueryBundleTransactionsAsync(string hash) =>
            JsonConvert.DeserializeObject<string[]>(await GetUrlAsync(baseAddress + tangleBundle + hash + transactions).ConfigureAwait(false));

        public TransactionContainer[] TangleQueryAddressTransactionsDetails(string address) =>
            TangleQueryAddressTransactionsDetailsAsync(address).Result;

        public async Task<TransactionContainer[]> TangleQueryAddressTransactionsDetailsAsync(string address) =>
            JsonConvert.DeserializeObject<TransactionContainer[]>(await GetUrlAsync(baseAddress + tangleAddress + address + transactionsDetails).ConfigureAwait(false));

        public TransactionContainer[] TangleQueryBundleTransactionsDetails(string hash, FilterCriteria filter = FilterCriteria.ConfirmedOnly) =>
            TangleQueryBundleTransactionsDetailsAsync(hash, filter).Result;

        public async Task<TransactionContainer[]> TangleQueryBundleTransactionsDetailsAsync(string hash, FilterCriteria filter = FilterCriteria.ConfirmedOnly) =>
            JsonConvert.DeserializeObject<TransactionContainer[]>(await GetUrlAsync(baseAddress + tangleBundle + hash + transactionsDetails + "?" + filter).ConfigureAwait(false));

        public AddressWithBalances TangleQueryAddressBalance(string address) =>
            TangleQueryAddressBalanceAsync(address).Result;

        public async Task<AddressWithBalances> TangleQueryAddressBalanceAsync(string address) =>
            JsonConvert.DeserializeObject<AddressWithBalances>(await GetUrlAsync(baseAddress + tangleAddress + address + balance).ConfigureAwait(false));

        public TransactionContainer[] TangleQueryTransaction(string hash) =>
            TangleQueryTransactionAsync(hash).Result;

        public async Task<TransactionContainer[]> TangleQueryTransactionAsync(string hash) =>
            JsonConvert.DeserializeObject<TransactionContainer[]>(await GetUrlAsync(baseAddress + tangleTransaction + hash).ConfigureAwait(false));

        async Task<string> GetUrlAsync(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            using (var response = (HttpWebResponse)await request.GetResponseAsync())
            using (var stream = response.GetResponseStream())
            using (var reader = new StreamReader(stream))
                return await reader.ReadToEndAsync();
        }
    }
}

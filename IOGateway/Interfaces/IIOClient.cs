using IOGateway.Enums;
using IOGateway.Models;
using System.Threading.Tasks;

namespace IOGateway.Interfaces
{
    interface IIOClient
    {
        GatewayStatus CoreQueryStatus();
        Task<GatewayStatus> CoreQueryStatusAsync();
        NodeTree CoreQueryApiMapCalls();
        Task<NodeTree> CoreQueryApiMapCallsAsync();
        NodeInfo NodeQueryNodeInfo();
        Task<NodeInfo> NodeQueryNodeInfoAsync();
        int NodeQueryLatestMilestoneIndex();
        Task<int> NodeQueryLatestMilestoneIndexAsync();
        string[] TangleQueryAddressTransactions(string address);
        Task<string[]> TangleQueryAddressTransactionsAsync(string address);
        string[] TangleQueryBundleTransactions(string hash);
        Task<string[]> TangleQueryBundleTransactionsAsync(string hash);
        TransactionContainer[] TangleQueryAddressTransactionsDetails(string address);
        Task<TransactionContainer[]> TangleQueryAddressTransactionsDetailsAsync(string address);
        TransactionContainer[] TangleQueryBundleTransactionsDetails(string hash, FilterCriteria filter = FilterCriteria.ConfirmedOnly);
        Task<TransactionContainer[]> TangleQueryBundleTransactionsDetailsAsync(string hash, FilterCriteria filter = FilterCriteria.ConfirmedOnly);
        AddressWithBalances TangleQueryAddressBalance(string address);
        Task<AddressWithBalances> TangleQueryAddressBalanceAsync(string address);
        TransactionContainer[] TangleQueryTransaction(string hash);
        Task<TransactionContainer[]> TangleQueryTransactionAsync(string hash);
    }
}

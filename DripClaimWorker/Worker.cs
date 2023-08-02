using Nethereum.Model;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using Account = Nethereum.Web3.Accounts.Account;
using dripObserver;

namespace DripClaimWorker;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private static string url;
    private static string botToken;
    private static string contractAddress;
    private readonly string k = "privateKey";

    public Worker(ILogger<Worker> logger)
    {
        _logger = logger;

        url = "https://bsc-dataseed.binance.org:443";
        botToken = "";
        contractAddress = "0xFFE811714ab35360b67eE195acE7C10D93f89D8C";
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {

            var account = new Account(k, 56);
            var web3 = new Web3(account, url);
            web3.TransactionManager.UseLegacyAsDefault = true;
            var dripUser = account.Address;
            var user = account.Address; ;


            _logger.LogInformation($"{DateTime.Now.ToShortTimeString()} - Start Claiming {account.Address}");

            var dripContractHandler = web3.Eth.GetContractHandler(contractAddress);          

            var balance = await web3.Eth.GetBalance.SendRequestAsync(user);
            var gasPrice = await web3.Eth.GasPrice.SendRequestAsync();

            _logger.LogInformation($"Balance BNB: {decimal.Parse(balance.Value.ToString()) / 1000000000000000000m} Gas Price: {decimal.Parse(gasPrice.Value.ToString()) / 1000000000000000000m}");

            var claimFunctionTxnReceipt = await dripContractHandler.SendRequestAndWaitForReceiptAsync<ClaimFunction>();

            if (claimFunctionTxnReceipt.Status.ToString() == "1")
            {
                 _logger.LogInformation($"Tansaction hash: {claimFunctionTxnReceipt.TransactionHash} Gas used:  {claimFunctionTxnReceipt.GasUsed}");
            }
            else
            {
                Console.WriteLine("error");
            }

            await Task.Delay(24*60*1000, stoppingToken);
        }
    }
}



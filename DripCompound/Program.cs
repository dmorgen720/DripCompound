using System;
using System.Threading.Tasks;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using dripObserver;


namespace DripCompound
{
    class Program
    {
        private System.Threading.Timer timer;
        private static string url = "https://bsc-dataseed.binance.org:443";
        private static string BotToken = "";
        private static string dripContractAddress = "0xFFE811714ab35360b67eE195acE7C10D93f89D8C";


        static async Task Main(string[] args)
        {
            // Get private keys from arguments
            string[] keys = args;
            
            // Coumpound each private key
            foreach (string k in keys)
            {
                var account = new Account(k, 56);
                var web3 = new Web3(account, url);
                web3.TransactionManager.UseLegacyAsDefault = true;
                var dripUser = account.Address;

                Compound(web3, account);
            }

        }

        private static async void Compound(Web3 web3, Account account)
        {
            Console.WriteLine("Run at:" + DateTime.Now.ToShortTimeString());

            var user = account.Address; ;

            var dripContractHandler = web3.Eth.GetContractHandler(dripContractAddress);

            var balance = await web3.Eth.GetBalance.SendRequestAsync(user);
            var gasPrice = await web3.Eth.GasPrice.SendRequestAsync();


            Console.WriteLine("Hydrate account: " + account.Address);
            Console.WriteLine("balance BNB:" + decimal.Parse(balance.Value.ToString()) / 1000000000000000000m);

            var rollFunctionTxnReceipt = await dripContractHandler.SendRequestAndWaitForReceiptAsync<RollFunction>();

            if (rollFunctionTxnReceipt.Status.ToString() == "1")
            {

                Console.WriteLine("Tansaction hash:" + rollFunctionTxnReceipt.TransactionHash);
                Console.WriteLine("Gas used:" + rollFunctionTxnReceipt.GasUsed);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}

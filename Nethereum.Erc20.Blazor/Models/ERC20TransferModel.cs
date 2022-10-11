using Nethereum.Contracts.Standards.ERC20.ContractDefinition;
using Nethereum.UI;

namespace Nethereum.Erc20.Blazor
{
    public class ERC20TransferModel
    {
        public ERC20ContractModel ERC20Contract { get; set; } = new ERC20ContractModel();
        public string To { get; set; } = "0x156bc2186c73F4960b916cd554842F69321dD53C";
        public decimal Value { get; set; }

        public TransferFunction GetTransferFunction(string from)
        {
            return new TransferFunction()
            {
                FromAddress = from,
                To = To,
                Value = Web3.Web3.Convert.ToWei(Value, ERC20Contract.DecimalPlaces),
                AmountToSend = 0
            };
        }
    }
}

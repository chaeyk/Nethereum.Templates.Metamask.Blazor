using FluentValidation;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace Nethereum.Erc20.Blazor
{
    public class ERC20ContractModel
    {
        public const int DEFAULT_DECIMALS = 18;
        public const string IX_SMART_CONTRACT = "0x123455D0f27E9e6c4447322524d6f2Acd22f340A";
        public ERC20ContractModel() { }

        public string Address { get; set; } = IX_SMART_CONTRACT;
        public int DecimalPlaces { get; set; } = DEFAULT_DECIMALS;
        public string Name { get; set; }
    }
   
}


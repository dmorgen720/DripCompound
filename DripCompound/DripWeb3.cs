
using System.Collections.Generic;
using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;


namespace dripObserver
{

    public partial class DripFaucetDeployment : DripFaucetDeploymentBase
    {
        public DripFaucetDeployment() : base(BYTECODE) { }
        public DripFaucetDeployment(string byteCode) : base(byteCode) { }
    }

    public class DripFaucetDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "";
        public DripFaucetDeploymentBase() : base(BYTECODE) { }
        public DripFaucetDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class CompoundTaxFunction : CompoundTaxFunctionBase { }

    [Function("CompoundTax", "uint256")]
    public class CompoundTaxFunctionBase : FunctionMessage
    {

    }

    public partial class ExitTaxFunction : ExitTaxFunctionBase { }

    [Function("ExitTax", "uint256")]
    public class ExitTaxFunctionBase : FunctionMessage
    {

    }

    public partial class MAX_UINTFunction : MAX_UINTFunctionBase { }

    [Function("MAX_UINT", "uint256")]
    public class MAX_UINTFunctionBase : FunctionMessage
    {

    }

    public partial class AirdropFunction : AirdropFunctionBase { }

    [Function("airdrop")]
    public class AirdropFunctionBase : FunctionMessage
    {
        [Parameter("address", "_to", 1)]
        public virtual string To { get; set; }
        [Parameter("uint256", "_amount", 2)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class AirdropsFunction : AirdropsFunctionBase { }

    [Function("airdrops", typeof(AirdropsOutputDTO))]
    public class AirdropsFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class BalanceLevelFunction : BalanceLevelFunctionBase { }

    [Function("balanceLevel", "uint8")]
    public class BalanceLevelFunctionBase : FunctionMessage
    {
        [Parameter("address", "_addr", 1)]
        public virtual string Addr { get; set; }
    }

    public partial class CheckinFunction : CheckinFunctionBase { }

    [Function("checkin")]
    public class CheckinFunctionBase : FunctionMessage
    {

    }

    public partial class ClaimFunction : ClaimFunctionBase { }

    [Function("claim")]
    public class ClaimFunctionBase : FunctionMessage
    {

    }

    public partial class ClaimsAvailableFunction : ClaimsAvailableFunctionBase { }

    [Function("claimsAvailable", "uint256")]
    public class ClaimsAvailableFunctionBase : FunctionMessage
    {
        [Parameter("address", "_addr", 1)]
        public virtual string Addr { get; set; }
    }

    public partial class ContractInfoFunction : ContractInfoFunctionBase { }

    [Function("contractInfo", typeof(ContractInfoOutputDTO))]
    public class ContractInfoFunctionBase : FunctionMessage
    {

    }

    public partial class CreditsAndDebitsFunction : CreditsAndDebitsFunctionBase { }

    [Function("creditsAndDebits", typeof(CreditsAndDebitsOutputDTO))]
    public class CreditsAndDebitsFunctionBase : FunctionMessage
    {
        [Parameter("address", "_addr", 1)]
        public virtual string Addr { get; set; }
    }

    public partial class CustodyFunction : CustodyFunctionBase { }

    [Function("custody", typeof(CustodyOutputDTO))]
    public class CustodyFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class DepositFunction : DepositFunctionBase { }

    [Function("deposit")]
    public class DepositFunctionBase : FunctionMessage
    {
        [Parameter("address", "_upline", 1)]
        public virtual string Upline { get; set; }
        [Parameter("uint256", "_amount", 2)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class Deposit_bracket_sizeFunction : Deposit_bracket_sizeFunctionBase { }

    [Function("deposit_bracket_size", "uint256")]
    public class Deposit_bracket_sizeFunctionBase : FunctionMessage
    {

    }

    public partial class DripVaultAddressFunction : DripVaultAddressFunctionBase { }

    [Function("dripVaultAddress", "address")]
    public class DripVaultAddressFunctionBase : FunctionMessage
    {

    }

    public partial class GetCustodyFunction : GetCustodyFunctionBase { }

    [Function("getCustody", typeof(GetCustodyOutputDTO))]
    public class GetCustodyFunctionBase : FunctionMessage
    {
        [Parameter("address", "_addr", 1)]
        public virtual string Addr { get; set; }
    }

    public partial class InitializeFunction : InitializeFunctionBase { }

    [Function("initialize")]
    public class InitializeFunctionBase : FunctionMessage
    {

    }

    public partial class IsBalanceCoveredFunction : IsBalanceCoveredFunctionBase { }

    [Function("isBalanceCovered", "bool")]
    public class IsBalanceCoveredFunctionBase : FunctionMessage
    {
        [Parameter("address", "_addr", 1)]
        public virtual string Addr { get; set; }
        [Parameter("uint8", "_level", 2)]
        public virtual byte Level { get; set; }
    }

    public partial class IsNetPositiveFunction : IsNetPositiveFunctionBase { }

    [Function("isNetPositive", "bool")]
    public class IsNetPositiveFunctionBase : FunctionMessage
    {
        [Parameter("address", "_addr", 1)]
        public virtual string Addr { get; set; }
    }

    public partial class LastActivityFunction : LastActivityFunctionBase { }

    [Function("lastActivity", typeof(LastActivityOutputDTO))]
    public class LastActivityFunctionBase : FunctionMessage
    {
        [Parameter("address", "_addr", 1)]
        public virtual string Addr { get; set; }
    }

    public partial class MaxPayoutOfFunction : MaxPayoutOfFunctionBase { }

    [Function("maxPayoutOf", "uint256")]
    public class MaxPayoutOfFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_amount", 1)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class Max_payout_capFunction : Max_payout_capFunctionBase { }

    [Function("max_payout_cap", "uint256")]
    public class Max_payout_capFunctionBase : FunctionMessage
    {

    }

    public partial class OwnerFunction : OwnerFunctionBase { }

    [Function("owner", "address")]
    public class OwnerFunctionBase : FunctionMessage
    {

    }

    public partial class PayoutOfFunction : PayoutOfFunctionBase { }

    [Function("payoutOf", typeof(PayoutOfOutputDTO))]
    public class PayoutOfFunctionBase : FunctionMessage
    {
        [Parameter("address", "_addr", 1)]
        public virtual string Addr { get; set; }
    }

    public partial class Ref_balancesFunction : Ref_balancesFunctionBase { }

    [Function("ref_balances", "uint256")]
    public class Ref_balancesFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class RenounceOwnershipFunction : RenounceOwnershipFunctionBase { }

    [Function("renounceOwnership")]
    public class RenounceOwnershipFunctionBase : FunctionMessage
    {

    }

    public partial class RollFunction : RollFunctionBase { }

    [Function("roll")]
    public class RollFunctionBase : FunctionMessage
    {

    }

    public partial class SustainabilityFeeV2Function : SustainabilityFeeV2FunctionBase { }

    [Function("sustainabilityFeeV2", "uint256")]
    public class SustainabilityFeeV2FunctionBase : FunctionMessage
    {
        [Parameter("address", "_addr", 1)]
        public virtual string Addr { get; set; }
        [Parameter("uint256", "_pendingDiv", 2)]
        public virtual BigInteger PendingDiv { get; set; }
    }

    public partial class Total_airdropsFunction : Total_airdropsFunctionBase { }

    [Function("total_airdrops", "uint256")]
    public class Total_airdropsFunctionBase : FunctionMessage
    {

    }

    public partial class Total_bnbFunction : Total_bnbFunctionBase { }

    [Function("total_bnb", "uint256")]
    public class Total_bnbFunctionBase : FunctionMessage
    {

    }

    public partial class Total_depositedFunction : Total_depositedFunctionBase { }

    [Function("total_deposited", "uint256")]
    public class Total_depositedFunctionBase : FunctionMessage
    {

    }

    public partial class Total_txsFunction : Total_txsFunctionBase { }

    [Function("total_txs", "uint256")]
    public class Total_txsFunctionBase : FunctionMessage
    {

    }

    public partial class Total_usersFunction : Total_usersFunctionBase { }

    [Function("total_users", "uint256")]
    public class Total_usersFunctionBase : FunctionMessage
    {

    }

    public partial class Total_withdrawFunction : Total_withdrawFunctionBase { }

    [Function("total_withdraw", "uint256")]
    public class Total_withdrawFunctionBase : FunctionMessage
    {

    }

    public partial class TransferOwnershipFunction : TransferOwnershipFunctionBase { }

    [Function("transferOwnership")]
    public class TransferOwnershipFunctionBase : FunctionMessage
    {
        [Parameter("address", "newOwner", 1)]
        public virtual string NewOwner { get; set; }
    }

    public partial class UpdateCompoundTaxFunction : UpdateCompoundTaxFunctionBase { }

    [Function("updateCompoundTax")]
    public class UpdateCompoundTaxFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_newCompoundTax", 1)]
        public virtual BigInteger NewCompoundTax { get; set; }
    }

    public partial class UpdateDepositBracketSizeFunction : UpdateDepositBracketSizeFunctionBase { }

    [Function("updateDepositBracketSize")]
    public class UpdateDepositBracketSizeFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_newBracketSize", 1)]
        public virtual BigInteger NewBracketSize { get; set; }
    }

    public partial class UpdateExitTaxFunction : UpdateExitTaxFunctionBase { }

    [Function("updateExitTax")]
    public class UpdateExitTaxFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_newExitTax", 1)]
        public virtual BigInteger NewExitTax { get; set; }
    }

    public partial class UpdateHoldRequirementsFunction : UpdateHoldRequirementsFunctionBase { }

    [Function("updateHoldRequirements")]
    public class UpdateHoldRequirementsFunctionBase : FunctionMessage
    {
        [Parameter("uint256[]", "_newRefBalances", 1)]
        public virtual List<BigInteger> NewRefBalances { get; set; }
    }

    public partial class UpdateInitialDepositFunction : UpdateInitialDepositFunctionBase { }

    [Function("updateInitialDeposit")]
    public class UpdateInitialDepositFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_newInitialDeposit", 1)]
        public virtual BigInteger NewInitialDeposit { get; set; }
    }

    public partial class UpdateMaxPayoutCapFunction : UpdateMaxPayoutCapFunctionBase { }

    [Function("updateMaxPayoutCap")]
    public class UpdateMaxPayoutCapFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_newPayoutCap", 1)]
        public virtual BigInteger NewPayoutCap { get; set; }
    }

    public partial class UpdatePayoutRateFunction : UpdatePayoutRateFunctionBase { }

    [Function("updatePayoutRate")]
    public class UpdatePayoutRateFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_newPayoutRate", 1)]
        public virtual BigInteger NewPayoutRate { get; set; }
    }

    public partial class UpdateRefBonusFunction : UpdateRefBonusFunctionBase { }

    [Function("updateRefBonus")]
    public class UpdateRefBonusFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_newRefBonus", 1)]
        public virtual BigInteger NewRefBonus { get; set; }
    }

    public partial class UpdateRefDepthFunction : UpdateRefDepthFunctionBase { }

    [Function("updateRefDepth")]
    public class UpdateRefDepthFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_newRefDepth", 1)]
        public virtual BigInteger NewRefDepth { get; set; }
    }

    public partial class UserInfoFunction : UserInfoFunctionBase { }

    [Function("userInfo", typeof(UserInfoOutputDTO))]
    public class UserInfoFunctionBase : FunctionMessage
    {
        [Parameter("address", "_addr", 1)]
        public virtual string Addr { get; set; }
    }

    public partial class UserInfoTotalsFunction : UserInfoTotalsFunctionBase { }

    [Function("userInfoTotals", typeof(UserInfoTotalsOutputDTO))]
    public class UserInfoTotalsFunctionBase : FunctionMessage
    {
        [Parameter("address", "_addr", 1)]
        public virtual string Addr { get; set; }
    }

    public partial class UsersFunction : UsersFunctionBase { }

    [Function("users", typeof(UsersOutputDTO))]
    public class UsersFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class BalanceTransferEventDTO : BalanceTransferEventDTOBase { }

    [Event("BalanceTransfer")]
    public class BalanceTransferEventDTOBase : IEventDTO
    {
        [Parameter("address", "_src", 1, true)]
        public virtual string Src { get; set; }
        [Parameter("address", "_dest", 2, true)]
        public virtual string Dest { get; set; }
        [Parameter("uint256", "_deposits", 3, false)]
        public virtual BigInteger Deposits { get; set; }
        [Parameter("uint256", "_payouts", 4, false)]
        public virtual BigInteger Payouts { get; set; }
    }

    public partial class BeneficiaryUpdateEventDTO : BeneficiaryUpdateEventDTOBase { }

    [Event("BeneficiaryUpdate")]
    public class BeneficiaryUpdateEventDTOBase : IEventDTO
    {
        [Parameter("address", "addr", 1, true)]
        public virtual string Addr { get; set; }
        [Parameter("address", "beneficiary", 2, true)]
        public virtual string Beneficiary { get; set; }
    }

    public partial class CheckinEventDTO : CheckinEventDTOBase { }

    [Event("Checkin")]
    public class CheckinEventDTOBase : IEventDTO
    {
        [Parameter("address", "addr", 1, true)]
        public virtual string Addr { get; set; }
        [Parameter("uint256", "timestamp", 2, false)]
        public virtual BigInteger Timestamp { get; set; }
    }

    public partial class DirectPayoutEventDTO : DirectPayoutEventDTOBase { }

    [Event("DirectPayout")]
    public class DirectPayoutEventDTOBase : IEventDTO
    {
        [Parameter("address", "addr", 1, true)]
        public virtual string Addr { get; set; }
        [Parameter("address", "from", 2, true)]
        public virtual string From { get; set; }
        [Parameter("uint256", "amount", 3, false)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class HeartBeatEventDTO : HeartBeatEventDTOBase { }

    [Event("HeartBeat")]
    public class HeartBeatEventDTOBase : IEventDTO
    {
        [Parameter("address", "addr", 1, true)]
        public virtual string Addr { get; set; }
        [Parameter("uint256", "timestamp", 2, false)]
        public virtual BigInteger Timestamp { get; set; }
    }

    public partial class HeartBeatIntervalUpdateEventDTO : HeartBeatIntervalUpdateEventDTOBase { }

    [Event("HeartBeatIntervalUpdate")]
    public class HeartBeatIntervalUpdateEventDTOBase : IEventDTO
    {
        [Parameter("address", "addr", 1, true)]
        public virtual string Addr { get; set; }
        [Parameter("uint256", "interval", 2, false)]
        public virtual BigInteger Interval { get; set; }
    }

    public partial class LeaderboardEventDTO : LeaderboardEventDTOBase { }

    [Event("Leaderboard")]
    public class LeaderboardEventDTOBase : IEventDTO
    {
        [Parameter("address", "addr", 1, true)]
        public virtual string Addr { get; set; }
        [Parameter("uint256", "referrals", 2, false)]
        public virtual BigInteger Referrals { get; set; }
        [Parameter("uint256", "total_deposits", 3, false)]
        public virtual BigInteger Total_deposits { get; set; }
        [Parameter("uint256", "total_payouts", 4, false)]
        public virtual BigInteger Total_payouts { get; set; }
        [Parameter("uint256", "total_structure", 5, false)]
        public virtual BigInteger Total_structure { get; set; }
    }

    public partial class LimitReachedEventDTO : LimitReachedEventDTOBase { }

    [Event("LimitReached")]
    public class LimitReachedEventDTOBase : IEventDTO
    {
        [Parameter("address", "addr", 1, true)]
        public virtual string Addr { get; set; }
        [Parameter("uint256", "amount", 2, false)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class ManagerUpdateEventDTO : ManagerUpdateEventDTOBase { }

    [Event("ManagerUpdate")]
    public class ManagerUpdateEventDTOBase : IEventDTO
    {
        [Parameter("address", "addr", 1, true)]
        public virtual string Addr { get; set; }
        [Parameter("address", "manager", 2, true)]
        public virtual string Manager { get; set; }
        [Parameter("uint256", "timestamp", 3, false)]
        public virtual BigInteger Timestamp { get; set; }
    }

    public partial class MatchPayoutEventDTO : MatchPayoutEventDTOBase { }

    [Event("MatchPayout")]
    public class MatchPayoutEventDTOBase : IEventDTO
    {
        [Parameter("address", "addr", 1, true)]
        public virtual string Addr { get; set; }
        [Parameter("address", "from", 2, true)]
        public virtual string From { get; set; }
        [Parameter("uint256", "amount", 3, false)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class NewAirdropEventDTO : NewAirdropEventDTOBase { }

    [Event("NewAirdrop")]
    public class NewAirdropEventDTOBase : IEventDTO
    {
        [Parameter("address", "from", 1, true)]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2, true)]
        public virtual string To { get; set; }
        [Parameter("uint256", "amount", 3, false)]
        public virtual BigInteger Amount { get; set; }
        [Parameter("uint256", "timestamp", 4, false)]
        public virtual BigInteger Timestamp { get; set; }
    }

    public partial class NewDepositEventDTO : NewDepositEventDTOBase { }

    [Event("NewDeposit")]
    public class NewDepositEventDTOBase : IEventDTO
    {
        [Parameter("address", "addr", 1, true)]
        public virtual string Addr { get; set; }
        [Parameter("uint256", "amount", 2, false)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class OwnershipTransferredEventDTO : OwnershipTransferredEventDTOBase { }

    [Event("OwnershipTransferred")]
    public class OwnershipTransferredEventDTOBase : IEventDTO
    {
        [Parameter("address", "previousOwner", 1, true)]
        public virtual string PreviousOwner { get; set; }
        [Parameter("address", "newOwner", 2, true)]
        public virtual string NewOwner { get; set; }
    }

    public partial class UplineEventDTO : UplineEventDTOBase { }

    [Event("Upline")]
    public class UplineEventDTOBase : IEventDTO
    {
        [Parameter("address", "addr", 1, true)]
        public virtual string Addr { get; set; }
        [Parameter("address", "upline", 2, true)]
        public virtual string Upline { get; set; }
    }

    public partial class WithdrawEventDTO : WithdrawEventDTOBase { }

    [Event("Withdraw")]
    public class WithdrawEventDTOBase : IEventDTO
    {
        [Parameter("address", "addr", 1, true)]
        public virtual string Addr { get; set; }
        [Parameter("uint256", "amount", 2, false)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class CompoundTaxOutputDTO : CompoundTaxOutputDTOBase { }

    [FunctionOutput]
    public class CompoundTaxOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class ExitTaxOutputDTO : ExitTaxOutputDTOBase { }

    [FunctionOutput]
    public class ExitTaxOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class MAX_UINTOutputDTO : MAX_UINTOutputDTOBase { }

    [FunctionOutput]
    public class MAX_UINTOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }



    public partial class AirdropsOutputDTO : AirdropsOutputDTOBase { }

    [FunctionOutput]
    public class AirdropsOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "airdrops", 1)]
        public virtual BigInteger Airdrops { get; set; }
        [Parameter("uint256", "airdrops_received", 2)]
        public virtual BigInteger Airdrops_received { get; set; }
        [Parameter("uint256", "last_airdrop", 3)]
        public virtual BigInteger Last_airdrop { get; set; }
    }

    public partial class BalanceLevelOutputDTO : BalanceLevelOutputDTOBase { }

    [FunctionOutput]
    public class BalanceLevelOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint8", "", 1)]
        public virtual byte ReturnValue1 { get; set; }
    }





    public partial class ClaimsAvailableOutputDTO : ClaimsAvailableOutputDTOBase { }

    [FunctionOutput]
    public class ClaimsAvailableOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class ContractInfoOutputDTO : ContractInfoOutputDTOBase { }

    [FunctionOutput]
    public class ContractInfoOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "_total_users", 1)]
        public virtual BigInteger Total_users { get; set; }
        [Parameter("uint256", "_total_deposited", 2)]
        public virtual BigInteger Total_deposited { get; set; }
        [Parameter("uint256", "_total_withdraw", 3)]
        public virtual BigInteger Total_withdraw { get; set; }
        [Parameter("uint256", "_total_bnb", 4)]
        public virtual BigInteger Total_bnb { get; set; }
        [Parameter("uint256", "_total_txs", 5)]
        public virtual BigInteger Total_txs { get; set; }
        [Parameter("uint256", "_total_airdrops", 6)]
        public virtual BigInteger Total_airdrops { get; set; }
    }

    public partial class CreditsAndDebitsOutputDTO : CreditsAndDebitsOutputDTOBase { }

    [FunctionOutput]
    public class CreditsAndDebitsOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "_credits", 1)]
        public virtual BigInteger Credits { get; set; }
        [Parameter("uint256", "_debits", 2)]
        public virtual BigInteger Debits { get; set; }
    }

    public partial class CustodyOutputDTO : CustodyOutputDTOBase { }

    [FunctionOutput]
    public class CustodyOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("address", "manager", 1)]
        public virtual string Manager { get; set; }
        [Parameter("address", "beneficiary", 2)]
        public virtual string Beneficiary { get; set; }
        [Parameter("uint256", "last_heartbeat", 3)]
        public virtual BigInteger Last_heartbeat { get; set; }
        [Parameter("uint256", "last_checkin", 4)]
        public virtual BigInteger Last_checkin { get; set; }
        [Parameter("uint256", "heartbeat_interval", 5)]
        public virtual BigInteger Heartbeat_interval { get; set; }
    }


    public partial class Deposit_bracket_sizeOutputDTO : Deposit_bracket_sizeOutputDTOBase { }

    [FunctionOutput]
    public class Deposit_bracket_sizeOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class DripVaultAddressOutputDTO : DripVaultAddressOutputDTOBase { }

    [FunctionOutput]
    public class DripVaultAddressOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class GetCustodyOutputDTO : GetCustodyOutputDTOBase { }

    [FunctionOutput]
    public class GetCustodyOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("address", "_beneficiary", 1)]
        public virtual string Beneficiary { get; set; }
        [Parameter("uint256", "_heartbeat_interval", 2)]
        public virtual BigInteger Heartbeat_interval { get; set; }
        [Parameter("address", "_manager", 3)]
        public virtual string Manager { get; set; }
    }



    public partial class IsBalanceCoveredOutputDTO : IsBalanceCoveredOutputDTOBase { }

    [FunctionOutput]
    public class IsBalanceCoveredOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class IsNetPositiveOutputDTO : IsNetPositiveOutputDTOBase { }

    [FunctionOutput]
    public class IsNetPositiveOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class LastActivityOutputDTO : LastActivityOutputDTOBase { }

    [FunctionOutput]
    public class LastActivityOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "_heartbeat", 1)]
        public virtual BigInteger Heartbeat { get; set; }
        [Parameter("uint256", "_lapsed_heartbeat", 2)]
        public virtual BigInteger Lapsed_heartbeat { get; set; }
        [Parameter("uint256", "_checkin", 3)]
        public virtual BigInteger Checkin { get; set; }
        [Parameter("uint256", "_lapsed_checkin", 4)]
        public virtual BigInteger Lapsed_checkin { get; set; }
    }

    public partial class MaxPayoutOfOutputDTO : MaxPayoutOfOutputDTOBase { }

    [FunctionOutput]
    public class MaxPayoutOfOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class Max_payout_capOutputDTO : Max_payout_capOutputDTOBase { }

    [FunctionOutput]
    public class Max_payout_capOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class PayoutOfOutputDTO : PayoutOfOutputDTOBase { }

    [FunctionOutput]
    public class PayoutOfOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "payout", 1)]
        public virtual BigInteger Payout { get; set; }
        [Parameter("uint256", "max_payout", 2)]
        public virtual BigInteger Max_payout { get; set; }
        [Parameter("uint256", "net_payout", 3)]
        public virtual BigInteger Net_payout { get; set; }
        [Parameter("uint256", "sustainability_fee", 4)]
        public virtual BigInteger Sustainability_fee { get; set; }
    }

    public partial class Ref_balancesOutputDTO : Ref_balancesOutputDTOBase { }

    [FunctionOutput]
    public class Ref_balancesOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }





    public partial class SustainabilityFeeV2OutputDTO : SustainabilityFeeV2OutputDTOBase { }

    [FunctionOutput]
    public class SustainabilityFeeV2OutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class Total_airdropsOutputDTO : Total_airdropsOutputDTOBase { }

    [FunctionOutput]
    public class Total_airdropsOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class Total_bnbOutputDTO : Total_bnbOutputDTOBase { }

    [FunctionOutput]
    public class Total_bnbOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class Total_depositedOutputDTO : Total_depositedOutputDTOBase { }

    [FunctionOutput]
    public class Total_depositedOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class Total_txsOutputDTO : Total_txsOutputDTOBase { }

    [FunctionOutput]
    public class Total_txsOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class Total_usersOutputDTO : Total_usersOutputDTOBase { }

    [FunctionOutput]
    public class Total_usersOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class Total_withdrawOutputDTO : Total_withdrawOutputDTOBase { }

    [FunctionOutput]
    public class Total_withdrawOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }



    public partial class UserInfoOutputDTO : UserInfoOutputDTOBase { }

    [FunctionOutput]
    public class UserInfoOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("address", "upline", 1)]
        public virtual string Upline { get; set; }
        [Parameter("uint256", "deposit_time", 2)]
        public virtual BigInteger Deposit_time { get; set; }
        [Parameter("uint256", "deposits", 3)]
        public virtual BigInteger Deposits { get; set; }
        [Parameter("uint256", "payouts", 4)]
        public virtual BigInteger Payouts { get; set; }
        [Parameter("uint256", "direct_bonus", 5)]
        public virtual BigInteger Direct_bonus { get; set; }
        [Parameter("uint256", "match_bonus", 6)]
        public virtual BigInteger Match_bonus { get; set; }
        [Parameter("uint256", "last_airdrop", 7)]
        public virtual BigInteger Last_airdrop { get; set; }
    }

    public partial class UserInfoTotalsOutputDTO : UserInfoTotalsOutputDTOBase { }

    [FunctionOutput]
    public class UserInfoTotalsOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "referrals", 1)]
        public virtual BigInteger Referrals { get; set; }
        [Parameter("uint256", "total_deposits", 2)]
        public virtual BigInteger Total_deposits { get; set; }
        [Parameter("uint256", "total_payouts", 3)]
        public virtual BigInteger Total_payouts { get; set; }
        [Parameter("uint256", "total_structure", 4)]
        public virtual BigInteger Total_structure { get; set; }
        [Parameter("uint256", "airdrops_total", 5)]
        public virtual BigInteger Airdrops_total { get; set; }
        [Parameter("uint256", "airdrops_received", 6)]
        public virtual BigInteger Airdrops_received { get; set; }
    }

    public partial class UsersOutputDTO : UsersOutputDTOBase { }

    [FunctionOutput]
    public class UsersOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("address", "upline", 1)]
        public virtual string Upline { get; set; }
        [Parameter("uint256", "referrals", 2)]
        public virtual BigInteger Referrals { get; set; }
        [Parameter("uint256", "total_structure", 3)]
        public virtual BigInteger Total_structure { get; set; }
        [Parameter("uint256", "direct_bonus", 4)]
        public virtual BigInteger Direct_bonus { get; set; }
        [Parameter("uint256", "match_bonus", 5)]
        public virtual BigInteger Match_bonus { get; set; }
        [Parameter("uint256", "deposits", 6)]
        public virtual BigInteger Deposits { get; set; }
        [Parameter("uint256", "deposit_time", 7)]
        public virtual BigInteger Deposit_time { get; set; }
        [Parameter("uint256", "payouts", 8)]
        public virtual BigInteger Payouts { get; set; }
        [Parameter("uint256", "rolls", 9)]
        public virtual BigInteger Rolls { get; set; }
        [Parameter("uint256", "ref_claim_pos", 10)]
        public virtual BigInteger Ref_claim_pos { get; set; }
        [Parameter("uint256", "accumulatedDiv", 11)]
        public virtual BigInteger AccumulatedDiv { get; set; }
    }


    public partial class GardenContractDeployment : GardenContractDeploymentBase
    {
        public GardenContractDeployment() : base(BYTECODE) { }
        public GardenContractDeployment(string byteCode) : base(byteCode) { }
    }

    public class GardenContractDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "";
        public GardenContractDeploymentBase() : base(BYTECODE) { }
        public GardenContractDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class BusdAddressFunction : BusdAddressFunctionBase { }

    [Function("BusdAddress", "address")]
    public class BusdAddressFunctionBase : FunctionMessage
    {

    }

    public partial class DripAddressFunction : DripAddressFunctionBase { }

    [Function("DripAddress", "address")]
    public class DripAddressFunctionBase : FunctionMessage
    {

    }

    public partial class DripBusdLpFunction : DripBusdLpFunctionBase { }

    [Function("DripBusdLp", "address")]
    public class DripBusdLpFunctionBase : FunctionMessage
    {

    }

    public partial class DripVaultAddressFunction : DripVaultAddressFunctionBase { }



    public partial class MarketingAndDevelopmentAddressFunction : MarketingAndDevelopmentAddressFunctionBase { }

    [Function("MarketingAndDevelopmentAddress", "address")]
    public class MarketingAndDevelopmentAddressFunctionBase : FunctionMessage
    {

    }

    public partial class PancakeSwapRouterFunction : PancakeSwapRouterFunctionBase { }

    [Function("PancakeSwapRouter", "address")]
    public class PancakeSwapRouterFunctionBase : FunctionMessage
    {

    }

    public partial class PancakeSwapRouterAddressFunction : PancakeSwapRouterAddressFunctionBase { }

    [Function("PancakeSwapRouterAddress", "address")]
    public class PancakeSwapRouterAddressFunctionBase : FunctionMessage
    {

    }

    public partial class SEEDS_TO_GROW_1PLANTFunction : SEEDS_TO_GROW_1PLANTFunctionBase { }

    [Function("SEEDS_TO_GROW_1PLANT", "uint256")]
    public class SEEDS_TO_GROW_1PLANTFunctionBase : FunctionMessage
    {

    }

    public partial class BuySeedsFunction : BuySeedsFunctionBase { }

    [Function("buySeeds")]
    public class BuySeedsFunctionBase : FunctionMessage
    {
        [Parameter("address", "ref", 1)]
        public virtual string Ref { get; set; }
        [Parameter("uint256", "amount", 2)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class CalculateSeedSellFunction : CalculateSeedSellFunctionBase { }

    [Function("calculateSeedSell", "uint256")]
    public class CalculateSeedSellFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "seeds", 1)]
        public virtual BigInteger Seeds { get; set; }
    }

    public partial class CalculateSeedsBuyFunction : CalculateSeedsBuyFunctionBase { }

    [Function("calculateSeedsBuy", "uint256")]
    public class CalculateSeedsBuyFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "bnb", 1)]
        public virtual BigInteger Bnb { get; set; }
        [Parameter("uint256", "contractBalance", 2)]
        public virtual BigInteger ContractBalance { get; set; }
    }

    public partial class CalculateSeedsBuySimpleFunction : CalculateSeedsBuySimpleFunctionBase { }

    [Function("calculateSeedsBuySimple", "uint256")]
    public class CalculateSeedsBuySimpleFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "bnb", 1)]
        public virtual BigInteger Bnb { get; set; }
    }

    public partial class CalculateSeedsBuySimpleBalanceFunction : CalculateSeedsBuySimpleBalanceFunctionBase { }

    [Function("calculateSeedsBuySimpleBalance", "uint256")]
    public class CalculateSeedsBuySimpleBalanceFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "bnb", 1)]
        public virtual BigInteger Bnb { get; set; }
    }

    public partial class CalculateSeedsBuySimpleTimeFunction : CalculateSeedsBuySimpleTimeFunctionBase { }

    [Function("calculateSeedsBuySimpleTime", "uint256")]
    public class CalculateSeedsBuySimpleTimeFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "bnb", 1)]
        public virtual BigInteger Bnb { get; set; }
    }

    public partial class CalculateSeedsBuySimpleTotalFunction : CalculateSeedsBuySimpleTotalFunctionBase { }

    [Function("calculateSeedsBuySimpleTotal", "uint256")]
    public class CalculateSeedsBuySimpleTotalFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "bnb", 1)]
        public virtual BigInteger Bnb { get; set; }
    }

    public partial class CalculateSeedsBuyTotalFunction : CalculateSeedsBuyTotalFunctionBase { }

    [Function("calculateSeedsBuyTotal", "uint256")]
    public class CalculateSeedsBuyTotalFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "bnb", 1)]
        public virtual BigInteger Bnb { get; set; }
        [Parameter("uint256", "contractBalance", 2)]
        public virtual BigInteger ContractBalance { get; set; }
    }

    public partial class CalculateTradeFunction : CalculateTradeFunctionBase { }

    [Function("calculateTrade", "uint256")]
    public class CalculateTradeFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "rt", 1)]
        public virtual BigInteger Rt { get; set; }
        [Parameter("uint256", "rs", 2)]
        public virtual BigInteger Rs { get; set; }
        [Parameter("uint256", "bs", 3)]
        public virtual BigInteger Bs { get; set; }
    }

    public partial class ClaimedSeedsFunction : ClaimedSeedsFunctionBase { }

    [Function("claimedSeeds", "uint256")]
    public class ClaimedSeedsFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class CurrentBalanceMultiplierFunction : CurrentBalanceMultiplierFunctionBase { }

    [Function("currentBalanceMultiplier", "uint256")]
    public class CurrentBalanceMultiplierFunctionBase : FunctionMessage
    {

    }

    public partial class CurrentTimeMultiplierFunction : CurrentTimeMultiplierFunctionBase { }

    [Function("currentTimeMultiplier", "uint256")]
    public class CurrentTimeMultiplierFunctionBase : FunctionMessage
    {

    }

    public partial class DevFeeFunction : DevFeeFunctionBase { }

    [Function("devFee", "uint256")]
    public class DevFeeFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "amount", 1)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class GetBalanceFunction : GetBalanceFunctionBase { }

    [Function("getBalance", "uint256")]
    public class GetBalanceFunctionBase : FunctionMessage
    {

    }

    public partial class GetMyPlantsFunction : GetMyPlantsFunctionBase { }

    [Function("getMyPlants", "uint256")]
    public class GetMyPlantsFunctionBase : FunctionMessage
    {

    }

    public partial class GetMySeedsFunction : GetMySeedsFunctionBase { }

    [Function("getMySeeds", "uint256")]
    public class GetMySeedsFunctionBase : FunctionMessage
    {

    }

    public partial class GetSeedsSinceLastPlantFunction : GetSeedsSinceLastPlantFunctionBase { }

    [Function("getSeedsSinceLastPlant", "uint256")]
    public class GetSeedsSinceLastPlantFunctionBase : FunctionMessage
    {
        [Parameter("address", "adr", 1)]
        public virtual string Adr { get; set; }
    }

    public partial class GetUserSeedsFunction : GetUserSeedsFunctionBase { }

    [Function("getUserSeeds", "uint256")]
    public class GetUserSeedsFunctionBase : FunctionMessage
    {
        [Parameter("address", "_user", 1)]
        public virtual string User { get; set; }
    }

    public partial class HatcheryPlantsFunction : HatcheryPlantsFunctionBase { }

    [Function("hatcheryPlants", "uint256")]
    public class HatcheryPlantsFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class InitializedFunction : InitializedFunctionBase { }

    [Function("initialized", "bool")]
    public class InitializedFunctionBase : FunctionMessage
    {

    }

    public partial class LastPlantFunction : LastPlantFunctionBase { }

    [Function("lastPlant", "uint256")]
    public class LastPlantFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class MarketSeedsFunction : MarketSeedsFunctionBase { }

    [Function("marketSeeds", "uint256")]
    public class MarketSeedsFunctionBase : FunctionMessage
    {

    }

    public partial class OwnerFunction : OwnerFunctionBase { }



    public partial class PlantSeedsFunction : PlantSeedsFunctionBase { }

    [Function("plantSeeds")]
    public class PlantSeedsFunctionBase : FunctionMessage
    {
        [Parameter("address", "ref", 1)]
        public virtual string Ref { get; set; }
    }

    public partial class ReferralsFunction : ReferralsFunctionBase { }

    [Function("referrals", "address")]
    public class ReferralsFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class RenounceOwnershipFunction : RenounceOwnershipFunctionBase { }



    public partial class SeedMarketFunction : SeedMarketFunctionBase { }

    [Function("seedMarket")]
    public class SeedMarketFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "amount", 1)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class SellSeedsFunction : SellSeedsFunctionBase { }

    [Function("sellSeeds")]
    public class SellSeedsFunctionBase : FunctionMessage
    {

    }

    public partial class SetBalanceMultiplierFunction : SetBalanceMultiplierFunctionBase { }

    [Function("setBalanceMultiplier")]
    public class SetBalanceMultiplierFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_top", 1)]
        public virtual BigInteger Top { get; set; }
        [Parameter("uint256", "multiplier", 2)]
        public virtual BigInteger Multiplier { get; set; }
    }

    public partial class SetSeedAmountFunction : SetSeedAmountFunctionBase { }

    [Function("setSeedAmount")]
    public class SetSeedAmountFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_seed", 1)]
        public virtual BigInteger Seed { get; set; }
    }

    public partial class StartTimeFunction : StartTimeFunctionBase { }

    [Function("startTime", "uint256")]
    public class StartTimeFunctionBase : FunctionMessage
    {

    }

    public partial class TransferOwnershipFunction : TransferOwnershipFunctionBase { }



    public partial class OwnershipTransferredEventDTO : OwnershipTransferredEventDTOBase { }



    public partial class SeedsBoughtEventDTO : SeedsBoughtEventDTOBase { }

    [Event("SeedsBought")]
    public class SeedsBoughtEventDTOBase : IEventDTO
    {
        [Parameter("address", "sender", 1, true)]
        public virtual string Sender { get; set; }
        [Parameter("address", "ref", 2, false)]
        public virtual string Ref { get; set; }
        [Parameter("uint256", "amountBNB", 3, false)]
        public virtual BigInteger AmountBNB { get; set; }
        [Parameter("uint256", "amountEggs", 4, false)]
        public virtual BigInteger AmountEggs { get; set; }
    }

    public partial class SeedsPlantedEventDTO : SeedsPlantedEventDTOBase { }

    [Event("SeedsPlanted")]
    public class SeedsPlantedEventDTOBase : IEventDTO
    {
        [Parameter("address", "sender", 1, true)]
        public virtual string Sender { get; set; }
        [Parameter("address", "ref", 2, false)]
        public virtual string Ref { get; set; }
        [Parameter("uint256", "seedsUsed", 3, false)]
        public virtual BigInteger SeedsUsed { get; set; }
        [Parameter("uint256", "marketSeeds", 4, false)]
        public virtual BigInteger MarketSeeds { get; set; }
    }

    public partial class SeedsSoldEventDTO : SeedsSoldEventDTOBase { }

    [Event("SeedsSold")]
    public class SeedsSoldEventDTOBase : IEventDTO
    {
        [Parameter("address", "sender", 1, true)]
        public virtual string Sender { get; set; }
        [Parameter("uint256", "seedsSold", 2, false)]
        public virtual BigInteger SeedsSold { get; set; }
        [Parameter("uint256", "seedValue", 3, false)]
        public virtual BigInteger SeedValue { get; set; }
        [Parameter("uint256", "marketSeeds", 4, false)]
        public virtual BigInteger MarketSeeds { get; set; }
    }

    public partial class BusdAddressOutputDTO : BusdAddressOutputDTOBase { }

    [FunctionOutput]
    public class BusdAddressOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class DripAddressOutputDTO : DripAddressOutputDTOBase { }

    [FunctionOutput]
    public class DripAddressOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class DripBusdLpOutputDTO : DripBusdLpOutputDTOBase { }

    [FunctionOutput]
    public class DripBusdLpOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class DripVaultAddressOutputDTO : DripVaultAddressOutputDTOBase { }




    public partial class PancakeSwapRouterOutputDTO : PancakeSwapRouterOutputDTOBase { }

    [FunctionOutput]
    public class PancakeSwapRouterOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class PancakeSwapRouterAddressOutputDTO : PancakeSwapRouterAddressOutputDTOBase { }

    [FunctionOutput]
    public class PancakeSwapRouterAddressOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class SEEDS_TO_GROW_1PLANTOutputDTO : SEEDS_TO_GROW_1PLANTOutputDTOBase { }

    [FunctionOutput]
    public class SEEDS_TO_GROW_1PLANTOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }



    public partial class CalculateSeedSellOutputDTO : CalculateSeedSellOutputDTOBase { }

    [FunctionOutput]
    public class CalculateSeedSellOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class CalculateSeedsBuyOutputDTO : CalculateSeedsBuyOutputDTOBase { }

    [FunctionOutput]
    public class CalculateSeedsBuyOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class CalculateSeedsBuySimpleOutputDTO : CalculateSeedsBuySimpleOutputDTOBase { }

    [FunctionOutput]
    public class CalculateSeedsBuySimpleOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class CalculateSeedsBuySimpleBalanceOutputDTO : CalculateSeedsBuySimpleBalanceOutputDTOBase { }

    [FunctionOutput]
    public class CalculateSeedsBuySimpleBalanceOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class CalculateSeedsBuySimpleTimeOutputDTO : CalculateSeedsBuySimpleTimeOutputDTOBase { }

    [FunctionOutput]
    public class CalculateSeedsBuySimpleTimeOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class CalculateSeedsBuySimpleTotalOutputDTO : CalculateSeedsBuySimpleTotalOutputDTOBase { }

    [FunctionOutput]
    public class CalculateSeedsBuySimpleTotalOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class CalculateSeedsBuyTotalOutputDTO : CalculateSeedsBuyTotalOutputDTOBase { }

    [FunctionOutput]
    public class CalculateSeedsBuyTotalOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class CalculateTradeOutputDTO : CalculateTradeOutputDTOBase { }

    [FunctionOutput]
    public class CalculateTradeOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class ClaimedSeedsOutputDTO : ClaimedSeedsOutputDTOBase { }

    [FunctionOutput]
    public class ClaimedSeedsOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class CurrentBalanceMultiplierOutputDTO : CurrentBalanceMultiplierOutputDTOBase { }

    [FunctionOutput]
    public class CurrentBalanceMultiplierOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class CurrentTimeMultiplierOutputDTO : CurrentTimeMultiplierOutputDTOBase { }

    [FunctionOutput]
    public class CurrentTimeMultiplierOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class DevFeeOutputDTO : DevFeeOutputDTOBase { }

    [FunctionOutput]
    public class DevFeeOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class GetBalanceOutputDTO : GetBalanceOutputDTOBase { }

    [FunctionOutput]
    public class GetBalanceOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class GetMyPlantsOutputDTO : GetMyPlantsOutputDTOBase { }

    [FunctionOutput]
    public class GetMyPlantsOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class GetMySeedsOutputDTO : GetMySeedsOutputDTOBase { }

    [FunctionOutput]
    public class GetMySeedsOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class GetSeedsSinceLastPlantOutputDTO : GetSeedsSinceLastPlantOutputDTOBase { }

    [FunctionOutput]
    public class GetSeedsSinceLastPlantOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class GetUserSeedsOutputDTO : GetUserSeedsOutputDTOBase { }

    [FunctionOutput]
    public class GetUserSeedsOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class HatcheryPlantsOutputDTO : HatcheryPlantsOutputDTOBase { }

    [FunctionOutput]
    public class HatcheryPlantsOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class InitializedOutputDTO : InitializedOutputDTOBase { }

    [FunctionOutput]
    public class InitializedOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class LastPlantOutputDTO : LastPlantOutputDTOBase { }

    [FunctionOutput]
    public class LastPlantOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class MarketSeedsOutputDTO : MarketSeedsOutputDTOBase { }

    [FunctionOutput]
    public class MarketSeedsOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }



    public partial class ReferralsOutputDTO : ReferralsOutputDTOBase { }

    [FunctionOutput]
    public class ReferralsOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }



    public partial class StartTimeOutputDTO : StartTimeOutputDTOBase { }

    [FunctionOutput]
    public class StartTimeOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

}
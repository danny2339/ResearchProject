// This class was generated on Tue, 30 Jan 2018 11:14:21 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// FundingInstrument.cs
// @version 0.1.0-dev+6beb51-dirty
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.v1.BillingAgreements
{
    /// <summary>
    /// Information about a customer's funding instrument.
    /// </summary>
    [DataContract]
    public class FundingInstrument
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public FundingInstrument() {}

        /// <summary>
        /// A bank account that can be used to fund a payment. Supports Single Euro Payments Area (SEPA) bank accounts.
        /// </summary>
        [DataMember(Name="bank_account", EmitDefaultValue = false)]
        public ExtendedBankAccount BankAccount;

        /// <summary>
        /// A token for a bank card. Can be used to fund a payment.
        /// </summary>
        [DataMember(Name="bank_account_token", EmitDefaultValue = false)]
        public BankToken BankAccountToken;

        /// <summary>
        /// A payment card that can be used to fund a payment.
        /// </summary>
        [DataMember(Name="payment_card", EmitDefaultValue = false)]
        public PaymentCard PaymentCard;

        /// <summary>
        /// A token for a payment card that can be used to fund a payment.
        /// </summary>
        [DataMember(Name="payment_card_token", EmitDefaultValue = false)]
        public PaymentCardToken PaymentCardToken;
    }
}


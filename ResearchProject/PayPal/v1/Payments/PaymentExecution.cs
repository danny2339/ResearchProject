// This class was generated on Mon, 09 Apr 2018 18:07:49 UTC by version 0.1.0-dev+291f3f of Braintree SDK Generator
// PaymentExecution.cs
// @version 0.1.0-dev+291f3f
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// Executes a PayPal account-based payment with the `payer_id` obtained from the web approval URL.
    /// </summary>
    [DataContract]
    public class PaymentExecution
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PaymentExecution() {}

        /// <summary>
        /// The ID of the payer that PayPal passes in the `return_url`.
        /// </summary>
        [DataMember(Name="payer_id", EmitDefaultValue = false)]
        public string PayerId;

        /// <summary>
        /// An array of transaction details. Includes the amount and item details. For update and execute payment calls, the `transactions` object accepts only the `amount` object.
        /// </summary>
        [DataMember(Name="transactions", EmitDefaultValue = false)]
        public List<CartBase> Transactions;
    }
}


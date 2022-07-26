// This class was generated on Mon, 09 Apr 2018 18:07:49 UTC by version 0.1.0-dev+291f3f of Braintree SDK Generator
// CreditCardToken.cs
// @version 0.1.0-dev+291f3f
// @type object
// @data H4sIAAAAAAAC/7xWwW7jNhC99ysG6i1wpGzbk4EeUrgojAJtsM0uUDRFNBbHFhGKVDhDe7XF/ntBSnIke1M02GAvBjhDDd97HL7xP9lt11K2zCpPSst9hV7di3sgmy2y9+g1bgz9hk3cki2yX6l7WqyIK69b0c5my+y2Jkgf6o+koC8HsRwoEtSGc/jTBajQQmACqTWDtiw+NGQFxME2WAUILXYxkmeL7Np77HqAV4vsLaH63ZouW27RMMXAY9Ce1DFw411LXjRxtvzrSI3Fa7s75zOlrNWM3VnqnOt6BW474yk1CmgGFudJgbYgNcENdjdoYI/BSH4Xrq6+rzbGVQ+PwQmldf9bsXhnd31k3bTOC1pZ9rlimoR4fNTQbacnvP35j1vot1dODaWLQU0e6jxl4PpmzVF2rCpqZcZk/Ciy8RT1q4RUDmvLQqgW0A03+V/fHrTUA/xgpkSNnq4Qak/bH++yQrmKC22Fdh6j0IXSnio5Uih2gVguj8u7rK/zSwzDCVEcWEYUgPDZs7DVRbqX4tuewWW68MoTCo3VX3bD89OH1ZzwM/RrkZaXRXE4HPKNR23FE42k8so1ReudCpVwcUxf9gqNUH8a47Dq468CpsWuRZMQBC4OtMG25aJp26IhX9Voj+cPQmwCa0vMMAL+HziKeYsUp0/kJWYgPpx4gQ3GfFocDSH1GPlzR6APrfZ03zgr9cwPThLnbpA2pK6FtKnvO+vAECptd/CRvMvhPZpAsYO23jVQvinjAyzffFd+qdu9kGFH6D9HcIif89u64C+V3mmZUo3bXxn5c2ZtkOWHGeQxcg42ZhJiSIh5NMrh2U5ftA3Nhr4WhxY78qejZhKcM7mGYPVjSJMmGc/RdJn1zgJaBeKxeoBDTTZlE0HAGcPBpJI7gfNpcGC/nGuRw22cyetVOqQm06bpsHdaRSRWyEZkaPrZ46HRPEyhSRVOuGKFDQHaDvax5RfAoaoBGRDevVuvFrGGB4sNLWIpalAbQKU8MedwcTHKfXHxxO5Z5OlIvQWEclSzhAMyOK932qIxXfSivVaknsqNhaI6Uxm+Ti9ITE/7YAicd/NsAHUtTVyk3GvGcgFlgyzk45a4UportydfJm1LbOhDmcPKgXUy/PkiJjDuEL9h6u+IYevii+HWYPcqKvz96Zt/AQAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// The tokenized credit card details. You can use this instrument to fund a payment.
    /// </summary>
    [DataContract]
    public class CreditCardToken
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public CreditCardToken() {}

        /// <summary>
        /// REQUIRED
        /// The ID of credit card that is stored in the PayPal vault.<blockquote><strong>Important:</strong> The use of the PayPal REST <code>/payments</code> APIs to accept credit card payments is restricted. Instead, you can accept credit card payments with:<ul><li><a href="/docs/integration/direct/payments/guest-payments/">Guest payments</a> with a <a href="/docs/api/vault/#credit-card_create">credit card that is stored in the PayPal vault</a></li><li><a href="https://www.braintreepayments.com/products/braintree-direct">Braintree Direct</a></li><li><a href="https://www.paypal.com/us/webapps/mpp/merchant">PayPal business products</a></li></ul></blockquote>
        /// </summary>
        [DataMember(Name="credit_card_id", EmitDefaultValue = false)]
        public string CreditCardId;

        /// <summary>
        /// The expiration month with no leading zero. Value is from `1` to `12`.
        /// </summary>
        [DataMember(Name="expire_month", EmitDefaultValue = false)]
        public int? ExpireMonth;

        /// <summary>
        /// The four-digit expiration year.
        /// </summary>
        [DataMember(Name="expire_year", EmitDefaultValue = false)]
        public int? ExpireYear;

        /// <summary>
        /// The last four digits of the stored credit card number.
        /// </summary>
        [DataMember(Name="last4", EmitDefaultValue = false)]
        public string Last4;

        /// <summary>
        /// A unique ID that you can assign and track when you store a credit card in the vault or use a vaulted credit card. This ID can help to avoid unintentional use or misuse of credit cards and can be any value, such as a UUID, user name, or email address. **Required** when you use a vaulted credit card and if a `payer_id` was originally provided when you vaulted the credit card.
        /// </summary>
        [DataMember(Name="payer_id", EmitDefaultValue = false)]
        public string PayerId;

        /// <summary>
        /// The credit card type. Value is `visa`, `mastercard`, `discover`, or `amex`. Do not use these lowercase values for display.
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue = false)]
        public string Type;
    }
}


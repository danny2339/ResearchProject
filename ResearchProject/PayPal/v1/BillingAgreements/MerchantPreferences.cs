// This class was generated on Tue, 30 Jan 2018 11:14:21 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// MerchantPreferences.cs
// @version 0.1.0-dev+6beb51-dirty
// @type object
// @data H4sIAAAAAAAC/8xY32/ctg9///4VhF++G+DY2Q9gwL0VTQfc1iZBmxYouuLCSHQsTJZcibqLMfR/HyTbd+feeV3aJthTIommyA/JD6n7K7vqWsoW2QtyokbD0DqqyJER5LM8e4NO4Y2mc2yiVJZnv1O3W5yRF061rKzJFtlVTdAc0QOVdYDQajQFLI3QQZKH2m6gCaIGxSCsZw9swRNDaIFrArx1RA0ZztPy9cvnHjY1OUpLETzbhhwINIBt6+yawKalIH1MQYN3qgkNmNDckANbAWptNyShQqVJQotdlAZkpqZln8fruCYHl9hdogYMbBtkJVDrDm6U1j5ptoE9o5HK3MIN6mgBKJOODN1xkoxnohOackAje/tExA1UNXHo/x6UUaxQbw2K9vkiy7MnzmHXB+w0z14Syguju2xRofYUNz4E5UhuNy6dbcmxIp8t3m1D7dkpc3sYXBSCWia5Gu5dcZTfj/icxGEajKZHgQgSMqCLLvcKUkZwrfwuSAVEf06s0V1CyJEntx5Eq8DBEQRPXwuDCVp/zD+PRWC7inFbYWOD4SkMh4dTBJZGKoFM/kEyqICruU96bWw53pVsS3luuliOa2WD192Y7l7UJMNe4vsC3qAOUc3ij3B6+pMIOv2lfqXV/kpY2f9H5xf9TrnbKkaHpSUPxvIRz6dlPINCAWdUYdAcffs3Fw87U1vnLH/77NW86XOx+qzJR00YoXyc9O1ZcBWcniTuZPuwaF+/fB45eFMrUU9dVR4cSeVIxOLtGas7yrX3qk924Qv9q9GtPE3Lcm/z0Ld4iILJpRbzX6cfJSeepeWhT8uzWN0803Ufy9S+Wa0iqwx8uOo729SFfxI7dO2evfHLiOvpxfnV8vz1syMccLWf0+CoQWV8smpN2wb+6dzQE27MKilJxlKaZbVllfjlZCR25YFMRFXm37hX7PHn9ejw9f1o8umT86fPnh+gNBoqHKVeN+EBuAkcS82DYg+ekWNfgpZ6w4Nh1TPHpwEVmtD5hND8cT/Rjcr2LiVhGxoDNaskJc2cDuUHYiN5HKbycbm8wbuhaoa5dFJXx06PTOX3nX2neXN6nQ9dIX0Wq7CKmNLs548DjSMOzhy0ucn217e5fmh9yDb3whrq0qwMG8U1iOAih3cQiw0+BNSqUiRhHVnuEAZPHNpVRdNhfX93CsKT/qr0KtMaKmXQiFgfSf+JI41pRlekpS/gV+uA7rBp4+NlYJx8G3IZhieNt2DNw79SRmymrX+3eRjvd1w7opPdBLB8dXHy848//DLF+f13NXPrF2UpaU062lS02LWoC2GbUlrhS2WYbh1G5WWfJ6Ujz+Wo6CQq8uX3jzMFjemww2HcOTL/jK4mkQJeqNs68iWggeQVuZQQg5wiD1r9SXD92+Xb690DLo7y3LVDU6pc36dRQ3rh90C3GgWBJKEa1FuZ49qvzs/2tPtwI9VaxeapTGqfNng0kushDWMNugG4PTIb70o3jz83TIKbgyeCd8tXFxAj38d6UZabzaZQ3hbW3ZbK27K2DZWpvaKTfhvXVYprUXPzTUL7/uP7j//7GwAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.v1.BillingAgreements
{
    /// <summary>
    /// The merchant preferences for a plan. Includes how much it costs to set up the agreement, the URLs where the customer can approve or cancel the agreement, the maximum number of allowed failed payment attempts, whether PayPal automatically bills the outstanding balance in the next billing cycle, and the action if the customer's initial payment fails.
    /// </summary>
    [DataContract]
    public class MerchantPreferences
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public MerchantPreferences() {}

        /// <summary>
        /// The payment types that are accepted for this agreement. Read-only and reserved for future use.
        /// </summary>
        [DataMember(Name="accepted_payment_type", EmitDefaultValue = false)]
        public string AcceptedPaymentType;

        /// <summary>
        /// Indicates whether PayPal automatically bills the outstanding balance in the next billing cycle. The outstanding balance is the total amount of any previously failed scheduled payments. Value is:<ul><li><code>NO</code>. PayPal does not automatically bill the customer the outstanding balance. Default is <code>NO</code>.</li><li><code>YES</code>. PayPal automatically bills the customer the outstanding balance.</li><ul>
        /// </summary>
        [DataMember(Name="auto_bill_amount", EmitDefaultValue = false)]
        public string AutoBillAmount;

        /// <summary>
        /// REQUIRED
        /// The URL to which the customer is redirected if they cancel the agreement.
        /// </summary>
        [DataMember(Name="cancel_url", EmitDefaultValue = false)]
        public string CancelUrl;

        /// <summary>
        /// The character set for this agreement. Read-only and reserved for future use.
        /// </summary>
        [DataMember(Name="char_set", EmitDefaultValue = false)]
        public string CharSet;

        /// <summary>
        /// The ID of the merchant preferences.
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue = false)]
        public string Id;

        /// <summary>
        /// The action if the customer's initial payment fails. Value is:<ul><li><code>CONTINUE</code>. The agreement remains active and the failed payment amount is added to the outstanding balance. If auto-billing is enabled, PayPal automatically bills the outstanding balance in the next billing cycle. Default is `CONTINUE`.</li><li><code>CANCEL</code> PayPal creates the agreement but sets its state to pending until the initial payment clears. If the initial payment clears, the pending agreement becomes active. If the initial payment fails, the pending agreement is canceled.</li></ul>
        /// </summary>
        [DataMember(Name="initial_fail_amount_action", EmitDefaultValue = false)]
        public string InitialFailAmountAction;

        /// <summary>
        /// The maximum number of allowed failed payment attempts. Default is `0`, which allows infinite failed payment attempts.
        /// </summary>
        [DataMember(Name="max_fail_attempts", EmitDefaultValue = false)]
        public string MaxFailAttempts;

        /// <summary>
        /// REQUIRED
        /// The URL to which the customer is redirected if they accept the agreement.
        /// </summary>
        [DataMember(Name="return_url", EmitDefaultValue = false)]
        public string ReturnUrl;

        /// <summary>
        /// A type for all financial value-related fields. For example, balance, payment due, and so on.
        /// </summary>
        [DataMember(Name="setup_fee", EmitDefaultValue = false)]
        public MoneyTypeWithCurrencyCodeQualifiedValue SetupFee;
    }
}


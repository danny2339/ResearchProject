// This class was generated on Tue, 30 Jan 2018 11:02:44 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// CreditCardUpdateRequest.cs
// @version 0.1.0-dev+6beb51-dirty
// @type request
// @data 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
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;


namespace PayPal.v1.Vault
{
    /// <summary>
    /// Updates information for a vaulted credit card, by ID. In the JSON request body, specify the values to update.
    /// </summary>
    public class CreditCardUpdateRequest<T> : HttpRequest
    {
        public CreditCardUpdateRequest(string CreditCardId) : base("/v1/vault/credit-cards/{credit_card_id}?", new HttpMethod("PATCH"), typeof(CreditCard))
        {
            try {
                this.Path = this.Path.Replace("{credit_card_id}", Uri.EscapeDataString(Convert.ToString(CreditCardId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        
        public CreditCardUpdateRequest<T> RequestBody(List<JsonPatch<T>> PatchRequest)
        {
            this.Body = PatchRequest;
            return this;
        }
    }
}

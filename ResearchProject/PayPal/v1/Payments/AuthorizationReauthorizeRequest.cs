// This class was generated on Mon, 09 Apr 2018 18:07:50 UTC by version 0.1.0-dev+291f3f of Braintree SDK Generator
// AuthorizationReauthorizeRequest.cs
// @version 0.1.0-dev+291f3f
// @type request
// @data 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
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// Re-authorizes a PayPal account payment, by authorization ID. To ensure that funds are still available, re-authorize a payment after the initial three-day honor period. Supports only the `amount` request parameter. You can re-authorize a payment only once from four to 29 days after three-day honor period for the original authorization expires. If 30 days have passed from the original authorization, you must create a new authorization instead. A re-authorized payment itself has a new three-day honor period. You can re-authorize a transaction once for up to 115% of the originally authorized amount, not to exceed an increase of $75 USD.
    /// </summary>
    public class AuthorizationReauthorizeRequest : HttpRequest
    {
        public AuthorizationReauthorizeRequest(string AuthorizationId) : base("/v1/payments/authorization/{authorization_id}/reauthorize?", HttpMethod.Post, typeof(Authorization))
        {
            try {
                this.Path = this.Path.Replace("{authorization_id}", Uri.EscapeDataString(Convert.ToString(AuthorizationId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        
        public AuthorizationReauthorizeRequest RequestBody(Authorization Authorization)
        {
            this.Body = Authorization;
            return this;
        }
    }
}

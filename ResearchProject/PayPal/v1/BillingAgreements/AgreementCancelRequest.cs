// This class was generated on Tue, 30 Jan 2018 11:14:21 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// AgreementCancelRequest.cs
// @version 0.1.0-dev+6beb51-dirty
// @type request
// @data H4sIAAAAAAAC/6RUX2/TMBB/51Oc7tksA/GUt2kFrSDWQite0NRd4mvjybUz+wJEVb87chKyNZWGEE+Vf73z/f6cc8Bb2jPmSLvAvGcnFyW5ki0qnHEsg6nFeIc5XndwBILCWGvcDsYWBUUL89kFzB1IxfBxtbiFwI8NR4HC61aBcaVtNAM5uB/7NlFIeKOHOT7cgy8euBT4aaRKtb6bThacFwapSKCvLjh2owJT9A62PnTHnrul1AXkdAeO84D2vkk/TkPZhMCubC9Q4ZeGQ7ukQHsWDhHz73cKb5g0hyn6wYf9FFuSVCfYAddtnUyNEozbocJvFAwVlqdmb4xGhZ+4Hf44c31dMcxn4LcTJeIHrYn/VQjU9iMvFX5l0gtnW8y3ZCMn4LExgTXmEhpWuAy+5iCGI+ausfZ419dwlP6Skf/VOG+VkoLZmNRLmqapnih8sexU+xXop/MfC/rcBLruM1/+yY0BeG7H36NLi3giaADOY5us5lN2PfWyIrfj/yXc53dMVbH2LnJ/T4IVXnsn7IZQkeramrJ7GtlD9A4V3ojUn1kqrzHH5WK1xn6bMcfsx5uspjYRjtnw4l+PGmJ2eL7Dx2z8aLz/VXMprNPCNPHaa8b87eW746vfAAAA//8=
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;


namespace PayPal.v1.BillingAgreements
{
    /// <summary>
    /// Cancels a billing agreement, by ID. In the JSON request body, include an `agreement_state_descriptor` object with an optional note that describes the reason for the cancellation and the agreement amount and currency.
    /// </summary>
    public class AgreementCancelRequest : HttpRequest
    {
        public AgreementCancelRequest(string AgreementId) : base("/v1/payments/billing-agreements/{agreement_id}/cancel?", HttpMethod.Post, typeof(void))
        {
            try {
                this.Path = this.Path.Replace("{agreement_id}", Uri.EscapeDataString(Convert.ToString(AgreementId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        
        public AgreementCancelRequest RequestBody(AgreementStateDescriptor AgreementStateDescriptor)
        {
            this.Body = AgreementStateDescriptor;
            return this;
        }
    }
}

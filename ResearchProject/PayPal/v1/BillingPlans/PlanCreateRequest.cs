// This class was generated on Tue, 30 Jan 2018 11:14:21 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// PlanCreateRequest.cs
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


namespace PayPal.v1.BillingPlans
{
    /// <summary>
    /// Creates a billing plan. In the JSON request body, include the plan details. A plan must include at least one regular payment definition and, optionally, a trial payment definition. Each payment definition specifies a billing period, which determines how often and for how long the customer is charged. A plan can specify a fixed or infinite number of payment cycles. A payment definition can optionally specify shipping fee and tax amounts. The default state of a new plan is `CREATED`. Before you can create an agreement from a plan, you must activate the plan by updating its `state` to `ACTIVE`.
    /// </summary>
    public class PlanCreateRequest : HttpRequest
    {
        public PlanCreateRequest() : base("/v1/payments/billing-plans/?", HttpMethod.Post, typeof(Plan))
        {
            
            this.ContentType =  "application/json";
        }
        
        public PlanCreateRequest RequestBody(Plan Plan)
        {
            this.Body = Plan;
            return this;
        }
    }
}

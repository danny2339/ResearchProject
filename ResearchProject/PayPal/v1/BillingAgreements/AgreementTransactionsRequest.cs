// This class was generated on Tue, 30 Jan 2018 11:14:21 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// AgreementTransactionsRequest.cs
// @version 0.1.0-dev+6beb51-dirty
// @type request
// @data H4sIAAAAAAAC/+xZUW8btw9//38KQv+XFbjcpc3WYX4LmnbNtrZZaxQYssCmTzyfOp10lXhJb0W/+yDJdny2k6xdlg1DngJRPJI/kj9JZj6Kl9iQGAmcO6KGDOfs0HgsWVnjRSaOyJdOtWEpRuIn5dnDugpU1gEaWBnIYNbD8VEOYwuV0kwOuKbhN1wjA7YtoQNl4r4j31rjKQPfUqmqPkptdIwaPKNjQCOBjASJTPC+I9dDiw4bYnI+F5n4OchOViIxOv0oxn0bEHp2ysxFJt6iUzjTtEBORk6CPZGJH6lfCLeAj2u69GyrFDKaeVoMsFnQynOI5tA57JP7/Uy8JpSvjO7FqELtKQjed8qRXAlOnG3JsSIvRqbT+lN2Y/QxL38y/pTDu0VwlonnhJLcoChnmXhmXbMpO0GuP694q66bKHlzAo6PlsBX38X2vahVWS9hD3LxWTlg112RgqBDnpORIAyi1O9JtgJ6uApsPOThBvDrwR4awBB1gHsJ9YuB7Sju6Y6I1+xfV6k1tUlI+ADKtWqfCRLs7B2VvIn18ZdjfWEN9cB9S3ChuIayc45M2UNpZTiQUKtKkYRz1B3tyEFjO7OBdynawJacxLNVa6iUQVMq1MnyniONTBIqRVr6HJ5ZB/QBm1ZTBjPUaErKoMU+pkR2lMWj01uw5vYqfxUpl1kZAF0TbhPzlGtHtFfW6LAMN8bxm1d7Xz96+O0ww2df1cytHxWFpHPSIaa8xb5FnZe2KaQtfaEM09xhMF5I5ajkwpHnYmloLxjyxYPbYPbNx/OyES7zsJRsJ2EFNark8ELNa4YZhds1oiIXG2Khp8iDVr8RTH84+WW6uFIdgbEcmkeVqHUPlUtcQA2hlyAlutVYEkgqVYN6pbPb+vjl0Zp1382kOleSZIjJAte282gk14s2THd5ShyYrpmRCwRd+oqeF4+GYXEz8ERwevzmFYTKp1qPiuLi4iJX3ubWzQvlbVHbhgrPaCQ66Vd1ncS65jU3t1Las7Xi/kXWV0STHcwfiO/Zf8/+e/b/F9lviHexfyC+Z/89++/Z/69k/1XFbbEnN6EGlR6UeCjfMUMIO2s/RMvOs23I3dG4IIVnwmI76oV4O+hZ55Uh7yFo/EORe0bu/CDqlegqPjEklWXIa78Nc3gbmAbKj37t9vcPyk7Hv5RWWqXV9IkNByuTnOYwHpoA5aFcbMcjNrho4m1Ro4cZkUnqFQU+RMJQOJiJ8uSlWLrZcHqCjlWg8OQ1VZ2R0fshtOh4BxRI98ilU7f4aN2lu8klGanMfDfKNm2CJ2adpoTXW1sLe/w3BHtERu00vrIqo8ZuM8Wy1HfTuKwamnjGph0070C83cBxShebSjUEFzWZrbLbMna5zEAZOD02TM4Qb3xZWdcgX16ebK32uSKu4qFac6MLV5UHBwff/d9TNLz3Tf74QX6HyfndGtrOzUK6nZqIK+wuuTDt2gB6Ejam6V10V+Gvzag2BpBbW9eNI9cPpruPPDw3r4x9sbmjDOGROhwd5zBePj4ymL6m0J/h3DhJj9Hp7UyUw/0snljDZBYTVYFtq1WZHn7vfBw/PmduXxDXVoqR+P7pWKTxshiJ4vxhsXge+2KmtFZmvrcaIPri4/pQ+VOx8f+Qpx9aKpnkm3izPLGSxOjR/v6n//0BAAD//w==
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
    /// Lists transactions for an agreement, by ID. To filter the transactions that appear in the response, specify the optional start and end date query parameters.
    /// </summary>
    public class AgreementTransactionsRequest : HttpRequest
    {
        public AgreementTransactionsRequest(string AgreementId) : base("/v1/payments/billing-agreements/{agreement_id}/transactions?", HttpMethod.Get, typeof(AgreementTransactions))
        {
            try {
                this.Path = this.Path.Replace("{agreement_id}", Uri.EscapeDataString(Convert.ToString(AgreementId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }

        public AgreementTransactionsRequest EndDate(string EndDate)
        {
            var strParams = Convert.ToString(EndDate);
            try {
                this.Path = $"{this.Path}end_date={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public AgreementTransactionsRequest StartDate(string StartDate)
        {
            var strParams = Convert.ToString(StartDate);
            try {
                this.Path = $"{this.Path}start_date={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        
        
    }
}

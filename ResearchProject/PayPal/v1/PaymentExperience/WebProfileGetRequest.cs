// This class was generated on Tue, 30 Jan 2018 11:02:41 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// WebProfileGetRequest.cs
// @version 0.1.0-dev+6beb51-dirty
// @type request
// @data H4sIAAAAAAAC/8xZX3PbuBF/76fY4cu1M4zspNN2qpk+OP7f5BzVVi4PbYaCyBWJBAR4AGiZyeS7dxYARVKUYvvOcfsQRMYugP3tX2D5NbpiJUbTaI3LF5VWKy5wkqON4ugETap5ZbmS0TS6KdTaQIaWcWFgpTQwWOMS8K5CzVGmCGF5DMsGLk8mURz9q0bdzJhmJVrUJpr++2McXSDLUG/Pnildbs/NmC0Gc1+jeVORtMZqLvMojn5hmrOlwIAiiJDwLIqjN9iE6RGaeYFweQJqBbbYCO5QrQueFmAVmEKtW7yE5Uhr1vjjD+PoGln2Toommq6YMEgTv9ZcYxZNra4xjmZaVagtRxNNZS3Et4+eB431m9AkTZlKSYN+boPvAy5h5qUag/w+tCOoWFOitHvM8ygsYaIPpjPCmVBrOFZyxXdYYiXUOklbYifvcH5sFaKDp9eaEQGqjQs8nez7HGjJ5OfE3smkQplxmSe1FgP59zCMgZSo04JJC4ZbhPfXb8mpMm4qwRpgK4sUQbQbWM2kWaFuDTeBSwnnqEsmmxhumeAZKCka55/kr+dcq4o1G0OXaAuVgdK79wv036s858XxvRoUzOulYjkmlnj76ttFHeuOCBScgRuIu68+JZ0eZqyZMeEVTLqpDWpIC0w/q9pOYK5oxnFKJV8EbpamqpZ2sHcMBi0dsHjNheAyXwxWb69UOZd71r8l2uKZVK3R1lomteZJYW2VeDsP9L2XZaz0i/l81rqSDeAVaMy4xtQ6RaS1sapETQQGfm9y7Qn8wkSNwA0szk/nC3LFxezdzfy5NEGWT1jq0PThD+eHmGcaDUprALkt0EfWf+rDwz+nxmolc/cbj5W0XNboKQd9EqEcL5ixBq7Uehd/65o+yVk10OnEr1jqA8+99ecJrlgtLKn4UULGnZSpyjwH9tTyj3S4tmOawIcCJTSqhkyBVBY+SxKbkjSXTGzSCyspLGKKD6zIUThdFLy4hDQORbV1JTPypV6QtZu6kF9zW/wGuyxra5UM8g/OSgVPPz9ag8MtmARK7LnPDUMl3GPETqP3qJLSyfeNVpbcjkxGukwLpULeepRz/jBLfefM32Co/bvFA3twQxeeFI3BDHhZYsaZRdE8SUL6+ICUtHUF5dk9l9Afc1vbyp+XsqotnHEUmdkhMlGTVUvtCT8kjGE4BnAMwYb8y4+7vHFpMUc9BsCyTKMxibpFrXk2vHrsIA6BXMqMp8yigXWBviR0Vw4ykSl4VVHND1uBLZj3NObczMUHN5AyIUCzUFWYd20l6R9sHhqOc1k3qLeuM30nYDmarrhOvdfXop9cBO//1eWCwx0J/cSDMbvRBOlCDjsYbrzvmJePPsZUmPIVp7CUnb4moyxLFQczHgrK9ja7pTxodfO0YbNUSiCTOxxO0HNGKrvlav3pe51su7qg9I8DWt/m3M1rYugrLvdmNWWg7uL7tNj3BptUSWuUAfjh/H3oA5CsdZmRu/is0+L+XwbHlt7N7w+Ua8wYVdl9oFdaleNj4UxpyHjOLROQK5WZ2MeIz7/cgA72BSYzKGtjYYnwAIEeBejVDkDnaPfobwOldfWfzOZB1da6Hx/SDynckv4bOLSfGFe93SUbiH8CPwe115L/WmPomNG9Tq1azraP1gb3U7SZOnzhfcPC42fUKRtQO7RbhDFqYxuBzrP6rM/bpdFMZsnIUIPp7a6YYEsUvmK3NwDvqsvacEkuSgt9TRo9+XdFPxwXTLOUcrVAmdvC6UTwknuNmCm8fPU3MFzmAl8sG4vARFUwWZeoeUqPCL/cPFdnRqVMYELxOuzJDObHBvd057cE3Otwx0OgFwptOp/AUWhg3W4aBEfvFzEsjuY0vj514zWNx0duvHDjFY0njnp6Q+P5axrPHOelW3v1lsaZH93MNe2sNCze3yzo5L+82OgYCB0dz4RRQSQKPsFkXjtU3vAGwVlcczRTWGQsOXlDWxeYXLqTeJZcntCPTyz554x+SJVcvaMflU08El0nTpSFuU1uHAZbJHMH7EuReGxfiuTiTRD3S5HMPyyezQtylfCS5dtO0Jvejp3QvbTOGXIFjq+zrXtc+aYdGXiS8xVBnHyq8oBwUvmeGj0VaO1PBkp2x8u6hDXPbEHrXv79ECp+h8L4shXoBfK8cLfsv7b0Set5qVaV8TsGt2QaQTCdo94wVYKlaOjVrXvSQ/Bhq6r2BZYybUHjLcc17cM2O2ik9zbKLBxCD3hjlfavbL+dki69p7VG+OPFfD67+RMY1LckyDu66ay5wdiVjKVWa4PadN1gKNEY1+Ok7TdtIh9uqZKWcel6mOEAbrH8v0tAHx9yYbZYVkoz3Qycrz/7kOtyW2kr1IYba8KDSiNCoWptyOcq10BHaUXjmrmBd3t9y9O1cB2+xd41W0d166ggL55Kk9GxkhZl+FYUsaoSpAeu5MEn4wrzhbXVz76bO43OT+eR/14WTaOD25cHISe/6HLyQe8Lnzn42n0p+xbF0eldhanF7MYyW5tjqgTTV4eH3/7wXwAAAP//
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;


namespace PayPal.v1.PaymentExperience
{
    /// <summary>
    /// Shows details for a web experience profile, by ID.
    /// </summary>
    public class WebProfileGetRequest : HttpRequest
    {
        public WebProfileGetRequest(string ProfileId) : base("/v1/payment-experience/web-profiles/{profile_id}?", HttpMethod.Get, typeof(WebProfile))
        {
            try {
                this.Path = this.Path.Replace("{profile_id}", Uri.EscapeDataString(Convert.ToString(ProfileId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        
    }
}

// This class was generated on Tue, 30 Jan 2018 11:02:44 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// WebhookCreateRequest.cs
// @version 0.1.0-dev+6beb51-dirty
// @type request
// @data H4sIAAAAAAAC/+xY32/bthN///4VB/b7EBey1Q5r1/ktaDMkWLZkjrM9GMF0ls4Wa4pUSSquUfR/H46UPMte+gMr8jD4KeGRFD8/yLuDP4hfsSIxFmual8asRrkl9CQS8YZcbmXtpdFiLG6aOQ/n5GBjGgvtclDSedJkwRuge9LejUQifmvIbq7RYkWerBPj2V0izgkLsvvRn4yt9mPX6Mv92ITeNeT8dFOTGH8Q8a/4I8IQifgdrcS5oj4dkYifaXMQ63O70gTGQmUsbXmZ+VvKI5lTa3ETz3vGOLC40mojxgtUjiIwaanYBq6tqcl6SYx8i/SMxYEwOAAbhPvTb2pyPcD9eB/0qQZkYGAW0NQsvyfdWsCjdSnzkv9xnXM940Yw3Z3yBlCpbrvUuWoKqZegad0F0YEvaQNoCbAoqEjA1ZTLxYbjgM6TlW4FJ9nTbABrqQrI0RbhIEu1wpzCwmyHVRY59L+UPc32tvMlC/hcU9fGeipaUAnM4tw9SsWCtvG7kyfb0DCEhnzeiBcP9jx9+UlPvW0etNR5K/Xy0M5ix6hdO/vxPTuhbCrUQ0tYBCI7i9liFiYQ+bc3UjdKfUw+y0Hzn13wbaCPeloSNFq+a1pwwKseCaHz6Jv+e9mGDlHGKVYSt2/82+l59wV4ZdHDGoaHOC/edG53D/Xbqnkp9Qp2joWrkOgO4SqpV311u8jDecjGHD20pJAf6ez8dHp2dXoDYevdSVqY3KVYy7RETwbdMEykX/ckP5lmH1K/tLTosWkDhw7kpqoVeQKPdkkebieXIQlVuIoJrGOXo1IJL59LHWcq8qUpYC19Cb6ULvBOQGqY3U4uwFNV81ZYGFuhvzspva/dOE29McqNJPnFyNhlWvpKpXaRv3zxw7PBCC5CNm6T5/+zBLKTLAHUBWSDDPISLeZcJ/mzUFsa1tbk5JzUyxEwo4y5ZiBDAocVbaDzhbkazQ/Xl+ijTYBbCSLHyAdDtWCDtQ/hR3rmUdOeddvQoXnn0+l1Z4NtT+fi9o/mPRIDS6oHP44Psc9Y/giQHyYXrM9ekRc/vnr1xFHOO4bfD5K27Duy9xRKNmpOKXwzMNgbjW40VnO5bEzj1KYtNdzasUKOKtRe5q5LRLxtBDdEMAvZY9IidH+jW6/XI4kaAzZ0Ti51xXU45b3DjtL+cPSeaQweLQM3tm9EHB8acTu5jDJJB7nRC7ls2msUu10wGjJlclSlcT4L6kqdm4o7puz66maagTZeLmQerazIOVwGfdHzJz3KtlcDqWM2kEZ/lRCHjUmng5iQq4129KW9ck+UY3d87I6P3fGxOz52x8fu+NgdH7vjY3d87I7/U93xa6M96faHZIF1rVog6VsXWo9z7+tf4iMaC8Yr4i/SYizS++fpLnaXtnWIM//Z+5pyT8VNKKavTUFi/N2z5x//9xcAAAD//w==
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;


namespace PayPal.v1.Webhooks
{
    /// <summary>
    /// Subscribes your webhook listener to events.
    /// </summary>
    public class WebhookCreateRequest : HttpRequest
    {
        public WebhookCreateRequest() : base("/v1/notifications/webhooks?", HttpMethod.Post, typeof(Webhook))
        {
            
            this.ContentType =  "application/json";
        }
        
        public WebhookCreateRequest RequestBody(Webhook Webhook)
        {
            this.Body = Webhook;
            return this;
        }
    }
}

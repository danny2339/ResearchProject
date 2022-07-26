// This class was generated on Tue, 30 Jan 2018 11:02:44 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// AvailableEventTypeListRequest.cs
// @version 0.1.0-dev+6beb51-dirty
// @type request
// @data H4sIAAAAAAAC/7yUwY7TMBCG7zzFaE4gpU3hwCG31dJlJRYoUMFhVaFpMt0YUtvrmbREq747chKVpEVaCRCnyH/Gnm9+j+cB39GWMUPakaloXfGEd2x1oo3naWVEMcFXLHkwXo2zmOGNERU4xkMbL6AO9qXJSyDbwJ7XpXPfIScLUq/j9jVP4coFIIingtuA1N67oFz0RyQgzHD7pd/bimBpy7J6mhYul9RY5btAESQtTOBc0z6TpB12G54+m2KCH2oOzYICbVk5CGa3qwSvmQoOp+qVC9tTbUFanmof+b5m0WXjGTNbV1WUxDsr3GkP2H1x3sLHBdx0Jn6mYKJfvd+Y4Btufi3OPY4W7YdeSKzqIgRquiSzmJ2K97ZqMNtQJdwRmsDFUVgE5zmo4VjCb/DOydpcX+P9ywhyrI95LyxQBHuU+eWfM4sGY+/OeYsByZB3rJ/wQllvyU4CU9E28SA41qBl39d/a3lskkPyaA2xbUfwvTCmXpYMtTX3NQ8ex38iFCWtxw1xlM4pu1/RSRr3wz+hXR1WhwQvnVW2/WNE8r4yeTcavkl75deq/i1r6QrM8PV8id2jxgzT3fPUOjWbfoccx8hg+sXK5j8858rFp7aeS1cwZi9ms8OTnwAAAP//
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
    /// Lists available events to which any webhook can subscribe. For a list of supported events, see [Webhook event names](/docs/integration/direct/webhooks/event-names/).
    /// </summary>
    public class AvailableEventTypeListRequest : HttpRequest
    {
        public AvailableEventTypeListRequest() : base("/v1/notifications/webhooks-event-types?", HttpMethod.Get, typeof(EventTypeList))
        {
            
            this.ContentType =  "application/json";
        }
        
    }
}

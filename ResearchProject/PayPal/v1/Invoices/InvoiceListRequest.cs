// This class was generated on Tue, 30 Jan 2018 11:02:40 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// InvoiceListRequest.cs
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


namespace PayPal.v1.Invoices
{
    /// <summary>
    /// Lists merchant invoices. To filter the invoices that appear in the response, you can specify one or more optional query parameters.
    /// </summary>
    public class InvoiceListRequest : HttpRequest
    {
        public InvoiceListRequest() : base("/v1/invoicing/invoices/?", HttpMethod.Get, typeof(InvoiceList))
        {
            
            this.ContentType =  "application/json";
        }

        public InvoiceListRequest Page(int Page)
        {
            var strParams = Convert.ToString(Page);
            try {
                this.Path = $"{this.Path}page={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public InvoiceListRequest PageSize(int PageSize)
        {
            var strParams = Convert.ToString(PageSize);
            try {
                this.Path = $"{this.Path}page_size={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        

        public InvoiceListRequest TotalCountRequired(bool TotalCountRequired)
        {
            var strParams = Convert.ToString(TotalCountRequired);
            try {
                this.Path = $"{this.Path}total_count_required={Uri.EscapeDataString(strParams)}&";
            } catch (IOException) {}
            return this;
        }
        
        
    }
}

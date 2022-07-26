// This class was generated on Mon, 09 Apr 2018 18:07:49 UTC by version 0.1.0-dev+291f3f of Braintree SDK Generator
// LinkDescriptionObject.cs
// @version 0.1.0-dev+291f3f
// @type object
// @data H4sIAAAAAAAC/6yUwU7cQAyG730Ka+iBlbIJh9LSvSHRClRU0BJ6WSHiTZzNlMlMGDtso4p3ryYDi2BV0ao92rHH/+ffyk+VDx2pmTLa3lxXxKXXnWhnr93yO5WiEvUNvcaloa/YhkKVqC80PAVHTz1qpvKGwNNtTyxTTwaFKlgcH+afzg4vIMy42s0qV3KGnc7cHfk7Tetsp0EhhzwNFTwBbWvnWwxvpipRh97jEHXuJWpOWJ1ZM6hZjYYpJG577anaJM6968iLJlazxYaQxWu72gZqPNXPoB4S22ClaztDQiDoVyRwOT9NIXfQ4g2BjOSRuERjklC+1DZ+aUkaV8FaSwPSaIbF5fwEcmq70DGNuELV1W4j0vEsy8Q5w6kmqVPnV1kjrcl8Xb7f/7A3GTeZwmfnofM07bwriVnbVQLalqav4tDibZFAsVskgLaCYlJA2aDHUshzCoGoCKwFaB7rb2iAR68Cq7NkBaRBGQcy4GYFkTHyIHC/5GC6lTH9V56J719YZntj7pNXfYsrfebcJrXt3XGenz+64B+Gg/zGu389uj8k8GSeyY/xtvZF2H4UqJ0FGTp69U72Px4c7DCVoWP6bpLAutFlA0z+jhiQAS2cHEHtPODobvS5t9gu9ap3PZsB4v9gSfE8mFq0oksGV4+JeIUXRLA4DS/MHxTyk7r1ep1qtDhqQ2a9si1Z4Sz0Th+RXobpj4Ax+R93dHX/5hcAAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// The request-related [HATEOAS link](/docs/api/overview/#hateoas-links) information.
    /// </summary>
    [DataContract]
    public class LinkDescriptionObject
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public LinkDescriptionObject() {}

        /// <summary>
        /// REQUIRED
        /// The complete target URL. To make the related call, combine the method with this [URI Template-formatted](https://tools.ietf.org/html/rfc6570) link. For pre-processing, include the `$`, `(`, and `)` characters. The `href` is the key HATEOAS component that links a completed call with a subsequent call.
        /// </summary>
        [DataMember(Name="href", EmitDefaultValue = false)]
        public string Href;

        /// <summary>
        /// The HTTP method required to make the related call.
        /// </summary>
        [DataMember(Name="method", EmitDefaultValue = false)]
        public string Method;

        /// <summary>
        /// REQUIRED
        /// The [link relation type](https://tools.ietf.org/html/rfc5988#section-4), which serves as an ID for a link that unambiguously describes the semantics of the link. See [Link Relations](https://www.iana.org/assignments/link-relations/link-relations.xhtml).
        /// </summary>
        [DataMember(Name="rel", EmitDefaultValue = false)]
        public string Rel;
    }
}


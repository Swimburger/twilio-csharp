/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Twilio.Converters;
using Twilio.Types;

namespace Twilio.TwiML.Voice
{

    /// <summary>
    /// Client TwiML Noun
    /// </summary>
    public class Client : TwiML
    {
        public sealed class EventEnum : StringEnum
        {
            private EventEnum(string value) : base(value) {}
            public EventEnum() {}
            public static implicit operator EventEnum(string value)
            {
                return new EventEnum(value);
            }

            public static readonly EventEnum Initiated = new EventEnum("initiated");
            public static readonly EventEnum Ringing = new EventEnum("ringing");
            public static readonly EventEnum Answered = new EventEnum("answered");
            public static readonly EventEnum Completed = new EventEnum("completed");
        }

        /// <summary>
        /// Client identity
        /// </summary>
        public string IdentityAttribute { get; set; }
        /// <summary>
        /// Client URL
        /// </summary>
        public Uri Url { get; set; }
        /// <summary>
        /// Client URL Method
        /// </summary>
        public Twilio.Http.HttpMethod Method { get; set; }
        /// <summary>
        /// Events to trigger status callback
        /// </summary>
        public IEnumerable<Client.EventEnum> StatusCallbackEvent { get; set; }
        /// <summary>
        /// Status Callback URL
        /// </summary>
        public Uri StatusCallback { get; set; }
        /// <summary>
        /// Status Callback URL Method
        /// </summary>
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; set; }

        /// <summary>
        /// Create a new Client
        /// </summary>
        /// <param name="identity"> Client identity, the body of the TwiML Element. </param>
        /// <param name="url"> Client URL </param>
        /// <param name="method"> Client URL Method </param>
        /// <param name="statusCallbackEvent"> Events to trigger status callback </param>
        /// <param name="statusCallback"> Status Callback URL </param>
        /// <param name="statusCallbackMethod"> Status Callback URL Method </param>
        public Client(string identity = null,
                      Uri url = null,
                      Twilio.Http.HttpMethod method = null,
                      IEnumerable<Client.EventEnum> statusCallbackEvent = null,
                      Uri statusCallback = null,
                      Twilio.Http.HttpMethod statusCallbackMethod = null) : base("Client")
        {
            this.IdentityAttribute = identity;
            this.Url = url;
            this.Method = method;
            this.StatusCallbackEvent = statusCallbackEvent;
            this.StatusCallback = statusCallback;
            this.StatusCallbackMethod = statusCallbackMethod;
        }

        /// <summary>
        /// Return the body of the TwiML tag
        /// </summary>
        protected override string GetElementBody()
        {
            return this.IdentityAttribute != null ? this.IdentityAttribute : string.Empty;
        }

        /// <summary>
        /// Return the attributes of the TwiML tag
        /// </summary>
        protected override IEnumerable<XAttribute> GetElementAttributes()
        {
            var attributes = new List<XAttribute>();
            if (this.Url != null)
            {
                attributes.Add(new XAttribute("url", Serializers.Url(this.Url)));
            }
            if (this.Method != null)
            {
                attributes.Add(new XAttribute("method", this.Method.ToString()));
            }
            if (this.StatusCallbackEvent != null)
            {
                attributes.Add(new XAttribute("statusCallbackEvent", String.Join(" ", this.StatusCallbackEvent.Select(e => e.ToString()).ToArray())));
            }
            if (this.StatusCallback != null)
            {
                attributes.Add(new XAttribute("statusCallback", Serializers.Url(this.StatusCallback)));
            }
            if (this.StatusCallbackMethod != null)
            {
                attributes.Add(new XAttribute("statusCallbackMethod", this.StatusCallbackMethod.ToString()));
            }
            return attributes;
        }

        /// <summary>
        /// Create a new <Identity/> element and append it as a child of this element.
        /// </summary>
        /// <param name="clientIdentity"> Identity of the client to dial, the body of the TwiML Element. </param>
        public Client Identity(string clientIdentity = null)
        {
            var newChild = new Identity(clientIdentity);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Identity/> element as a child of this element
        /// </summary>
        /// <param name="identity"> A Identity instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public Client Identity(Identity identity)
        {
            this.Append(identity);
            return this;
        }

        /// <summary>
        /// Create a new <Parameter/> element and append it as a child of this element.
        /// </summary>
        /// <param name="name"> The name of the custom parameter </param>
        /// <param name="value"> The value of the custom parameter </param>
        public Client Parameter(string name = null, string value = null)
        {
            var newChild = new Parameter(name, value);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Parameter/> element as a child of this element
        /// </summary>
        /// <param name="parameter"> A Parameter instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public Client Parameter(Parameter parameter)
        {
            this.Append(parameter);
            return this;
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new Client Append(TwiML childElem)
        {
            return (Client) base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new Client SetOption(string key, object value)
        {
            return (Client) base.SetOption(key, value);
        }
    }

}
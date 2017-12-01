/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Proxy.V1 
{

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    /// 
    /// Fetch a specific Service.
    /// </summary>
    public class FetchServiceOptions : IOptions<ServiceResource> 
    {
        /// <summary>
        /// A string that uniquely identifies this Service.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchServiceOptions
        /// </summary>
        /// <param name="pathSid"> A string that uniquely identifies this Service. </param>
        public FetchServiceOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    /// 
    /// Retrieve a list of all Services for Twilio Proxy.
    /// </summary>
    public class ReadServiceOptions : ReadOptions<ServiceResource> 
    {
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    /// 
    /// Create a new Service for Twilio Proxy
    /// </summary>
    public class CreateServiceOptions : IOptions<ServiceResource> 
    {
        /// <summary>
        /// The human-readable string that uniquely identifies this Service.
        /// </summary>
        public string UniqueName { get; }
        /// <summary>
        /// Default TTL for a Session, in seconds.
        /// </summary>
        public int? DefaultTtl { get; set; }
        /// <summary>
        /// URL Twilio will send callbacks to
        /// </summary>
        public Uri CallbackUrl { get; set; }
        /// <summary>
        /// Whether to find proxy numbers in the same areacode.
        /// </summary>
        public ServiceResource.GeoMatchLevelEnum GeoMatchLevel { get; set; }
        /// <summary>
        /// What behavior to use when choosing a proxy number.
        /// </summary>
        public ServiceResource.NumberSelectionBehaviorEnum NumberSelectionBehavior { get; set; }
        /// <summary>
        /// A URL for Twilio call before each Interaction.
        /// </summary>
        public Uri InterceptCallbackUrl { get; set; }
        /// <summary>
        /// A URL for Twilio call when a new Interaction has no Session.
        /// </summary>
        public Uri OutOfSessionCallbackUrl { get; set; }

        /// <summary>
        /// Construct a new CreateServiceOptions
        /// </summary>
        /// <param name="uniqueName"> The human-readable string that uniquely identifies this Service. </param>
        public CreateServiceOptions(string uniqueName)
        {
            UniqueName = uniqueName;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }

            if (DefaultTtl != null)
            {
                p.Add(new KeyValuePair<string, string>("DefaultTtl", DefaultTtl.Value.ToString()));
            }

            if (CallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("CallbackUrl", CallbackUrl.AbsoluteUri.TrimEnd('/')));
            }

            if (GeoMatchLevel != null)
            {
                p.Add(new KeyValuePair<string, string>("GeoMatchLevel", GeoMatchLevel.ToString()));
            }

            if (NumberSelectionBehavior != null)
            {
                p.Add(new KeyValuePair<string, string>("NumberSelectionBehavior", NumberSelectionBehavior.ToString()));
            }

            if (InterceptCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("InterceptCallbackUrl", InterceptCallbackUrl.AbsoluteUri.TrimEnd('/')));
            }

            if (OutOfSessionCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("OutOfSessionCallbackUrl", OutOfSessionCallbackUrl.AbsoluteUri.TrimEnd('/')));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    /// 
    /// Delete a specific Service.
    /// </summary>
    public class DeleteServiceOptions : IOptions<ServiceResource> 
    {
        /// <summary>
        /// A string that uniquely identifies this Service.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteServiceOptions
        /// </summary>
        /// <param name="pathSid"> A string that uniquely identifies this Service. </param>
        public DeleteServiceOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    /// 
    /// Update a specific Service.
    /// </summary>
    public class UpdateServiceOptions : IOptions<ServiceResource> 
    {
        /// <summary>
        /// A string that uniquely identifies this Service.
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// A human readable description of this resource.
        /// </summary>
        public string UniqueName { get; set; }
        /// <summary>
        /// Default TTL for a Session, in seconds.
        /// </summary>
        public int? DefaultTtl { get; set; }
        /// <summary>
        /// URL Twilio will send callbacks to
        /// </summary>
        public Uri CallbackUrl { get; set; }
        /// <summary>
        /// Whether to find proxy numbers in the same areacode.
        /// </summary>
        public ServiceResource.GeoMatchLevelEnum GeoMatchLevel { get; set; }
        /// <summary>
        /// What behavior to use when choosing a proxy number.
        /// </summary>
        public ServiceResource.NumberSelectionBehaviorEnum NumberSelectionBehavior { get; set; }
        /// <summary>
        /// A URL for Twilio call before each Interaction.
        /// </summary>
        public Uri InterceptCallbackUrl { get; set; }
        /// <summary>
        /// A URL for Twilio call when a new Interaction has no Session.
        /// </summary>
        public Uri OutOfSessionCallbackUrl { get; set; }

        /// <summary>
        /// Construct a new UpdateServiceOptions
        /// </summary>
        /// <param name="pathSid"> A string that uniquely identifies this Service. </param>
        public UpdateServiceOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }

            if (DefaultTtl != null)
            {
                p.Add(new KeyValuePair<string, string>("DefaultTtl", DefaultTtl.Value.ToString()));
            }

            if (CallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("CallbackUrl", CallbackUrl.AbsoluteUri.TrimEnd('/')));
            }

            if (GeoMatchLevel != null)
            {
                p.Add(new KeyValuePair<string, string>("GeoMatchLevel", GeoMatchLevel.ToString()));
            }

            if (NumberSelectionBehavior != null)
            {
                p.Add(new KeyValuePair<string, string>("NumberSelectionBehavior", NumberSelectionBehavior.ToString()));
            }

            if (InterceptCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("InterceptCallbackUrl", InterceptCallbackUrl.AbsoluteUri.TrimEnd('/')));
            }

            if (OutOfSessionCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("OutOfSessionCallbackUrl", OutOfSessionCallbackUrl.AbsoluteUri.TrimEnd('/')));
            }

            return p;
        }
    }

}
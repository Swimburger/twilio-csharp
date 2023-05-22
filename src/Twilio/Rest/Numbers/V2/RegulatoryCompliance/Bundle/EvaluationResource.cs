/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Numbers
 * This is the public Twilio REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;


namespace Twilio.Rest.Numbers.V2.RegulatoryCompliance.Bundle
{
    public class EvaluationResource : Resource
    {
    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class StatusEnum : StringEnum
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }
            public static readonly StatusEnum Compliant = new StatusEnum("compliant");
            public static readonly StatusEnum Noncompliant = new StatusEnum("noncompliant");

        }

        
        private static Request BuildCreateRequest(CreateEvaluationOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/RegulatoryCompliance/Bundles/{BundleSid}/Evaluations";

            string PathBundleSid = options.PathBundleSid;
            path = path.Replace("{"+"BundleSid"+"}", PathBundleSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Numbers,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Creates an evaluation for a bundle </summary>
        /// <param name="options"> Create Evaluation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Evaluation </returns>
        public static EvaluationResource Create(CreateEvaluationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Creates an evaluation for a bundle </summary>
        /// <param name="options"> Create Evaluation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Evaluation </returns>
        public static async System.Threading.Tasks.Task<EvaluationResource> CreateAsync(CreateEvaluationOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Creates an evaluation for a bundle </summary>
        /// <param name="pathBundleSid"> The unique string that identifies the Bundle resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Evaluation </returns>
        public static EvaluationResource Create(
                                          string pathBundleSid,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateEvaluationOptions(pathBundleSid){  };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Creates an evaluation for a bundle </summary>
        /// <param name="pathBundleSid"> The unique string that identifies the Bundle resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Evaluation </returns>
        public static async System.Threading.Tasks.Task<EvaluationResource> CreateAsync(
                                                                                  string pathBundleSid,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateEvaluationOptions(pathBundleSid){  };
            return await CreateAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchEvaluationOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/RegulatoryCompliance/Bundles/{BundleSid}/Evaluations/{Sid}";

            string PathBundleSid = options.PathBundleSid;
            path = path.Replace("{"+"BundleSid"+"}", PathBundleSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Numbers,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch specific Evaluation Instance. </summary>
        /// <param name="options"> Fetch Evaluation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Evaluation </returns>
        public static EvaluationResource Fetch(FetchEvaluationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch specific Evaluation Instance. </summary>
        /// <param name="options"> Fetch Evaluation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Evaluation </returns>
        public static async System.Threading.Tasks.Task<EvaluationResource> FetchAsync(FetchEvaluationOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch specific Evaluation Instance. </summary>
        /// <param name="pathBundleSid"> The unique string that we created to identify the Bundle resource. </param>
        /// <param name="pathSid"> The unique string that identifies the Evaluation resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Evaluation </returns>
        public static EvaluationResource Fetch(
                                         string pathBundleSid, 
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchEvaluationOptions(pathBundleSid, pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch specific Evaluation Instance. </summary>
        /// <param name="pathBundleSid"> The unique string that we created to identify the Bundle resource. </param>
        /// <param name="pathSid"> The unique string that identifies the Evaluation resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Evaluation </returns>
        public static async System.Threading.Tasks.Task<EvaluationResource> FetchAsync(string pathBundleSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchEvaluationOptions(pathBundleSid, pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadEvaluationOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/RegulatoryCompliance/Bundles/{BundleSid}/Evaluations";

            string PathBundleSid = options.PathBundleSid;
            path = path.Replace("{"+"BundleSid"+"}", PathBundleSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Numbers,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of Evaluations associated to the Bundle resource. </summary>
        /// <param name="options"> Read Evaluation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Evaluation </returns>
        public static ResourceSet<EvaluationResource> Read(ReadEvaluationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<EvaluationResource>.FromJson("results", response.Content);
            return new ResourceSet<EvaluationResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of Evaluations associated to the Bundle resource. </summary>
        /// <param name="options"> Read Evaluation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Evaluation </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<EvaluationResource>> ReadAsync(ReadEvaluationOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<EvaluationResource>.FromJson("results", response.Content);
            return new ResourceSet<EvaluationResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of Evaluations associated to the Bundle resource. </summary>
        /// <param name="pathBundleSid"> The unique string that identifies the Bundle resource. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Evaluation </returns>
        public static ResourceSet<EvaluationResource> Read(
                                                     string pathBundleSid,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadEvaluationOptions(pathBundleSid){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of Evaluations associated to the Bundle resource. </summary>
        /// <param name="pathBundleSid"> The unique string that identifies the Bundle resource. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Evaluation </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<EvaluationResource>> ReadAsync(
                                                                                             string pathBundleSid,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadEvaluationOptions(pathBundleSid){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<EvaluationResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<EvaluationResource>.FromJson("results", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<EvaluationResource> NextPage(Page<EvaluationResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<EvaluationResource>.FromJson("results", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<EvaluationResource> PreviousPage(Page<EvaluationResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<EvaluationResource>.FromJson("results", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a EvaluationResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> EvaluationResource object represented by the provided JSON </returns>
        public static EvaluationResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<EvaluationResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The unique string that identifies the Evaluation resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Bundle resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The unique string of a regulation that is associated to the Bundle resource. </summary> 
        [JsonProperty("regulation_sid")]
        public string RegulationSid { get; private set; }

        ///<summary> The unique string that we created to identify the Bundle resource. </summary> 
        [JsonProperty("bundle_sid")]
        public string BundleSid { get; private set; }

        
        [JsonProperty("status")]
        public EvaluationResource.StatusEnum Status { get; private set; }

        ///<summary> The results of the Evaluation which includes the valid and invalid attributes. </summary> 
        [JsonProperty("results")]
        public List<object> Results { get; private set; }

        ///<summary> The date_created </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private EvaluationResource() {

        }
    }
}


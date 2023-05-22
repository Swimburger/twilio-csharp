/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Studio
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



namespace Twilio.Rest.Studio.V1.Flow.Engagement
{
    public class StepResource : Resource
    {
    

        
        private static Request BuildFetchRequest(FetchStepOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Flows/{FlowSid}/Engagements/{EngagementSid}/Steps/{Sid}";

            string PathFlowSid = options.PathFlowSid;
            path = path.Replace("{"+"FlowSid"+"}", PathFlowSid);
            string PathEngagementSid = options.PathEngagementSid;
            path = path.Replace("{"+"EngagementSid"+"}", PathEngagementSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Studio,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Retrieve a Step. </summary>
        /// <param name="options"> Fetch Step parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Step </returns>
        public static StepResource Fetch(FetchStepOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Retrieve a Step. </summary>
        /// <param name="options"> Fetch Step parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Step </returns>
        public static async System.Threading.Tasks.Task<StepResource> FetchAsync(FetchStepOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Retrieve a Step. </summary>
        /// <param name="pathFlowSid"> The SID of the Flow with the Step to fetch. </param>
        /// <param name="pathEngagementSid"> The SID of the Engagement with the Step to fetch. </param>
        /// <param name="pathSid"> The SID of the Step resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Step </returns>
        public static StepResource Fetch(
                                         string pathFlowSid, 
                                         string pathEngagementSid, 
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchStepOptions(pathFlowSid, pathEngagementSid, pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a Step. </summary>
        /// <param name="pathFlowSid"> The SID of the Flow with the Step to fetch. </param>
        /// <param name="pathEngagementSid"> The SID of the Engagement with the Step to fetch. </param>
        /// <param name="pathSid"> The SID of the Step resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Step </returns>
        public static async System.Threading.Tasks.Task<StepResource> FetchAsync(string pathFlowSid, string pathEngagementSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchStepOptions(pathFlowSid, pathEngagementSid, pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadStepOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Flows/{FlowSid}/Engagements/{EngagementSid}/Steps";

            string PathFlowSid = options.PathFlowSid;
            path = path.Replace("{"+"FlowSid"+"}", PathFlowSid);
            string PathEngagementSid = options.PathEngagementSid;
            path = path.Replace("{"+"EngagementSid"+"}", PathEngagementSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Studio,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of all Steps for an Engagement. </summary>
        /// <param name="options"> Read Step parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Step </returns>
        public static ResourceSet<StepResource> Read(ReadStepOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<StepResource>.FromJson("steps", response.Content);
            return new ResourceSet<StepResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Steps for an Engagement. </summary>
        /// <param name="options"> Read Step parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Step </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<StepResource>> ReadAsync(ReadStepOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<StepResource>.FromJson("steps", response.Content);
            return new ResourceSet<StepResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of all Steps for an Engagement. </summary>
        /// <param name="pathFlowSid"> The SID of the Flow with the Step to read. </param>
        /// <param name="pathEngagementSid"> The SID of the Engagement with the Step to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Step </returns>
        public static ResourceSet<StepResource> Read(
                                                     string pathFlowSid,
                                                     string pathEngagementSid,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadStepOptions(pathFlowSid, pathEngagementSid){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Steps for an Engagement. </summary>
        /// <param name="pathFlowSid"> The SID of the Flow with the Step to read. </param>
        /// <param name="pathEngagementSid"> The SID of the Engagement with the Step to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Step </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<StepResource>> ReadAsync(
                                                                                             string pathFlowSid,
                                                                                             string pathEngagementSid,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadStepOptions(pathFlowSid, pathEngagementSid){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<StepResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<StepResource>.FromJson("steps", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<StepResource> NextPage(Page<StepResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<StepResource>.FromJson("steps", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<StepResource> PreviousPage(Page<StepResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<StepResource>.FromJson("steps", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a StepResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> StepResource object represented by the provided JSON </returns>
        public static StepResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<StepResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The unique string that we created to identify the Step resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Step resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the Flow. </summary> 
        [JsonProperty("flow_sid")]
        public string FlowSid { get; private set; }

        ///<summary> The SID of the Engagement. </summary> 
        [JsonProperty("engagement_sid")]
        public string EngagementSid { get; private set; }

        ///<summary> The event that caused the Flow to transition to the Step. </summary> 
        [JsonProperty("name")]
        public string Name { get; private set; }

        ///<summary> The current state of the Flow's Execution. As a flow executes, we save its state in this context. We save data that your widgets can access as variables in configuration fields or in text areas as variable substitution. </summary> 
        [JsonProperty("context")]
        public object Context { get; private set; }

        ///<summary> The Widget that preceded the Widget for the Step. </summary> 
        [JsonProperty("transitioned_from")]
        public string TransitionedFrom { get; private set; }

        ///<summary> The Widget that will follow the Widget for the Step. </summary> 
        [JsonProperty("transitioned_to")]
        public string TransitionedTo { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the resource was last updated specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The absolute URL of the resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The URLs of related resources. </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private StepResource() {

        }
    }
}


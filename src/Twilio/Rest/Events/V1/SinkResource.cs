/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Events
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
using Twilio.Constant;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;


namespace Twilio.Rest.Events.V1
{
    public class SinkResource : Resource
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
            public static readonly StatusEnum Initialized = new StatusEnum("initialized");
            public static readonly StatusEnum Validating = new StatusEnum("validating");
            public static readonly StatusEnum Active = new StatusEnum("active");
            public static readonly StatusEnum Failed = new StatusEnum("failed");

        }
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class SinkTypeEnum : StringEnum
        {
            private SinkTypeEnum(string value) : base(value) {}
            public SinkTypeEnum() {}
            public static implicit operator SinkTypeEnum(string value)
            {
                return new SinkTypeEnum(value);
            }
            public static readonly SinkTypeEnum Kinesis = new SinkTypeEnum("kinesis");
            public static readonly SinkTypeEnum Webhook = new SinkTypeEnum("webhook");
            public static readonly SinkTypeEnum Segment = new SinkTypeEnum("segment");

        }

        
        private static Request BuildCreateRequest(CreateSinkOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Sinks";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Events,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a new Sink </summary>
        /// <param name="options"> Create Sink parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sink </returns>
        public static SinkResource Create(CreateSinkOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Create a new Sink </summary>
        /// <param name="options"> Create Sink parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sink </returns>
        public static async System.Threading.Tasks.Task<SinkResource> CreateAsync(CreateSinkOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Create a new Sink </summary>
        /// <param name="description"> A human readable description for the Sink **This value should not contain PII.** </param>
        /// <param name="sinkConfiguration"> The information required for Twilio to connect to the provided Sink encoded as JSON. </param>
        /// <param name="sinkType">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sink </returns>
        public static SinkResource Create(
                                          string description,
                                          object sinkConfiguration,
                                          SinkResource.SinkTypeEnum sinkType,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateSinkOptions(description, sinkConfiguration, sinkType){  };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Create a new Sink </summary>
        /// <param name="description"> A human readable description for the Sink **This value should not contain PII.** </param>
        /// <param name="sinkConfiguration"> The information required for Twilio to connect to the provided Sink encoded as JSON. </param>
        /// <param name="sinkType">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sink </returns>
        public static async System.Threading.Tasks.Task<SinkResource> CreateAsync(
                                                                                  string description,
                                                                                  object sinkConfiguration,
                                                                                  SinkResource.SinkTypeEnum sinkType,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateSinkOptions(description, sinkConfiguration, sinkType){  };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> Delete a specific Sink. </summary>
        /// <param name="options"> Delete Sink parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sink </returns>
        private static Request BuildDeleteRequest(DeleteSinkOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Sinks/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Events,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Delete a specific Sink. </summary>
        /// <param name="options"> Delete Sink parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sink </returns>
        public static bool Delete(DeleteSinkOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> Delete a specific Sink. </summary>
        /// <param name="options"> Delete Sink parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sink </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteSinkOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> Delete a specific Sink. </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this Sink. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sink </returns>
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteSinkOptions(pathSid)     ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> Delete a specific Sink. </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this Sink. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sink </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteSinkOptions(pathSid) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchSinkOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Sinks/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Events,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch a specific Sink. </summary>
        /// <param name="options"> Fetch Sink parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sink </returns>
        public static SinkResource Fetch(FetchSinkOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch a specific Sink. </summary>
        /// <param name="options"> Fetch Sink parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sink </returns>
        public static async System.Threading.Tasks.Task<SinkResource> FetchAsync(FetchSinkOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch a specific Sink. </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this Sink. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sink </returns>
        public static SinkResource Fetch(
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchSinkOptions(pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch a specific Sink. </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this Sink. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sink </returns>
        public static async System.Threading.Tasks.Task<SinkResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchSinkOptions(pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadSinkOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Sinks";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Events,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a paginated list of Sinks belonging to the account used to make the request. </summary>
        /// <param name="options"> Read Sink parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sink </returns>
        public static ResourceSet<SinkResource> Read(ReadSinkOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<SinkResource>.FromJson("sinks", response.Content);
            return new ResourceSet<SinkResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a paginated list of Sinks belonging to the account used to make the request. </summary>
        /// <param name="options"> Read Sink parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sink </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SinkResource>> ReadAsync(ReadSinkOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<SinkResource>.FromJson("sinks", response.Content);
            return new ResourceSet<SinkResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a paginated list of Sinks belonging to the account used to make the request. </summary>
        /// <param name="inUse"> A boolean query parameter filtering the results to return sinks used/not used by a subscription. </param>
        /// <param name="status"> A String query parameter filtering the results by status `initialized`, `validating`, `active` or `failed`. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sink </returns>
        public static ResourceSet<SinkResource> Read(
                                                     bool? inUse = null,
                                                     string status = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadSinkOptions(){ InUse = inUse, Status = status, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a paginated list of Sinks belonging to the account used to make the request. </summary>
        /// <param name="inUse"> A boolean query parameter filtering the results to return sinks used/not used by a subscription. </param>
        /// <param name="status"> A String query parameter filtering the results by status `initialized`, `validating`, `active` or `failed`. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sink </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SinkResource>> ReadAsync(
                                                                                             bool? inUse = null,
                                                                                             string status = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadSinkOptions(){ InUse = inUse, Status = status, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<SinkResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<SinkResource>.FromJson("sinks", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<SinkResource> NextPage(Page<SinkResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<SinkResource>.FromJson("sinks", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<SinkResource> PreviousPage(Page<SinkResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<SinkResource>.FromJson("sinks", response.Content);
        }

        
        private static Request BuildUpdateRequest(UpdateSinkOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Sinks/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Events,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Update a specific Sink </summary>
        /// <param name="options"> Update Sink parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sink </returns>
        public static SinkResource Update(UpdateSinkOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Update a specific Sink </summary>
        /// <param name="options"> Update Sink parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sink </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<SinkResource> UpdateAsync(UpdateSinkOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Update a specific Sink </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this Sink. </param>
        /// <param name="description"> A human readable description for the Sink **This value should not contain PII.** </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sink </returns>
        public static SinkResource Update(
                                          string pathSid,
                                          string description,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateSinkOptions(pathSid, description){  };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> Update a specific Sink </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this Sink. </param>
        /// <param name="description"> A human readable description for the Sink **This value should not contain PII.** </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sink </returns>
        public static async System.Threading.Tasks.Task<SinkResource> UpdateAsync(
                                                                              string pathSid,
                                                                              string description,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateSinkOptions(pathSid, description){  };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a SinkResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> SinkResource object represented by the provided JSON </returns>
        public static SinkResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<SinkResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
        /// <summary>
    /// Converts an object into a json string
    /// </summary>
    /// <param name="model"> C# model </param>
    /// <returns> JSON string </returns>
    public static string ToJson(object model)
    {
        try
        {
            return JsonConvert.SerializeObject(model);
        }
        catch (JsonException e)
        {
            throw new ApiException(e.Message, e);
        }
    }

    
        ///<summary> The date that this Sink was created, given in ISO 8601 format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date that this Sink was updated, given in ISO 8601 format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> A human readable description for the Sink </summary> 
        [JsonProperty("description")]
        public string Description { get; private set; }

        ///<summary> A 34 character string that uniquely identifies this Sink. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The information required for Twilio to connect to the provided Sink encoded as JSON. </summary> 
        [JsonProperty("sink_configuration")]
        public object SinkConfiguration { get; private set; }

        
        [JsonProperty("sink_type")]
        public SinkResource.SinkTypeEnum SinkType { get; private set; }

        
        [JsonProperty("status")]
        public SinkResource.StatusEnum Status { get; private set; }

        ///<summary> The URL of this resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> Contains a dictionary of URL links to nested resources of this Sink. </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private SinkResource() {

        }
    }
}


/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Api
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



namespace Twilio.Rest.Api.V2010.Account
{
    public class QueueResource : Resource
    {
    

        
        private static Request BuildCreateRequest(CreateQueueOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/Queues.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a queue </summary>
        /// <param name="options"> Create Queue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Queue </returns>
        public static QueueResource Create(CreateQueueOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Create a queue </summary>
        /// <param name="options"> Create Queue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Queue </returns>
        public static async System.Threading.Tasks.Task<QueueResource> CreateAsync(CreateQueueOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Create a queue </summary>
        /// <param name="friendlyName"> A descriptive string that you created to describe this resource. It can be up to 64 characters long. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that will create the resource. </param>
        /// <param name="maxSize"> The maximum number of calls allowed to be in the queue. The default is 1000. The maximum is 5000. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Queue </returns>
        public static QueueResource Create(
                                          string friendlyName,
                                          string pathAccountSid = null,
                                          int? maxSize = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateQueueOptions(friendlyName){  PathAccountSid = pathAccountSid, MaxSize = maxSize };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Create a queue </summary>
        /// <param name="friendlyName"> A descriptive string that you created to describe this resource. It can be up to 64 characters long. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that will create the resource. </param>
        /// <param name="maxSize"> The maximum number of calls allowed to be in the queue. The default is 1000. The maximum is 5000. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Queue </returns>
        public static async System.Threading.Tasks.Task<QueueResource> CreateAsync(
                                                                                  string friendlyName,
                                                                                  string pathAccountSid = null,
                                                                                  int? maxSize = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateQueueOptions(friendlyName){  PathAccountSid = pathAccountSid, MaxSize = maxSize };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> Remove an empty queue </summary>
        /// <param name="options"> Delete Queue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Queue </returns>
        private static Request BuildDeleteRequest(DeleteQueueOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/Queues/{Sid}.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Remove an empty queue </summary>
        /// <param name="options"> Delete Queue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Queue </returns>
        public static bool Delete(DeleteQueueOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> Remove an empty queue </summary>
        /// <param name="options"> Delete Queue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Queue </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteQueueOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> Remove an empty queue </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Queue resource to delete </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Queue resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Queue </returns>
        public static bool Delete(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteQueueOptions(pathSid)      { PathAccountSid = pathAccountSid }   ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> Remove an empty queue </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Queue resource to delete </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Queue resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Queue </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteQueueOptions(pathSid)  { PathAccountSid = pathAccountSid };
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchQueueOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/Queues/{Sid}.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch an instance of a queue identified by the QueueSid </summary>
        /// <param name="options"> Fetch Queue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Queue </returns>
        public static QueueResource Fetch(FetchQueueOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch an instance of a queue identified by the QueueSid </summary>
        /// <param name="options"> Fetch Queue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Queue </returns>
        public static async System.Threading.Tasks.Task<QueueResource> FetchAsync(FetchQueueOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch an instance of a queue identified by the QueueSid </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Queue resource to fetch </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Queue resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Queue </returns>
        public static QueueResource Fetch(
                                         string pathSid, 
                                         string pathAccountSid = null, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchQueueOptions(pathSid){ PathAccountSid = pathAccountSid };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch an instance of a queue identified by the QueueSid </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Queue resource to fetch </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Queue resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Queue </returns>
        public static async System.Threading.Tasks.Task<QueueResource> FetchAsync(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchQueueOptions(pathSid){ PathAccountSid = pathAccountSid };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadQueueOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/Queues.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of queues belonging to the account used to make the request </summary>
        /// <param name="options"> Read Queue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Queue </returns>
        public static ResourceSet<QueueResource> Read(ReadQueueOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<QueueResource>.FromJson("queues", response.Content);
            return new ResourceSet<QueueResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of queues belonging to the account used to make the request </summary>
        /// <param name="options"> Read Queue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Queue </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<QueueResource>> ReadAsync(ReadQueueOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<QueueResource>.FromJson("queues", response.Content);
            return new ResourceSet<QueueResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of queues belonging to the account used to make the request </summary>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Queue resources to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Queue </returns>
        public static ResourceSet<QueueResource> Read(
                                                     string pathAccountSid = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadQueueOptions(){ PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of queues belonging to the account used to make the request </summary>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Queue resources to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Queue </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<QueueResource>> ReadAsync(
                                                                                             string pathAccountSid = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadQueueOptions(){ PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<QueueResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<QueueResource>.FromJson("queues", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<QueueResource> NextPage(Page<QueueResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<QueueResource>.FromJson("queues", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<QueueResource> PreviousPage(Page<QueueResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<QueueResource>.FromJson("queues", response.Content);
        }

        
        private static Request BuildUpdateRequest(UpdateQueueOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/Queues/{Sid}.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Update the queue with the new parameters </summary>
        /// <param name="options"> Update Queue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Queue </returns>
        public static QueueResource Update(UpdateQueueOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Update the queue with the new parameters </summary>
        /// <param name="options"> Update Queue parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Queue </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<QueueResource> UpdateAsync(UpdateQueueOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Update the queue with the new parameters </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Queue resource to update </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Queue resource to update. </param>
        /// <param name="friendlyName"> A descriptive string that you created to describe this resource. It can be up to 64 characters long. </param>
        /// <param name="maxSize"> The maximum number of calls allowed to be in the queue. The default is 1000. The maximum is 5000. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Queue </returns>
        public static QueueResource Update(
                                          string pathSid,
                                          string pathAccountSid = null,
                                          string friendlyName = null,
                                          int? maxSize = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateQueueOptions(pathSid){ PathAccountSid = pathAccountSid, FriendlyName = friendlyName, MaxSize = maxSize };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> Update the queue with the new parameters </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Queue resource to update </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Queue resource to update. </param>
        /// <param name="friendlyName"> A descriptive string that you created to describe this resource. It can be up to 64 characters long. </param>
        /// <param name="maxSize"> The maximum number of calls allowed to be in the queue. The default is 1000. The maximum is 5000. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Queue </returns>
        public static async System.Threading.Tasks.Task<QueueResource> UpdateAsync(
                                                                              string pathSid,
                                                                              string pathAccountSid = null,
                                                                              string friendlyName = null,
                                                                              int? maxSize = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateQueueOptions(pathSid){ PathAccountSid = pathAccountSid, FriendlyName = friendlyName, MaxSize = maxSize };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a QueueResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> QueueResource object represented by the provided JSON </returns>
        public static QueueResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<QueueResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The date and time in GMT that this resource was last updated, specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The number of calls currently in the queue. </summary> 
        [JsonProperty("current_size")]
        public int? CurrentSize { get; private set; }

        ///<summary> A string that you assigned to describe this resource. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> The URI of this resource, relative to `https://api.twilio.com`. </summary> 
        [JsonProperty("uri")]
        public string Uri { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created this Queue resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary>  The average wait time in seconds of the members in this queue. This is calculated at the time of the request. </summary> 
        [JsonProperty("average_wait_time")]
        public int? AverageWaitTime { get; private set; }

        ///<summary> The unique string that that we created to identify this Queue resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The date and time in GMT that this resource was created specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary>  The maximum number of calls that can be in the queue. The default is 1000 and the maximum is 5000. </summary> 
        [JsonProperty("max_size")]
        public int? MaxSize { get; private set; }



        private QueueResource() {

        }
    }
}


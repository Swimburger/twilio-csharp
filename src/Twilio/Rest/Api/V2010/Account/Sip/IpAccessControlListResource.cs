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



namespace Twilio.Rest.Api.V2010.Account.Sip
{
    public class IpAccessControlListResource : Resource
    {
    

        
        private static Request BuildCreateRequest(CreateIpAccessControlListOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/SIP/IpAccessControlLists.json";

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

        /// <summary> Create a new IpAccessControlList resource </summary>
        /// <param name="options"> Create IpAccessControlList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAccessControlList </returns>
        public static IpAccessControlListResource Create(CreateIpAccessControlListOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Create a new IpAccessControlList resource </summary>
        /// <param name="options"> Create IpAccessControlList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAccessControlList </returns>
        public static async System.Threading.Tasks.Task<IpAccessControlListResource> CreateAsync(CreateIpAccessControlListOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Create a new IpAccessControlList resource </summary>
        /// <param name="friendlyName"> A human readable descriptive text that describes the IpAccessControlList, up to 255 characters long. </param>
        /// <param name="pathAccountSid"> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAccessControlList </returns>
        public static IpAccessControlListResource Create(
                                          string friendlyName,
                                          string pathAccountSid = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateIpAccessControlListOptions(friendlyName){  PathAccountSid = pathAccountSid };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Create a new IpAccessControlList resource </summary>
        /// <param name="friendlyName"> A human readable descriptive text that describes the IpAccessControlList, up to 255 characters long. </param>
        /// <param name="pathAccountSid"> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAccessControlList </returns>
        public static async System.Threading.Tasks.Task<IpAccessControlListResource> CreateAsync(
                                                                                  string friendlyName,
                                                                                  string pathAccountSid = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateIpAccessControlListOptions(friendlyName){  PathAccountSid = pathAccountSid };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> Delete an IpAccessControlList from the requested account </summary>
        /// <param name="options"> Delete IpAccessControlList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAccessControlList </returns>
        private static Request BuildDeleteRequest(DeleteIpAccessControlListOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/SIP/IpAccessControlLists/{Sid}.json";

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

        /// <summary> Delete an IpAccessControlList from the requested account </summary>
        /// <param name="options"> Delete IpAccessControlList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAccessControlList </returns>
        public static bool Delete(DeleteIpAccessControlListOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> Delete an IpAccessControlList from the requested account </summary>
        /// <param name="options"> Delete IpAccessControlList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAccessControlList </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteIpAccessControlListOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> Delete an IpAccessControlList from the requested account </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies the resource to delete. </param>
        /// <param name="pathAccountSid"> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAccessControlList </returns>
        public static bool Delete(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteIpAccessControlListOptions(pathSid)      { PathAccountSid = pathAccountSid }   ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> Delete an IpAccessControlList from the requested account </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies the resource to delete. </param>
        /// <param name="pathAccountSid"> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAccessControlList </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteIpAccessControlListOptions(pathSid)  { PathAccountSid = pathAccountSid };
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchIpAccessControlListOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/SIP/IpAccessControlLists/{Sid}.json";

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

        /// <summary> Fetch a specific instance of an IpAccessControlList </summary>
        /// <param name="options"> Fetch IpAccessControlList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAccessControlList </returns>
        public static IpAccessControlListResource Fetch(FetchIpAccessControlListOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch a specific instance of an IpAccessControlList </summary>
        /// <param name="options"> Fetch IpAccessControlList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAccessControlList </returns>
        public static async System.Threading.Tasks.Task<IpAccessControlListResource> FetchAsync(FetchIpAccessControlListOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch a specific instance of an IpAccessControlList </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies the resource to fetch. </param>
        /// <param name="pathAccountSid"> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAccessControlList </returns>
        public static IpAccessControlListResource Fetch(
                                         string pathSid, 
                                         string pathAccountSid = null, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchIpAccessControlListOptions(pathSid){ PathAccountSid = pathAccountSid };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch a specific instance of an IpAccessControlList </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies the resource to fetch. </param>
        /// <param name="pathAccountSid"> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAccessControlList </returns>
        public static async System.Threading.Tasks.Task<IpAccessControlListResource> FetchAsync(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchIpAccessControlListOptions(pathSid){ PathAccountSid = pathAccountSid };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadIpAccessControlListOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/SIP/IpAccessControlLists.json";

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
        /// <summary> Retrieve a list of IpAccessControlLists that belong to the account used to make the request </summary>
        /// <param name="options"> Read IpAccessControlList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAccessControlList </returns>
        public static ResourceSet<IpAccessControlListResource> Read(ReadIpAccessControlListOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<IpAccessControlListResource>.FromJson("ip_access_control_lists", response.Content);
            return new ResourceSet<IpAccessControlListResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of IpAccessControlLists that belong to the account used to make the request </summary>
        /// <param name="options"> Read IpAccessControlList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAccessControlList </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<IpAccessControlListResource>> ReadAsync(ReadIpAccessControlListOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<IpAccessControlListResource>.FromJson("ip_access_control_lists", response.Content);
            return new ResourceSet<IpAccessControlListResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of IpAccessControlLists that belong to the account used to make the request </summary>
        /// <param name="pathAccountSid"> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAccessControlList </returns>
        public static ResourceSet<IpAccessControlListResource> Read(
                                                     string pathAccountSid = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadIpAccessControlListOptions(){ PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of IpAccessControlLists that belong to the account used to make the request </summary>
        /// <param name="pathAccountSid"> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAccessControlList </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<IpAccessControlListResource>> ReadAsync(
                                                                                             string pathAccountSid = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadIpAccessControlListOptions(){ PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<IpAccessControlListResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<IpAccessControlListResource>.FromJson("ip_access_control_lists", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<IpAccessControlListResource> NextPage(Page<IpAccessControlListResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<IpAccessControlListResource>.FromJson("ip_access_control_lists", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<IpAccessControlListResource> PreviousPage(Page<IpAccessControlListResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<IpAccessControlListResource>.FromJson("ip_access_control_lists", response.Content);
        }

        
        private static Request BuildUpdateRequest(UpdateIpAccessControlListOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/SIP/IpAccessControlLists/{Sid}.json";

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

        /// <summary> Rename an IpAccessControlList </summary>
        /// <param name="options"> Update IpAccessControlList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAccessControlList </returns>
        public static IpAccessControlListResource Update(UpdateIpAccessControlListOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Rename an IpAccessControlList </summary>
        /// <param name="options"> Update IpAccessControlList parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAccessControlList </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<IpAccessControlListResource> UpdateAsync(UpdateIpAccessControlListOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Rename an IpAccessControlList </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies the resource to udpate. </param>
        /// <param name="friendlyName"> A human readable descriptive text, up to 255 characters long. </param>
        /// <param name="pathAccountSid"> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAccessControlList </returns>
        public static IpAccessControlListResource Update(
                                          string pathSid,
                                          string friendlyName,
                                          string pathAccountSid = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateIpAccessControlListOptions(pathSid, friendlyName){ PathAccountSid = pathAccountSid };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> Rename an IpAccessControlList </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies the resource to udpate. </param>
        /// <param name="friendlyName"> A human readable descriptive text, up to 255 characters long. </param>
        /// <param name="pathAccountSid"> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAccessControlList </returns>
        public static async System.Threading.Tasks.Task<IpAccessControlListResource> UpdateAsync(
                                                                              string pathSid,
                                                                              string friendlyName,
                                                                              string pathAccountSid = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateIpAccessControlListOptions(pathSid, friendlyName){ PathAccountSid = pathAccountSid };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a IpAccessControlListResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> IpAccessControlListResource object represented by the provided JSON </returns>
        public static IpAccessControlListResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<IpAccessControlListResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> A 34 character string that uniquely identifies this resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) that owns this resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> A human readable descriptive text, up to 255 characters long. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> The date that this resource was created, given as GMT in [RFC 2822](https://www.php.net/manual/en/class.datetime.php#datetime.constants.rfc2822) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date that this resource was last updated, given as GMT in [RFC 2822](https://www.php.net/manual/en/class.datetime.php#datetime.constants.rfc2822) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> A list of the IpAddress resources associated with this IP access control list resource. </summary> 
        [JsonProperty("subresource_uris")]
        public Dictionary<string, string> SubresourceUris { get; private set; }

        ///<summary> The URI for this resource, relative to `https://api.twilio.com` </summary> 
        [JsonProperty("uri")]
        public string Uri { get; private set; }



        private IpAccessControlListResource() {

        }
    }
}


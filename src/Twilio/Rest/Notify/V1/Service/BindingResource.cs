/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Notify
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


namespace Twilio.Rest.Notify.V1.Service
{
    public class BindingResource : Resource
    {
    
        public sealed class BindingTypeEnum : StringEnum
        {
            private BindingTypeEnum(string value) : base(value) {}
            public BindingTypeEnum() {}
            public static implicit operator BindingTypeEnum(string value)
            {
                return new BindingTypeEnum(value);
            }
            public static readonly BindingTypeEnum Apn = new BindingTypeEnum("apn");
            public static readonly BindingTypeEnum Gcm = new BindingTypeEnum("gcm");
            public static readonly BindingTypeEnum Sms = new BindingTypeEnum("sms");
            public static readonly BindingTypeEnum Fcm = new BindingTypeEnum("fcm");
            public static readonly BindingTypeEnum FacebookMessenger = new BindingTypeEnum("facebook-messenger");
            public static readonly BindingTypeEnum Alexa = new BindingTypeEnum("alexa");

        }

        
        private static Request BuildCreateRequest(CreateBindingOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ServiceSid}/Bindings";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Notify,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> create </summary>
        /// <param name="options"> Create Binding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Binding </returns>
        public static BindingResource Create(CreateBindingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="options"> Create Binding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Binding </returns>
        public static async System.Threading.Tasks.Task<BindingResource> CreateAsync(CreateBindingOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> create </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/notify/api/service-resource) to create the resource under. </param>
        /// <param name="identity"> The `identity` value that uniquely identifies the new resource's [User](https://www.twilio.com/docs/chat/rest/user-resource) within the [Service](https://www.twilio.com/docs/notify/api/service-resource). Up to 20 Bindings can be created for the same Identity in a given Service. </param>
        /// <param name="bindingType">  </param>
        /// <param name="address"> The channel-specific address. For APNS, the device token. For FCM and GCM, the registration token. For SMS, a phone number in E.164 format. For Facebook Messenger, the Messenger ID of the user or a phone number in E.164 format. </param>
        /// <param name="tag"> A tag that can be used to select the Bindings to notify. Repeat this parameter to specify more than one tag, up to a total of 20 tags. </param>
        /// <param name="notificationProtocolVersion"> The protocol version to use to send the notification. This defaults to the value of `default_xxxx_notification_protocol_version` for the protocol in the [Service](https://www.twilio.com/docs/notify/api/service-resource). The current version is `\\\"3\\\"` for `apn`, `fcm`, and `gcm` type Bindings. The parameter is not applicable to `sms` and `facebook-messenger` type Bindings as the data format is fixed. </param>
        /// <param name="credentialSid"> The SID of the [Credential](https://www.twilio.com/docs/notify/api/credential-resource) resource to be used to send notifications to this Binding. If present, this overrides the Credential specified in the Service resource. Applies to only `apn`, `fcm`, and `gcm` type Bindings. </param>
        /// <param name="endpoint"> Deprecated. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Binding </returns>
        public static BindingResource Create(
                                          string pathServiceSid,
                                          string identity,
                                          BindingResource.BindingTypeEnum bindingType,
                                          string address,
                                          List<string> tag = null,
                                          string notificationProtocolVersion = null,
                                          string credentialSid = null,
                                          string endpoint = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateBindingOptions(pathServiceSid, identity, bindingType, address){  Tag = tag, NotificationProtocolVersion = notificationProtocolVersion, CredentialSid = credentialSid, Endpoint = endpoint };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/notify/api/service-resource) to create the resource under. </param>
        /// <param name="identity"> The `identity` value that uniquely identifies the new resource's [User](https://www.twilio.com/docs/chat/rest/user-resource) within the [Service](https://www.twilio.com/docs/notify/api/service-resource). Up to 20 Bindings can be created for the same Identity in a given Service. </param>
        /// <param name="bindingType">  </param>
        /// <param name="address"> The channel-specific address. For APNS, the device token. For FCM and GCM, the registration token. For SMS, a phone number in E.164 format. For Facebook Messenger, the Messenger ID of the user or a phone number in E.164 format. </param>
        /// <param name="tag"> A tag that can be used to select the Bindings to notify. Repeat this parameter to specify more than one tag, up to a total of 20 tags. </param>
        /// <param name="notificationProtocolVersion"> The protocol version to use to send the notification. This defaults to the value of `default_xxxx_notification_protocol_version` for the protocol in the [Service](https://www.twilio.com/docs/notify/api/service-resource). The current version is `\\\"3\\\"` for `apn`, `fcm`, and `gcm` type Bindings. The parameter is not applicable to `sms` and `facebook-messenger` type Bindings as the data format is fixed. </param>
        /// <param name="credentialSid"> The SID of the [Credential](https://www.twilio.com/docs/notify/api/credential-resource) resource to be used to send notifications to this Binding. If present, this overrides the Credential specified in the Service resource. Applies to only `apn`, `fcm`, and `gcm` type Bindings. </param>
        /// <param name="endpoint"> Deprecated. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Binding </returns>
        public static async System.Threading.Tasks.Task<BindingResource> CreateAsync(
                                                                                  string pathServiceSid,
                                                                                  string identity,
                                                                                  BindingResource.BindingTypeEnum bindingType,
                                                                                  string address,
                                                                                  List<string> tag = null,
                                                                                  string notificationProtocolVersion = null,
                                                                                  string credentialSid = null,
                                                                                  string endpoint = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateBindingOptions(pathServiceSid, identity, bindingType, address){  Tag = tag, NotificationProtocolVersion = notificationProtocolVersion, CredentialSid = credentialSid, Endpoint = endpoint };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> delete </summary>
        /// <param name="options"> Delete Binding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Binding </returns>
        private static Request BuildDeleteRequest(DeleteBindingOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ServiceSid}/Bindings/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Notify,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> delete </summary>
        /// <param name="options"> Delete Binding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Binding </returns>
        public static bool Delete(DeleteBindingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="options"> Delete Binding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Binding </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteBindingOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> delete </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/notify/api/service-resource) to delete the resource from. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Binding resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Binding </returns>
        public static bool Delete(string pathServiceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteBindingOptions(pathServiceSid, pathSid)        ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/notify/api/service-resource) to delete the resource from. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Binding resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Binding </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathServiceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteBindingOptions(pathServiceSid, pathSid) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchBindingOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ServiceSid}/Bindings/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Notify,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Binding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Binding </returns>
        public static BindingResource Fetch(FetchBindingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Binding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Binding </returns>
        public static async System.Threading.Tasks.Task<BindingResource> FetchAsync(FetchBindingOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> fetch </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/notify/api/service-resource) to fetch the resource from. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Binding resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Binding </returns>
        public static BindingResource Fetch(
                                         string pathServiceSid, 
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchBindingOptions(pathServiceSid, pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/notify/api/service-resource) to fetch the resource from. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Binding resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Binding </returns>
        public static async System.Threading.Tasks.Task<BindingResource> FetchAsync(string pathServiceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchBindingOptions(pathServiceSid, pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadBindingOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ServiceSid}/Bindings";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Notify,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> read </summary>
        /// <param name="options"> Read Binding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Binding </returns>
        public static ResourceSet<BindingResource> Read(ReadBindingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<BindingResource>.FromJson("bindings", response.Content);
            return new ResourceSet<BindingResource>(page, options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="options"> Read Binding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Binding </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<BindingResource>> ReadAsync(ReadBindingOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<BindingResource>.FromJson("bindings", response.Content);
            return new ResourceSet<BindingResource>(page, options, client);
        }
        #endif
        /// <summary> read </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/notify/api/service-resource) to read the resource from. </param>
        /// <param name="startDate"> Only include usage that has occurred on or after this date. Specify the date in GMT and format as `YYYY-MM-DD`. </param>
        /// <param name="endDate"> Only include usage that occurred on or before this date. Specify the date in GMT and format as `YYYY-MM-DD`. </param>
        /// <param name="identity"> The [User](https://www.twilio.com/docs/chat/rest/user-resource)'s `identity` value of the resources to read. </param>
        /// <param name="tag"> Only list Bindings that have all of the specified Tags. The following implicit tags are available: `all`, `apn`, `fcm`, `gcm`, `sms`, `facebook-messenger`. Up to 5 tags are allowed. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Binding </returns>
        public static ResourceSet<BindingResource> Read(
                                                     string pathServiceSid,
                                                     DateTime? startDate = null,
                                                     DateTime? endDate = null,
                                                     List<string> identity = null,
                                                     List<string> tag = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadBindingOptions(pathServiceSid){ StartDate = startDate, EndDate = endDate, Identity = identity, Tag = tag, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/notify/api/service-resource) to read the resource from. </param>
        /// <param name="startDate"> Only include usage that has occurred on or after this date. Specify the date in GMT and format as `YYYY-MM-DD`. </param>
        /// <param name="endDate"> Only include usage that occurred on or before this date. Specify the date in GMT and format as `YYYY-MM-DD`. </param>
        /// <param name="identity"> The [User](https://www.twilio.com/docs/chat/rest/user-resource)'s `identity` value of the resources to read. </param>
        /// <param name="tag"> Only list Bindings that have all of the specified Tags. The following implicit tags are available: `all`, `apn`, `fcm`, `gcm`, `sms`, `facebook-messenger`. Up to 5 tags are allowed. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Binding </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<BindingResource>> ReadAsync(
                                                                                             string pathServiceSid,
                                                                                             DateTime? startDate = null,
                                                                                             DateTime? endDate = null,
                                                                                             List<string> identity = null,
                                                                                             List<string> tag = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadBindingOptions(pathServiceSid){ StartDate = startDate, EndDate = endDate, Identity = identity, Tag = tag, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<BindingResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<BindingResource>.FromJson("bindings", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<BindingResource> NextPage(Page<BindingResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<BindingResource>.FromJson("bindings", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<BindingResource> PreviousPage(Page<BindingResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<BindingResource>.FromJson("bindings", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a BindingResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> BindingResource object represented by the provided JSON </returns>
        public static BindingResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<BindingResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The unique string that we created to identify the Binding resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Binding resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the [Service](https://www.twilio.com/docs/notify/api/service-resource) the resource is associated with. </summary> 
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }

        ///<summary> The SID of the [Credential](https://www.twilio.com/docs/notify/api/credential-resource) resource to be used to send notifications to this Binding. If present, this overrides the Credential specified in the Service resource. Applicable only to `apn`, `fcm`, and `gcm` type Bindings. </summary> 
        [JsonProperty("credential_sid")]
        public string CredentialSid { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the resource was last updated specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The protocol version to use to send the notification. This defaults to the value of `default_xxxx_notification_protocol_version` in the [Service](https://www.twilio.com/docs/notify/api/service-resource) for the protocol. The current version is `\"3\"` for `apn`, `fcm`, and `gcm` type Bindings. The parameter is not applicable to `sms` and `facebook-messenger` type Bindings as the data format is fixed. </summary> 
        [JsonProperty("notification_protocol_version")]
        public string NotificationProtocolVersion { get; private set; }

        ///<summary> Deprecated. </summary> 
        [JsonProperty("endpoint")]
        public string Endpoint { get; private set; }

        ///<summary> The `identity` value that uniquely identifies the resource's [User](https://www.twilio.com/docs/chat/rest/user-resource) within the [Service](https://www.twilio.com/docs/notify/api/service-resource). Up to 20 Bindings can be created for the same Identity in a given Service. </summary> 
        [JsonProperty("identity")]
        public string Identity { get; private set; }

        ///<summary> The transport technology to use for the Binding. Can be: `apn`, `fcm`, `gcm`, `sms`, or `facebook-messenger`. </summary> 
        [JsonProperty("binding_type")]
        public string BindingType { get; private set; }

        ///<summary> The channel-specific address. For APNS, the device token. For FCM and GCM, the registration token. For SMS, a phone number in E.164 format. For Facebook Messenger, the Messenger ID of the user or a phone number in E.164 format. </summary> 
        [JsonProperty("address")]
        public string Address { get; private set; }

        ///<summary> The list of tags associated with this Binding. Tags can be used to select the Bindings to use when sending a notification. Maximum 20 tags are allowed. </summary> 
        [JsonProperty("tags")]
        public List<string> Tags { get; private set; }

        ///<summary> The absolute URL of the Binding resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The URLs of related resources. </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private BindingResource() {

        }
    }
}


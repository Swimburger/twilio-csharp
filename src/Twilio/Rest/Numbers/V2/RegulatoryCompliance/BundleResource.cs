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


namespace Twilio.Rest.Numbers.V2.RegulatoryCompliance
{
    public class BundleResource : Resource
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
            public static readonly StatusEnum Draft = new StatusEnum("draft");
            public static readonly StatusEnum PendingReview = new StatusEnum("pending-review");
            public static readonly StatusEnum InReview = new StatusEnum("in-review");
            public static readonly StatusEnum TwilioRejected = new StatusEnum("twilio-rejected");
            public static readonly StatusEnum TwilioApproved = new StatusEnum("twilio-approved");
            public static readonly StatusEnum ProvisionallyApproved = new StatusEnum("provisionally-approved");

        }
        public sealed class SortByEnum : StringEnum
        {
            private SortByEnum(string value) : base(value) {}
            public SortByEnum() {}
            public static implicit operator SortByEnum(string value)
            {
                return new SortByEnum(value);
            }
            public static readonly SortByEnum ValidUntil = new SortByEnum("valid-until");
            public static readonly SortByEnum DateUpdated = new SortByEnum("date-updated");

        }
        public sealed class SortDirectionEnum : StringEnum
        {
            private SortDirectionEnum(string value) : base(value) {}
            public SortDirectionEnum() {}
            public static implicit operator SortDirectionEnum(string value)
            {
                return new SortDirectionEnum(value);
            }
            public static readonly SortDirectionEnum Asc = new SortDirectionEnum("ASC");
            public static readonly SortDirectionEnum Desc = new SortDirectionEnum("DESC");

        }
        public sealed class EndUserTypeEnum : StringEnum
        {
            private EndUserTypeEnum(string value) : base(value) {}
            public EndUserTypeEnum() {}
            public static implicit operator EndUserTypeEnum(string value)
            {
                return new EndUserTypeEnum(value);
            }
            public static readonly EndUserTypeEnum Individual = new EndUserTypeEnum("individual");
            public static readonly EndUserTypeEnum Business = new EndUserTypeEnum("business");

        }

        
        private static Request BuildCreateRequest(CreateBundleOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/RegulatoryCompliance/Bundles";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Numbers,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a new Bundle. </summary>
        /// <param name="options"> Create Bundle parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Bundle </returns>
        public static BundleResource Create(CreateBundleOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Create a new Bundle. </summary>
        /// <param name="options"> Create Bundle parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Bundle </returns>
        public static async System.Threading.Tasks.Task<BundleResource> CreateAsync(CreateBundleOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Create a new Bundle. </summary>
        /// <param name="friendlyName"> The string that you assigned to describe the resource. </param>
        /// <param name="email"> The email address that will receive updates when the Bundle resource changes status. </param>
        /// <param name="statusCallback"> The URL we call to inform your application of status changes. </param>
        /// <param name="regulationSid"> The unique string of a regulation that is associated to the Bundle resource. </param>
        /// <param name="isoCountry"> The [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) of the Bundle's phone number country ownership request. </param>
        /// <param name="endUserType">  </param>
        /// <param name="numberType"> The type of phone number of the Bundle's ownership request. Can be `local`, `mobile`, `national`, or `toll free`. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Bundle </returns>
        public static BundleResource Create(
                                          string friendlyName,
                                          string email,
                                          Uri statusCallback = null,
                                          string regulationSid = null,
                                          string isoCountry = null,
                                          BundleResource.EndUserTypeEnum endUserType = null,
                                          string numberType = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateBundleOptions(friendlyName, email){  StatusCallback = statusCallback, RegulationSid = regulationSid, IsoCountry = isoCountry, EndUserType = endUserType, NumberType = numberType };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Create a new Bundle. </summary>
        /// <param name="friendlyName"> The string that you assigned to describe the resource. </param>
        /// <param name="email"> The email address that will receive updates when the Bundle resource changes status. </param>
        /// <param name="statusCallback"> The URL we call to inform your application of status changes. </param>
        /// <param name="regulationSid"> The unique string of a regulation that is associated to the Bundle resource. </param>
        /// <param name="isoCountry"> The [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) of the Bundle's phone number country ownership request. </param>
        /// <param name="endUserType">  </param>
        /// <param name="numberType"> The type of phone number of the Bundle's ownership request. Can be `local`, `mobile`, `national`, or `toll free`. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Bundle </returns>
        public static async System.Threading.Tasks.Task<BundleResource> CreateAsync(
                                                                                  string friendlyName,
                                                                                  string email,
                                                                                  Uri statusCallback = null,
                                                                                  string regulationSid = null,
                                                                                  string isoCountry = null,
                                                                                  BundleResource.EndUserTypeEnum endUserType = null,
                                                                                  string numberType = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateBundleOptions(friendlyName, email){  StatusCallback = statusCallback, RegulationSid = regulationSid, IsoCountry = isoCountry, EndUserType = endUserType, NumberType = numberType };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> Delete a specific Bundle. </summary>
        /// <param name="options"> Delete Bundle parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Bundle </returns>
        private static Request BuildDeleteRequest(DeleteBundleOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/RegulatoryCompliance/Bundles/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Numbers,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Delete a specific Bundle. </summary>
        /// <param name="options"> Delete Bundle parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Bundle </returns>
        public static bool Delete(DeleteBundleOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> Delete a specific Bundle. </summary>
        /// <param name="options"> Delete Bundle parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Bundle </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteBundleOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> Delete a specific Bundle. </summary>
        /// <param name="pathSid"> The unique string that we created to identify the Bundle resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Bundle </returns>
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteBundleOptions(pathSid)     ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> Delete a specific Bundle. </summary>
        /// <param name="pathSid"> The unique string that we created to identify the Bundle resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Bundle </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteBundleOptions(pathSid) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchBundleOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/RegulatoryCompliance/Bundles/{Sid}";

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

        /// <summary> Fetch a specific Bundle instance. </summary>
        /// <param name="options"> Fetch Bundle parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Bundle </returns>
        public static BundleResource Fetch(FetchBundleOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch a specific Bundle instance. </summary>
        /// <param name="options"> Fetch Bundle parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Bundle </returns>
        public static async System.Threading.Tasks.Task<BundleResource> FetchAsync(FetchBundleOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch a specific Bundle instance. </summary>
        /// <param name="pathSid"> The unique string that we created to identify the Bundle resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Bundle </returns>
        public static BundleResource Fetch(
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchBundleOptions(pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch a specific Bundle instance. </summary>
        /// <param name="pathSid"> The unique string that we created to identify the Bundle resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Bundle </returns>
        public static async System.Threading.Tasks.Task<BundleResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchBundleOptions(pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadBundleOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/RegulatoryCompliance/Bundles";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Numbers,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of all Bundles for an account. </summary>
        /// <param name="options"> Read Bundle parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Bundle </returns>
        public static ResourceSet<BundleResource> Read(ReadBundleOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<BundleResource>.FromJson("results", response.Content);
            return new ResourceSet<BundleResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Bundles for an account. </summary>
        /// <param name="options"> Read Bundle parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Bundle </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<BundleResource>> ReadAsync(ReadBundleOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<BundleResource>.FromJson("results", response.Content);
            return new ResourceSet<BundleResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of all Bundles for an account. </summary>
        /// <param name="status"> The verification status of the Bundle resource. Please refer to [Bundle Statuses](https://www.twilio.com/docs/phone-numbers/regulatory/api/bundles#bundle-statuses) for more details. </param>
        /// <param name="friendlyName"> The string that you assigned to describe the resource. The column can contain 255 variable characters. </param>
        /// <param name="regulationSid"> The unique string of a [Regulation resource](https://www.twilio.com/docs/phone-numbers/regulatory/api/regulations) that is associated to the Bundle resource. </param>
        /// <param name="isoCountry"> The 2-digit [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) of the Bundle's phone number country ownership request. </param>
        /// <param name="numberType"> The type of phone number of the Bundle's ownership request. Can be `local`, `mobile`, `national`, or `tollfree`. </param>
        /// <param name="hasValidUntilDate"> Indicates that the Bundle is a valid Bundle until a specified expiration date. </param>
        /// <param name="sortBy"> Can be `valid-until` or `date-updated`. Defaults to `date-created`. </param>
        /// <param name="sortDirection"> Default is `DESC`. Can be `ASC` or `DESC`. </param>
        /// <param name="validUntilDateBefore"> Date to filter Bundles having their `valid_until_date` before or after the specified date. Can be `ValidUntilDate>=` or `ValidUntilDate<=`. Both can be used in conjunction as well. [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) is the acceptable date format. </param>
        /// <param name="validUntilDate"> Date to filter Bundles having their `valid_until_date` before or after the specified date. Can be `ValidUntilDate>=` or `ValidUntilDate<=`. Both can be used in conjunction as well. [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) is the acceptable date format. </param>
        /// <param name="validUntilDateAfter"> Date to filter Bundles having their `valid_until_date` before or after the specified date. Can be `ValidUntilDate>=` or `ValidUntilDate<=`. Both can be used in conjunction as well. [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) is the acceptable date format. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Bundle </returns>
        public static ResourceSet<BundleResource> Read(
                                                     BundleResource.StatusEnum status = null,
                                                     string friendlyName = null,
                                                     string regulationSid = null,
                                                     string isoCountry = null,
                                                     string numberType = null,
                                                     bool? hasValidUntilDate = null,
                                                     BundleResource.SortByEnum sortBy = null,
                                                     BundleResource.SortDirectionEnum sortDirection = null,
                                                     DateTime? validUntilDateBefore = null,
                                                     DateTime? validUntilDate = null,
                                                     DateTime? validUntilDateAfter = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadBundleOptions(){ Status = status, FriendlyName = friendlyName, RegulationSid = regulationSid, IsoCountry = isoCountry, NumberType = numberType, HasValidUntilDate = hasValidUntilDate, SortBy = sortBy, SortDirection = sortDirection, ValidUntilDateBefore = validUntilDateBefore, ValidUntilDate = validUntilDate, ValidUntilDateAfter = validUntilDateAfter, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Bundles for an account. </summary>
        /// <param name="status"> The verification status of the Bundle resource. Please refer to [Bundle Statuses](https://www.twilio.com/docs/phone-numbers/regulatory/api/bundles#bundle-statuses) for more details. </param>
        /// <param name="friendlyName"> The string that you assigned to describe the resource. The column can contain 255 variable characters. </param>
        /// <param name="regulationSid"> The unique string of a [Regulation resource](https://www.twilio.com/docs/phone-numbers/regulatory/api/regulations) that is associated to the Bundle resource. </param>
        /// <param name="isoCountry"> The 2-digit [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) of the Bundle's phone number country ownership request. </param>
        /// <param name="numberType"> The type of phone number of the Bundle's ownership request. Can be `local`, `mobile`, `national`, or `tollfree`. </param>
        /// <param name="hasValidUntilDate"> Indicates that the Bundle is a valid Bundle until a specified expiration date. </param>
        /// <param name="sortBy"> Can be `valid-until` or `date-updated`. Defaults to `date-created`. </param>
        /// <param name="sortDirection"> Default is `DESC`. Can be `ASC` or `DESC`. </param>
        /// <param name="validUntilDateBefore"> Date to filter Bundles having their `valid_until_date` before or after the specified date. Can be `ValidUntilDate>=` or `ValidUntilDate<=`. Both can be used in conjunction as well. [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) is the acceptable date format. </param>
        /// <param name="validUntilDate"> Date to filter Bundles having their `valid_until_date` before or after the specified date. Can be `ValidUntilDate>=` or `ValidUntilDate<=`. Both can be used in conjunction as well. [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) is the acceptable date format. </param>
        /// <param name="validUntilDateAfter"> Date to filter Bundles having their `valid_until_date` before or after the specified date. Can be `ValidUntilDate>=` or `ValidUntilDate<=`. Both can be used in conjunction as well. [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) is the acceptable date format. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Bundle </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<BundleResource>> ReadAsync(
                                                                                             BundleResource.StatusEnum status = null,
                                                                                             string friendlyName = null,
                                                                                             string regulationSid = null,
                                                                                             string isoCountry = null,
                                                                                             string numberType = null,
                                                                                             bool? hasValidUntilDate = null,
                                                                                             BundleResource.SortByEnum sortBy = null,
                                                                                             BundleResource.SortDirectionEnum sortDirection = null,
                                                                                             DateTime? validUntilDateBefore = null,
                                                                                             DateTime? validUntilDate = null,
                                                                                             DateTime? validUntilDateAfter = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadBundleOptions(){ Status = status, FriendlyName = friendlyName, RegulationSid = regulationSid, IsoCountry = isoCountry, NumberType = numberType, HasValidUntilDate = hasValidUntilDate, SortBy = sortBy, SortDirection = sortDirection, ValidUntilDateBefore = validUntilDateBefore, ValidUntilDate = validUntilDate, ValidUntilDateAfter = validUntilDateAfter, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<BundleResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<BundleResource>.FromJson("results", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<BundleResource> NextPage(Page<BundleResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<BundleResource>.FromJson("results", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<BundleResource> PreviousPage(Page<BundleResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<BundleResource>.FromJson("results", response.Content);
        }

        
        private static Request BuildUpdateRequest(UpdateBundleOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/RegulatoryCompliance/Bundles/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Numbers,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Updates a Bundle in an account. </summary>
        /// <param name="options"> Update Bundle parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Bundle </returns>
        public static BundleResource Update(UpdateBundleOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Updates a Bundle in an account. </summary>
        /// <param name="options"> Update Bundle parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Bundle </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<BundleResource> UpdateAsync(UpdateBundleOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Updates a Bundle in an account. </summary>
        /// <param name="pathSid"> The unique string that we created to identify the Bundle resource. </param>
        /// <param name="status">  </param>
        /// <param name="statusCallback"> The URL we call to inform your application of status changes. </param>
        /// <param name="friendlyName"> The string that you assigned to describe the resource. </param>
        /// <param name="email"> The email address that will receive updates when the Bundle resource changes status. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Bundle </returns>
        public static BundleResource Update(
                                          string pathSid,
                                          BundleResource.StatusEnum status = null,
                                          Uri statusCallback = null,
                                          string friendlyName = null,
                                          string email = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateBundleOptions(pathSid){ Status = status, StatusCallback = statusCallback, FriendlyName = friendlyName, Email = email };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> Updates a Bundle in an account. </summary>
        /// <param name="pathSid"> The unique string that we created to identify the Bundle resource. </param>
        /// <param name="status">  </param>
        /// <param name="statusCallback"> The URL we call to inform your application of status changes. </param>
        /// <param name="friendlyName"> The string that you assigned to describe the resource. </param>
        /// <param name="email"> The email address that will receive updates when the Bundle resource changes status. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Bundle </returns>
        public static async System.Threading.Tasks.Task<BundleResource> UpdateAsync(
                                                                              string pathSid,
                                                                              BundleResource.StatusEnum status = null,
                                                                              Uri statusCallback = null,
                                                                              string friendlyName = null,
                                                                              string email = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateBundleOptions(pathSid){ Status = status, StatusCallback = statusCallback, FriendlyName = friendlyName, Email = email };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a BundleResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> BundleResource object represented by the provided JSON </returns>
        public static BundleResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<BundleResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The unique string that we created to identify the Bundle resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Bundle resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The unique string of a regulation that is associated to the Bundle resource. </summary> 
        [JsonProperty("regulation_sid")]
        public string RegulationSid { get; private set; }

        ///<summary> The string that you assigned to describe the resource. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        
        [JsonProperty("status")]
        public BundleResource.StatusEnum Status { get; private set; }

        ///<summary> The date and time in GMT in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format when the resource will be valid until. </summary> 
        [JsonProperty("valid_until")]
        public DateTime? ValidUntil { get; private set; }

        ///<summary> The email address that will receive updates when the Bundle resource changes status. </summary> 
        [JsonProperty("email")]
        public string Email { get; private set; }

        ///<summary> The URL we call to inform your application of status changes. </summary> 
        [JsonProperty("status_callback")]
        public Uri StatusCallback { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the resource was last updated specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The absolute URL of the Bundle resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The URLs of the Assigned Items of the Bundle resource. </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private BundleResource() {

        }
    }
}


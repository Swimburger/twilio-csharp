/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Insights
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


namespace Twilio.Rest.Insights.V1.Conference
{
    public class ConferenceParticipantResource : Resource
    {
    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class CallStatusEnum : StringEnum
        {
            private CallStatusEnum(string value) : base(value) {}
            public CallStatusEnum() {}
            public static implicit operator CallStatusEnum(string value)
            {
                return new CallStatusEnum(value);
            }
            public static readonly CallStatusEnum Answered = new CallStatusEnum("answered");
            public static readonly CallStatusEnum Completed = new CallStatusEnum("completed");
            public static readonly CallStatusEnum Busy = new CallStatusEnum("busy");
            public static readonly CallStatusEnum Fail = new CallStatusEnum("fail");
            public static readonly CallStatusEnum Noanswer = new CallStatusEnum("noanswer");
            public static readonly CallStatusEnum Ringing = new CallStatusEnum("ringing");
            public static readonly CallStatusEnum Canceled = new CallStatusEnum("canceled");

        }
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class RegionEnum : StringEnum
        {
            private RegionEnum(string value) : base(value) {}
            public RegionEnum() {}
            public static implicit operator RegionEnum(string value)
            {
                return new RegionEnum(value);
            }
            public static readonly RegionEnum Us1 = new RegionEnum("us1");
            public static readonly RegionEnum Us2 = new RegionEnum("us2");
            public static readonly RegionEnum Au1 = new RegionEnum("au1");
            public static readonly RegionEnum Br1 = new RegionEnum("br1");
            public static readonly RegionEnum Ie1 = new RegionEnum("ie1");
            public static readonly RegionEnum Jp1 = new RegionEnum("jp1");
            public static readonly RegionEnum Sg1 = new RegionEnum("sg1");
            public static readonly RegionEnum De1 = new RegionEnum("de1");

        }
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class JitterBufferSizeEnum : StringEnum
        {
            private JitterBufferSizeEnum(string value) : base(value) {}
            public JitterBufferSizeEnum() {}
            public static implicit operator JitterBufferSizeEnum(string value)
            {
                return new JitterBufferSizeEnum(value);
            }
            public static readonly JitterBufferSizeEnum Large = new JitterBufferSizeEnum("large");
            public static readonly JitterBufferSizeEnum Small = new JitterBufferSizeEnum("small");
            public static readonly JitterBufferSizeEnum Medium = new JitterBufferSizeEnum("medium");
            public static readonly JitterBufferSizeEnum Off = new JitterBufferSizeEnum("off");

        }
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class ProcessingStateEnum : StringEnum
        {
            private ProcessingStateEnum(string value) : base(value) {}
            public ProcessingStateEnum() {}
            public static implicit operator ProcessingStateEnum(string value)
            {
                return new ProcessingStateEnum(value);
            }
            public static readonly ProcessingStateEnum Complete = new ProcessingStateEnum("complete");
            public static readonly ProcessingStateEnum InProgress = new ProcessingStateEnum("in_progress");
            public static readonly ProcessingStateEnum Timeout = new ProcessingStateEnum("timeout");

        }
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class CallDirectionEnum : StringEnum
        {
            private CallDirectionEnum(string value) : base(value) {}
            public CallDirectionEnum() {}
            public static implicit operator CallDirectionEnum(string value)
            {
                return new CallDirectionEnum(value);
            }
            public static readonly CallDirectionEnum Inbound = new CallDirectionEnum("inbound");
            public static readonly CallDirectionEnum Outbound = new CallDirectionEnum("outbound");

        }
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class CallTypeEnum : StringEnum
        {
            private CallTypeEnum(string value) : base(value) {}
            public CallTypeEnum() {}
            public static implicit operator CallTypeEnum(string value)
            {
                return new CallTypeEnum(value);
            }
            public static readonly CallTypeEnum Carrier = new CallTypeEnum("carrier");
            public static readonly CallTypeEnum Client = new CallTypeEnum("client");
            public static readonly CallTypeEnum Sip = new CallTypeEnum("sip");

        }

        
        private static Request BuildFetchRequest(FetchConferenceParticipantOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Conferences/{ConferenceSid}/Participants/{ParticipantSid}";

            string PathConferenceSid = options.PathConferenceSid;
            path = path.Replace("{"+"ConferenceSid"+"}", PathConferenceSid);
            string PathParticipantSid = options.PathParticipantSid;
            path = path.Replace("{"+"ParticipantSid"+"}", PathParticipantSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Insights,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch a specific Conference Participant Summary. </summary>
        /// <param name="options"> Fetch ConferenceParticipant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ConferenceParticipant </returns>
        public static ConferenceParticipantResource Fetch(FetchConferenceParticipantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch a specific Conference Participant Summary. </summary>
        /// <param name="options"> Fetch ConferenceParticipant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ConferenceParticipant </returns>
        public static async System.Threading.Tasks.Task<ConferenceParticipantResource> FetchAsync(FetchConferenceParticipantOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch a specific Conference Participant Summary. </summary>
        /// <param name="pathConferenceSid"> The unique SID identifier of the Conference. </param>
        /// <param name="pathParticipantSid"> The unique SID identifier of the Participant. </param>
        /// <param name="events"> Conference events generated by application or participant activity; e.g. `hold`, `mute`, etc. </param>
        /// <param name="metrics"> Object. Contains participant call quality metrics. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ConferenceParticipant </returns>
        public static ConferenceParticipantResource Fetch(
                                         string pathConferenceSid, 
                                         string pathParticipantSid, 
                                         string events = null, 
                                         string metrics = null, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchConferenceParticipantOptions(pathConferenceSid, pathParticipantSid){ Events = events,Metrics = metrics };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch a specific Conference Participant Summary. </summary>
        /// <param name="pathConferenceSid"> The unique SID identifier of the Conference. </param>
        /// <param name="pathParticipantSid"> The unique SID identifier of the Participant. </param>
        /// <param name="events"> Conference events generated by application or participant activity; e.g. `hold`, `mute`, etc. </param>
        /// <param name="metrics"> Object. Contains participant call quality metrics. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ConferenceParticipant </returns>
        public static async System.Threading.Tasks.Task<ConferenceParticipantResource> FetchAsync(string pathConferenceSid, string pathParticipantSid, string events = null, string metrics = null, ITwilioRestClient client = null)
        {
            var options = new FetchConferenceParticipantOptions(pathConferenceSid, pathParticipantSid){ Events = events,Metrics = metrics };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadConferenceParticipantOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Conferences/{ConferenceSid}/Participants";

            string PathConferenceSid = options.PathConferenceSid;
            path = path.Replace("{"+"ConferenceSid"+"}", PathConferenceSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Insights,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> List Conference Participants. </summary>
        /// <param name="options"> Read ConferenceParticipant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ConferenceParticipant </returns>
        public static ResourceSet<ConferenceParticipantResource> Read(ReadConferenceParticipantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<ConferenceParticipantResource>.FromJson("participants", response.Content);
            return new ResourceSet<ConferenceParticipantResource>(page, options, client);
        }

        #if !NET35
        /// <summary> List Conference Participants. </summary>
        /// <param name="options"> Read ConferenceParticipant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ConferenceParticipant </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ConferenceParticipantResource>> ReadAsync(ReadConferenceParticipantOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<ConferenceParticipantResource>.FromJson("participants", response.Content);
            return new ResourceSet<ConferenceParticipantResource>(page, options, client);
        }
        #endif
        /// <summary> List Conference Participants. </summary>
        /// <param name="pathConferenceSid"> The unique SID identifier of the Conference. </param>
        /// <param name="participantSid"> The unique SID identifier of the Participant. </param>
        /// <param name="label"> User-specified label for a participant. </param>
        /// <param name="events"> Conference events generated by application or participant activity; e.g. `hold`, `mute`, etc. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ConferenceParticipant </returns>
        public static ResourceSet<ConferenceParticipantResource> Read(
                                                     string pathConferenceSid,
                                                     string participantSid = null,
                                                     string label = null,
                                                     string events = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadConferenceParticipantOptions(pathConferenceSid){ ParticipantSid = participantSid, Label = label, Events = events, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> List Conference Participants. </summary>
        /// <param name="pathConferenceSid"> The unique SID identifier of the Conference. </param>
        /// <param name="participantSid"> The unique SID identifier of the Participant. </param>
        /// <param name="label"> User-specified label for a participant. </param>
        /// <param name="events"> Conference events generated by application or participant activity; e.g. `hold`, `mute`, etc. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ConferenceParticipant </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ConferenceParticipantResource>> ReadAsync(
                                                                                             string pathConferenceSid,
                                                                                             string participantSid = null,
                                                                                             string label = null,
                                                                                             string events = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadConferenceParticipantOptions(pathConferenceSid){ ParticipantSid = participantSid, Label = label, Events = events, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<ConferenceParticipantResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<ConferenceParticipantResource>.FromJson("participants", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<ConferenceParticipantResource> NextPage(Page<ConferenceParticipantResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<ConferenceParticipantResource>.FromJson("participants", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<ConferenceParticipantResource> PreviousPage(Page<ConferenceParticipantResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<ConferenceParticipantResource>.FromJson("participants", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a ConferenceParticipantResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ConferenceParticipantResource object represented by the provided JSON </returns>
        public static ConferenceParticipantResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<ConferenceParticipantResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> SID for this participant. </summary> 
        [JsonProperty("participant_sid")]
        public string ParticipantSid { get; private set; }

        ///<summary> The user-specified label of this participant. </summary> 
        [JsonProperty("label")]
        public string Label { get; private set; }

        ///<summary> The unique SID identifier of the Conference. </summary> 
        [JsonProperty("conference_sid")]
        public string ConferenceSid { get; private set; }

        ///<summary> Unique SID identifier of the call that generated the Participant resource. </summary> 
        [JsonProperty("call_sid")]
        public string CallSid { get; private set; }

        ///<summary> The unique SID identifier of the Account. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        
        [JsonProperty("call_direction")]
        public ConferenceParticipantResource.CallDirectionEnum CallDirection { get; private set; }

        ///<summary> Caller ID of the calling party. </summary> 
        [JsonProperty("from")]
        public string From { get; private set; }

        ///<summary> Called party. </summary> 
        [JsonProperty("to")]
        public string To { get; private set; }

        
        [JsonProperty("call_status")]
        public ConferenceParticipantResource.CallStatusEnum CallStatus { get; private set; }

        ///<summary> ISO alpha-2 country code of the participant based on caller ID or called number. </summary> 
        [JsonProperty("country_code")]
        public string CountryCode { get; private set; }

        ///<summary> Boolean. Indicates whether participant had startConferenceOnEnter=true or endConferenceOnExit=true. </summary> 
        [JsonProperty("is_moderator")]
        public bool? IsModerator { get; private set; }

        ///<summary> ISO 8601 timestamp of participant join event. </summary> 
        [JsonProperty("join_time")]
        public DateTime? JoinTime { get; private set; }

        ///<summary> ISO 8601 timestamp of participant leave event. </summary> 
        [JsonProperty("leave_time")]
        public DateTime? LeaveTime { get; private set; }

        ///<summary> Participant durations in seconds. </summary> 
        [JsonProperty("duration_seconds")]
        public int? DurationSeconds { get; private set; }

        ///<summary> Add Participant API only. Estimated time in queue at call creation. </summary> 
        [JsonProperty("outbound_queue_length")]
        public int? OutboundQueueLength { get; private set; }

        ///<summary> Add Participant API only. Actual time in queue in seconds. </summary> 
        [JsonProperty("outbound_time_in_queue")]
        public int? OutboundTimeInQueue { get; private set; }

        
        [JsonProperty("jitter_buffer_size")]
        public ConferenceParticipantResource.JitterBufferSizeEnum JitterBufferSize { get; private set; }

        ///<summary> Boolean. Indicated whether participant was a coach. </summary> 
        [JsonProperty("is_coach")]
        public bool? IsCoach { get; private set; }

        ///<summary> Call SIDs coached by this participant. </summary> 
        [JsonProperty("coached_participants")]
        public List<string> CoachedParticipants { get; private set; }

        
        [JsonProperty("participant_region")]
        public ConferenceParticipantResource.RegionEnum ParticipantRegion { get; private set; }

        
        [JsonProperty("conference_region")]
        public ConferenceParticipantResource.RegionEnum ConferenceRegion { get; private set; }

        
        [JsonProperty("call_type")]
        public ConferenceParticipantResource.CallTypeEnum CallType { get; private set; }

        
        [JsonProperty("processing_state")]
        public ConferenceParticipantResource.ProcessingStateEnum ProcessingState { get; private set; }

        ///<summary> Participant properties and metadata. </summary> 
        [JsonProperty("properties")]
        public object Properties { get; private set; }

        ///<summary> Object containing information of actions taken by participants. Contains a dictionary of URL links to nested resources of this Conference Participant. </summary> 
        [JsonProperty("events")]
        public object Events { get; private set; }

        ///<summary> Object. Contains participant call quality metrics. </summary> 
        [JsonProperty("metrics")]
        public object Metrics { get; private set; }

        ///<summary> The URL of this resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private ConferenceParticipantResource() {

        }
    }
}


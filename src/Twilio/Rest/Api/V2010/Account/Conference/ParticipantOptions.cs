/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;
using Twilio.Types;

namespace Twilio.Rest.Api.V2010.Account.Conference
{

    /// <summary>
    /// Fetch an instance of a participant
    /// </summary>
    public class FetchParticipantOptions : IOptions<ParticipantResource>
    {
        /// <summary>
        /// The SID of the Account that created the resource to fetch
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The SID of the conference with the participant to fetch
        /// </summary>
        public string PathConferenceSid { get; }
        /// <summary>
        /// The Call SID or URL encoded label of the participant to fetch
        /// </summary>
        public string PathCallSid { get; }

        /// <summary>
        /// Construct a new FetchParticipantOptions
        /// </summary>
        /// <param name="pathConferenceSid"> The SID of the conference with the participant to fetch </param>
        /// <param name="pathCallSid"> The Call SID or URL encoded label of the participant to fetch </param>
        public FetchParticipantOptions(string pathConferenceSid, string pathCallSid)
        {
            PathConferenceSid = pathConferenceSid;
            PathCallSid = pathCallSid;
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
    /// Update the properties of the participant
    /// </summary>
    public class UpdateParticipantOptions : IOptions<ParticipantResource>
    {
        /// <summary>
        /// The SID of the Account that created the resources to update
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The SID of the conference with the participant to update
        /// </summary>
        public string PathConferenceSid { get; }
        /// <summary>
        /// The Call SID or URL encoded label of the participant to update
        /// </summary>
        public string PathCallSid { get; }
        /// <summary>
        /// Whether the participant should be muted
        /// </summary>
        public bool? Muted { get; set; }
        /// <summary>
        /// Whether the participant should be on hold
        /// </summary>
        public bool? Hold { get; set; }
        /// <summary>
        /// The URL we call using the `hold_method` for  music that plays when the participant is on hold
        /// </summary>
        public Uri HoldUrl { get; set; }
        /// <summary>
        /// The HTTP method we should use to call hold_url
        /// </summary>
        public Twilio.Http.HttpMethod HoldMethod { get; set; }
        /// <summary>
        /// The URL we call using the `announce_method` for an announcement to the participant
        /// </summary>
        public Uri AnnounceUrl { get; set; }
        /// <summary>
        /// The HTTP method we should use to call announce_url
        /// </summary>
        public Twilio.Http.HttpMethod AnnounceMethod { get; set; }
        /// <summary>
        /// URL that hosts pre-conference hold music
        /// </summary>
        public Uri WaitUrl { get; set; }
        /// <summary>
        /// The HTTP method we should use to call `wait_url`
        /// </summary>
        public Twilio.Http.HttpMethod WaitMethod { get; set; }
        /// <summary>
        /// Whether to play a notification beep to the conference when the participant exit
        /// </summary>
        public bool? BeepOnExit { get; set; }
        /// <summary>
        /// Whether to end the conference when the participant leaves
        /// </summary>
        public bool? EndConferenceOnExit { get; set; }
        /// <summary>
        /// Indicates if the participant changed to coach
        /// </summary>
        public bool? Coaching { get; set; }
        /// <summary>
        /// The SID of the participant who is being `coached`
        /// </summary>
        public string CallSidToCoach { get; set; }

        /// <summary>
        /// Construct a new UpdateParticipantOptions
        /// </summary>
        /// <param name="pathConferenceSid"> The SID of the conference with the participant to update </param>
        /// <param name="pathCallSid"> The Call SID or URL encoded label of the participant to update </param>
        public UpdateParticipantOptions(string pathConferenceSid, string pathCallSid)
        {
            PathConferenceSid = pathConferenceSid;
            PathCallSid = pathCallSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Muted != null)
            {
                p.Add(new KeyValuePair<string, string>("Muted", Muted.Value.ToString().ToLower()));
            }

            if (Hold != null)
            {
                p.Add(new KeyValuePair<string, string>("Hold", Hold.Value.ToString().ToLower()));
            }

            if (HoldUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("HoldUrl", Serializers.Url(HoldUrl)));
            }

            if (HoldMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("HoldMethod", HoldMethod.ToString()));
            }

            if (AnnounceUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("AnnounceUrl", Serializers.Url(AnnounceUrl)));
            }

            if (AnnounceMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("AnnounceMethod", AnnounceMethod.ToString()));
            }

            if (WaitUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("WaitUrl", Serializers.Url(WaitUrl)));
            }

            if (WaitMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("WaitMethod", WaitMethod.ToString()));
            }

            if (BeepOnExit != null)
            {
                p.Add(new KeyValuePair<string, string>("BeepOnExit", BeepOnExit.Value.ToString().ToLower()));
            }

            if (EndConferenceOnExit != null)
            {
                p.Add(new KeyValuePair<string, string>("EndConferenceOnExit", EndConferenceOnExit.Value.ToString().ToLower()));
            }

            if (Coaching != null)
            {
                p.Add(new KeyValuePair<string, string>("Coaching", Coaching.Value.ToString().ToLower()));
            }

            if (CallSidToCoach != null)
            {
                p.Add(new KeyValuePair<string, string>("CallSidToCoach", CallSidToCoach.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// CreateParticipantOptions
    /// </summary>
    public class CreateParticipantOptions : IOptions<ParticipantResource>
    {
        /// <summary>
        /// The SID of the Account that will create the resource
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The SID of the participant's conference
        /// </summary>
        public string PathConferenceSid { get; }
        /// <summary>
        /// The phone number, Client identifier, or username portion of SIP address that made this call.
        /// </summary>
        public IEndpoint From { get; }
        /// <summary>
        /// The phone number, SIP address or Client identifier that received this call.
        /// </summary>
        public IEndpoint To { get; }
        /// <summary>
        /// The URL we should call to send status information to your application
        /// </summary>
        public Uri StatusCallback { get; set; }
        /// <summary>
        /// The HTTP method we should use to call `status_callback`
        /// </summary>
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; set; }
        /// <summary>
        /// Set state change events that will trigger a callback
        /// </summary>
        public List<string> StatusCallbackEvent { get; set; }
        /// <summary>
        /// The label of this participant
        /// </summary>
        public string Label { get; set; }
        /// <summary>
        /// he number of seconds that we should wait for an answer
        /// </summary>
        public int? Timeout { get; set; }
        /// <summary>
        /// Whether to record the participant and their conferences
        /// </summary>
        public bool? Record { get; set; }
        /// <summary>
        /// Whether to mute the agent
        /// </summary>
        public bool? Muted { get; set; }
        /// <summary>
        /// Whether to play a notification beep to the conference when the participant joins
        /// </summary>
        public string Beep { get; set; }
        /// <summary>
        /// Whether the conference starts when the participant joins the conference
        /// </summary>
        public bool? StartConferenceOnEnter { get; set; }
        /// <summary>
        /// Whether to end the conference when the participant leaves
        /// </summary>
        public bool? EndConferenceOnExit { get; set; }
        /// <summary>
        /// URL that hosts pre-conference hold music
        /// </summary>
        public Uri WaitUrl { get; set; }
        /// <summary>
        /// The HTTP method we should use to call `wait_url`
        /// </summary>
        public Twilio.Http.HttpMethod WaitMethod { get; set; }
        /// <summary>
        /// Whether agents can hear the state of the outbound call
        /// </summary>
        public bool? EarlyMedia { get; set; }
        /// <summary>
        /// The maximum number of agent conference participants
        /// </summary>
        public int? MaxParticipants { get; set; }
        /// <summary>
        /// Whether to record the conference the participant is joining
        /// </summary>
        public string ConferenceRecord { get; set; }
        /// <summary>
        /// Whether to trim leading and trailing silence from your recorded conference audio files
        /// </summary>
        public string ConferenceTrim { get; set; }
        /// <summary>
        /// The callback URL for conference events
        /// </summary>
        public Uri ConferenceStatusCallback { get; set; }
        /// <summary>
        /// HTTP method for requesting `conference_status_callback` URL
        /// </summary>
        public Twilio.Http.HttpMethod ConferenceStatusCallbackMethod { get; set; }
        /// <summary>
        /// The conference state changes that should generate a call to `conference_status_callback`
        /// </summary>
        public List<string> ConferenceStatusCallbackEvent { get; set; }
        /// <summary>
        /// Specify `mono` or `dual` recording channels
        /// </summary>
        public string RecordingChannels { get; set; }
        /// <summary>
        /// The URL that we should call using the `recording_status_callback_method` when the recording status changes
        /// </summary>
        public Uri RecordingStatusCallback { get; set; }
        /// <summary>
        /// The HTTP method we should use when we call `recording_status_callback`
        /// </summary>
        public Twilio.Http.HttpMethod RecordingStatusCallbackMethod { get; set; }
        /// <summary>
        /// The SIP username used for authentication
        /// </summary>
        public string SipAuthUsername { get; set; }
        /// <summary>
        /// The SIP password for authentication
        /// </summary>
        public string SipAuthPassword { get; set; }
        /// <summary>
        /// The region where we should mix the conference audio
        /// </summary>
        public string Region { get; set; }
        /// <summary>
        /// The URL we should call using the `conference_recording_status_callback_method` when the conference recording is available
        /// </summary>
        public Uri ConferenceRecordingStatusCallback { get; set; }
        /// <summary>
        /// The HTTP method we should use to call `conference_recording_status_callback`
        /// </summary>
        public Twilio.Http.HttpMethod ConferenceRecordingStatusCallbackMethod { get; set; }
        /// <summary>
        /// The recording state changes that should generate a call to `recording_status_callback`
        /// </summary>
        public List<string> RecordingStatusCallbackEvent { get; set; }
        /// <summary>
        /// The conference recording state changes that should generate a call to `conference_recording_status_callback`
        /// </summary>
        public List<string> ConferenceRecordingStatusCallbackEvent { get; set; }
        /// <summary>
        /// Indicates if the participant changed to coach
        /// </summary>
        public bool? Coaching { get; set; }
        /// <summary>
        /// The SID of the participant who is being `coached`
        /// </summary>
        public string CallSidToCoach { get; set; }
        /// <summary>
        /// Jitter Buffer size for the connecting participant
        /// </summary>
        public string JitterBufferSize { get; set; }
        /// <summary>
        /// BYOC trunk SID (Beta)
        /// </summary>
        public string Byoc { get; set; }
        /// <summary>
        /// The phone number, Client identifier, or username portion of SIP address that made this call.
        /// </summary>
        public string CallerId { get; set; }
        /// <summary>
        /// Reason for the call (Branded Calls Beta)
        /// </summary>
        public string CallReason { get; set; }
        /// <summary>
        /// The track(s) to record
        /// </summary>
        public string RecordingTrack { get; set; }
        /// <summary>
        /// The maximum duration of the call in seconds.
        /// </summary>
        public int? TimeLimit { get; set; }
        /// <summary>
        /// Enable machine detection or end of greeting detection
        /// </summary>
        public string MachineDetection { get; set; }
        /// <summary>
        /// Number of seconds to wait for machine detection
        /// </summary>
        public int? MachineDetectionTimeout { get; set; }
        /// <summary>
        /// Number of milliseconds for measuring stick for the length of the speech activity
        /// </summary>
        public int? MachineDetectionSpeechThreshold { get; set; }
        /// <summary>
        /// Number of milliseconds of silence after speech activity
        /// </summary>
        public int? MachineDetectionSpeechEndThreshold { get; set; }
        /// <summary>
        /// Number of milliseconds of initial silence
        /// </summary>
        public int? MachineDetectionSilenceTimeout { get; set; }
        /// <summary>
        /// The URL we should call to send amd status information to your application
        /// </summary>
        public Uri AmdStatusCallback { get; set; }
        /// <summary>
        /// HTTP Method to use with amd_status_callback
        /// </summary>
        public Twilio.Http.HttpMethod AmdStatusCallbackMethod { get; set; }

        /// <summary>
        /// Construct a new CreateParticipantOptions
        /// </summary>
        /// <param name="pathConferenceSid"> The SID of the participant's conference </param>
        /// <param name="from"> The phone number, Client identifier, or username portion of SIP address that made this call.
        ///            </param>
        /// <param name="to"> The phone number, SIP address or Client identifier that received this call. </param>
        public CreateParticipantOptions(string pathConferenceSid, IEndpoint from, IEndpoint to)
        {
            PathConferenceSid = pathConferenceSid;
            From = from;
            To = to;
            StatusCallbackEvent = new List<string>();
            ConferenceStatusCallbackEvent = new List<string>();
            RecordingStatusCallbackEvent = new List<string>();
            ConferenceRecordingStatusCallbackEvent = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (From != null)
            {
                p.Add(new KeyValuePair<string, string>("From", From.ToString()));
            }

            if (To != null)
            {
                p.Add(new KeyValuePair<string, string>("To", To.ToString()));
            }

            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", Serializers.Url(StatusCallback)));
            }

            if (StatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallbackMethod", StatusCallbackMethod.ToString()));
            }

            if (StatusCallbackEvent != null)
            {
                p.AddRange(StatusCallbackEvent.Select(prop => new KeyValuePair<string, string>("StatusCallbackEvent", prop)));
            }

            if (Label != null)
            {
                p.Add(new KeyValuePair<string, string>("Label", Label));
            }

            if (Timeout != null)
            {
                p.Add(new KeyValuePair<string, string>("Timeout", Timeout.ToString()));
            }

            if (Record != null)
            {
                p.Add(new KeyValuePair<string, string>("Record", Record.Value.ToString().ToLower()));
            }

            if (Muted != null)
            {
                p.Add(new KeyValuePair<string, string>("Muted", Muted.Value.ToString().ToLower()));
            }

            if (Beep != null)
            {
                p.Add(new KeyValuePair<string, string>("Beep", Beep));
            }

            if (StartConferenceOnEnter != null)
            {
                p.Add(new KeyValuePair<string, string>("StartConferenceOnEnter", StartConferenceOnEnter.Value.ToString().ToLower()));
            }

            if (EndConferenceOnExit != null)
            {
                p.Add(new KeyValuePair<string, string>("EndConferenceOnExit", EndConferenceOnExit.Value.ToString().ToLower()));
            }

            if (WaitUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("WaitUrl", Serializers.Url(WaitUrl)));
            }

            if (WaitMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("WaitMethod", WaitMethod.ToString()));
            }

            if (EarlyMedia != null)
            {
                p.Add(new KeyValuePair<string, string>("EarlyMedia", EarlyMedia.Value.ToString().ToLower()));
            }

            if (MaxParticipants != null)
            {
                p.Add(new KeyValuePair<string, string>("MaxParticipants", MaxParticipants.ToString()));
            }

            if (ConferenceRecord != null)
            {
                p.Add(new KeyValuePair<string, string>("ConferenceRecord", ConferenceRecord));
            }

            if (ConferenceTrim != null)
            {
                p.Add(new KeyValuePair<string, string>("ConferenceTrim", ConferenceTrim));
            }

            if (ConferenceStatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("ConferenceStatusCallback", Serializers.Url(ConferenceStatusCallback)));
            }

            if (ConferenceStatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("ConferenceStatusCallbackMethod", ConferenceStatusCallbackMethod.ToString()));
            }

            if (ConferenceStatusCallbackEvent != null)
            {
                p.AddRange(ConferenceStatusCallbackEvent.Select(prop => new KeyValuePair<string, string>("ConferenceStatusCallbackEvent", prop)));
            }

            if (RecordingChannels != null)
            {
                p.Add(new KeyValuePair<string, string>("RecordingChannels", RecordingChannels));
            }

            if (RecordingStatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("RecordingStatusCallback", Serializers.Url(RecordingStatusCallback)));
            }

            if (RecordingStatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("RecordingStatusCallbackMethod", RecordingStatusCallbackMethod.ToString()));
            }

            if (SipAuthUsername != null)
            {
                p.Add(new KeyValuePair<string, string>("SipAuthUsername", SipAuthUsername));
            }

            if (SipAuthPassword != null)
            {
                p.Add(new KeyValuePair<string, string>("SipAuthPassword", SipAuthPassword));
            }

            if (Region != null)
            {
                p.Add(new KeyValuePair<string, string>("Region", Region));
            }

            if (ConferenceRecordingStatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("ConferenceRecordingStatusCallback", Serializers.Url(ConferenceRecordingStatusCallback)));
            }

            if (ConferenceRecordingStatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("ConferenceRecordingStatusCallbackMethod", ConferenceRecordingStatusCallbackMethod.ToString()));
            }

            if (RecordingStatusCallbackEvent != null)
            {
                p.AddRange(RecordingStatusCallbackEvent.Select(prop => new KeyValuePair<string, string>("RecordingStatusCallbackEvent", prop)));
            }

            if (ConferenceRecordingStatusCallbackEvent != null)
            {
                p.AddRange(ConferenceRecordingStatusCallbackEvent.Select(prop => new KeyValuePair<string, string>("ConferenceRecordingStatusCallbackEvent", prop)));
            }

            if (Coaching != null)
            {
                p.Add(new KeyValuePair<string, string>("Coaching", Coaching.Value.ToString().ToLower()));
            }

            if (CallSidToCoach != null)
            {
                p.Add(new KeyValuePair<string, string>("CallSidToCoach", CallSidToCoach.ToString()));
            }

            if (JitterBufferSize != null)
            {
                p.Add(new KeyValuePair<string, string>("JitterBufferSize", JitterBufferSize));
            }

            if (Byoc != null)
            {
                p.Add(new KeyValuePair<string, string>("Byoc", Byoc.ToString()));
            }

            if (CallerId != null)
            {
                p.Add(new KeyValuePair<string, string>("CallerId", CallerId));
            }

            if (CallReason != null)
            {
                p.Add(new KeyValuePair<string, string>("CallReason", CallReason));
            }

            if (RecordingTrack != null)
            {
                p.Add(new KeyValuePair<string, string>("RecordingTrack", RecordingTrack));
            }

            if (TimeLimit != null)
            {
                p.Add(new KeyValuePair<string, string>("TimeLimit", TimeLimit.ToString()));
            }

            if (MachineDetection != null)
            {
                p.Add(new KeyValuePair<string, string>("MachineDetection", MachineDetection));
            }

            if (MachineDetectionTimeout != null)
            {
                p.Add(new KeyValuePair<string, string>("MachineDetectionTimeout", MachineDetectionTimeout.ToString()));
            }

            if (MachineDetectionSpeechThreshold != null)
            {
                p.Add(new KeyValuePair<string, string>("MachineDetectionSpeechThreshold", MachineDetectionSpeechThreshold.ToString()));
            }

            if (MachineDetectionSpeechEndThreshold != null)
            {
                p.Add(new KeyValuePair<string, string>("MachineDetectionSpeechEndThreshold", MachineDetectionSpeechEndThreshold.ToString()));
            }

            if (MachineDetectionSilenceTimeout != null)
            {
                p.Add(new KeyValuePair<string, string>("MachineDetectionSilenceTimeout", MachineDetectionSilenceTimeout.ToString()));
            }

            if (AmdStatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("AmdStatusCallback", Serializers.Url(AmdStatusCallback)));
            }

            if (AmdStatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("AmdStatusCallbackMethod", AmdStatusCallbackMethod.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// Kick a participant from a given conference
    /// </summary>
    public class DeleteParticipantOptions : IOptions<ParticipantResource>
    {
        /// <summary>
        /// The SID of the Account that created the resources to delete
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The SID of the conference with the participants to delete
        /// </summary>
        public string PathConferenceSid { get; }
        /// <summary>
        /// The Call SID or URL encoded label of the participant to delete
        /// </summary>
        public string PathCallSid { get; }

        /// <summary>
        /// Construct a new DeleteParticipantOptions
        /// </summary>
        /// <param name="pathConferenceSid"> The SID of the conference with the participants to delete </param>
        /// <param name="pathCallSid"> The Call SID or URL encoded label of the participant to delete </param>
        public DeleteParticipantOptions(string pathConferenceSid, string pathCallSid)
        {
            PathConferenceSid = pathConferenceSid;
            PathCallSid = pathCallSid;
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
    /// Retrieve a list of participants belonging to the account used to make the request
    /// </summary>
    public class ReadParticipantOptions : ReadOptions<ParticipantResource>
    {
        /// <summary>
        /// The SID of the Account that created the resources to read
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The SID of the conference with the participants to read
        /// </summary>
        public string PathConferenceSid { get; }
        /// <summary>
        /// Whether to return only participants that are muted
        /// </summary>
        public bool? Muted { get; set; }
        /// <summary>
        /// Whether to return only participants that are on hold
        /// </summary>
        public bool? Hold { get; set; }
        /// <summary>
        /// Whether to return only participants who are coaching another call
        /// </summary>
        public bool? Coaching { get; set; }

        /// <summary>
        /// Construct a new ReadParticipantOptions
        /// </summary>
        /// <param name="pathConferenceSid"> The SID of the conference with the participants to read </param>
        public ReadParticipantOptions(string pathConferenceSid)
        {
            PathConferenceSid = pathConferenceSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Muted != null)
            {
                p.Add(new KeyValuePair<string, string>("Muted", Muted.Value.ToString().ToLower()));
            }

            if (Hold != null)
            {
                p.Add(new KeyValuePair<string, string>("Hold", Hold.Value.ToString().ToLower()));
            }

            if (Coaching != null)
            {
                p.Add(new KeyValuePair<string, string>("Coaching", Coaching.Value.ToString().ToLower()));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}
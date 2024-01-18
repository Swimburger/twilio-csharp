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


using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;




namespace Twilio.Rest.Api.V2010.Account.Conference
{
    /// <summary> Delete a recording from your account </summary>
    public class DeleteRecordingOptions : IOptions<RecordingResource>
    {
        
        ///<summary> The Conference SID that identifies the conference associated with the recording to delete. </summary> 
        public string PathConferenceSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the Conference Recording resource to delete. </summary> 
        public string PathSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Conference Recording resources to delete. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new DeleteConferenceRecordingOptions </summary>
        /// <param name="pathConferenceSid"> The Conference SID that identifies the conference associated with the recording to delete. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Conference Recording resource to delete. </param>
        public DeleteRecordingOptions(string pathConferenceSid, string pathSid)
        {
            PathConferenceSid = pathConferenceSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

        

    }


    /// <summary> Fetch an instance of a recording for a call </summary>
    public class FetchRecordingOptions : IOptions<RecordingResource>
    {
    
        ///<summary> The Conference SID that identifies the conference associated with the recording to fetch. </summary> 
        public string PathConferenceSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the Conference Recording resource to fetch. </summary> 
        public string PathSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Conference Recording resource to fetch. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new FetchConferenceRecordingOptions </summary>
        /// <param name="pathConferenceSid"> The Conference SID that identifies the conference associated with the recording to fetch. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Conference Recording resource to fetch. </param>
        public FetchRecordingOptions(string pathConferenceSid, string pathSid)
        {
            PathConferenceSid = pathConferenceSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

        

    }


    /// <summary> Retrieve a list of recordings belonging to the call used to make the request </summary>
    public class ReadRecordingOptions : ReadOptions<RecordingResource>
    {
    
        ///<summary> The Conference SID that identifies the conference associated with the recording to read. </summary> 
        public string PathConferenceSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Conference Recording resources to read. </summary> 
        public string PathAccountSid { get; set; }

        ///<summary> The `date_created` value, specified as `YYYY-MM-DD`, of the resources to read. You can also specify inequality: `DateCreated<=YYYY-MM-DD` will return recordings generated at or before midnight on a given date, and `DateCreated>=YYYY-MM-DD` returns recordings generated at or after midnight on a date. </summary> 
        public DateTime? DateCreated { get; set; }

        ///<summary> The `date_created` value, specified as `YYYY-MM-DD`, of the resources to read. You can also specify inequality: `DateCreated<=YYYY-MM-DD` will return recordings generated at or before midnight on a given date, and `DateCreated>=YYYY-MM-DD` returns recordings generated at or after midnight on a date. </summary> 
        public DateTime? DateCreatedBefore { get; set; }

        ///<summary> The `date_created` value, specified as `YYYY-MM-DD`, of the resources to read. You can also specify inequality: `DateCreated<=YYYY-MM-DD` will return recordings generated at or before midnight on a given date, and `DateCreated>=YYYY-MM-DD` returns recordings generated at or after midnight on a date. </summary> 
        public DateTime? DateCreatedAfter { get; set; }



        /// <summary> Construct a new ListConferenceRecordingOptions </summary>
        /// <param name="pathConferenceSid"> The Conference SID that identifies the conference associated with the recording to read. </param>
        public ReadRecordingOptions(string pathConferenceSid)
        {
            PathConferenceSid = pathConferenceSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", DateCreated.Value.ToString("yyyy-MM-dd")));
            }
            else
            {
                if (DateCreatedBefore != null)
                {
                    p.Add(new KeyValuePair<string, string>("DateCreated<", DateCreatedBefore.Value.ToString("yyyy-MM-dd")));
                }
                if (DateCreatedAfter != null)
                {
                    p.Add(new KeyValuePair<string, string>("DateCreated>", DateCreatedAfter.Value.ToString("yyyy-MM-dd")));
                }
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }

        

    }

    /// <summary> Changes the status of the recording to paused, stopped, or in-progress. Note: To use `Twilio.CURRENT`, pass it as recording sid. </summary>
    public class UpdateRecordingOptions : IOptions<RecordingResource>
    {
    
        ///<summary> The Conference SID that identifies the conference associated with the recording to update. </summary> 
        public string PathConferenceSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the Conference Recording resource to update. Use `Twilio.CURRENT` to reference the current active recording. </summary> 
        public string PathSid { get; }

        
        public RecordingResource.StatusEnum Status { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Conference Recording resource to update. </summary> 
        public string PathAccountSid { get; set; }

        ///<summary> Whether to record during a pause. Can be: `skip` or `silence` and the default is `silence`. `skip` does not record during the pause period, while `silence` will replace the actual audio of the call with silence during the pause period. This parameter only applies when setting `status` is set to `paused`. </summary> 
        public string PauseBehavior { get; set; }



        /// <summary> Construct a new UpdateConferenceRecordingOptions </summary>
        /// <param name="pathConferenceSid"> The Conference SID that identifies the conference associated with the recording to update. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Conference Recording resource to update. Use `Twilio.CURRENT` to reference the current active recording. </param>
        /// <param name="status">  </param>
        public UpdateRecordingOptions(string pathConferenceSid, string pathSid, RecordingResource.StatusEnum status)
        {
            PathConferenceSid = pathConferenceSid;
            PathSid = pathSid;
            Status = status;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }
            if (PauseBehavior != null)
            {
                p.Add(new KeyValuePair<string, string>("PauseBehavior", PauseBehavior));
            }
            return p;
        }

        

    }


}


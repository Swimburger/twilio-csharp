/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Taskrouter
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




namespace Twilio.Rest.Taskrouter.V1.Workspace.Worker
{
    /// <summary> fetch </summary>
    public class FetchWorkerStatisticsOptions : IOptions<WorkerStatisticsResource>
    {
    
        ///<summary> The SID of the Workspace with the WorkerChannel to fetch. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> The SID of the Worker with the WorkerChannel to fetch. </summary> 
        public string PathWorkerSid { get; }

        ///<summary> Only calculate statistics since this many minutes in the past. The default 15 minutes. This is helpful for displaying statistics for the last 15 minutes, 240 minutes (4 hours), and 480 minutes (8 hours) to see trends. </summary> 
        public int? Minutes { get; set; }

        ///<summary> Only calculate statistics from this date and time and later, specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        public DateTime? StartDate { get; set; }

        ///<summary> Only include usage that occurred on or before this date, specified in GMT as an [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) date-time. </summary> 
        public DateTime? EndDate { get; set; }

        ///<summary> Only calculate statistics on this TaskChannel. Can be the TaskChannel's SID or its `unique_name`, such as `voice`, `sms`, or `default`. </summary> 
        public string TaskChannel { get; set; }



        /// <summary> Construct a new FetchWorkerInstanceStatisticsOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the WorkerChannel to fetch. </param>
        /// <param name="pathWorkerSid"> The SID of the Worker with the WorkerChannel to fetch. </param>
        public FetchWorkerStatisticsOptions(string pathWorkspaceSid, string pathWorkerSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathWorkerSid = pathWorkerSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Minutes != null)
            {
                p.Add(new KeyValuePair<string, string>("Minutes", Minutes.ToString()));
            }
            if (StartDate != null)
            {
                p.Add(new KeyValuePair<string, string>("StartDate", Serializers.DateTimeIso8601(StartDate)));
            }
            if (EndDate != null)
            {
                p.Add(new KeyValuePair<string, string>("EndDate", Serializers.DateTimeIso8601(EndDate)));
            }
            if (TaskChannel != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskChannel", TaskChannel));
            }
            return p;
        }

        

    }


}


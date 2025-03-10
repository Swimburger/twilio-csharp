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
using System.Linq;



namespace Twilio.Rest.Api.V2010.Account.Call
{
    /// <summary> Fetch a Feedback resource from a call </summary>
    public class FetchFeedbackOptions : IOptions<FeedbackResource>
    {
    
        ///<summary> The call sid that uniquely identifies the call </summary> 
        public string PathCallSid { get; }

        ///<summary> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new FetchCallFeedbackOptions </summary>
        /// <param name="pathCallSid"> The call sid that uniquely identifies the call </param>
        public FetchFeedbackOptions(string pathCallSid)
        {
            PathCallSid = pathCallSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Update a Feedback resource for a call </summary>
    public class UpdateFeedbackOptions : IOptions<FeedbackResource>
    {
    
        ///<summary> The call sid that uniquely identifies the call </summary> 
        public string PathCallSid { get; }

        ///<summary> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </summary> 
        public string PathAccountSid { get; set; }

        ///<summary> The call quality expressed as an integer from `1` to `5` where `1` represents very poor call quality and `5` represents a perfect call. </summary> 
        public int? QualityScore { get; set; }

        ///<summary> One or more issues experienced during the call. The issues can be: `imperfect-audio`, `dropped-call`, `incorrect-caller-id`, `post-dial-delay`, `digits-not-captured`, `audio-latency`, `unsolicited-call`, or `one-way-audio`. </summary> 
        public List<FeedbackResource.IssuesEnum> Issue { get; set; }



        /// <summary> Construct a new UpdateCallFeedbackOptions </summary>
        /// <param name="pathCallSid"> The call sid that uniquely identifies the call </param>
        public UpdateFeedbackOptions(string pathCallSid)
        {
            PathCallSid = pathCallSid;
            Issue = new List<FeedbackResource.IssuesEnum>();
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (QualityScore != null)
            {
                p.Add(new KeyValuePair<string, string>("QualityScore", QualityScore.ToString()));
            }
            if (Issue != null)
            {
                p.AddRange(Issue.Select(Issue => new KeyValuePair<string, string>("Issue", Issue.ToString())));
            }
            return p;
        }
        

    }


}


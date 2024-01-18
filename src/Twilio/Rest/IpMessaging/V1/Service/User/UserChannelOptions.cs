/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Ip_messaging
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




namespace Twilio.Rest.IpMessaging.V1.Service.User
{
    /// <summary> read </summary>
    public class ReadUserChannelOptions : ReadOptions<UserChannelResource>
    {
    
        
        public string PathServiceSid { get; }

        
        public string PathUserSid { get; }



        /// <summary> Construct a new ListUserChannelOptions </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathUserSid">  </param>
        public ReadUserChannelOptions(string pathServiceSid, string pathUserSid)
        {
            PathServiceSid = pathServiceSid;
            PathUserSid = pathUserSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }

        

    }

}


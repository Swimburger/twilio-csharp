/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Messaging
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




namespace Twilio.Rest.Messaging.V1.BrandRegistration
{

    /// <summary> create </summary>
    public class CreateBrandRegistrationOtpOptions : IOptions<BrandRegistrationOtpResource>
    {
        
        ///<summary> Brand Registration Sid of Sole Proprietor Brand. </summary> 
        public string PathBrandRegistrationSid { get; }


        /// <summary> Construct a new CreateBrandRegistrationOtpOptions </summary>
        /// <param name="pathBrandRegistrationSid"> Brand Registration Sid of Sole Proprietor Brand. </param>
        public CreateBrandRegistrationOtpOptions(string pathBrandRegistrationSid)
        {
            PathBrandRegistrationSid = pathBrandRegistrationSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

        

    }
}


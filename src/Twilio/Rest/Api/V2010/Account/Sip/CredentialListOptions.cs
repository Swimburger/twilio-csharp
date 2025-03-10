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




namespace Twilio.Rest.Api.V2010.Account.Sip
{

    /// <summary> Create a Credential List </summary>
    public class CreateCredentialListOptions : IOptions<CredentialListResource>
    {
        
        ///<summary> A human readable descriptive text that describes the CredentialList, up to 64 characters long. </summary> 
        public string FriendlyName { get; }

        ///<summary> The unique id of the Account that is responsible for this resource. </summary> 
        public string PathAccountSid { get; set; }


        /// <summary> Construct a new CreateSipCredentialListOptions </summary>
        /// <param name="friendlyName"> A human readable descriptive text that describes the CredentialList, up to 64 characters long. </param>
        public CreateCredentialListOptions(string friendlyName)
        {
            FriendlyName = friendlyName;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            return p;
        }
        

    }
    /// <summary> Delete a Credential List </summary>
    public class DeleteCredentialListOptions : IOptions<CredentialListResource>
    {
        
        ///<summary> The credential list Sid that uniquely identifies this resource </summary> 
        public string PathSid { get; }

        ///<summary> The unique id of the Account that is responsible for this resource. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new DeleteSipCredentialListOptions </summary>
        /// <param name="pathSid"> The credential list Sid that uniquely identifies this resource </param>
        public DeleteCredentialListOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Get a Credential List </summary>
    public class FetchCredentialListOptions : IOptions<CredentialListResource>
    {
    
        ///<summary> The credential list Sid that uniquely identifies this resource </summary> 
        public string PathSid { get; }

        ///<summary> The unique id of the Account that is responsible for this resource. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new FetchSipCredentialListOptions </summary>
        /// <param name="pathSid"> The credential list Sid that uniquely identifies this resource </param>
        public FetchCredentialListOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Get All Credential Lists </summary>
    public class ReadCredentialListOptions : ReadOptions<CredentialListResource>
    {
    
        ///<summary> The unique id of the Account that is responsible for this resource. </summary> 
        public string PathAccountSid { get; set; }




        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

    /// <summary> Update a Credential List </summary>
    public class UpdateCredentialListOptions : IOptions<CredentialListResource>
    {
    
        ///<summary> The credential list Sid that uniquely identifies this resource </summary> 
        public string PathSid { get; }

        ///<summary> A human readable descriptive text for a CredentialList, up to 64 characters long. </summary> 
        public string FriendlyName { get; }

        ///<summary> The unique id of the Account that is responsible for this resource. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new UpdateSipCredentialListOptions </summary>
        /// <param name="pathSid"> The credential list Sid that uniquely identifies this resource </param>
        /// <param name="friendlyName"> A human readable descriptive text for a CredentialList, up to 64 characters long. </param>
        public UpdateCredentialListOptions(string pathSid, string friendlyName)
        {
            PathSid = pathSid;
            FriendlyName = friendlyName;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            return p;
        }
        

    }


}


/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Serverless
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




namespace Twilio.Rest.Serverless.V1.Service.Environment
{

    /// <summary> Create a new Variable. </summary>
    public class CreateVariableOptions : IOptions<VariableResource>
    {
        
        ///<summary> The SID of the Service to create the Variable resource under. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the Environment in which the Variable resource exists. </summary> 
        public string PathEnvironmentSid { get; }

        ///<summary> A string by which the Variable resource can be referenced. It can be a maximum of 128 characters. </summary> 
        public string Key { get; }

        ///<summary> A string that contains the actual value of the Variable. It can be a maximum of 450 bytes in size. </summary> 
        public string Value { get; }


        /// <summary> Construct a new CreateVariableOptions </summary>
        /// <param name="pathServiceSid"> The SID of the Service to create the Variable resource under. </param>
        /// <param name="pathEnvironmentSid"> The SID of the Environment in which the Variable resource exists. </param>
        /// <param name="key"> A string by which the Variable resource can be referenced. It can be a maximum of 128 characters. </param>
        /// <param name="value"> A string that contains the actual value of the Variable. It can be a maximum of 450 bytes in size. </param>
        public CreateVariableOptions(string pathServiceSid, string pathEnvironmentSid, string key, string value)
        {
            PathServiceSid = pathServiceSid;
            PathEnvironmentSid = pathEnvironmentSid;
            Key = key;
            Value = value;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Key != null)
            {
                p.Add(new KeyValuePair<string, string>("Key", Key));
            }
            if (Value != null)
            {
                p.Add(new KeyValuePair<string, string>("Value", Value));
            }
            return p;
        }

        

    }
    /// <summary> Delete a specific Variable. </summary>
    public class DeleteVariableOptions : IOptions<VariableResource>
    {
        
        ///<summary> The SID of the Service to delete the Variable resource from. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the Environment with the Variables to delete. </summary> 
        public string PathEnvironmentSid { get; }

        ///<summary> The SID of the Variable resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteVariableOptions </summary>
        /// <param name="pathServiceSid"> The SID of the Service to delete the Variable resource from. </param>
        /// <param name="pathEnvironmentSid"> The SID of the Environment with the Variables to delete. </param>
        /// <param name="pathSid"> The SID of the Variable resource to delete. </param>
        public DeleteVariableOptions(string pathServiceSid, string pathEnvironmentSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathEnvironmentSid = pathEnvironmentSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

        

    }


    /// <summary> Retrieve a specific Variable. </summary>
    public class FetchVariableOptions : IOptions<VariableResource>
    {
    
        ///<summary> The SID of the Service to fetch the Variable resource from. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the Environment with the Variable resource to fetch. </summary> 
        public string PathEnvironmentSid { get; }

        ///<summary> The SID of the Variable resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchVariableOptions </summary>
        /// <param name="pathServiceSid"> The SID of the Service to fetch the Variable resource from. </param>
        /// <param name="pathEnvironmentSid"> The SID of the Environment with the Variable resource to fetch. </param>
        /// <param name="pathSid"> The SID of the Variable resource to fetch. </param>
        public FetchVariableOptions(string pathServiceSid, string pathEnvironmentSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathEnvironmentSid = pathEnvironmentSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

        

    }


    /// <summary> Retrieve a list of all Variables. </summary>
    public class ReadVariableOptions : ReadOptions<VariableResource>
    {
    
        ///<summary> The SID of the Service to read the Variable resources from. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the Environment with the Variable resources to read. </summary> 
        public string PathEnvironmentSid { get; }



        /// <summary> Construct a new ListVariableOptions </summary>
        /// <param name="pathServiceSid"> The SID of the Service to read the Variable resources from. </param>
        /// <param name="pathEnvironmentSid"> The SID of the Environment with the Variable resources to read. </param>
        public ReadVariableOptions(string pathServiceSid, string pathEnvironmentSid)
        {
            PathServiceSid = pathServiceSid;
            PathEnvironmentSid = pathEnvironmentSid;
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

    /// <summary> Update a specific Variable. </summary>
    public class UpdateVariableOptions : IOptions<VariableResource>
    {
    
        ///<summary> The SID of the Service to update the Variable resource under. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the Environment with the Variable resource to update. </summary> 
        public string PathEnvironmentSid { get; }

        ///<summary> The SID of the Variable resource to update. </summary> 
        public string PathSid { get; }

        ///<summary> A string by which the Variable resource can be referenced. It can be a maximum of 128 characters. </summary> 
        public string Key { get; set; }

        ///<summary> A string that contains the actual value of the Variable. It can be a maximum of 450 bytes in size. </summary> 
        public string Value { get; set; }



        /// <summary> Construct a new UpdateVariableOptions </summary>
        /// <param name="pathServiceSid"> The SID of the Service to update the Variable resource under. </param>
        /// <param name="pathEnvironmentSid"> The SID of the Environment with the Variable resource to update. </param>
        /// <param name="pathSid"> The SID of the Variable resource to update. </param>
        public UpdateVariableOptions(string pathServiceSid, string pathEnvironmentSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathEnvironmentSid = pathEnvironmentSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Key != null)
            {
                p.Add(new KeyValuePair<string, string>("Key", Key));
            }
            if (Value != null)
            {
                p.Add(new KeyValuePair<string, string>("Value", Value));
            }
            return p;
        }

        

    }


}


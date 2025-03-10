/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Microvisor
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




namespace Twilio.Rest.Microvisor.V1
{

    /// <summary> Create a config for an Account. </summary>
    public class CreateAccountConfigOptions : IOptions<AccountConfigResource>
    {
        
        ///<summary> The config key; up to 100 characters. </summary> 
        public string Key { get; }

        ///<summary> The config value;  up to 4096 characters. </summary> 
        public string Value { get; }


        /// <summary> Construct a new CreateAccountConfigOptions </summary>
        /// <param name="key"> The config key; up to 100 characters. </param>
        /// <param name="value"> The config value;  up to 4096 characters. </param>
        public CreateAccountConfigOptions(string key, string value)
        {
            Key = key;
            Value = value;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
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
    /// <summary> Delete a config for an Account. </summary>
    public class DeleteAccountConfigOptions : IOptions<AccountConfigResource>
    {
        
        ///<summary> The config key; up to 100 characters. </summary> 
        public string PathKey { get; }



        /// <summary> Construct a new DeleteAccountConfigOptions </summary>
        /// <param name="pathKey"> The config key; up to 100 characters. </param>
        public DeleteAccountConfigOptions(string pathKey)
        {
            PathKey = pathKey;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Retrieve a Config for an Account. </summary>
    public class FetchAccountConfigOptions : IOptions<AccountConfigResource>
    {
    
        ///<summary> The config key; up to 100 characters. </summary> 
        public string PathKey { get; }



        /// <summary> Construct a new FetchAccountConfigOptions </summary>
        /// <param name="pathKey"> The config key; up to 100 characters. </param>
        public FetchAccountConfigOptions(string pathKey)
        {
            PathKey = pathKey;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Retrieve a list of all Configs for an Account. </summary>
    public class ReadAccountConfigOptions : ReadOptions<AccountConfigResource>
    {
    



        
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

}


/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Flex
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



namespace Twilio.Rest.FlexApi.V1
{
    public class InsightsSettingsAnswerSetsResource : Resource
    {
    

        
        private static Request BuildFetchRequest(FetchInsightsSettingsAnswerSetsOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Insights/QM/Settings/AnswerSets";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.FlexApi,
                path,
                queryParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary> To get the Answer Set Settings for an Account </summary>
        /// <param name="options"> Fetch InsightsSettingsAnswerSets parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsSettingsAnswerSets </returns>
        public static InsightsSettingsAnswerSetsResource Fetch(FetchInsightsSettingsAnswerSetsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> To get the Answer Set Settings for an Account </summary>
        /// <param name="options"> Fetch InsightsSettingsAnswerSets parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InsightsSettingsAnswerSets </returns>
        public static async System.Threading.Tasks.Task<InsightsSettingsAnswerSetsResource> FetchAsync(FetchInsightsSettingsAnswerSetsOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> To get the Answer Set Settings for an Account </summary>
        /// <param name="token"> The Token HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsSettingsAnswerSets </returns>
        public static InsightsSettingsAnswerSetsResource Fetch(
                                         string token = null, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchInsightsSettingsAnswerSetsOptions(){ Token = token };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> To get the Answer Set Settings for an Account </summary>
        /// <param name="token"> The Token HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InsightsSettingsAnswerSets </returns>
        public static async System.Threading.Tasks.Task<InsightsSettingsAnswerSetsResource> FetchAsync(string token = null, ITwilioRestClient client = null)
        {
            var options = new FetchInsightsSettingsAnswerSetsOptions(){ Token = token };
            return await FetchAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a InsightsSettingsAnswerSetsResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> InsightsSettingsAnswerSetsResource object represented by the provided JSON </returns>
        public static InsightsSettingsAnswerSetsResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<InsightsSettingsAnswerSetsResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Flex Insights resource and owns this resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The lis of answer sets </summary> 
        [JsonProperty("answer_sets")]
        public object AnswerSets { get; private set; }

        ///<summary> The list of answer set categories </summary> 
        [JsonProperty("answer_set_categories")]
        public object AnswerSetCategories { get; private set; }

        ///<summary> The details for not applicable answer set </summary> 
        [JsonProperty("not_applicable")]
        public object NotApplicable { get; private set; }

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private InsightsSettingsAnswerSetsResource() {

        }
    }
}


using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using VirtoCommerce.Client.Client;
using VirtoCommerce.Client.Model;


namespace VirtoCommerce.Client.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICommerceCoreModuleApi
    {
        
        /// <summary>
        /// Return all fulfillment centers registered in the system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns></returns>
        List<VirtoCommerceCoreModuleWebModelFulfillmentCenter> CommerceGetFulfillmentCenters ();
  
        /// <summary>
        /// Return all fulfillment centers registered in the system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns></returns>
        System.Threading.Tasks.Task<List<VirtoCommerceCoreModuleWebModelFulfillmentCenter>> CommerceGetFulfillmentCentersAsync ();
        
        /// <summary>
        /// Update a existing fulfillment center
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="center">fulfillment center</param>
        /// <returns>VirtoCommerceCoreModuleWebModelFulfillmentCenter</returns>
        VirtoCommerceCoreModuleWebModelFulfillmentCenter CommerceUpdateFulfillmentCenter (VirtoCommerceCoreModuleWebModelFulfillmentCenter center);
  
        /// <summary>
        /// Update a existing fulfillment center
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="center">fulfillment center</param>
        /// <returns>VirtoCommerceCoreModuleWebModelFulfillmentCenter</returns>
        System.Threading.Tasks.Task<VirtoCommerceCoreModuleWebModelFulfillmentCenter> CommerceUpdateFulfillmentCenterAsync (VirtoCommerceCoreModuleWebModelFulfillmentCenter center);
        
        /// <summary>
        /// Find fulfillment center by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">fulfillment center id</param>
        /// <returns>VirtoCommerceCoreModuleWebModelFulfillmentCenter</returns>
        VirtoCommerceCoreModuleWebModelFulfillmentCenter CommerceGetFulfillmentCenter (string id);
  
        /// <summary>
        /// Find fulfillment center by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id">fulfillment center id</param>
        /// <returns>VirtoCommerceCoreModuleWebModelFulfillmentCenter</returns>
        System.Threading.Tasks.Task<VirtoCommerceCoreModuleWebModelFulfillmentCenter> CommerceGetFulfillmentCenterAsync (string id);
        
        /// <summary>
        /// Find all SEO records for object by slug
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="slug">slug</param>
        /// <returns></returns>
        List<VirtoCommerceDomainCommerceModelSeoInfo> CommerceGetSeoInfoBySlug (string slug);
  
        /// <summary>
        /// Find all SEO records for object by slug
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="slug">slug</param>
        /// <returns></returns>
        System.Threading.Tasks.Task<List<VirtoCommerceDomainCommerceModelSeoInfo>> CommerceGetSeoInfoBySlugAsync (string slug);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CommerceCoreModuleApi : ICommerceCoreModuleApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommerceCoreModuleApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient</param>
        /// <returns></returns>
        public CommerceCoreModuleApi(ApiClient apiClient)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        
        /// <summary>
        /// Return all fulfillment centers registered in the system 
        /// </summary>
        /// <returns></returns>            
        public List<VirtoCommerceCoreModuleWebModelFulfillmentCenter> CommerceGetFulfillmentCenters ()
        {
            
    
            var path_ = "/api/fulfillment/centers";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CommerceGetFulfillmentCenters: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CommerceGetFulfillmentCenters: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<VirtoCommerceCoreModuleWebModelFulfillmentCenter>) ApiClient.Deserialize(response, typeof(List<VirtoCommerceCoreModuleWebModelFulfillmentCenter>));
        }
    
        /// <summary>
        /// Return all fulfillment centers registered in the system 
        /// </summary>
        /// <returns></returns>
        public async System.Threading.Tasks.Task<List<VirtoCommerceCoreModuleWebModelFulfillmentCenter>> CommerceGetFulfillmentCentersAsync ()
        {
            
    
            var path_ = "/api/fulfillment/centers";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CommerceGetFulfillmentCenters: " + response.Content, response.Content);

            return (List<VirtoCommerceCoreModuleWebModelFulfillmentCenter>) ApiClient.Deserialize(response, typeof(List<VirtoCommerceCoreModuleWebModelFulfillmentCenter>));
        }
        
        /// <summary>
        /// Update a existing fulfillment center 
        /// </summary>
        /// <param name="center">fulfillment center</param> 
        /// <returns>VirtoCommerceCoreModuleWebModelFulfillmentCenter</returns>            
        public VirtoCommerceCoreModuleWebModelFulfillmentCenter CommerceUpdateFulfillmentCenter (VirtoCommerceCoreModuleWebModelFulfillmentCenter center)
        {
            
            // verify the required parameter 'center' is set
            if (center == null) throw new ApiException(400, "Missing required parameter 'center' when calling CommerceUpdateFulfillmentCenter");
            
    
            var path_ = "/api/fulfillment/centers";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(center); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CommerceUpdateFulfillmentCenter: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CommerceUpdateFulfillmentCenter: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VirtoCommerceCoreModuleWebModelFulfillmentCenter) ApiClient.Deserialize(response, typeof(VirtoCommerceCoreModuleWebModelFulfillmentCenter));
        }
    
        /// <summary>
        /// Update a existing fulfillment center 
        /// </summary>
        /// <param name="center">fulfillment center</param>
        /// <returns>VirtoCommerceCoreModuleWebModelFulfillmentCenter</returns>
        public async System.Threading.Tasks.Task<VirtoCommerceCoreModuleWebModelFulfillmentCenter> CommerceUpdateFulfillmentCenterAsync (VirtoCommerceCoreModuleWebModelFulfillmentCenter center)
        {
            // verify the required parameter 'center' is set
            if (center == null) throw new ApiException(400, "Missing required parameter 'center' when calling CommerceUpdateFulfillmentCenter");
            
    
            var path_ = "/api/fulfillment/centers";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(center); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CommerceUpdateFulfillmentCenter: " + response.Content, response.Content);

            return (VirtoCommerceCoreModuleWebModelFulfillmentCenter) ApiClient.Deserialize(response, typeof(VirtoCommerceCoreModuleWebModelFulfillmentCenter));
        }
        
        /// <summary>
        /// Find fulfillment center by id 
        /// </summary>
        /// <param name="id">fulfillment center id</param> 
        /// <returns>VirtoCommerceCoreModuleWebModelFulfillmentCenter</returns>            
        public VirtoCommerceCoreModuleWebModelFulfillmentCenter CommerceGetFulfillmentCenter (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CommerceGetFulfillmentCenter");
            
    
            var path_ = "/api/fulfillment/centers/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CommerceGetFulfillmentCenter: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CommerceGetFulfillmentCenter: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VirtoCommerceCoreModuleWebModelFulfillmentCenter) ApiClient.Deserialize(response, typeof(VirtoCommerceCoreModuleWebModelFulfillmentCenter));
        }
    
        /// <summary>
        /// Find fulfillment center by id 
        /// </summary>
        /// <param name="id">fulfillment center id</param>
        /// <returns>VirtoCommerceCoreModuleWebModelFulfillmentCenter</returns>
        public async System.Threading.Tasks.Task<VirtoCommerceCoreModuleWebModelFulfillmentCenter> CommerceGetFulfillmentCenterAsync (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CommerceGetFulfillmentCenter");
            
    
            var path_ = "/api/fulfillment/centers/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CommerceGetFulfillmentCenter: " + response.Content, response.Content);

            return (VirtoCommerceCoreModuleWebModelFulfillmentCenter) ApiClient.Deserialize(response, typeof(VirtoCommerceCoreModuleWebModelFulfillmentCenter));
        }
        
        /// <summary>
        /// Find all SEO records for object by slug 
        /// </summary>
        /// <param name="slug">slug</param> 
        /// <returns></returns>            
        public List<VirtoCommerceDomainCommerceModelSeoInfo> CommerceGetSeoInfoBySlug (string slug)
        {
            
            // verify the required parameter 'slug' is set
            if (slug == null) throw new ApiException(400, "Missing required parameter 'slug' when calling CommerceGetSeoInfoBySlug");
            
    
            var path_ = "/api/seoinfos/{slug}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (slug != null) pathParams.Add("slug", ApiClient.ParameterToString(slug)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CommerceGetSeoInfoBySlug: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CommerceGetSeoInfoBySlug: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<VirtoCommerceDomainCommerceModelSeoInfo>) ApiClient.Deserialize(response, typeof(List<VirtoCommerceDomainCommerceModelSeoInfo>));
        }
    
        /// <summary>
        /// Find all SEO records for object by slug 
        /// </summary>
        /// <param name="slug">slug</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task<List<VirtoCommerceDomainCommerceModelSeoInfo>> CommerceGetSeoInfoBySlugAsync (string slug)
        {
            // verify the required parameter 'slug' is set
            if (slug == null) throw new ApiException(400, "Missing required parameter 'slug' when calling CommerceGetSeoInfoBySlug");
            
    
            var path_ = "/api/seoinfos/{slug}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "text/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (slug != null) pathParams.Add("slug", ApiClient.ParameterToString(slug)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CommerceGetSeoInfoBySlug: " + response.Content, response.Content);

            return (List<VirtoCommerceDomainCommerceModelSeoInfo>) ApiClient.Deserialize(response, typeof(List<VirtoCommerceDomainCommerceModelSeoInfo>));
        }
        
    }
    
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;
using RestSharp;
using PostFinanceCheckout.Client;
using PostFinanceCheckout.Model;
using PostFinanceCheckout.Util;

namespace PostFinanceCheckout.Service
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInvoiceReconciliationRecordInvoiceLinkService : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Count
        /// </summary>
        /// <remarks>
        /// Counts the number of items in the database as restricted by the given filter.
        /// </remarks>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>long?</returns>
        long? Count (long? spaceId, EntityQueryFilter filter = null);

        /// <summary>
        /// Count
        /// </summary>
        /// <remarks>
        /// Counts the number of items in the database as restricted by the given filter.
        /// </remarks>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>ApiResponse of long?</returns>
        ApiResponse<long?> CountWithHttpInfo (long? spaceId, EntityQueryFilter filter = null);



        /// <summary>
        /// Link Invoice
        /// </summary>
        /// <remarks>
        /// Links the invoice reconciliation record with the provided invoice.
        /// </remarks>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="recordId">The ID of the invoice reconciliation record which should be linked.</param>
        /// <param name="completionId">The ID of the completion which should be linked.</param>
        /// <param name="amount">The amount of the invoice reconciliation record linked completion which should be changed. (optional)</param>
        /// <returns>InvoiceReconciliationRecordInvoiceLink</returns>
        InvoiceReconciliationRecordInvoiceLink Link (long? spaceId, long? recordId, long? completionId, decimal? amount = null);

        /// <summary>
        /// Link Invoice
        /// </summary>
        /// <remarks>
        /// Links the invoice reconciliation record with the provided invoice.
        /// </remarks>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="recordId">The ID of the invoice reconciliation record which should be linked.</param>
        /// <param name="completionId">The ID of the completion which should be linked.</param>
        /// <param name="amount">The amount of the invoice reconciliation record linked completion which should be changed. (optional)</param>
        /// <returns>ApiResponse of InvoiceReconciliationRecordInvoiceLink</returns>
        ApiResponse<InvoiceReconciliationRecordInvoiceLink> LinkWithHttpInfo (long? spaceId, long? recordId, long? completionId, decimal? amount = null);



        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The ID of the invoice reconciliation record invoice link which should be returned.</param>
        /// <returns>InvoiceReconciliationRecordInvoiceLink</returns>
        InvoiceReconciliationRecordInvoiceLink Read (long? spaceId, long? id);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The ID of the invoice reconciliation record invoice link which should be returned.</param>
        /// <returns>ApiResponse of InvoiceReconciliationRecordInvoiceLink</returns>
        ApiResponse<InvoiceReconciliationRecordInvoiceLink> ReadWithHttpInfo (long? spaceId, long? id);



        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the invoice reconciliation record invoice link which are returned by the search.</param>
        /// <returns>List&lt;InvoiceReconciliationRecordInvoiceLink&gt;</returns>
        List<InvoiceReconciliationRecordInvoiceLink> Search (long? spaceId, EntityQuery query);

        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the invoice reconciliation record invoice link which are returned by the search.</param>
        /// <returns>ApiResponse of List&lt;InvoiceReconciliationRecordInvoiceLink&gt;</returns>
        ApiResponse<List<InvoiceReconciliationRecordInvoiceLink>> SearchWithHttpInfo (long? spaceId, EntityQuery query);



        /// <summary>
        /// Unlink Invoice
        /// </summary>
        /// <remarks>
        /// Unlinks the invoice reconciliation record from the provided invoice.
        /// </remarks>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="recordId">The ID of the invoice reconciliation record which should be unlinked.</param>
        /// <param name="completionId">The ID of the completion which should be unlinked.</param>
        /// <returns></returns>
        void UnlinkTransaction (long? spaceId, long? recordId, long? completionId);

        /// <summary>
        /// Unlink Invoice
        /// </summary>
        /// <remarks>
        /// Unlinks the invoice reconciliation record from the provided invoice.
        /// </remarks>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="recordId">The ID of the invoice reconciliation record which should be unlinked.</param>
        /// <param name="completionId">The ID of the completion which should be unlinked.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UnlinkTransactionWithHttpInfo (long? spaceId, long? recordId, long? completionId);



        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class InvoiceReconciliationRecordInvoiceLinkService : IInvoiceReconciliationRecordInvoiceLinkService
    {
        private PostFinanceCheckout.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceReconciliationRecordInvoiceLinkService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InvoiceReconciliationRecordInvoiceLinkService(PostFinanceCheckout.Client.Configuration configuration = null)
        {
            if (configuration == null) {
                throw new ArgumentException("Parameter cannot be null", "configuration");
            }
            this.Configuration = configuration;

            ExceptionFactory = PostFinanceCheckout.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.Options.BaseUrl.ToString();
        }


        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public PostFinanceCheckout.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public PostFinanceCheckout.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Count Counts the number of items in the database as restricted by the given filter.
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>long?</returns>
        public long? Count (long? spaceId, EntityQueryFilter filter = null)
        {
             ApiResponse<long?> localVarResponse = CountWithHttpInfo(spaceId, filter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Count Counts the number of items in the database as restricted by the given filter.
        
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>ApiResponse of long?</returns>
        public ApiResponse< long? > CountWithHttpInfo (long? spaceId, EntityQueryFilter filter = null)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling InvoiceReconciliationRecordInvoiceLinkService->Count");

            var localVarPath = "/invoice-reconciliation-record-invoice-link-service/count";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (filter != null && filter.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(filter); // http body (model) parameter
            }
            else
            {
                localVarPostBody = filter; // byte array
            }

			int requestTimeout = this.Configuration.Timeout * 1000;

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Count", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<long?>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (long?) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(long?)));
        }
        /// <summary>
        /// Link Invoice Links the invoice reconciliation record with the provided invoice.
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="recordId">The ID of the invoice reconciliation record which should be linked.</param>
        /// <param name="completionId">The ID of the completion which should be linked.</param>
        /// <param name="amount">The amount of the invoice reconciliation record linked completion which should be changed. (optional)</param>
        /// <returns>InvoiceReconciliationRecordInvoiceLink</returns>
        public InvoiceReconciliationRecordInvoiceLink Link (long? spaceId, long? recordId, long? completionId, decimal? amount = null)
        {
             ApiResponse<InvoiceReconciliationRecordInvoiceLink> localVarResponse = LinkWithHttpInfo(spaceId, recordId, completionId, amount);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Link Invoice Links the invoice reconciliation record with the provided invoice.
        
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="recordId">The ID of the invoice reconciliation record which should be linked.</param>
        /// <param name="completionId">The ID of the completion which should be linked.</param>
        /// <param name="amount">The amount of the invoice reconciliation record linked completion which should be changed. (optional)</param>
        /// <returns>ApiResponse of InvoiceReconciliationRecordInvoiceLink</returns>
        public ApiResponse< InvoiceReconciliationRecordInvoiceLink > LinkWithHttpInfo (long? spaceId, long? recordId, long? completionId, decimal? amount = null)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling InvoiceReconciliationRecordInvoiceLinkService->Link");
            // verify the required parameter 'recordId' is set
            if (recordId == null)
                throw new ApiException(400, "Missing required parameter 'recordId' when calling InvoiceReconciliationRecordInvoiceLinkService->Link");
            // verify the required parameter 'completionId' is set
            if (completionId == null)
                throw new ApiException(400, "Missing required parameter 'completionId' when calling InvoiceReconciliationRecordInvoiceLinkService->Link");

            var localVarPath = "/invoice-reconciliation-record-invoice-link-service/link";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (recordId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "recordId", recordId)); // query parameter
            if (completionId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "completionId", completionId)); // query parameter
            if (amount != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "amount", amount)); // query parameter

			int requestTimeout = this.Configuration.Timeout * 1000;

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Link", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InvoiceReconciliationRecordInvoiceLink>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (InvoiceReconciliationRecordInvoiceLink) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InvoiceReconciliationRecordInvoiceLink)));
        }
        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The ID of the invoice reconciliation record invoice link which should be returned.</param>
        /// <returns>InvoiceReconciliationRecordInvoiceLink</returns>
        public InvoiceReconciliationRecordInvoiceLink Read (long? spaceId, long? id)
        {
             ApiResponse<InvoiceReconciliationRecordInvoiceLink> localVarResponse = ReadWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The ID of the invoice reconciliation record invoice link which should be returned.</param>
        /// <returns>ApiResponse of InvoiceReconciliationRecordInvoiceLink</returns>
        public ApiResponse< InvoiceReconciliationRecordInvoiceLink > ReadWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling InvoiceReconciliationRecordInvoiceLinkService->Read");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling InvoiceReconciliationRecordInvoiceLinkService->Read");

            var localVarPath = "/invoice-reconciliation-record-invoice-link-service/read";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter

			int requestTimeout = this.Configuration.Timeout * 1000;

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Read", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InvoiceReconciliationRecordInvoiceLink>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (InvoiceReconciliationRecordInvoiceLink) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InvoiceReconciliationRecordInvoiceLink)));
        }
        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the invoice reconciliation record invoice link which are returned by the search.</param>
        /// <returns>List&lt;InvoiceReconciliationRecordInvoiceLink&gt;</returns>
        public List<InvoiceReconciliationRecordInvoiceLink> Search (long? spaceId, EntityQuery query)
        {
             ApiResponse<List<InvoiceReconciliationRecordInvoiceLink>> localVarResponse = SearchWithHttpInfo(spaceId, query);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the invoice reconciliation record invoice link which are returned by the search.</param>
        /// <returns>ApiResponse of List&lt;InvoiceReconciliationRecordInvoiceLink&gt;</returns>
        public ApiResponse< List<InvoiceReconciliationRecordInvoiceLink> > SearchWithHttpInfo (long? spaceId, EntityQuery query)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling InvoiceReconciliationRecordInvoiceLinkService->Search");
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling InvoiceReconciliationRecordInvoiceLinkService->Search");

            var localVarPath = "/invoice-reconciliation-record-invoice-link-service/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (query != null && query.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(query); // http body (model) parameter
            }
            else
            {
                localVarPostBody = query; // byte array
            }

			int requestTimeout = this.Configuration.Timeout * 1000;

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Search", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<InvoiceReconciliationRecordInvoiceLink>>(localVarStatusCode,
                    localVarResponse.Headers
                        .GroupBy(x => x.Name, x => x.Value.ToString())
                        .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                    (List<InvoiceReconciliationRecordInvoiceLink>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<InvoiceReconciliationRecordInvoiceLink>)));
        }
        /// <summary>
        /// Unlink Invoice Unlinks the invoice reconciliation record from the provided invoice.
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="recordId">The ID of the invoice reconciliation record which should be unlinked.</param>
        /// <param name="completionId">The ID of the completion which should be unlinked.</param>
        /// <returns></returns>
        public void UnlinkTransaction (long? spaceId, long? recordId, long? completionId)
        {
             UnlinkTransactionWithHttpInfo(spaceId, recordId, completionId);
        }

        /// <summary>
        /// Unlink Invoice Unlinks the invoice reconciliation record from the provided invoice.
        
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="recordId">The ID of the invoice reconciliation record which should be unlinked.</param>
        /// <param name="completionId">The ID of the completion which should be unlinked.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UnlinkTransactionWithHttpInfo (long? spaceId, long? recordId, long? completionId)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling InvoiceReconciliationRecordInvoiceLinkService->UnlinkTransaction");
            // verify the required parameter 'recordId' is set
            if (recordId == null)
                throw new ApiException(400, "Missing required parameter 'recordId' when calling InvoiceReconciliationRecordInvoiceLinkService->UnlinkTransaction");
            // verify the required parameter 'completionId' is set
            if (completionId == null)
                throw new ApiException(400, "Missing required parameter 'completionId' when calling InvoiceReconciliationRecordInvoiceLinkService->UnlinkTransaction");

            var localVarPath = "/invoice-reconciliation-record-invoice-link-service/unlink-transaction";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "spaceId", spaceId)); // query parameter
            if (recordId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "recordId", recordId)); // query parameter
            if (completionId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "completionId", completionId)); // query parameter

			int requestTimeout = this.Configuration.Timeout * 1000;

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarFileParams,
                localVarPathParams, localVarHttpContentType, requestTimeout);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UnlinkTransaction", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers
                    .GroupBy(x => x.Name, x => x.Value.ToString())
                    .ToDictionary(x => x.Key,  x => String.Join(", ", x)),
                null);
        }
    }
}

/**
 * PostFinance C# SDK
 *
 * This library allows to interact with the PostFinance payment service.
 *
 * Copyright owner: Wallee AG
 * Website: https://www.postfinance.ch/en/private.html
 * Developer email: ecosystem-team@wallee.com
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using PostFinanceCheckout.Client;
using PostFinanceCheckout.Model;

namespace PostFinanceCheckout.Service
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISubscriptionProductMeteredFeeTiersServiceSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete a metered fee tier
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="feeId"></param>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void DeleteSubscriptionsProductsMeteredFeesFeeIdTiersId(long feeId, long id, long space, int operationIndex = 0);

        /// <summary>
        /// Delete a metered fee tier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="feeId"></param>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteSubscriptionsProductsMeteredFeesFeeIdTiersIdWithHttpInfo(long feeId, long id, long space, int operationIndex = 0);
        /// <summary>
        /// List all metered fee tiers
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="feeId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="after">Set to an object&#39;s ID to retrieve the page of objects coming immediately after the named object. (optional)</param>
        /// <param name="before">Set to an object&#39;s ID to retrieve the page of objects coming immediately before the named object. (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="order">Specify to retrieve objects in chronological (ASC) or reverse chronological (DESC) order. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductMeteredFeeTierListResponse</returns>
        ProductMeteredFeeTierListResponse GetSubscriptionsProductsMeteredFeesFeeIdTiers(long feeId, long space, long? after = default, long? before = default, List<string>? expand = default, int? limit = default, SortingOrder? order = default, int operationIndex = 0);

        /// <summary>
        /// List all metered fee tiers
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="feeId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="after">Set to an object&#39;s ID to retrieve the page of objects coming immediately after the named object. (optional)</param>
        /// <param name="before">Set to an object&#39;s ID to retrieve the page of objects coming immediately before the named object. (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="order">Specify to retrieve objects in chronological (ASC) or reverse chronological (DESC) order. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductMeteredFeeTierListResponse</returns>
        ApiResponse<ProductMeteredFeeTierListResponse> GetSubscriptionsProductsMeteredFeesFeeIdTiersWithHttpInfo(long feeId, long space, long? after = default, long? before = default, List<string>? expand = default, int? limit = default, SortingOrder? order = default, int operationIndex = 0);
        /// <summary>
        /// Retrieve a metered fee tier
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="feeId"></param>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductMeteredTierFee</returns>
        ProductMeteredTierFee GetSubscriptionsProductsMeteredFeesFeeIdTiersId(long feeId, long id, long space, List<string>? expand = default, int operationIndex = 0);

        /// <summary>
        /// Retrieve a metered fee tier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="feeId"></param>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductMeteredTierFee</returns>
        ApiResponse<ProductMeteredTierFee> GetSubscriptionsProductsMeteredFeesFeeIdTiersIdWithHttpInfo(long feeId, long id, long space, List<string>? expand = default, int operationIndex = 0);
        /// <summary>
        /// Search metered fee tiers
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="feeId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="offset">A cursor for pagination, specifies the number of objects to skip. (optional)</param>
        /// <param name="order">The fields and order to sort the objects by. (optional)</param>
        /// <param name="query">The search query to filter the objects by. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductMeteredFeeTierSearchResponse</returns>
        ProductMeteredFeeTierSearchResponse GetSubscriptionsProductsMeteredFeesFeeIdTiersSearch(long feeId, long space, List<string>? expand = default, int? limit = default, int? offset = default, string? order = default, string? query = default, int operationIndex = 0);

        /// <summary>
        /// Search metered fee tiers
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="feeId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="offset">A cursor for pagination, specifies the number of objects to skip. (optional)</param>
        /// <param name="order">The fields and order to sort the objects by. (optional)</param>
        /// <param name="query">The search query to filter the objects by. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductMeteredFeeTierSearchResponse</returns>
        ApiResponse<ProductMeteredFeeTierSearchResponse> GetSubscriptionsProductsMeteredFeesFeeIdTiersSearchWithHttpInfo(long feeId, long space, List<string>? expand = default, int? limit = default, int? offset = default, string? order = default, string? query = default, int operationIndex = 0);
        /// <summary>
        /// Update a metered fee tier
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="feeId"></param>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="productMeteredTierFeeUpdate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductMeteredTierFee</returns>
        ProductMeteredTierFee PatchSubscriptionsProductsMeteredFeesFeeIdTiersId(long feeId, long id, long space, ProductMeteredTierFeeUpdate productMeteredTierFeeUpdate, List<string>? expand = default, int operationIndex = 0);

        /// <summary>
        /// Update a metered fee tier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="feeId"></param>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="productMeteredTierFeeUpdate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductMeteredTierFee</returns>
        ApiResponse<ProductMeteredTierFee> PatchSubscriptionsProductsMeteredFeesFeeIdTiersIdWithHttpInfo(long feeId, long id, long space, ProductMeteredTierFeeUpdate productMeteredTierFeeUpdate, List<string>? expand = default, int operationIndex = 0);
        /// <summary>
        /// Create a metered fee tier
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="feeId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="productMeteredTierFeeUpdate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductMeteredTierFee</returns>
        ProductMeteredTierFee PostSubscriptionsProductsMeteredFeesFeeIdTiers(long feeId, long space, ProductMeteredTierFeeUpdate productMeteredTierFeeUpdate, List<string>? expand = default, int operationIndex = 0);

        /// <summary>
        /// Create a metered fee tier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="feeId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="productMeteredTierFeeUpdate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductMeteredTierFee</returns>
        ApiResponse<ProductMeteredTierFee> PostSubscriptionsProductsMeteredFeesFeeIdTiersWithHttpInfo(long feeId, long space, ProductMeteredTierFeeUpdate productMeteredTierFeeUpdate, List<string>? expand = default, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISubscriptionProductMeteredFeeTiersService : ISubscriptionProductMeteredFeeTiersServiceSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SubscriptionProductMeteredFeeTiersService : ISubscriptionProductMeteredFeeTiersService
    {

        private PostFinanceCheckout.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductMeteredFeeTiersService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SubscriptionProductMeteredFeeTiersService(PostFinanceCheckout.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            this.Configuration = configuration;
            this.Client = new PostFinanceCheckout.Client.ApiClient(this.Configuration);
            ExceptionFactory = PostFinanceCheckout.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductMeteredFeeTiersService"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public SubscriptionProductMeteredFeeTiersService(PostFinanceCheckout.Client.ISynchronousClient client, PostFinanceCheckout.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.Configuration = configuration;
            this.ExceptionFactory = PostFinanceCheckout.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public PostFinanceCheckout.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public PostFinanceCheckout.Client.IReadableConfiguration Configuration { get; set; }

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
        /// Delete a metered fee tier 
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="feeId"></param>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void DeleteSubscriptionsProductsMeteredFeesFeeIdTiersId(long feeId, long id, long space, int operationIndex = 0)
        {
            DeleteSubscriptionsProductsMeteredFeesFeeIdTiersIdWithHttpInfo(feeId, id, space);
        }

        /// <summary>
        /// Delete a metered fee tier 
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="feeId"></param>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public PostFinanceCheckout.Client.ApiResponse<Object> DeleteSubscriptionsProductsMeteredFeesFeeIdTiersIdWithHttpInfo(long feeId, long id, long space, int operationIndex = 0)
        {
            PostFinanceCheckout.Client.RequestOptions localVarRequestOptions = new PostFinanceCheckout.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = PostFinanceCheckout.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            var localVarMultipartFormData = localVarContentType == "multipart/form-data";
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = PostFinanceCheckout.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("feeId", PostFinanceCheckout.Client.ClientUtils.ParameterToString(feeId)); // path parameter
            localVarRequestOptions.PathParameters.Add("id", PostFinanceCheckout.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("Space", PostFinanceCheckout.Client.ClientUtils.ParameterToString(space)); // header parameter

            localVarRequestOptions.Operation = "SubscriptionProductMeteredFeeTiersService.DeleteSubscriptionsProductsMeteredFeesFeeIdTiersId";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/subscriptions/products/metered-fees/{feeId}/tiers/{id}",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteSubscriptionsProductsMeteredFeesFeeIdTiersId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// List all metered fee tiers 
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="feeId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="after">Set to an object&#39;s ID to retrieve the page of objects coming immediately after the named object. (optional)</param>
        /// <param name="before">Set to an object&#39;s ID to retrieve the page of objects coming immediately before the named object. (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="order">Specify to retrieve objects in chronological (ASC) or reverse chronological (DESC) order. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductMeteredFeeTierListResponse</returns>
        public ProductMeteredFeeTierListResponse GetSubscriptionsProductsMeteredFeesFeeIdTiers(long feeId, long space, long? after = default, long? before = default, List<string>? expand = default, int? limit = default, SortingOrder? order = default, int operationIndex = 0)
        {
            PostFinanceCheckout.Client.ApiResponse<ProductMeteredFeeTierListResponse> localVarResponse = GetSubscriptionsProductsMeteredFeesFeeIdTiersWithHttpInfo(feeId, space, after, before, expand, limit, order);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all metered fee tiers 
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="feeId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="after">Set to an object&#39;s ID to retrieve the page of objects coming immediately after the named object. (optional)</param>
        /// <param name="before">Set to an object&#39;s ID to retrieve the page of objects coming immediately before the named object. (optional)</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="order">Specify to retrieve objects in chronological (ASC) or reverse chronological (DESC) order. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductMeteredFeeTierListResponse</returns>
        public PostFinanceCheckout.Client.ApiResponse<ProductMeteredFeeTierListResponse> GetSubscriptionsProductsMeteredFeesFeeIdTiersWithHttpInfo(long feeId, long space, long? after = default, long? before = default, List<string>? expand = default, int? limit = default, SortingOrder? order = default, int operationIndex = 0)
        {
            PostFinanceCheckout.Client.RequestOptions localVarRequestOptions = new PostFinanceCheckout.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = PostFinanceCheckout.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            var localVarMultipartFormData = localVarContentType == "multipart/form-data";
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = PostFinanceCheckout.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("feeId", PostFinanceCheckout.Client.ClientUtils.ParameterToString(feeId)); // path parameter
            if (after != null)
            {
                localVarRequestOptions.QueryParameters.Add(PostFinanceCheckout.Client.ClientUtils.ParameterToMultiMap("", "after", after));
            }
            if (before != null)
            {
                localVarRequestOptions.QueryParameters.Add(PostFinanceCheckout.Client.ClientUtils.ParameterToMultiMap("", "before", before));
            }
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(PostFinanceCheckout.Client.ClientUtils.ParameterToMultiMap("multi", "expand", expand));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(PostFinanceCheckout.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (order != null)
            {
                localVarRequestOptions.QueryParameters.Add(PostFinanceCheckout.Client.ClientUtils.ParameterToMultiMap("", "order", order));
            }
            localVarRequestOptions.HeaderParameters.Add("Space", PostFinanceCheckout.Client.ClientUtils.ParameterToString(space)); // header parameter

            localVarRequestOptions.Operation = "SubscriptionProductMeteredFeeTiersService.GetSubscriptionsProductsMeteredFeesFeeIdTiers";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Get<ProductMeteredFeeTierListResponse>("/subscriptions/products/metered-fees/{feeId}/tiers",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetSubscriptionsProductsMeteredFeesFeeIdTiers", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Retrieve a metered fee tier 
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="feeId"></param>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductMeteredTierFee</returns>
        public ProductMeteredTierFee GetSubscriptionsProductsMeteredFeesFeeIdTiersId(long feeId, long id, long space, List<string>? expand = default, int operationIndex = 0)
        {
            PostFinanceCheckout.Client.ApiResponse<ProductMeteredTierFee> localVarResponse = GetSubscriptionsProductsMeteredFeesFeeIdTiersIdWithHttpInfo(feeId, id, space, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a metered fee tier 
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="feeId"></param>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductMeteredTierFee</returns>
        public PostFinanceCheckout.Client.ApiResponse<ProductMeteredTierFee> GetSubscriptionsProductsMeteredFeesFeeIdTiersIdWithHttpInfo(long feeId, long id, long space, List<string>? expand = default, int operationIndex = 0)
        {
            PostFinanceCheckout.Client.RequestOptions localVarRequestOptions = new PostFinanceCheckout.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = PostFinanceCheckout.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            var localVarMultipartFormData = localVarContentType == "multipart/form-data";
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = PostFinanceCheckout.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("feeId", PostFinanceCheckout.Client.ClientUtils.ParameterToString(feeId)); // path parameter
            localVarRequestOptions.PathParameters.Add("id", PostFinanceCheckout.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(PostFinanceCheckout.Client.ClientUtils.ParameterToMultiMap("multi", "expand", expand));
            }
            localVarRequestOptions.HeaderParameters.Add("Space", PostFinanceCheckout.Client.ClientUtils.ParameterToString(space)); // header parameter

            localVarRequestOptions.Operation = "SubscriptionProductMeteredFeeTiersService.GetSubscriptionsProductsMeteredFeesFeeIdTiersId";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Get<ProductMeteredTierFee>("/subscriptions/products/metered-fees/{feeId}/tiers/{id}",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetSubscriptionsProductsMeteredFeesFeeIdTiersId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Search metered fee tiers 
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="feeId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="offset">A cursor for pagination, specifies the number of objects to skip. (optional)</param>
        /// <param name="order">The fields and order to sort the objects by. (optional)</param>
        /// <param name="query">The search query to filter the objects by. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductMeteredFeeTierSearchResponse</returns>
        public ProductMeteredFeeTierSearchResponse GetSubscriptionsProductsMeteredFeesFeeIdTiersSearch(long feeId, long space, List<string>? expand = default, int? limit = default, int? offset = default, string? order = default, string? query = default, int operationIndex = 0)
        {
            PostFinanceCheckout.Client.ApiResponse<ProductMeteredFeeTierSearchResponse> localVarResponse = GetSubscriptionsProductsMeteredFeesFeeIdTiersSearchWithHttpInfo(feeId, space, expand, limit, offset, order, query);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search metered fee tiers 
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="feeId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="expand"> (optional)</param>
        /// <param name="limit">A limit on the number of objects to be returned, between 1 and 100. Default is 10. (optional)</param>
        /// <param name="offset">A cursor for pagination, specifies the number of objects to skip. (optional)</param>
        /// <param name="order">The fields and order to sort the objects by. (optional)</param>
        /// <param name="query">The search query to filter the objects by. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductMeteredFeeTierSearchResponse</returns>
        public PostFinanceCheckout.Client.ApiResponse<ProductMeteredFeeTierSearchResponse> GetSubscriptionsProductsMeteredFeesFeeIdTiersSearchWithHttpInfo(long feeId, long space, List<string>? expand = default, int? limit = default, int? offset = default, string? order = default, string? query = default, int operationIndex = 0)
        {
            PostFinanceCheckout.Client.RequestOptions localVarRequestOptions = new PostFinanceCheckout.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = PostFinanceCheckout.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            var localVarMultipartFormData = localVarContentType == "multipart/form-data";
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = PostFinanceCheckout.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("feeId", PostFinanceCheckout.Client.ClientUtils.ParameterToString(feeId)); // path parameter
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(PostFinanceCheckout.Client.ClientUtils.ParameterToMultiMap("multi", "expand", expand));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(PostFinanceCheckout.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (offset != null)
            {
                localVarRequestOptions.QueryParameters.Add(PostFinanceCheckout.Client.ClientUtils.ParameterToMultiMap("", "offset", offset));
            }
            if (order != null)
            {
                localVarRequestOptions.QueryParameters.Add(PostFinanceCheckout.Client.ClientUtils.ParameterToMultiMap("", "order", order));
            }
            if (query != null)
            {
                localVarRequestOptions.QueryParameters.Add(PostFinanceCheckout.Client.ClientUtils.ParameterToMultiMap("", "query", query));
            }
            localVarRequestOptions.HeaderParameters.Add("Space", PostFinanceCheckout.Client.ClientUtils.ParameterToString(space)); // header parameter

            localVarRequestOptions.Operation = "SubscriptionProductMeteredFeeTiersService.GetSubscriptionsProductsMeteredFeesFeeIdTiersSearch";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Get<ProductMeteredFeeTierSearchResponse>("/subscriptions/products/metered-fees/{feeId}/tiers/search",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetSubscriptionsProductsMeteredFeesFeeIdTiersSearch", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Update a metered fee tier 
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="feeId"></param>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="productMeteredTierFeeUpdate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductMeteredTierFee</returns>
        public ProductMeteredTierFee PatchSubscriptionsProductsMeteredFeesFeeIdTiersId(long feeId, long id, long space, ProductMeteredTierFeeUpdate productMeteredTierFeeUpdate, List<string>? expand = default, int operationIndex = 0)
        {
            PostFinanceCheckout.Client.ApiResponse<ProductMeteredTierFee> localVarResponse = PatchSubscriptionsProductsMeteredFeesFeeIdTiersIdWithHttpInfo(feeId, id, space, productMeteredTierFeeUpdate, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a metered fee tier 
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="feeId"></param>
        /// <param name="id"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="productMeteredTierFeeUpdate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductMeteredTierFee</returns>
        public PostFinanceCheckout.Client.ApiResponse<ProductMeteredTierFee> PatchSubscriptionsProductsMeteredFeesFeeIdTiersIdWithHttpInfo(long feeId, long id, long space, ProductMeteredTierFeeUpdate productMeteredTierFeeUpdate, List<string>? expand = default, int operationIndex = 0)
        {
            // verify the required parameter 'productMeteredTierFeeUpdate' is set
            if (productMeteredTierFeeUpdate == null)
            {
                throw new PostFinanceCheckout.Client.ApiException(400, "Missing required parameter 'productMeteredTierFeeUpdate' when calling SubscriptionProductMeteredFeeTiersService->PatchSubscriptionsProductsMeteredFeesFeeIdTiersId");
            }

            PostFinanceCheckout.Client.RequestOptions localVarRequestOptions = new PostFinanceCheckout.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = PostFinanceCheckout.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            var localVarMultipartFormData = localVarContentType == "multipart/form-data";
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = PostFinanceCheckout.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("feeId", PostFinanceCheckout.Client.ClientUtils.ParameterToString(feeId)); // path parameter
            localVarRequestOptions.PathParameters.Add("id", PostFinanceCheckout.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(PostFinanceCheckout.Client.ClientUtils.ParameterToMultiMap("multi", "expand", expand));
            }
            localVarRequestOptions.HeaderParameters.Add("Space", PostFinanceCheckout.Client.ClientUtils.ParameterToString(space)); // header parameter
            localVarRequestOptions.Data = productMeteredTierFeeUpdate;

            localVarRequestOptions.Operation = "SubscriptionProductMeteredFeeTiersService.PatchSubscriptionsProductsMeteredFeesFeeIdTiersId";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Patch<ProductMeteredTierFee>("/subscriptions/products/metered-fees/{feeId}/tiers/{id}",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PatchSubscriptionsProductsMeteredFeesFeeIdTiersId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Create a metered fee tier 
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="feeId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="productMeteredTierFeeUpdate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ProductMeteredTierFee</returns>
        public ProductMeteredTierFee PostSubscriptionsProductsMeteredFeesFeeIdTiers(long feeId, long space, ProductMeteredTierFeeUpdate productMeteredTierFeeUpdate, List<string>? expand = default, int operationIndex = 0)
        {
            PostFinanceCheckout.Client.ApiResponse<ProductMeteredTierFee> localVarResponse = PostSubscriptionsProductsMeteredFeesFeeIdTiersWithHttpInfo(feeId, space, productMeteredTierFeeUpdate, expand);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a metered fee tier 
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="feeId"></param>
        /// <param name="space">Specifies the ID of the space the operation should be executed in.</param>
        /// <param name="productMeteredTierFeeUpdate"></param>
        /// <param name="expand"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ProductMeteredTierFee</returns>
        public PostFinanceCheckout.Client.ApiResponse<ProductMeteredTierFee> PostSubscriptionsProductsMeteredFeesFeeIdTiersWithHttpInfo(long feeId, long space, ProductMeteredTierFeeUpdate productMeteredTierFeeUpdate, List<string>? expand = default, int operationIndex = 0)
        {
            // verify the required parameter 'productMeteredTierFeeUpdate' is set
            if (productMeteredTierFeeUpdate == null)
            {
                throw new PostFinanceCheckout.Client.ApiException(400, "Missing required parameter 'productMeteredTierFeeUpdate' when calling SubscriptionProductMeteredFeeTiersService->PostSubscriptionsProductsMeteredFeesFeeIdTiers");
            }

            PostFinanceCheckout.Client.RequestOptions localVarRequestOptions = new PostFinanceCheckout.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = PostFinanceCheckout.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            var localVarMultipartFormData = localVarContentType == "multipart/form-data";
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = PostFinanceCheckout.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("feeId", PostFinanceCheckout.Client.ClientUtils.ParameterToString(feeId)); // path parameter
            if (expand != null)
            {
                localVarRequestOptions.QueryParameters.Add(PostFinanceCheckout.Client.ClientUtils.ParameterToMultiMap("multi", "expand", expand));
            }
            localVarRequestOptions.HeaderParameters.Add("Space", PostFinanceCheckout.Client.ClientUtils.ParameterToString(space)); // header parameter
            localVarRequestOptions.Data = productMeteredTierFeeUpdate;

            localVarRequestOptions.Operation = "SubscriptionProductMeteredFeeTiersService.PostSubscriptionsProductsMeteredFeesFeeIdTiers";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Post<ProductMeteredTierFee>("/subscriptions/products/metered-fees/{feeId}/tiers",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostSubscriptionsProductsMeteredFeesFeeIdTiers", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }


    }
}

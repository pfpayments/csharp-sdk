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
    public interface IWebUiAccountThemeServiceSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete account UI theme
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void DeleteAccountUiThemesAccountId(long accountId, long account, int operationIndex = 0);

        /// <summary>
        /// Delete account UI theme
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteAccountUiThemesAccountIdWithHttpInfo(long accountId, long account, int operationIndex = 0);
        /// <summary>
        /// Delete account theme logo
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void DeleteAccountUiThemesAccountIdLogo(long accountId, long account, int operationIndex = 0);

        /// <summary>
        /// Delete account theme logo
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteAccountUiThemesAccountIdLogoWithHttpInfo(long accountId, long account, int operationIndex = 0);
        /// <summary>
        /// Create account UI theme
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>WebUiAccountTheme</returns>
        WebUiAccountTheme PostAccountUiThemesCreate(long account, Object body, int operationIndex = 0);

        /// <summary>
        /// Create account UI theme
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of WebUiAccountTheme</returns>
        ApiResponse<WebUiAccountTheme> PostAccountUiThemesCreateWithHttpInfo(long account, Object body, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWebUiAccountThemeService : IWebUiAccountThemeServiceSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class WebUiAccountThemeService : IWebUiAccountThemeService
    {

        private PostFinanceCheckout.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="WebUiAccountThemeService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WebUiAccountThemeService(PostFinanceCheckout.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            this.Configuration = configuration;
            this.Client = new PostFinanceCheckout.Client.ApiClient(this.Configuration);
            ExceptionFactory = PostFinanceCheckout.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebUiAccountThemeService"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public WebUiAccountThemeService(PostFinanceCheckout.Client.ISynchronousClient client, PostFinanceCheckout.Client.IReadableConfiguration configuration)
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
        /// Delete account UI theme 
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void DeleteAccountUiThemesAccountId(long accountId, long account, int operationIndex = 0)
        {
            DeleteAccountUiThemesAccountIdWithHttpInfo(accountId, account);
        }

        /// <summary>
        /// Delete account UI theme 
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public PostFinanceCheckout.Client.ApiResponse<Object> DeleteAccountUiThemesAccountIdWithHttpInfo(long accountId, long account, int operationIndex = 0)
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

            localVarRequestOptions.PathParameters.Add("accountId", PostFinanceCheckout.Client.ClientUtils.ParameterToString(accountId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("account", PostFinanceCheckout.Client.ClientUtils.ParameterToString(account)); // header parameter

            localVarRequestOptions.Operation = "WebUiAccountThemeService.DeleteAccountUiThemesAccountId";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/account/ui-themes/{accountId}",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteAccountUiThemesAccountId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Delete account theme logo 
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void DeleteAccountUiThemesAccountIdLogo(long accountId, long account, int operationIndex = 0)
        {
            DeleteAccountUiThemesAccountIdLogoWithHttpInfo(accountId, account);
        }

        /// <summary>
        /// Delete account theme logo 
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public PostFinanceCheckout.Client.ApiResponse<Object> DeleteAccountUiThemesAccountIdLogoWithHttpInfo(long accountId, long account, int operationIndex = 0)
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

            localVarRequestOptions.PathParameters.Add("accountId", PostFinanceCheckout.Client.ClientUtils.ParameterToString(accountId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("account", PostFinanceCheckout.Client.ClientUtils.ParameterToString(account)); // header parameter

            localVarRequestOptions.Operation = "WebUiAccountThemeService.DeleteAccountUiThemesAccountIdLogo";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/account/ui-themes/{accountId}/logo",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteAccountUiThemesAccountIdLogo", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
        /// <summary>
        /// Create account UI theme 
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>WebUiAccountTheme</returns>
        public WebUiAccountTheme PostAccountUiThemesCreate(long account, Object body, int operationIndex = 0)
        {
            PostFinanceCheckout.Client.ApiResponse<WebUiAccountTheme> localVarResponse = PostAccountUiThemesCreateWithHttpInfo(account, body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create account UI theme 
        /// </summary>
        /// <exception cref="PostFinanceCheckout.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="account">Specifies the ID of the account the operation should be executed in.</param>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of WebUiAccountTheme</returns>
        public PostFinanceCheckout.Client.ApiResponse<WebUiAccountTheme> PostAccountUiThemesCreateWithHttpInfo(long account, Object body, int operationIndex = 0)
        {
            // verify the required parameter 'body' is set
            if (body == null)
            {
                throw new PostFinanceCheckout.Client.ApiException(400, "Missing required parameter 'body' when calling WebUiAccountThemeService->PostAccountUiThemesCreate");
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

            localVarRequestOptions.HeaderParameters.Add("account", PostFinanceCheckout.Client.ClientUtils.ParameterToString(account)); // header parameter
            localVarRequestOptions.Data = body;

            localVarRequestOptions.Operation = "WebUiAccountThemeService.PostAccountUiThemesCreate";
            localVarRequestOptions.OperationIndex = operationIndex;

            // set request timeout in seconds
            var requestTimeout = Configuration.Timeout;

            // make the HTTP request
            var localVarResponse = this.Client.Post<WebUiAccountTheme>("/account/ui-themes/create",
                localVarRequestOptions, requestTimeout, Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostAccountUiThemesCreate", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }


    }
}

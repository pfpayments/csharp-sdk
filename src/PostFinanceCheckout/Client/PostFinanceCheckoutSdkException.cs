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

namespace PostFinanceCheckout.Client
{
    /// <summary>
    /// Exception thrown when an internal SDK error occurs.
    /// </summary>
    public class PostFinanceCheckoutSdkException : Exception
    {
        /// <summary>
        /// SDK-specific error code.
        /// </summary>
        public ErrorCode Code { get; }

        /// <summary>
        /// Exception message details.
        /// </summary>
        private readonly string _customMessage;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="code">SDK error code</param>
        /// <param name="message">Exception message details</param>
        public PostFinanceCheckoutSdkException(ErrorCode code, string message) : base()
        {
            this.Code = code;
            this._customMessage = $"Error code: {(int)code.Code}. {message}";
        }

        /// <summary>
        /// Gets the SDK error code.
        /// </summary>
        public ErrorCode GetCode()
        {
            return this.Code;
        }

        /// <summary>
        /// Gets the custom error message.
        /// </summary>
        public override string Message => this._customMessage;
    }
}

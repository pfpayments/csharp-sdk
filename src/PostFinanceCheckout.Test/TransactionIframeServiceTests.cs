using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using PostFinanceCheckout.Model;
using PostFinanceCheckout.Service;
using PostFinanceCheckout.Client;

namespace PostFinanceCheckout.Test
{
    /// <summary>
    /// TransactionIframeService tests
    /// </summary>
    [TestFixture]
    public class TransactionIframeServiceTests
    {
        private TransactionService transactionService;
        private TransactionIframeService transactionIframeService;

        [SetUp]
        public void Init()
        {
            transactionService = new TransactionService(Constants.Config);
            transactionIframeService = new TransactionIframeService(Constants.Config);
        }

        [TearDown]
        public void Cleanup()
        {
        }

        /// <summary>
        /// JavascriptUrl() should create URL for use in Iframe checkout flow javascript
        /// </summary>
        [Test]
        public void JavascriptUrlTest()
        {
            var transaction = transactionService.Create(Constants.SpaceId, Constants.GetTransactionCreate());
            var url = transactionIframeService.JavascriptUrl(Constants.SpaceId, transaction.Id);

            StringAssert.Contains("securityToken", url, "URL must be of a proper format");
        }
    }
}
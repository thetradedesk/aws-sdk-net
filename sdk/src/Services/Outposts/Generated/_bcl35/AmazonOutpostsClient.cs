/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Outposts.Model;
using Amazon.Outposts.Model.Internal.MarshallTransformations;
using Amazon.Outposts.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Outposts
{
    /// <summary>
    /// Implementation for accessing Outposts
    ///
    /// AWS Outposts is a fully-managed service that extends AWS infrastructure, APIs, and
    /// tools to customer premises. By providing local access to AWS-managed infrastructure,
    /// AWS Outposts enables customers to build and run applications on premises using the
    /// same programming interfaces as in AWS Regions, while using local compute and storage
    /// resources for lower latency and local data processing needs.
    /// </summary>
    public partial class AmazonOutpostsClient : AmazonServiceClient, IAmazonOutposts
    {
        private static IServiceMetadata serviceMetadata = new AmazonOutpostsMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonOutpostsClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonOutpostsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonOutpostsConfig()) { }

        /// <summary>
        /// Constructs AmazonOutpostsClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonOutpostsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonOutpostsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonOutpostsClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonOutpostsClient Configuration Object</param>
        public AmazonOutpostsClient(AmazonOutpostsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonOutpostsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonOutpostsClient(AWSCredentials credentials)
            : this(credentials, new AmazonOutpostsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOutpostsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOutpostsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonOutpostsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonOutpostsClient with AWS Credentials and an
        /// AmazonOutpostsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonOutpostsClient Configuration Object</param>
        public AmazonOutpostsClient(AWSCredentials credentials, AmazonOutpostsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonOutpostsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonOutpostsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonOutpostsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOutpostsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOutpostsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonOutpostsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonOutpostsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonOutpostsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonOutpostsClient Configuration Object</param>
        public AmazonOutpostsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonOutpostsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonOutpostsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonOutpostsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonOutpostsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOutpostsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOutpostsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonOutpostsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonOutpostsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonOutpostsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonOutpostsClient Configuration Object</param>
        public AmazonOutpostsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonOutpostsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  CreateOutpost

        /// <summary>
        /// Creates an Outpost.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOutpost service method.</param>
        /// 
        /// <returns>The response from the CreateOutpost service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ServiceQuotaExceededException">
        /// You have exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/CreateOutpost">REST API Reference for CreateOutpost Operation</seealso>
        public virtual CreateOutpostResponse CreateOutpost(CreateOutpostRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOutpostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOutpostResponseUnmarshaller.Instance;

            return Invoke<CreateOutpostResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOutpost operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOutpost operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOutpost
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/CreateOutpost">REST API Reference for CreateOutpost Operation</seealso>
        public virtual IAsyncResult BeginCreateOutpost(CreateOutpostRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOutpostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOutpostResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOutpost operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOutpost.</param>
        /// 
        /// <returns>Returns a  CreateOutpostResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/CreateOutpost">REST API Reference for CreateOutpost Operation</seealso>
        public virtual CreateOutpostResponse EndCreateOutpost(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateOutpostResponse>(asyncResult);
        }

        #endregion
        
        #region  GetOutpost

        /// <summary>
        /// Gets information about the specified Outpost.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOutpost service method.</param>
        /// 
        /// <returns>The response from the GetOutpost service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetOutpost">REST API Reference for GetOutpost Operation</seealso>
        public virtual GetOutpostResponse GetOutpost(GetOutpostRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOutpostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOutpostResponseUnmarshaller.Instance;

            return Invoke<GetOutpostResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOutpost operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOutpost operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOutpost
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetOutpost">REST API Reference for GetOutpost Operation</seealso>
        public virtual IAsyncResult BeginGetOutpost(GetOutpostRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOutpostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOutpostResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetOutpost operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOutpost.</param>
        /// 
        /// <returns>Returns a  GetOutpostResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetOutpost">REST API Reference for GetOutpost Operation</seealso>
        public virtual GetOutpostResponse EndGetOutpost(IAsyncResult asyncResult)
        {
            return EndInvoke<GetOutpostResponse>(asyncResult);
        }

        #endregion
        
        #region  GetOutpostInstanceTypes

        /// <summary>
        /// Lists the instance types for the specified Outpost.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOutpostInstanceTypes service method.</param>
        /// 
        /// <returns>The response from the GetOutpostInstanceTypes service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.NotFoundException">
        /// The specified request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetOutpostInstanceTypes">REST API Reference for GetOutpostInstanceTypes Operation</seealso>
        public virtual GetOutpostInstanceTypesResponse GetOutpostInstanceTypes(GetOutpostInstanceTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOutpostInstanceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOutpostInstanceTypesResponseUnmarshaller.Instance;

            return Invoke<GetOutpostInstanceTypesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOutpostInstanceTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOutpostInstanceTypes operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOutpostInstanceTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetOutpostInstanceTypes">REST API Reference for GetOutpostInstanceTypes Operation</seealso>
        public virtual IAsyncResult BeginGetOutpostInstanceTypes(GetOutpostInstanceTypesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOutpostInstanceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOutpostInstanceTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetOutpostInstanceTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOutpostInstanceTypes.</param>
        /// 
        /// <returns>Returns a  GetOutpostInstanceTypesResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/GetOutpostInstanceTypes">REST API Reference for GetOutpostInstanceTypes Operation</seealso>
        public virtual GetOutpostInstanceTypesResponse EndGetOutpostInstanceTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<GetOutpostInstanceTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListOutposts

        /// <summary>
        /// List the Outposts for your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOutposts service method.</param>
        /// 
        /// <returns>The response from the ListOutposts service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListOutposts">REST API Reference for ListOutposts Operation</seealso>
        public virtual ListOutpostsResponse ListOutposts(ListOutpostsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOutpostsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOutpostsResponseUnmarshaller.Instance;

            return Invoke<ListOutpostsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOutposts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOutposts operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOutposts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListOutposts">REST API Reference for ListOutposts Operation</seealso>
        public virtual IAsyncResult BeginListOutposts(ListOutpostsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOutpostsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOutpostsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOutposts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOutposts.</param>
        /// 
        /// <returns>Returns a  ListOutpostsResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListOutposts">REST API Reference for ListOutposts Operation</seealso>
        public virtual ListOutpostsResponse EndListOutposts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOutpostsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSites

        /// <summary>
        /// Lists the sites for the specified AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSites service method.</param>
        /// 
        /// <returns>The response from the ListSites service method, as returned by Outposts.</returns>
        /// <exception cref="Amazon.Outposts.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.Outposts.Model.ValidationException">
        /// A parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListSites">REST API Reference for ListSites Operation</seealso>
        public virtual ListSitesResponse ListSites(ListSitesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSitesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSitesResponseUnmarshaller.Instance;

            return Invoke<ListSitesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSites operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSites operation on AmazonOutpostsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSites
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListSites">REST API Reference for ListSites Operation</seealso>
        public virtual IAsyncResult BeginListSites(ListSitesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSitesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSitesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSites operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSites.</param>
        /// 
        /// <returns>Returns a  ListSitesResult from Outposts.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/outposts-2019-12-03/ListSites">REST API Reference for ListSites Operation</seealso>
        public virtual ListSitesResponse EndListSites(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSitesResponse>(asyncResult);
        }

        #endregion
        
    }
}
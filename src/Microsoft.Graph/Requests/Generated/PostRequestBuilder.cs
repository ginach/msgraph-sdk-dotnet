// ------------------------------------------------------------------------------
//  Copyright (c) 2016 Microsoft Corporation
//  
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//  
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
//  
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type PostRequestBuilder.
    /// </summary>
    public partial class PostRequestBuilder : BaseRequestBuilder, IPostRequestBuilder
    {

        /// <summary>
        /// Constructs a new PostRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PostRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IPostRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IPostRequest Request(IList<Option> options)
        {
            return new PostRequest(this.RequestUrl, this.Client, options);
        }
        
        /// <summary>
        /// Gets the request builder for InReplyTo.
        /// </summary>
        /// <returns>The <see cref="IPostRequestBuilder"/>.</returns>
        public IPostRequestBuilder InReplyTo
        {
            get
            {
                return new PostRequestBuilder(this.AppendSegmentToRequestUrl("inReplyTo"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Attachments.
        /// </summary>
        /// <returns>The <see cref="IAttachmentsCollectionRequestBuilder"/>.</returns>
        public IAttachmentsCollectionRequestBuilder Attachments
        {
            get
            {
                return new AttachmentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("attachments"), this.Client);
            }
        }
        
        /// <summary>
        /// Gets the request builder for PostForward.
        /// </summary>
        /// <returns>The <see cref="IPostForwardRequestBuilder"/>.</returns>
        public IPostForwardRequestBuilder Forward(
            Recipient toRecipients,
            string comment = null)
        {
            return new PostForwardRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.forward"),
                this.Client,
                toRecipients,
                comment);
        }

        /// <summary>
        /// Gets the request builder for PostReply.
        /// </summary>
        /// <returns>The <see cref="IPostReplyRequestBuilder"/>.</returns>
        public IPostReplyRequestBuilder Reply(
            Post post)
        {
            return new PostReplyRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.reply"),
                this.Client,
                post);
        }
    
    }
}
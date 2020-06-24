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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateWebhook operation.
    /// Updates a webhook.
    /// </summary>
    public partial class UpdateWebhookRequest : AmazonAmplifyRequest
    {
        private string _branchName;
        private string _description;
        private string _webhookId;

        /// <summary>
        /// Gets and sets the property BranchName. 
        /// <para>
        ///  The name for a branch that is part of an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string BranchName
        {
            get { return this._branchName; }
            set { this._branchName = value; }
        }

        // Check to see if BranchName property is set
        internal bool IsSetBranchName()
        {
            return this._branchName != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description for a webhook. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property WebhookId. 
        /// <para>
        ///  The unique ID for a webhook. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string WebhookId
        {
            get { return this._webhookId; }
            set { this._webhookId = value; }
        }

        // Check to see if WebhookId property is set
        internal bool IsSetWebhookId()
        {
            return this._webhookId != null;
        }

    }
}
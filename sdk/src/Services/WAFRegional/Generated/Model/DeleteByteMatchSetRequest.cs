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
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFRegional.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteByteMatchSet operation.
    /// <note> 
    /// <para>
    /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
    /// WAF Classic</a> in the developer guide.
    /// </para>
    ///  
    /// <para>
    ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
    /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
    /// for regional and global use. 
    /// </para>
    ///  </note> 
    /// <para>
    /// Permanently deletes a <a>ByteMatchSet</a>. You can't delete a <code>ByteMatchSet</code>
    /// if it's still used in any <code>Rules</code> or if it still includes any <a>ByteMatchTuple</a>
    /// objects (any filters).
    /// </para>
    ///  
    /// <para>
    /// If you just want to remove a <code>ByteMatchSet</code> from a <code>Rule</code>, use
    /// <a>UpdateRule</a>.
    /// </para>
    ///  
    /// <para>
    /// To permanently delete a <code>ByteMatchSet</code>, perform the following steps:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Update the <code>ByteMatchSet</code> to remove filters, if any. For more information,
    /// see <a>UpdateByteMatchSet</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
    /// parameter of a <code>DeleteByteMatchSet</code> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit a <code>DeleteByteMatchSet</code> request.
    /// </para>
    ///  </li> </ol>
    /// </summary>
    public partial class DeleteByteMatchSetRequest : AmazonWAFRegionalRequest
    {
        private string _byteMatchSetId;
        private string _changeToken;

        /// <summary>
        /// Gets and sets the property ByteMatchSetId. 
        /// <para>
        /// The <code>ByteMatchSetId</code> of the <a>ByteMatchSet</a> that you want to delete.
        /// <code>ByteMatchSetId</code> is returned by <a>CreateByteMatchSet</a> and by <a>ListByteMatchSets</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ByteMatchSetId
        {
            get { return this._byteMatchSetId; }
            set { this._byteMatchSetId = value; }
        }

        // Check to see if ByteMatchSetId property is set
        internal bool IsSetByteMatchSetId()
        {
            return this._byteMatchSetId != null;
        }

        /// <summary>
        /// Gets and sets the property ChangeToken. 
        /// <para>
        /// The value returned by the most recent call to <a>GetChangeToken</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ChangeToken
        {
            get { return this._changeToken; }
            set { this._changeToken = value; }
        }

        // Check to see if ChangeToken property is set
        internal bool IsSetChangeToken()
        {
            return this._changeToken != null;
        }

    }
}
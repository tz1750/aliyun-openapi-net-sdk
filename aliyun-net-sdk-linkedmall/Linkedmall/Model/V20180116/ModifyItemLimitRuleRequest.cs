/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.linkedmall.Transform;
using Aliyun.Acs.linkedmall.Transform.V20180116;

namespace Aliyun.Acs.linkedmall.Model.V20180116
{
    public class ModifyItemLimitRuleRequest : RpcAcsRequest<ModifyItemLimitRuleResponse>
    {
        public ModifyItemLimitRuleRequest()
            : base("linkedmall", "2018-01-16", "ModifyItemLimitRule", "linkedmall", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? upperNum;

		private long? lmActivityId;

		private int? ruleType;

		private long? endTime;

		private string lmItemId;

		private long? beginTime;

		private string subBizCode;

		private long? itemId;

		private string bizId;

		private long? ruleId;

		public int? UpperNum
		{
			get
			{
				return upperNum;
			}
			set	
			{
				upperNum = value;
				DictionaryUtil.Add(QueryParameters, "UpperNum", value.ToString());
			}
		}

		public long? LmActivityId
		{
			get
			{
				return lmActivityId;
			}
			set	
			{
				lmActivityId = value;
				DictionaryUtil.Add(QueryParameters, "LmActivityId", value.ToString());
			}
		}

		public int? RuleType
		{
			get
			{
				return ruleType;
			}
			set	
			{
				ruleType = value;
				DictionaryUtil.Add(QueryParameters, "RuleType", value.ToString());
			}
		}

		public long? EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value.ToString());
			}
		}

		public string LmItemId
		{
			get
			{
				return lmItemId;
			}
			set	
			{
				lmItemId = value;
				DictionaryUtil.Add(QueryParameters, "LmItemId", value);
			}
		}

		public long? BeginTime
		{
			get
			{
				return beginTime;
			}
			set	
			{
				beginTime = value;
				DictionaryUtil.Add(QueryParameters, "BeginTime", value.ToString());
			}
		}

		public string SubBizCode
		{
			get
			{
				return subBizCode;
			}
			set	
			{
				subBizCode = value;
				DictionaryUtil.Add(QueryParameters, "SubBizCode", value);
			}
		}

		public long? ItemId
		{
			get
			{
				return itemId;
			}
			set	
			{
				itemId = value;
				DictionaryUtil.Add(QueryParameters, "ItemId", value.ToString());
			}
		}

		public string BizId
		{
			get
			{
				return bizId;
			}
			set	
			{
				bizId = value;
				DictionaryUtil.Add(QueryParameters, "BizId", value);
			}
		}

		public long? RuleId
		{
			get
			{
				return ruleId;
			}
			set	
			{
				ruleId = value;
				DictionaryUtil.Add(QueryParameters, "RuleId", value.ToString());
			}
		}

        public override ModifyItemLimitRuleResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyItemLimitRuleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

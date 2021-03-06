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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.digitalstore.Model.V20200107;

namespace Aliyun.Acs.digitalstore.Transform.V20200107
{
    public class ListApisResponseUnmarshaller
    {
        public static ListApisResponse Unmarshall(UnmarshallerContext context)
        {
			ListApisResponse listApisResponse = new ListApisResponse();

			listApisResponse.HttpResponse = context.HttpResponse;
			listApisResponse.RequestId = context.StringValue("ListApis.RequestId");
			listApisResponse.Success = context.BooleanValue("ListApis.Success");

			List<ListApisResponse.ListApis_DataItem> listApisResponse_data = new List<ListApisResponse.ListApis_DataItem>();
			for (int i = 0; i < context.Length("ListApis.Data.Length"); i++) {
				ListApisResponse.ListApis_DataItem dataItem = new ListApisResponse.ListApis_DataItem();
				dataItem.Id = context.LongValue("ListApis.Data["+ i +"].Id");
				dataItem.Name = context.StringValue("ListApis.Data["+ i +"].Name");
				dataItem.Code = context.StringValue("ListApis.Data["+ i +"].Code");
				dataItem.Status = context.IntegerValue("ListApis.Data["+ i +"].Status");
				dataItem.Type = context.IntegerValue("ListApis.Data["+ i +"].Type");
				dataItem.Url = context.StringValue("ListApis.Data["+ i +"].Url");

				listApisResponse_data.Add(dataItem);
			}
			listApisResponse.Data = listApisResponse_data;
        
			return listApisResponse;
        }
    }
}

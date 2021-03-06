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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Cdn.Model.V20141111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeDomainMax95BpsDataResponseUnmarshaller
    {
        public static DescribeDomainMax95BpsDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainMax95BpsDataResponse describeDomainMax95BpsDataResponse = new DescribeDomainMax95BpsDataResponse();

			describeDomainMax95BpsDataResponse.HttpResponse = context.HttpResponse;
			describeDomainMax95BpsDataResponse.RequestId = context.StringValue("DescribeDomainMax95BpsData.RequestId");
			describeDomainMax95BpsDataResponse.DomainName = context.StringValue("DescribeDomainMax95BpsData.DomainName");
			describeDomainMax95BpsDataResponse.StartTime = context.StringValue("DescribeDomainMax95BpsData.StartTime");
			describeDomainMax95BpsDataResponse.EndTime = context.StringValue("DescribeDomainMax95BpsData.EndTime");
			describeDomainMax95BpsDataResponse.Max95Bps = context.StringValue("DescribeDomainMax95BpsData.Max95Bps");
			describeDomainMax95BpsDataResponse.DomesticMax95Bps = context.StringValue("DescribeDomainMax95BpsData.DomesticMax95Bps");
			describeDomainMax95BpsDataResponse.OverseasMax95Bps = context.StringValue("DescribeDomainMax95BpsData.OverseasMax95Bps");
        
			return describeDomainMax95BpsDataResponse;
        }
    }
}
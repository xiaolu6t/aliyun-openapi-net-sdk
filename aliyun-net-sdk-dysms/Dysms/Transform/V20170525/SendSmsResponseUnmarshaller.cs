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
using Aliyun.Acs.Sms.Model.V20170525;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Sms.Transform.V20170525
{
    public class SingleSendSmsResponseUnmarshaller
    {
        public static SendSmsResponse Unmarshall(UnmarshallerContext context)
        {
            SendSmsResponse sendSmsResponse = new SendSmsResponse();

            sendSmsResponse.HttpResponse = context.HttpResponse;
            sendSmsResponse.RequestId = context.StringValue("SendSms.RequestId");
            sendSmsResponse.Code = context.StringValue("SendSms.Code");
            sendSmsResponse.Message = context.StringValue("SendSms.Message");
            sendSmsResponse.BizId = context.StringValue("SendSms.CodeBizId");

            return sendSmsResponse;
        }
    }
}
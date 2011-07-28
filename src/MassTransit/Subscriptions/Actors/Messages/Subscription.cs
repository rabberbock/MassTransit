// Copyright 2007-2011 Chris Patterson, Dru Sellers, Travis Smith, et. al.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace MassTransit.Subscriptions.Actors.Messages
{
	using System;

	public interface Subscription
	{
		/// <summary>
		/// The instance of the client that created the subscription
		/// </summary>
		Guid PeerId { get; }

		/// <summary>
		/// The message number sent by this client
		/// </summary>
		long MessageNumber { get; }

		/// <summary>
		/// The endpoint where messages should be sent
		/// </summary>
		Uri EndpointUri { get; }

		/// <summary>
		/// The unique ID for this subscription
		/// </summary>
		Guid SubscriptionId { get; }

		/// <summary>
		/// The message name for the subscription
		/// </summary>
		string MessageName { get; }
	}
}
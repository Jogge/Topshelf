﻿// Copyright 2007-2010 The Apache Software Foundation.
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
namespace Topshelf.Shelving
{
	using System;


	/// <summary>
	/// Interface to the service controller
	/// </summary>
	public interface IServiceCoordinator :
		IDisposable
	{
		/// <summary>
		/// Start the services hosted by the coordinator and wait until they have completed starting
		/// before returning to the caller
		/// </summary>
		/// <param name="timeout"></param>
		void Start(TimeSpan timeout);

		/// <summary>
		/// Creates a shelf service using the specified bootstrapper type
		/// </summary>
		/// <param name="serviceName">The name of the service to create</param>
		/// <param name="bootstrapperType">The type of the bootstrapper class for the service</param>
		void CreateShelfService(string serviceName, Type bootstrapperType);

		/// <summary>
		/// Creates a shelf service by name, determining the bootstrapper type by reflection
		/// </summary>
		/// <param name="serviceName">The name of the service to create (should match the folder)</param>
		void CreateShelfService(string serviceName);
	}
}
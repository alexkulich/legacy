/*
   Copyright 2006-2017 Cryptany, Inc.

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

using System;

namespace Cryptany.Common.Settings
{

	/// <summary>
	/// Exception when it will be some conversion error
	/// </summary>
	[global::System.Serializable]
	public class ConvertFromStringException : Exception
	{
		//
		// For guidelines regarding the creation of new exception types, see
		//    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
		// and
		//    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
		//

		/// <summary>
		/// Default constructor
		/// </summary>
		public ConvertFromStringException() { }

		/// <summary>
		/// User-defined message constructor
		/// </summary>
		/// <param name="message"></param>
		public ConvertFromStringException(string message) : base(message) { }

		/// <summary>
		/// User-define message and inner exception constructor
		/// </summary>
		/// <param name="message"></param>
		/// <param name="inner"></param>
		public ConvertFromStringException(string message, Exception inner) : base(message, inner) { }
		/// <summary>
		/// Serializing constructor, derived from System.Exception
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ConvertFromStringException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context)
			: base(info, context) { }
	}

}

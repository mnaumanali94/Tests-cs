/*
 * Tester.PCL
 *
 * This file was automatically generated for Stamplay by APIMATIC v2.0 ( https://apimatic.io ) on 09/08/2016
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Tester.PCL.Http.Client;

using Tester.PCL.Models;
using Tester.PCL;

namespace Tester.PCL.Exceptions
{
    public class GlobalTestException : APIException 
    {
        // These fields hold the values for the public properties.
        private string serverMessage;
        private int serverCode;

        /// <summary>
        /// Represents the server's exception message
        /// </summary>
        [JsonProperty("ServerMessage")]
        public string ServerMessage 
        { 
            get 
            {
                return this.serverMessage; 
            } 
            private set 
            {
                this.serverMessage = value;
            }
        }

        /// <summary>
        /// Represents the server's error code
        /// </summary>
        [JsonProperty("ServerCode")]
        public int ServerCode 
        { 
            get 
            {
                return this.serverCode; 
            } 
            private set 
            {
                this.serverCode = value;
            }
        }

        /// <summary>
        /// Initialization constructor
        /// </summary>
        /// <param name="reason"> The reason for throwing exception </param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects </param>
        public GlobalTestException(string reason, HttpContext context)
            : base(reason, context)
        {
        }
    }
} 
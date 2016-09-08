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
    public class LocalTestException : GlobalTestException 
    {
        // These fields hold the values for the public properties.
        private string secretMessageForEndpoint;

        /// <summary>
        /// Represents the specific endpoint info
        /// </summary>
        [JsonProperty("SecretMessageForEndpoint")]
        public string SecretMessageForEndpoint 
        { 
            get 
            {
                return this.secretMessageForEndpoint; 
            } 
            private set 
            {
                this.secretMessageForEndpoint = value;
            }
        }

        /// <summary>
        /// Initialization constructor
        /// </summary>
        /// <param name="reason"> The reason for throwing exception </param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects </param>
        public LocalTestException(string reason, HttpContext context)
            : base(reason, context)
        {
        }
    }
} 
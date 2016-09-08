/*
 * Tester.PCL
 *
 * This file was automatically generated for Stamplay by APIMATIC v2.0 ( https://apimatic.io ) on 09/08/2016
 */
using System;
using Tester.PCL.Controllers;
using Tester.PCL.Http.Client;

namespace Tester.PCL
{
    public partial class TesterClient: ITesterClient
    {

        /// <summary>
        /// Singleton access to ResponseTypes controller
        /// </summary>
        public IResponseTypesController ResponseTypes
        {
            get
            {
                return Tester.PCL.Controllers.ResponseTypesController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to ErrorCodes controller
        /// </summary>
        public IErrorCodesController ErrorCodes
        {
            get
            {
                return Tester.PCL.Controllers.ErrorCodesController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to BodyParams controller
        /// </summary>
        public IBodyParamsController BodyParams
        {
            get
            {
                return Tester.PCL.Controllers.BodyParamsController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to FormParams controller
        /// </summary>
        public IFormParamsController FormParams
        {
            get
            {
                return Tester.PCL.Controllers.FormParamsController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Echo controller
        /// </summary>
        public IEchoController Echo
        {
            get
            {
                return Tester.PCL.Controllers.EchoController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Header controller
        /// </summary>
        public IHeaderController Header
        {
            get
            {
                return Tester.PCL.Controllers.HeaderController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to QueryParam controller
        /// </summary>
        public IQueryParamController QueryParam
        {
            get
            {
                return Tester.PCL.Controllers.QueryParamController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to TemplateParams controller
        /// </summary>
        public ITemplateParamsController TemplateParams
        {
            get
            {
                return Tester.PCL.Controllers.TemplateParamsController.Instance;
            }
        }

        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        
        /// <summary>
        /// Default constructor
        /// </summary>
        public TesterClient() { }
    }
}
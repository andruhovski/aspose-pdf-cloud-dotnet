// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Configuration.cs">
//   Copyright (c) 2024 Aspose.PDF Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Aspose.Pdf.Cloud.Sdk.Client
{
    /// <summary>
    /// Represents a set of configuration settings
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// Initializes a new instance of the Configuration class with different settings
        /// </summary>
        /// <param name="selfHost">The self-host flag.</param>
        /// <param name="apiKey">The api key.</param>
        /// <param name="appSid">The app SID.</param>
        /// <param name="basePath">The base path.</param>
        /// <param name="defaultHeader">Dictionary of default HTTP header.</param>
        /// <param name="tempFolderPath">Temp folder path.</param>
        /// <param name="dateTimeFormat">DateTime format string.</param>
        /// <param name="timeout">HTTP connection timeout (in milliseconds).</param>
        /// <param name="userAgent">HTTP user agent.</param>
        public Configuration(
            bool selfHost,
            string apiKey,
            string appSid,
            string basePath = "https://api.aspose.cloud/v3.0",
            Dictionary<string, string> defaultHeader = null,
            string tempFolderPath = null,
            string dateTimeFormat = null,
            int timeout = 5 * 60 * 1000,
            string userAgent = "aspose pdf cloud sdk"
        )
        {
            SelfHost = selfHost;
            ApiKey = apiKey;
            AppSid = appSid;
            BasePath = basePath;
            UserAgent = userAgent;
            if (defaultHeader != null)
                DefaultHeader = defaultHeader;
            TempFolderPath = tempFolderPath;
            DateTimeFormat = dateTimeFormat;
            Timeout = timeout;
        }

        /// <summary>
        /// Default creation of exceptions for a given method name and response object
        /// </summary>
        public static readonly ExceptionFactory DefaultExceptionFactory = (methodName, response) =>
        {
            int status = (int) response.StatusCode;
            if (status >= 400)
                return new ApiException(status, string.Format("Error calling {0}: {1}", methodName, response.Content), response.Content);
            if (status == 0)
                return new ApiException(status, string.Format("Error calling {0}: {1}", methodName, response.ErrorMessage), response.ErrorMessage);
            return null;
        };

        /// <summary>
        /// Gets or sets the HTTP timeout (milliseconds). Default to 100000 milliseconds.
        /// </summary>
        /// <value>Timeout.</value>
        public int Timeout { get; set; }

        /// <summary>
        /// Gets or sets the SelfHost flag.
        /// </summary>
        public bool SelfHost { get; set; }

        /// <summary>
        /// Gets or sets the api key.
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets or sets the app sid.
        /// </summary>
        public string AppSid { get; set; }

        /// <summary>
        /// Gets or sets the base path.
        /// </summary>
        public string BasePath { get; set; }

        private Dictionary<string, string> _defaultHeaderMap = new Dictionary<string, string>();

        /// <summary>
        /// Gets or sets the default header.
        /// </summary>
        public Dictionary<string, string> DefaultHeader
        {
            get { return _defaultHeaderMap; }
            set
            {
                _defaultHeaderMap = value;
            }
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        public void AddDefaultHeader(string key, string value)
        {
            _defaultHeaderMap[key] = value;
        }

        /// <summary>
        /// Gets or sets the HTTP user agent.
        /// </summary>
        /// <value>Http user agent.</value>
        public string UserAgent { get; set; }

        private string _tempFolderPath;

        /// <summary>
        /// Gets or sets the temporary folder path to store the files downloaded from the server.
        /// </summary>
        /// <value>Folder path.</value>
        public string TempFolderPath
        {
            get
            {
                // default to Path.GetTempPath() if _tempFolderPath is not set
                if (string.IsNullOrEmpty(_tempFolderPath))
                {
                    _tempFolderPath = Path.GetTempPath();
                }
                return _tempFolderPath;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _tempFolderPath = value;
                    return;
                }

                // create the directory if it does not exist
                if (!Directory.Exists(value))
                    Directory.CreateDirectory(value);

                // check if the path contains directory separator at the end
                if (value[value.Length - 1] == Path.DirectorySeparatorChar)
                    _tempFolderPath = value;
                else
                    _tempFolderPath = value  + Path.DirectorySeparatorChar;
            }
        }

        private const string ISO8601_DATETIME_FORMAT = "o";

        private string _dateTimeFormat = ISO8601_DATETIME_FORMAT;

        /// <summary>
        /// Gets or sets the the date time format used when serializing in the ApiClient
        /// By default, it's set to ISO 8601 - "o", for others see:
        /// https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx
        /// and https://msdn.microsoft.com/en-us/library/8kb3ddd4(v=vs.110).aspx
        /// No validation is done to ensure that the string you're providing is valid
        /// </summary>
        /// <value>The DateTimeFormat string</value>
        public string DateTimeFormat
        {
            get
            {
                return _dateTimeFormat;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    // Never allow a blank or null string, go back to the default
                    _dateTimeFormat = ISO8601_DATETIME_FORMAT;
                    return;
                }

                // Caution, no validation when you choose date time format other than ISO 8601
                // Take a look at the above links
                _dateTimeFormat = value;
            }
        }

        /// <summary>
        /// Returns a string with essential information for debugging.
        /// </summary>
        public static string ToDebugReport()
        {
            string report = "C# SDK (Aspose.Pdf.Cloud.Sdk) Debug Report:\n";
            report += "    OS: " + Environment.OSVersion + "\n";
            report += "    .NET Framework Version: " + Assembly
                     .GetExecutingAssembly()
                     .GetReferencedAssemblies()
                     .Where(x => x.Name == "System.Core").First().Version.ToString()  + "\n";
            report += "    Version of the API: 3.0\n";
            report += "    SDK Package Version: 24.11.0\n";

            return report;
        }
    }
}

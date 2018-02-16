﻿using Avalara.AvaTax.RestClient;
using CommandLine;
using System;

namespace CoreConnect
{
    public class Options
    {
        [Option(shortName: 'u', Required = true, HelpText = "Username for AvaTax.")]
        public string Username { get; set; }

        [Option(shortName: 'p', Required = true, HelpText = "Password for AvaTax.")]
        public string Password { get; set; }

        [Option(shortName: 'c', Default = "DEFAULT", Required = true, HelpText = "CompanyCode to use when contacting AvaTax.  If not specified, uses 'DEFAULT'.")]
        public string CompanyCode { get; set; }

        [Option(shortName: 'd', Required = false, Default = true, HelpText = "Discard first API call.  The first API call includes lots of overhead.")]
        public bool? DiscardFirstCall { get; set; }

        [Option(shortName: 'e', Default = "https://sandbox-rest.avatax.com", Required = false, HelpText = "URL of the AvaTax environment to call.")]
        public string Environment { get; set; }

        [Option(shortName: 'y', Default = DocumentType.SalesOrder, Required = false, HelpText = "Type of document to create.")]
        public DocumentType DocType { get; set; }

        [Option(shortName: 'l', Default = 1, Required = false, HelpText = "Number of lines to include in each tax transaction.")]
        public int Lines { get; set; }

        [Option(shortName: 'x', Default = false, Required = false, HelpText = "Log only exceptional delays")]
        public bool LogExceptionalDelays { get; set; }

        [Option(shortName: 's', Default = 0, Required = false, HelpText = "Milliseconds to sleep between calls")]
        public int SleepBetweenCalls { get; set; }

        [Option(shortName: 't', Default = 1, Required = false, HelpText = "Number of threads to create")]
        public int Threads { get; set; }

        [Option(Required = false, HelpText = "Number of API calls to execute before finishing.  Default is forever.")]
        public int? Calls { get; set; }

        /// <summary>
        /// Returns true if the options are valid
        /// </summary>
        public bool IsValid()
        {
            return (!String.IsNullOrEmpty(Username) && !String.IsNullOrEmpty(Password));
        }
    }
}

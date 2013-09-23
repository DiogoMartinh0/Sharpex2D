﻿using System;

namespace SharpexGL.Framework.Plugins
{
    public class PluginException : Exception
    {
        private string _message = "";
        public override string Message
        {
            get
            {
                return _message;
            }
        }
        /// <summary>
        /// Initializes a new PluginException.
        /// </summary>
        public PluginException()
        {
        }
        /// <summary>
        /// Initializes a new PluginException.
        /// </summary>
        /// <param name="message">The Message.</param>
        public PluginException(string message)
        {
            _message = message;
        }
    }
}
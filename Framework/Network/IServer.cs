﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpexGL.Framework.Components;
using SharpexGL.Framework.Game;
using SharpexGL.Framework.Network.Listener;
using SharpexGL.Framework.Network.Packages;

namespace SharpexGL.Framework.Network
{
    public interface IServer : IGameHandler
    {
        /// <summary>
        /// Subscribes the Listener to the Server.
        /// </summary>
        /// <param name="subscriber">The Listener.</param>
        void Subscribe(IServerListener subscriber);
        /// <summary>
        /// Unsubscribes the Listener from the Server.
        /// </summary>
        /// <param name="unsubscriber">The Unsubscriber.</param>
        void Unsubscribe(IServerListener unsubscriber);
    }
}
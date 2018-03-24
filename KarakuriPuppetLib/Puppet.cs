﻿using WebSocketSharp.Server;

namespace KarakuriPuppetLib
{
    public partial class Puppet
    {
        private WebSocketServer _webSocketServer;
        private string _ip;
        private int _port;
        private string _token;
        private IPuppetState _puppetState = PuppetStateStoped.GetInstance();

        /// <summary>
        /// Start Websocket Server
        /// </summary>
        /// <param name="ip">Listen IPAddress</param>
        /// <param name="port">Port</param>
        /// <param name="token">Password for connecting server</param>
        public void Start(string ip, int port, string token)
        {
            _token = token;
            _port = port;
            _ip = ip;
            _puppetState = _puppetState.Start(this);
        }

        /// <summary>
        /// Stop Websocket Server
        /// </summary>
        public void Stop()
        {
            _puppetState = _puppetState.Stop(this);
        }
    }
}

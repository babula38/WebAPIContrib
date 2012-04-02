﻿using System.Net.Http.Headers;

namespace WebApiContrib.Internal
{
    public static class MediaTypeConstants
    {
        private static readonly MediaTypeHeaderValue _applicationJson = new MediaTypeHeaderValue("application/json");

        public static MediaTypeHeaderValue ApplicationJson { get { return _applicationJson; } }
    }
}
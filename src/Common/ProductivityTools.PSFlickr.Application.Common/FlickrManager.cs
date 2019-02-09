﻿using FlickrNet;
using PSFlickr.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.PSFlickr.Application.Common
{
    public class FlickrManager
    {
        //public const string ApiKey = "b1714ae904a921ba7349c787b88f4bf7";
        //public const string SharedSecret = "176531a9c388f832";

        private static string ApiKey
        {
            get
            {
                return new Config().ApiKey;
            }
        }

        private static string SharedSecret
        {
            get
            {
                return new Config().SharedSecret;
            }
        }

        public static Flickr GetInstance()
        {
            return new Flickr(ApiKey, SharedSecret);
        }

        public static Flickr GetInstanceAutenticated(string token)
        {
            return new Flickr(ApiKey, SharedSecret, token);
        }

        //public static Flickr GetAuthInstance()
        //{
        //    var f = new Flickr(ApiKey, SharedSecret);
        //    f.OAuthAccessToken = OAuthToken.Token;
        //    f.OAuthAccessTokenSecret = OAuthToken.TokenSecret;
        //    return f;
        //}

    }
}

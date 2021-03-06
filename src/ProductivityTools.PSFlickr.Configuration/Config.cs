﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSFlickr.Configuration
{

    public class Config
    {
        ProductivityTools.MasterConfiguration.MConfiguration conf;
        public Config()
        {
            conf = new ProductivityTools.MasterConfiguration.MConfiguration();
            conf.SetApplicationName("PSFlickr");
            conf.SetConfigurationFileName("MasterConfiguration.xml");
            conf.SetConfigurationFileDirectory(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));
        }

        private string GetValue(string s)
        {
            var r = conf[s];
            return r;
        }

        public string ApiKey
        {
            get
            {
                return GetValue("ApiKey");
            }
        }

        public string PhotoTypes
        {
            get
            {
                return GetValue("PhotoTypes");
            }
        }

        public string MaintenanceAlbumName
        {
            get
            {
                return GetValue("MaintananceAlbumName");
            }
        }

        public string SharedSecret
        {
            get
            {
                return GetValue("SharedSecret");
            }
        }

        public string OauthAccessTokenToken
        {
            get
            {
                var x = conf["AccessToken"];
                return x;
            }
            set
            {
                conf.SetValue("AccessToken", value);
            }
        }

        public string OauthAccessTokenTokenSecret
        {
            get
            {
                var x = conf["AccessTokenSecret"];
                return x;
            }
            set
            {
                conf.SetValue("AccessTokenSecret", value);
            }
        }

        //public string CoverPhotoId
        //{
        //    get
        //    {
        //        var x = conf["CoverPhotoId"];
        //        return x;
        //    }
        //    set
        //    {
        //        conf.SetValue("CoverPhotoId", value);
        //    }
        //}


    }
    //public class Config : IConfig
    //{
    //    public string DataSource
    //    {
    //        get
    //        {
    //            return @".\sql2017";
    //        }
    //    }
    //    public string DatabaseName
    //    {
    //        get
    //        {
    //            return "FlickrTest";
    //        }
    //    }
    //}
}

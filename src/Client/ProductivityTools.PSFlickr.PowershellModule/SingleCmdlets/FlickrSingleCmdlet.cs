﻿using ProductivityTools.PSFlickr.Application.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.PSFlickr.PowershellModule.SingleCmdlets
{
    public abstract class FlickrSingleCmdlet: System.Management.Automation.PSCmdlet
    {
        protected FlickrOperations FlickrOperation;

        public FlickrSingleCmdlet()
        {
            FlickrOperation = FlickrOperationsFactory.GetFlickrOperations(WriteVerbose);
        }
    }
}
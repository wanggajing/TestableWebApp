﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestableWebApp.Presenters.Results
{
    public class RedirectResult:IResult
    {
        private string url;
        public RedirectResult(string urlValue)
        {
            this.url = urlValue;
        }
        public string Url
        {
            get
            {
                return url;
            }
        }
    }
}
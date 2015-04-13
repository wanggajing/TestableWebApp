using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestableWebApp.Models;
using TestableWebApp.Models.Repository;
using TestableWebApp.Presenters.Results;

namespace TestableWebApp.Presenters
{
    public class RSVPPresenter:IPresenter<GuestResponse>
    {
        public IRepository repository { get; set; }
        Results.IResult IPresenter<GuestResponse>.GetResult()
        {
            return new DataResult<GuestResponse>(new GuestResponse());
        }

        Results.IResult IPresenter<GuestResponse>.GetResult(GuestResponse requestData)
        {
            repository.AddResponse(requestData);
            if (requestData.WillAttend.Value)
            {
                return new RedirectResult("/Content/seeyouthere.html");
            }
            else
            {
                return new RedirectResult("/Content/sorryyoucantcome.html");
            }
        }
    }
}
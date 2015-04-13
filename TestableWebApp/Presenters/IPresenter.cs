using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestableWebApp.Presenters.Results;

namespace TestableWebApp.Presenters
{
    public interface IPresenter<T>
    {
        IResult GetResult();
        IResult GetResult(T requestData);
    }
}
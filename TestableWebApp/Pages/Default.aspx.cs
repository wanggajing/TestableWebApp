using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestableWebApp.Models;
using TestableWebApp.Models.Repository;
using TestableWebApp.Presenters;

namespace TestableWebApp.Pages
{
    public partial class Default : System.Web.UI.Page
    {
        public IPresenter<GuestResponse> presenter;
        protected void Page_Load(object sender, EventArgs e)
        {
            presenter = new RSVPPresenter {repository=new MemoryRepository()};
            if (IsPostBack)
            {

            }
        }
    }
}
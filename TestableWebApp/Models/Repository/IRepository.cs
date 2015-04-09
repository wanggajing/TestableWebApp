using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestableWebApp.Models.Repository
{
    interface IRepository
    {
        IEnumerable<GuestResponse> GetAllResponse();
        void AddResponse(GuestResponse response);
    }
}

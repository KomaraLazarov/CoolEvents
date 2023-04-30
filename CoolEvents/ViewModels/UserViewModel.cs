using CoolEvents.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoolEvents.ViewModels
{
    public class UserViewModel
    {
        public int currentPageIndex { get; set; }
        public int pageCount { get; set; }

        public IEnumerable<User> userList;
    }
}

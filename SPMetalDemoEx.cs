using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeProject.SharePoint.Demo
{
    public partial class CompanyContact
    {
        public string FullName
        {
            get { return FirstName + " " + LastName;  }
        }
    }
}

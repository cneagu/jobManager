using JobManagementTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobManagementTest
{
    //custom EventArgs Class
    public class JobChangedEventArgs : EventArgs
    {
        public Job Job { get; set; }
    }
}

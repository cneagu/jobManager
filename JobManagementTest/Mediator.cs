using JobManagementTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobManagementTest
{
    public sealed class Mediator
    {
        //static members, singleton functionality
        private static readonly Mediator _instance = new Mediator(); //single instance, created only one time
        private Mediator() { } //hide the constructor

        public static Mediator GetInstance()
        {
            return _instance;
        }

        //Instance Functionality
        public event EventHandler<JobChangedEventArgs> JobChanged; //delegate that handle event

        public void OnJobChanged(object sender, Job job)
        {
            var jobChangeDelegate = JobChanged as EventHandler<JobChangedEventArgs>;
            if(jobChangeDelegate != null)
            {
                jobChangeDelegate(sender, new JobChangedEventArgs { Job = job });
            }
        }
    }
}

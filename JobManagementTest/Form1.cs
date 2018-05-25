using JobManagementTest.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobManagementTest
{
    public partial class JobManagementForm : Form
    {
        List<Job> _Jobs = new List<Job>
        {
           new Job { ID = 1, Title = "Area 1 Maintenance", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(1) },
           new Job { ID = 2, Title = "Edge Park", StartDate = DateTime.Now.AddDays(-5), EndDate = DateTime.Now.AddDays(5)  },
           new Job { ID = 3, Title = "Paint Benches", StartDate = DateTime.Now.AddDays(4), EndDate = DateTime.Now.AddDays(10)  },
           new Job { ID = 4, Title = "Build New Wall", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(15)  }
        };

        List<Employee> _Employees = new List<Employee> {
            new Employee { ID = 1, Name = "John Doe", Jobs = new List<Job>
                            {
                                new Job { ID = 1, Title = "Area 1 Maintenance" },
                                new Job { ID = 2, Title = "Edge Park" },
                                new Job { ID = 3, Title = "Paint Benches" },
                                new Job { ID = 4, Title = "Build New Wall" }
                            }
            },
            new Employee { ID = 2, Name = "Jane Doe", Jobs = new List<Job>
                            {
                                new Job { ID = 3, Title = "Paint Benches" },
                                new Job { ID = 4, Title = "Build New Wall" }
                            }
            },
            new Employee { ID = 3, Name = "Michelle Davis", Jobs = new List<Job>
                            {
                                new Job { ID = 1, Title = "Area 1 Maintenance" },
                                new Job { ID = 3, Title = "Paint Benches" }
                            }
            },
        };

        BindingSource bindingSourceJobs = new BindingSource();
        BindingSource bindingSourceEmployees = new BindingSource();

        public JobManagementForm()
        {
            InitializeComponent();
            JobsBindData();
            Mediator.GetInstance().JobChanged += (s, e) => EmployeesBindData(e.Job);
        }

        private void JobsBindData()
        {
            bindingSourceJobs.DataSource = _Jobs;
            JobsComboBox.DataSource = bindingSourceJobs.DataSource;
            JobsComboBox.DisplayMember = "Title";
            JobsComboBox.ValueMember = "Title";
            IDTextBox.DataBindings.Add("Text", _Jobs, "ID");
            TitleTextBox.DataBindings.Add("Text", _Jobs, "Title");
            StartDateTextBox.DataBindings.Add("Text", _Jobs, "StartDate");
            EndDateTextBox.DataBindings.Add("Text", _Jobs, "EndDate");
        }

        private void EmployeesBindData(Job job)
        {
            var _emps = _Employees.Where(e => e.Jobs.Any(j => j.ID == job.ID)).ToList();
            EmployeesListBox.DataSource = _emps;
            EmployeesListBox.DisplayMember = "Name";
            EmployeeIDTextBox.DataBindings.Clear();
            EmployeeIDTextBox.DataBindings.Add("Text", _emps, "ID");
            EmployeeNameTextBox.DataBindings.Clear();
            EmployeeNameTextBox.DataBindings.Add("Text", _emps, "Name");

            JobsListBox.DataSource = _emps[0].Jobs;
            JobsListBox.DisplayMember = "Title";

        }

        private void JobsComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Mediator.GetInstance().OnJobChanged(this, (Job)JobsComboBox.SelectedItem);
        }
    }
}

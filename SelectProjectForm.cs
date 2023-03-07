using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using elyticaService;

namespace elytica_c_sharp_diet_app
{
  public partial class SelectProjectForm : Form
  {
    private elyticaService.elyticaService elytica;
    private Dictionary<elyticaService.Application, IList<Project>> application_projects;
    private Dictionary<Project, IList<Job>> project_jobs;
    private elyticaService.Application selected_application;
    private Project selected_project;
    private Job selected_job;
    private string input_file_name;
    public event EventHandler ButtonClicked;

    private void RaiseButtonClicked()
    {
      if (ButtonClicked != null)
        ButtonClicked(this, EventArgs.Empty);
    }

    public SelectProjectForm(elyticaService.elyticaService e)
    {
      InitializeComponent();
      elytica= e;
    }

    public elyticaService.Application GetSelectedApplication()
    {
      return selected_application;
    }
    public Project GetSelectedProject()
    {
      return this.selected_project;
    }

    public Job GetSelectedJob()
    {
      return selected_job;
    }

    public string GetInputFileName()
    {
      return input_file_name;
    }

    private void SelectProjectForm_Load(object sender, EventArgs e)
    {
      IList<elyticaService.Application> applications = elytica.GetApplications();      
      IList<elyticaService.Project> projects = elytica.GetProjects();      
      application_projects = new Dictionary<elyticaService.Application, IList<Project>>();
      project_jobs= new Dictionary<Project, IList<Job>>();
      foreach (var a in applications)
        application_projects[a] = elytica.GetProjects(a);
      foreach (var p in projects)
        project_jobs[p] = elytica.GetJobs(p);

      application_combobox.DataSource = applications;
      application_combobox.DisplayMember = "display_name";
      application_combobox.ValueMember = null;
    }

    private void select_project_button_Click(object sender, EventArgs e)
    {
      selected_application = (elyticaService.Application)application_combobox.SelectedItem;
      selected_project = (Project)this.project_combobox.SelectedItem;
      selected_job = (Job)this.job_combobox.SelectedItem;
      input_file_name = input_file_textbox.Text;
      RaiseButtonClicked();
      this.Close();
    }

    private void application_combobox_SelectedIndexChanged(object sender, EventArgs e)
    {
      project_combobox.DataSource = application_projects[(elyticaService.Application)application_combobox.SelectedItem];
      project_combobox.DisplayMember = "name";
      project_combobox.ValueMember = null;
      if (application_projects[(elyticaService.Application)application_combobox.SelectedItem].Count == 0)
        select_project_button.Enabled = false;      
    }    

    private void project_combobox_SelectedIndexChanged(object sender, EventArgs e)
    {
      job_combobox.DataSource = project_jobs[(Project)project_combobox.SelectedItem];
      job_combobox.DisplayMember = "name";
      job_combobox.ValueMember = null;

      if (project_jobs[(Project)project_combobox.SelectedItem].Count == 0)
        select_project_button.Enabled = false;
      else
        select_project_button.Enabled = true;


    }
  }
}

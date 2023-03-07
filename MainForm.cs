using elyticaService;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Text;
using static elyticaService.elyticaService;

namespace elytica_c_sharp_diet_app
{
  public partial class MainForm : Form
  {
    LoginForm login_form = new LoginForm();
    SelectProjectForm project_select_form;
    elyticaService.elyticaService elytica = new elyticaService.elyticaService();
    Job active_job;
    DataInterface data_interface = new DataInterface();
    public MainForm()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {      
      login_form.connect_btn_clicked += LoginCallback;
      login_form.ShowDialog();
    }

    private void CreateFoodInputTable()
    {
      DataTable table = new DataTable();
      table.Columns.Add("Food", typeof(string));
      table.Columns.Add("Unit Portion (g)", typeof(string));
      table.Columns.Add("Unit Cost (EUR/g)", typeof(string));
      table.Columns.Add("Calories (kcal)", typeof(string));
      table.Columns.Add("Fat (g)", typeof(string));
      table.Columns.Add("Carbohydrates (g)", typeof(string));
      table.Columns.Add("Protein (g)", typeof(string));
      table.Columns.Add("Calcium (mg)", typeof(string));
      table.Columns.Add("Potassium (mg)", typeof(string));
      table.Columns.Add("Vitamin A (mg)", typeof(string));
      table.Columns.Add("Vitamin B6 (mg)", typeof(string));

      foreach (var f in data_interface.input_data.Food)
      {
        var row = table.NewRow();
        row["Food"] = f.Name;
        row["Unit Portion (g)"] = f.UnitPortion;
        row["Unit Cost (EUR/g)"] = f.UnitCost;
        row["Calories (kcal)"] = f.Calories;
        row["Fat (g)"] = f.Fat;
        row["Carbohydrates (g)"] = f.Carbohydrates;
        row["Protein (g)"] = f.Protein;
        row["Calcium (mg)"] = f.Calcium;
        row["Potassium (mg)"] = f.Potassium;
        row["Vitamin A (mg)"] = f.VitaminA;
        row["Vitamin B6 (mg)"] = f.VitaminB6;
        table.Rows.Add(row);  
      }
      food_input_datagrid.DataSource = table;
    }

    private void ReadFromFoodInputTable()
    {      
      data_interface.input_data.Food = new FoodItem[food_input_datagrid.Rows.Count - 1];
      for (int i = 0; i < food_input_datagrid.Rows.Count - 1; i++)
      {
        DataGridViewRow row = food_input_datagrid.Rows[i] as DataGridViewRow;
        FoodItem food = new FoodItem();
        food.Name = row.Cells["Food"].Value.ToString();
        food.UnitPortion = Convert.ToDouble(row.Cells["Unit Portion (g)"].Value);
        food.UnitCost = Convert.ToDouble(row.Cells["Unit Cost (EUR/g)"].Value);
        food.Calories = Convert.ToDouble(row.Cells["Calories (kcal)"].Value);
        food.Fat = Convert.ToDouble(row.Cells["Fat (g)"].Value);
        food.Carbohydrates = Convert.ToDouble(row.Cells["Carbohydrates (g)"].Value);
        food.Protein = Convert.ToDouble(row.Cells["Protein (g)"].Value);
        food.Calcium = Convert.ToDouble(row.Cells["Calcium (mg)"].Value);
        food.Potassium = Convert.ToDouble(row.Cells["Potassium (mg)"].Value);
        food.VitaminA = Convert.ToDouble(row.Cells["Vitamin A (mg)"].Value);
        food.VitaminB6 = Convert.ToDouble(row.Cells["Vitamin B6 (mg)"].Value);
        data_interface.input_data.Food[i] = food;
      }
    }

    private void ReadFromNutrientInputTable()
    {
      data_interface.input_data.Nutrients = new Nutrient[nutrient_input_datagrid.Rows.Count - 1];
      for (int i = 0; i < nutrient_input_datagrid.Rows.Count - 1; i++)
      {
        DataGridViewRow row = nutrient_input_datagrid.Rows[i] as DataGridViewRow;        
        Nutrient nutrient = new Nutrient();
        nutrient.Name = row.Cells["Nutrient"].Value.ToString();
        nutrient.Minimum = Convert.ToDouble(row.Cells["Minimum"].Value);
        nutrient.Maximum = Convert.ToDouble(row.Cells["Maximum"].Value);
        data_interface.input_data.Nutrients[i] = nutrient;
      }
    }

    private void CreateNutrientInputTable()
    {
      DataTable table = new DataTable();
      table.Columns.Add("Nutrient", typeof(string));
      table.Columns.Add("Minimum", typeof(string));
      table.Columns.Add("Maximum", typeof(string));      
      foreach (var n in data_interface.input_data.Nutrients)
      {
        var row = table.NewRow();
        row["Nutrient"] = n.Name;
        row["Minimum"] = n.Minimum;
        row["Maximum"] = n.Maximum;        
        table.Rows.Add(row);
      }
      nutrient_input_datagrid.DataSource = table;
    }

    private void LoginCallback(object sender, EventArgs args)
    {
      login_form.Hide();
      if (elytica.Login(login_form.GetAccessToken()))
      {
        project_select_form = new SelectProjectForm(elytica);
        project_select_form.ButtonClicked += SelectProjectCallback;
        project_select_form.ShowDialog(this);
      }
      else
      {
        MessageBox.Show(@"Invalid access token.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        this.Close();
      }
    }

    private void SelectProjectCallback(object sender, EventArgs args)
    {
      active_job = project_select_form.GetSelectedJob();
      elytica.SetActiveJob(active_job, UpdateConsole, IsCompleted);      
      string json_str = elytica.GetActiveJobInputFile(project_select_form.GetInputFileName());
      if (json_str != null)
        data_interface.ParseJsonInputString(json_str);
      CreateFoodInputTable();
      CreateNutrientInputTable();
      project_select_form.Close();
    }

    private void UpdateConsole(string stdout)
    {
      elytica_console_textbox.Invoke((Action)delegate
      {
        elytica_console_textbox.AppendText(stdout);
      });
    }

    private void PopulateResultGrid()
    {
      DataTable table = new DataTable();
      table.Columns.Add("Food", typeof(string));
      table.Columns.Add("Portions", typeof(string));
      foreach (var d in data_interface.result_data.Diet)
      {
        var row = table.NewRow();
        row["Food"] = d.Food;
        row["Portions"] = d.Portions;        
        table.Rows.Add(row);
      }
      result_datagrid.DataSource = table;
    }

    private void IsCompleted(bool finished)
    {
      if (!finished) return;
      string json_str = elytica.GetActiveJobResults();
      if (json_str != null)
        data_interface.ParseJsonResultString(json_str);
      result_datagrid.Invoke((Action)delegate
      {
        PopulateResultGrid();
      });

      solve_button.Invoke((Action)delegate
      {
        solve_button.Enabled = true;
      });

    }

    private void UploadJobInputFile()
    {
      uint argument_no = 2; //the model file is always the first argument      
      string json_str = data_interface.GetDataJsonString();
      byte[] json_bytes = Encoding.UTF8.GetBytes(json_str.ToString());
      string fname = project_select_form.GetInputFileName();
      elytica.UploadActiveJobInputFile(fname, json_bytes, argument_no);      
    }

    private void solve_button_Click(object sender, EventArgs e)
    {
      solve_button.Enabled= false;
      elytica_console_textbox.Text = "";
      ReadFromFoodInputTable();
      ReadFromNutrientInputTable();
      UploadJobInputFile();
      elytica.QueueActiveJob().Wait();
    }
  }
}
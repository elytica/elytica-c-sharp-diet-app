namespace elytica_c_sharp_diet_app
{
  partial class SelectProjectForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.application_combobox = new System.Windows.Forms.ComboBox();
      this.project_combobox = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.select_project_button = new System.Windows.Forms.Button();
      this.job_combobox = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.input_file_textbox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // application_combobox
      // 
      this.application_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.application_combobox.FormattingEnabled = true;
      this.application_combobox.Location = new System.Drawing.Point(39, 54);
      this.application_combobox.Name = "application_combobox";
      this.application_combobox.Size = new System.Drawing.Size(275, 23);
      this.application_combobox.TabIndex = 0;
      this.application_combobox.SelectedIndexChanged += new System.EventHandler(this.application_combobox_SelectedIndexChanged);
      // 
      // project_combobox
      // 
      this.project_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.project_combobox.FormattingEnabled = true;
      this.project_combobox.Location = new System.Drawing.Point(39, 107);
      this.project_combobox.Name = "project_combobox";
      this.project_combobox.Size = new System.Drawing.Size(275, 23);
      this.project_combobox.TabIndex = 1;
      this.project_combobox.SelectedIndexChanged += new System.EventHandler(this.project_combobox_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(39, 36);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(68, 15);
      this.label1.TabIndex = 2;
      this.label1.Text = "Application";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(39, 89);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(44, 15);
      this.label2.TabIndex = 3;
      this.label2.Text = "Project";
      // 
      // select_project_button
      // 
      this.select_project_button.Location = new System.Drawing.Point(216, 286);
      this.select_project_button.Name = "select_project_button";
      this.select_project_button.Size = new System.Drawing.Size(98, 32);
      this.select_project_button.TabIndex = 4;
      this.select_project_button.Text = "Select";
      this.select_project_button.UseVisualStyleBackColor = true;
      this.select_project_button.Click += new System.EventHandler(this.select_project_button_Click);
      // 
      // job_combobox
      // 
      this.job_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.job_combobox.FormattingEnabled = true;
      this.job_combobox.Location = new System.Drawing.Point(39, 165);
      this.job_combobox.Name = "job_combobox";
      this.job_combobox.Size = new System.Drawing.Size(275, 23);
      this.job_combobox.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(39, 147);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(25, 15);
      this.label3.TabIndex = 6;
      this.label3.Text = "Job";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(39, 210);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(54, 15);
      this.label4.TabIndex = 8;
      this.label4.Text = "Input file";
      // 
      // input_file_textbox
      // 
      this.input_file_textbox.Location = new System.Drawing.Point(39, 228);
      this.input_file_textbox.Name = "input_file_textbox";
      this.input_file_textbox.Size = new System.Drawing.Size(275, 23);
      this.input_file_textbox.TabIndex = 7;
      this.input_file_textbox.Text = "diet_problem.json";
      // 
      // SelectProjectForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(363, 343);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.input_file_textbox);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.job_combobox);
      this.Controls.Add(this.select_project_button);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.project_combobox);
      this.Controls.Add(this.application_combobox);
      this.Name = "SelectProjectForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Diet Plan App - Input Selection";
      this.Load += new System.EventHandler(this.SelectProjectForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private ComboBox application_combobox;
    private ComboBox project_combobox;
    private Label label1;
    private Label label2;
    private Button select_project_button;
    private ComboBox job_combobox;
    private Label label3;
    private Label label4;
    private TextBox input_file_textbox;
  }
}
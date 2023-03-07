namespace elytica_c_sharp_diet_app
{
  partial class MainForm
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.food_input_datagrid = new System.Windows.Forms.DataGridView();
      this.elytica_console_textbox = new System.Windows.Forms.RichTextBox();
      this.nutrient_input_datagrid = new System.Windows.Forms.DataGridView();
      this.solve_button = new System.Windows.Forms.Button();
      this.result_datagrid = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.food_input_datagrid)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nutrient_input_datagrid)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.result_datagrid)).BeginInit();
      this.SuspendLayout();
      // 
      // food_input_datagrid
      // 
      this.food_input_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.food_input_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.food_input_datagrid.Location = new System.Drawing.Point(33, 26);
      this.food_input_datagrid.Name = "food_input_datagrid";
      this.food_input_datagrid.RowTemplate.Height = 25;
      this.food_input_datagrid.Size = new System.Drawing.Size(636, 210);
      this.food_input_datagrid.TabIndex = 0;
      // 
      // elytica_console_textbox
      // 
      this.elytica_console_textbox.BackColor = System.Drawing.SystemColors.WindowText;
      this.elytica_console_textbox.ForeColor = System.Drawing.SystemColors.HighlightText;
      this.elytica_console_textbox.Location = new System.Drawing.Point(352, 255);
      this.elytica_console_textbox.Name = "elytica_console_textbox";
      this.elytica_console_textbox.Size = new System.Drawing.Size(317, 210);
      this.elytica_console_textbox.TabIndex = 1;
      this.elytica_console_textbox.Text = "";
      // 
      // nutrient_input_datagrid
      // 
      this.nutrient_input_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.nutrient_input_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.nutrient_input_datagrid.Location = new System.Drawing.Point(33, 255);
      this.nutrient_input_datagrid.Name = "nutrient_input_datagrid";
      this.nutrient_input_datagrid.RowTemplate.Height = 25;
      this.nutrient_input_datagrid.Size = new System.Drawing.Size(299, 210);
      this.nutrient_input_datagrid.TabIndex = 2;
      // 
      // solve_button
      // 
      this.solve_button.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.solve_button.Location = new System.Drawing.Point(33, 515);
      this.solve_button.Name = "solve_button";
      this.solve_button.Size = new System.Drawing.Size(299, 68);
      this.solve_button.TabIndex = 3;
      this.solve_button.Text = "Solve";
      this.solve_button.UseVisualStyleBackColor = true;
      this.solve_button.Click += new System.EventHandler(this.solve_button_Click);
      // 
      // result_datagrid
      // 
      this.result_datagrid.AllowUserToAddRows = false;
      this.result_datagrid.AllowUserToDeleteRows = false;
      this.result_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.result_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.result_datagrid.Location = new System.Drawing.Point(352, 481);
      this.result_datagrid.Name = "result_datagrid";
      this.result_datagrid.RowTemplate.Height = 25;
      this.result_datagrid.Size = new System.Drawing.Size(317, 132);
      this.result_datagrid.TabIndex = 4;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(700, 625);
      this.Controls.Add(this.result_datagrid);
      this.Controls.Add(this.solve_button);
      this.Controls.Add(this.nutrient_input_datagrid);
      this.Controls.Add(this.elytica_console_textbox);
      this.Controls.Add(this.food_input_datagrid);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Diet Plan App";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.food_input_datagrid)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nutrient_input_datagrid)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.result_datagrid)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DataGridView food_input_datagrid;
    private RichTextBox elytica_console_textbox;
    private DataGridView nutrient_input_datagrid;
    private Button solve_button;
    private DataGridView result_datagrid;
  }
}
namespace elytica_c_sharp_diet_app
{
  partial class LoginForm
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
      this.access_token_textbox = new System.Windows.Forms.RichTextBox();
      this.connect_button = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // access_token_textbox
      // 
      this.access_token_textbox.Location = new System.Drawing.Point(65, 29);
      this.access_token_textbox.Name = "access_token_textbox";
      this.access_token_textbox.Size = new System.Drawing.Size(346, 227);
      this.access_token_textbox.TabIndex = 0;
      this.access_token_textbox.Text = "";
      // 
      // connect_button
      // 
      this.connect_button.Location = new System.Drawing.Point(293, 276);
      this.connect_button.Name = "connect_button";
      this.connect_button.Size = new System.Drawing.Size(118, 33);
      this.connect_button.TabIndex = 1;
      this.connect_button.Text = "Connect";
      this.connect_button.UseVisualStyleBackColor = true;
      this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
      // 
      // LoginForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(488, 353);
      this.Controls.Add(this.connect_button);
      this.Controls.Add(this.access_token_textbox);
      this.Name = "LoginForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Diet Plan App - Login";
      this.ResumeLayout(false);

    }

    #endregion

    private RichTextBox access_token_textbox;
    private Button connect_button;
  }
}
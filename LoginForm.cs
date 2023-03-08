using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elytica_c_sharp_diet_app
{
  public partial class LoginForm : Form
  {
    public event EventHandler connect_btn_clicked;

    public LoginForm()
    {
      InitializeComponent();
    }

    public string GetAccessToken()
    {
      return access_token_textbox.Text;
    }

    private void connect_button_Click(object sender, EventArgs e)
    {
      if (connect_btn_clicked != null)
        connect_btn_clicked(this, EventArgs.Empty);            
    }
  }
}

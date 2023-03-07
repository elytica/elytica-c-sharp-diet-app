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
      access_token_textbox.Text = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJhdWQiOiIyMiIsImp0aSI6IjI2OTJmZWE1OTRmMmIyOTlmNWFiNmQ1ZDc2Yjg3YmRiYWNmZDA5YWMyMzZlOWU0YTFlZDA4YmY5NGJhOWU2YjEyM2IzZjMzNTY3OGMzZTNhIiwiaWF0IjoxNjc3NzQzMTgzLjg1NDA2LCJuYmYiOjE2Nzc3NDMxODMuODU0MDYzLCJleHAiOjE2OTM2NDA3ODMuODQ4Mjk5LCJzdWIiOiIyNzgiLCJzY29wZXMiOltdfQ.KSzFbqtHK5oPVnKazIUPXPtVwYAKOR_gvFIgbcsgo5unlAl0Ceb0MZwxtPpxMjpGJrWEEL3kpeG4WOJ7gi8yaHTvvRnouw19YFBku51h6gzHjyazvDoB2efIRTYsLuY_4e85fsT1AkuV-c1jXdBc4npB20qn6BUNO_VJcxFL5sPWjqKBvwupdxCEQZZOBcys3EPVjGTwFNqanfqMeQIrcZ9nNQFSQI8aFLNA004KDNAIQspPj8Eltf4JFipOIelajWvBBX3bo6BGxsA2bSAGEJyb7bN7MyPAM5uB6GuASNTgAtr2sV5zoF1uJTI8incPao9OCZYsqc1cmefXoUCTB4AqyDjSXcpi8rTLBj5xzVlhbI1sZ6kfdSCWY620yv27NDJN3CQXe80xEqyd2jgwZu8C1ydvguaev_rYewQTk5XLByy23iABf7d03IMS67LXVAOus8YRvdPtXZa9Ip5qycgc8qew5zY-OYCuMGD17PjXEzij8o0B1axp8MSZca5nYiWAeihl_Y1EuFsU7bRQ2J3wky0YNFpmTen1oEYv9Gbpw23B1qjiOasHkz3XhNmnrbWZ_levrrh16wi3Byotrbk3Xf6GHFKamYX1aICzVjD3s3MHFbJwH0J9vvkWunkv82naE9xwqTJowCee-M8ydnjgFKyuzwKM-WOavKUB_qU";
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

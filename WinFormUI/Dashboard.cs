using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
  public partial class Dashboard : Form
  {
    public Dashboard()
    {
      InitializeComponent();
    }

    private void generateButton_Click(object sender, EventArgs e)
    {
      string employeeId = $@"{firstNameTextBox.Text.Substring(0, 4)}{lastNameTextBox.Text.Substring(0, 4)}{DateTime.Now.Millisecond}";
      employeeIdTextBox.Text = employeeId;
    }
  }
}

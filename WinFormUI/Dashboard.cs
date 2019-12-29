using DRYDemoLibrary;
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
      EmployeeProcessor processor = new EmployeeProcessor();
      employeeIdTextBox.Text = processor.GenerateEmployeeID(firstNameTextBox.Text, lastNameTextBox.Text );
    }
  }
}

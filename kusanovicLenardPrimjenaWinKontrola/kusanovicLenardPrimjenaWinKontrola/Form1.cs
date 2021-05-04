using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace kusanovicLenardPrimjenaWinKontrola
{
    public partial class chkShowProgram : Form
    {
        public chkShowProgram()
        {
            InitializeComponent();
        }

        private void chkShowProgram_Load(object sender, EventArgs e)
        {

        }

        private void btnRunProgram_Click(object sender, EventArgs e)
        {
            string odabir = comboBox1.SelectedItem.ToString();
            if (odabir == "Paint")
            {
                Process.Start("mspaint.exe");
            }

            if (odabir == "Notepad")
            {
                Process.Start("notepad.exe");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (grbProgramControl.Visible == false)
            {
                grbProgramControl.Visible = true;
            }
            else
            {
                grbProgramControl.Visible = false;
            }
        }

        private void lblProgramDescription_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            textBox1.Clear();
        }
        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaText frm = new FormaText();
            frm.Show();
           

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult odgovor = MessageBox.Show("Jeste li suigurni da cete zatvorit aplikaciju?", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (odgovor == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Tag.ToString())
            {
                case "NewDoc":
                    MessageBox.Show(
                        "Отработала кнопка New doc",
                        "",
                        MessageBoxButtons.OK);
                    break;
                case "Cascade":
                    MessageBox.Show(
                        "Отработала кнопка Cascade",
                        "",
                        MessageBoxButtons.OK);
                    break;
                case "Title":
                    MessageBox.Show(
                        "Отработала кнопка Title",
                        "",
                        MessageBoxButtons.OK);
                    break;
            }
        }
    }
}

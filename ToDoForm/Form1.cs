using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoForm
{
    public partial class frmKezdo : Form
    {
        private List<string> todos = new List<string>();
        public frmKezdo()
        {
            InitializeComponent();
            StreamReader be = new StreamReader("todoitems.txt");
            while (!be.EndOfStream)
            {
                todos.Add(be.ReadLine());
            }

            be.Close();
        }

        private void mKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmKezdo_Shown(object sender, EventArgs e)
        {
            tbBevitel.Text = "";
            lbTodo.Items.Clear();
            tbBevitel.Focus();
        }

        private void btnListabol_Click(object sender, EventArgs e)
        {
            frmLista formLista = new frmLista(todos);

            formLista.ShowDialog();

            tbBevitel.Text = formLista.SelectedTodo;
        }

        private void btnFelvitel_Click(object sender, EventArgs e)
        {
            if (tbBevitel.Text != "")
            {
                lbTodo.Items.Add(tbBevitel.Text);
                tbBevitel.Text = "";
            }
        }

        private void btnEltavolit_Click(object sender, EventArgs e)
        {
            lbTodo.Items.Clear();
        }
    }
}

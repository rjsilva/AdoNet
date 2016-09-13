using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTabela_Click(object sender, EventArgs e)
        {
            DataTable tabela = new DataTable("Pessoas");
            tabela.Columns.Add("ID", typeof(int));
            tabela.Columns.Add("Nome", typeof(string));

            tabela.PrimaryKey = new DataColumn[] { tabela.Columns["ID"] };

            this.label1.Text = tabela.TableName;

            foreach(DataColumn coluna in tabela.Columns){

                this.lblcoluna.Text = this.lblcoluna.Text;
            }

            foreach(DataColumn primaryColum in tabela.Columns){

                if(tabela.PrimaryKey.Contains(primaryColum) == true){

                    this.lblkey.Text = primaryColum.ColumnName.ToString();
                }
            }
        }

    }
}

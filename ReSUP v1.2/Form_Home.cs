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

namespace ReSUP_v1._2
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {

            InitializeComponent();
        }

       
        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
        }

        private void clienteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void nomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void clienteBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.teamViewerDataGridView.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBSet1);
            MessageBox.Show("  Dado Salvo");
        }

        private void Form_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dBSet1.Tecnico'. Você pode movê-la ou removê-la conforme necessário.
            this.tecnicoTableAdapter.Fill(this.dBSet1.Tecnico);
            // TODO: esta linha de código carrega dados na tabela 'dBSet1.Atividade'. Você pode movê-la ou removê-la conforme necessário.
            this.atividadeTableAdapter.Fill(this.dBSet1.Atividade);
            // TODO: esta linha de código carrega dados na tabela 'dBSet1.Atividade'. Você pode movê-la ou removê-la conforme necessário.
            this.atividadeTableAdapter.Fill(this.dBSet1.Atividade);
            // TODO: esta linha de código carrega dados na tabela 'dBSet1.TeamViewer'. Você pode movê-la ou removê-la conforme necessário.
            this.teamViewerTableAdapter.Fill(this.dBSet1.TeamViewer);
            // TODO: esta linha de código carrega dados na tabela 'dBSet1.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.dBSet1.Cliente);

        }

        private void ConecatrTVButton_Click(object sender, EventArgs e)
        {
            string[] lines = { "cd..", "cd..", "cd Program Files (x86)/TeamViewer", ComandoTV.Text };
            System.IO.File.WriteAllLines(@"C:\Users\Public\Documents\ReSUP\Connection.bat", lines);


            ProcessStartInfo processtartinfo = new ProcessStartInfo();
            processtartinfo.Verb = "runas";
            processtartinfo.FileName = @"C:\Users\Public\Documents\ReSUP\Connection.bat";
            processtartinfo.CreateNoWindow = false;
            Process.Start(processtartinfo);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tecnicoTableAdapter.FillBy(this.dBSet1.Tecnico);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void idTecnicoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tecnicoTableAdapter.Fill(this.dBSet1.Tecnico);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }
    }
}

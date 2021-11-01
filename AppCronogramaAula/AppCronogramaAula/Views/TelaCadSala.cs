using System;
using System.Windows.Forms;
using AppCronogramaAula.Model;
using AppCronogramaAula.Controller;

namespace CronogramaAula
{
    public partial class TelaCadSala : Form
    {
        public TelaCadSala()
        {
            InitializeComponent();
        }
        private void btnCadSala_Click(object sender, EventArgs e)
        {
            Sala.NomeSala = tbNomeSala.Text;
            Sala.TipoSala= label3.Text; //mudar tbTipoSala


            SalaController salaController = new SalaController();
            salaController.cadastroSala();

            tbNomeSala.Clear();
            label3.Clear(); // ?


            if (Sala.Retorno == "True")
            {
                this.Close();
            }
        }
    }
}


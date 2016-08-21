using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using DAL;

namespace Aula02
{
    public partial class CadastroPessoa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Pessoa objPessoa = new Pessoa();

            objPessoa.Nome = txtNome.Text;
            objPessoa.Email = txtEmail.Text;
            objPessoa.Sexo = rblSexo.SelectedValue;
            objPessoa.EstadoCivil = dplEstadoCivil.SelectedValue;
            objPessoa.ReceberSMS = chkSms.Checked;
            objPessoa.ReceberEmail = chkEmail.Checked;

            PessoaDAL pDAL = new PessoaDAL();
            pDAL.InserirPessoa(objPessoa);
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            PessoaDAL pDAL = new PessoaDAL();

            Pessoa objPessoa = pDAL.SelecionarPessoaPeloId(id); //Jogando o método dentro do Objeto.
            if (objPessoa != null)
            {
                txtNome.Text = objPessoa.Nome;
                txtEmail.Text = objPessoa.Email;
                rblSexo.SelectedValue = objPessoa.Sexo;
                dplEstadoCivil.SelectedValue = objPessoa.EstadoCivil;
                chkSms.Checked = objPessoa.ReceberSMS;
                chkEmail.Checked = objPessoa.ReceberEmail;
            }

        }
    }
}
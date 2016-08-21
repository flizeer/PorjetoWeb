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
    public partial class CadastroCarro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Carro objCarro = new Carro();
            objCarro.Marca = txtMarca.Text;
            objCarro.Modelo = txtModelo.Text;
            objCarro.Ano = Convert.ToInt32(txtAno.Text);
            objCarro.Cor = txtCor.Text;

            CarroDAL cDAL = new CarroDAL ();
            cDAL.InserirCarro(objCarro);

        }
    }
}
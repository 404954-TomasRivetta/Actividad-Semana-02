using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problema1_4.Vistas.Equipo
{
    public partial class FrmNuevoEquipo : Form
    {
        public FrmNuevoEquipo()
        {
            InitializeComponent();
        }

        private void FrmNuevoEquipo_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Today.ToString("d");
            txtNomDT.Text = "";
            txtNomEquipo.Text = "";
            ProximoEquipo();
        }

        private void ProximoEquipo()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=PCCESAR;Initial Catalog=ligaCordobesa;Integrated Security=True";

            conexion.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "sp_proximo_id";
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@next";
            parametro.SqlDbType = SqlDbType.Int;
            parametro.Direction = ParameterDirection.Output;
            comando.Parameters.Add(parametro);

            comando.ExecuteNonQuery();

            conexion.Close();

            lblEquipoNro.Text = lblEquipoNro.Text + ": " + parametro.Value.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desea cancelar la operacion?", "Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNomDT.Text == "" || txtNomEquipo.Text == "")
            {
                MessageBox.Show("Complete los campos..","Control",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }



        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using SistemaVeterinaria.Negocios;
using SistemaVeterinaria.Entidades;

namespace SistemaVeterinaria.Principal
{
    public partial class FrmLogin : MaterialSkin.Controls.MaterialForm
    {
        public FrmLogin()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Purple700, MaterialSkin.Primary.Purple700, MaterialSkin.Primary.Purple700, MaterialSkin.Accent.Pink100, MaterialSkin.TextShade.WHITE);
        }

        private void FrmLogins_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == null || txtClave.Text == "")
            {
                if (txtClave.Text == null || txtCodigo.Text == "")
                {
                    MessageBox.Show("Error de datos");
                }
            }
            else
            {
                ClsEUsuario objE = new ClsEUsuario();
                ClsNUsuario objN = new ClsNUsuario();
                objE.Codigo = txtCodigo.Text;
                objE.Clave = txtClave.Text;
                objE.Estado = "TRUE";
                DataTable dtEmp = new DataTable();
                dtEmp = objN.MtdVAlidarLogin(objE);
                if (dtEmp.Rows.Count > 0)
                {
                    DataRow Fila = dtEmp.Rows[0];
                    FrmPrincipal.codEmp = Fila["codigo"].ToString();
                    FrmPrincipal.nombreEmp = Fila["nombre"].ToString();
                    FrmPrincipal.apelliEmp = Fila["apellido"].ToString();
                    FrmPrincipal.cargoEmp = Fila["cargo"].ToString();

                    MessageBox.Show("Bienvenido " + FrmPrincipal.cargoEmp + " : " + FrmPrincipal.nombreEmp + " " + FrmPrincipal.apelliEmp);
                    FrmPrincipal frm = new FrmPrincipal();
                    frm.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("No existe el usuario");
                }
            }


           
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}

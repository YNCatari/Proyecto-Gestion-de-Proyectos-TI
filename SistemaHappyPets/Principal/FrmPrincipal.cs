using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVeterinaria.Principal
{

    public partial class FrmPrincipal : Form
    {
        Button Activo;
        Color dark = Color.FromArgb(123, 31, 162);
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        public static int ayuda = 0;
        public static string codEmp = "";
        public static string nombreEmp = "";
        public static string apelliEmp = "";
        public static string ruc = "";
        public static string cargoEmp = "";
        public static int contEmp = 1;
        public void loadForm(Form form)
        {
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            group.Controls.Clear();
            group.Controls.Add(form);
            form.Show();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
            
            btnclientes.BackColor = dark;
            btnUsuarios.BackColor = dark;
            btnHistorial.BackColor = dark;
            btnTratamientos.BackColor = dark;
            btnAgendas.BackColor = dark;
            btnMascota.BackColor = dark;
            btnServicios.BackColor = dark;
            btncerrar.BackColor = dark;
            btnVacunas.BackColor = dark;
            btnReportes.BackColor = dark;
            panelIzquierdo.BackColor = Color.FromArgb(123, 31, 162);

            btnclientes.Enabled = false;
            btnUsuarios.Enabled = false;
            btnHistorial.Enabled = false;
            btnTratamientos.Enabled = false;
            btnAgendas.Enabled = false;
            btnMascota.Enabled = false;
            btnServicios.Enabled = false;
            btnVacunas.Enabled = false;
            btnReportes.Enabled = true;

            if (cargoEmp.Equals("Medico Veterinario"))
            {
                btnclientes.Enabled = false;
                btnUsuarios.Enabled =false;
                btnMascota.Enabled = true;
                btnVacunas.Enabled = true;
                btnServicios.Enabled = true;
                btnTratamientos.Enabled = true;
                btnHistorial.Enabled = true;               
                btnAgendas.Enabled = false;
                btnReportes.Enabled = false;

            }
            if (cargoEmp.Equals("Administrador"))
            {
                btnclientes.Enabled = true;
                btnUsuarios.Enabled = true;
                btnMascota.Enabled = true;
                btnVacunas.Enabled = true;
                btnServicios.Enabled = true;
                btnTratamientos.Enabled = true;
                btnHistorial.Enabled = true;
                btnAgendas.Enabled = true;
                btnReportes.Enabled = true;
            }
            if (cargoEmp.Equals("Asistente"))
            {
                btnclientes.Enabled = true;
                btnUsuarios.Enabled = false;
                btnMascota.Enabled = true;
                btnVacunas.Enabled = true;
                btnServicios.Enabled = true;
                btnTratamientos.Enabled = true;
                btnHistorial.Enabled = true;
                btnAgendas.Enabled =false;
                btnReportes.Enabled = true;
            }
            lblEmpleado.Text = cargoEmp;
            lblNombre.Text = apelliEmp+","+ nombreEmp;
        }
        public void setActiveForm(Button btn)
        {
            if (btn != Activo)
            {
                btn.BackColor = Color.FromArgb(123, 31, 162);
                if (Activo != null) { Activo.BackColor = Color.FromArgb(123, 31, 162); }
                Activo = btn;
            }
        
       }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            setActiveForm(btnclientes);
            loadForm(new FrmCliente());
        }

        private void btnPProductos_Click(object sender, EventArgs e)
        {
            setActiveForm(btnUsuarios);
            loadForm(new FrmUsuario());
        }

        private void btnECanina_Click(object sender, EventArgs e)
        {
            setActiveForm(btnTratamientos);
            loadForm(new FrmTratamientos());
        }

        private void btnAActividades_Click(object sender, EventArgs e)
        {
            setActiveForm(btnAgendas);
            loadForm(new FrmAgenda());
        }

        private void btnMPacientes_Click(object sender, EventArgs e)
        {
            setActiveForm(btnServicios);
            loadForm(new FrmServicios());
        }

        private void btnSVacunacion_Click(object sender, EventArgs e)
        {
            setActiveForm(btnVacunas);
            loadForm(new FrmVacunas());
        }

        private void btnRMascota_Click(object sender, EventArgs e)
        {
            setActiveForm(btnMascota);
            loadForm(new FrmMascota());
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Hide();
        }



        private void group_Enter(object sender, EventArgs e)
        {

        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            setActiveForm(btnHistorial);
            loadForm(new FrmHistorial());
        }

        private void btnGanancias_Click(object sender, EventArgs e)
        {
            setActiveForm(btnReportes);
            loadForm(new FrmReportes());
        }
    }
}

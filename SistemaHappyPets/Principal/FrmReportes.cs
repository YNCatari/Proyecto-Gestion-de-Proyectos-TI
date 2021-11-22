using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using SistemaVeterinaria.Entidades;
using SistemaVeterinaria.Negocios;
namespace SistemaVeterinaria.Principal
{
    public partial class FrmReportes : MaterialSkin.Controls.MaterialForm
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void FrmGanancias_Load(object sender, EventArgs e)
        {

        }
         public double TotalVacuna, TotalMantenimiento, TotalTratamiento;

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            ClsEReportes objE = new ClsEReportes();
            ClsNReportes ojbjN = new ClsNReportes();
            objE.FechaI = DtpfechaI.Text;
            objE.FechaF = DtpfechaF.Text;
            DataTable dtEmp2 = new DataTable();
            dtEmp2 = ojbjN.MtdBuscarVacuna(objE);
            if (dtEmp2.Rows.Count > 0)
            {
                DataRow Fila = dtEmp2.Rows[0];
                TotalVacuna = Convert.ToDouble(Fila["sum(precio)".ToString()]);
            }
            DataTable dtEmp = new DataTable();
            dtEmp = ojbjN.MtdBuscarMantenimiento(objE);
            if (dtEmp.Rows.Count > 0)
            {
                DataRow Fila = dtEmp.Rows[0];
                TotalMantenimiento = Convert.ToDouble(Fila["sum(precio)".ToString()]);
            }
            DataTable dtEmp3 = new DataTable();
            dtEmp3 = ojbjN.MtdBuscarTratamiento(objE);
            if (dtEmp3.Rows.Count > 0)
            {
                DataRow Fila = dtEmp3.Rows[0];
                TotalTratamiento = Convert.ToDouble(Fila["sum(precio)".ToString()]);
            }


            this.chGanancias.Series.Clear();

            // Data arrays
            string[] seriesArray = { "Ganancia de Vacunas: "+ "S/"+TotalVacuna.ToString(), "Ganancia de Servicios: " + "S/" + TotalMantenimiento.ToString(),
                "Ganancia de Tratamineto: "+ "S/"+TotalTratamiento.ToString() };
            int[] pointsArray = { Convert.ToInt32(TotalVacuna), Convert.ToInt32(TotalMantenimiento), Convert.ToInt32(TotalTratamiento) };

            // Set palette
            this.chGanancias.Palette =ChartColorPalette.BrightPastel;

            // Set title
            this.chGanancias.Titles.Add("Reportes de Ganancias");

            // Add series.
            for (int i = 0; i < seriesArray.Length; i++)
            {
                Series series = this.chGanancias.Series.Add(seriesArray[i]);
                series.Points.Add(pointsArray[i]);
            }
        }
    }
}

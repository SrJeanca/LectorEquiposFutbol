using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LectorEquiposFutbol
{
    public partial class Formu_Equipos : Form
    {
        Equipo_class class_equipo = new Equipo_class();
        public Formu_Equipos()
        {
            InitializeComponent();
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            dataGVDatosEquipos.DataSource = class_equipo.EnviarConsultaDatos();
        }
    }
}

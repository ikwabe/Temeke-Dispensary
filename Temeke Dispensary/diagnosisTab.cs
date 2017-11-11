using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temeke_Dispensary
{
    public partial class diagnosisTab : UserControl
    {
        public static diagnosisTab _instance;
        public static diagnosisTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new diagnosisTab();
                return _instance;
            }
        }
        public diagnosisTab()
        {
            InitializeComponent();
        }

        private void diagnosisTab_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Lab Test".ToString());
            table.Columns.Add("Results".ToString());
            table.Columns.Add("N.performed".ToString());

            DataRow dr = table.NewRow();
            dr["Lab Test"] = "HEMOGLOBIN";
            dr["Results"] = "Possitive";
            dr["N.performed"] = "nill";

            table.Rows.Add(dr);

            labResultList.DataSource = table;



        }

        private void moreDiagnosBtn_Click(object sender, EventArgs e)
        {
            AllDiagnosis dia = new AllDiagnosis();
            dia.Show();
        }
    }
}

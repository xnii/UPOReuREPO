using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Система_учета_пожарного_оборудования
{
    public partial class SpsOTV : Form
    {
        public SpsOTV()
        {
            InitializeComponent();
        }

        private void oBEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.oBEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uPOReuV1DataSet);

        }

        private void SpsOTV_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uPOReuV1DataSet.OBE". При необходимости она может быть перемещена или удалена.
            this.oBETableAdapter.Fill(this.uPOReuV1DataSet.OBE);

        }
    }
}

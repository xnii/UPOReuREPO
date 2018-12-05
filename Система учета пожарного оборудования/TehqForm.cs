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
    public partial class TehqForm : Form
    {
        public TehqForm()
        {
            InitializeComponent();
        }

        private void tEHQBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        

        }

        private void TehqForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uPOReuV1DataSet.TEHQ". При необходимости она может быть перемещена или удалена.
            //this.tEHQTableAdapter.Fill(this.uPOReuV1DataSet.TEHQ);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

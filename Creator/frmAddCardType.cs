using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Creator
{
    public partial class frmAddCardType : Form
    {
        public frmAddCardType()
        {
            InitializeComponent();
        }

        private void frmAddCardType_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“creatorDataSet.CardType”中。您可以根据需要移动或删除它。
            this.cardTypeTableAdapter.Fill(this.creatorDataSet.CardType);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            cardTypeBindingSource.EndEdit();
            cardTypeTableAdapter.Update(creatorDataSet);
        }
    }
}

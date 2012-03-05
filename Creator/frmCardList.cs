using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using Aspose.Cells;
namespace Creator
{
    public partial class frmCardList : Form
    {
        private readonly int _createCareId;

        public frmCardList(int createCareId)
        {
            _createCareId = createCareId;
            InitializeComponent();
        }

        private void frmCardList_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“creatorDataSet.Card”中。您可以根据需要移动或删除它。
            this.cardTableAdapter.FillByCreateCardID(this.creatorDataSet.Card, _createCareId);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            cardBindingSource.EndEdit();
            cardTableAdapter.Update(creatorDataSet.Card);
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SolidBrush solidBrush = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor);
            int xh = e.RowIndex + 1;
            e.Graphics.DrawString(xh.ToString(CultureInfo.CurrentUICulture), e.InheritedRowStyle.Font, solidBrush, e.RowBounds.Location.X + 5, e.RowBounds.Location.Y + 4);
        }

        private void toolStripButtonExportExcel_Click(object sender, EventArgs e)
        {
            var fileDialog = new SaveFileDialog();
            fileDialog.DefaultExt = "xls";
            fileDialog.FileName = "生成卡" + DateTime.Today.ToLongDateString() ;
            fileDialog.Filter = "Excel 2003(*.xls)|*.xls|Excel 2007(*.xlsx)|*.xlsx";
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            var fileName = fileDialog.FileName;
            var dataTable = creatorDataSet.Card;
            var workbook = new Workbook();
            var worksheet = workbook.Worksheets[0];

            var styleIndex = workbook.Styles.Add();
            Style style = workbook.Styles[styleIndex];
            style.Font.Name = "宋体";
            style.Font.Size = 16;
            style.Font.IsBold = true;
            style.Font.Color = System.Drawing.Color.Red;
            var range = worksheet.Cells.CreateRange("a1", "d1");
            range.SetStyle(style);

            worksheet.Cells[0, 0].PutValue("卡号");
            worksheet.Cells[0, 1].PutValue("卡密");
            worksheet.Cells[0, 2].PutValue("卡类别");
            worksheet.Cells[0, 3].PutValue("创建日期");
            for (int rowIndex = 0; rowIndex < dataTable.Rows.Count; rowIndex++)
            {

                for (int columnIndex = 0; columnIndex < 4; columnIndex++)
                {
                    worksheet.Cells[rowIndex + 1, columnIndex].PutValue(dataTable.Rows[rowIndex][columnIndex + 1].ToString());
                     var cStyle= worksheet.Cells[rowIndex + 1, columnIndex].GetStyle();
                     cStyle.Font.Name = "宋体";
                     worksheet.Cells[rowIndex + 1, columnIndex].SetStyle(cStyle);
                }
            }
            worksheet.AutoFitColumns();
            workbook.Save(fileName);
            if(MessageBox.Show("导出完成!是否立即打开导出文件所在的文件夹?","提示", MessageBoxButtons.YesNo)== System.Windows.Forms.DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("explorer.exe", System.IO.Path.GetDirectoryName(fileName));
            }
        }
    }
}

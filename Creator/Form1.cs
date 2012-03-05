using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Creator.Model;
using System.Globalization;

namespace Creator
{
    public partial class Form1 : Form
    {
        private System.Collections.Hashtable htConditions = new System.Collections.Hashtable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“creatorDataSet.CardType”中。您可以根据需要移动或删除它。
            this.cardTypeTableAdapter.Fill(this.creatorDataSet.CardType);
            // TODO: 这行代码将数据加载到表“creatorDataSet.CreateCard”中。您可以根据需要移动或删除它。
            dtpStart.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Today;
            this.createCardTableAdapter.FillByCreateDateBetween(creatorDataSet.CreateCard, dtpStart.Value, dtpEndDate.Value.AddDays(1));

            ////判断条件表是否有默认值
            ////var count = conditionTableAdapter.GetCountByConditonName("默认");
            //var count = creatorDataSet.Tables["Condition"].Rows.Cast<CreatorDataSet.ConditionRow>().Count(c => c.ConditionName == "缺省");
            //if (count==0)
            //{
            //    string strTemp="ABCDEFHIJKLMNOPQRSTUVWXYZ0123456789";
            //    conditionTableAdapter.Insert("缺省", "", "", "", 8, strTemp, 8, strTemp);
            //}
            //creatorDataSet.Clear();
            //this.conditionTableAdapter.Fill(this.creatorDataSet.Condition);

            foreach (CreatorDataSet.CardTypeRow row in this.creatorDataSet.CardType.Rows)
            {
                lbCardTypes.Items.Add(row);
            }
            lbSelectedCardTypes.ValueMember = "ID";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddSelecedCardType();
        }

        private void AddSelecedCardType()
        {
            if (lbCardTypes.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择至少一个卡类别!");
                return;
            }
            var frm = new frmConditon();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            var selectedCardTypes = (from CreatorDataSet.CardTypeRow item in lbCardTypes.SelectedItems select (item)).Cast<object>().ToList();
            foreach (CreatorDataSet.CardTypeRow item in selectedCardTypes)
            {
                lbCardTypes.Items.Remove(item);
                lbSelectedCardTypes.Items.Add(item);
                htConditions.Add(item.CardTypeName, frm.CustomerCondition.ShallowCopy());
            }
        }

        private void lbSelectedCardTypes_DoubleClick(object sender, EventArgs e)
        {
            var key = ((CreatorDataSet.CardTypeRow)lbSelectedCardTypes.SelectedItem).CardTypeName;
            var condition = (CustomerCondition)htConditions[key];
            var frm = new frmConditon(condition.ShallowCopy());
            if (frm.ShowDialog() == DialogResult.OK)
            {
                htConditions[key] = frm.CustomerCondition.ShallowCopy();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lbSelectedCardTypes.SelectedItems.Count == 0)
            {
                MessageBox.Show("选择至少一个卡类别!");
                return;
            }
            if (MessageBox.Show("是否移除选择的项?") == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            var temp = lbSelectedCardTypes.SelectedItems;
            var selectedCardTypes = (from CreatorDataSet.CardTypeRow item in lbSelectedCardTypes.SelectedItems select (item)).Cast<object>().ToList();
            foreach (CreatorDataSet.CardTypeRow item in selectedCardTypes)
            {
                lbCardTypes.Items.Add(item);
                lbSelectedCardTypes.Items.Remove(item);
                htConditions.Remove(item.CardTypeName);
            }

        }

        private void lbCardTypes_DoubleClick(object sender, EventArgs e)
        {
            AddSelecedCardType();
        }

        private void btnAddCardType_Click(object sender, EventArgs e)
        {

            var frm = new frmAddCardType();
            frm.ShowDialog();

            lbCardTypes.Items.Clear();
            lbSelectedCardTypes.Items.Clear();

            creatorDataSet.CardType.Clear();

            this.cardTypeTableAdapter.Fill(this.creatorDataSet.CardType);

            foreach (CreatorDataSet.CardTypeRow row in this.creatorDataSet.CardType.Rows)
            {
                lbCardTypes.Items.Add(row);
            }
            foreach (long item in htConditions.Keys)
            {
                var tempItem = lbCardTypes.Items.Cast<CreatorDataSet.CardTypeRow>().Single(c => c.ID == item);
                if (tempItem == null)
                {
                    htConditions.Remove(item);
                    continue;
                }

                lbCardTypes.Items.Remove(tempItem);
                lbSelectedCardTypes.Items.Add(tempItem);
            }
            //lbCardTypes.DisplayMember = "CardTypeName";
            //lbSelectedCardTypes.DisplayMember = "CardTypeName";
        }

        private void btnStartCreate_Click(object sender, EventArgs e)
        {
            if (htConditions.Count == 0)
            {
                MessageBox.Show("未选择要生成的卡类别！");
                return;
            }
            CreatorDataSet.CreateCardRow createCard;
            DateTime createDate;
            if (MessageBox.Show("是否生成新的生成卡记录？选否将把生成的卡添加到当前选择的生成卡记录中。", "提示", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                createCard = creatorDataSet.CreateCard.AddCreateCardRow(DateTime.Now, txtMemo.Text);
                createCardTableAdapter.Update(creatorDataSet.CreateCard);
                createCard.ID = (int)createCardTableAdapter.GetMaxID();
                createCard.AcceptChanges();
                createDate = createCard.CreateDate;
            }
            else
            {
                if (createCardBindingSource.Current == null)
                {
                    MessageBox.Show("生成卡失败，未选择要添加卡的生成卡记录");
                    return;
                }
                createCard = (CreatorDataSet.CreateCardRow)(createCardBindingSource.Current as DataRowView).Row;
                createDate = DateTime.Now;
            }
            var bar = ShowProgressBar();
            bar.Value = 1;
            bar.Maximum = htConditions.Keys.Cast<object>().Sum(key => ((CustomerCondition)htConditions[key]).CardCount);
            
            var cardTableAdapter = new CreatorDataSetTableAdapters.CardTableAdapter();
            cardTableAdapter.Fill(creatorDataSet.Card);
            foreach (string cardTypeName in htConditions.Keys)
            {
                var condition = (CustomerCondition)htConditions[cardTypeName];
                for (int i = 0; i < condition.CardCount; i++)
                {
                    //Application.DoEvents();
                    string cardNumber;
                    string cardPassword;
                    while (true)
                    {
                        Application.DoEvents();
                        cardNumber = RandomString(condition.CardNumberLength, condition.CardNumberString);
                        cardPassword = RandomString(condition.CardPasswordLength, condition.CardPasswordString);
                        if (creatorDataSet.Card.Count(c => c.CardNumber == cardNumber && c.CardPassword == cardPassword) == 0)
                        {
                            break;
                        }
                    }
                    creatorDataSet.Card.AddCardRow(cardNumber,
                                                   cardPassword,
                                                   cardTypeName,
                                                   createDate,
                                                   createCard
                        );

                    bar.PerformStep();
                    bar.Refresh();
                }
            }

            var count = cardTableAdapter.Update(creatorDataSet.Card);

            lbCardTypes.Items.AddRange(lbSelectedCardTypes.Items);
            lbSelectedCardTypes.Items.Clear();
            htConditions.Clear();
            HideProgressBar(bar);
            MessageBox.Show(string.Format("已生成{0}条记录！", count));
        }

        private string RandomString(int length, string strOf)
        {
            return RandomStr.BuildRndCodeOnly(strOf, length);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.Value.ToString() == "详细")
            {
                frmCardList frm = new frmCardList((int)dataGridView1.Rows[e.RowIndex].Cells["iDDataGridViewTextBoxColumn"].Value);
                frm.ShowDialog();
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.createCardTableAdapter.FillByCreateDateBetween(creatorDataSet.CreateCard, dtpStart.Value, dtpEndDate.Value.AddDays(1));

        }

        private void btnDelSelected_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("删除记录将删除相关的卡记录,是否删除选择的记录?", "提示", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
            createCardTableAdapter.Update(creatorDataSet.CreateCard);
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SolidBrush solidBrush = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor);
            int xh = e.RowIndex + 1;
            e.Graphics.DrawString(xh.ToString(CultureInfo.CurrentUICulture), e.InheritedRowStyle.Font, solidBrush, e.RowBounds.Location.X + 5, e.RowBounds.Location.Y + 4);

        }

        private void dataGridView1_Resize(object sender, EventArgs e)
        {
            GridAutoResizeColumns();
        }
        private void GridAutoResizeColumns()
        {
            dataGridView1.AutoResizeColumns();
            //dataGridView1.AutoResizeColumn(1);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GridAutoResizeColumns();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            System.Threading.Thread.Sleep(5000);
        }

        private UserControl1 ShowProgressBar()
        {
            //var panel = new Panel();
            //panel.Width = this.Width / 5 * 4;
            //panel.Height = 56;
            //panel.BorderStyle = BorderStyle.Fixed3D;

            //int gLeft = this.Width / 2 - panel.Width / 2; //this指Form
            //int gTop = this.Height / 2 - panel.Height * 2 ;
            //panel.Location = new Point(gLeft, gTop);
            //panel.BackColor = Color.FromArgb(100, Color.PowderBlue);
            //ProgressBar bar = new ProgressBar();
            //bar.Maximum = barMaximum;
            //bar.Dock = DockStyle.Top ;
            //bar.Step = 1;
            //bar.Style = ProgressBarStyle.Blocks;


            //panel.Controls.Add(bar);
            //this.Controls.Add(panel);
            //panel.BringToFront();
            //return bar;
            UserControl1 uc = new UserControl1();
            uc.Width = this.Width / 5 * 4;
            int gLeft = this.Width / 2 - uc.Width / 2; //this指Form
            int gTop = this.Height / 2 - uc.Height;
            uc.Location = new Point(gLeft, gTop);
            this.Controls.Add(uc);
            uc.BringToFront();
            return uc;
        }
        void HideProgressBar(UserControl1 bar)
        {
            this.Controls.Remove(bar);
            bar.Dispose();
        }
    }
}

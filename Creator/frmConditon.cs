using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Creator
{
    public partial class frmConditon : Form
    {
        public Model.CustomerCondition CustomerCondition { get; set; }

        public frmConditon()
        {
            InitializeComponent();
        }

        public frmConditon(Model.CustomerCondition customerCondition)
        {
            InitializeComponent();
            CustomerCondition = customerCondition;

        }

        private void frmConditon_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“creatorDataSet.Condition”中。您可以根据需要移动或删除它。
            creatorDataSet.Condition.Clear();
            this.conditionTableAdapter.Fill(this.creatorDataSet.Condition);
            //判断条件表是否有值
            if (creatorDataSet.Condition.Rows.Count == 0)
            {
                const string strTemp = "ABCDEFHIJKLMNOPQRSTUVWXYZ0123456789";
                creatorDataSet.Condition.AddConditionRow("缺省", "", "", "", 8, strTemp, 8, strTemp);
                conditionTableAdapter.Update(creatorDataSet.Condition);
            }

            if (CustomerCondition != null)
            {
                nudCardCount.Value = CustomerCondition.CardCount;
                nudCardNumberLength.Value = CustomerCondition.CardNumberLength;
                txtCardNumberString.Text = CustomerCondition.CardNumberString;
                nudCardPasswordLength.Value = CustomerCondition.CardPasswordLength;
                txtCardPasswordString.Text = CustomerCondition.CardPasswordString;
                cbbConditon.SelectedValue = CustomerCondition.ConditionId;
                txtPrefix.Text = CustomerCondition.Prefix;
                txtSeparator.Text = CustomerCondition.Separator;
                txtSuffix.Text = CustomerCondition.Suffix;
            }

            if (cbbConditon.Text == "")
            {

                btnSaveCondition.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CustomerCondition == null)
            {
                CustomerCondition = new Model.CustomerCondition();
            }
            try
            {
                CustomerCondition.CardCount = (int)nudCardCount.Value;
                CustomerCondition.CardNumberLength = (int)nudCardNumberLength.Value;
                CustomerCondition.CardNumberString = txtCardNumberString.Text;
                CustomerCondition.CardPasswordLength = (int)nudCardPasswordLength.Value;
                CustomerCondition.CardPasswordString = txtCardPasswordString.Text;
                CustomerCondition.ConditionId = (int)cbbConditon.SelectedValue;
                CustomerCondition.Prefix = txtPrefix.Text;
                CustomerCondition.Separator = txtSeparator.Text;
                CustomerCondition.Suffix = txtSuffix.Text;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }

        private void btnSaveCondition_Click(object sender, EventArgs e)
        {
            //var i = conditionTableAdapter.Update(cbbConditon.Text, txtPrefix.Text
            //                              , txtSuffix.Text, txtSeparator.Text, (long)nudCardNumberLength.Value,
            //                              txtCardNumberString.Text,
            //                               (long)nudCardPasswordLength.Value, txtCardPasswordString.Text,
            //                              (long)cbbConditon.SelectedValue);
            
            //creatorDataSet.AcceptChanges();

            conditionBindingSource.CurrencyManager.EndCurrentEdit();
            conditionTableAdapter.Update(creatorDataSet.Condition);
            creatorDataSet.AcceptChanges();
            MessageBox.Show("数据已保存");
        }

        private void btnSaveAsConditon_Click(object sender, EventArgs e)
        {

            //var i = conditionTableAdapter.Insert();
            var conditionName = Interaction.InputBox("输入卡类别名称：", "输入");
            creatorDataSet.Condition.AddConditionRow(conditionName,
                                                     txtPrefix.Text,
                                                     txtSuffix.Text, txtSeparator.Text,
                                                     (short) nudCardNumberLength.Value,
                                                     txtCardNumberString.Text,
                                                     (short) nudCardPasswordLength.Value,
                                                     txtCardPasswordString.Text);
            conditionTableAdapter.Update(creatorDataSet.Condition);
            creatorDataSet.AcceptChanges();
            MessageBox.Show("数据已保存");
        }

        private void btnDeleteCondition_Click(object sender, EventArgs e)
        {
            conditionBindingSource.RemoveCurrent();
            conditionTableAdapter.Update(creatorDataSet.Condition);
        }

    }
}

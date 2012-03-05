namespace Creator
{
    partial class frmConditon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbbConditon = new System.Windows.Forms.ComboBox();
            this.conditionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.creatorDataSet = new Creator.CreatorDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSuffix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSeparator = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCardNumberString = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCardPasswordString = new System.Windows.Forms.TextBox();
            this.nudCardNumberLength = new System.Windows.Forms.NumericUpDown();
            this.nudCardPasswordLength = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteCondition = new System.Windows.Forms.Button();
            this.btnSaveAsCondition = new System.Windows.Forms.Button();
            this.btnSaveCondition = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.nudCardCount = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.conditionTableAdapter = new Creator.CreatorDataSetTableAdapters.ConditionTableAdapter();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conditionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creatorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCardNumberLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCardPasswordLength)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCardCount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(648, 259);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "生成条件";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.47253F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.52747F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 245F));
            this.tableLayoutPanel1.Controls.Add(this.cbbConditon, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPrefix, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSuffix, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtSeparator, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCardNumberString, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCardPasswordString, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.nudCardNumberLength, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.nudCardPasswordLength, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(642, 239);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cbbConditon
            // 
            this.cbbConditon.DataSource = this.conditionBindingSource;
            this.cbbConditon.DisplayMember = "ConditionName";
            this.cbbConditon.FormattingEnabled = true;
            this.cbbConditon.Location = new System.Drawing.Point(85, 8);
            this.cbbConditon.Name = "cbbConditon";
            this.cbbConditon.Size = new System.Drawing.Size(112, 20);
            this.cbbConditon.TabIndex = 1;
            this.cbbConditon.ValueMember = "ID";
            // 
            // conditionBindingSource
            // 
            this.conditionBindingSource.DataMember = "Condition";
            this.conditionBindingSource.DataSource = this.creatorDataSet;
            // 
            // creatorDataSet
            // 
            this.creatorDataSet.DataSetName = "CreatorDataSet";
            this.creatorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "模式";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "前缀";
            // 
            // txtPrefix
            // 
            this.txtPrefix.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPrefix.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conditionBindingSource, "Prefix", true));
            this.txtPrefix.Location = new System.Drawing.Point(85, 36);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(112, 21);
            this.txtPrefix.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "后缀";
            // 
            // txtSuffix
            // 
            this.txtSuffix.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSuffix.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conditionBindingSource, "Suffix", true));
            this.txtSuffix.Location = new System.Drawing.Point(394, 36);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(112, 21);
            this.txtSuffix.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "分隔符";
            // 
            // txtSeparator
            // 
            this.txtSeparator.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSeparator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conditionBindingSource, "Separator", true));
            this.txtSeparator.Location = new System.Drawing.Point(85, 64);
            this.txtSeparator.Name = "txtSeparator";
            this.txtSeparator.Size = new System.Drawing.Size(112, 21);
            this.txtSeparator.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "卡号位数";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(322, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "密码位数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "卡号字符集";
            // 
            // txtCardNumberString
            // 
            this.txtCardNumberString.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conditionBindingSource, "CardNumberString", true));
            this.txtCardNumberString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCardNumberString.Location = new System.Drawing.Point(85, 120);
            this.txtCardNumberString.Multiline = true;
            this.txtCardNumberString.Name = "txtCardNumberString";
            this.txtCardNumberString.Size = new System.Drawing.Size(198, 100);
            this.txtCardNumberString.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "密码字符集";
            // 
            // txtCardPasswordString
            // 
            this.txtCardPasswordString.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conditionBindingSource, "CardPasswordString", true));
            this.txtCardPasswordString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCardPasswordString.Location = new System.Drawing.Point(394, 120);
            this.txtCardPasswordString.Multiline = true;
            this.txtCardPasswordString.Name = "txtCardPasswordString";
            this.txtCardPasswordString.Size = new System.Drawing.Size(240, 100);
            this.txtCardPasswordString.TabIndex = 9;
            // 
            // nudCardNumberLength
            // 
            this.nudCardNumberLength.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.conditionBindingSource, "CardNumberLength", true));
            this.nudCardNumberLength.Location = new System.Drawing.Point(85, 92);
            this.nudCardNumberLength.Name = "nudCardNumberLength";
            this.nudCardNumberLength.Size = new System.Drawing.Size(58, 21);
            this.nudCardNumberLength.TabIndex = 10;
            // 
            // nudCardPasswordLength
            // 
            this.nudCardPasswordLength.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.conditionBindingSource, "CardPasswordLength", true));
            this.nudCardPasswordLength.Location = new System.Drawing.Point(394, 92);
            this.nudCardPasswordLength.Name = "nudCardPasswordLength";
            this.nudCardPasswordLength.Size = new System.Drawing.Size(58, 21);
            this.nudCardPasswordLength.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeleteCondition);
            this.panel1.Controls.Add(this.btnSaveAsCondition);
            this.panel1.Controls.Add(this.btnSaveCondition);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(391, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 28);
            this.panel1.TabIndex = 11;
            // 
            // btnDeleteCondition
            // 
            this.btnDeleteCondition.Location = new System.Drawing.Point(161, 3);
            this.btnDeleteCondition.Name = "btnDeleteCondition";
            this.btnDeleteCondition.Size = new System.Drawing.Size(66, 23);
            this.btnDeleteCondition.TabIndex = 2;
            this.btnDeleteCondition.Text = "删除模式";
            this.btnDeleteCondition.UseVisualStyleBackColor = true;
            this.btnDeleteCondition.Click += new System.EventHandler(this.btnDeleteCondition_Click);
            // 
            // btnSaveAsCondition
            // 
            this.btnSaveAsCondition.Location = new System.Drawing.Point(84, 3);
            this.btnSaveAsCondition.Name = "btnSaveAsCondition";
            this.btnSaveAsCondition.Size = new System.Drawing.Size(71, 23);
            this.btnSaveAsCondition.TabIndex = 1;
            this.btnSaveAsCondition.Text = "另存为...";
            this.btnSaveAsCondition.UseVisualStyleBackColor = true;
            this.btnSaveAsCondition.Click += new System.EventHandler(this.btnSaveAsConditon_Click);
            // 
            // btnSaveCondition
            // 
            this.btnSaveCondition.Location = new System.Drawing.Point(3, 3);
            this.btnSaveCondition.Name = "btnSaveCondition";
            this.btnSaveCondition.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCondition.TabIndex = 0;
            this.btnSaveCondition.Text = "保存模式";
            this.btnSaveCondition.UseVisualStyleBackColor = true;
            this.btnSaveCondition.Click += new System.EventHandler(this.btnSaveCondition_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 68);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label10);
            this.flowLayoutPanel1.Controls.Add(this.nudCardCount);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(642, 48);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 13);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "生成数量";
            // 
            // nudCardCount
            // 
            this.nudCardCount.Location = new System.Drawing.Point(64, 8);
            this.nudCardCount.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudCardCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCardCount.Name = "nudCardCount";
            this.nudCardCount.Size = new System.Drawing.Size(77, 21);
            this.nudCardCount.TabIndex = 2;
            this.nudCardCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(194, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "确  定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(251, 8);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "取  消";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // conditionTableAdapter
            // 
            this.conditionTableAdapter.ClearBeforeFill = true;
            // 
            // frmConditon
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(672, 368);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConditon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmConditon";
            this.Load += new System.EventHandler(this.frmConditon_Load);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conditionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creatorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCardNumberLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCardPasswordLength)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCardCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbbConditon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSuffix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSeparator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudCardCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCardNumberString;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCardPasswordString;
        private CreatorDataSet creatorDataSet;
        private System.Windows.Forms.BindingSource conditionBindingSource;
        private CreatorDataSetTableAdapters.ConditionTableAdapter conditionTableAdapter;
        private System.Windows.Forms.NumericUpDown nudCardNumberLength;
        private System.Windows.Forms.NumericUpDown nudCardPasswordLength;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSaveAsCondition;
        private System.Windows.Forms.Button btnSaveCondition;
        private System.Windows.Forms.Button btnDeleteCondition;

    }
}
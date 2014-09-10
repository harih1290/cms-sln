﻿namespace CMS.Main.View
{
    partial class PaymentForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupPayment = new System.Windows.Forms.GroupBox();
            this.rbMembership = new System.Windows.Forms.RadioButton();
            this.rbLoan = new System.Windows.Forms.RadioButton();
            this.groupSearch = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.rbMemberName = new System.Windows.Forms.RadioButton();
            this.rbAccountNo = new System.Windows.Forms.RadioButton();
            this.dataSearch = new System.Windows.Forms.DataGridView();
            this.dataLoan = new System.Windows.Forms.DataGridView();
            this.contextMenuBlank = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupLoan = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.lblPenalty = new System.Windows.Forms.Label();
            this.txtAMChange = new System.Windows.Forms.TextBox();
            this.txtPenaltyList = new System.Windows.Forms.TextBox();
            this.lblCMChange = new System.Windows.Forms.Label();
            this.txtAMAmountTendered = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCMAmountTendered = new System.Windows.Forms.Label();
            this.txtTotalAmortization = new System.Windows.Forms.TextBox();
            this.lblCMTotal = new System.Windows.Forms.Label();
            this.txtPenalty = new System.Windows.Forms.TextBox();
            this.txtAmountDue = new System.Windows.Forms.TextBox();
            this.lblAddPenalty = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.chbPayAll = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLoanType = new System.Windows.Forms.ComboBox();
            this.dataAmortization = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupUnpaidLoans = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupMembership = new System.Windows.Forms.GroupBox();
            this.btnMoveBackAll = new System.Windows.Forms.Button();
            this.btnMoveBackSelected = new System.Windows.Forms.Button();
            this.btnMoveAll = new System.Windows.Forms.Button();
            this.dataAddedFee = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataFee = new System.Windows.Forms.DataGridView();
            this.btnMoveSelected = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.linkClosePayments = new System.Windows.Forms.Button();
            this.groupPayment.SuspendLayout();
            this.groupSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLoan)).BeginInit();
            this.groupLoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAmortization)).BeginInit();
            this.groupUnpaidLoans.SuspendLayout();
            this.groupMembership.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAddedFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(480, 492);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 31);
            this.btnClear.TabIndex = 50;
            this.btnClear.Text = "Cancel";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(365, 492);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 31);
            this.btnSave.TabIndex = 49;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // groupPayment
            // 
            this.groupPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupPayment.Controls.Add(this.rbMembership);
            this.groupPayment.Controls.Add(this.rbLoan);
            this.groupPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupPayment.Location = new System.Drawing.Point(495, 36);
            this.groupPayment.Name = "groupPayment";
            this.groupPayment.Size = new System.Drawing.Size(470, 61);
            this.groupPayment.TabIndex = 8;
            this.groupPayment.TabStop = false;
            this.groupPayment.Text = "Payment Type:";
            // 
            // rbMembership
            // 
            this.rbMembership.AutoSize = true;
            this.rbMembership.Checked = true;
            this.rbMembership.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rbMembership.Location = new System.Drawing.Point(211, 28);
            this.rbMembership.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbMembership.Name = "rbMembership";
            this.rbMembership.Size = new System.Drawing.Size(108, 21);
            this.rbMembership.TabIndex = 10;
            this.rbMembership.TabStop = true;
            this.rbMembership.Text = "Miscellaneous";
            this.rbMembership.UseVisualStyleBackColor = true;
            this.rbMembership.CheckedChanged += new System.EventHandler(this.radioMembership_CheckedChanged);
            // 
            // rbLoan
            // 
            this.rbLoan.AutoSize = true;
            this.rbLoan.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rbLoan.Location = new System.Drawing.Point(56, 28);
            this.rbLoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbLoan.Name = "rbLoan";
            this.rbLoan.Size = new System.Drawing.Size(107, 21);
            this.rbLoan.TabIndex = 9;
            this.rbLoan.TabStop = true;
            this.rbLoan.Text = "Loan Payment";
            this.rbLoan.UseVisualStyleBackColor = true;
            this.rbLoan.CheckedChanged += new System.EventHandler(this.radioLoan_CheckedChanged);
            // 
            // groupSearch
            // 
            this.groupSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupSearch.Controls.Add(this.label1);
            this.groupSearch.Controls.Add(this.txtMemberName);
            this.groupSearch.Controls.Add(this.txtAccountNo);
            this.groupSearch.Controls.Add(this.rbMemberName);
            this.groupSearch.Controls.Add(this.rbAccountNo);
            this.groupSearch.Controls.Add(this.dataSearch);
            this.groupSearch.Controls.Add(this.dataLoan);
            this.groupSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSearch.Location = new System.Drawing.Point(6, 35);
            this.groupSearch.Name = "groupSearch";
            this.groupSearch.Size = new System.Drawing.Size(482, 262);
            this.groupSearch.TabIndex = 1;
            this.groupSearch.TabStop = false;
            this.groupSearch.Text = "Search Member:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search by:";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Enabled = false;
            this.txtMemberName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberName.Location = new System.Drawing.Point(227, 53);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(249, 25);
            this.txtMemberName.TabIndex = 6;
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Enabled = false;
            this.txtAccountNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNo.Location = new System.Drawing.Point(227, 22);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(249, 25);
            this.txtAccountNo.TabIndex = 4;
            // 
            // rbMemberName
            // 
            this.rbMemberName.AutoSize = true;
            this.rbMemberName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMemberName.Location = new System.Drawing.Point(86, 54);
            this.rbMemberName.Name = "rbMemberName";
            this.rbMemberName.Size = new System.Drawing.Size(118, 21);
            this.rbMemberName.TabIndex = 5;
            this.rbMemberName.TabStop = true;
            this.rbMemberName.Text = "Member Name:";
            this.rbMemberName.UseVisualStyleBackColor = true;
            this.rbMemberName.CheckedChanged += new System.EventHandler(this.rbMemberName_CheckedChanged);
            // 
            // rbAccountNo
            // 
            this.rbAccountNo.AutoSize = true;
            this.rbAccountNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAccountNo.Location = new System.Drawing.Point(86, 23);
            this.rbAccountNo.Name = "rbAccountNo";
            this.rbAccountNo.Size = new System.Drawing.Size(127, 21);
            this.rbAccountNo.TabIndex = 3;
            this.rbAccountNo.TabStop = true;
            this.rbAccountNo.Text = "Account Number:";
            this.rbAccountNo.UseVisualStyleBackColor = true;
            this.rbAccountNo.CheckedChanged += new System.EventHandler(this.rbAccountNo_CheckedChanged);
            // 
            // dataSearch
            // 
            this.dataSearch.AllowUserToAddRows = false;
            this.dataSearch.AllowUserToDeleteRows = false;
            this.dataSearch.AllowUserToOrderColumns = true;
            this.dataSearch.AllowUserToResizeRows = false;
            this.dataSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataSearch.BackgroundColor = System.Drawing.Color.Silver;
            this.dataSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataSearch.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataSearch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataSearch.Location = new System.Drawing.Point(6, 83);
            this.dataSearch.Name = "dataSearch";
            this.dataSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataSearch.Size = new System.Drawing.Size(470, 169);
            this.dataSearch.TabIndex = 7;
            this.dataSearch.Visible = false;
            this.dataSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSearch_CellClick);
            // 
            // dataLoan
            // 
            this.dataLoan.AllowUserToAddRows = false;
            this.dataLoan.AllowUserToDeleteRows = false;
            this.dataLoan.AllowUserToOrderColumns = true;
            this.dataLoan.AllowUserToResizeRows = false;
            this.dataLoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataLoan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataLoan.BackgroundColor = System.Drawing.Color.Silver;
            this.dataLoan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataLoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataLoan.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataLoan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataLoan.Location = new System.Drawing.Point(6, 83);
            this.dataLoan.Name = "dataLoan";
            this.dataLoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLoan.Size = new System.Drawing.Size(470, 170);
            this.dataLoan.TabIndex = 70;
            this.dataLoan.Visible = false;
            this.dataLoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLoan_CellClick);
            // 
            // contextMenuBlank
            // 
            this.contextMenuBlank.Name = "contextMenuBlank";
            this.contextMenuBlank.Size = new System.Drawing.Size(61, 4);
            // 
            // groupLoan
            // 
            this.groupLoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupLoan.Controls.Add(this.label2);
            this.groupLoan.Controls.Add(this.txtInterest);
            this.groupLoan.Controls.Add(this.lblPenalty);
            this.groupLoan.Controls.Add(this.txtAMChange);
            this.groupLoan.Controls.Add(this.txtPenaltyList);
            this.groupLoan.Controls.Add(this.lblCMChange);
            this.groupLoan.Controls.Add(this.txtAMAmountTendered);
            this.groupLoan.Controls.Add(this.label6);
            this.groupLoan.Controls.Add(this.lblCMAmountTendered);
            this.groupLoan.Controls.Add(this.txtTotalAmortization);
            this.groupLoan.Controls.Add(this.lblCMTotal);
            this.groupLoan.Controls.Add(this.txtPenalty);
            this.groupLoan.Controls.Add(this.txtAmountDue);
            this.groupLoan.Controls.Add(this.lblAddPenalty);
            this.groupLoan.Controls.Add(this.lblAmountDue);
            this.groupLoan.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupLoan.Location = new System.Drawing.Point(9, 305);
            this.groupLoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupLoan.Name = "groupLoan";
            this.groupLoan.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupLoan.Size = new System.Drawing.Size(956, 179);
            this.groupLoan.TabIndex = 18;
            this.groupLoan.TabStop = false;
            this.groupLoan.Text = "Loan Payment:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(542, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Interest";
            // 
            // txtInterest
            // 
            this.txtInterest.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterest.Location = new System.Drawing.Point(616, 87);
            this.txtInterest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.ReadOnly = true;
            this.txtInterest.Size = new System.Drawing.Size(100, 29);
            this.txtInterest.TabIndex = 26;
            this.txtInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPenalty
            // 
            this.lblPenalty.AutoSize = true;
            this.lblPenalty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenalty.Location = new System.Drawing.Point(9, 25);
            this.lblPenalty.Name = "lblPenalty";
            this.lblPenalty.Size = new System.Drawing.Size(122, 17);
            this.lblPenalty.TabIndex = 19;
            this.lblPenalty.Text = "Notes and Details:";
            // 
            // txtAMChange
            // 
            this.txtAMChange.ContextMenuStrip = this.contextMenuBlank;
            this.txtAMChange.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtAMChange.Location = new System.Drawing.Point(761, 137);
            this.txtAMChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAMChange.Name = "txtAMChange";
            this.txtAMChange.ReadOnly = true;
            this.txtAMChange.Size = new System.Drawing.Size(187, 29);
            this.txtAMChange.TabIndex = 33;
            this.txtAMChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPenaltyList
            // 
            this.txtPenaltyList.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPenaltyList.Location = new System.Drawing.Point(7, 45);
            this.txtPenaltyList.Multiline = true;
            this.txtPenaltyList.Name = "txtPenaltyList";
            this.txtPenaltyList.ReadOnly = true;
            this.txtPenaltyList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPenaltyList.Size = new System.Drawing.Size(447, 121);
            this.txtPenaltyList.TabIndex = 20;
            this.txtPenaltyList.WordWrap = false;
            // 
            // lblCMChange
            // 
            this.lblCMChange.AutoSize = true;
            this.lblCMChange.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMChange.Location = new System.Drawing.Point(757, 116);
            this.lblCMChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCMChange.Name = "lblCMChange";
            this.lblCMChange.Size = new System.Drawing.Size(65, 20);
            this.lblCMChange.TabIndex = 32;
            this.lblCMChange.Text = "Change:";
            // 
            // txtAMAmountTendered
            // 
            this.txtAMAmountTendered.ContextMenuStrip = this.contextMenuBlank;
            this.txtAMAmountTendered.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtAMAmountTendered.Location = new System.Drawing.Point(761, 81);
            this.txtAMAmountTendered.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAMAmountTendered.MaxLength = 7;
            this.txtAMAmountTendered.Name = "txtAMAmountTendered";
            this.txtAMAmountTendered.Size = new System.Drawing.Size(187, 29);
            this.txtAMAmountTendered.TabIndex = 31;
            this.txtAMAmountTendered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAMAmountTendered.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAMAmountTendered_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(494, 104);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "_____________________________________";
            // 
            // lblCMAmountTendered
            // 
            this.lblCMAmountTendered.AutoSize = true;
            this.lblCMAmountTendered.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMAmountTendered.Location = new System.Drawing.Point(757, 58);
            this.lblCMAmountTendered.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCMAmountTendered.Name = "lblCMAmountTendered";
            this.lblCMAmountTendered.Size = new System.Drawing.Size(136, 20);
            this.lblCMAmountTendered.TabIndex = 30;
            this.lblCMAmountTendered.Text = "Amount Tendered:";
            // 
            // txtTotalAmortization
            // 
            this.txtTotalAmortization.ContextMenuStrip = this.contextMenuBlank;
            this.txtTotalAmortization.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtTotalAmortization.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtTotalAmortization.Location = new System.Drawing.Point(589, 134);
            this.txtTotalAmortization.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalAmortization.Name = "txtTotalAmortization";
            this.txtTotalAmortization.ReadOnly = true;
            this.txtTotalAmortization.Size = new System.Drawing.Size(127, 31);
            this.txtTotalAmortization.TabIndex = 29;
            this.txtTotalAmortization.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCMTotal
            // 
            this.lblCMTotal.AutoSize = true;
            this.lblCMTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMTotal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCMTotal.Location = new System.Drawing.Point(490, 141);
            this.lblCMTotal.Name = "lblCMTotal";
            this.lblCMTotal.Size = new System.Drawing.Size(92, 25);
            this.lblCMTotal.TabIndex = 28;
            this.lblCMTotal.Text = "TOTAL:";
            // 
            // txtPenalty
            // 
            this.txtPenalty.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenalty.Location = new System.Drawing.Point(616, 56);
            this.txtPenalty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPenalty.Name = "txtPenalty";
            this.txtPenalty.ReadOnly = true;
            this.txtPenalty.Size = new System.Drawing.Size(100, 29);
            this.txtPenalty.TabIndex = 24;
            this.txtPenalty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAmountDue
            // 
            this.txtAmountDue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountDue.Location = new System.Drawing.Point(604, 19);
            this.txtAmountDue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAmountDue.Name = "txtAmountDue";
            this.txtAmountDue.ReadOnly = true;
            this.txtAmountDue.Size = new System.Drawing.Size(112, 29);
            this.txtAmountDue.TabIndex = 22;
            this.txtAmountDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAddPenalty
            // 
            this.lblAddPenalty.AutoSize = true;
            this.lblAddPenalty.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPenalty.Location = new System.Drawing.Point(503, 62);
            this.lblAddPenalty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddPenalty.Name = "lblAddPenalty";
            this.lblAddPenalty.Size = new System.Drawing.Size(93, 17);
            this.lblAddPenalty.TabIndex = 23;
            this.lblAddPenalty.Text = "Add: Penalites";
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountDue.Location = new System.Drawing.Point(491, 21);
            this.lblAmountDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(106, 21);
            this.lblAmountDue.TabIndex = 21;
            this.lblAmountDue.Text = "Amount Due:";
            // 
            // chbPayAll
            // 
            this.chbPayAll.AutoSize = true;
            this.chbPayAll.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPayAll.Location = new System.Drawing.Point(377, 52);
            this.chbPayAll.Name = "chbPayAll";
            this.chbPayAll.Size = new System.Drawing.Size(70, 21);
            this.chbPayAll.TabIndex = 16;
            this.chbPayAll.Text = "Pay All";
            this.chbPayAll.UseVisualStyleBackColor = true;
            this.chbPayAll.CheckedChanged += new System.EventHandler(this.chbPayAll_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.Location = new System.Drawing.Point(41, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Select Loan:";
            // 
            // cbLoanType
            // 
            this.cbLoanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoanType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLoanType.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbLoanType.FormattingEnabled = true;
            this.cbLoanType.Location = new System.Drawing.Point(118, 26);
            this.cbLoanType.Name = "cbLoanType";
            this.cbLoanType.Size = new System.Drawing.Size(231, 25);
            this.cbLoanType.TabIndex = 13;
            // 
            // dataAmortization
            // 
            this.dataAmortization.AllowUserToAddRows = false;
            this.dataAmortization.AllowUserToDeleteRows = false;
            this.dataAmortization.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataAmortization.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataAmortization.BackgroundColor = System.Drawing.Color.Silver;
            this.dataAmortization.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataAmortization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAmortization.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataAmortization.Location = new System.Drawing.Point(27, 76);
            this.dataAmortization.Name = "dataAmortization";
            this.dataAmortization.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataAmortization.Size = new System.Drawing.Size(420, 104);
            this.dataAmortization.TabIndex = 17;
            this.dataAmortization.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAmortization_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(24, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Amortizations:";
            // 
            // groupUnpaidLoans
            // 
            this.groupUnpaidLoans.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupUnpaidLoans.Controls.Add(this.chbPayAll);
            this.groupUnpaidLoans.Controls.Add(this.dataAmortization);
            this.groupUnpaidLoans.Controls.Add(this.label5);
            this.groupUnpaidLoans.Controls.Add(this.label3);
            this.groupUnpaidLoans.Controls.Add(this.cbLoanType);
            this.groupUnpaidLoans.Controls.Add(this.label4);
            this.groupUnpaidLoans.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupUnpaidLoans.Location = new System.Drawing.Point(495, 103);
            this.groupUnpaidLoans.Name = "groupUnpaidLoans";
            this.groupUnpaidLoans.Size = new System.Drawing.Size(470, 195);
            this.groupUnpaidLoans.TabIndex = 11;
            this.groupUnpaidLoans.TabStop = false;
            this.groupUnpaidLoans.Text = "Unpaid Loans:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(115, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "(Please check to pay)";
            // 
            // groupMembership
            // 
            this.groupMembership.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupMembership.Controls.Add(this.btnMoveBackAll);
            this.groupMembership.Controls.Add(this.btnMoveBackSelected);
            this.groupMembership.Controls.Add(this.btnMoveAll);
            this.groupMembership.Controls.Add(this.dataAddedFee);
            this.groupMembership.Controls.Add(this.txtChange);
            this.groupMembership.Controls.Add(this.label7);
            this.groupMembership.Controls.Add(this.txtAmount);
            this.groupMembership.Controls.Add(this.label8);
            this.groupMembership.Controls.Add(this.txtTotalAmount);
            this.groupMembership.Controls.Add(this.label9);
            this.groupMembership.Controls.Add(this.label11);
            this.groupMembership.Controls.Add(this.dataFee);
            this.groupMembership.Controls.Add(this.btnMoveSelected);
            this.groupMembership.Controls.Add(this.label12);
            this.groupMembership.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupMembership.Location = new System.Drawing.Point(495, 107);
            this.groupMembership.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupMembership.Name = "groupMembership";
            this.groupMembership.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupMembership.Size = new System.Drawing.Size(470, 377);
            this.groupMembership.TabIndex = 34;
            this.groupMembership.TabStop = false;
            this.groupMembership.Text = "Miscellaneous Fees:";
            // 
            // btnMoveBackAll
            // 
            this.btnMoveBackAll.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMoveBackAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMoveBackAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveBackAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveBackAll.ForeColor = System.Drawing.Color.White;
            this.btnMoveBackAll.Location = new System.Drawing.Point(212, 197);
            this.btnMoveBackAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMoveBackAll.Name = "btnMoveBackAll";
            this.btnMoveBackAll.Size = new System.Drawing.Size(50, 30);
            this.btnMoveBackAll.TabIndex = 40;
            this.btnMoveBackAll.Text = "<<";
            this.btnMoveBackAll.UseVisualStyleBackColor = false;
            // 
            // btnMoveBackSelected
            // 
            this.btnMoveBackSelected.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMoveBackSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMoveBackSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveBackSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveBackSelected.ForeColor = System.Drawing.Color.White;
            this.btnMoveBackSelected.Location = new System.Drawing.Point(212, 161);
            this.btnMoveBackSelected.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMoveBackSelected.Name = "btnMoveBackSelected";
            this.btnMoveBackSelected.Size = new System.Drawing.Size(50, 30);
            this.btnMoveBackSelected.TabIndex = 39;
            this.btnMoveBackSelected.Text = "<";
            this.btnMoveBackSelected.UseVisualStyleBackColor = false;
            // 
            // btnMoveAll
            // 
            this.btnMoveAll.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMoveAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveAll.ForeColor = System.Drawing.Color.White;
            this.btnMoveAll.Location = new System.Drawing.Point(212, 106);
            this.btnMoveAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMoveAll.Name = "btnMoveAll";
            this.btnMoveAll.Size = new System.Drawing.Size(50, 30);
            this.btnMoveAll.TabIndex = 38;
            this.btnMoveAll.Text = ">>";
            this.btnMoveAll.UseVisualStyleBackColor = false;
            // 
            // dataAddedFee
            // 
            this.dataAddedFee.AllowUserToAddRows = false;
            this.dataAddedFee.AllowUserToDeleteRows = false;
            this.dataAddedFee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataAddedFee.BackgroundColor = System.Drawing.Color.Silver;
            this.dataAddedFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAddedFee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataAddedFee.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataAddedFee.Location = new System.Drawing.Point(270, 48);
            this.dataAddedFee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataAddedFee.Name = "dataAddedFee";
            this.dataAddedFee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataAddedFee.Size = new System.Drawing.Size(192, 187);
            this.dataAddedFee.TabIndex = 42;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Fee";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // txtChange
            // 
            this.txtChange.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtChange.Location = new System.Drawing.Point(310, 338);
            this.txtChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(152, 29);
            this.txtChange.TabIndex = 48;
            this.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(223, 342);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Change:";
            // 
            // txtAmount
            // 
            this.txtAmount.ContextMenuStrip = this.contextMenuBlank;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtAmount.Location = new System.Drawing.Point(310, 299);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAmount.MaxLength = 7;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(152, 29);
            this.txtAmount.TabIndex = 46;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(223, 288);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 40);
            this.label8.TabIndex = 45;
            this.label8.Text = "Amount \r\nTendered:";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtTotalAmount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtTotalAmount.Location = new System.Drawing.Point(310, 248);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(152, 31);
            this.txtTotalAmount.TabIndex = 44;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(210, 250);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 25);
            this.label9.TabIndex = 43;
            this.label9.Text = "TOTAL:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label11.Location = new System.Drawing.Point(252, 25);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 17);
            this.label11.TabIndex = 41;
            this.label11.Text = "Currently Added:";
            // 
            // dataFee
            // 
            this.dataFee.AllowUserToAddRows = false;
            this.dataFee.AllowUserToDeleteRows = false;
            this.dataFee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataFee.BackgroundColor = System.Drawing.Color.Silver;
            this.dataFee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFee.Location = new System.Drawing.Point(6, 48);
            this.dataFee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataFee.Name = "dataFee";
            this.dataFee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataFee.Size = new System.Drawing.Size(200, 316);
            this.dataFee.TabIndex = 36;
            // 
            // btnMoveSelected
            // 
            this.btnMoveSelected.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMoveSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMoveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveSelected.ForeColor = System.Drawing.Color.White;
            this.btnMoveSelected.Location = new System.Drawing.Point(212, 66);
            this.btnMoveSelected.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMoveSelected.Name = "btnMoveSelected";
            this.btnMoveSelected.Size = new System.Drawing.Size(50, 30);
            this.btnMoveSelected.TabIndex = 37;
            this.btnMoveSelected.Text = ">";
            this.btnMoveSelected.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label12.Location = new System.Drawing.Point(8, 26);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 17);
            this.label12.TabIndex = 35;
            this.label12.Text = "Particulars:";
            // 
            // linkClosePayments
            // 
            this.linkClosePayments.BackColor = System.Drawing.Color.Firebrick;
            this.linkClosePayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linkClosePayments.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkClosePayments.ForeColor = System.Drawing.Color.White;
            this.linkClosePayments.Location = new System.Drawing.Point(905, 3);
            this.linkClosePayments.Name = "linkClosePayments";
            this.linkClosePayments.Size = new System.Drawing.Size(92, 32);
            this.linkClosePayments.TabIndex = 72;
            this.linkClosePayments.Text = "Close";
            this.linkClosePayments.UseVisualStyleBackColor = false;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.linkClosePayments);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupPayment);
            this.Controls.Add(this.groupSearch);
            this.Controls.Add(this.groupUnpaidLoans);
            this.Controls.Add(this.groupLoan);
            this.Controls.Add(this.groupMembership);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PaymentForm";
            this.Size = new System.Drawing.Size(1000, 530);
            this.groupPayment.ResumeLayout(false);
            this.groupPayment.PerformLayout();
            this.groupSearch.ResumeLayout(false);
            this.groupSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLoan)).EndInit();
            this.groupLoan.ResumeLayout(false);
            this.groupLoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAmortization)).EndInit();
            this.groupUnpaidLoans.ResumeLayout(false);
            this.groupUnpaidLoans.PerformLayout();
            this.groupMembership.ResumeLayout(false);
            this.groupMembership.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAddedFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupPayment;
        private System.Windows.Forms.RadioButton rbMembership;
        private System.Windows.Forms.RadioButton rbLoan;
        private System.Windows.Forms.GroupBox groupSearch;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.RadioButton rbMemberName;
        private System.Windows.Forms.RadioButton rbAccountNo;
        private System.Windows.Forms.GroupBox groupLoan;
        private System.Windows.Forms.TextBox txtPenalty;
        private System.Windows.Forms.TextBox txtAmountDue;
        private System.Windows.Forms.Label lblAddPenalty;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.ContextMenuStrip contextMenuBlank;
        private System.Windows.Forms.TextBox txtPenaltyList;
        private System.Windows.Forms.Label lblPenalty;
        private System.Windows.Forms.TextBox txtAMChange;
        private System.Windows.Forms.Label lblCMChange;
        private System.Windows.Forms.TextBox txtAMAmountTendered;
        private System.Windows.Forms.Label lblCMAmountTendered;
        private System.Windows.Forms.TextBox txtTotalAmortization;
        private System.Windows.Forms.Label lblCMTotal;
        private System.Windows.Forms.DataGridView dataLoan;
        public System.Windows.Forms.DataGridView dataAmortization;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.CheckBox chbPayAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLoanType;
        private System.Windows.Forms.DataGridView dataSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupUnpaidLoans;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupMembership;
        private System.Windows.Forms.Button btnMoveBackAll;
        private System.Windows.Forms.Button btnMoveBackSelected;
        private System.Windows.Forms.Button btnMoveAll;
        private System.Windows.Forms.DataGridView dataAddedFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataFee;
        private System.Windows.Forms.Button btnMoveSelected;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button linkClosePayments;



    }
}
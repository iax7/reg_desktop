namespace Registration
{
    partial class RegistrationData
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.grdGuests = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdFood = new System.Windows.Forms.DataGridView();
            this.option = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAllocation = new System.Windows.Forms.FlowLayoutPanel();
            this.lblN1 = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lblN3 = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlPay = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPay1 = new System.Windows.Forms.Label();
            this.lblPay2 = new System.Windows.Forms.Label();
            this.lblPay3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdGuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFood)).BeginInit();
            this.pnlAllocation.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlPay.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoEllipsis = true;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(4, 0);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 32);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoEllipsis = true;
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(5, 36);
            this.lblSubTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(63, 25);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "label1";
            // 
            // grdGuests
            // 
            this.grdGuests.AllowUserToAddRows = false;
            this.grdGuests.AllowUserToDeleteRows = false;
            this.grdGuests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdGuests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grdGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGuests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.nickname,
            this.Age,
            this.relation});
            this.grdGuests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdGuests.Location = new System.Drawing.Point(42, 63);
            this.grdGuests.Name = "grdGuests";
            this.grdGuests.ReadOnly = true;
            this.grdGuests.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grdGuests.Size = new System.Drawing.Size(480, 123);
            this.grdGuests.TabIndex = 2;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Nombre";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // nickname
            // 
            this.nickname.DataPropertyName = "nickname";
            this.nickname.HeaderText = "Sobrenombre";
            this.nickname.Name = "nickname";
            this.nickname.ReadOnly = true;
            this.nickname.Width = 110;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "age";
            this.Age.HeaderText = "Edad";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // relation
            // 
            this.relation.DataPropertyName = "relation";
            this.relation.HeaderText = "Relación";
            this.relation.Name = "relation";
            this.relation.ReadOnly = true;
            // 
            // grdFood
            // 
            this.grdFood.AllowUserToAddRows = false;
            this.grdFood.AllowUserToDeleteRows = false;
            this.grdFood.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.option,
            this.v3,
            this.s1,
            this.s2,
            this.s3,
            this.d1,
            this.d2,
            this.d3,
            this.l1});
            this.grdFood.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdFood.Location = new System.Drawing.Point(42, 192);
            this.grdFood.Name = "grdFood";
            this.grdFood.ReadOnly = true;
            this.grdFood.Size = new System.Drawing.Size(480, 85);
            this.grdFood.TabIndex = 3;
            // 
            // option
            // 
            this.option.DataPropertyName = "created_at";
            this.option.Frozen = true;
            this.option.HeaderText = "Tipo";
            this.option.Name = "option";
            this.option.ReadOnly = true;
            // 
            // v3
            // 
            this.v3.DataPropertyName = "v3";
            this.v3.Frozen = true;
            this.v3.HeaderText = "V3";
            this.v3.Name = "v3";
            this.v3.ReadOnly = true;
            this.v3.Width = 40;
            // 
            // s1
            // 
            this.s1.DataPropertyName = "s1";
            this.s1.HeaderText = "S1";
            this.s1.Name = "s1";
            this.s1.ReadOnly = true;
            this.s1.Width = 40;
            // 
            // s2
            // 
            this.s2.DataPropertyName = "s2";
            this.s2.HeaderText = "S2";
            this.s2.Name = "s2";
            this.s2.ReadOnly = true;
            this.s2.Width = 40;
            // 
            // s3
            // 
            this.s3.DataPropertyName = "s3";
            this.s3.HeaderText = "S3";
            this.s3.Name = "s3";
            this.s3.ReadOnly = true;
            this.s3.Width = 40;
            // 
            // d1
            // 
            this.d1.DataPropertyName = "d1";
            this.d1.HeaderText = "D1";
            this.d1.Name = "d1";
            this.d1.ReadOnly = true;
            this.d1.Width = 40;
            // 
            // d2
            // 
            this.d2.DataPropertyName = "d2";
            this.d2.HeaderText = "D2";
            this.d2.Name = "d2";
            this.d2.ReadOnly = true;
            this.d2.Width = 40;
            // 
            // d3
            // 
            this.d3.DataPropertyName = "d3";
            this.d3.HeaderText = "D3";
            this.d3.Name = "d3";
            this.d3.ReadOnly = true;
            this.d3.Width = 40;
            // 
            // l1
            // 
            this.l1.DataPropertyName = "l1";
            this.l1.HeaderText = "L1";
            this.l1.Name = "l1";
            this.l1.ReadOnly = true;
            this.l1.Width = 40;
            // 
            // pnlAllocation
            // 
            this.pnlAllocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAllocation.Controls.Add(this.lblN1);
            this.pnlAllocation.Controls.Add(this.lblN2);
            this.pnlAllocation.Controls.Add(this.lblN3);
            this.pnlAllocation.Location = new System.Drawing.Point(42, 283);
            this.pnlAllocation.Name = "pnlAllocation";
            this.pnlAllocation.Size = new System.Drawing.Size(480, 49);
            this.pnlAllocation.TabIndex = 5;
            // 
            // lblN1
            // 
            this.lblN1.AutoEllipsis = true;
            this.lblN1.AutoSize = true;
            this.lblN1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN1.Location = new System.Drawing.Point(4, 0);
            this.lblN1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(65, 25);
            this.lblN1.TabIndex = 1;
            this.lblN1.Text = "label1";
            // 
            // lblN2
            // 
            this.lblN2.AutoEllipsis = true;
            this.lblN2.AutoSize = true;
            this.lblN2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN2.Location = new System.Drawing.Point(77, 0);
            this.lblN2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(65, 25);
            this.lblN2.TabIndex = 2;
            this.lblN2.Text = "label1";
            // 
            // lblN3
            // 
            this.lblN3.AutoEllipsis = true;
            this.lblN3.AutoSize = true;
            this.lblN3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN3.Location = new System.Drawing.Point(150, 0);
            this.lblN3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblN3.Name = "lblN3";
            this.lblN3.Size = new System.Drawing.Size(65, 25);
            this.lblN3.TabIndex = 3;
            this.lblN3.Text = "label1";
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblName);
            this.pnlTop.Controls.Add(this.lblSubTitle);
            this.pnlTop.Location = new System.Drawing.Point(19, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(484, 61);
            this.pnlTop.TabIndex = 6;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox5.Image = global::Registration.Properties.Resources.credit_card_ffffff_32;
            this.pictureBox5.Location = new System.Drawing.Point(4, 334);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox4.Image = global::Registration.Properties.Resources.bus_ffffff_32;
            this.pictureBox4.Location = new System.Drawing.Point(4, 119);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.Image = global::Registration.Properties.Resources.suitcase_ffffff_32;
            this.pictureBox3.Location = new System.Drawing.Point(4, 283);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = global::Registration.Properties.Resources.cutlery_ffffff_32;
            this.pictureBox2.Location = new System.Drawing.Point(4, 192);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Registration.Properties.Resources.users_ffffff_32;
            this.pictureBox1.Location = new System.Drawing.Point(4, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pnlPay
            // 
            this.pnlPay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPay.Controls.Add(this.lblPay1);
            this.pnlPay.Controls.Add(this.lblPay2);
            this.pnlPay.Controls.Add(this.lblPay3);
            this.pnlPay.Location = new System.Drawing.Point(42, 334);
            this.pnlPay.Name = "pnlPay";
            this.pnlPay.Size = new System.Drawing.Size(480, 49);
            this.pnlPay.TabIndex = 12;
            // 
            // lblPay1
            // 
            this.lblPay1.AutoEllipsis = true;
            this.lblPay1.AutoSize = true;
            this.lblPay1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPay1.Location = new System.Drawing.Point(4, 0);
            this.lblPay1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPay1.Name = "lblPay1";
            this.lblPay1.Size = new System.Drawing.Size(77, 25);
            this.lblPay1.TabIndex = 1;
            this.lblPay1.Text = "lblPay1";
            // 
            // lblPay2
            // 
            this.lblPay2.AutoEllipsis = true;
            this.lblPay2.AutoSize = true;
            this.lblPay2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPay2.Location = new System.Drawing.Point(89, 0);
            this.lblPay2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPay2.Name = "lblPay2";
            this.lblPay2.Size = new System.Drawing.Size(77, 25);
            this.lblPay2.TabIndex = 2;
            this.lblPay2.Text = "lblPay2";
            // 
            // lblPay3
            // 
            this.lblPay3.AutoEllipsis = true;
            this.lblPay3.AutoSize = true;
            this.lblPay3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPay3.Location = new System.Drawing.Point(174, 0);
            this.lblPay3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPay3.Name = "lblPay3";
            this.lblPay3.Size = new System.Drawing.Size(65, 25);
            this.lblPay3.TabIndex = 3;
            this.lblPay3.Text = "label1";
            // 
            // RegistrationData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlPay);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlAllocation);
            this.Controls.Add(this.grdFood);
            this.Controls.Add(this.grdGuests);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegistrationData";
            this.Size = new System.Drawing.Size(538, 386);
            ((System.ComponentModel.ISupportInitialize)(this.grdGuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFood)).EndInit();
            this.pnlAllocation.ResumeLayout(false);
            this.pnlAllocation.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlPay.ResumeLayout(false);
            this.pnlPay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblSubTitle;
        public System.Windows.Forms.DataGridView grdGuests;
        public System.Windows.Forms.DataGridView grdFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn option;
        private System.Windows.Forms.DataGridViewTextBoxColumn v3;
        private System.Windows.Forms.DataGridViewTextBoxColumn s1;
        private System.Windows.Forms.DataGridViewTextBoxColumn s2;
        private System.Windows.Forms.DataGridViewTextBoxColumn s3;
        private System.Windows.Forms.DataGridViewTextBoxColumn d1;
        private System.Windows.Forms.DataGridViewTextBoxColumn d2;
        private System.Windows.Forms.DataGridViewTextBoxColumn d3;
        private System.Windows.Forms.DataGridViewTextBoxColumn l1;
        public System.Windows.Forms.Label lblN1;
        public System.Windows.Forms.Label lblN2;
        public System.Windows.Forms.Label lblN3;
        public System.Windows.Forms.FlowLayoutPanel pnlAllocation;
        public System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn nickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn relation;
        private System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.FlowLayoutPanel pnlPay;
        public System.Windows.Forms.Label lblPay1;
        public System.Windows.Forms.Label lblPay2;
        public System.Windows.Forms.Label lblPay3;
    }
}

namespace JobPortal
{
    partial class EducationInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EducationInfo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnContactUs = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlButtom = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblDTitle = new System.Windows.Forms.Label();
            this.txtDTitle = new System.Windows.Forms.TextBox();
            this.lblPlace = new System.Windows.Forms.Label();
            this.cmbPlace = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textInsName = new System.Windows.Forms.TextBox();
            this.drpDegree = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.eduDataGrid = new System.Windows.Forms.DataGridView();
            this.degree_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.institution_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passing_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DegreeTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlButtom.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eduDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Indigo;
            this.pnlTop.Controls.Add(this.btnBack);
            this.pnlTop.Controls.Add(this.panel1);
            this.pnlTop.Controls.Add(this.btnContactUs);
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1151, 73);
            this.pnlTop.TabIndex = 11;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(787, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(175, 55);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 435);
            this.panel1.TabIndex = 3;
            // 
            // btnContactUs
            // 
            this.btnContactUs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContactUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnContactUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContactUs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContactUs.Location = new System.Drawing.Point(968, 12);
            this.btnContactUs.Name = "btnContactUs";
            this.btnContactUs.Size = new System.Drawing.Size(175, 55);
            this.btnContactUs.TabIndex = 3;
            this.btnContactUs.Text = "Log Out";
            this.btnContactUs.UseVisualStyleBackColor = false;
            this.btnContactUs.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(657, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(494, 48);
            this.label5.TabIndex = 0;
            this.label5.Text = "Build Your Carrer With Us";
            // 
            // pnlButtom
            // 
            this.pnlButtom.BackColor = System.Drawing.Color.Indigo;
            this.pnlButtom.Controls.Add(this.label5);
            this.pnlButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtom.Location = new System.Drawing.Point(0, 716);
            this.pnlButtom.Name = "pnlButtom";
            this.pnlButtom.Size = new System.Drawing.Size(1151, 69);
            this.pnlButtom.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.eduDataGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1151, 643);
            this.panel2.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.lblDTitle);
            this.groupBox1.Controls.Add(this.txtDTitle);
            this.groupBox1.Controls.Add(this.lblPlace);
            this.groupBox1.Controls.Add(this.cmbPlace);
            this.groupBox1.Controls.Add(this.lblYear);
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Controls.Add(this.lblGroup);
            this.groupBox1.Controls.Add(this.cmbGroup);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textInsName);
            this.groupBox1.Controls.Add(this.drpDegree);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(146, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 432);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Education Information";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(373, 361);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 56);
            this.btnUpdate.TabIndex = 49;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblDTitle
            // 
            this.lblDTitle.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDTitle.Location = new System.Drawing.Point(148, 311);
            this.lblDTitle.Name = "lblDTitle";
            this.lblDTitle.Size = new System.Drawing.Size(176, 34);
            this.lblDTitle.TabIndex = 48;
            this.lblDTitle.Text = "Degree Title";
            // 
            // txtDTitle
            // 
            this.txtDTitle.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDTitle.Location = new System.Drawing.Point(373, 311);
            this.txtDTitle.Name = "txtDTitle";
            this.txtDTitle.Size = new System.Drawing.Size(386, 42);
            this.txtDTitle.TabIndex = 47;
            // 
            // lblPlace
            // 
            this.lblPlace.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlace.Location = new System.Drawing.Point(149, 263);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(175, 34);
            this.lblPlace.TabIndex = 46;
            this.lblPlace.Text = "Exam Place";
            // 
            // cmbPlace
            // 
            this.cmbPlace.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlace.FormattingEnabled = true;
            this.cmbPlace.Items.AddRange(new object[] {
            "Dhaka",
            "Rajshahi",
            "Chattagram",
            "Kumilla",
            "Dinajpur",
            "Khulna",
            "Barisal",
            "Sylhet"});
            this.cmbPlace.Location = new System.Drawing.Point(373, 263);
            this.cmbPlace.Name = "cmbPlace";
            this.cmbPlace.Size = new System.Drawing.Size(386, 42);
            this.cmbPlace.TabIndex = 45;
            // 
            // lblYear
            // 
            this.lblYear.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(139, 215);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(185, 34);
            this.lblYear.TabIndex = 44;
            this.lblYear.Text = "Passing Year";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(373, 215);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(386, 42);
            this.txtYear.TabIndex = 43;
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(216, 167);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(93, 34);
            this.lblResult.TabIndex = 42;
            this.lblResult.Text = "Result";
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(373, 167);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(386, 42);
            this.txtResult.TabIndex = 41;
            // 
            // lblGroup
            // 
            this.lblGroup.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroup.Location = new System.Drawing.Point(208, 121);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(101, 34);
            this.lblGroup.TabIndex = 40;
            this.lblGroup.Text = "Group";
            // 
            // cmbGroup
            // 
            this.cmbGroup.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Items.AddRange(new object[] {
            "Science",
            "Arts",
            "Commerce"});
            this.cmbGroup.Location = new System.Drawing.Point(373, 121);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(386, 42);
            this.cmbGroup.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 34);
            this.label3.TabIndex = 38;
            this.label3.Text = "Institute Name";
            // 
            // textInsName
            // 
            this.textInsName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInsName.Location = new System.Drawing.Point(373, 73);
            this.textInsName.Name = "textInsName";
            this.textInsName.Size = new System.Drawing.Size(386, 42);
            this.textInsName.TabIndex = 37;
            // 
            // drpDegree
            // 
            this.drpDegree.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpDegree.FormattingEnabled = true;
            this.drpDegree.Location = new System.Drawing.Point(373, 25);
            this.drpDegree.Name = "drpDegree";
            this.drpDegree.Size = new System.Drawing.Size(386, 42);
            this.drpDegree.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 34);
            this.label1.TabIndex = 35;
            this.label1.Text = "Degree";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(504, 361);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 56);
            this.btnClear.TabIndex = 34;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(641, 359);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 58);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // eduDataGrid
            // 
            this.eduDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.eduDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eduDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.degree_name,
            this.institution_name,
            this.grp,
            this.result,
            this.passing_year,
            this.ExamPlace,
            this.DegreeTitle});
            this.eduDataGrid.Location = new System.Drawing.Point(146, 428);
            this.eduDataGrid.Name = "eduDataGrid";
            this.eduDataGrid.RowTemplate.Height = 28;
            this.eduDataGrid.Size = new System.Drawing.Size(890, 184);
            this.eduDataGrid.TabIndex = 21;
            this.eduDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eduDataGrid_CellClick);
            // 
            // degree_name
            // 
            this.degree_name.DataPropertyName = "degree_name";
            this.degree_name.HeaderText = "Degree";
            this.degree_name.Name = "degree_name";
            // 
            // institution_name
            // 
            this.institution_name.DataPropertyName = "institution_name";
            this.institution_name.HeaderText = "Institute Name";
            this.institution_name.Name = "institution_name";
            // 
            // grp
            // 
            this.grp.DataPropertyName = "grp";
            this.grp.HeaderText = "Group";
            this.grp.Name = "grp";
            // 
            // result
            // 
            this.result.DataPropertyName = "result";
            this.result.HeaderText = "Result";
            this.result.Name = "result";
            // 
            // passing_year
            // 
            this.passing_year.DataPropertyName = "passing_year";
            this.passing_year.HeaderText = "Passing Year";
            this.passing_year.Name = "passing_year";
            // 
            // ExamPlace
            // 
            this.ExamPlace.DataPropertyName = "ExamPlace";
            this.ExamPlace.HeaderText = "Exam Place";
            this.ExamPlace.Name = "ExamPlace";
            // 
            // DegreeTitle
            // 
            this.DegreeTitle.DataPropertyName = "DegreeTitle";
            this.DegreeTitle.HeaderText = "Degree Title";
            this.DegreeTitle.Name = "DegreeTitle";
            // 
            // EducationInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1151, 785);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlButtom);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EducationInfo";
            this.Text = "EducationInfo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlButtom.ResumeLayout(false);
            this.pnlButtom.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eduDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnContactUs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlButtom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView eduDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn degree_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn institution_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn grp;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private System.Windows.Forms.DataGridViewTextBoxColumn passing_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn DegreeTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblDTitle;
        private System.Windows.Forms.TextBox txtDTitle;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.ComboBox cmbPlace;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textInsName;
        private System.Windows.Forms.ComboBox drpDegree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
    }
}
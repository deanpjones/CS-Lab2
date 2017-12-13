namespace CPRG200_Lab2_CustomerDB
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radIndustrial = new System.Windows.Forms.RadioButton();
            this.radCommercial = new System.Windows.Forms.RadioButton();
            this.radResidential = new System.Windows.Forms.RadioButton();
            this.txtPowerUsage = new System.Windows.Forms.TextBox();
            this.lblKw1 = new System.Windows.Forms.Label();
            this.txtDisplayCharge = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsage1 = new System.Windows.Forms.Label();
            this.lblUsage2 = new System.Windows.Forms.Label();
            this.lblKw2 = new System.Windows.Forms.Label();
            this.txtPowerUsage2 = new System.Windows.Forms.TextBox();
            this.btnCalculateUsage = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picDisplayImage = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lstCustomerList = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblIndTotal = new System.Windows.Forms.Label();
            this.lblComTotal = new System.Windows.Forms.Label();
            this.lblResTotal = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblIndCount = new System.Windows.Forms.Label();
            this.lblComCount = new System.Windows.Forms.Label();
            this.lblResCount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplayImage)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radIndustrial);
            this.groupBox1.Controls.Add(this.radCommercial);
            this.groupBox1.Controls.Add(this.radResidential);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 195);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Type";
            // 
            // radIndustrial
            // 
            this.radIndustrial.AutoSize = true;
            this.radIndustrial.Location = new System.Drawing.Point(17, 86);
            this.radIndustrial.Name = "radIndustrial";
            this.radIndustrial.Size = new System.Drawing.Size(87, 20);
            this.radIndustrial.TabIndex = 2;
            this.radIndustrial.TabStop = true;
            this.radIndustrial.Text = "Industrial";
            this.radIndustrial.UseVisualStyleBackColor = true;
            this.radIndustrial.CheckedChanged += new System.EventHandler(this.radIndustrial_CheckedChanged);
            // 
            // radCommercial
            // 
            this.radCommercial.AutoSize = true;
            this.radCommercial.Location = new System.Drawing.Point(17, 60);
            this.radCommercial.Name = "radCommercial";
            this.radCommercial.Size = new System.Drawing.Size(100, 20);
            this.radCommercial.TabIndex = 1;
            this.radCommercial.TabStop = true;
            this.radCommercial.Text = "Commercial";
            this.radCommercial.UseVisualStyleBackColor = true;
            this.radCommercial.CheckedChanged += new System.EventHandler(this.radCommercial_CheckedChanged);
            // 
            // radResidential
            // 
            this.radResidential.AutoSize = true;
            this.radResidential.Checked = true;
            this.radResidential.Location = new System.Drawing.Point(17, 34);
            this.radResidential.Name = "radResidential";
            this.radResidential.Size = new System.Drawing.Size(96, 20);
            this.radResidential.TabIndex = 0;
            this.radResidential.TabStop = true;
            this.radResidential.Text = "Residential";
            this.radResidential.UseVisualStyleBackColor = true;
            this.radResidential.CheckedChanged += new System.EventHandler(this.radResidential_CheckedChanged);
            // 
            // txtPowerUsage
            // 
            this.txtPowerUsage.Location = new System.Drawing.Point(404, 262);
            this.txtPowerUsage.Name = "txtPowerUsage";
            this.txtPowerUsage.Size = new System.Drawing.Size(110, 27);
            this.txtPowerUsage.TabIndex = 0;
            this.txtPowerUsage.Tag = "Power Usage";
            // 
            // lblKw1
            // 
            this.lblKw1.AutoSize = true;
            this.lblKw1.Location = new System.Drawing.Point(520, 271);
            this.lblKw1.Name = "lblKw1";
            this.lblKw1.Size = new System.Drawing.Size(44, 18);
            this.lblKw1.TabIndex = 7;
            this.lblKw1.Text = "kWh";
            // 
            // txtDisplayCharge
            // 
            this.txtDisplayCharge.Enabled = false;
            this.txtDisplayCharge.Location = new System.Drawing.Point(404, 384);
            this.txtDisplayCharge.Name = "txtDisplayCharge";
            this.txtDisplayCharge.Size = new System.Drawing.Size(110, 27);
            this.txtDisplayCharge.TabIndex = 5;
            this.txtDisplayCharge.TabStop = false;
            this.txtDisplayCharge.Tag = "Charge Owing (need to calculate)";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(492, 437);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(376, 437);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(110, 40);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(11, 2);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(591, 25);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Charge Owing:";
            // 
            // lblUsage1
            // 
            this.lblUsage1.AutoSize = true;
            this.lblUsage1.Location = new System.Drawing.Point(22, 35);
            this.lblUsage1.Name = "lblUsage1";
            this.lblUsage1.Size = new System.Drawing.Size(121, 18);
            this.lblUsage1.TabIndex = 2;
            this.lblUsage1.Text = "Power Usage:";
            // 
            // lblUsage2
            // 
            this.lblUsage2.AutoSize = true;
            this.lblUsage2.Location = new System.Drawing.Point(22, 66);
            this.lblUsage2.Name = "lblUsage2";
            this.lblUsage2.Size = new System.Drawing.Size(121, 18);
            this.lblUsage2.TabIndex = 3;
            this.lblUsage2.Text = "Power Usage:";
            // 
            // lblKw2
            // 
            this.lblKw2.AutoSize = true;
            this.lblKw2.Location = new System.Drawing.Point(353, 66);
            this.lblKw2.Name = "lblKw2";
            this.lblKw2.Size = new System.Drawing.Size(44, 18);
            this.lblKw2.TabIndex = 5;
            this.lblKw2.Text = "kWh";
            // 
            // txtPowerUsage2
            // 
            this.txtPowerUsage2.Location = new System.Drawing.Point(237, 57);
            this.txtPowerUsage2.Name = "txtPowerUsage2";
            this.txtPowerUsage2.Size = new System.Drawing.Size(110, 27);
            this.txtPowerUsage2.TabIndex = 1;
            this.txtPowerUsage2.Tag = "Power Usage";
            // 
            // btnCalculateUsage
            // 
            this.btnCalculateUsage.Location = new System.Drawing.Point(237, 102);
            this.btnCalculateUsage.Name = "btnCalculateUsage";
            this.btnCalculateUsage.Size = new System.Drawing.Size(110, 40);
            this.btnCalculateUsage.TabIndex = 2;
            this.btnCalculateUsage.Text = "&Calculate";
            this.btnCalculateUsage.UseVisualStyleBackColor = true;
            this.btnCalculateUsage.Click += new System.EventHandler(this.btnCalculateUsage_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCalculateUsage);
            this.groupBox2.Controls.Add(this.txtPowerUsage2);
            this.groupBox2.Controls.Add(this.lblKw2);
            this.groupBox2.Controls.Add(this.lblUsage2);
            this.groupBox2.Controls.Add(this.lblUsage1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(167, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 195);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculate Power Bill";
            // 
            // picDisplayImage
            // 
            this.picDisplayImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDisplayImage.Location = new System.Drawing.Point(392, 17);
            this.picDisplayImage.Name = "picDisplayImage";
            this.picDisplayImage.Size = new System.Drawing.Size(192, 151);
            this.picDisplayImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDisplayImage.TabIndex = 8;
            this.picDisplayImage.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.txtAccountNo);
            this.groupBox3.Controls.Add(this.txtFirstName);
            this.groupBox3.Controls.Add(this.picDisplayImage);
            this.groupBox3.Controls.Add(this.txtLastName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblLastName);
            this.groupBox3.Controls.Add(this.lblFirstName);
            this.groupBox3.Location = new System.Drawing.Point(12, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(590, 178);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Customer Info";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(263, 134);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 34);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Location = new System.Drawing.Point(136, 35);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(226, 27);
            this.txtAccountNo.TabIndex = 1;
            this.txtAccountNo.Tag = "Account#";
            this.txtAccountNo.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(136, 68);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(226, 27);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Tag = "First Name";
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(136, 101);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(226, 27);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.Tag = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Account#:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(6, 109);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(103, 18);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(6, 76);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(104, 18);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(626, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Customer List";
            // 
            // lstCustomerList
            // 
            this.lstCustomerList.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCustomerList.FormattingEnabled = true;
            this.lstCustomerList.ItemHeight = 14;
            this.lstCustomerList.Location = new System.Drawing.Point(630, 38);
            this.lstCustomerList.Name = "lstCustomerList";
            this.lstCustomerList.ScrollAlwaysVisible = true;
            this.lstCustomerList.Size = new System.Drawing.Size(449, 172);
            this.lstCustomerList.TabIndex = 10;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(178, 156);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(68, 18);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "lblTotal";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(318, 155);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(76, 18);
            this.lblCount.TabIndex = 12;
            this.lblCount.Text = "lblCount";
            // 
            // lblIndTotal
            // 
            this.lblIndTotal.AutoSize = true;
            this.lblIndTotal.Location = new System.Drawing.Point(178, 126);
            this.lblIndTotal.Name = "lblIndTotal";
            this.lblIndTotal.Size = new System.Drawing.Size(95, 18);
            this.lblIndTotal.TabIndex = 12;
            this.lblIndTotal.Text = "lblIndTotal";
            // 
            // lblComTotal
            // 
            this.lblComTotal.AutoSize = true;
            this.lblComTotal.Location = new System.Drawing.Point(178, 96);
            this.lblComTotal.Name = "lblComTotal";
            this.lblComTotal.Size = new System.Drawing.Size(104, 18);
            this.lblComTotal.TabIndex = 12;
            this.lblComTotal.Text = "lblComTotal";
            // 
            // lblResTotal
            // 
            this.lblResTotal.AutoSize = true;
            this.lblResTotal.Location = new System.Drawing.Point(178, 66);
            this.lblResTotal.Name = "lblResTotal";
            this.lblResTotal.Size = new System.Drawing.Size(98, 18);
            this.lblResTotal.TabIndex = 12;
            this.lblResTotal.Text = "lblResTotal";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblResCount);
            this.groupBox4.Controls.Add(this.lblResTotal);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.lblComCount);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.lblComTotal);
            this.groupBox4.Controls.Add(this.lblIndCount);
            this.groupBox4.Controls.Add(this.lblCount);
            this.groupBox4.Controls.Add(this.lblIndTotal);
            this.groupBox4.Controls.Add(this.lblTotal);
            this.groupBox4.Location = new System.Drawing.Point(630, 236);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(449, 195);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Customer Stats";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 18);
            this.label11.TabIndex = 12;
            this.label11.Text = "Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 18);
            this.label10.TabIndex = 12;
            this.label10.Text = "Industrial:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "Commercial:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(318, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Count";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Residential:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(178, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 18);
            this.label12.TabIndex = 12;
            this.label12.Text = "Charges";
            // 
            // lblIndCount
            // 
            this.lblIndCount.AutoSize = true;
            this.lblIndCount.Location = new System.Drawing.Point(318, 126);
            this.lblIndCount.Name = "lblIndCount";
            this.lblIndCount.Size = new System.Drawing.Size(103, 18);
            this.lblIndCount.TabIndex = 12;
            this.lblIndCount.Text = "lblIndCount";
            // 
            // lblComCount
            // 
            this.lblComCount.AutoSize = true;
            this.lblComCount.Location = new System.Drawing.Point(318, 96);
            this.lblComCount.Name = "lblComCount";
            this.lblComCount.Size = new System.Drawing.Size(112, 18);
            this.lblComCount.TabIndex = 12;
            this.lblComCount.Text = "lblComCount";
            // 
            // lblResCount
            // 
            this.lblResCount.AutoSize = true;
            this.lblResCount.Location = new System.Drawing.Point(318, 66);
            this.lblResCount.Name = "lblResCount";
            this.lblResCount.Size = new System.Drawing.Size(106, 18);
            this.lblResCount.TabIndex = 12;
            this.lblResCount.Text = "lblResCount";
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnCalculateUsage;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1091, 485);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstCustomerList);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtDisplayCharge);
            this.Controls.Add(this.txtPowerUsage);
            this.Controls.Add(this.lblKw1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmMain";
            this.Text = "Lab 2 - Customer List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplayImage)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radIndustrial;
        private System.Windows.Forms.RadioButton radCommercial;
        private System.Windows.Forms.RadioButton radResidential;
        private System.Windows.Forms.TextBox txtPowerUsage;
        private System.Windows.Forms.Label lblKw1;
        private System.Windows.Forms.TextBox txtDisplayCharge;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsage1;
        private System.Windows.Forms.Label lblUsage2;
        private System.Windows.Forms.Label lblKw2;
        private System.Windows.Forms.TextBox txtPowerUsage2;
        private System.Windows.Forms.Button btnCalculateUsage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picDisplayImage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstCustomerList;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblIndTotal;
        private System.Windows.Forms.Label lblComTotal;
        private System.Windows.Forms.Label lblResTotal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblResCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblComCount;
        private System.Windows.Forms.Label lblIndCount;
    }
}


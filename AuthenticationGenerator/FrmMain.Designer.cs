
namespace AuthenticationGenerator
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtVersion = new System.Windows.Forms.TextBox();
            this.TxtEncPrimitives = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSignPrimitives = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMACPrimitives = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtMasterKeyHash = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTarget = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtMainBody = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtSubsidiaryBodies = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ChkIsSubsidiaryBodyLocked = new System.Windows.Forms.CheckBox();
            this.TxtTimeStart = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.NumTimeSustain = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.TxtNotesService = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtNyarlathotepService = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtExpressService = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtInfonetService = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtProsService = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ChkIsCoreUser = new System.Windows.Forms.CheckBox();
            this.ChkIsPayingUser = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.NumAdvancedSupport = new System.Windows.Forms.NumericUpDown();
            this.ChkIsOverseasService = new System.Windows.Forms.CheckBox();
            this.TxtRegion = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TxtComments = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumTimeSustain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAdvancedSupport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Version";
            // 
            // TxtVersion
            // 
            this.TxtVersion.Location = new System.Drawing.Point(141, 10);
            this.TxtVersion.Name = "TxtVersion";
            this.TxtVersion.Size = new System.Drawing.Size(100, 22);
            this.TxtVersion.TabIndex = 1;
            this.TxtVersion.TextChanged += new System.EventHandler(this.TxtVersion_TextChanged);
            // 
            // TxtEncPrimitives
            // 
            this.TxtEncPrimitives.Location = new System.Drawing.Point(141, 38);
            this.TxtEncPrimitives.Name = "TxtEncPrimitives";
            this.TxtEncPrimitives.Size = new System.Drawing.Size(100, 22);
            this.TxtEncPrimitives.TabIndex = 3;
            this.TxtEncPrimitives.TextChanged += new System.EventHandler(this.TxtEncPrimitives_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "EncPrimitives";
            // 
            // TxtSignPrimitives
            // 
            this.TxtSignPrimitives.Location = new System.Drawing.Point(141, 66);
            this.TxtSignPrimitives.Name = "TxtSignPrimitives";
            this.TxtSignPrimitives.Size = new System.Drawing.Size(100, 22);
            this.TxtSignPrimitives.TabIndex = 5;
            this.TxtSignPrimitives.TextChanged += new System.EventHandler(this.TxtSignPrimitives_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "SignPrimitives";
            // 
            // TxtMACPrimitives
            // 
            this.TxtMACPrimitives.Location = new System.Drawing.Point(141, 94);
            this.TxtMACPrimitives.Name = "TxtMACPrimitives";
            this.TxtMACPrimitives.Size = new System.Drawing.Size(100, 22);
            this.TxtMACPrimitives.TabIndex = 7;
            this.TxtMACPrimitives.TextChanged += new System.EventHandler(this.TxtMACPrimitives_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "MACPrimitives";
            // 
            // TxtMasterKeyHash
            // 
            this.TxtMasterKeyHash.Location = new System.Drawing.Point(141, 122);
            this.TxtMasterKeyHash.Name = "TxtMasterKeyHash";
            this.TxtMasterKeyHash.Size = new System.Drawing.Size(100, 22);
            this.TxtMasterKeyHash.TabIndex = 9;
            this.TxtMasterKeyHash.TextChanged += new System.EventHandler(this.TxtMasterKeyHash_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "MasterKeyHash";
            // 
            // TxtType
            // 
            this.TxtType.Location = new System.Drawing.Point(141, 150);
            this.TxtType.Name = "TxtType";
            this.TxtType.Size = new System.Drawing.Size(100, 22);
            this.TxtType.TabIndex = 11;
            this.TxtType.TextChanged += new System.EventHandler(this.TxtType_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Type";
            // 
            // TxtTarget
            // 
            this.TxtTarget.Location = new System.Drawing.Point(141, 178);
            this.TxtTarget.Name = "TxtTarget";
            this.TxtTarget.Size = new System.Drawing.Size(100, 22);
            this.TxtTarget.TabIndex = 13;
            this.TxtTarget.TextChanged += new System.EventHandler(this.TxtTarget_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Target";
            // 
            // TxtMainBody
            // 
            this.TxtMainBody.Location = new System.Drawing.Point(141, 206);
            this.TxtMainBody.Name = "TxtMainBody";
            this.TxtMainBody.Size = new System.Drawing.Size(100, 22);
            this.TxtMainBody.TabIndex = 15;
            this.TxtMainBody.TextChanged += new System.EventHandler(this.TxtMainBody_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "MainBody";
            // 
            // TxtSubsidiaryBodies
            // 
            this.TxtSubsidiaryBodies.Location = new System.Drawing.Point(141, 262);
            this.TxtSubsidiaryBodies.Name = "TxtSubsidiaryBodies";
            this.TxtSubsidiaryBodies.Size = new System.Drawing.Size(100, 22);
            this.TxtSubsidiaryBodies.TabIndex = 17;
            this.TxtSubsidiaryBodies.TextChanged += new System.EventHandler(this.TxtSubsidiaryBodies_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "SubsidiaryBodies";
            // 
            // ChkIsSubsidiaryBodyLocked
            // 
            this.ChkIsSubsidiaryBodyLocked.AutoSize = true;
            this.ChkIsSubsidiaryBodyLocked.Location = new System.Drawing.Point(16, 235);
            this.ChkIsSubsidiaryBodyLocked.Name = "ChkIsSubsidiaryBodyLocked";
            this.ChkIsSubsidiaryBodyLocked.Size = new System.Drawing.Size(184, 21);
            this.ChkIsSubsidiaryBodyLocked.TabIndex = 18;
            this.ChkIsSubsidiaryBodyLocked.Text = "IsSubsidiaryBodyLocked";
            this.ChkIsSubsidiaryBodyLocked.UseVisualStyleBackColor = true;
            this.ChkIsSubsidiaryBodyLocked.CheckedChanged += new System.EventHandler(this.ChkIsSubsidiaryBodyLocked_CheckedChanged);
            // 
            // TxtTimeStart
            // 
            this.TxtTimeStart.Location = new System.Drawing.Point(141, 290);
            this.TxtTimeStart.Name = "TxtTimeStart";
            this.TxtTimeStart.Size = new System.Drawing.Size(100, 22);
            this.TxtTimeStart.TabIndex = 20;
            this.TxtTimeStart.TextChanged += new System.EventHandler(this.TxtTimeStart_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "TimeStart";
            // 
            // NumTimeSustain
            // 
            this.NumTimeSustain.Location = new System.Drawing.Point(141, 319);
            this.NumTimeSustain.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumTimeSustain.Name = "NumTimeSustain";
            this.NumTimeSustain.Size = new System.Drawing.Size(100, 22);
            this.NumTimeSustain.TabIndex = 21;
            this.NumTimeSustain.ValueChanged += new System.EventHandler(this.NumTimeSustain_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "TimeSustain";
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(17, 365);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(225, 45);
            this.BtnGenerate.TabIndex = 23;
            this.BtnGenerate.Text = "GENERATE";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // TxtNotesService
            // 
            this.TxtNotesService.Location = new System.Drawing.Point(383, 66);
            this.TxtNotesService.Name = "TxtNotesService";
            this.TxtNotesService.Size = new System.Drawing.Size(100, 22);
            this.TxtNotesService.TabIndex = 25;
            this.TxtNotesService.TextChanged += new System.EventHandler(this.TxtNotesService_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(254, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "NotesService";
            // 
            // TxtNyarlathotepService
            // 
            this.TxtNyarlathotepService.Location = new System.Drawing.Point(383, 38);
            this.TxtNyarlathotepService.Name = "TxtNyarlathotepService";
            this.TxtNyarlathotepService.Size = new System.Drawing.Size(100, 22);
            this.TxtNyarlathotepService.TabIndex = 27;
            this.TxtNyarlathotepService.TextChanged += new System.EventHandler(this.TxtNyarlathotepService_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(255, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "NyarlathotepService";
            // 
            // TxtExpressService
            // 
            this.TxtExpressService.Location = new System.Drawing.Point(382, 10);
            this.TxtExpressService.Name = "TxtExpressService";
            this.TxtExpressService.Size = new System.Drawing.Size(100, 22);
            this.TxtExpressService.TabIndex = 29;
            this.TxtExpressService.TextChanged += new System.EventHandler(this.TxtExpressService_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(255, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 17);
            this.label14.TabIndex = 28;
            this.label14.Text = "ExpressService";
            // 
            // TxtInfonetService
            // 
            this.TxtInfonetService.Location = new System.Drawing.Point(383, 122);
            this.TxtInfonetService.Name = "TxtInfonetService";
            this.TxtInfonetService.Size = new System.Drawing.Size(100, 22);
            this.TxtInfonetService.TabIndex = 31;
            this.TxtInfonetService.TextChanged += new System.EventHandler(this.TxtInfonetService_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(255, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 17);
            this.label15.TabIndex = 30;
            this.label15.Text = "InfonetService";
            // 
            // TxtProsService
            // 
            this.TxtProsService.Location = new System.Drawing.Point(383, 94);
            this.TxtProsService.Name = "TxtProsService";
            this.TxtProsService.Size = new System.Drawing.Size(100, 22);
            this.TxtProsService.TabIndex = 33;
            this.TxtProsService.TextChanged += new System.EventHandler(this.TxtProsService_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(255, 97);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 17);
            this.label16.TabIndex = 32;
            this.label16.Text = "ProsService";
            // 
            // ChkIsCoreUser
            // 
            this.ChkIsCoreUser.AutoSize = true;
            this.ChkIsCoreUser.Location = new System.Drawing.Point(256, 152);
            this.ChkIsCoreUser.Name = "ChkIsCoreUser";
            this.ChkIsCoreUser.Size = new System.Drawing.Size(100, 21);
            this.ChkIsCoreUser.TabIndex = 34;
            this.ChkIsCoreUser.Text = "IsCoreUser";
            this.ChkIsCoreUser.UseVisualStyleBackColor = true;
            this.ChkIsCoreUser.CheckedChanged += new System.EventHandler(this.ChkIsCoreUser_CheckedChanged);
            // 
            // ChkIsPayingUser
            // 
            this.ChkIsPayingUser.AutoSize = true;
            this.ChkIsPayingUser.Location = new System.Drawing.Point(256, 180);
            this.ChkIsPayingUser.Name = "ChkIsPayingUser";
            this.ChkIsPayingUser.Size = new System.Drawing.Size(113, 21);
            this.ChkIsPayingUser.TabIndex = 35;
            this.ChkIsPayingUser.Text = "IsPayingUser";
            this.ChkIsPayingUser.UseVisualStyleBackColor = true;
            this.ChkIsPayingUser.CheckedChanged += new System.EventHandler(this.ChkIsPayingUser_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(255, 208);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 17);
            this.label17.TabIndex = 37;
            this.label17.Text = "AdvancedSupport";
            // 
            // NumAdvancedSupport
            // 
            this.NumAdvancedSupport.Location = new System.Drawing.Point(383, 206);
            this.NumAdvancedSupport.Name = "NumAdvancedSupport";
            this.NumAdvancedSupport.Size = new System.Drawing.Size(100, 22);
            this.NumAdvancedSupport.TabIndex = 36;
            this.NumAdvancedSupport.ValueChanged += new System.EventHandler(this.NumAdvancedSupport_ValueChanged);
            // 
            // ChkIsOverseasService
            // 
            this.ChkIsOverseasService.AutoSize = true;
            this.ChkIsOverseasService.Location = new System.Drawing.Point(256, 235);
            this.ChkIsOverseasService.Name = "ChkIsOverseasService";
            this.ChkIsOverseasService.Size = new System.Drawing.Size(148, 21);
            this.ChkIsOverseasService.TabIndex = 38;
            this.ChkIsOverseasService.Text = "IsOverseasService";
            this.ChkIsOverseasService.UseVisualStyleBackColor = true;
            this.ChkIsOverseasService.CheckedChanged += new System.EventHandler(this.ChkIsOverseasService_CheckedChanged);
            // 
            // TxtRegion
            // 
            this.TxtRegion.Location = new System.Drawing.Point(383, 263);
            this.TxtRegion.Name = "TxtRegion";
            this.TxtRegion.Size = new System.Drawing.Size(100, 22);
            this.TxtRegion.TabIndex = 40;
            this.TxtRegion.TextChanged += new System.EventHandler(this.TxtRegion_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(253, 265);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 17);
            this.label18.TabIndex = 39;
            this.label18.Text = "Region";
            // 
            // TxtComments
            // 
            this.TxtComments.Location = new System.Drawing.Point(383, 291);
            this.TxtComments.Name = "TxtComments";
            this.TxtComments.Size = new System.Drawing.Size(100, 22);
            this.TxtComments.TabIndex = 42;
            this.TxtComments.TextChanged += new System.EventHandler(this.TxtComments_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(255, 294);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 17);
            this.label19.TabIndex = 41;
            this.label19.Text = "Comments";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(256, 365);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(225, 45);
            this.BtnSave.TabIndex = 43;
            this.BtnSave.Text = "SAVE";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 428);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtComments);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.TxtRegion);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.ChkIsOverseasService);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.NumAdvancedSupport);
            this.Controls.Add(this.ChkIsPayingUser);
            this.Controls.Add(this.ChkIsCoreUser);
            this.Controls.Add(this.TxtProsService);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TxtInfonetService);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TxtExpressService);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TxtNyarlathotepService);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtNotesService);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BtnGenerate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.NumTimeSustain);
            this.Controls.Add(this.TxtTimeStart);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ChkIsSubsidiaryBodyLocked);
            this.Controls.Add(this.TxtSubsidiaryBodies);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtMainBody);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtTarget);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtMasterKeyHash);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtMACPrimitives);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSignPrimitives);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtEncPrimitives);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtVersion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "OpenMUNCS Authentication Generator";
            ((System.ComponentModel.ISupportInitialize)(this.NumTimeSustain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAdvancedSupport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtVersion;
        private System.Windows.Forms.TextBox TxtEncPrimitives;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSignPrimitives;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMACPrimitives;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtMasterKeyHash;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtTarget;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtMainBody;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtSubsidiaryBodies;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox ChkIsSubsidiaryBodyLocked;
        private System.Windows.Forms.TextBox TxtTimeStart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown NumTimeSustain;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.TextBox TxtNotesService;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtNyarlathotepService;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtExpressService;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtInfonetService;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtProsService;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox ChkIsCoreUser;
        private System.Windows.Forms.CheckBox ChkIsPayingUser;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown NumAdvancedSupport;
        private System.Windows.Forms.CheckBox ChkIsOverseasService;
        private System.Windows.Forms.TextBox TxtRegion;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TxtComments;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button BtnSave;
    }
}


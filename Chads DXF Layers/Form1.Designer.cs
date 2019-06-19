namespace Chads_DXF_Layers
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbTools = new System.Windows.Forms.ComboBox();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnCenter = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.lblToolCode = new System.Windows.Forms.Label();
            this.lblWorkSpeed = new System.Windows.Forms.Label();
            this.txtWorkSpeed = new System.Windows.Forms.TextBox();
            this.cmbPercent = new System.Windows.Forms.ComboBox();
            this.txtToolDepth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLayerName = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.chkOnTop = new System.Windows.Forms.CheckBox();
            this.pictureBoxTool = new System.Windows.Forms.PictureBox();
            this.chkBoring = new System.Windows.Forms.CheckBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTools
            // 
            this.cmbTools.FormattingEnabled = true;
            this.cmbTools.Location = new System.Drawing.Point(103, 173);
            this.cmbTools.Name = "cmbTools";
            this.cmbTools.Size = new System.Drawing.Size(172, 21);
            this.cmbTools.TabIndex = 0;
            this.cmbTools.SelectedIndexChanged += new System.EventHandler(this.cmbTools_SelectedIndexChanged);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLeft.Location = new System.Drawing.Point(36, 245);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 37);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnCenter
            // 
            this.btnCenter.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCenter.Location = new System.Drawing.Point(117, 245);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(75, 37);
            this.btnCenter.TabIndex = 1;
            this.btnCenter.Text = "Center";
            this.btnCenter.UseVisualStyleBackColor = false;
            this.btnCenter.Click += new System.EventHandler(this.btnCenter_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRight.Location = new System.Drawing.Point(198, 245);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 37);
            this.btnRight.TabIndex = 1;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // lblToolCode
            // 
            this.lblToolCode.AutoSize = true;
            this.lblToolCode.Location = new System.Drawing.Point(36, 176);
            this.lblToolCode.Name = "lblToolCode";
            this.lblToolCode.Size = new System.Drawing.Size(56, 13);
            this.lblToolCode.TabIndex = 2;
            this.lblToolCode.Text = "Tool Code";
            // 
            // lblWorkSpeed
            // 
            this.lblWorkSpeed.AutoSize = true;
            this.lblWorkSpeed.Location = new System.Drawing.Point(30, 301);
            this.lblWorkSpeed.Name = "lblWorkSpeed";
            this.lblWorkSpeed.Size = new System.Drawing.Size(57, 13);
            this.lblWorkSpeed.TabIndex = 3;
            this.lblWorkSpeed.Text = "Feed Rate";
            // 
            // txtWorkSpeed
            // 
            this.txtWorkSpeed.Enabled = false;
            this.txtWorkSpeed.Location = new System.Drawing.Point(102, 298);
            this.txtWorkSpeed.Name = "txtWorkSpeed";
            this.txtWorkSpeed.Size = new System.Drawing.Size(103, 20);
            this.txtWorkSpeed.TabIndex = 4;
            // 
            // cmbPercent
            // 
            this.cmbPercent.FormattingEnabled = true;
            this.cmbPercent.Items.AddRange(new object[] {
            "100%",
            "90%",
            "80%",
            "70%",
            "60%",
            "50%",
            "40%",
            "30%",
            "20%",
            "10%"});
            this.cmbPercent.Location = new System.Drawing.Point(211, 297);
            this.cmbPercent.Name = "cmbPercent";
            this.cmbPercent.Size = new System.Drawing.Size(63, 21);
            this.cmbPercent.TabIndex = 5;
            this.cmbPercent.Text = "%";
            this.cmbPercent.SelectedIndexChanged += new System.EventHandler(this.cmbPercent_SelectedIndexChanged);
            // 
            // txtToolDepth
            // 
            this.txtToolDepth.Location = new System.Drawing.Point(104, 208);
            this.txtToolDepth.Name = "txtToolDepth";
            this.txtToolDepth.Size = new System.Drawing.Size(172, 20);
            this.txtToolDepth.TabIndex = 6;
            this.txtToolDepth.TextChanged += new System.EventHandler(this.txtToolDepth_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tool Depth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Layer Name";
            // 
            // txtLayerName
            // 
            this.txtLayerName.Location = new System.Drawing.Point(27, 111);
            this.txtLayerName.Name = "txtLayerName";
            this.txtLayerName.Size = new System.Drawing.Size(461, 20);
            this.txtLayerName.TabIndex = 9;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(27, 44);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(240, 30);
            this.btnCopy.TabIndex = 10;
            this.btnCopy.Text = "Copy Layer Name to Clipboard";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // chkOnTop
            // 
            this.chkOnTop.AutoSize = true;
            this.chkOnTop.Location = new System.Drawing.Point(409, 12);
            this.chkOnTop.Name = "chkOnTop";
            this.chkOnTop.Size = new System.Drawing.Size(93, 17);
            this.chkOnTop.TabIndex = 11;
            this.chkOnTop.Text = "Keep On Top!";
            this.chkOnTop.UseVisualStyleBackColor = true;
            this.chkOnTop.CheckedChanged += new System.EventHandler(this.chkOnTop_CheckedChanged_1);
            // 
            // pictureBoxTool
            // 
            this.pictureBoxTool.Location = new System.Drawing.Point(298, 148);
            this.pictureBoxTool.Name = "pictureBoxTool";
            this.pictureBoxTool.Size = new System.Drawing.Size(190, 214);
            this.pictureBoxTool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTool.TabIndex = 12;
            this.pictureBoxTool.TabStop = false;
            // 
            // chkBoring
            // 
            this.chkBoring.AutoSize = true;
            this.chkBoring.Location = new System.Drawing.Point(432, 75);
            this.chkBoring.Name = "chkBoring";
            this.chkBoring.Size = new System.Drawing.Size(56, 17);
            this.chkBoring.TabIndex = 13;
            this.chkBoring.Text = "Boring";
            this.chkBoring.UseVisualStyleBackColor = true;
            this.chkBoring.CheckedChanged += new System.EventHandler(this.chkBoring_CheckedChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(21, 379);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(0, 13);
            this.lblDescription.TabIndex = 16;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(298, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(514, 401);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.chkBoring);
            this.Controls.Add(this.pictureBoxTool);
            this.Controls.Add(this.chkOnTop);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtLayerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtToolDepth);
            this.Controls.Add(this.cmbPercent);
            this.Controls.Add(this.txtWorkSpeed);
            this.Controls.Add(this.lblWorkSpeed);
            this.Controls.Add(this.lblToolCode);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnCenter);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.cmbTools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Layer Name for DXF Files";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTools;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnCenter;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Label lblToolCode;
        private System.Windows.Forms.Label lblWorkSpeed;
        private System.Windows.Forms.TextBox txtWorkSpeed;
        private System.Windows.Forms.ComboBox cmbPercent;
        private System.Windows.Forms.TextBox txtToolDepth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLayerName;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.CheckBox chkOnTop;
        private System.Windows.Forms.PictureBox pictureBoxTool;
        private System.Windows.Forms.CheckBox chkBoring;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


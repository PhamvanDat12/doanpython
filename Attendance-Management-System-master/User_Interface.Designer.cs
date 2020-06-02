namespace Attendance_System
{
    partial class User_Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Interface));
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grInfo = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ptCam = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ptImage1 = new System.Windows.Forms.PictureBox();
            this.ptImage2 = new System.Windows.Forms.PictureBox();
            this.ptImage3 = new System.Windows.Forms.PictureBox();
            this.ptImage4 = new System.Windows.Forms.PictureBox();
            this.ptImage5 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCam = new System.Windows.Forms.ComboBox();
            this.btnRecog = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCapture = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressPercent = new System.Windows.Forms.ToolStripProgressBar();
            this.lblProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptCam)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptImage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptImage5)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(4, 63);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(4, 24);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 20);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(106, 25);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(286, 20);
            this.txtID.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(106, 65);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(286, 20);
            this.txtName.TabIndex = 2;
            // 
            // grInfo
            // 
            this.grInfo.Controls.Add(this.btnClear);
            this.grInfo.Controls.Add(this.btnSave);
            this.grInfo.Controls.Add(this.lblName);
            this.grInfo.Controls.Add(this.txtName);
            this.grInfo.Controls.Add(this.txtID);
            this.grInfo.Controls.Add(this.lblID);
            this.grInfo.Location = new System.Drawing.Point(11, 11);
            this.grInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grInfo.Name = "grInfo";
            this.grInfo.Padding = new System.Windows.Forms.Padding(2);
            this.grInfo.Size = new System.Drawing.Size(522, 96);
            this.grInfo.TabIndex = 3;
            this.grInfo.TabStop = false;
            this.grInfo.Text = "Information:";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(409, 60);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 28);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(409, 18);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 31);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(9, 134);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel1.Controls.Add(this.ptCam);
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.cbxCam);
            this.splitContainer1.Panel2.Controls.Add(this.btnRecog);
            this.splitContainer1.Panel2.Controls.Add(this.btnSend);
            this.splitContainer1.Panel2.Controls.Add(this.btnCapture);
            this.splitContainer1.Size = new System.Drawing.Size(524, 364);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 4;
            // 
            // ptCam
            // 
            this.ptCam.BackColor = System.Drawing.SystemColors.Control;
            this.ptCam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptCam.Image = ((System.Drawing.Image)(resources.GetObject("ptCam.Image")));
            this.ptCam.Location = new System.Drawing.Point(2, 3);
            this.ptCam.Margin = new System.Windows.Forms.Padding(2);
            this.ptCam.Name = "ptCam";
            this.ptCam.Size = new System.Drawing.Size(394, 277);
            this.ptCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptCam.TabIndex = 1;
            this.ptCam.TabStop = false;
            this.ptCam.Click += new System.EventHandler(this.PtCam_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ptImage1);
            this.flowLayoutPanel1.Controls.Add(this.ptImage2);
            this.flowLayoutPanel1.Controls.Add(this.ptImage3);
            this.flowLayoutPanel1.Controls.Add(this.ptImage4);
            this.flowLayoutPanel1.Controls.Add(this.ptImage5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 283);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(400, 81);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ptImage1
            // 
            this.ptImage1.BackColor = System.Drawing.SystemColors.Control;
            this.ptImage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptImage1.Location = new System.Drawing.Point(2, 2);
            this.ptImage1.Margin = new System.Windows.Forms.Padding(2);
            this.ptImage1.Name = "ptImage1";
            this.ptImage1.Size = new System.Drawing.Size(76, 77);
            this.ptImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptImage1.TabIndex = 0;
            this.ptImage1.TabStop = false;
            // 
            // ptImage2
            // 
            this.ptImage2.BackColor = System.Drawing.SystemColors.Control;
            this.ptImage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptImage2.Location = new System.Drawing.Point(82, 2);
            this.ptImage2.Margin = new System.Windows.Forms.Padding(2);
            this.ptImage2.Name = "ptImage2";
            this.ptImage2.Size = new System.Drawing.Size(76, 77);
            this.ptImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptImage2.TabIndex = 0;
            this.ptImage2.TabStop = false;
            // 
            // ptImage3
            // 
            this.ptImage3.BackColor = System.Drawing.SystemColors.Control;
            this.ptImage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptImage3.Location = new System.Drawing.Point(162, 2);
            this.ptImage3.Margin = new System.Windows.Forms.Padding(2);
            this.ptImage3.Name = "ptImage3";
            this.ptImage3.Size = new System.Drawing.Size(76, 77);
            this.ptImage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptImage3.TabIndex = 0;
            this.ptImage3.TabStop = false;
            // 
            // ptImage4
            // 
            this.ptImage4.BackColor = System.Drawing.SystemColors.Control;
            this.ptImage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptImage4.Location = new System.Drawing.Point(242, 2);
            this.ptImage4.Margin = new System.Windows.Forms.Padding(2);
            this.ptImage4.Name = "ptImage4";
            this.ptImage4.Size = new System.Drawing.Size(76, 77);
            this.ptImage4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptImage4.TabIndex = 0;
            this.ptImage4.TabStop = false;
            // 
            // ptImage5
            // 
            this.ptImage5.BackColor = System.Drawing.SystemColors.Control;
            this.ptImage5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptImage5.Location = new System.Drawing.Point(322, 2);
            this.ptImage5.Margin = new System.Windows.Forms.Padding(2);
            this.ptImage5.Name = "ptImage5";
            this.ptImage5.Size = new System.Drawing.Size(76, 77);
            this.ptImage5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptImage5.TabIndex = 0;
            this.ptImage5.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 338);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "4-2020";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 292);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Created By: ";
            // 
            // cbxCam
            // 
            this.cbxCam.FormattingEnabled = true;
            this.cbxCam.Location = new System.Drawing.Point(5, 21);
            this.cbxCam.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCam.Name = "cbxCam";
            this.cbxCam.Size = new System.Drawing.Size(98, 21);
            this.cbxCam.TabIndex = 1;
            // 
            // btnRecog
            // 
            this.btnRecog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecog.Location = new System.Drawing.Point(5, 185);
            this.btnRecog.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecog.Name = "btnRecog";
            this.btnRecog.Size = new System.Drawing.Size(97, 32);
            this.btnRecog.TabIndex = 0;
            this.btnRecog.Text = "Recognize";
            this.btnRecog.UseVisualStyleBackColor = true;
            this.btnRecog.Click += new System.EventHandler(this.BtnRecog_Click);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(5, 128);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(97, 32);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Train";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnTrain_Click);
            // 
            // btnCapture
            // 
            this.btnCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapture.Location = new System.Drawing.Point(5, 71);
            this.btnCapture.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(97, 32);
            this.btnCapture.TabIndex = 0;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.BtnStart_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.ProgressPercent,
            this.lblProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(823, 30);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(121, 25);
            this.lblStatus.Text = "Adding information...";
            // 
            // ProgressPercent
            // 
            this.ProgressPercent.Name = "ProgressPercent";
            this.ProgressPercent.Size = new System.Drawing.Size(150, 24);
            // 
            // lblProgress
            // 
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(0, 25);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // User_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 530);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.grInfo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "User_Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FACE RECOGNITION";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.grInfo.ResumeLayout(false);
            this.grInfo.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptCam)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptImage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptImage5)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox ptImage1;
        private System.Windows.Forms.PictureBox ptImage2;
        private System.Windows.Forms.PictureBox ptImage3;
        private System.Windows.Forms.PictureBox ptImage4;
        private System.Windows.Forms.PictureBox ptImage5;
        private System.Windows.Forms.PictureBox ptCam;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRecog;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.ComboBox cbxCam;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripProgressBar ProgressPercent;
        private System.Windows.Forms.ToolStripStatusLabel lblProgress;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}


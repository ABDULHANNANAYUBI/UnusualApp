
namespace TakeHome1_OOP_Lab
{
    partial class EncryptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptionForm));
            this.pnlUst = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUst = new System.Windows.Forms.Label();
            this.grpEnc = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEnc = new System.Windows.Forms.Label();
            this.rdoDecVig = new System.Windows.Forms.RadioButton();
            this.rdoEncVig = new System.Windows.Forms.RadioButton();
            this.rdoDecCea = new System.Windows.Forms.RadioButton();
            this.rdoEncCea = new System.Windows.Forms.RadioButton();
            this.txtAlp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStr = new System.Windows.Forms.TextBox();
            this.lblStr = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.rtxtResult = new System.Windows.Forms.RichTextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpEnc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.Controls.Add(this.pictureBox2);
            this.pnlUst.Controls.Add(this.pictureBox1);
            this.pnlUst.Controls.Add(this.pictureBox3);
            this.pnlUst.Controls.Add(this.lblUst);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(749, 84);
            this.pnlUst.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(366, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblUst
            // 
            this.lblUst.AutoSize = true;
            this.lblUst.Font = new System.Drawing.Font("Papyrus", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUst.ForeColor = System.Drawing.Color.White;
            this.lblUst.Location = new System.Drawing.Point(12, 23);
            this.lblUst.Name = "lblUst";
            this.lblUst.Size = new System.Drawing.Size(362, 46);
            this.lblUst.TabIndex = 2;
            this.lblUst.Text = "Encryption / Decryption";
            // 
            // grpEnc
            // 
            this.grpEnc.Controls.Add(this.label2);
            this.grpEnc.Controls.Add(this.lblEnc);
            this.grpEnc.Controls.Add(this.rdoDecVig);
            this.grpEnc.Controls.Add(this.rdoEncVig);
            this.grpEnc.Controls.Add(this.rdoDecCea);
            this.grpEnc.Controls.Add(this.rdoEncCea);
            this.grpEnc.ForeColor = System.Drawing.Color.White;
            this.grpEnc.Location = new System.Drawing.Point(423, 106);
            this.grpEnc.Name = "grpEnc";
            this.grpEnc.Size = new System.Drawing.Size(316, 146);
            this.grpEnc.TabIndex = 1;
            this.grpEnc.TabStop = false;
            this.grpEnc.Text = "Encryption / Decryption";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Decryption";
            // 
            // lblEnc
            // 
            this.lblEnc.AutoSize = true;
            this.lblEnc.Location = new System.Drawing.Point(3, 31);
            this.lblEnc.Name = "lblEnc";
            this.lblEnc.Size = new System.Drawing.Size(86, 18);
            this.lblEnc.TabIndex = 4;
            this.lblEnc.Text = "Encryption";
            // 
            // rdoDecVig
            // 
            this.rdoDecVig.AutoSize = true;
            this.rdoDecVig.Location = new System.Drawing.Point(171, 98);
            this.rdoDecVig.Name = "rdoDecVig";
            this.rdoDecVig.Size = new System.Drawing.Size(140, 22);
            this.rdoDecVig.TabIndex = 7;
            this.rdoDecVig.TabStop = true;
            this.rdoDecVig.Text = "Vigenère Cipher";
            this.rdoDecVig.UseVisualStyleBackColor = true;
            this.rdoDecVig.CheckedChanged += new System.EventHandler(this.rdoDecVig_CheckedChanged);
            // 
            // rdoEncVig
            // 
            this.rdoEncVig.AutoSize = true;
            this.rdoEncVig.Location = new System.Drawing.Point(6, 98);
            this.rdoEncVig.Name = "rdoEncVig";
            this.rdoEncVig.Size = new System.Drawing.Size(140, 22);
            this.rdoEncVig.TabIndex = 6;
            this.rdoEncVig.TabStop = true;
            this.rdoEncVig.Text = "Vigenère Cipher";
            this.rdoEncVig.UseVisualStyleBackColor = true;
            this.rdoEncVig.CheckedChanged += new System.EventHandler(this.rdoEncVig_CheckedChanged);
            // 
            // rdoDecCea
            // 
            this.rdoDecCea.AutoSize = true;
            this.rdoDecCea.Location = new System.Drawing.Point(171, 58);
            this.rdoDecCea.Name = "rdoDecCea";
            this.rdoDecCea.Size = new System.Drawing.Size(125, 22);
            this.rdoDecCea.TabIndex = 5;
            this.rdoDecCea.TabStop = true;
            this.rdoDecCea.Text = "Ceaser Cipher";
            this.rdoDecCea.UseVisualStyleBackColor = true;
            this.rdoDecCea.CheckedChanged += new System.EventHandler(this.rdoDecCea_CheckedChanged);
            // 
            // rdoEncCea
            // 
            this.rdoEncCea.AutoSize = true;
            this.rdoEncCea.Location = new System.Drawing.Point(6, 58);
            this.rdoEncCea.Name = "rdoEncCea";
            this.rdoEncCea.Size = new System.Drawing.Size(125, 22);
            this.rdoEncCea.TabIndex = 4;
            this.rdoEncCea.TabStop = true;
            this.rdoEncCea.Text = "Ceaser Cipher";
            this.rdoEncCea.UseVisualStyleBackColor = true;
            this.rdoEncCea.CheckedChanged += new System.EventHandler(this.rdoEncCea_CheckedChanged);
            // 
            // txtAlp
            // 
            this.txtAlp.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlp.Location = new System.Drawing.Point(119, 115);
            this.txtAlp.Multiline = true;
            this.txtAlp.Name = "txtAlp";
            this.txtAlp.Size = new System.Drawing.Size(286, 49);
            this.txtAlp.TabIndex = 1;
            this.txtAlp.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            this.txtAlp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAlp_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alphabet";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtStr
            // 
            this.txtStr.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStr.Location = new System.Drawing.Point(119, 179);
            this.txtStr.Name = "txtStr";
            this.txtStr.Size = new System.Drawing.Size(286, 25);
            this.txtStr.TabIndex = 2;
            this.txtStr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAlp_MouseClick);
            // 
            // lblStr
            // 
            this.lblStr.AutoSize = true;
            this.lblStr.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStr.ForeColor = System.Drawing.Color.White;
            this.lblStr.Location = new System.Drawing.Point(54, 182);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(59, 18);
            this.lblStr.TabIndex = 4;
            this.lblStr.Text = "String";
            this.lblStr.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.Location = new System.Drawing.Point(119, 227);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(286, 25);
            this.txtValue.TabIndex = 3;
            this.txtValue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAlp_MouseClick);
            this.txtValue.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.ForeColor = System.Drawing.Color.White;
            this.lblValue.Location = new System.Drawing.Point(24, 230);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(89, 18);
            this.lblValue.TabIndex = 4;
            this.lblValue.Text = "Rot Value";
            this.lblValue.Click += new System.EventHandler(this.label1_Click);
            // 
            // rtxtResult
            // 
            this.rtxtResult.Location = new System.Drawing.Point(423, 267);
            this.rtxtResult.Name = "rtxtResult";
            this.rtxtResult.ReadOnly = true;
            this.rtxtResult.Size = new System.Drawing.Size(316, 77);
            this.rtxtResult.TabIndex = 6;
            this.rtxtResult.Text = "";
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.ForeColor = System.Drawing.Color.Black;
            this.btnResult.Image = ((System.Drawing.Image)(resources.GetObject("btnResult.Image")));
            this.btnResult.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResult.Location = new System.Drawing.Point(278, 267);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(127, 50);
            this.btnResult.TabIndex = 8;
            this.btnResult.Text = "Start";
            this.btnResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TakeHome1_OOP_Lab.Properties.Resources.icons8_minimize_window_30px;
            this.pictureBox2.Location = new System.Drawing.Point(684, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 30);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TakeHome1_OOP_Lab.Properties.Resources.icons8_delete_30px;
            this.pictureBox3.Location = new System.Drawing.Point(719, 3);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::TakeHome1_OOP_Lab.Properties.Resources.icons8_copyright_30px_1;
            this.pictureBox4.Location = new System.Drawing.Point(498, 357);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(527, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 14);
            this.label3.TabIndex = 13;
            this.label3.Text = "All rights reserved by Group 17";
            // 
            // EncryptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(749, 391);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtxtResult);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblStr);
            this.Controls.Add(this.txtStr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAlp);
            this.Controls.Add(this.grpEnc);
            this.Controls.Add(this.pnlUst);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EncryptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EncryptionForm";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EncryptionForm_MouseClick);
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpEnc.ResumeLayout(false);
            this.grpEnc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Label lblUst;
        private System.Windows.Forms.GroupBox grpEnc;
        private System.Windows.Forms.RadioButton rdoEncVig;
        private System.Windows.Forms.RadioButton rdoEncCea;
        private System.Windows.Forms.RadioButton rdoDecVig;
        private System.Windows.Forms.RadioButton rdoDecCea;
        private System.Windows.Forms.TextBox txtAlp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStr;
        private System.Windows.Forms.Label lblStr;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEnc;
        private System.Windows.Forms.RichTextBox rtxtResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
    }
}
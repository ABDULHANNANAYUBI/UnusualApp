
namespace TakeHome1_OOP_Lab
{
    partial class PositionGuesserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PositionGuesserForm));
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.groupBoxMyGuesses = new System.Windows.Forms.GroupBox();
            this.listBoxCoordinates = new System.Windows.Forms.ListBox();
            this.buttonSouthEast = new System.Windows.Forms.Button();
            this.buttonEast = new System.Windows.Forms.Button();
            this.buttonNorth = new System.Windows.Forms.Button();
            this.buttonSouthWest = new System.Windows.Forms.Button();
            this.buttonNorthWest = new System.Windows.Forms.Button();
            this.buttonNorthEast = new System.Windows.Forms.Button();
            this.buttonSouth = new System.Windows.Forms.Button();
            this.buttonWest = new System.Windows.Forms.Button();
            this.labelGuesses = new System.Windows.Forms.Label();
            this.labelCounter = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.groupBoxMyGuesses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMinimize
            // 
            this.pictureBoxMinimize.Image = global::TakeHome1_OOP_Lab.Properties.Resources.icons8_minimize_window_30px;
            this.pictureBoxMinimize.Location = new System.Drawing.Point(567, 2);
            this.pictureBoxMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxMinimize.Name = "pictureBoxMinimize";
            this.pictureBoxMinimize.Size = new System.Drawing.Size(23, 24);
            this.pictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimize.TabIndex = 8;
            this.pictureBoxMinimize.TabStop = false;
            this.pictureBoxMinimize.Click += new System.EventHandler(this.pictureBoxMinimize_Click);
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Image = global::TakeHome1_OOP_Lab.Properties.Resources.icons8_delete_30px;
            this.pictureBoxExit.Location = new System.Drawing.Point(592, 4);
            this.pictureBoxExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(21, 23);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExit.TabIndex = 9;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.pictureBox1);
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Controls.Add(this.pictureBoxExit);
            this.panelTitle.Controls.Add(this.pictureBoxMinimize);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(618, 117);
            this.panelTitle.TabIndex = 10;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(11, 28);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(299, 57);
            this.labelTitle.TabIndex = 10;
            this.labelTitle.Text = "Position Guesser";
            // 
            // buttonReset
            // 
            this.buttonReset.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.buttonReset.FlatAppearance.BorderSize = 5;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonReset.ForeColor = System.Drawing.Color.White;
            this.buttonReset.Location = new System.Drawing.Point(185, 284);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(112, 37);
            this.buttonReset.TabIndex = 11;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // groupBoxMyGuesses
            // 
            this.groupBoxMyGuesses.Controls.Add(this.listBoxCoordinates);
            this.groupBoxMyGuesses.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxMyGuesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxMyGuesses.ForeColor = System.Drawing.Color.White;
            this.groupBoxMyGuesses.Location = new System.Drawing.Point(444, 117);
            this.groupBoxMyGuesses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxMyGuesses.Name = "groupBoxMyGuesses";
            this.groupBoxMyGuesses.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxMyGuesses.Size = new System.Drawing.Size(174, 435);
            this.groupBoxMyGuesses.TabIndex = 12;
            this.groupBoxMyGuesses.TabStop = false;
            this.groupBoxMyGuesses.Text = "My Guesses";
            // 
            // listBoxCoordinates
            // 
            this.listBoxCoordinates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.listBoxCoordinates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxCoordinates.ForeColor = System.Drawing.Color.White;
            this.listBoxCoordinates.FormattingEnabled = true;
            this.listBoxCoordinates.ItemHeight = 20;
            this.listBoxCoordinates.Items.AddRange(new object[] {
            "(0, 0)"});
            this.listBoxCoordinates.Location = new System.Drawing.Point(54, 24);
            this.listBoxCoordinates.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxCoordinates.Name = "listBoxCoordinates";
            this.listBoxCoordinates.Size = new System.Drawing.Size(103, 400);
            this.listBoxCoordinates.TabIndex = 0;
            // 
            // buttonSouthEast
            // 
            this.buttonSouthEast.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.buttonSouthEast.FlatAppearance.BorderSize = 5;
            this.buttonSouthEast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSouthEast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSouthEast.ForeColor = System.Drawing.Color.White;
            this.buttonSouthEast.Location = new System.Drawing.Point(302, 326);
            this.buttonSouthEast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSouthEast.Name = "buttonSouthEast";
            this.buttonSouthEast.Size = new System.Drawing.Size(112, 37);
            this.buttonSouthEast.TabIndex = 13;
            this.buttonSouthEast.Text = "SouthEast";
            this.buttonSouthEast.UseVisualStyleBackColor = true;
            this.buttonSouthEast.Click += new System.EventHandler(this.buttonSouthEast_Click);
            // 
            // buttonEast
            // 
            this.buttonEast.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.buttonEast.FlatAppearance.BorderSize = 5;
            this.buttonEast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEast.ForeColor = System.Drawing.Color.White;
            this.buttonEast.Location = new System.Drawing.Point(302, 284);
            this.buttonEast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEast.Name = "buttonEast";
            this.buttonEast.Size = new System.Drawing.Size(112, 37);
            this.buttonEast.TabIndex = 14;
            this.buttonEast.Text = "East";
            this.buttonEast.UseVisualStyleBackColor = true;
            this.buttonEast.Click += new System.EventHandler(this.buttonEast_Click);
            // 
            // buttonNorth
            // 
            this.buttonNorth.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.buttonNorth.FlatAppearance.BorderSize = 5;
            this.buttonNorth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNorth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonNorth.ForeColor = System.Drawing.Color.White;
            this.buttonNorth.Location = new System.Drawing.Point(185, 243);
            this.buttonNorth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNorth.Name = "buttonNorth";
            this.buttonNorth.Size = new System.Drawing.Size(112, 37);
            this.buttonNorth.TabIndex = 15;
            this.buttonNorth.Text = "North";
            this.buttonNorth.UseVisualStyleBackColor = true;
            this.buttonNorth.Click += new System.EventHandler(this.buttonNorth_Click);
            // 
            // buttonSouthWest
            // 
            this.buttonSouthWest.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.buttonSouthWest.FlatAppearance.BorderSize = 5;
            this.buttonSouthWest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSouthWest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSouthWest.ForeColor = System.Drawing.Color.White;
            this.buttonSouthWest.Location = new System.Drawing.Point(68, 326);
            this.buttonSouthWest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSouthWest.Name = "buttonSouthWest";
            this.buttonSouthWest.Size = new System.Drawing.Size(112, 37);
            this.buttonSouthWest.TabIndex = 16;
            this.buttonSouthWest.Text = "SouthWest";
            this.buttonSouthWest.UseVisualStyleBackColor = true;
            this.buttonSouthWest.Click += new System.EventHandler(this.buttonSouthWest_Click);
            // 
            // buttonNorthWest
            // 
            this.buttonNorthWest.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.buttonNorthWest.FlatAppearance.BorderSize = 5;
            this.buttonNorthWest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNorthWest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonNorthWest.ForeColor = System.Drawing.Color.White;
            this.buttonNorthWest.Location = new System.Drawing.Point(68, 243);
            this.buttonNorthWest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNorthWest.Name = "buttonNorthWest";
            this.buttonNorthWest.Size = new System.Drawing.Size(112, 37);
            this.buttonNorthWest.TabIndex = 17;
            this.buttonNorthWest.Text = "NorthWest";
            this.buttonNorthWest.UseVisualStyleBackColor = true;
            this.buttonNorthWest.Click += new System.EventHandler(this.buttonNorthWest_Click);
            // 
            // buttonNorthEast
            // 
            this.buttonNorthEast.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.buttonNorthEast.FlatAppearance.BorderSize = 5;
            this.buttonNorthEast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNorthEast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonNorthEast.ForeColor = System.Drawing.Color.White;
            this.buttonNorthEast.Location = new System.Drawing.Point(302, 243);
            this.buttonNorthEast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNorthEast.Name = "buttonNorthEast";
            this.buttonNorthEast.Size = new System.Drawing.Size(112, 37);
            this.buttonNorthEast.TabIndex = 18;
            this.buttonNorthEast.Text = "NorthEast";
            this.buttonNorthEast.UseVisualStyleBackColor = true;
            this.buttonNorthEast.Click += new System.EventHandler(this.buttonNorthEast_Click);
            // 
            // buttonSouth
            // 
            this.buttonSouth.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.buttonSouth.FlatAppearance.BorderSize = 5;
            this.buttonSouth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSouth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSouth.ForeColor = System.Drawing.Color.White;
            this.buttonSouth.Location = new System.Drawing.Point(185, 326);
            this.buttonSouth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSouth.Name = "buttonSouth";
            this.buttonSouth.Size = new System.Drawing.Size(112, 37);
            this.buttonSouth.TabIndex = 19;
            this.buttonSouth.Text = "South";
            this.buttonSouth.UseVisualStyleBackColor = true;
            this.buttonSouth.Click += new System.EventHandler(this.buttonSouth_Click);
            // 
            // buttonWest
            // 
            this.buttonWest.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.buttonWest.FlatAppearance.BorderSize = 5;
            this.buttonWest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonWest.ForeColor = System.Drawing.Color.White;
            this.buttonWest.Location = new System.Drawing.Point(68, 284);
            this.buttonWest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonWest.Name = "buttonWest";
            this.buttonWest.Size = new System.Drawing.Size(112, 37);
            this.buttonWest.TabIndex = 20;
            this.buttonWest.Text = "West";
            this.buttonWest.UseVisualStyleBackColor = true;
            this.buttonWest.Click += new System.EventHandler(this.buttonWest_Click);
            // 
            // labelGuesses
            // 
            this.labelGuesses.AutoSize = true;
            this.labelGuesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGuesses.ForeColor = System.Drawing.Color.White;
            this.labelGuesses.Location = new System.Drawing.Point(64, 398);
            this.labelGuesses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGuesses.Name = "labelGuesses";
            this.labelGuesses.Size = new System.Drawing.Size(155, 24);
            this.labelGuesses.TabIndex = 21;
            this.labelGuesses.Text = "Total Guesses: ";
            // 
            // labelCounter
            // 
            this.labelCounter.AutoSize = true;
            this.labelCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCounter.ForeColor = System.Drawing.Color.White;
            this.labelCounter.Location = new System.Drawing.Point(210, 399);
            this.labelCounter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(21, 24);
            this.labelCounter.TabIndex = 22;
            this.labelCounter.Text = "1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TakeHome1_OOP_Lab.Properties.Resources.icons8_copyright_30px_1;
            this.pictureBox3.Location = new System.Drawing.Point(201, 513);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(231, 521);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 14);
            this.label3.TabIndex = 23;
            this.label3.Text = "All rights reserved by Group 17";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(315, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // PositionGuesserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(618, 552);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCounter);
            this.Controls.Add(this.labelGuesses);
            this.Controls.Add(this.buttonWest);
            this.Controls.Add(this.buttonSouth);
            this.Controls.Add(this.buttonNorthEast);
            this.Controls.Add(this.buttonNorthWest);
            this.Controls.Add(this.buttonSouthWest);
            this.Controls.Add(this.buttonNorth);
            this.Controls.Add(this.buttonEast);
            this.Controls.Add(this.buttonSouthEast);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.groupBoxMyGuesses);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PositionGuesserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PositionGuesserForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.groupBoxMyGuesses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.GroupBox groupBoxMyGuesses;
        private System.Windows.Forms.ListBox listBoxCoordinates;
        private System.Windows.Forms.Button buttonSouthEast;
        private System.Windows.Forms.Button buttonEast;
        private System.Windows.Forms.Button buttonNorth;
        private System.Windows.Forms.Button buttonSouthWest;
        private System.Windows.Forms.Button buttonNorthWest;
        private System.Windows.Forms.Button buttonNorthEast;
        private System.Windows.Forms.Button buttonSouth;
        private System.Windows.Forms.Button buttonWest;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelGuesses;
        private System.Windows.Forms.Label labelCounter;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
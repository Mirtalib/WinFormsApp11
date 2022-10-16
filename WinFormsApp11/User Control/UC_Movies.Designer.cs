namespace WinFormsApp11.User_Control
{
    partial class UC_Movies
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNameMovie = new System.Windows.Forms.Label();
            this.lblYearMovie = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblImdb = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 405F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(678, 361);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lblNameMovie);
            this.panel1.Controls.Add(this.lblYearMovie);
            this.panel1.Controls.Add(this.lblYear);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblImdb);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 355);
            this.panel1.TabIndex = 0;
            // 
            // lblNameMovie
            // 
            this.lblNameMovie.AutoSize = true;
            this.lblNameMovie.BackColor = System.Drawing.Color.Yellow;
            this.lblNameMovie.Location = new System.Drawing.Point(61, 290);
            this.lblNameMovie.Name = "lblNameMovie";
            this.lblNameMovie.Size = new System.Drawing.Size(94, 20);
            this.lblNameMovie.TabIndex = 4;
            this.lblNameMovie.Text = "Name Movie";
            // 
            // lblYearMovie
            // 
            this.lblYearMovie.AutoSize = true;
            this.lblYearMovie.BackColor = System.Drawing.Color.Yellow;
            this.lblYearMovie.Location = new System.Drawing.Point(49, 326);
            this.lblYearMovie.Name = "lblYearMovie";
            this.lblYearMovie.Size = new System.Drawing.Size(82, 20);
            this.lblYearMovie.TabIndex = 3;
            this.lblYearMovie.Text = "Year Movie";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Yellow;
            this.lblYear.Location = new System.Drawing.Point(3, 326);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(40, 20);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Year:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Yellow;
            this.lblName.Location = new System.Drawing.Point(3, 290);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // lblImdb
            // 
            this.lblImdb.AutoSize = true;
            this.lblImdb.BackColor = System.Drawing.Color.Yellow;
            this.lblImdb.Location = new System.Drawing.Point(42, 22);
            this.lblImdb.Name = "lblImdb";
            this.lblImdb.Size = new System.Drawing.Size(28, 20);
            this.lblImdb.TabIndex = 1;
            this.lblImdb.Text = "0.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(36, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(276, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 355);
            this.panel2.TabIndex = 1;
            // 
            // UC_Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_Movies";
            this.Size = new System.Drawing.Size(678, 361);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblImdb;
        private Label lblNameMovie;
        private Label lblYearMovie;
        private Label lblYear;
        private Label lblName;
        private Panel panel2;
    }
}

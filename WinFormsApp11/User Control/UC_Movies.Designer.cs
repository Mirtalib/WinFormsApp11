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
            this.lblPlotMovies = new System.Windows.Forms.Label();
            this.lblPlot = new System.Windows.Forms.Label();
            this.lblDirectorMovies = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCountryMovie = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblNameMovie = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLanguageMovies = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblYearMovie = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblActorsMovies = new System.Windows.Forms.Label();
            this.lblActors = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblWriterMovie = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblWriter = new System.Windows.Forms.Label();
            this.lblImdb = new System.Windows.Forms.Label();
            this.lblGenreMovie = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(636, 378);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lblPlotMovies);
            this.panel1.Controls.Add(this.lblPlot);
            this.panel1.Controls.Add(this.lblDirectorMovies);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblCountryMovie);
            this.panel1.Controls.Add(this.lblDirector);
            this.panel1.Controls.Add(this.lblCountry);
            this.panel1.Controls.Add(this.lblNameMovie);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblLanguageMovies);
            this.panel1.Controls.Add(this.lblLanguage);
            this.panel1.Controls.Add(this.lblYearMovie);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblActorsMovies);
            this.panel1.Controls.Add(this.lblActors);
            this.panel1.Controls.Add(this.lblYear);
            this.panel1.Controls.Add(this.lblWriterMovie);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblWriter);
            this.panel1.Controls.Add(this.lblImdb);
            this.panel1.Controls.Add(this.lblGenreMovie);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblGenre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 372);
            this.panel1.TabIndex = 0;
            // 
            // lblPlotMovies
            // 
            this.lblPlotMovies.ForeColor = System.Drawing.Color.Yellow;
            this.lblPlotMovies.Location = new System.Drawing.Point(283, 208);
            this.lblPlotMovies.Name = "lblPlotMovies";
            this.lblPlotMovies.Size = new System.Drawing.Size(342, 122);
            this.lblPlotMovies.TabIndex = 5;
            this.lblPlotMovies.Text = "Plot Movies";
            // 
            // lblPlot
            // 
            this.lblPlot.AutoSize = true;
            this.lblPlot.ForeColor = System.Drawing.Color.Yellow;
            this.lblPlot.Location = new System.Drawing.Point(235, 208);
            this.lblPlot.Name = "lblPlot";
            this.lblPlot.Size = new System.Drawing.Size(42, 20);
            this.lblPlot.TabIndex = 5;
            this.lblPlot.Text = "Plot :";
            // 
            // lblDirectorMovies
            // 
            this.lblDirectorMovies.AutoSize = true;
            this.lblDirectorMovies.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDirectorMovies.ForeColor = System.Drawing.Color.Yellow;
            this.lblDirectorMovies.Location = new System.Drawing.Point(304, 49);
            this.lblDirectorMovies.Name = "lblDirectorMovies";
            this.lblDirectorMovies.Size = new System.Drawing.Size(114, 20);
            this.lblDirectorMovies.TabIndex = 0;
            this.lblDirectorMovies.Text = "Director Movies";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(304, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Country Movie";
            // 
            // lblCountryMovie
            // 
            this.lblCountryMovie.AutoSize = true;
            this.lblCountryMovie.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCountryMovie.ForeColor = System.Drawing.Color.Yellow;
            this.lblCountryMovie.Location = new System.Drawing.Point(304, 174);
            this.lblCountryMovie.Name = "lblCountryMovie";
            this.lblCountryMovie.Size = new System.Drawing.Size(105, 20);
            this.lblCountryMovie.TabIndex = 0;
            this.lblCountryMovie.Text = "Country Movie";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDirector.ForeColor = System.Drawing.Color.Yellow;
            this.lblDirector.Location = new System.Drawing.Point(235, 49);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(66, 20);
            this.lblDirector.TabIndex = 0;
            this.lblDirector.Text = "Director:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCountry.ForeColor = System.Drawing.Color.Yellow;
            this.lblCountry.Location = new System.Drawing.Point(235, 174);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(63, 20);
            this.lblCountry.TabIndex = 0;
            this.lblCountry.Text = "Country:";
            // 
            // lblNameMovie
            // 
            this.lblNameMovie.AutoSize = true;
            this.lblNameMovie.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNameMovie.ForeColor = System.Drawing.Color.Yellow;
            this.lblNameMovie.Location = new System.Drawing.Point(61, 290);
            this.lblNameMovie.Name = "lblNameMovie";
            this.lblNameMovie.Size = new System.Drawing.Size(94, 20);
            this.lblNameMovie.TabIndex = 4;
            this.lblNameMovie.Text = "Name Movie";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(318, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Language Movies";
            // 
            // lblLanguageMovies
            // 
            this.lblLanguageMovies.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLanguageMovies.ForeColor = System.Drawing.Color.Yellow;
            this.lblLanguageMovies.Location = new System.Drawing.Point(318, 143);
            this.lblLanguageMovies.Name = "lblLanguageMovies";
            this.lblLanguageMovies.Size = new System.Drawing.Size(307, 20);
            this.lblLanguageMovies.TabIndex = 0;
            this.lblLanguageMovies.Text = "Language Movies";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLanguage.ForeColor = System.Drawing.Color.Yellow;
            this.lblLanguage.Location = new System.Drawing.Point(235, 143);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(77, 20);
            this.lblLanguage.TabIndex = 0;
            this.lblLanguage.Text = "Language:";
            // 
            // lblYearMovie
            // 
            this.lblYearMovie.AutoSize = true;
            this.lblYearMovie.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblYearMovie.ForeColor = System.Drawing.Color.Yellow;
            this.lblYearMovie.Location = new System.Drawing.Point(49, 310);
            this.lblYearMovie.Name = "lblYearMovie";
            this.lblYearMovie.Size = new System.Drawing.Size(82, 20);
            this.lblYearMovie.TabIndex = 3;
            this.lblYearMovie.Text = "Year Movie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(289, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Actors Movies";
            // 
            // lblActorsMovies
            // 
            this.lblActorsMovies.AutoSize = true;
            this.lblActorsMovies.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblActorsMovies.ForeColor = System.Drawing.Color.Yellow;
            this.lblActorsMovies.Location = new System.Drawing.Point(289, 113);
            this.lblActorsMovies.Name = "lblActorsMovies";
            this.lblActorsMovies.Size = new System.Drawing.Size(102, 20);
            this.lblActorsMovies.TabIndex = 0;
            this.lblActorsMovies.Text = "Actors Movies";
            // 
            // lblActors
            // 
            this.lblActors.AutoSize = true;
            this.lblActors.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblActors.ForeColor = System.Drawing.Color.Yellow;
            this.lblActors.Location = new System.Drawing.Point(235, 113);
            this.lblActors.Name = "lblActors";
            this.lblActors.Size = new System.Drawing.Size(54, 20);
            this.lblActors.TabIndex = 0;
            this.lblActors.Text = "Actors:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblYear.ForeColor = System.Drawing.Color.Yellow;
            this.lblYear.Location = new System.Drawing.Point(3, 310);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(40, 20);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Year:";
            // 
            // lblWriterMovie
            // 
            this.lblWriterMovie.AutoSize = true;
            this.lblWriterMovie.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWriterMovie.ForeColor = System.Drawing.Color.Yellow;
            this.lblWriterMovie.Location = new System.Drawing.Point(289, 80);
            this.lblWriterMovie.Name = "lblWriterMovie";
            this.lblWriterMovie.Size = new System.Drawing.Size(95, 20);
            this.lblWriterMovie.TabIndex = 0;
            this.lblWriterMovie.Text = "Writer Movie";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.ForeColor = System.Drawing.Color.Yellow;
            this.lblName.Location = new System.Drawing.Point(3, 290);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // lblWriter
            // 
            this.lblWriter.AutoSize = true;
            this.lblWriter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWriter.ForeColor = System.Drawing.Color.Yellow;
            this.lblWriter.Location = new System.Drawing.Point(235, 80);
            this.lblWriter.Name = "lblWriter";
            this.lblWriter.Size = new System.Drawing.Size(53, 20);
            this.lblWriter.TabIndex = 0;
            this.lblWriter.Text = "Writer:";
            // 
            // lblImdb
            // 
            this.lblImdb.AutoSize = true;
            this.lblImdb.BackColor = System.Drawing.Color.Yellow;
            this.lblImdb.Location = new System.Drawing.Point(24, 19);
            this.lblImdb.Name = "lblImdb";
            this.lblImdb.Size = new System.Drawing.Size(28, 20);
            this.lblImdb.TabIndex = 1;
            this.lblImdb.Text = "0.0";
            // 
            // lblGenreMovie
            // 
            this.lblGenreMovie.AutoSize = true;
            this.lblGenreMovie.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGenreMovie.ForeColor = System.Drawing.Color.Yellow;
            this.lblGenreMovie.Location = new System.Drawing.Point(289, 19);
            this.lblGenreMovie.Name = "lblGenreMovie";
            this.lblGenreMovie.Size = new System.Drawing.Size(93, 20);
            this.lblGenreMovie.TabIndex = 0;
            this.lblGenreMovie.Text = "Genre Movie";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(24, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGenre.ForeColor = System.Drawing.Color.Yellow;
            this.lblGenre.Location = new System.Drawing.Point(235, 19);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(51, 20);
            this.lblGenre.TabIndex = 0;
            this.lblGenre.Text = "Genre:";
            // 
            // UC_Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_Movies";
            this.Size = new System.Drawing.Size(636, 378);
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
        private Label lblCountry;
        private Label lblLanguage;
        private Label lblActors;
        private Label lblWriter;
        private Label lblGenre;
        private Label lblGenreMovie;
        private Label lblWriterMovie;
        private Label lblActorsMovies;
        private Label lblLanguageMovies;
        private Label lblCountryMovie;
        private Label lblDirectorMovies;
        private Label lblDirector;
        private Label lblPlot;
        private Label lblPlotMovies;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}

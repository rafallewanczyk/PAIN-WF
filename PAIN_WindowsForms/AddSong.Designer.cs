namespace PAIN_WindowsForms
{
    partial class AddSong
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.Anuluj = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.genreSelector1 = new PAIN_WindowsForms.GenreSelector();
            this.genre_text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(121, 52);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(225, 20);
            this.nameBox.TabIndex = 0;
            this.nameBox.Validated += new System.EventHandler(this.nameBox_Validated);
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(121, 101);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(225, 20);
            this.authorBox.TabIndex = 1;
            this.authorBox.Validated += new System.EventHandler(this.authorBox_Validated);
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(121, 146);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(225, 20);
            this.yearBox.TabIndex = 2;
            this.yearBox.Validated += new System.EventHandler(this.yearBox_Validated);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(82, 318);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(108, 34);
            this.OK.TabIndex = 4;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Anuluj
            // 
            this.Anuluj.Location = new System.Drawing.Point(288, 318);
            this.Anuluj.Name = "Anuluj";
            this.Anuluj.Size = new System.Drawing.Size(108, 34);
            this.Anuluj.TabIndex = 5;
            this.Anuluj.Text = "Anuluj";
            this.Anuluj.UseVisualStyleBackColor = true;
            this.Anuluj.Click += new System.EventHandler(this.Anuluj_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(214, 36);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(40, 13);
            this.name.TabIndex = 6;
            this.name.Text = "Nazwa";
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Location = new System.Drawing.Point(214, 85);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(32, 13);
            this.author.TabIndex = 7;
            this.author.Text = "Autor";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(214, 130);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(27, 13);
            this.year.TabIndex = 8;
            this.year.Text = "Rok";
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.Location = new System.Drawing.Point(214, 183);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(48, 13);
            this.genre.TabIndex = 9;
            this.genre.Text = "Gatunek";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // genreSelector1
            // 
            this.genreSelector1.current_index = 2;
            this.genreSelector1.Location = new System.Drawing.Point(121, 212);
            this.genreSelector1.Name = "genreSelector1";
            this.genreSelector1.Size = new System.Drawing.Size(225, 80);
            this.genreSelector1.TabIndex = 10;
            this.genreSelector1.genreChanged += new PAIN_WindowsForms.genreChangedHandler(this.genreChanged); 
            // 
            // genre_text
            // 
            this.genre_text.AutoSize = true;
            this.genre_text.Location = new System.Drawing.Point(214, 295);
            this.genre_text.Name = "genre_text";
            this.genre_text.Size = new System.Drawing.Size(35, 13);
            this.genre_text.TabIndex = 11;
            this.genre_text.Text = "label1";
            // 
            // AddSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 391);
            this.Controls.Add(this.genre_text);
            this.Controls.Add(this.genreSelector1);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.year);
            this.Controls.Add(this.author);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Anuluj);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.nameBox);
            this.Name = "AddSong";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Anuluj;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label genre;
        private GenreSelector genreSelector1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label genre_text;
    }
}
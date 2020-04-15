namespace PAIN_WindowsForms
{
    partial class Parent
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oknoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usunToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pop_button = new System.Windows.Forms.ToolStripButton();
            this.rock_button = new System.Windows.Forms.ToolStripButton();
            this.rap_button = new System.Windows.Forms.ToolStripButton();
            this.delete_button = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oknoToolStripMenuItem,
            this.widokToolStripMenuItem,
            this.edycjaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1089, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oknoToolStripMenuItem
            // 
            this.oknoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zamknijToolStripMenuItem});
            this.oknoToolStripMenuItem.Name = "oknoToolStripMenuItem";
            this.oknoToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.oknoToolStripMenuItem.Text = "Okno";
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // widokToolStripMenuItem
            // 
            this.widokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.usunToolStripMenuItem});
            this.widokToolStripMenuItem.Name = "widokToolStripMenuItem";
            this.widokToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.widokToolStripMenuItem.Text = "Widok";
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.nowyToolStripMenuItem.Text = "Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // usunToolStripMenuItem
            // 
            this.usunToolStripMenuItem.Name = "usunToolStripMenuItem";
            this.usunToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.usunToolStripMenuItem.Text = "Usun";
            this.usunToolStripMenuItem.Click += new System.EventHandler(this.usunToolStripMenuItem_Click);
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.usunToolStripMenuItem1});
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.edycjaToolStripMenuItem.Text = "Edycja";
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.popToolStripMenuItem,
            this.rockToolStripMenuItem,
            this.rapToolStripMenuItem});
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            // 
            // popToolStripMenuItem
            // 
            this.popToolStripMenuItem.Name = "popToolStripMenuItem";
            this.popToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.popToolStripMenuItem.Text = "Pop";
            this.popToolStripMenuItem.Click += new System.EventHandler(this.popToolStripMenuItem_Click);
            // 
            // rockToolStripMenuItem
            // 
            this.rockToolStripMenuItem.Name = "rockToolStripMenuItem";
            this.rockToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.rockToolStripMenuItem.Text = "Rock";
            this.rockToolStripMenuItem.Click += new System.EventHandler(this.rockToolStripMenuItem_Click);
            // 
            // rapToolStripMenuItem
            // 
            this.rapToolStripMenuItem.Name = "rapToolStripMenuItem";
            this.rapToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.rapToolStripMenuItem.Text = "Rap";
            this.rapToolStripMenuItem.Click += new System.EventHandler(this.rapToolStripMenuItem_Click);
            // 
            // usunToolStripMenuItem1
            // 
            this.usunToolStripMenuItem1.Name = "usunToolStripMenuItem1";
            this.usunToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.usunToolStripMenuItem1.Text = "Usun";
            this.usunToolStripMenuItem1.Click += new System.EventHandler(this.usunToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 542);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1089, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(118, 17);
            this.status.Text = "toolStripStatusLabel1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pop_button,
            this.rock_button,
            this.rap_button,
            this.delete_button});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1089, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pop_button
            // 
            this.pop_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pop_button.Image = global::PAIN_WindowsForms.Properties.Resources.mj_resized;
            this.pop_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pop_button.Name = "pop_button";
            this.pop_button.Size = new System.Drawing.Size(23, 22);
            this.pop_button.Text = "toolStripButton1";
            this.pop_button.Click += new System.EventHandler(this.popToolStripMenuItem_Click);
            // 
            // rock_button
            // 
            this.rock_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rock_button.Image = global::PAIN_WindowsForms.Properties.Resources.acdc_resized;
            this.rock_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rock_button.Name = "rock_button";
            this.rock_button.Size = new System.Drawing.Size(23, 22);
            this.rock_button.Text = "toolStripButton2";
            this.rock_button.Click += new System.EventHandler(this.rockToolStripMenuItem_Click);
            // 
            // rap_button
            // 
            this.rap_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rap_button.Image = global::PAIN_WindowsForms.Properties.Resources.xxxtentacion_resized;
            this.rap_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rap_button.Name = "rap_button";
            this.rap_button.Size = new System.Drawing.Size(23, 22);
            this.rap_button.Text = "toolStripButton3";
            this.rap_button.Click += new System.EventHandler(this.rapToolStripMenuItem_Click);
            // 
            // delete_button
            // 
            this.delete_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.delete_button.Image = global::PAIN_WindowsForms.Properties.Resources.delete_resized;
            this.delete_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(23, 22);
            this.delete_button.Text = "toolStripButton1";
            this.delete_button.Click += new System.EventHandler(this.usunToolStripMenuItem1_Click);
            // 
            // Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 564);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Parent";
            this.Text = "PAIN_WindowsForms";
            this.MdiChildActivate += new System.EventHandler(this.Parent_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Parent_MdiChildActivate1(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oknoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usunToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.ToolStripMenuItem usunToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem popToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton pop_button;
        private System.Windows.Forms.ToolStripButton rock_button;
        private System.Windows.Forms.ToolStripButton rap_button;
        private System.Windows.Forms.ToolStripButton delete_button;
    }
}


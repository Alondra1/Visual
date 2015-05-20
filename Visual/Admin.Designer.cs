namespace Visual
{
    partial class Admin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarNuevoRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.top5XKmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.top3XPuntosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(721, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarNuevoRegistroToolStripMenuItem,
            this.top5XKmToolStripMenuItem,
            this.top3XPuntosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // insertarNuevoRegistroToolStripMenuItem
            // 
            this.insertarNuevoRegistroToolStripMenuItem.Name = "insertarNuevoRegistroToolStripMenuItem";
            this.insertarNuevoRegistroToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.insertarNuevoRegistroToolStripMenuItem.Text = "Insertar Nuevo Registro";
            this.insertarNuevoRegistroToolStripMenuItem.Click += new System.EventHandler(this.insertarNuevoRegistroToolStripMenuItem_Click);
            // 
            // top5XKmToolStripMenuItem
            // 
            this.top5XKmToolStripMenuItem.Name = "top5XKmToolStripMenuItem";
            this.top5XKmToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.top5XKmToolStripMenuItem.Text = "Top 5 x Km";
            this.top5XKmToolStripMenuItem.Click += new System.EventHandler(this.top5XKmToolStripMenuItem_Click);
            // 
            // top3XPuntosToolStripMenuItem
            // 
            this.top3XPuntosToolStripMenuItem.Name = "top3XPuntosToolStripMenuItem";
            this.top3XPuntosToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.top3XPuntosToolStripMenuItem.Text = "Top 3 x puntos";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 420);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarNuevoRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem top5XKmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem top3XPuntosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}
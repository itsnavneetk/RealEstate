﻿namespace realestate
{
    partial class rental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rental));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.housesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.flatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apartmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.housesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.WindowText;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentalToolStripMenuItem,
            this.salesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(814, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rentalToolStripMenuItem
            // 
            this.rentalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.housesToolStripMenuItem1,
            this.flatsToolStripMenuItem});
            this.rentalToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rentalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rentalToolStripMenuItem.Image")));
            this.rentalToolStripMenuItem.Name = "rentalToolStripMenuItem";
            this.rentalToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.rentalToolStripMenuItem.Text = "Rentals";
            this.rentalToolStripMenuItem.Click += new System.EventHandler(this.rentalToolStripMenuItem_Click);
            // 
            // housesToolStripMenuItem1
            // 
            this.housesToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.housesToolStripMenuItem1.Name = "housesToolStripMenuItem1";
            this.housesToolStripMenuItem1.Size = new System.Drawing.Size(178, 30);
            this.housesToolStripMenuItem1.Text = "Commercial";
            this.housesToolStripMenuItem1.Click += new System.EventHandler(this.housesToolStripMenuItem1_Click);
            // 
            // flatsToolStripMenuItem
            // 
            this.flatsToolStripMenuItem.Name = "flatsToolStripMenuItem";
            this.flatsToolStripMenuItem.Size = new System.Drawing.Size(178, 30);
            this.flatsToolStripMenuItem.Text = "Residential";
            this.flatsToolStripMenuItem.Click += new System.EventHandler(this.flatsToolStripMenuItem_Click_1);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apartmentsToolStripMenuItem,
            this.housesToolStripMenuItem});
            this.salesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.salesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salesToolStripMenuItem.Image")));
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // apartmentsToolStripMenuItem
            // 
            this.apartmentsToolStripMenuItem.Name = "apartmentsToolStripMenuItem";
            this.apartmentsToolStripMenuItem.Size = new System.Drawing.Size(178, 30);
            this.apartmentsToolStripMenuItem.Text = "Commercial";
            this.apartmentsToolStripMenuItem.Click += new System.EventHandler(this.apartmentsToolStripMenuItem_Click);
            // 
            // housesToolStripMenuItem
            // 
            this.housesToolStripMenuItem.Name = "housesToolStripMenuItem";
            this.housesToolStripMenuItem.Size = new System.Drawing.Size(178, 30);
            this.housesToolStripMenuItem.Text = "Residential";
            this.housesToolStripMenuItem.Click += new System.EventHandler(this.housesToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rentals";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.Location = new System.Drawing.Point(40, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(735, 103);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(814, 416);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "rental";
            this.Text = "Rental";
            this.Load += new System.EventHandler(this.rental_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem housesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem flatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apartmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem housesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
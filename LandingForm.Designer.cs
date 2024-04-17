namespace RestaurantDesktopApp
{
    partial class LandingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingForm));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurantMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingredientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManagementToolStripMenuItem,
            this.restaurantMenuToolStripMenuItem,
            this.ingredientsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1189, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.userManagementToolStripMenuItem.Text = "User management";
            // 
            // restaurantMenuToolStripMenuItem
            // 
            this.restaurantMenuToolStripMenuItem.Name = "restaurantMenuToolStripMenuItem";
            this.restaurantMenuToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.restaurantMenuToolStripMenuItem.Text = "Restaurant menu";
            this.restaurantMenuToolStripMenuItem.Click += new System.EventHandler(this.restaurantMenuToolStripMenuItem_Click);
            // 
            // ingredientsToolStripMenuItem
            // 
            this.ingredientsToolStripMenuItem.Name = "ingredientsToolStripMenuItem";
            this.ingredientsToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.ingredientsToolStripMenuItem.Text = "Ingredients";
            this.ingredientsToolStripMenuItem.Click += new System.EventHandler(this.ingredientsToolStripMenuItem_Click);
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1189, 795);
            this.Controls.Add(this.menuStrip2);
            this.Name = "LandingForm";
            this.Text = "LandingForm";
            this.Load += new System.EventHandler(this.LandingForm_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurantMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingredientsToolStripMenuItem;
    }
}
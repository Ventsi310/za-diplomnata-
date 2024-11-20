namespace uprrr.View
{
    partial class Form1
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
            this.началоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.входToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.галерияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заНасToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gallery1 = new uprrr.View.Gallery();
            this.gallery2 = new uprrr.View.Gallery();
            this.signin1 = new uprrr.View.Signin();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.началоToolStripMenuItem,
            this.галерияToolStripMenuItem,
            this.заНасToolStripMenuItem,
            this.услугиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // началоToolStripMenuItem
            // 
            this.началоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.входToolStripMenuItem,
            this.регистрацияToolStripMenuItem});
            this.началоToolStripMenuItem.Name = "началоToolStripMenuItem";
            this.началоToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.началоToolStripMenuItem.Text = "Начало";
            // 
            // входToolStripMenuItem
            // 
            this.входToolStripMenuItem.Name = "входToolStripMenuItem";
            this.входToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.входToolStripMenuItem.Text = "Вход";
            // 
            // регистрацияToolStripMenuItem
            // 
            this.регистрацияToolStripMenuItem.Name = "регистрацияToolStripMenuItem";
            this.регистрацияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.регистрацияToolStripMenuItem.Text = "Регистрация";
            // 
            // галерияToolStripMenuItem
            // 
            this.галерияToolStripMenuItem.Name = "галерияToolStripMenuItem";
            this.галерияToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.галерияToolStripMenuItem.Text = "Галерия";
            this.галерияToolStripMenuItem.Click += new System.EventHandler(this.галерияToolStripMenuItem_Click);
            // 
            // заНасToolStripMenuItem
            // 
            this.заНасToolStripMenuItem.Name = "заНасToolStripMenuItem";
            this.заНасToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.заНасToolStripMenuItem.Text = "За Нас";
            // 
            // услугиToolStripMenuItem
            // 
            this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            this.услугиToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.услугиToolStripMenuItem.Text = "Услуги";
            this.услугиToolStripMenuItem.Click += new System.EventHandler(this.услугиToolStripMenuItem_Click);
            // 
            // gallery1
            // 
            this.gallery1.Location = new System.Drawing.Point(0, 27);
            this.gallery1.Name = "gallery1";
            this.gallery1.Size = new System.Drawing.Size(800, 424);
            this.gallery1.TabIndex = 1;
            // 
            // gallery2
            // 
            this.gallery2.Location = new System.Drawing.Point(0, 27);
            this.gallery2.Name = "gallery2";
            this.gallery2.Size = new System.Drawing.Size(800, 424);
            this.gallery2.TabIndex = 2;
            this.gallery2.Load += new System.EventHandler(this.gallery2_Load);
            // 
            // signin1
            // 
            this.signin1.Location = new System.Drawing.Point(0, 27);
            this.signin1.Name = "signin1";
            this.signin1.Size = new System.Drawing.Size(800, 424);
            this.signin1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gallery2);
            this.Controls.Add(this.gallery1);
            this.Controls.Add(this.signin1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem началоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem входToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистрацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem галерияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заНасToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
        private Gallery gallery1;
        private Gallery gallery2;
        private Signin signin1;
    }
}
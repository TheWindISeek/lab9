namespace lab9
{
    partial class MainForm
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
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.收支管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加收支ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.统计查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.基本资料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加收支项目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统管理ToolStripMenuItem,
            this.收支管理ToolStripMenuItem,
            this.基本资料ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.帮助ToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(654, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "文件";
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.系统管理ToolStripMenuItem.Text = "系统管理";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.quitToolStripMenuItem.Text = "退出";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // 收支管理ToolStripMenuItem
            // 
            this.收支管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加收支ToolStripMenuItem,
            this.统计查询ToolStripMenuItem});
            this.收支管理ToolStripMenuItem.Name = "收支管理ToolStripMenuItem";
            this.收支管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.收支管理ToolStripMenuItem.Text = "收支管理";
            // 
            // 添加收支ToolStripMenuItem
            // 
            this.添加收支ToolStripMenuItem.Name = "添加收支ToolStripMenuItem";
            this.添加收支ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.添加收支ToolStripMenuItem.Text = "添加收支";
            this.添加收支ToolStripMenuItem.Click += new System.EventHandler(this.添加收支ToolStripMenuItem_Click);
            // 
            // 统计查询ToolStripMenuItem
            // 
            this.统计查询ToolStripMenuItem.Name = "统计查询ToolStripMenuItem";
            this.统计查询ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.统计查询ToolStripMenuItem.Text = "统计查询";
            this.统计查询ToolStripMenuItem.Click += new System.EventHandler(this.统计查询ToolStripMenuItem_Click);
            // 
            // 基本资料ToolStripMenuItem
            // 
            this.基本资料ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加收支项目ToolStripMenuItem,
            this.用户管理ToolStripMenuItem});
            this.基本资料ToolStripMenuItem.Name = "基本资料ToolStripMenuItem";
            this.基本资料ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.基本资料ToolStripMenuItem.Text = "基本资料";
            // 
            // 添加收支项目ToolStripMenuItem
            // 
            this.添加收支项目ToolStripMenuItem.Name = "添加收支项目ToolStripMenuItem";
            this.添加收支项目ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.添加收支项目ToolStripMenuItem.Text = "添加收支项目";
            this.添加收支项目ToolStripMenuItem.Click += new System.EventHandler(this.addIncomeToolStripMenuItem_Click);
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            this.用户管理ToolStripMenuItem.Click += new System.EventHandler(this.userManToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 511);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "个人理财";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 收支管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加收支ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 统计查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 基本资料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加收支项目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
    }
}
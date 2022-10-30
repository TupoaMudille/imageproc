/*
 * Создано в SharpDevelop.
 * Пользователь: tanap
 * Дата: 30.10.2022
 * Время: 16:27
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace laba3
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem noiseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem expToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem alphaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gaussToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.noiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.expToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alphaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gaussToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fileToolStripMenuItem,
			this.noiseToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(880, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.openToolStripMenuItem,
			this.saveToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.fileToolStripMenuItem.Text = "file";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
			this.openToolStripMenuItem.Text = "open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
			this.saveToolStripMenuItem.Text = "save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// noiseToolStripMenuItem
			// 
			this.noiseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.blackToolStripMenuItem,
			this.expToolStripMenuItem,
			this.alphaToolStripMenuItem,
			this.gaussToolStripMenuItem});
			this.noiseToolStripMenuItem.Name = "noiseToolStripMenuItem";
			this.noiseToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.noiseToolStripMenuItem.Text = "noise";
			// 
			// blackToolStripMenuItem
			// 
			this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
			this.blackToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
			this.blackToolStripMenuItem.Text = "black";
			this.blackToolStripMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
			// 
			// expToolStripMenuItem
			// 
			this.expToolStripMenuItem.Name = "expToolStripMenuItem";
			this.expToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
			this.expToolStripMenuItem.Text = "exp";
			this.expToolStripMenuItem.Click += new System.EventHandler(this.expToolStripMenuItem_Click);
			// 
			// alphaToolStripMenuItem
			// 
			this.alphaToolStripMenuItem.Name = "alphaToolStripMenuItem";
			this.alphaToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
			this.alphaToolStripMenuItem.Text = "alpha";
			// 
			// gaussToolStripMenuItem
			// 
			this.gaussToolStripMenuItem.Name = "gaussToolStripMenuItem";
			this.gaussToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
			this.gaussToolStripMenuItem.Text = "gauss";
			this.gaussToolStripMenuItem.Click += new System.EventHandler(this.gaussToolStripMenuItem_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(0, 28);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(880, 468);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(880, 496);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "laba3";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

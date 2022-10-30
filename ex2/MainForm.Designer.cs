/*
 * Создано в SharpDevelop.
 * Пользователь: tanap
 * Дата: 04.10.2022
 * Время: 13:38
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace ex2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem binarizationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem globalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem niblackToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem globalHistToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem autocontrastToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem histautocontrastToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem noiseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gaussToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saltToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem medianToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem notlocalToolStripMenuItem;
		
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.binarizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.globalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.niblackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.globalHistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.autocontrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.histautocontrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.noiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gaussToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.medianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.notlocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(0, 58);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(670, 444);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fileToolStripMenuItem,
			this.binarizationToolStripMenuItem,
			this.filterToolStripMenuItem,
			this.noiseToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(670, 24);
			this.menuStrip1.TabIndex = 1;
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
			this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.openToolStripMenuItem.Text = "open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.saveToolStripMenuItem.Text = "save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// binarizationToolStripMenuItem
			// 
			this.binarizationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.globalToolStripMenuItem,
			this.niblackToolStripMenuItem,
			this.globalHistToolStripMenuItem});
			this.binarizationToolStripMenuItem.Name = "binarizationToolStripMenuItem";
			this.binarizationToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
			this.binarizationToolStripMenuItem.Text = "binarization";
			// 
			// globalToolStripMenuItem
			// 
			this.globalToolStripMenuItem.Name = "globalToolStripMenuItem";
			this.globalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.globalToolStripMenuItem.Text = "global";
			this.globalToolStripMenuItem.Click += new System.EventHandler(this.globalToolStripMenuItem_Click);
			// 
			// niblackToolStripMenuItem
			// 
			this.niblackToolStripMenuItem.Name = "niblackToolStripMenuItem";
			this.niblackToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.niblackToolStripMenuItem.Text = "niblack";
			this.niblackToolStripMenuItem.Click += new System.EventHandler(this.niblackToolStripMenuItem_Click);
			// 
			// globalHistToolStripMenuItem
			// 
			this.globalHistToolStripMenuItem.Name = "globalHistToolStripMenuItem";
			this.globalHistToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.globalHistToolStripMenuItem.Text = "global hist";
			this.globalHistToolStripMenuItem.Click += new System.EventHandler(this.globalHistToolStripMenuItem_Click);
			// 
			// filterToolStripMenuItem
			// 
			this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.grayscaleToolStripMenuItem,
			this.blurToolStripMenuItem,
			this.autocontrastToolStripMenuItem,
			this.histautocontrastToolStripMenuItem});
			this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
			this.filterToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.filterToolStripMenuItem.Text = "filter";
			// 
			// grayscaleToolStripMenuItem
			// 
			this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
			this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.grayscaleToolStripMenuItem.Text = "grayscale";
			this.grayscaleToolStripMenuItem.Click += new System.EventHandler(this.grayscaleToolStripMenuItem_Click);
			// 
			// blurToolStripMenuItem
			// 
			this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
			this.blurToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.blurToolStripMenuItem.Text = "blur";
			this.blurToolStripMenuItem.Click += new System.EventHandler(this.blurToolStripMenuItem_Click);
			// 
			// autocontrastToolStripMenuItem
			// 
			this.autocontrastToolStripMenuItem.Name = "autocontrastToolStripMenuItem";
			this.autocontrastToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.autocontrastToolStripMenuItem.Text = "autocontrast";
			this.autocontrastToolStripMenuItem.Click += new System.EventHandler(this.autocontrastToolStripMenuItem_Click);
			// 
			// histautocontrastToolStripMenuItem
			// 
			this.histautocontrastToolStripMenuItem.Name = "histautocontrastToolStripMenuItem";
			this.histautocontrastToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.histautocontrastToolStripMenuItem.Text = "histautocontrast";
			this.histautocontrastToolStripMenuItem.Click += new System.EventHandler(this.histautocontrastToolStripMenuItem_Click);
			// 
			// noiseToolStripMenuItem
			// 
			this.noiseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.gaussToolStripMenuItem,
			this.saltToolStripMenuItem,
			this.medianToolStripMenuItem,
			this.notlocalToolStripMenuItem});
			this.noiseToolStripMenuItem.Name = "noiseToolStripMenuItem";
			this.noiseToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.noiseToolStripMenuItem.Text = "noise";
			// 
			// gaussToolStripMenuItem
			// 
			this.gaussToolStripMenuItem.Name = "gaussToolStripMenuItem";
			this.gaussToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.gaussToolStripMenuItem.Text = "gauss";
			this.gaussToolStripMenuItem.Click += new System.EventHandler(this.gaussToolStripMenuItem_Click);
			// 
			// saltToolStripMenuItem
			// 
			this.saltToolStripMenuItem.Name = "saltToolStripMenuItem";
			this.saltToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.saltToolStripMenuItem.Text = "salt";
			this.saltToolStripMenuItem.Click += new System.EventHandler(this.saltToolStripMenuItem_Click);
			// 
			// medianToolStripMenuItem
			// 
			this.medianToolStripMenuItem.Name = "medianToolStripMenuItem";
			this.medianToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.medianToolStripMenuItem.Text = "median";
			this.medianToolStripMenuItem.Click += new System.EventHandler(this.medianToolStripMenuItem_Click);
			// 
			// notlocalToolStripMenuItem
			// 
			this.notlocalToolStripMenuItem.Name = "notlocalToolStripMenuItem";
			this.notlocalToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.notlocalToolStripMenuItem.Text = "notlocal";
			this.notlocalToolStripMenuItem.Click += new System.EventHandler(this.notlocalToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(670, 514);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "ex2";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

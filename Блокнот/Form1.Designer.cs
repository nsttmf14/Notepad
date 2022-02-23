
namespace Блокнот
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgramTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.CutTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BoldTSMI = new System.Windows.Forms.ToolStripButton();
            this.UnderLineTSMI = new System.Windows.Forms.ToolStripButton();
            this.ItalicTSMI = new System.Windows.Forms.ToolStripButton();
            this.BlackTSMI = new System.Windows.Forms.ToolStripButton();
            this.BlueTSMI = new System.Windows.Forms.ToolStripButton();
            this.RedTSMI = new System.Windows.Forms.ToolStripButton();
            this.GreenTSMI = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.FontComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.SizeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.NotePadRichTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.правкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateTSMI,
            this.OpenTSMI,
            this.SaveTSMI,
            this.ExitTSMI});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // CreateTSMI
            // 
            this.CreateTSMI.Name = "CreateTSMI";
            this.CreateTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.CreateTSMI.Size = new System.Drawing.Size(180, 22);
            this.CreateTSMI.Text = "Создать";
            this.CreateTSMI.Click += new System.EventHandler(this.CreateTSMI_Click);
            // 
            // OpenTSMI
            // 
            this.OpenTSMI.Name = "OpenTSMI";
            this.OpenTSMI.Size = new System.Drawing.Size(180, 22);
            this.OpenTSMI.Text = "Загрузить";
            this.OpenTSMI.Click += new System.EventHandler(this.OpenTSMI_Click);
            // 
            // SaveTSMI
            // 
            this.SaveTSMI.Name = "SaveTSMI";
            this.SaveTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveTSMI.Size = new System.Drawing.Size(180, 22);
            this.SaveTSMI.Text = "Сохранить";
            this.SaveTSMI.Click += new System.EventHandler(this.SaveTSMI_Click);
            // 
            // ExitTSMI
            // 
            this.ExitTSMI.Name = "ExitTSMI";
            this.ExitTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.End)));
            this.ExitTSMI.Size = new System.Drawing.Size(173, 22);
            this.ExitTSMI.Text = "Выход";
            this.ExitTSMI.Click += new System.EventHandler(this.ExitTSMI_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgramTSMI});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // ProgramTSMI
            // 
            this.ProgramTSMI.Name = "ProgramTSMI";
            this.ProgramTSMI.Size = new System.Drawing.Size(180, 22);
            this.ProgramTSMI.Text = "О программе";
            this.ProgramTSMI.Click += new System.EventHandler(this.ProgramTSMI_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyTSMI,
            this.PasteTSMI,
            this.CutTSMI});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // CopyTSMI
            // 
            this.CopyTSMI.Name = "CopyTSMI";
            this.CopyTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyTSMI.Size = new System.Drawing.Size(181, 22);
            this.CopyTSMI.Text = "Копировать";
            this.CopyTSMI.Click += new System.EventHandler(this.CopyTSMI_Click);
            // 
            // PasteTSMI
            // 
            this.PasteTSMI.Name = "PasteTSMI";
            this.PasteTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteTSMI.Size = new System.Drawing.Size(181, 22);
            this.PasteTSMI.Text = "Вставить";
            this.PasteTSMI.Click += new System.EventHandler(this.PasteTSMI_Click);
            // 
            // CutTSMI
            // 
            this.CutTSMI.Name = "CutTSMI";
            this.CutTSMI.Size = new System.Drawing.Size(181, 22);
            this.CutTSMI.Text = "Вырезать";
            this.CutTSMI.Click += new System.EventHandler(this.CutTSMI_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BoldTSMI,
            this.UnderLineTSMI,
            this.ItalicTSMI,
            this.BlackTSMI,
            this.BlueTSMI,
            this.RedTSMI,
            this.GreenTSMI,
            this.toolStripLabel1,
            this.FontComboBox,
            this.toolStripLabel2,
            this.SizeComboBox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BoldTSMI
            // 
            this.BoldTSMI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BoldTSMI.Image = global::Блокнот.Properties.Resources.Bold;
            this.BoldTSMI.ImageTransparentColor = System.Drawing.Color.Crimson;
            this.BoldTSMI.Name = "BoldTSMI";
            this.BoldTSMI.Size = new System.Drawing.Size(23, 22);
            this.BoldTSMI.Text = "toolStripButton1";
            this.BoldTSMI.Click += new System.EventHandler(this.BoldTSMI_Click);
            // 
            // UnderLineTSMI
            // 
            this.UnderLineTSMI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UnderLineTSMI.Image = global::Блокнот.Properties.Resources.underline;
            this.UnderLineTSMI.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UnderLineTSMI.Name = "UnderLineTSMI";
            this.UnderLineTSMI.Size = new System.Drawing.Size(23, 22);
            this.UnderLineTSMI.Text = "toolStripButton2";
            this.UnderLineTSMI.Click += new System.EventHandler(this.UnderLineTSMI_Click);
            // 
            // ItalicTSMI
            // 
            this.ItalicTSMI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItalicTSMI.Image = global::Блокнот.Properties.Resources.italic;
            this.ItalicTSMI.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItalicTSMI.Name = "ItalicTSMI";
            this.ItalicTSMI.Size = new System.Drawing.Size(23, 22);
            this.ItalicTSMI.Text = "toolStripButton3";
            this.ItalicTSMI.Click += new System.EventHandler(this.ItalicTSMI_Click);
            // 
            // BlackTSMI
            // 
            this.BlackTSMI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BlackTSMI.Image = global::Блокнот.Properties.Resources.Black;
            this.BlackTSMI.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BlackTSMI.Name = "BlackTSMI";
            this.BlackTSMI.Size = new System.Drawing.Size(23, 22);
            this.BlackTSMI.Text = "toolStripButton4";
            this.BlackTSMI.Click += new System.EventHandler(this.BlackTSMI_Click);
            // 
            // BlueTSMI
            // 
            this.BlueTSMI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BlueTSMI.Image = global::Блокнот.Properties.Resources.blue;
            this.BlueTSMI.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BlueTSMI.Name = "BlueTSMI";
            this.BlueTSMI.Size = new System.Drawing.Size(23, 22);
            this.BlueTSMI.Text = "toolStripButton5";
            this.BlueTSMI.Click += new System.EventHandler(this.BlueTSMI_Click);
            // 
            // RedTSMI
            // 
            this.RedTSMI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RedTSMI.Image = global::Блокнот.Properties.Resources.red;
            this.RedTSMI.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RedTSMI.Name = "RedTSMI";
            this.RedTSMI.Size = new System.Drawing.Size(23, 22);
            this.RedTSMI.Text = "toolStripButton6";
            this.RedTSMI.Click += new System.EventHandler(this.RedTSMI_Click);
            // 
            // GreenTSMI
            // 
            this.GreenTSMI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GreenTSMI.Image = global::Блокнот.Properties.Resources.green;
            this.GreenTSMI.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GreenTSMI.Name = "GreenTSMI";
            this.GreenTSMI.Size = new System.Drawing.Size(23, 22);
            this.GreenTSMI.Text = "toolStripButton7";
            this.GreenTSMI.Click += new System.EventHandler(this.GreenTSMI_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(46, 22);
            this.toolStripLabel1.Text = "Шрифт";
            // 
            // FontComboBox
            // 
            this.FontComboBox.Items.AddRange(new object[] {
            "Times New Roman",
            "Arial",
            "Tahoma",
            ""});
            this.FontComboBox.Name = "FontComboBox";
            this.FontComboBox.Size = new System.Drawing.Size(121, 25);
            this.FontComboBox.Text = "Times New Roman";
            this.FontComboBox.SelectedIndexChanged += new System.EventHandler(this.FontComboBox_SelectedIndexChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel2.Text = "Размер";
            // 
            // SizeComboBox
            // 
            this.SizeComboBox.Items.AddRange(new object[] {
            "10",
            "12",
            "14",
            "16",
            "18"});
            this.SizeComboBox.Name = "SizeComboBox";
            this.SizeComboBox.Size = new System.Drawing.Size(121, 25);
            this.SizeComboBox.Text = "10";
            this.SizeComboBox.SelectedIndexChanged += new System.EventHandler(this.SizeComboBox_SelectedIndexChanged);
            // 
            // NotePadRichTextBox
            // 
            this.NotePadRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotePadRichTextBox.Location = new System.Drawing.Point(0, 49);
            this.NotePadRichTextBox.Name = "NotePadRichTextBox";
            this.NotePadRichTextBox.Size = new System.Drawing.Size(800, 401);
            this.NotePadRichTextBox.TabIndex = 2;
            this.NotePadRichTextBox.Text = "";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NotePadRichTextBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form";
            this.Text = "Мой блокнот";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateTSMI;
        private System.Windows.Forms.ToolStripMenuItem OpenTSMI;
        private System.Windows.Forms.ToolStripMenuItem SaveTSMI;
        private System.Windows.Forms.ToolStripMenuItem ExitTSMI;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProgramTSMI;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyTSMI;
        private System.Windows.Forms.ToolStripMenuItem PasteTSMI;
        private System.Windows.Forms.ToolStripMenuItem CutTSMI;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BoldTSMI;
        private System.Windows.Forms.ToolStripButton UnderLineTSMI;
        private System.Windows.Forms.ToolStripButton ItalicTSMI;
        private System.Windows.Forms.ToolStripButton BlackTSMI;
        private System.Windows.Forms.ToolStripButton BlueTSMI;
        private System.Windows.Forms.ToolStripButton RedTSMI;
        private System.Windows.Forms.ToolStripButton GreenTSMI;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox FontComboBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox SizeComboBox;
        private System.Windows.Forms.RichTextBox NotePadRichTextBox;
    }
}


namespace Image_Coupling.Plugins
{
    partial class Extrctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Extrctor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenPDFButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectFolderButton = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFolderButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.画像DPIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DPISelectBox = new System.Windows.Forms.ToolStripComboBox();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenHelpButton = new System.Windows.Forms.ToolStripMenuItem();
            this.TargetBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.AutoCheckBox = new System.Windows.Forms.CheckBox();
            this.ExtractButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.画像DPIDToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(505, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenPDFButton,
            this.toolStripMenuItem2,
            this.SelectFolderButton,
            this.OpenFolderButton,
            this.toolStripMenuItem1,
            this.ExitButton});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.ファイルFToolStripMenuItem.Text = "ファイル(F)";
            // 
            // OpenPDFButton
            // 
            this.OpenPDFButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenPDFButton.Image")));
            this.OpenPDFButton.Name = "OpenPDFButton";
            this.OpenPDFButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenPDFButton.Size = new System.Drawing.Size(192, 22);
            this.OpenPDFButton.Text = "PDFを開く";
            this.OpenPDFButton.Click += new System.EventHandler(this.OpenPDFButton_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(189, 6);
            // 
            // SelectFolderButton
            // 
            this.SelectFolderButton.Name = "SelectFolderButton";
            this.SelectFolderButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.SelectFolderButton.Size = new System.Drawing.Size(192, 22);
            this.SelectFolderButton.Text = "出力先の指定";
            this.SelectFolderButton.Click += new System.EventHandler(this.SelectFolderButton_Click);
            // 
            // OpenFolderButton
            // 
            this.OpenFolderButton.Name = "OpenFolderButton";
            this.OpenFolderButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.OpenFolderButton.Size = new System.Drawing.Size(192, 22);
            this.OpenFolderButton.Text = "保存先を開く";
            this.OpenFolderButton.Click += new System.EventHandler(this.OpenFolderButton_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(189, 6);
            // 
            // ExitButton
            // 
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.ExitButton.Size = new System.Drawing.Size(192, 22);
            this.ExitButton.Text = "終了";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // 画像DPIDToolStripMenuItem
            // 
            this.画像DPIDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DPISelectBox});
            this.画像DPIDToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("画像DPIDToolStripMenuItem.Image")));
            this.画像DPIDToolStripMenuItem.Name = "画像DPIDToolStripMenuItem";
            this.画像DPIDToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.画像DPIDToolStripMenuItem.Text = "画像DPI（&D）";
            // 
            // DPISelectBox
            // 
            this.DPISelectBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.DPISelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DPISelectBox.Name = "DPISelectBox";
            this.DPISelectBox.Size = new System.Drawing.Size(121, 26);
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenHelpButton});
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(H)";
            // 
            // OpenHelpButton
            // 
            this.OpenHelpButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenHelpButton.Image")));
            this.OpenHelpButton.Name = "OpenHelpButton";
            this.OpenHelpButton.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.H)));
            this.OpenHelpButton.Size = new System.Drawing.Size(222, 22);
            this.OpenHelpButton.Text = "ヘルプを表示";
            // 
            // TargetBox
            // 
            this.TargetBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TargetBox.Location = new System.Drawing.Point(19, 68);
            this.TargetBox.Name = "TargetBox";
            this.TargetBox.ReadOnly = true;
            this.TargetBox.Size = new System.Drawing.Size(469, 19);
            this.TargetBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "抽出対象：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(16, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "出力先：";
            // 
            // OutputBox
            // 
            this.OutputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputBox.Location = new System.Drawing.Point(19, 131);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(469, 19);
            this.OutputBox.TabIndex = 4;
            this.OutputBox.TextChanged += new System.EventHandler(this.OutputBox_TextChanged);
            // 
            // AutoCheckBox
            // 
            this.AutoCheckBox.AutoSize = true;
            this.AutoCheckBox.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AutoCheckBox.Location = new System.Drawing.Point(19, 162);
            this.AutoCheckBox.Name = "AutoCheckBox";
            this.AutoCheckBox.Size = new System.Drawing.Size(186, 17);
            this.AutoCheckBox.TabIndex = 6;
            this.AutoCheckBox.Text = "出力先フォルダを自動生成する";
            this.AutoCheckBox.UseVisualStyleBackColor = true;
            this.AutoCheckBox.CheckedChanged += new System.EventHandler(this.AutoCheckBox_CheckedChanged);
            // 
            // ExtractButton
            // 
            this.ExtractButton.Location = new System.Drawing.Point(363, 162);
            this.ExtractButton.Name = "ExtractButton";
            this.ExtractButton.Size = new System.Drawing.Size(125, 39);
            this.ExtractButton.TabIndex = 7;
            this.ExtractButton.Text = "画像を出力";
            this.ExtractButton.UseVisualStyleBackColor = true;
            this.ExtractButton.Click += new System.EventHandler(this.ExtractButton_Click);
            // 
            // Extrctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 218);
            this.Controls.Add(this.ExtractButton);
            this.Controls.Add(this.AutoCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TargetBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Extrctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extractor Beta v1.0   |   Sakamochanq";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenPDFButton;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExitButton;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenHelpButton;
        private System.Windows.Forms.TextBox TargetBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem SelectFolderButton;
        private System.Windows.Forms.CheckBox AutoCheckBox;
        private System.Windows.Forms.Button ExtractButton;
        private System.Windows.Forms.ToolStripMenuItem OpenFolderButton;
        private System.Windows.Forms.ToolStripMenuItem 画像DPIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox DPISelectBox;
    }
}
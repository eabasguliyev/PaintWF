
namespace PaintWF
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
            this.PanelPaintArea = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonSelectColor = new System.Windows.Forms.Button();
            this.PanelTools = new System.Windows.Forms.Panel();
            this.RadioButtonBrush = new System.Windows.Forms.RadioButton();
            this.RadioButtonPen = new System.Windows.Forms.RadioButton();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.PanelProperties = new System.Windows.Forms.Panel();
            this.TextBoxHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckBoxManual = new System.Windows.Forms.CheckBox();
            this.ComboBoxFigures = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelColorView = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.PanelTools.SuspendLayout();
            this.PanelProperties.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPaintArea
            // 
            this.PanelPaintArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelPaintArea.Location = new System.Drawing.Point(0, 94);
            this.PanelPaintArea.Name = "PanelPaintArea";
            this.PanelPaintArea.Size = new System.Drawing.Size(742, 379);
            this.PanelPaintArea.TabIndex = 0;
            this.PanelPaintArea.Click += new System.EventHandler(this.PanelPaintArea_Click);
            this.PanelPaintArea.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPaintArea_Paint);
            this.PanelPaintArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelPaintArea_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PanelColorView);
            this.panel1.Controls.Add(this.ButtonSelectColor);
            this.panel1.Controls.Add(this.PanelTools);
            this.panel1.Controls.Add(this.ButtonClear);
            this.panel1.Controls.Add(this.PanelProperties);
            this.panel1.Controls.Add(this.CheckBoxManual);
            this.panel1.Controls.Add(this.ComboBoxFigures);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 66);
            this.panel1.TabIndex = 1;
            // 
            // ButtonSelectColor
            // 
            this.ButtonSelectColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonSelectColor.Location = new System.Drawing.Point(462, 4);
            this.ButtonSelectColor.Name = "ButtonSelectColor";
            this.ButtonSelectColor.Size = new System.Drawing.Size(72, 29);
            this.ButtonSelectColor.TabIndex = 14;
            this.ButtonSelectColor.Text = "Color";
            this.ButtonSelectColor.UseVisualStyleBackColor = true;
            this.ButtonSelectColor.Click += new System.EventHandler(this.ButtonSelectColor_Click);
            // 
            // PanelTools
            // 
            this.PanelTools.Controls.Add(this.RadioButtonBrush);
            this.PanelTools.Controls.Add(this.RadioButtonPen);
            this.PanelTools.Location = new System.Drawing.Point(540, 6);
            this.PanelTools.Name = "PanelTools";
            this.PanelTools.Size = new System.Drawing.Size(86, 54);
            this.PanelTools.TabIndex = 13;
            // 
            // RadioButtonBrush
            // 
            this.RadioButtonBrush.AutoSize = true;
            this.RadioButtonBrush.Location = new System.Drawing.Point(13, 30);
            this.RadioButtonBrush.Name = "RadioButtonBrush";
            this.RadioButtonBrush.Size = new System.Drawing.Size(66, 21);
            this.RadioButtonBrush.TabIndex = 1;
            this.RadioButtonBrush.TabStop = true;
            this.RadioButtonBrush.Text = "Brush";
            this.RadioButtonBrush.UseVisualStyleBackColor = true;
            this.RadioButtonBrush.CheckedChanged += new System.EventHandler(this.RadioButtonBrush_CheckedChanged);
            // 
            // RadioButtonPen
            // 
            this.RadioButtonPen.AutoSize = true;
            this.RadioButtonPen.Checked = true;
            this.RadioButtonPen.Location = new System.Drawing.Point(13, 5);
            this.RadioButtonPen.Name = "RadioButtonPen";
            this.RadioButtonPen.Size = new System.Drawing.Size(54, 21);
            this.RadioButtonPen.TabIndex = 0;
            this.RadioButtonPen.TabStop = true;
            this.RadioButtonPen.Text = "Pen";
            this.RadioButtonPen.UseVisualStyleBackColor = true;
            this.RadioButtonPen.CheckedChanged += new System.EventHandler(this.RadioButtonPen_CheckedChanged);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonClear.Location = new System.Drawing.Point(633, 5);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(72, 57);
            this.ButtonClear.TabIndex = 13;
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // PanelProperties
            // 
            this.PanelProperties.Controls.Add(this.TextBoxHeight);
            this.PanelProperties.Controls.Add(this.label2);
            this.PanelProperties.Controls.Add(this.TextBoxWidth);
            this.PanelProperties.Controls.Add(this.label1);
            this.PanelProperties.Location = new System.Drawing.Point(244, 0);
            this.PanelProperties.Name = "PanelProperties";
            this.PanelProperties.Size = new System.Drawing.Size(212, 66);
            this.PanelProperties.TabIndex = 8;
            // 
            // TextBoxHeight
            // 
            this.TextBoxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextBoxHeight.Location = new System.Drawing.Point(79, 34);
            this.TextBoxHeight.MaxLength = 10;
            this.TextBoxHeight.Multiline = true;
            this.TextBoxHeight.Name = "TextBoxHeight";
            this.TextBoxHeight.Size = new System.Drawing.Size(122, 29);
            this.TextBoxHeight.TabIndex = 10;
            this.TextBoxHeight.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Height";
            // 
            // TextBoxWidth
            // 
            this.TextBoxWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextBoxWidth.Location = new System.Drawing.Point(79, 4);
            this.TextBoxWidth.MaxLength = 10;
            this.TextBoxWidth.Multiline = true;
            this.TextBoxWidth.Name = "TextBoxWidth";
            this.TextBoxWidth.Size = new System.Drawing.Size(122, 29);
            this.TextBoxWidth.TabIndex = 8;
            this.TextBoxWidth.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Width";
            // 
            // CheckBoxManual
            // 
            this.CheckBoxManual.AutoSize = true;
            this.CheckBoxManual.Location = new System.Drawing.Point(170, 22);
            this.CheckBoxManual.Name = "CheckBoxManual";
            this.CheckBoxManual.Size = new System.Drawing.Size(76, 21);
            this.CheckBoxManual.TabIndex = 7;
            this.CheckBoxManual.Text = "Manual";
            this.CheckBoxManual.UseVisualStyleBackColor = true;
            this.CheckBoxManual.CheckedChanged += new System.EventHandler(this.CheckBoxManual_CheckedChanged);
            // 
            // ComboBoxFigures
            // 
            this.ComboBoxFigures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFigures.FormattingEnabled = true;
            this.ComboBoxFigures.Location = new System.Drawing.Point(12, 22);
            this.ComboBoxFigures.Name = "ComboBoxFigures";
            this.ComboBoxFigures.Size = new System.Drawing.Size(136, 24);
            this.ComboBoxFigures.TabIndex = 0;
            this.ComboBoxFigures.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFigures_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // PanelColorView
            // 
            this.PanelColorView.Location = new System.Drawing.Point(464, 34);
            this.PanelColorView.Name = "PanelColorView";
            this.PanelColorView.Size = new System.Drawing.Size(70, 28);
            this.PanelColorView.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(742, 473);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelPaintArea);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(760, 520);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelTools.ResumeLayout(false);
            this.PanelTools.PerformLayout();
            this.PanelProperties.ResumeLayout(false);
            this.PanelProperties.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelPaintArea;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ComboBoxFigures;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Panel PanelProperties;
        private System.Windows.Forms.TextBox TextBoxHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CheckBoxManual;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button ButtonSelectColor;
        private System.Windows.Forms.Panel PanelTools;
        private System.Windows.Forms.RadioButton RadioButtonBrush;
        private System.Windows.Forms.RadioButton RadioButtonPen;
        private System.Windows.Forms.Panel PanelColorView;
    }
}


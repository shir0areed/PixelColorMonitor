﻿
namespace PixelColorMonitor
{
    partial class PixelColorMonitorForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PixelColorMonitorForm));
            this.PickButton = new System.Windows.Forms.Button();
            this.PickTimer = new System.Windows.Forms.Timer(this.components);
            this.HSVLabel = new System.Windows.Forms.Label();
            this.RGBLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LocationLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.HSVBox = new PixelColorMonitor.CopiableTextBox();
            this.RGBBox = new PixelColorMonitor.CopiableTextBox();
            this.ColorBox = new PixelColorMonitor.ColorBox();
            this.FloatButton = new System.Windows.Forms.RadioButton();
            this.IntButton = new System.Windows.Forms.RadioButton();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PickButton
            // 
            this.PickButton.Location = new System.Drawing.Point(13, 13);
            this.PickButton.Name = "PickButton";
            this.PickButton.Size = new System.Drawing.Size(80, 40);
            this.PickButton.TabIndex = 0;
            this.PickButton.Text = "取得";
            this.PickButton.UseVisualStyleBackColor = true;
            this.PickButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PickButton_MouseMove);
            // 
            // PickTimer
            // 
            this.PickTimer.Enabled = true;
            this.PickTimer.Tick += new System.EventHandler(this.PickTimer_Tick);
            // 
            // HSVLabel
            // 
            this.HSVLabel.Location = new System.Drawing.Point(12, 103);
            this.HSVLabel.Name = "HSVLabel";
            this.HSVLabel.Size = new System.Drawing.Size(60, 30);
            this.HSVLabel.TabIndex = 3;
            this.HSVLabel.Text = "HSV";
            // 
            // RGBLabel
            // 
            this.RGBLabel.Location = new System.Drawing.Point(12, 62);
            this.RGBLabel.Name = "RGBLabel";
            this.RGBLabel.Size = new System.Drawing.Size(60, 30);
            this.RGBLabel.TabIndex = 4;
            this.RGBLabel.Text = "RGB";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LocationLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 138);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(357, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LocationLabel
            // 
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(118, 17);
            this.LocationLabel.Text = "toolStripStatusLabel1";
            // 
            // HSVBox
            // 
            this.HSVBox.Location = new System.Drawing.Point(78, 100);
            this.HSVBox.Name = "HSVBox";
            this.HSVBox.ReadOnly = true;
            this.HSVBox.Size = new System.Drawing.Size(267, 35);
            this.HSVBox.TabIndex = 6;
            // 
            // RGBBox
            // 
            this.RGBBox.Location = new System.Drawing.Point(78, 59);
            this.RGBBox.Name = "RGBBox";
            this.RGBBox.ReadOnly = true;
            this.RGBBox.Size = new System.Drawing.Size(267, 35);
            this.RGBBox.TabIndex = 5;
            // 
            // ColorBox
            // 
            this.ColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorBox.Image = ((System.Drawing.Image)(resources.GetObject("ColorBox.Image")));
            this.ColorBox.Location = new System.Drawing.Point(99, 13);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(40, 40);
            this.ColorBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ColorBox.TabIndex = 1;
            this.ColorBox.TabStop = false;
            // 
            // FloatButton
            // 
            this.FloatButton.AutoSize = true;
            this.FloatButton.Checked = true;
            this.FloatButton.Location = new System.Drawing.Point(210, 16);
            this.FloatButton.Name = "FloatButton";
            this.FloatButton.Size = new System.Drawing.Size(74, 34);
            this.FloatButton.TabIndex = 8;
            this.FloatButton.TabStop = true;
            this.FloatButton.Text = "float";
            this.FloatButton.UseVisualStyleBackColor = true;
            // 
            // IntButton
            // 
            this.IntButton.AutoSize = true;
            this.IntButton.Location = new System.Drawing.Point(290, 16);
            this.IntButton.Name = "IntButton";
            this.IntButton.Size = new System.Drawing.Size(55, 34);
            this.IntButton.TabIndex = 9;
            this.IntButton.Text = "int";
            this.IntButton.UseVisualStyleBackColor = true;
            // 
            // PixelColorMonitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(357, 160);
            this.Controls.Add(this.FloatButton);
            this.Controls.Add(this.IntButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.HSVBox);
            this.Controls.Add(this.RGBBox);
            this.Controls.Add(this.RGBLabel);
            this.Controls.Add(this.HSVLabel);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.PickButton);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PixelColorMonitorForm";
            this.Text = "PixelColorMonitor";
            this.TopMost = true;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PickButton;
        private PixelColorMonitor.ColorBox ColorBox;
        private System.Windows.Forms.Timer PickTimer;
        private System.Windows.Forms.Label HSVLabel;
        private System.Windows.Forms.Label RGBLabel;
        private PixelColorMonitor.CopiableTextBox RGBBox;
        private PixelColorMonitor.CopiableTextBox HSVBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LocationLabel;
        private System.Windows.Forms.RadioButton FloatButton;
        private System.Windows.Forms.RadioButton IntButton;
    }
}


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
            this.PickButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ColorBox = new PixelColorMonitor.ColorBox();
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
            this.PickButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PickButton_MouseUp);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(145, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "{X=XXXX,Y=XXXX}";
            // 
            // ColorBox
            // 
            this.ColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorBox.Location = new System.Drawing.Point(99, 13);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(40, 40);
            this.ColorBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ColorBox.TabIndex = 1;
            this.ColorBox.TabStop = false;
            // 
            // PixelColorMonitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.PickButton);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PixelColorMonitorForm";
            this.Text = "PixelColorMonitor";
            ((System.ComponentModel.ISupportInitialize)(this.ColorBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PickButton;
        private PixelColorMonitor.ColorBox ColorBox;
        private System.Windows.Forms.Label label1;
    }
}


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
            // 
            // PixelColorMonitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PickButton);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PixelColorMonitorForm";
            this.Text = "PixelColorMonitor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PickButton;
    }
}

namespace ManagementController.WinForm
{
    partial class MainView
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
            this.MainButton = new System.Windows.Forms.Button();
            this.SampleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainButton
            // 
            this.MainButton.Location = new System.Drawing.Point(247, 123);
            this.MainButton.Name = "MainButton";
            this.MainButton.Size = new System.Drawing.Size(80, 40);
            this.MainButton.TabIndex = 0;
            this.MainButton.Text = "実行";
            this.MainButton.UseVisualStyleBackColor = true;
            // 
            // SampleLabel
            // 
            this.SampleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SampleLabel.Location = new System.Drawing.Point(12, 12);
            this.SampleLabel.Name = "SampleLabel";
            this.SampleLabel.Size = new System.Drawing.Size(80, 40);
            this.SampleLabel.TabIndex = 1;
            this.SampleLabel.Text = "-";
            this.SampleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 175);
            this.Controls.Add(this.SampleLabel);
            this.Controls.Add(this.MainButton);
            this.Name = "MainView";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MainButton;
        private System.Windows.Forms.Label SampleLabel;
    }
}


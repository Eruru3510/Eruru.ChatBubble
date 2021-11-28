namespace Eruru.ChatBubble {
	partial class ChatBubbleListViewItem {
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose (bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region 组件设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent () {
			this.PictureBox = new System.Windows.Forms.PictureBox ();
			this.Label = new System.Windows.Forms.Label ();
			this.Panel = new System.Windows.Forms.Panel ();
			this.RichTextBox = new System.Windows.Forms.RichTextBox ();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit ();
			this.Panel.SuspendLayout ();
			this.SuspendLayout ();
			// 
			// PictureBox_ProfilePhoto
			// 
			this.PictureBox.Location = new System.Drawing.Point (0, 0);
			this.PictureBox.Name = "PictureBox_ProfilePhoto";
			this.PictureBox.Size = new System.Drawing.Size (32, 32);
			this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox.TabIndex = 0;
			this.PictureBox.TabStop = false;
			// 
			// Label_Nickname
			// 
			this.Label.AutoSize = true;
			this.Label.Location = new System.Drawing.Point (40, 0);
			this.Label.Name = "Label_Nickname";
			this.Label.Size = new System.Drawing.Size (53, 12);
			this.Label.TabIndex = 1;
			this.Label.Text = "Nickname";
			// 
			// Panel_Bubble
			// 
			this.Panel.BackColor = System.Drawing.Color.LightGreen;
			this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel.Controls.Add (this.RichTextBox);
			this.Panel.Location = new System.Drawing.Point (40, 20);
			this.Panel.Name = "Panel_Bubble";
			this.Panel.Size = new System.Drawing.Size (240, 95);
			this.Panel.TabIndex = 3;
			// 
			// RichTextBox_Content
			// 
			this.RichTextBox.BackColor = System.Drawing.Color.LightGreen;
			this.RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.RichTextBox.Font = new System.Drawing.Font ("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.RichTextBox.Location = new System.Drawing.Point (10, 10);
			this.RichTextBox.Name = "RichTextBox_Content";
			this.RichTextBox.ReadOnly = true;
			this.RichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.RichTextBox.Size = new System.Drawing.Size (218, 73);
			this.RichTextBox.TabIndex = 4;
			this.RichTextBox.Text = "Content";
			this.RichTextBox.WordWrap = false;
			this.RichTextBox.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler (this.RichTextBox_ContentsResized);
			// 
			// ChatBubble
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add (this.Panel);
			this.Controls.Add (this.Label);
			this.Controls.Add (this.PictureBox);
			this.Name = "ChatBubble";
			this.Size = new System.Drawing.Size (280, 119);
			((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit ();
			this.Panel.ResumeLayout (false);
			this.ResumeLayout (false);
			this.PerformLayout ();

		}

		#endregion

		private System.Windows.Forms.PictureBox PictureBox;
		private System.Windows.Forms.Label Label;
		private System.Windows.Forms.Panel Panel;
		private System.Windows.Forms.RichTextBox RichTextBox;
	}
}

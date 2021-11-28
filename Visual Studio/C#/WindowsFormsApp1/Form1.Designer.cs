
namespace WindowsFormsApp1 {
	partial class Form1 {
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

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent () {
			this.components = new System.ComponentModel.Container();
			this.RichTextBox = new System.Windows.Forms.RichTextBox();
			this.ChatBubbleListView = new Eruru.ChatBubble.ChatBubbleListView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.测试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// RichTextBox
			// 
			this.RichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RichTextBox.Location = new System.Drawing.Point(5, 403);
			this.RichTextBox.Name = "RichTextBox";
			this.RichTextBox.Size = new System.Drawing.Size(739, 140);
			this.RichTextBox.TabIndex = 1;
			this.RichTextBox.Text = "111111111111111111111111111111111111";
			this.RichTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RichTextBox_KeyDown);
			// 
			// ChatBubbleListView
			// 
			this.ChatBubbleListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ChatBubbleListView.AutoScroll = true;
			this.ChatBubbleListView.AutoScrollMargin = new System.Drawing.Size(100, 0);
			this.ChatBubbleListView.Location = new System.Drawing.Point(5, 5);
			this.ChatBubbleListView.Name = "ChatBubbleListView";
			this.ChatBubbleListView.Size = new System.Drawing.Size(739, 393);
			this.ChatBubbleListView.Spacing = 10;
			this.ChatBubbleListView.TabIndex = 0;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.测试ToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
			// 
			// 测试ToolStripMenuItem
			// 
			this.测试ToolStripMenuItem.Name = "测试ToolStripMenuItem";
			this.测试ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.测试ToolStripMenuItem.Text = "测试";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(749, 547);
			this.Controls.Add(this.RichTextBox);
			this.Controls.Add(this.ChatBubbleListView);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Eruru.ChatBubble.ChatBubbleListView ChatBubbleListView;
		private System.Windows.Forms.RichTextBox RichTextBox;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 测试ToolStripMenuItem;
	}
}


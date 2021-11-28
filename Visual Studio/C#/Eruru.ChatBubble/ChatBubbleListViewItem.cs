using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Eruru.ChatBubble {

	public partial class ChatBubbleListViewItem : UserControl {

		public ChatBubbleListViewItemType Type {

			get => _Type;

			set {
				_Type = value;
				switch (value) {
					case ChatBubbleListViewItemType.Other:
						PictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Left;
						PictureBox.Left = ProfilePhotoLeft;
						Panel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
						Panel.Left = BubbleLeft;
						Label.Visible = true;
						BubbleColor = Color.White;
						break;
					case ChatBubbleListViewItemType.Self:
						PictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
						PictureBox.Left = Width - PictureBox.Width - ProfilePhotoLeft;
						Panel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
						Panel.Left = Width - Panel.Width - BubbleLeft;
						Label.Visible = false;
						BubbleColor = Color.LightGreen;
						break;
					default:
						throw new NotImplementedException ();
				}
			}

		}
		public string Nickname {

			get => Label.Text;

			set => Label.Text = value;

		}
		public Image ProfilePhoto {

			get => PictureBox.Image;

			set => PictureBox.Image = value;

		}
		public string Rtf {

			get => RichTextBox.Rtf;

			set {
				RichTextBox.WordWrap = false;
				try {
					RichTextBox.Rtf = value;
				} catch {
					RichTextBox.Text = value;
				}
				RichTextBox.WordWrap = true;
			}

		}
		public new string Text {

			get => RichTextBox.Text;

			set {
				RichTextBox.WordWrap = false;
				RichTextBox.Text = value;
				RichTextBox.WordWrap = true;
			}

		}
		public int ContentMargin {

			get => _ContentMargin;

			set {
				_ContentMargin = value;
				OnContentSizeChanged ();
			}

		}
		public Color BubbleColor {

			get => Panel.BackColor;

			set => SetBubbleColor (value);

		}
		public new ContextMenuStrip ContextMenuStrip {

			get => Panel.ContextMenuStrip;

			set {
				Panel.ContextMenuStrip = value;
				RichTextBox.ContextMenuStrip = value;
			}

		}

		readonly int ProfilePhotoLeft;
		readonly int BubbleLeft;

		ChatBubbleListViewItemType _Type;
		int _ContentMargin = 10;
		int MaxWidth;

		public ChatBubbleListViewItem (ChatBubbleListViewItemType type, string nickname, Image profilePhoto, string rtf) {
			InitializeComponent ();
			ProfilePhotoLeft = PictureBox.Left;
			BubbleLeft = Panel.Left;
			Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			GraphicsPath ellipseMask = new GraphicsPath ();
			ellipseMask.AddEllipse (PictureBox.ClientRectangle);
			PictureBox.Region = new Region (ellipseMask);
			Type = type;
			Nickname = nickname ?? throw new ArgumentNullException (nameof (nickname));
			ProfilePhoto = profilePhoto;
			Rtf = rtf ?? throw new ArgumentNullException (nameof (rtf));
		}

		private void RichTextBox_ContentsResized (object sender, ContentsResizedEventArgs e) {
			RichTextBox.Size = e.NewRectangle.Size;
			if (MaxWidth < e.NewRectangle.Width) {
				MaxWidth = e.NewRectangle.Width;
			}
			OnContentSizeChanged ();
		}

		void SetBubbleColor (Color color) {
			Panel.BackColor = color;
			RichTextBox.BackColor = color;
		}

		internal void SetWidth (int width) {
			Width = width;
			RichTextBox.Width = Math.Min (Width - BubbleLeft - ContentMargin * 2, MaxWidth);
			OnContentSizeChanged ();
		}

		void OnContentSizeChanged () {
			Panel.Size = new Size (RichTextBox.Width + ContentMargin * 2, RichTextBox.Height + ContentMargin * 2);
			Height = Panel.Bottom;
			if (Type == ChatBubbleListViewItemType.Self) {
				Panel.Location = new Point (Width - Panel.Width - BubbleLeft, Panel.Top);
			}
		}

	}

}
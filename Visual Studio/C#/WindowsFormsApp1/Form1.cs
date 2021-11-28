using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Eruru.ChatBubble;

namespace WindowsFormsApp1 {

	public partial class Form1 : Form {

		readonly Bitmap OtherProfilePhoto;
		readonly Bitmap OwnProfilePhoto;
		readonly Random Random = new Random ();


		public Form1 () {
			InitializeComponent ();
			Assembly assembly = Assembly.GetExecutingAssembly ();
			OtherProfilePhoto = new Bitmap (assembly.GetManifestResourceStream ($"{nameof (WindowsFormsApp1)}.Aruru.jpg"));
			OwnProfilePhoto = new Bitmap (assembly.GetManifestResourceStream ($"{nameof (WindowsFormsApp1)}.Eruru.png"));
		}

		private void RichTextBox_KeyDown (object sender, KeyEventArgs e) {
			if (!e.Control && e.KeyCode == Keys.Enter) {
				e.Handled = true;
				RichTextBox.Rtf = RichTextBox.Rtf.Trim ();
				if (RichTextBox.TextLength == 0) {
					return;
				}
				ChatBubbleListViewItem chatBubbleListViewItem;
				switch (Random.Next (2)) {
					case 0:
						chatBubbleListViewItem = ChatBubbleListView.Add (ChatBubbleListViewItemType.Other, "Aruru", OtherProfilePhoto, RichTextBox.Rtf);
						break;
					case 1:
						chatBubbleListViewItem = ChatBubbleListView.Add (ChatBubbleListViewItemType.Self, "Eruru", OwnProfilePhoto, RichTextBox.Rtf);
						break;
					default:
						throw new NotImplementedException ();
				}
				chatBubbleListViewItem.ContextMenuStrip = contextMenuStrip1;
				RichTextBox.Clear ();
				return;
			}
		}

	}

}
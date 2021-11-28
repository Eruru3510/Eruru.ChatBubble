using System;
using System.Drawing;
using System.Windows.Forms;

namespace Eruru.ChatBubble {

	public partial class ChatBubbleListView : UserControl {

		public int Spacing {

			get => _Spacing;

			set {
				_Spacing = value;
				OnSpacingChanged ();
			}

		}

		int _Spacing = 10;
		int OldWidth;

		public ChatBubbleListView () {
			InitializeComponent ();
		}

		public ChatBubbleListViewItem Add (ChatBubbleListViewItem chatBubble) {
			if (chatBubble is null) {
				throw new ArgumentNullException (nameof (chatBubble));
			}
			chatBubble.Top = Controls.Count == 0 ? AutoScrollPosition.Y : Controls[Controls.Count - 1].Bottom + Spacing;
			Controls.Add (chatBubble);
			chatBubble.SetWidth (ClientSize.Width);
			return chatBubble;
		}
		public ChatBubbleListViewItem Add (ChatBubbleListViewItemType type, string nickname, Image profilePhoto, string rtf) {
			if (nickname is null) {
				throw new ArgumentNullException (nameof (nickname));
			}
			if (rtf is null) {
				throw new ArgumentNullException (nameof (rtf));
			}
			return Add (new ChatBubbleListViewItem (type, nickname, profilePhoto, rtf));
		}

		private void ChatBubbleListView_SizeChanged (object sender, EventArgs e) {
			if (OldWidth != ClientSize.Width) {
				OldWidth = ClientSize.Width;
				ChatBubbleListViewItem lastChatBubble = null;
				foreach (ChatBubbleListViewItem chatBubble in Controls) {
					chatBubble.Top = lastChatBubble is null ? AutoScrollPosition.Y : lastChatBubble.Bottom + Spacing;
					chatBubble.SetWidth (ClientSize.Width);
					lastChatBubble = chatBubble;
				}
			}
		}

		void OnSpacingChanged () {
			for (int i = 1; i < Controls.Count; i++) {
				Controls[i].Top = Controls[i - 1].Bottom + Spacing;
			}
		}

	}

}
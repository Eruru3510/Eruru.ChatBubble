using System;
using System.Windows.Forms;

namespace WindowsFormsApp2 {
	public partial class Form1 : Form {
		public Form1 () {
			InitializeComponent ();
		}

		private void richTextBox1_ContentsResized (object sender, ContentsResizedEventArgs e) {
			Console.WriteLine (e.NewRectangle);
			richTextBox1.Size = e.NewRectangle.Size;
		}
	}
}

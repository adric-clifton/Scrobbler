using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Scrobbler
{
	public partial class MainForm : Form
	{
		private Scrobble scrobbler = new Scrobble();

		public MainForm()
		{
			InitializeComponent();
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			lstOutput.Items.Clear();

			foreach (var wordList in scrobbler.GetWords(txtInput.Text))
			{
				foreach (var word in wordList.Value)
				{
					lstOutput.Items.Add(word);
				}

				lstOutput.Items.Add('\n');
			}
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			string word = (string)lstOutput.SelectedItem;

			if (word == null)
			{
				txtInput.Text = "";
				return;
			}

			List<char> rack = new List<char>(txtInput.Text);

			foreach (char letter in word)
			{
				rack.Remove(letter);
			}

			StringBuilder result = new StringBuilder();
			result.Append(rack.ToArray());

			txtInput.Text = result.ToString();
		}
	}
}

using System.Drawing.Printing;
using System.Drawing.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace wordpad
{
    public partial class Form1 : Form
    {

        public void createFontBox()
        {
            FontFamily[] fontFamilies;

            InstalledFontCollection installedFontCollection = new InstalledFontCollection();

            // Get the array of FontFamily objects.
            fontFamilies = installedFontCollection.Families;

            // The loop below creates a large string that is a comma-separated
            // list of all font family names.

            int count = fontFamilies.Length;
            for (int j = 0; j < count; ++j)
            {
                fontList.Items.Add(fontFamilies[j].Name);
            }
            fontList.SelectedIndex = fontList.Items.IndexOf(richTextBox1.SelectionFont.Name);

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (filePath.Text.Equals(""))
            {
                saveAsButton_Click(sender, e);
                return;
            }
            richTextBox1.SaveFile(filePath.Text, RichTextBoxStreamType.RichText);
            loadFile(filePath.Text);
        }

        private void saveAsButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Rich Text Files (*.rtf)|*.rtf|All Files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText); // Save as RTF
                loadFile(saveFileDialog1.FileName);
            }
        }

        private void loadFile(String filePath)
        {
            string fileExtension = Path.GetExtension(filePath).ToLower();

            // Load RTF or plain text based on file extension
            if (fileExtension == ".rtf")
            {
                richTextBox1.LoadFile(filePath, RichTextBoxStreamType.RichText); // Load RTF content
            }
            else
            {
                richTextBox1.LoadFile(filePath, RichTextBoxStreamType.PlainText); // Load plain text
            }
            this.filePath.Text = filePath;
        }
        private void titleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("Segoe UI", 24, FontStyle.Bold);
        }

        private void headerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("Segoe UI", 20, FontStyle.Bold);
        }

        private void subheaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("Segoe UI", 16);
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("Segoe UI", 12);
        }

        private void monToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("Consolas", 12, FontStyle.Bold);
        }

        private void addImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files (*.png;*.jpg;*.bmp)|*.png;*.jpg;*.bmp|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load the selected image into a Bitmap object
                    Image img = Image.FromFile(openFileDialog1.FileName);
                    Clipboard.SetImage(img); // Copy the image to the clipboard
                    richTextBox1.Paste(); // Paste the image from the clipboard into the RichTextBox
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding image: " + ex.Message);
                }
            }
        }

        private void changeTextBtn_Click(object sender, EventArgs e)
        {
            PictureBox btnSender = (PictureBox)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            changeTextSize.Show(ptLowerLeft);
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                // Save the user's current selection
                for (int i = 0; i < richTextBox1.TextLength; i++)
                {
                    richTextBox1.Select(i, 1);
                    richTextBox1.SelectionFont = new Font(fontDialog.Font.Name, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
                }
            }
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void moveRight_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void moveLeft_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void moveCenter_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createFontBox();
        }
        private void fontList_Click(object sender, EventArgs e)
        {
            try
            {

                if ((System.Windows.Forms.ComboBox)sender != null)
                {
                    fontList.DroppedDown = true;
                }
            }
            catch (Exception) { }
        }

        private void fontList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected font name
            string selectedFontName = fontList.SelectedItem.ToString();
            if (selectedFontName == null) return;

            // Determine the start index and length of the selection
            int startIndex = richTextBox1.SelectionStart;
            int length = richTextBox1.SelectionLength;

            // Apply the new font to each character in the selection
            for (int i = startIndex; i < startIndex + length; i++)
            {
                richTextBox1.Select(i, 1);
                if (richTextBox1.SelectionFont != null) // Check if the current selection has a font
                {
                    // Change font only, keep existing size and style
                    Font newFont = new(selectedFontName, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
                    richTextBox1.SelectionFont = newFont;
                }
            }
            richTextBox1.Select(startIndex, length);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Determine the start index and length of the selection
            int startIndex = richTextBox1.SelectionStart;
            int length = richTextBox1.SelectionLength;

            // Apply the new font to each character in the selection
            for (int i = startIndex; i < startIndex + length; i++)
            {
                richTextBox1.Select(i, 1);
                if (richTextBox1.SelectionFont != null) // Check if the current selection has a font
                {
                    // Change font only, keep existing size and style
                    Font newFont = new Font(richTextBox1.SelectionFont.Name.ToString(), (int)numericUpDown1.Value, richTextBox1.SelectionFont.Style);
                    richTextBox1.SelectionFont = newFont;
                }
            }
            richTextBox1.Select(startIndex, length);
        }

        private void alignLeftBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void alignCenterBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;

        }

        private void alignRightBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;

        }

        private void changeType(FontStyle Fstyle)
        {
            int startIndex = richTextBox1.SelectionStart;
            int length = richTextBox1.SelectionLength;

            // Check if any text is selected
            if (length > 0 && richTextBox1.SelectionFont != null)
            {
                // Get the current font style for the selection
                // Determine if the current selection already has the target style
                bool hasStyle = (richTextBox1.SelectionFont.Style & Fstyle) == Fstyle;

                // Calculate the new style by adding or removing the specified style
                FontStyle newStyle = hasStyle
                    ? richTextBox1.SelectionFont.Style & ~Fstyle // Remove the style
                    : richTextBox1.SelectionFont.Style | Fstyle;

                // Apply the new font with the modified style to the selection
                richTextBox1.SelectionFont = new Font(
                    richTextBox1.SelectionFont.Name,
                    richTextBox1.SelectionFont.Size,
                    newStyle
                );
            }
        }

        private void strikeThroughBtn_Click(object sender, EventArgs e)
        {
            changeType(FontStyle.Strikeout);
        }

        private void underlineBtn_Click(object sender, EventArgs e)
        {
            changeType(FontStyle.Underline);
        }

        private void italicBtn_Click(object sender, EventArgs e)
        {
            changeType(FontStyle.Italic);

        }

        private void boldBtn_Click(object sender, EventArgs e)
        {
            changeType(FontStyle.Bold);

        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                    openFileDialog.Title = "Select a file to open";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;
                        // Check file extension to determine the loading method
                        loadFile(filePath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while opening the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changeForceColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog openColorDialog = new ColorDialog())
            {
                if (openColorDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionColor = openColorDialog.Color;
                }
            }
        }

        private void changeBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog openColorDialog = new ColorDialog())
            {
                if (openColorDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionBackColor = openColorDialog.Color;
                }
            }
        }
    }
}

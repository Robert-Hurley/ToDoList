namespace ToDoList
{
    public partial class Form1 : Form
    {
        string filenm = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void updateCounts()
        {
            lblCountSometime.Text = "Number of items: " + cbxSometime.Items.Count.ToString("n0");
            lblCountToday.Text = "Number of items: " + lbxToday.Items.Count.ToString("n0");
            cbxSometime.Text = "";
            cbxSometime.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateCounts();
            cbxNuke.SelectedIndex = 0;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (string.IsNullOrWhiteSpace(cbxSometime.Text) == false))
            {
                cbxSometime.Items.Insert(0, cbxSometime.Text);
                updateCounts();
            }
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            if (cbxSometime.SelectedIndex != -1)
            {
                lbxToday.Items.Add(cbxSometime.SelectedItem);
                cbxSometime.Items.RemoveAt(cbxSometime.SelectedIndex);
                updateCounts();
            }
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            if (lbxToday.SelectedIndex != -1)
            {
                cbxSometime.Items.Add(lbxToday.SelectedItem);
                lbxToday.Items.RemoveAt(lbxToday.SelectedIndex);
                updateCounts();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbxSometime.SelectedIndex != -1)
            {
                cbxSometime.Items.RemoveAt(cbxSometime.SelectedIndex);
                updateCounts();
            }
            else if(lbxToday.SelectedIndex != -1)
            {
                lbxToday.Items.RemoveAt(lbxToday.SelectedIndex);
                updateCounts();
            }
        }

        private void cbxSometime_Click(object sender, EventArgs e)
        {
            lbxToday.SelectedIndex = -1;
        }

        private void lbxToday_Click(object sender, EventArgs e)
        {
            cbxSometime.SelectedIndex = -1;
        }

        private void cbxNuke_SelectedIndexChanged(object sender, EventArgs e)
        {
            DialogResult yorn;

            if (cbxNuke.SelectedIndex == 1)
            {
                yorn = MessageBox.Show("Do you really want to clear all items from the To Do Sometime list?", "Remove All?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (yorn == DialogResult.Yes)
                {
                    cbxSometime.Items.Clear();
                    updateCounts();
                }
            }
            else if(cbxNuke.SelectedIndex == 2)
            {
                yorn = MessageBox.Show("Do you really want to clear all items from the To Do Today list?", "Remove All?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (yorn == DialogResult.Yes)
                {
                    lbxToday.Items.Clear();
                    updateCounts();
                }
            }
            else if(cbxNuke.SelectedIndex == 3)
            {
                yorn = MessageBox.Show("Do you really want to clear all items from both lists?", "Remove All?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (yorn == DialogResult.Yes)
                {
                    cbxSometime.Items.Clear();
                    lbxToday.Items.Clear();
                    updateCounts();
                }
            }
            cbxNuke.SelectedIndex = 0;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showLogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbxLogo.Visible = showLogoToolStripMenuItem.Checked;
            //if (showLogoToolStripMenuItem.Checked)
            //    pbxLogo.Visible = true;
            //else
            //    pbxLogo.Visible = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A Stormy C Production" + Environment.NewLine + "Copyright 2023", "About");
        }

        private void changeWindowColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = this.BackColor;
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void changeTextColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = this.ForeColor;
            colorDialog1.ShowDialog();
            this.ForeColor = colorDialog1.Color;
        }

        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = lblToDoSometime.Font;
            fontDialog1.ShowDialog();
            lblToDoSometime.Font = fontDialog1.Font;
            lblToDoToday.Font = fontDialog1.Font;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult saveOrCancel;
            int currentItem;
            StreamWriter saver;

            try
            {
                saveOrCancel = saveFileDialog1.ShowDialog();
                if (saveOrCancel == DialogResult.OK)
                {
                    filenm = saveFileDialog1.FileName;
                    saver = new StreamWriter(filenm);
                    for(currentItem = 0; currentItem < cbxSometime.Items.Count; currentItem++)
                    {
                        saver.WriteLine(cbxSometime.Items[currentItem].ToString());
                    }
                    saver.WriteLine("");
                    for (currentItem = 0; currentItem < lbxToday.Items.Count; currentItem++)
                    {
                        saver.WriteLine(lbxToday.Items[currentItem].ToString());
                    }
                    saver.Close();
                }
            }
            catch
            {
                MessageBox.Show("There was an error. File was not saved.", "Save Error");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter saver;
            int currentItem;

            try
            {
                if (filenm == "")
                {
                    saveAsToolStripMenuItem_Click(sender, e);
                }
                else
                {
                    saver = new StreamWriter(filenm);
                    for (currentItem = 0; currentItem < cbxSometime.Items.Count; currentItem++)
                    {
                        saver.WriteLine(cbxSometime.Items[currentItem].ToString());
                    }
                    saver.WriteLine("");
                    for (currentItem = 0; currentItem < lbxToday.Items.Count; currentItem++)
                    {
                        saver.WriteLine(lbxToday.Items[currentItem].ToString());
                    }
                    saver.Close();
                }
            }
            catch
            {
                MessageBox.Show("There was an error. File was not saved.", "Save Error");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult yOrN, openOrCancel;
            StreamReader opener;
            string item;

            try
            {
                yOrN = MessageBox.Show("Opening a file will lose any unsaved data. Are you sure you want to open a file?", "Open file?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (yOrN == DialogResult.Yes)
                {
                    openOrCancel = openFileDialog1.ShowDialog();
                    if (openOrCancel == DialogResult.OK)
                    {
                        filenm = openFileDialog1.FileName;
                        opener = new StreamReader(filenm);
                        cbxSometime.Items.Clear();
                        lbxToday.Items.Clear();
                        item = opener.ReadLine();
                        while (item != "")
                        {
                            cbxSometime.Items.Add(item);
                            item = opener.ReadLine();
                        }
                        while (opener.Peek() != -1)
                        {
                            item = opener.ReadLine();
                            lbxToday.Items.Add(item);
                        }
                        opener.Close();
                        updateCounts();
                    }
                }
            }
            catch
            {
                MessageBox.Show("There was an error opening this file.", "Open Error");
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult yOrN;

            yOrN = MessageBox.Show("Creating a new To Do list will lose unsaved data. Be sure your data is saved before doing this operation. Do you want to continue creating a new list?", "New List?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (yOrN == DialogResult.Yes)
            {
                cbxSometime.Items.Clear();
                lbxToday.Items.Clear();
                updateCounts();
                filenm = "";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult yOrN;

            yOrN = MessageBox.Show("Unsaved changes will be lost. Do you want to continue to exit", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (yOrN == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
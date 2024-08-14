namespace ToDoList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblToDoSometime = new System.Windows.Forms.Label();
            this.lblToDoToday = new System.Windows.Forms.Label();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblCountSometime = new System.Windows.Forms.Label();
            this.lbxToday = new System.Windows.Forms.ListBox();
            this.cbxSometime = new System.Windows.Forms.ComboBox();
            this.cbxNuke = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTextColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeWindowColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.showLogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.lblCountToday = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblToDoSometime
            // 
            this.lblToDoSometime.AutoSize = true;
            this.lblToDoSometime.BackColor = System.Drawing.Color.Transparent;
            this.lblToDoSometime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToDoSometime.Location = new System.Drawing.Point(38, 45);
            this.lblToDoSometime.Name = "lblToDoSometime";
            this.lblToDoSometime.Size = new System.Drawing.Size(136, 21);
            this.lblToDoSometime.TabIndex = 0;
            this.lblToDoSometime.Text = "To Do Sometime";
            // 
            // lblToDoToday
            // 
            this.lblToDoToday.AutoSize = true;
            this.lblToDoToday.BackColor = System.Drawing.Color.Transparent;
            this.lblToDoToday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToDoToday.Location = new System.Drawing.Point(307, 45);
            this.lblToDoToday.Name = "lblToDoToday";
            this.lblToDoToday.Size = new System.Drawing.Size(104, 21);
            this.lblToDoToday.TabIndex = 1;
            this.lblToDoToday.Text = "To Do Today";
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.BackgroundImage = global::ToDoList.Properties.Resources.leftArrow;
            this.btnMoveLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoveLeft.Location = new System.Drawing.Point(206, 166);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(52, 52);
            this.btnMoveLeft.TabIndex = 2;
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.BackgroundImage = global::ToDoList.Properties.Resources.rightArrow;
            this.btnMoveRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoveRight.Location = new System.Drawing.Point(206, 108);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(52, 52);
            this.btnMoveRight.TabIndex = 3;
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::ToDoList.Properties.Resources.trash;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(206, 224);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(52, 52);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblCountSometime
            // 
            this.lblCountSometime.BackColor = System.Drawing.Color.DarkBlue;
            this.lblCountSometime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCountSometime.ForeColor = System.Drawing.Color.White;
            this.lblCountSometime.Location = new System.Drawing.Point(18, 301);
            this.lblCountSometime.Name = "lblCountSometime";
            this.lblCountSometime.Size = new System.Drawing.Size(176, 23);
            this.lblCountSometime.TabIndex = 5;
            this.lblCountSometime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxToday
            // 
            this.lbxToday.FormattingEnabled = true;
            this.lbxToday.ItemHeight = 15;
            this.lbxToday.Location = new System.Drawing.Point(270, 73);
            this.lbxToday.Name = "lbxToday";
            this.lbxToday.Size = new System.Drawing.Size(176, 214);
            this.lbxToday.TabIndex = 7;
            this.lbxToday.Click += new System.EventHandler(this.lbxToday_Click);
            // 
            // cbxSometime
            // 
            this.cbxSometime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbxSometime.FormattingEnabled = true;
            this.cbxSometime.Location = new System.Drawing.Point(18, 73);
            this.cbxSometime.Name = "cbxSometime";
            this.cbxSometime.Size = new System.Drawing.Size(176, 225);
            this.cbxSometime.TabIndex = 8;
            this.cbxSometime.Click += new System.EventHandler(this.cbxSometime_Click);
            // 
            // cbxNuke
            // 
            this.cbxNuke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNuke.FormattingEnabled = true;
            this.cbxNuke.Items.AddRange(new object[] {
            "Pick an option",
            "Clear the Sometime List",
            "Clear the Today List",
            "Clear Both Sometime and Today Lists"});
            this.cbxNuke.Location = new System.Drawing.Point(18, 338);
            this.cbxNuke.Name = "cbxNuke";
            this.cbxNuke.Size = new System.Drawing.Size(428, 23);
            this.cbxNuke.TabIndex = 9;
            this.cbxNuke.SelectedIndexChanged += new System.EventHandler(this.cbxNuke_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(467, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator1,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeColorToolStripMenuItem,
            this.changeFontToolStripMenuItem,
            this.toolStripSeparator3,
            this.showLogoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // changeColorToolStripMenuItem
            // 
            this.changeColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeTextColorToolStripMenuItem,
            this.changeWindowColorToolStripMenuItem});
            this.changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
            this.changeColorToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.changeColorToolStripMenuItem.Text = "Change Color";
            // 
            // changeTextColorToolStripMenuItem
            // 
            this.changeTextColorToolStripMenuItem.Name = "changeTextColorToolStripMenuItem";
            this.changeTextColorToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.changeTextColorToolStripMenuItem.Text = "Change Text Color...";
            this.changeTextColorToolStripMenuItem.Click += new System.EventHandler(this.changeTextColorToolStripMenuItem_Click);
            // 
            // changeWindowColorToolStripMenuItem
            // 
            this.changeWindowColorToolStripMenuItem.Name = "changeWindowColorToolStripMenuItem";
            this.changeWindowColorToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.changeWindowColorToolStripMenuItem.Text = "Change Window Color...";
            this.changeWindowColorToolStripMenuItem.Click += new System.EventHandler(this.changeWindowColorToolStripMenuItem_Click);
            // 
            // changeFontToolStripMenuItem
            // 
            this.changeFontToolStripMenuItem.Name = "changeFontToolStripMenuItem";
            this.changeFontToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.changeFontToolStripMenuItem.Text = "Change Font";
            this.changeFontToolStripMenuItem.Click += new System.EventHandler(this.changeFontToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(144, 6);
            // 
            // showLogoToolStripMenuItem
            // 
            this.showLogoToolStripMenuItem.CheckOnClick = true;
            this.showLogoToolStripMenuItem.Name = "showLogoToolStripMenuItem";
            this.showLogoToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.showLogoToolStripMenuItem.Text = "Show Logo";
            this.showLogoToolStripMenuItem.Click += new System.EventHandler(this.showLogoToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::ToDoList.Properties.Resources.seawitchhorn;
            this.pbxLogo.Location = new System.Drawing.Point(12, 27);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(444, 350);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 11;
            this.pbxLogo.TabStop = false;
            this.pbxLogo.Visible = false;
            // 
            // lblCountToday
            // 
            this.lblCountToday.BackColor = System.Drawing.Color.DarkBlue;
            this.lblCountToday.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCountToday.ForeColor = System.Drawing.Color.White;
            this.lblCountToday.Location = new System.Drawing.Point(270, 301);
            this.lblCountToday.Name = "lblCountToday";
            this.lblCountToday.Size = new System.Drawing.Size(176, 23);
            this.lblCountToday.TabIndex = 12;
            this.lblCountToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "todo";
            this.openFileDialog1.Filter = "To Do List (*.todo)|*.todo|Text File (*.txt)|*.txt|All Files (*.*)|*.*";
            this.openFileDialog1.Title = "Open To Do List";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "todo";
            this.saveFileDialog1.Filter = "To Do List (*.todo)|*.todo|Text File (*.txt)|*.txt|All Files (*.*)|*.*";
            this.saveFileDialog1.Title = "Save To Do List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 387);
            this.Controls.Add(this.lblCountToday);
            this.Controls.Add(this.cbxNuke);
            this.Controls.Add(this.cbxSometime);
            this.Controls.Add(this.lbxToday);
            this.Controls.Add(this.lblCountSometime);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.lblToDoToday);
            this.Controls.Add(this.lblToDoSometime);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pbxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To Do";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblToDoSometime;
        private Label lblToDoToday;
        private Button btnMoveLeft;
        private Button btnMoveRight;
        private Button btnDelete;
        private Label lblCountSometime;
        private ListBox lbxToday;
        private ComboBox cbxSometime;
        private ComboBox cbxNuke;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem changeColorToolStripMenuItem;
        private ToolStripMenuItem changeTextColorToolStripMenuItem;
        private ToolStripMenuItem changeWindowColorToolStripMenuItem;
        private ToolStripMenuItem changeFontToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem showLogoToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private PictureBox pbxLogo;
        private Label lblCountToday;
        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
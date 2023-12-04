namespace KuruTweakGUI
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BtnConfigLoad = new MetroFramework.Controls.MetroButton();
            this.BtnConfigNew = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.BtnGithub = new MetroFramework.Controls.MetroButton();
            this.BtnConfigSave = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.LabelCacheExp = new MetroFramework.Controls.MetroTextBox();
            this.LabelCacheDirectory = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.LabelCacheSize = new MetroFramework.Controls.MetroTextBox();
            this.BtnCacheChange = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ToggleDRP = new MetroFramework.Controls.MetroToggle();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroStyleExtender1
            // 
            this.metroStyleExtender1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(113, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Configuration File";
            // 
            // BtnConfigLoad
            // 
            this.BtnConfigLoad.Location = new System.Drawing.Point(12, 37);
            this.BtnConfigLoad.Name = "BtnConfigLoad";
            this.BtnConfigLoad.Size = new System.Drawing.Size(133, 31);
            this.BtnConfigLoad.TabIndex = 3;
            this.BtnConfigLoad.Text = "Load";
            this.BtnConfigLoad.UseSelectable = true;
            this.BtnConfigLoad.Click += new System.EventHandler(this.BtnConfigLoad_Click);
            // 
            // BtnConfigNew
            // 
            this.BtnConfigNew.Enabled = false;
            this.BtnConfigNew.Location = new System.Drawing.Point(12, 74);
            this.BtnConfigNew.Name = "BtnConfigNew";
            this.BtnConfigNew.Size = new System.Drawing.Size(133, 31);
            this.BtnConfigNew.TabIndex = 4;
            this.BtnConfigNew.Text = "New";
            this.BtnConfigNew.UseSelectable = true;
            this.BtnConfigNew.Click += new System.EventHandler(this.BtnConfigNew_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.BtnGithub);
            this.metroPanel1.Controls.Add(this.BtnConfigSave);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.BtnConfigNew);
            this.metroPanel1.Controls.Add(this.BtnConfigLoad);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(597, 188);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // BtnGithub
            // 
            this.BtnGithub.Location = new System.Drawing.Point(12, 111);
            this.BtnGithub.Name = "BtnGithub";
            this.BtnGithub.Size = new System.Drawing.Size(133, 31);
            this.BtnGithub.TabIndex = 9;
            this.BtnGithub.Text = "Github";
            this.BtnGithub.UseSelectable = true;
            this.BtnGithub.Click += new System.EventHandler(this.BtnGithub_Click);
            // 
            // BtnConfigSave
            // 
            this.BtnConfigSave.Enabled = false;
            this.BtnConfigSave.Location = new System.Drawing.Point(12, 148);
            this.BtnConfigSave.Name = "BtnConfigSave";
            this.BtnConfigSave.Size = new System.Drawing.Size(133, 31);
            this.BtnConfigSave.TabIndex = 7;
            this.BtnConfigSave.Text = "Save";
            this.BtnConfigSave.UseSelectable = true;
            this.BtnConfigSave.Click += new System.EventHandler(this.BtnConfigSave_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.LabelCacheExp);
            this.metroPanel2.Controls.Add(this.LabelCacheDirectory);
            this.metroPanel2.Controls.Add(this.metroLabel5);
            this.metroPanel2.Controls.Add(this.LabelCacheSize);
            this.metroPanel2.Controls.Add(this.BtnCacheChange);
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.ToggleDRP);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(151, 15);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(440, 164);
            this.metroPanel2.TabIndex = 5;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // LabelCacheExp
            // 
            this.LabelCacheExp.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            // 
            // 
            // 
            this.LabelCacheExp.CustomButton.Image = null;
            this.LabelCacheExp.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.LabelCacheExp.CustomButton.Name = "";
            this.LabelCacheExp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.LabelCacheExp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LabelCacheExp.CustomButton.TabIndex = 1;
            this.LabelCacheExp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LabelCacheExp.CustomButton.UseSelectable = true;
            this.LabelCacheExp.CustomButton.Visible = false;
            this.LabelCacheExp.Lines = new string[0];
            this.LabelCacheExp.Location = new System.Drawing.Point(155, 96);
            this.LabelCacheExp.MaxLength = 32767;
            this.LabelCacheExp.Name = "LabelCacheExp";
            this.LabelCacheExp.PasswordChar = '\0';
            this.LabelCacheExp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LabelCacheExp.SelectedText = "";
            this.LabelCacheExp.SelectionLength = 0;
            this.LabelCacheExp.SelectionStart = 0;
            this.LabelCacheExp.ShortcutsEnabled = true;
            this.LabelCacheExp.Size = new System.Drawing.Size(96, 23);
            this.LabelCacheExp.TabIndex = 7;
            this.LabelCacheExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.LabelCacheExp, "By default, the cache will limit itself to 20 gigabytes in size. It may drift sli" +
        "ghtly above or below this value depending on the size of the assets present in t" +
        "he cache.");
            this.LabelCacheExp.UseSelectable = true;
            this.LabelCacheExp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LabelCacheExp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.LabelCacheExp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LabelCacheExp_KeyPress);
            this.LabelCacheExp.Validating += new System.ComponentModel.CancelEventHandler(this.LabelCacheExp_Validating);
            // 
            // LabelCacheDirectory
            // 
            this.LabelCacheDirectory.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            // 
            // 
            // 
            this.LabelCacheDirectory.CustomButton.Image = null;
            this.LabelCacheDirectory.CustomButton.Location = new System.Drawing.Point(51, 1);
            this.LabelCacheDirectory.CustomButton.Name = "";
            this.LabelCacheDirectory.CustomButton.Size = new System.Drawing.Size(81, 81);
            this.LabelCacheDirectory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LabelCacheDirectory.CustomButton.TabIndex = 1;
            this.LabelCacheDirectory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LabelCacheDirectory.CustomButton.UseSelectable = true;
            this.LabelCacheDirectory.CustomButton.Visible = false;
            this.LabelCacheDirectory.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.LabelCacheDirectory.Lines = new string[0];
            this.LabelCacheDirectory.Location = new System.Drawing.Point(16, 36);
            this.LabelCacheDirectory.MaxLength = 32767;
            this.LabelCacheDirectory.Multiline = true;
            this.LabelCacheDirectory.Name = "LabelCacheDirectory";
            this.LabelCacheDirectory.PasswordChar = '\0';
            this.LabelCacheDirectory.ReadOnly = true;
            this.LabelCacheDirectory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LabelCacheDirectory.SelectedText = "";
            this.LabelCacheDirectory.SelectionLength = 0;
            this.LabelCacheDirectory.SelectionStart = 0;
            this.LabelCacheDirectory.ShortcutsEnabled = true;
            this.LabelCacheDirectory.Size = new System.Drawing.Size(133, 83);
            this.LabelCacheDirectory.TabIndex = 8;
            this.toolTip1.SetToolTip(this.LabelCacheDirectory, resources.GetString("LabelCacheDirectory.ToolTip"));
            this.LabelCacheDirectory.UseSelectable = true;
            this.LabelCacheDirectory.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LabelCacheDirectory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(257, 100);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(146, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Cache Expiration (Days)";
            this.toolTip1.SetToolTip(this.metroLabel5, "By default, the cache will limit itself to 20 gigabytes in size. It may drift sli" +
        "ghtly above or below this value depending on the size of the assets present in t" +
        "he cache.");
            // 
            // LabelCacheSize
            // 
            this.LabelCacheSize.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            // 
            // 
            // 
            this.LabelCacheSize.CustomButton.Image = null;
            this.LabelCacheSize.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.LabelCacheSize.CustomButton.Name = "";
            this.LabelCacheSize.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.LabelCacheSize.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LabelCacheSize.CustomButton.TabIndex = 1;
            this.LabelCacheSize.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LabelCacheSize.CustomButton.UseSelectable = true;
            this.LabelCacheSize.CustomButton.Visible = false;
            this.LabelCacheSize.Lines = new string[0];
            this.LabelCacheSize.Location = new System.Drawing.Point(155, 66);
            this.LabelCacheSize.MaxLength = 32767;
            this.LabelCacheSize.Name = "LabelCacheSize";
            this.LabelCacheSize.PasswordChar = '\0';
            this.LabelCacheSize.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LabelCacheSize.SelectedText = "";
            this.LabelCacheSize.SelectionLength = 0;
            this.LabelCacheSize.SelectionStart = 0;
            this.LabelCacheSize.ShortcutsEnabled = true;
            this.LabelCacheSize.Size = new System.Drawing.Size(96, 23);
            this.LabelCacheSize.TabIndex = 5;
            this.LabelCacheSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.LabelCacheSize, "By default, the cache will limit itself to 20 gigabytes in size. It may drift sli" +
        "ghtly above or below this value depending on the size of the assets present in t" +
        "he cache.");
            this.LabelCacheSize.UseSelectable = true;
            this.LabelCacheSize.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LabelCacheSize.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.LabelCacheSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LabelCacheSize_KeyPress);
            this.LabelCacheSize.Validating += new System.ComponentModel.CancelEventHandler(this.LabelCacheSize_Validating);
            // 
            // BtnCacheChange
            // 
            this.BtnCacheChange.Location = new System.Drawing.Point(16, 125);
            this.BtnCacheChange.Name = "BtnCacheChange";
            this.BtnCacheChange.Size = new System.Drawing.Size(133, 31);
            this.BtnCacheChange.TabIndex = 6;
            this.BtnCacheChange.Text = "Change";
            this.toolTip1.SetToolTip(this.BtnCacheChange, resources.GetString("BtnCacheChange.ToolTip"));
            this.BtnCacheChange.UseSelectable = true;
            this.BtnCacheChange.Click += new System.EventHandler(this.BtnCacheChange_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(257, 70);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(101, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Cache Size (GB)";
            this.toolTip1.SetToolTip(this.metroLabel4, "By default, the cache will limit itself to 20 gigabytes in size. It may drift sli" +
        "ghtly above or below this value depending on the size of the assets present in t" +
        "he cache.");
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(31, 12);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(103, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Cache Directory";
            this.toolTip1.SetToolTip(this.metroLabel3, resources.GetString("metroLabel3.ToolTip"));
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(155, 12);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(179, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Discord/Steam Rich Presence";
            // 
            // ToggleDRP
            // 
            this.ToggleDRP.AutoSize = true;
            this.ToggleDRP.Location = new System.Drawing.Point(340, 14);
            this.ToggleDRP.Name = "ToggleDRP";
            this.ToggleDRP.Size = new System.Drawing.Size(80, 17);
            this.ToggleDRP.TabIndex = 2;
            this.ToggleDRP.Text = "Off";
            this.ToggleDRP.UseSelectable = true;
            this.ToggleDRP.CheckedChanged += new System.EventHandler(this.ToggleDRP_CheckedChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 268);
            this.Controls.Add(this.metroPanel1);
            this.Name = "GUI";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Form1";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Shown += new System.EventHandler(this.GUI_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroButton BtnConfigLoad;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton BtnConfigNew;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroToggle ToggleDRP;
        private MetroFramework.Controls.MetroButton BtnCacheChange;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton BtnConfigSave;
        private MetroFramework.Controls.MetroTextBox LabelCacheDirectory;
        private MetroFramework.Controls.MetroButton BtnGithub;
        private MetroFramework.Controls.MetroTextBox LabelCacheSize;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ToolTip toolTip1;
        private MetroFramework.Controls.MetroTextBox LabelCacheExp;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}


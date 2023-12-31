﻿using KuruTweak;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace KuruTweakGUI
{
    public partial class GUI : MetroForm
    {
        private readonly VRChatManager manager;

        public GUI()
        {
            InitializeComponent();

            Text = $"{Application.ProductName} - v{Program.Version}";

            manager = new VRChatManager();
        }

        private void RefreshUI()
        {
            metroPanel2.Enabled = true;
            BtnConfigSave.Enabled = true;
            LabelCacheDirectory.Text = manager.Configuration.CacheDirectory;
            ToggleDRP.Checked = !manager.Configuration.DisableRichPresence;
            LabelCacheSize.Text = manager.Configuration.CacheSize.ToString();
            LabelCacheExp.Text = manager.Configuration.CacheExpiryDelay.ToString();
        }

        private void GUI_Shown(object sender, EventArgs e)
        {
            if (!manager.ConfigFileExists())
            {
                DialogResult result = MetroMessageBox.Show(this, "Configuration file not found. Do you want to create a new config.json with default values?", "Configuration Missing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    manager.SaveConfigToFile();
                    RefreshUI();
                    return;
                }
                else
                {
                    BtnConfigNew.Enabled = true;
                    BtnConfigSave.Enabled = false;
                    BtnCacheChange.Enabled = false;
                    metroPanel2.Enabled = false;
                    return;
                }
            }

            manager.LoadConfigFromFile(manager.GetConfigPath());
            RefreshUI();
        }

        private void BtnConfigLoad_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = VRChatManager.VRChatPath;
                    openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        manager.LoadConfigFromFile(openFileDialog.FileName);
                        RefreshUI();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening file dialog: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnConfigNew_Click(object sender, EventArgs e)
        {
            BtnConfigNew.Enabled = false;
            manager.SaveConfigToFile();
            RefreshUI();
        }

        private void ToggleDRP_CheckedChanged(object sender, EventArgs e)
        {
            manager.Configuration.DisableRichPresence = !ToggleDRP.Checked;
            manager.SaveConfigToFile();
        }

        private void BtnConfigSave_Click(object sender, EventArgs e)
        {
            manager.SaveConfigToFile();
        }

        private void BtnCacheChange_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    folderBrowserDialog.SelectedPath = manager.Configuration.CacheDirectory;
                    folderBrowserDialog.Description = "Select the new cache directory.";

                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        manager.Configuration.CacheDirectory = folderBrowserDialog.SelectedPath;
                        manager.SaveConfigToFile();
                        RefreshUI();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error changing cache directory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGithub_Click(object sender, EventArgs e)
        {
            var result = MetroMessageBox.Show(this, "Do you want to open the GitHub page in your web browser?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Process.Start("https://github.com/CinderellaKuru/KuruTweak");
            }
        }

        private void LabelCacheSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LabelCacheExp_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LabelCacheSize_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            manager.Configuration.CacheSize = int.Parse(LabelCacheSize.Text);
        }

        private void LabelCacheExp_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            manager.Configuration.CacheSize = int.Parse(LabelCacheSize.Text);
        }
    }
}

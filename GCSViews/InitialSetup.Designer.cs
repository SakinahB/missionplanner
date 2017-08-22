﻿namespace MissionPlanner.GCSViews
{
    partial class InitialSetup
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialSetup));
            this.backstageView = new MissionPlanner.Controls.BackstageView.BackstageView();
            this.SuspendLayout();
            // 
            // backstageView
            // 
            resources.ApplyResources(this.backstageView, "backstageView");
            this.backstageView.ForeColor = System.Drawing.Color.White;
            this.backstageView.HighlightColor1 = System.Drawing.SystemColors.Control;
            this.backstageView.HighlightColor2 = System.Drawing.SystemColors.Menu;
            this.backstageView.Name = "backstageView";
            this.backstageView.UnSelectedTextColor = System.Drawing.Color.White;
            this.backstageView.WidthMenu = 172;
            // 
            // InitialSetup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.backstageView);
            resources.ApplyResources(this, "$this");
            this.Name = "InitialSetup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HardwareConfig_FormClosing);
            this.Load += new System.EventHandler(this.HardwareConfig_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal Controls.BackstageView.BackstageView backstageView;

    }
}

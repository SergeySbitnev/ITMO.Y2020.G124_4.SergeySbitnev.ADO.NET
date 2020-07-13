
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace DBConnection
{
    partial class DBConnection
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.runDB = new System.Windows.Forms.ToolStripMenuItem();
            this.connectDB = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectDB = new System.Windows.Forms.ToolStripMenuItem();
            this.asyncConnectionDB = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runDB});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(800, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // runDB
            // 
            this.runDB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectDB,
            this.disconnectDB,
            this.asyncConnectionDB});
            this.runDB.Name = "runDB";
            this.runDB.Size = new System.Drawing.Size(58, 20);
            this.runDB.Text = "Run DB";
            // 
            // connectDB
            // 
            this.connectDB.Name = "connectDB";
            this.connectDB.Size = new System.Drawing.Size(187, 22);
            this.connectDB.Text = "Connect DB";
            this.connectDB.Click += new System.EventHandler(this.openDB_Click);
            // 
            // disconnectDB
            // 
            this.disconnectDB.Enabled = false;
            this.disconnectDB.Name = "disconnectDB";
            this.disconnectDB.Size = new System.Drawing.Size(187, 22);
            this.disconnectDB.Text = "Disconnect DB";
            this.disconnectDB.Click += new System.EventHandler(this.closeDB_Click);
            // 
            // asyncConnectionDB
            // 
            this.asyncConnectionDB.Name = "asyncConnectionDB";
            this.asyncConnectionDB.Size = new System.Drawing.Size(187, 22);
            this.asyncConnectionDB.Text = "Async connection DB";
            this.asyncConnectionDB.Click += new System.EventHandler(this.asyncConnectionDB_Click);
            // 
            // DBConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "DBConnection";
            this.Text = "DBConnection";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem runDB;
        private System.Windows.Forms.ToolStripMenuItem connectDB;
        private System.Windows.Forms.ToolStripMenuItem disconnectDB;
        private System.Windows.Forms.ToolStripMenuItem asyncConnectionDB;
        private System.Windows.Forms.BindingSource bindingSource1;
        private BindingSource bindingSource2;
    }
}


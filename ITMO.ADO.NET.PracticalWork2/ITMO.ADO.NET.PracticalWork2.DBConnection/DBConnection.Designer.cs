
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
            this.ConnectionList = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.HowManyProductsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HowManyProductsButton2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductListButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Packing = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TransactionButton = new System.Windows.Forms.Button();
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
            this.MainMenu.Size = new System.Drawing.Size(656, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // runDB
            // 
            this.runDB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectDB,
            this.disconnectDB,
            this.asyncConnectionDB,
            this.ConnectionList});
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
            // ConnectionList
            // 
            this.ConnectionList.Name = "ConnectionList";
            this.ConnectionList.Size = new System.Drawing.Size(187, 22);
            this.ConnectionList.Text = "Connection list";
            this.ConnectionList.Click += new System.EventHandler(this.ConnectionList_Click);
            // 
            // HowManyProductsButton
            // 
            this.HowManyProductsButton.Location = new System.Drawing.Point(12, 27);
            this.HowManyProductsButton.Name = "HowManyProductsButton";
            this.HowManyProductsButton.Size = new System.Drawing.Size(129, 23);
            this.HowManyProductsButton.TabIndex = 1;
            this.HowManyProductsButton.Text = "How many products";
            this.HowManyProductsButton.UseVisualStyleBackColor = true;
            this.HowManyProductsButton.Click += new System.EventHandler(this.HowManyProductsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // HowManyProductsButton2
            // 
            this.HowManyProductsButton2.Location = new System.Drawing.Point(12, 56);
            this.HowManyProductsButton2.Name = "HowManyProductsButton2";
            this.HowManyProductsButton2.Size = new System.Drawing.Size(129, 23);
            this.HowManyProductsButton2.TabIndex = 3;
            this.HowManyProductsButton2.Text = "How many products 2";
            this.HowManyProductsButton2.UseVisualStyleBackColor = true;
            this.HowManyProductsButton2.Click += new System.EventHandler(this.HowManyProductsButton2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // ProductListButton
            // 
            this.ProductListButton.Location = new System.Drawing.Point(12, 85);
            this.ProductListButton.Name = "ProductListButton";
            this.ProductListButton.Size = new System.Drawing.Size(103, 23);
            this.ProductListButton.TabIndex = 5;
            this.ProductListButton.Text = "Product List";
            this.ProductListButton.UseVisualStyleBackColor = true;
            this.ProductListButton.Click += new System.EventHandler(this.ProductListButton_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductName,
            this.Price,
            this.Packing});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 114);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(332, 172);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Product Name";
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // Packing
            // 
            this.Packing.Text = "Packing";
            // 
            // TransactionButton
            // 
            this.TransactionButton.Location = new System.Drawing.Point(436, 27);
            this.TransactionButton.Name = "TransactionButton";
            this.TransactionButton.Size = new System.Drawing.Size(75, 23);
            this.TransactionButton.TabIndex = 7;
            this.TransactionButton.Text = "Transaction";
            this.TransactionButton.UseVisualStyleBackColor = true;
            this.TransactionButton.Click += new System.EventHandler(this.TransactionButton_Click);
            // 
            // DBConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 454);
            this.Controls.Add(this.TransactionButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ProductListButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HowManyProductsButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HowManyProductsButton);
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
        private ToolStripMenuItem ConnectionList;
        private Button HowManyProductsButton;
        private Label label1;
        private Button HowManyProductsButton2;
        private Label label2;
        private Button ProductListButton;
        private ListView listView1;
        private ColumnHeader ProductName;
        private ColumnHeader Price;
        private ColumnHeader Packing;
        private Button TransactionButton;
    }
}


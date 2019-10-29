using System;
using System.Windows.Forms;

namespace PlanBottler
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.cbxDrinkType = new System.Windows.Forms.ComboBox();
            this.cbxDrink = new System.Windows.Forms.ComboBox();
            this.cbxCount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxDrinkSubType = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.extrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.euroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dollarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxDrinkType
            // 
            this.cbxDrinkType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxDrinkType.FormattingEnabled = true;
            this.cbxDrinkType.Location = new System.Drawing.Point(68, 126);
            this.cbxDrinkType.Name = "cbxDrinkType";
            this.cbxDrinkType.Size = new System.Drawing.Size(278, 33);
            this.cbxDrinkType.TabIndex = 0;
            this.cbxDrinkType.SelectedIndexChanged += new System.EventHandler(this.cbxDrinkType_SelectedIndexChanged);
            // 
            // cbxDrink
            // 
            this.cbxDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxDrink.FormattingEnabled = true;
            this.cbxDrink.Location = new System.Drawing.Point(69, 208);
            this.cbxDrink.Name = "cbxDrink";
            this.cbxDrink.Size = new System.Drawing.Size(278, 33);
            this.cbxDrink.TabIndex = 1;
            this.cbxDrink.SelectedIndexChanged += new System.EventHandler(this.cbxDrink_SelectedIndexChanged);
            // 
            // cbxCount
            // 
            this.cbxCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCount.FormattingEnabled = true;
            this.cbxCount.Location = new System.Drawing.Point(408, 208);
            this.cbxCount.Name = "cbxCount";
            this.cbxCount.Size = new System.Drawing.Size(278, 33);
            this.cbxCount.TabIndex = 2;
            this.cbxCount.SelectedIndexChanged += new System.EventHandler(this.cbxCount_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Drink Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Drink";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Drink Subtype";
            // 
            // cbxDrinkSubType
            // 
            this.cbxDrinkSubType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxDrinkSubType.FormattingEnabled = true;
            this.cbxDrinkSubType.Location = new System.Drawing.Point(408, 126);
            this.cbxDrinkSubType.Name = "cbxDrinkSubType";
            this.cbxDrinkSubType.Size = new System.Drawing.Size(278, 33);
            this.cbxDrinkSubType.TabIndex = 6;
            this.cbxDrinkSubType.SelectedIndexChanged += new System.EventHandler(this.cbxDrinkSubType_SelectedIndexChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Location = new System.Drawing.Point(733, 208);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(220, 24);
            this.txtPrice.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(733, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(992, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Location = new System.Drawing.Point(992, 208);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(220, 24);
            this.txtTotal.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(615, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "label7";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extrasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1282, 42);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // extrasToolStripMenuItem
            // 
            this.extrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.euroToolStripMenuItem,
            this.dollarToolStripMenuItem});
            this.extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
            this.extrasToolStripMenuItem.Size = new System.Drawing.Size(130, 38);
            this.extrasToolStripMenuItem.Text = "Currency";
            // 
            // euroToolStripMenuItem
            // 
            this.euroToolStripMenuItem.Checked = true;
            this.euroToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.euroToolStripMenuItem.Name = "euroToolStripMenuItem";
            this.euroToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.euroToolStripMenuItem.Text = "Euro";
            this.euroToolStripMenuItem.Click += new System.EventHandler(this.euroToolStripMenuItem_Click);
            // 
            // dollarToolStripMenuItem
            // 
            this.dollarToolStripMenuItem.Name = "dollarToolStripMenuItem";
            this.dollarToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.dollarToolStripMenuItem.Text = "Dollar";
            this.dollarToolStripMenuItem.Click += new System.EventHandler(this.dollarToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 697);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxDrinkSubType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCount);
            this.Controls.Add(this.cbxDrink);
            this.Controls.Add(this.cbxDrinkType);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "PlanBottler";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxDrinkType;
        private System.Windows.Forms.ComboBox cbxDrink;
        private System.Windows.Forms.ComboBox cbxCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxDrinkSubType;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal;
        private Label label7;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem extrasToolStripMenuItem;
        private ToolStripMenuItem euroToolStripMenuItem;
        private ToolStripMenuItem dollarToolStripMenuItem;
    }
}


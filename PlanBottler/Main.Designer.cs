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
            this.SuspendLayout();
            // 
            // cbxDrinkType
            // 
            this.cbxDrinkType.FormattingEnabled = true;
            this.cbxDrinkType.Location = new System.Drawing.Point(68, 79);
            this.cbxDrinkType.Name = "cbxDrinkType";
            this.cbxDrinkType.Size = new System.Drawing.Size(278, 33);
            this.cbxDrinkType.TabIndex = 0;
            this.cbxDrinkType.SelectedIndexChanged += new System.EventHandler(this.cbxDrinkType_SelectedIndexChanged);
            // 
            // cbxDrink
            // 
            this.cbxDrink.FormattingEnabled = true;
            this.cbxDrink.Location = new System.Drawing.Point(69, 161);
            this.cbxDrink.Name = "cbxDrink";
            this.cbxDrink.Size = new System.Drawing.Size(278, 33);
            this.cbxDrink.TabIndex = 1;
            // 
            // cbxCount
            // 
            this.cbxCount.FormattingEnabled = true;
            this.cbxCount.Location = new System.Drawing.Point(408, 161);
            this.cbxCount.Name = "cbxCount";
            this.cbxCount.Size = new System.Drawing.Size(278, 33);
            this.cbxCount.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Drink Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Drink";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Drink Subtype";
            // 
            // cbxDrinkSubType
            // 
            this.cbxDrinkSubType.FormattingEnabled = true;
            this.cbxDrinkSubType.Location = new System.Drawing.Point(408, 79);
            this.cbxDrinkSubType.Name = "cbxDrinkSubType";
            this.cbxDrinkSubType.Size = new System.Drawing.Size(278, 33);
            this.cbxDrinkSubType.TabIndex = 6;
            this.cbxDrinkSubType.SelectedIndexChanged += new System.EventHandler(this.cbxDrinkSubType_SelectedIndexChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(733, 161);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(220, 31);
            this.txtPrice.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(733, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(992, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(992, 161);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(220, 31);
            this.txtTotal.TabIndex = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 697);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "PlanBottler";
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
    }
}


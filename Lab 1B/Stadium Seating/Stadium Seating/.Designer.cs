using System.Drawing;
using System.Windows.Forms;

namespace Stadium_Seating
{
    partial class StadiumRevenueForm
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
            this.TicketsSold_Panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.RevenueGenerated_Panel = new System.Windows.Forms.Panel();
            this.TicketsSold_Label = new System.Windows.Forms.Label();
            this.RevenueGenerated_Label = new System.Windows.Forms.Label();
            this.TicketsSold_ClassA_Label = new System.Windows.Forms.Label();
            this.TicketsSold_ClassA_Textbox = new System.Windows.Forms.TextBox();
            this.TicketsSold_ClassB_Textbox = new System.Windows.Forms.TextBox();
            this.TicketsSold_ClassB_Label = new System.Windows.Forms.Label();
            this.TicketsSold_ClassC_Label = new System.Windows.Forms.Label();
            this.TicketsSold_ClassC_Textbox = new System.Windows.Forms.TextBox();
            this.RevenueGenerated_ClassA_Label = new System.Windows.Forms.Label();
            this.RevenueGenerated_ClassA_Textbox = new System.Windows.Forms.TextBox();
            this.RevenueGenerated_ClassB_Label = new System.Windows.Forms.Label();
            this.RevenueGenerated_ClassB_Textbox = new System.Windows.Forms.TextBox();
            this.RevenueGenerated_ClassC_Label = new System.Windows.Forms.Label();
            this.RevenueGenerated_ClassC_Textbox = new System.Windows.Forms.TextBox();
            this.RevenueGenerated_Total_Label = new System.Windows.Forms.Label();
            this.RevenueGenerated_Total_Textbox = new System.Windows.Forms.TextBox();
            this.CalculateRevenue_Button = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.TicketsSold_Panel.SuspendLayout();
            this.RevenueGenerated_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TicketsSold_Panel
            // 
            this.TicketsSold_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TicketsSold_Panel.Controls.Add(this.TicketsSold_ClassC_Textbox);
            this.TicketsSold_Panel.Controls.Add(this.TicketsSold_ClassC_Label);
            this.TicketsSold_Panel.Controls.Add(this.TicketsSold_ClassB_Label);
            this.TicketsSold_Panel.Controls.Add(this.TicketsSold_ClassB_Textbox);
            this.TicketsSold_Panel.Controls.Add(this.TicketsSold_ClassA_Textbox);
            this.TicketsSold_Panel.Controls.Add(this.TicketsSold_ClassA_Label);
            this.TicketsSold_Panel.Controls.Add(this.label1);
            this.TicketsSold_Panel.Location = new System.Drawing.Point(12, 49);
            this.TicketsSold_Panel.Name = "TicketsSold_Panel";
            this.TicketsSold_Panel.Size = new System.Drawing.Size(282, 234);
            this.TicketsSold_Panel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number of tickets sold\r\nfor each class of seats\r\n";
            // 
            // RevenueGenerated_Panel
            // 
            this.RevenueGenerated_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RevenueGenerated_Panel.Controls.Add(this.RevenueGenerated_Total_Textbox);
            this.RevenueGenerated_Panel.Controls.Add(this.RevenueGenerated_Total_Label);
            this.RevenueGenerated_Panel.Controls.Add(this.RevenueGenerated_ClassC_Textbox);
            this.RevenueGenerated_Panel.Controls.Add(this.RevenueGenerated_ClassC_Label);
            this.RevenueGenerated_Panel.Controls.Add(this.RevenueGenerated_ClassB_Textbox);
            this.RevenueGenerated_Panel.Controls.Add(this.RevenueGenerated_ClassB_Label);
            this.RevenueGenerated_Panel.Controls.Add(this.RevenueGenerated_ClassA_Textbox);
            this.RevenueGenerated_Panel.Controls.Add(this.RevenueGenerated_ClassA_Label);
            this.RevenueGenerated_Panel.Location = new System.Drawing.Point(454, 49);
            this.RevenueGenerated_Panel.Name = "RevenueGenerated_Panel";
            this.RevenueGenerated_Panel.Size = new System.Drawing.Size(282, 234);
            this.RevenueGenerated_Panel.TabIndex = 2;
            // 
            // TicketsSold_Label
            // 
            this.TicketsSold_Label.AutoSize = true;
            this.TicketsSold_Label.Location = new System.Drawing.Point(13, 30);
            this.TicketsSold_Label.Name = "TicketsSold_Label";
            this.TicketsSold_Label.Size = new System.Drawing.Size(66, 13);
            this.TicketsSold_Label.TabIndex = 3;
            this.TicketsSold_Label.Text = "Tickets Sold";
            // 
            // RevenueGenerated_Label
            // 
            this.RevenueGenerated_Label.AutoSize = true;
            this.RevenueGenerated_Label.Location = new System.Drawing.Point(451, 30);
            this.RevenueGenerated_Label.Name = "RevenueGenerated_Label";
            this.RevenueGenerated_Label.Size = new System.Drawing.Size(104, 13);
            this.RevenueGenerated_Label.TabIndex = 4;
            this.RevenueGenerated_Label.Text = "Revenue Generated";
            // 
            // TicketsSold_ClassA_Label
            // 
            this.TicketsSold_ClassA_Label.AutoSize = true;
            this.TicketsSold_ClassA_Label.Location = new System.Drawing.Point(49, 66);
            this.TicketsSold_ClassA_Label.Name = "TicketsSold_ClassA_Label";
            this.TicketsSold_ClassA_Label.Size = new System.Drawing.Size(45, 13);
            this.TicketsSold_ClassA_Label.TabIndex = 1;
            this.TicketsSold_ClassA_Label.Text = "Class A:";
            // 
            // TicketsSold_ClassA_Textbox
            // 
            this.TicketsSold_ClassA_Textbox.Location = new System.Drawing.Point(105, 66);
            this.TicketsSold_ClassA_Textbox.Name = "TicketsSold_ClassA_Textbox";
            this.TicketsSold_ClassA_Textbox.Size = new System.Drawing.Size(100, 20);
            this.TicketsSold_ClassA_Textbox.TabIndex = 2;
            // 
            // TicketsSold_ClassB_Textbox
            // 
            this.TicketsSold_ClassB_Textbox.Location = new System.Drawing.Point(105, 114);
            this.TicketsSold_ClassB_Textbox.Name = "TicketsSold_ClassB_Textbox";
            this.TicketsSold_ClassB_Textbox.Size = new System.Drawing.Size(100, 20);
            this.TicketsSold_ClassB_Textbox.TabIndex = 3;
            // 
            // TicketsSold_ClassB_Label
            // 
            this.TicketsSold_ClassB_Label.AutoSize = true;
            this.TicketsSold_ClassB_Label.Location = new System.Drawing.Point(49, 114);
            this.TicketsSold_ClassB_Label.Name = "TicketsSold_ClassB_Label";
            this.TicketsSold_ClassB_Label.Size = new System.Drawing.Size(45, 13);
            this.TicketsSold_ClassB_Label.TabIndex = 4;
            this.TicketsSold_ClassB_Label.Text = "Class B:";
            // 
            // TicketsSold_ClassC_Label
            // 
            this.TicketsSold_ClassC_Label.AutoSize = true;
            this.TicketsSold_ClassC_Label.Location = new System.Drawing.Point(49, 164);
            this.TicketsSold_ClassC_Label.Name = "TicketsSold_ClassC_Label";
            this.TicketsSold_ClassC_Label.Size = new System.Drawing.Size(45, 13);
            this.TicketsSold_ClassC_Label.TabIndex = 5;
            this.TicketsSold_ClassC_Label.Text = "Class C:";
            // 
            // TicketsSold_ClassC_Textbox
            // 
            this.TicketsSold_ClassC_Textbox.Location = new System.Drawing.Point(105, 164);
            this.TicketsSold_ClassC_Textbox.Name = "TicketsSold_ClassC_Textbox";
            this.TicketsSold_ClassC_Textbox.Size = new System.Drawing.Size(100, 20);
            this.TicketsSold_ClassC_Textbox.TabIndex = 6;
            // 
            // RevenueGenerated_ClassA_Label
            // 
            this.RevenueGenerated_ClassA_Label.AutoSize = true;
            this.RevenueGenerated_ClassA_Label.Location = new System.Drawing.Point(55, 41);
            this.RevenueGenerated_ClassA_Label.Name = "RevenueGenerated_ClassA_Label";
            this.RevenueGenerated_ClassA_Label.Size = new System.Drawing.Size(45, 13);
            this.RevenueGenerated_ClassA_Label.TabIndex = 2;
            this.RevenueGenerated_ClassA_Label.Text = "Class A:";
            // 
            // RevenueGenerated_ClassA_Textbox
            // 
            this.RevenueGenerated_ClassA_Textbox.Location = new System.Drawing.Point(106, 41);
            this.RevenueGenerated_ClassA_Textbox.Name = "RevenueGenerated_ClassA_Textbox";
            this.RevenueGenerated_ClassA_Textbox.ReadOnly = true;
            this.RevenueGenerated_ClassA_Textbox.Size = new System.Drawing.Size(100, 20);
            this.RevenueGenerated_ClassA_Textbox.TabIndex = 3;
            // 
            // RevenueGenerated_ClassB_Label
            // 
            this.RevenueGenerated_ClassB_Label.AutoSize = true;
            this.RevenueGenerated_ClassB_Label.Location = new System.Drawing.Point(55, 89);
            this.RevenueGenerated_ClassB_Label.Name = "RevenueGenerated_ClassB_Label";
            this.RevenueGenerated_ClassB_Label.Size = new System.Drawing.Size(45, 13);
            this.RevenueGenerated_ClassB_Label.TabIndex = 4;
            this.RevenueGenerated_ClassB_Label.Text = "Class B:";
            // 
            // RevenueGenerated_ClassB_Textbox
            // 
            this.RevenueGenerated_ClassB_Textbox.Location = new System.Drawing.Point(106, 89);
            this.RevenueGenerated_ClassB_Textbox.Name = "RevenueGenerated_ClassB_Textbox";
            this.RevenueGenerated_ClassB_Textbox.ReadOnly = true;
            this.RevenueGenerated_ClassB_Textbox.Size = new System.Drawing.Size(100, 20);
            this.RevenueGenerated_ClassB_Textbox.TabIndex = 5;
            // 
            // RevenueGenerated_ClassC_Label
            // 
            this.RevenueGenerated_ClassC_Label.AutoSize = true;
            this.RevenueGenerated_ClassC_Label.Location = new System.Drawing.Point(55, 131);
            this.RevenueGenerated_ClassC_Label.Name = "RevenueGenerated_ClassC_Label";
            this.RevenueGenerated_ClassC_Label.Size = new System.Drawing.Size(45, 13);
            this.RevenueGenerated_ClassC_Label.TabIndex = 6;
            this.RevenueGenerated_ClassC_Label.Text = "Class C:";
            // 
            // RevenueGenerated_ClassC_Textbox
            // 
            this.RevenueGenerated_ClassC_Textbox.Location = new System.Drawing.Point(106, 131);
            this.RevenueGenerated_ClassC_Textbox.Name = "RevenueGenerated_ClassC_Textbox";
            this.RevenueGenerated_ClassC_Textbox.ReadOnly = true;
            this.RevenueGenerated_ClassC_Textbox.Size = new System.Drawing.Size(100, 20);
            this.RevenueGenerated_ClassC_Textbox.TabIndex = 7;
            // 
            // RevenueGenerated_Total_Label
            // 
            this.RevenueGenerated_Total_Label.AutoSize = true;
            this.RevenueGenerated_Total_Label.Location = new System.Drawing.Point(55, 178);
            this.RevenueGenerated_Total_Label.Name = "RevenueGenerated_Total_Label";
            this.RevenueGenerated_Total_Label.Size = new System.Drawing.Size(34, 13);
            this.RevenueGenerated_Total_Label.TabIndex = 8;
            this.RevenueGenerated_Total_Label.Text = "Total:";
            // 
            // RevenueGenerated_Total_Textbox
            // 
            this.RevenueGenerated_Total_Textbox.Location = new System.Drawing.Point(106, 178);
            this.RevenueGenerated_Total_Textbox.Name = "RevenueGenerated_Total_Textbox";
            this.RevenueGenerated_Total_Textbox.ReadOnly = true;
            this.RevenueGenerated_Total_Textbox.Size = new System.Drawing.Size(100, 20);
            this.RevenueGenerated_Total_Textbox.TabIndex = 9;
            // 
            // CalculateRevenue_Button
            // 
            this.CalculateRevenue_Button.Location = new System.Drawing.Point(194, 344);
            this.CalculateRevenue_Button.Name = "CalculateRevenue_Button";
            this.CalculateRevenue_Button.Size = new System.Drawing.Size(100, 52);
            this.CalculateRevenue_Button.TabIndex = 5;
            this.CalculateRevenue_Button.Text = "Calculate Revenue";
            this.CalculateRevenue_Button.UseVisualStyleBackColor = true;
            this.CalculateRevenue_Button.Click += new System.EventHandler(this.CalculateRevenue_Button_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.Location = new System.Drawing.Point(326, 344);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(100, 52);
            this.Clear_Button.TabIndex = 6;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(454, 344);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(100, 52);
            this.Exit_Button.TabIndex = 7;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // StadiumRevenueForm
            // 
            this.AcceptButton = this.CalculateRevenue_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 440);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.CalculateRevenue_Button);
            this.Controls.Add(this.RevenueGenerated_Label);
            this.Controls.Add(this.TicketsSold_Label);
            this.Controls.Add(this.RevenueGenerated_Panel);
            this.Controls.Add(this.TicketsSold_Panel);
            this.Name = "StadiumRevenueForm";
            this.Tag = "";
            this.Text = "Stadium Seating Revenue";
            this.TicketsSold_Panel.ResumeLayout(false);
            this.TicketsSold_Panel.PerformLayout();
            this.RevenueGenerated_Panel.ResumeLayout(false);
            this.RevenueGenerated_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel TicketsSold_Panel;
        private Panel RevenueGenerated_Panel;
        private Label TicketsSold_Label;
        private Label RevenueGenerated_Label;
        private Label label1;
        private TextBox TicketsSold_ClassC_Textbox;
        private Label TicketsSold_ClassC_Label;
        private Label TicketsSold_ClassB_Label;
        private TextBox TicketsSold_ClassB_Textbox;
        private TextBox TicketsSold_ClassA_Textbox;
        private Label TicketsSold_ClassA_Label;
        private TextBox RevenueGenerated_Total_Textbox;
        private Label RevenueGenerated_Total_Label;
        private TextBox RevenueGenerated_ClassC_Textbox;
        private Label RevenueGenerated_ClassC_Label;
        private TextBox RevenueGenerated_ClassB_Textbox;
        private Label RevenueGenerated_ClassB_Label;
        private TextBox RevenueGenerated_ClassA_Textbox;
        private Label RevenueGenerated_ClassA_Label;
        private Button CalculateRevenue_Button;
        private Button Clear_Button;
        private Button Exit_Button;
    }
}


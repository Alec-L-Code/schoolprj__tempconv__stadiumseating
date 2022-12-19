namespace TempConverter
{
    partial class TempConverterForm
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
            this.ConvertToFahrenheit_Button = new System.Windows.Forms.Button();
            this.ConvertToCelsius_Button = new System.Windows.Forms.Button();
            this.UnconvertedTemperature_Textbox = new System.Windows.Forms.TextBox();
            this.ConvertedTemperature_Textbox = new System.Windows.Forms.TextBox();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConvertToFahrenheit_Button
            // 
            this.ConvertToFahrenheit_Button.Location = new System.Drawing.Point(12, 96);
            this.ConvertToFahrenheit_Button.Name = "ConvertToFahrenheit_Button";
            this.ConvertToFahrenheit_Button.Size = new System.Drawing.Size(142, 58);
            this.ConvertToFahrenheit_Button.TabIndex = 0;
            this.ConvertToFahrenheit_Button.Text = "Convert\r\nTo\r\nFahrenheit";
            this.ConvertToFahrenheit_Button.UseVisualStyleBackColor = true;
            this.ConvertToFahrenheit_Button.Click += new System.EventHandler(this.ConvertToFahrenheit_Button_Click);
            // 
            // ConvertToCelsius_Button
            // 
            this.ConvertToCelsius_Button.Location = new System.Drawing.Point(264, 96);
            this.ConvertToCelsius_Button.Name = "ConvertToCelsius_Button";
            this.ConvertToCelsius_Button.Size = new System.Drawing.Size(143, 58);
            this.ConvertToCelsius_Button.TabIndex = 1;
            this.ConvertToCelsius_Button.Text = "Convert\r\nTo\r\nCelsius";
            this.ConvertToCelsius_Button.UseVisualStyleBackColor = true;
            this.ConvertToCelsius_Button.Click += new System.EventHandler(this.ConvertToCelsius_Button_Click);
            // 
            // UnconvertedTemperature_Textbox
            // 
            this.UnconvertedTemperature_Textbox.Location = new System.Drawing.Point(147, 26);
            this.UnconvertedTemperature_Textbox.Name = "UnconvertedTemperature_Textbox";
            this.UnconvertedTemperature_Textbox.Size = new System.Drawing.Size(119, 20);
            this.UnconvertedTemperature_Textbox.TabIndex = 2;
            this.UnconvertedTemperature_Textbox.TextChanged += new System.EventHandler(this.UnconvertedTemperature_Textbox_TextChanged);
            // 
            // ConvertedTemperature_Textbox
            // 
            this.ConvertedTemperature_Textbox.Location = new System.Drawing.Point(147, 222);
            this.ConvertedTemperature_Textbox.Name = "ConvertedTemperature_Textbox";
            this.ConvertedTemperature_Textbox.ReadOnly = true;
            this.ConvertedTemperature_Textbox.Size = new System.Drawing.Size(119, 20);
            this.ConvertedTemperature_Textbox.TabIndex = 3;
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(334, 243);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(75, 23);
            this.Exit_Button.TabIndex = 4;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // TempConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Exit_Button;
            this.ClientSize = new System.Drawing.Size(421, 278);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.ConvertedTemperature_Textbox);
            this.Controls.Add(this.UnconvertedTemperature_Textbox);
            this.Controls.Add(this.ConvertToCelsius_Button);
            this.Controls.Add(this.ConvertToFahrenheit_Button);
            this.Name = "TempConverterForm";
            this.Text = "Temperature Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConvertToFahrenheit_Button;
        private System.Windows.Forms.Button ConvertToCelsius_Button;
        private System.Windows.Forms.TextBox UnconvertedTemperature_Textbox;
        private System.Windows.Forms.TextBox ConvertedTemperature_Textbox;
        private System.Windows.Forms.Button Exit_Button;
    }
}


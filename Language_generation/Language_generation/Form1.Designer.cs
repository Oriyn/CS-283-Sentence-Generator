namespace Language_generation
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.inputText = new System.Windows.Forms.RichTextBox();
            this.outputText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Sentence";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(185, 93);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(241, 89);
            this.inputText.TabIndex = 1;
            this.inputText.Text = "";
            // 
            // outputText
            // 
            this.outputText.Enabled = false;
            this.outputText.Location = new System.Drawing.Point(185, 235);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(241, 96);
            this.outputText.TabIndex = 2;
            this.outputText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input Text:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output Text:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 481);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox inputText;
        private System.Windows.Forms.RichTextBox outputText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


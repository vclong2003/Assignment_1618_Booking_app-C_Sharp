namespace ASM_1618_Mark3
{
    partial class ManagerConsole
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
            this.backButton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.CheckedState.Parent = this.backButton;
            this.backButton.CustomImages.Parent = this.backButton;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.HoverState.Parent = this.backButton;
            this.backButton.Location = new System.Drawing.Point(1034, 555);
            this.backButton.Name = "backButton";
            this.backButton.ShadowDecoration.Parent = this.backButton;
            this.backButton.Size = new System.Drawing.Size(95, 45);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ManagerConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 612);
            this.Controls.Add(this.backButton);
            this.Name = "ManagerConsole";
            this.Text = "ManagerConsole";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button backButton;
    }
}
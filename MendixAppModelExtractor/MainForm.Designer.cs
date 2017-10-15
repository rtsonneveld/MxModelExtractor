namespace MendixAppModelExtractor {
  partial class MainForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.buttonSelectFile = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // buttonSelectFile
      // 
      this.buttonSelectFile.Location = new System.Drawing.Point(12, 12);
      this.buttonSelectFile.Name = "buttonSelectFile";
      this.buttonSelectFile.Size = new System.Drawing.Size(191, 23);
      this.buttonSelectFile.TabIndex = 0;
      this.buttonSelectFile.Text = "Browse for Mendix Project/Package";
      this.buttonSelectFile.UseVisualStyleBackColor = true;
      this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 443);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(242, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Mendix Model Extraction tool by Robin Sonneveld";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(418, 468);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.buttonSelectFile);
      this.Name = "MainForm";
      this.Text = "Mendix Model Extraction";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonSelectFile;
    private System.Windows.Forms.Label label1;
  }
}


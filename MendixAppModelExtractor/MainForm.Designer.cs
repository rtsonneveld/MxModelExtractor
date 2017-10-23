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
      this.buttonOpenProject = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.projectSelector = new System.Windows.Forms.ComboBox();
      this.buttonRefreshProjectList = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // buttonSelectFile
      // 
      this.buttonSelectFile.Location = new System.Drawing.Point(12, 12);
      this.buttonSelectFile.Name = "buttonSelectFile";
      this.buttonSelectFile.Size = new System.Drawing.Size(261, 23);
      this.buttonSelectFile.TabIndex = 0;
      this.buttonSelectFile.Text = "Extract MPK/MPR";
      this.buttonSelectFile.UseVisualStyleBackColor = true;
      this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 156);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(242, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Mendix Model Extraction tool by Robin Sonneveld";
      // 
      // buttonOpenProject
      // 
      this.buttonOpenProject.Location = new System.Drawing.Point(224, 74);
      this.buttonOpenProject.Name = "buttonOpenProject";
      this.buttonOpenProject.Size = new System.Drawing.Size(49, 21);
      this.buttonOpenProject.TabIndex = 2;
      this.buttonOpenProject.Text = "Open";
      this.buttonOpenProject.UseVisualStyleBackColor = true;
      this.buttonOpenProject.Click += new System.EventHandler(this.buttonOpenProject_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 58);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(92, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Extracted projects";
      // 
      // projectSelector
      // 
      this.projectSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.projectSelector.FormattingEnabled = true;
      this.projectSelector.Location = new System.Drawing.Point(12, 74);
      this.projectSelector.Name = "projectSelector";
      this.projectSelector.Size = new System.Drawing.Size(206, 21);
      this.projectSelector.TabIndex = 4;
      // 
      // buttonRefreshProjectList
      // 
      this.buttonRefreshProjectList.Location = new System.Drawing.Point(12, 101);
      this.buttonRefreshProjectList.Name = "buttonRefreshProjectList";
      this.buttonRefreshProjectList.Size = new System.Drawing.Size(60, 21);
      this.buttonRefreshProjectList.TabIndex = 5;
      this.buttonRefreshProjectList.Text = "Refresh";
      this.buttonRefreshProjectList.UseVisualStyleBackColor = true;
      this.buttonRefreshProjectList.Click += new System.EventHandler(this.buttonRefreshProjectList_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(285, 181);
      this.Controls.Add(this.buttonRefreshProjectList);
      this.Controls.Add(this.projectSelector);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.buttonOpenProject);
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
    private System.Windows.Forms.Button buttonOpenProject;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox projectSelector;
    private System.Windows.Forms.Button buttonRefreshProjectList;
  }
}


namespace MendixAppModelExtractor {
  partial class ProjectExplorer {
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
      this.components = new System.ComponentModel.Container();
      this.DocumentTreeView = new System.Windows.Forms.TreeView();
      this.ModuleList = new System.Windows.Forms.ComboBox();
      this.moduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.labelProjectInfo = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // DocumentTreeView
      // 
      this.DocumentTreeView.Location = new System.Drawing.Point(12, 52);
      this.DocumentTreeView.Name = "DocumentTreeView";
      this.DocumentTreeView.Size = new System.Drawing.Size(180, 430);
      this.DocumentTreeView.TabIndex = 0;
      // 
      // ModuleList
      // 
      this.ModuleList.FormattingEnabled = true;
      this.ModuleList.Location = new System.Drawing.Point(12, 25);
      this.ModuleList.Name = "ModuleList";
      this.ModuleList.Size = new System.Drawing.Size(180, 21);
      this.ModuleList.TabIndex = 1;
      this.ModuleList.SelectedIndexChanged += new System.EventHandler(this.ModuleList_SelectedIndexChanged);
      // 
      // labelProjectInfo
      // 
      this.labelProjectInfo.AutoSize = true;
      this.labelProjectInfo.Location = new System.Drawing.Point(12, 9);
      this.labelProjectInfo.Name = "labelProjectInfo";
      this.labelProjectInfo.Size = new System.Drawing.Size(61, 13);
      this.labelProjectInfo.TabIndex = 2;
      this.labelProjectInfo.Text = "Project Info";
      // 
      // ProjectExplorer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1021, 494);
      this.Controls.Add(this.labelProjectInfo);
      this.Controls.Add(this.ModuleList);
      this.Controls.Add(this.DocumentTreeView);
      this.Name = "ProjectExplorer";
      this.Text = "ProjectExplorer";
      ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TreeView DocumentTreeView;
    private System.Windows.Forms.ComboBox ModuleList;
    private System.Windows.Forms.BindingSource moduleBindingSource;
    private string selectedItem;
    private System.Windows.Forms.Label labelProjectInfo;
  }
}
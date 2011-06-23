namespace regexExtractorWin {
  partial class Form1 {
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
      this.btnSearch = new System.Windows.Forms.Button();
      this.txtFile = new System.Windows.Forms.TextBox();
      this.txtRegex = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // btnSearch
      // 
      this.btnSearch.Location = new System.Drawing.Point(471, 8);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(75, 23);
      this.btnSearch.TabIndex = 1;
      this.btnSearch.Text = "List matches";
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // txtFile
      // 
      this.txtFile.Location = new System.Drawing.Point(68, 10);
      this.txtFile.Name = "txtFile";
      this.txtFile.Size = new System.Drawing.Size(378, 20);
      this.txtFile.TabIndex = 2;
      this.txtFile.Text = "C:\\Users\\dan\\Documents\\Facultad\\Tesis\\Documentos\\Tesis.html";
      // 
      // txtRegex
      // 
      this.txtRegex.Location = new System.Drawing.Point(68, 36);
      this.txtRegex.Name = "txtRegex";
      this.txtRegex.Size = new System.Drawing.Size(378, 20);
      this.txtRegex.TabIndex = 3;
      this.txtRegex.Text = "<i>.+?</i>";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(9, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(23, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "File";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 39);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(38, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Regex";
      // 
      // textBox1
      // 
      this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox1.Location = new System.Drawing.Point(12, 69);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBox1.Size = new System.Drawing.Size(615, 230);
      this.textBox1.TabIndex = 5;
      // 
      // Form1
      // 
      this.AcceptButton = this.btnSearch;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(639, 311);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtRegex);
      this.Controls.Add(this.txtFile);
      this.Controls.Add(this.btnSearch);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.TextBox txtFile;
    private System.Windows.Forms.TextBox txtRegex;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox1;
  }
}


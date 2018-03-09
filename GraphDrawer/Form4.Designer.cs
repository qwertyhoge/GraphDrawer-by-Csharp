namespace GraphDrawer
{
    partial class Form4
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
            this.nodeGenerator = new System.Windows.Forms.Button();
            this.nodeName = new System.Windows.Forms.TextBox();
            this.nodeNameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.tagsLabel = new System.Windows.Forms.Label();
            this.tags = new System.Windows.Forms.TextBox();
            this.informationPanel = new System.Windows.Forms.TableLayoutPanel();
            this.informationDescription = new System.Windows.Forms.TextBox();
            this.informationDescriptionLabel = new System.Windows.Forms.Label();
            this.informationNodeNameLabel = new System.Windows.Forms.Label();
            this.informationNodeName = new System.Windows.Forms.TextBox();
            this.informationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nodeGenerator
            // 
            this.nodeGenerator.Location = new System.Drawing.Point(58, 158);
            this.nodeGenerator.Name = "nodeGenerator";
            this.nodeGenerator.Size = new System.Drawing.Size(127, 57);
            this.nodeGenerator.TabIndex = 0;
            this.nodeGenerator.Text = "Generate a Node";
            this.nodeGenerator.UseVisualStyleBackColor = true;
            this.nodeGenerator.Click += new System.EventHandler(this.nodeGenerator_Click);
            // 
            // nodeName
            // 
            this.nodeName.Location = new System.Drawing.Point(83, 12);
            this.nodeName.Name = "nodeName";
            this.nodeName.Size = new System.Drawing.Size(126, 19);
            this.nodeName.TabIndex = 1;
            // 
            // nodeNameLabel
            // 
            this.nodeNameLabel.AutoSize = true;
            this.nodeNameLabel.Location = new System.Drawing.Point(13, 12);
            this.nodeNameLabel.Name = "nodeNameLabel";
            this.nodeNameLabel.Size = new System.Drawing.Size(64, 12);
            this.nodeNameLabel.TabIndex = 2;
            this.nodeNameLabel.Text = "Node Name";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(13, 49);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 12);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Description";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(83, 49);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(126, 54);
            this.description.TabIndex = 4;
            // 
            // tagsLabel
            // 
            this.tagsLabel.AutoSize = true;
            this.tagsLabel.Location = new System.Drawing.Point(13, 120);
            this.tagsLabel.Name = "tagsLabel";
            this.tagsLabel.Size = new System.Drawing.Size(30, 12);
            this.tagsLabel.TabIndex = 5;
            this.tagsLabel.Text = "Tags";
            // 
            // tags
            // 
            this.tags.Location = new System.Drawing.Point(83, 117);
            this.tags.Name = "tags";
            this.tags.Size = new System.Drawing.Size(126, 19);
            this.tags.TabIndex = 6;
            // 
            // informationPanel
            // 
            this.informationPanel.ColumnCount = 2;
            this.informationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.10614F));
            this.informationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.89386F));
            this.informationPanel.Controls.Add(this.informationDescription, 1, 1);
            this.informationPanel.Controls.Add(this.informationDescriptionLabel, 0, 1);
            this.informationPanel.Controls.Add(this.informationNodeNameLabel, 0, 0);
            this.informationPanel.Controls.Add(this.informationNodeName, 1, 0);
            this.informationPanel.Location = new System.Drawing.Point(301, 12);
            this.informationPanel.Name = "informationPanel";
            this.informationPanel.RowCount = 2;
            this.informationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.25698F));
            this.informationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.74302F));
            this.informationPanel.Size = new System.Drawing.Size(179, 147);
            this.informationPanel.TabIndex = 7;
            // 
            // informationDescription
            // 
            this.informationDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.informationDescription.Location = new System.Drawing.Point(74, 60);
            this.informationDescription.Multiline = true;
            this.informationDescription.Name = "informationDescription";
            this.informationDescription.ReadOnly = true;
            this.informationDescription.Size = new System.Drawing.Size(100, 64);
            this.informationDescription.TabIndex = 3;
            // 
            // informationDescriptionLabel
            // 
            this.informationDescriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.informationDescriptionLabel.AutoSize = true;
            this.informationDescriptionLabel.Location = new System.Drawing.Point(3, 86);
            this.informationDescriptionLabel.Name = "informationDescriptionLabel";
            this.informationDescriptionLabel.Size = new System.Drawing.Size(63, 12);
            this.informationDescriptionLabel.TabIndex = 1;
            this.informationDescriptionLabel.Text = "Description";
            // 
            // informationNodeNameLabel
            // 
            this.informationNodeNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.informationNodeNameLabel.AutoSize = true;
            this.informationNodeNameLabel.Location = new System.Drawing.Point(4, 13);
            this.informationNodeNameLabel.Name = "informationNodeNameLabel";
            this.informationNodeNameLabel.Size = new System.Drawing.Size(60, 12);
            this.informationNodeNameLabel.TabIndex = 0;
            this.informationNodeNameLabel.Text = "NodeName";
            // 
            // informationNodeName
            // 
            this.informationNodeName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.informationNodeName.Location = new System.Drawing.Point(74, 9);
            this.informationNodeName.Name = "informationNodeName";
            this.informationNodeName.ReadOnly = true;
            this.informationNodeName.Size = new System.Drawing.Size(100, 19);
            this.informationNodeName.TabIndex = 2;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 445);
            this.Controls.Add(this.informationPanel);
            this.Controls.Add(this.tags);
            this.Controls.Add(this.tagsLabel);
            this.Controls.Add(this.description);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nodeNameLabel);
            this.Controls.Add(this.nodeName);
            this.Controls.Add(this.nodeGenerator);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.informationPanel.ResumeLayout(false);
            this.informationPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nodeGenerator;
        private System.Windows.Forms.TextBox nodeName;
        private System.Windows.Forms.Label nodeNameLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label tagsLabel;
        private System.Windows.Forms.TextBox tags;
        private System.Windows.Forms.TableLayoutPanel informationPanel;
        private System.Windows.Forms.TextBox informationDescription;
        private System.Windows.Forms.Label informationDescriptionLabel;
        private System.Windows.Forms.Label informationNodeNameLabel;
        private System.Windows.Forms.TextBox informationNodeName;
    }
}
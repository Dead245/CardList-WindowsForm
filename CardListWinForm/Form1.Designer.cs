namespace CardListWinForm
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.cardListBox = new System.Windows.Forms.ListBox();
            this.cardInfoLabel = new System.Windows.Forms.Label();
            this.cardListLabel = new System.Windows.Forms.Label();
            this.cardInfoTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(188, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(12, 12);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(170, 23);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // cardListBox
            // 
            this.cardListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardListBox.FormattingEnabled = true;
            this.cardListBox.ItemHeight = 16;
            this.cardListBox.Location = new System.Drawing.Point(13, 58);
            this.cardListBox.Name = "cardListBox";
            this.cardListBox.Size = new System.Drawing.Size(250, 372);
            this.cardListBox.TabIndex = 2;
            this.cardListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cardInfoLabel
            // 
            this.cardInfoLabel.AutoSize = true;
            this.cardInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardInfoLabel.Location = new System.Drawing.Point(595, 38);
            this.cardInfoLabel.Name = "cardInfoLabel";
            this.cardInfoLabel.Size = new System.Drawing.Size(112, 17);
            this.cardInfoLabel.TabIndex = 3;
            this.cardInfoLabel.Text = "Card Information";
            this.cardInfoLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // cardListLabel
            // 
            this.cardListLabel.AutoSize = true;
            this.cardListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardListLabel.Location = new System.Drawing.Point(95, 38);
            this.cardListLabel.Name = "cardListLabel";
            this.cardListLabel.Size = new System.Drawing.Size(64, 17);
            this.cardListLabel.TabIndex = 5;
            this.cardListLabel.Text = "Card List";
            // 
            // cardInfoTextBox
            // 
            this.cardInfoTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.cardInfoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardInfoTextBox.Location = new System.Drawing.Point(491, 58);
            this.cardInfoTextBox.Name = "cardInfoTextBox";
            this.cardInfoTextBox.Size = new System.Drawing.Size(297, 377);
            this.cardInfoTextBox.TabIndex = 6;
            this.cardInfoTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cardInfoTextBox);
            this.Controls.Add(this.cardListLabel);
            this.Controls.Add(this.cardInfoLabel);
            this.Controls.Add(this.cardListBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.btnSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ListBox cardListBox;
        private System.Windows.Forms.Label cardInfoLabel;
        private System.Windows.Forms.Label cardListLabel;
        private System.Windows.Forms.RichTextBox cardInfoTextBox;
    }
}


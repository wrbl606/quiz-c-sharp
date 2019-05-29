namespace JednokrotnyWybor
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TestTitle = new System.Windows.Forms.Label();
            this.TestAuthor = new System.Windows.Forms.Label();
            this.TestDescription = new System.Windows.Forms.Label();
            this.QuestionsList = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(775, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // TestTitle
            // 
            this.TestTitle.AutoSize = true;
            this.TestTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TestTitle.Location = new System.Drawing.Point(13, 43);
            this.TestTitle.Name = "TestTitle";
            this.TestTitle.Size = new System.Drawing.Size(134, 32);
            this.TestTitle.TabIndex = 1;
            this.TestTitle.Text = "TestTitle";
            this.TestTitle.Click += new System.EventHandler(this.TestTitle_Click);
            // 
            // TestAuthor
            // 
            this.TestAuthor.AutoSize = true;
            this.TestAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TestAuthor.Location = new System.Drawing.Point(19, 79);
            this.TestAuthor.Name = "TestAuthor";
            this.TestAuthor.Size = new System.Drawing.Size(83, 18);
            this.TestAuthor.TabIndex = 2;
            this.TestAuthor.Text = "Test author";
            // 
            // TestDescription
            // 
            this.TestDescription.AutoSize = true;
            this.TestDescription.Location = new System.Drawing.Point(22, 101);
            this.TestDescription.Name = "TestDescription";
            this.TestDescription.Size = new System.Drawing.Size(79, 17);
            this.TestDescription.TabIndex = 3;
            this.TestDescription.Text = "Description";
            // 
            // QuestionsList
            // 
            this.QuestionsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionsList.AutoScroll = true;
            this.QuestionsList.AutoScrollMinSize = new System.Drawing.Size(750, 600);
            this.QuestionsList.AutoSize = true;
            this.QuestionsList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.QuestionsList.ColumnCount = 1;
            this.QuestionsList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.QuestionsList.Location = new System.Drawing.Point(25, 122);
            this.QuestionsList.Name = "QuestionsList";
            this.QuestionsList.RowCount = 1;
            this.QuestionsList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.QuestionsList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.QuestionsList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.QuestionsList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.QuestionsList.Size = new System.Drawing.Size(750, 600);
            this.QuestionsList.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 771);
            this.Controls.Add(this.QuestionsList);
            this.Controls.Add(this.TestDescription);
            this.Controls.Add(this.TestAuthor);
            this.Controls.Add(this.TestTitle);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label TestTitle;
        private System.Windows.Forms.Label TestAuthor;
        private System.Windows.Forms.Label TestDescription;
        private System.Windows.Forms.TableLayoutPanel QuestionsList;
    }
}


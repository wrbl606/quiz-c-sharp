namespace JednokrotnyWybor
{
    partial class QuestionView
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.QuestionContent = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ResultExplaination = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QuestionContent
            // 
            this.QuestionContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QuestionContent.Location = new System.Drawing.Point(4, 4);
            this.QuestionContent.Margin = new System.Windows.Forms.Padding(12, 8, 12, 4);
            this.QuestionContent.Name = "QuestionContent";
            this.QuestionContent.Size = new System.Drawing.Size(674, 40);
            this.QuestionContent.TabIndex = 0;
            this.QuestionContent.Text = "label1";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.CheckBoxes = true;
            this.listView1.Location = new System.Drawing.Point(3, 84);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(671, 108);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ResultExplaination
            // 
            this.ResultExplaination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultExplaination.Location = new System.Drawing.Point(4, 56);
            this.ResultExplaination.Margin = new System.Windows.Forms.Padding(12, 8, 12, 4);
            this.ResultExplaination.Name = "ResultExplaination";
            this.ResultExplaination.Size = new System.Drawing.Size(674, 21);
            this.ResultExplaination.TabIndex = 2;
            this.ResultExplaination.Text = "label1";
            // 
            // QuestionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ResultExplaination);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.QuestionContent);
            this.Name = "QuestionView";
            this.Size = new System.Drawing.Size(681, 195);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label QuestionContent;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label ResultExplaination;
    }
}

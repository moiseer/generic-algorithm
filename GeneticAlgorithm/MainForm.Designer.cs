namespace GeneticAlgorithm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.PopulationCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PopulationSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.ClippingThresholdUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.CrossChanceUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.MutationProbabilityUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.MutationPercentUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PointListBox = new System.Windows.Forms.ListBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.GenerationGapUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.PopulationListBox = new System.Windows.Forms.ListBox();
            this.IndividualListBox = new System.Windows.Forms.ListBox();
            this.UpdatePointsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.PopulationCountUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.PopulationSizeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.ClippingThresholdUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.CrossChanceUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.MutationProbabilityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.MutationPercentUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.GenerationGapUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PopulationCountUpDown
            // 
            this.PopulationCountUpDown.Location = new System.Drawing.Point(170, 12);
            this.PopulationCountUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PopulationCountUpDown.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.PopulationCountUpDown.Name = "PopulationCountUpDown";
            this.PopulationCountUpDown.Size = new System.Drawing.Size(59, 23);
            this.PopulationCountUpDown.TabIndex = 0;
            this.PopulationCountUpDown.Value = new decimal(new int[] {20, 0, 0, 0});
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество поколений";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Размер популяции";
            // 
            // PopulationSizeUpDown
            // 
            this.PopulationSizeUpDown.Location = new System.Drawing.Point(170, 42);
            this.PopulationSizeUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PopulationSizeUpDown.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.PopulationSizeUpDown.Name = "PopulationSizeUpDown";
            this.PopulationSizeUpDown.Size = new System.Drawing.Size(59, 23);
            this.PopulationSizeUpDown.TabIndex = 3;
            this.PopulationSizeUpDown.Value = new decimal(new int[] {100, 0, 0, 0});
            // 
            // ClippingThresholdUpDown
            // 
            this.ClippingThresholdUpDown.DecimalPlaces = 2;
            this.ClippingThresholdUpDown.Increment = new decimal(new int[] {1, 0, 0, 131072});
            this.ClippingThresholdUpDown.Location = new System.Drawing.Point(170, 72);
            this.ClippingThresholdUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ClippingThresholdUpDown.Maximum = new decimal(new int[] {1, 0, 0, 0});
            this.ClippingThresholdUpDown.Name = "ClippingThresholdUpDown";
            this.ClippingThresholdUpDown.Size = new System.Drawing.Size(59, 23);
            this.ClippingThresholdUpDown.TabIndex = 5;
            this.ClippingThresholdUpDown.Value = new decimal(new int[] {3, 0, 0, 65536});
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Порог отсечения";
            // 
            // CrossChanceUpDown
            // 
            this.CrossChanceUpDown.DecimalPlaces = 2;
            this.CrossChanceUpDown.Increment = new decimal(new int[] {1, 0, 0, 131072});
            this.CrossChanceUpDown.Location = new System.Drawing.Point(170, 102);
            this.CrossChanceUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CrossChanceUpDown.Maximum = new decimal(new int[] {1, 0, 0, 0});
            this.CrossChanceUpDown.Name = "CrossChanceUpDown";
            this.CrossChanceUpDown.Size = new System.Drawing.Size(59, 23);
            this.CrossChanceUpDown.TabIndex = 7;
            this.CrossChanceUpDown.Value = new decimal(new int[] {6, 0, 0, 65536});
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Вероятность скрещивания";
            // 
            // MutationProbabilityUpDown
            // 
            this.MutationProbabilityUpDown.DecimalPlaces = 2;
            this.MutationProbabilityUpDown.Increment = new decimal(new int[] {1, 0, 0, 131072});
            this.MutationProbabilityUpDown.Location = new System.Drawing.Point(170, 162);
            this.MutationProbabilityUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MutationProbabilityUpDown.Maximum = new decimal(new int[] {1, 0, 0, 0});
            this.MutationProbabilityUpDown.Name = "MutationProbabilityUpDown";
            this.MutationProbabilityUpDown.Size = new System.Drawing.Size(59, 23);
            this.MutationProbabilityUpDown.TabIndex = 9;
            this.MutationProbabilityUpDown.Value = new decimal(new int[] {3, 0, 0, 65536});
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Вероятность мутации";
            // 
            // MutationPercentUpDown
            // 
            this.MutationPercentUpDown.DecimalPlaces = 2;
            this.MutationPercentUpDown.Increment = new decimal(new int[] {1, 0, 0, 131072});
            this.MutationPercentUpDown.Location = new System.Drawing.Point(170, 192);
            this.MutationPercentUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MutationPercentUpDown.Maximum = new decimal(new int[] {1, 0, 0, 0});
            this.MutationPercentUpDown.Name = "MutationPercentUpDown";
            this.MutationPercentUpDown.Size = new System.Drawing.Size(59, 23);
            this.MutationPercentUpDown.TabIndex = 11;
            this.MutationPercentUpDown.Value = new decimal(new int[] {1, 0, 0, 65536});
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 192);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Сила мутации";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 235);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Список точек";
            // 
            // PointListBox
            // 
            this.PointListBox.FormattingEnabled = true;
            this.PointListBox.ItemHeight = 15;
            this.PointListBox.Location = new System.Drawing.Point(12, 261);
            this.PointListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PointListBox.Name = "PointListBox";
            this.PointListBox.Size = new System.Drawing.Size(218, 199);
            this.PointListBox.TabIndex = 13;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 479);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(217, 23);
            this.StartButton.TabIndex = 14;
            this.StartButton.Text = "Начать";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 528);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Результат";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(89, 526);
            this.ResultTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(140, 23);
            this.ResultTextBox.TabIndex = 16;
            // 
            // GenerationGapUpDown
            // 
            this.GenerationGapUpDown.DecimalPlaces = 2;
            this.GenerationGapUpDown.Increment = new decimal(new int[] {1, 0, 0, 131072});
            this.GenerationGapUpDown.Location = new System.Drawing.Point(170, 132);
            this.GenerationGapUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GenerationGapUpDown.Maximum = new decimal(new int[] {1, 0, 0, 0});
            this.GenerationGapUpDown.Name = "GenerationGapUpDown";
            this.GenerationGapUpDown.Size = new System.Drawing.Size(59, 23);
            this.GenerationGapUpDown.TabIndex = 18;
            this.GenerationGapUpDown.Value = new decimal(new int[] {7, 0, 0, 65536});
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(12, 132);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Разрыв поколений";
            // 
            // PopulationListBox
            // 
            this.PopulationListBox.FormattingEnabled = true;
            this.PopulationListBox.ItemHeight = 15;
            this.PopulationListBox.Location = new System.Drawing.Point(237, 21);
            this.PopulationListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PopulationListBox.Name = "PopulationListBox";
            this.PopulationListBox.Size = new System.Drawing.Size(218, 439);
            this.PopulationListBox.TabIndex = 19;
            this.PopulationListBox.SelectedIndexChanged +=
                new System.EventHandler(this.PopulationListBox_SelectedIndexChanged);
            // 
            // IndividualListBox
            // 
            this.IndividualListBox.FormattingEnabled = true;
            this.IndividualListBox.ItemHeight = 15;
            this.IndividualListBox.Location = new System.Drawing.Point(463, 21);
            this.IndividualListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IndividualListBox.Name = "IndividualListBox";
            this.IndividualListBox.Size = new System.Drawing.Size(308, 439);
            this.IndividualListBox.TabIndex = 20;
            // 
            // UpdatePointsButton
            // 
            this.UpdatePointsButton.Location = new System.Drawing.Point(154, 235);
            this.UpdatePointsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UpdatePointsButton.Name = "UpdatePointsButton";
            this.UpdatePointsButton.Size = new System.Drawing.Size(75, 23);
            this.UpdatePointsButton.TabIndex = 21;
            this.UpdatePointsButton.Text = "Обновить";
            this.UpdatePointsButton.UseVisualStyleBackColor = true;
            this.UpdatePointsButton.Click += new System.EventHandler(this.UpdatePointsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.UpdatePointsButton);
            this.Controls.Add(this.IndividualListBox);
            this.Controls.Add(this.PopulationListBox);
            this.Controls.Add(this.GenerationGapUpDown);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.PointListBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MutationPercentUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MutationProbabilityUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CrossChanceUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClippingThresholdUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PopulationSizeUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PopulationCountUpDown);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Genetic Algorithm";
            ((System.ComponentModel.ISupportInitialize) (this.PopulationCountUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.PopulationSizeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.ClippingThresholdUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.CrossChanceUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.MutationProbabilityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.MutationPercentUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.GenerationGapUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown PopulationSizeUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown PopulationCountUpDown;
        private System.Windows.Forms.NumericUpDown ClippingThresholdUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown CrossChanceUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown MutationProbabilityUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown MutationPercentUpDown;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ListBox PointListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown GenerationGapUpDown;
        private System.Windows.Forms.ListBox PopulationListBox;
        private System.Windows.Forms.ListBox IndividualListBox;
        private System.Windows.Forms.Button UpdatePointsButton;
    }
}
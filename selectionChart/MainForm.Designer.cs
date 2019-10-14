namespace selectionChart
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.selecGenButton = new System.Windows.Forms.Button();
            this.findExsistButton = new System.Windows.Forms.Button();
            this.maxElemBox = new System.Windows.Forms.TextBox();
            this.minElemBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.elemBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.equableSelecRadio = new System.Windows.Forms.RadioButton();
            this.exponentSelecRadio = new System.Windows.Forms.RadioButton();
            this.normSelecRadio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.selectCountBox = new System.Windows.Forms.TextBox();
            this.writeSelectionButton = new System.Windows.Forms.Button();
            this.seriesCriterionButton = new System.Windows.Forms.Button();
            this.selectionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.matWaitingText = new System.Windows.Forms.TextBox();
            this.dispersionText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.standartDeviationText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.StudentCriterionMax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.StudentCriterionMin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.StudentCriterionButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectionChart)).BeginInit();
            this.SuspendLayout();
            // 
            // selecGenButton
            // 
            this.selecGenButton.Location = new System.Drawing.Point(612, 26);
            this.selecGenButton.Name = "selecGenButton";
            this.selecGenButton.Size = new System.Drawing.Size(117, 23);
            this.selecGenButton.TabIndex = 0;
            this.selecGenButton.Text = "Generate selection";
            this.selecGenButton.UseVisualStyleBackColor = true;
            this.selecGenButton.Click += new System.EventHandler(this.selecGenButton_Click);
            // 
            // findExsistButton
            // 
            this.findExsistButton.Location = new System.Drawing.Point(612, 66);
            this.findExsistButton.Name = "findExsistButton";
            this.findExsistButton.Size = new System.Drawing.Size(117, 27);
            this.findExsistButton.TabIndex = 1;
            this.findExsistButton.Text = "Find exsist selection";
            this.findExsistButton.UseVisualStyleBackColor = true;
            this.findExsistButton.Click += new System.EventHandler(this.findExsistButton_Click);
            // 
            // maxElemBox
            // 
            this.maxElemBox.Location = new System.Drawing.Point(39, 254);
            this.maxElemBox.Name = "maxElemBox";
            this.maxElemBox.Size = new System.Drawing.Size(100, 20);
            this.maxElemBox.TabIndex = 2;
            // 
            // minElemBox
            // 
            this.minElemBox.Location = new System.Drawing.Point(39, 322);
            this.minElemBox.Name = "minElemBox";
            this.minElemBox.Size = new System.Drawing.Size(100, 20);
            this.minElemBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Max elem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Min elem";
            // 
            // elemBox
            // 
            this.elemBox.Location = new System.Drawing.Point(177, 351);
            this.elemBox.Name = "elemBox";
            this.elemBox.Size = new System.Drawing.Size(525, 20);
            this.elemBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.equableSelecRadio);
            this.groupBox1.Controls.Add(this.exponentSelecRadio);
            this.groupBox1.Controls.Add(this.normSelecRadio);
            this.groupBox1.Location = new System.Drawing.Point(588, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "selection chooser";
            // 
            // equableSelecRadio
            // 
            this.equableSelecRadio.AutoSize = true;
            this.equableSelecRadio.Location = new System.Drawing.Point(18, 72);
            this.equableSelecRadio.Name = "equableSelecRadio";
            this.equableSelecRadio.Size = new System.Drawing.Size(109, 17);
            this.equableSelecRadio.TabIndex = 2;
            this.equableSelecRadio.TabStop = true;
            this.equableSelecRadio.Text = "Equable selection";
            this.equableSelecRadio.UseVisualStyleBackColor = true;
            // 
            // exponentSelecRadio
            // 
            this.exponentSelecRadio.AutoSize = true;
            this.exponentSelecRadio.Location = new System.Drawing.Point(18, 44);
            this.exponentSelecRadio.Name = "exponentSelecRadio";
            this.exponentSelecRadio.Size = new System.Drawing.Size(125, 17);
            this.exponentSelecRadio.TabIndex = 1;
            this.exponentSelecRadio.TabStop = true;
            this.exponentSelecRadio.Text = "Exponential selection";
            this.exponentSelecRadio.UseVisualStyleBackColor = true;
            // 
            // normSelecRadio
            // 
            this.normSelecRadio.AutoSize = true;
            this.normSelecRadio.Location = new System.Drawing.Point(18, 20);
            this.normSelecRadio.Name = "normSelecRadio";
            this.normSelecRadio.Size = new System.Drawing.Size(103, 17);
            this.normSelecRadio.TabIndex = 0;
            this.normSelecRadio.TabStop = true;
            this.normSelecRadio.Text = "Normal selection";
            this.normSelecRadio.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Count";
            // 
            // selectCountBox
            // 
            this.selectCountBox.Location = new System.Drawing.Point(39, 377);
            this.selectCountBox.Name = "selectCountBox";
            this.selectCountBox.Size = new System.Drawing.Size(100, 20);
            this.selectCountBox.TabIndex = 9;
            // 
            // writeSelectionButton
            // 
            this.writeSelectionButton.Location = new System.Drawing.Point(612, 119);
            this.writeSelectionButton.Name = "writeSelectionButton";
            this.writeSelectionButton.Size = new System.Drawing.Size(117, 25);
            this.writeSelectionButton.TabIndex = 10;
            this.writeSelectionButton.Text = "Write selection";
            this.writeSelectionButton.UseVisualStyleBackColor = true;
            this.writeSelectionButton.Click += new System.EventHandler(this.writeSelectionButton_Click);
            // 
            // seriesCriterionButton
            // 
            this.seriesCriterionButton.Location = new System.Drawing.Point(612, 159);
            this.seriesCriterionButton.Name = "seriesCriterionButton";
            this.seriesCriterionButton.Size = new System.Drawing.Size(117, 27);
            this.seriesCriterionButton.TabIndex = 11;
            this.seriesCriterionButton.Text = "Series criterion";
            this.seriesCriterionButton.UseVisualStyleBackColor = true;
            this.seriesCriterionButton.Click += new System.EventHandler(this.seriesCriterionButton_Click);
            // 
            // selectionChart
            // 
            chartArea1.Name = "ChartArea1";
            this.selectionChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.selectionChart.Legends.Add(legend1);
            this.selectionChart.Location = new System.Drawing.Point(12, 12);
            this.selectionChart.Name = "selectionChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.MarkerSize = 3;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series1.Name = "NormalSelection";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.MarkerSize = 3;
            series2.Name = "EquableSelection";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Legend = "Legend1";
            series3.MarkerSize = 3;
            series3.Name = "ExponentalSelection";
            series3.YValuesPerPoint = 2;
            this.selectionChart.Series.Add(series1);
            this.selectionChart.Series.Add(series2);
            this.selectionChart.Series.Add(series3);
            this.selectionChart.Size = new System.Drawing.Size(594, 192);
            this.selectionChart.TabIndex = 12;
            this.selectionChart.Text = "Series Chart";
            // 
            // matWaitingText
            // 
            this.matWaitingText.Location = new System.Drawing.Point(177, 254);
            this.matWaitingText.Name = "matWaitingText";
            this.matWaitingText.Size = new System.Drawing.Size(100, 20);
            this.matWaitingText.TabIndex = 13;
            // 
            // dispersionText
            // 
            this.dispersionText.Location = new System.Drawing.Point(300, 254);
            this.dispersionText.Name = "dispersionText";
            this.dispersionText.Size = new System.Drawing.Size(100, 20);
            this.dispersionText.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Math waiting";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Dispersion";
            // 
            // standartDeviationText
            // 
            this.standartDeviationText.Location = new System.Drawing.Point(177, 307);
            this.standartDeviationText.Name = "standartDeviationText";
            this.standartDeviationText.Size = new System.Drawing.Size(100, 20);
            this.standartDeviationText.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Standard deviation";
            // 
            // StudentCriterionMax
            // 
            this.StudentCriterionMax.Location = new System.Drawing.Point(300, 307);
            this.StudentCriterionMax.Name = "StudentCriterionMax";
            this.StudentCriterionMax.Size = new System.Drawing.Size(100, 20);
            this.StudentCriterionMax.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Student criterion max";
            // 
            // StudentCriterionMin
            // 
            this.StudentCriterionMin.Location = new System.Drawing.Point(431, 254);
            this.StudentCriterionMin.Name = "StudentCriterionMin";
            this.StudentCriterionMin.Size = new System.Drawing.Size(100, 20);
            this.StudentCriterionMin.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(428, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Student criteriom min";
            // 
            // StudentCriterionButton
            // 
            this.StudentCriterionButton.Location = new System.Drawing.Point(612, 208);
            this.StudentCriterionButton.Name = "StudentCriterionButton";
            this.StudentCriterionButton.Size = new System.Drawing.Size(117, 28);
            this.StudentCriterionButton.TabIndex = 23;
            this.StudentCriterionButton.Text = "Student criterion";
            this.StudentCriterionButton.UseVisualStyleBackColor = true;
            this.StudentCriterionButton.Click += new System.EventHandler(this.StudentCriterionButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StudentCriterionButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.StudentCriterionMin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.StudentCriterionMax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.standartDeviationText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dispersionText);
            this.Controls.Add(this.matWaitingText);
            this.Controls.Add(this.selectionChart);
            this.Controls.Add(this.seriesCriterionButton);
            this.Controls.Add(this.writeSelectionButton);
            this.Controls.Add(this.selectCountBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.elemBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minElemBox);
            this.Controls.Add(this.maxElemBox);
            this.Controls.Add(this.findExsistButton);
            this.Controls.Add(this.selecGenButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectionChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selecGenButton;
        private System.Windows.Forms.Button findExsistButton;
        private System.Windows.Forms.TextBox maxElemBox;
        private System.Windows.Forms.TextBox minElemBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox elemBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton equableSelecRadio;
        private System.Windows.Forms.RadioButton exponentSelecRadio;
        private System.Windows.Forms.RadioButton normSelecRadio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox selectCountBox;
        private System.Windows.Forms.Button writeSelectionButton;
        private System.Windows.Forms.Button seriesCriterionButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart selectionChart;
        private System.Windows.Forms.TextBox matWaitingText;
        private System.Windows.Forms.TextBox dispersionText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox standartDeviationText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox StudentCriterionMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox StudentCriterionMin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button StudentCriterionButton;
    }
}


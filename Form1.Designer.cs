
namespace WindowsFormsApp1
{
    partial class Lab1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.edWeight = new System.Windows.Forms.NumericUpDown();
            this.edSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edStep = new System.Windows.Forms.NumericUpDown();
            this.edSpeed = new System.Windows.Forms.NumericUpDown();
            this.edAngle = new System.Windows.Forms.NumericUpDown();
            this.edHeight = new System.Windows.Forms.NumericUpDown();
            this.btStart = new System.Windows.Forms.Button();
            this.Step = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.Label();
            this.Angel = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TableView1 = new System.Windows.Forms.DataGridView();
            this.timeStep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpeedPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.edWeight);
            this.panel1.Controls.Add(this.edSize);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.edStep);
            this.panel1.Controls.Add(this.edSpeed);
            this.panel1.Controls.Add(this.edAngle);
            this.panel1.Controls.Add(this.edHeight);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Controls.Add(this.Step);
            this.panel1.Controls.Add(this.Speed);
            this.panel1.Controls.Add(this.Angel);
            this.panel1.Controls.Add(this.Height);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 136);
            this.panel1.TabIndex = 0;
            // 
            // edWeight
            // 
            this.edWeight.Location = new System.Drawing.Point(389, 52);
            this.edWeight.Name = "edWeight";
            this.edWeight.Size = new System.Drawing.Size(120, 26);
            this.edWeight.TabIndex = 12;
            this.edWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // edSize
            // 
            this.edSize.DecimalPlaces = 2;
            this.edSize.Location = new System.Drawing.Point(389, 14);
            this.edSize.Name = "edSize";
            this.edSize.Size = new System.Drawing.Size(120, 26);
            this.edSize.TabIndex = 11;
            this.edSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Масса";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Размер";
            // 
            // edStep
            // 
            this.edStep.DecimalPlaces = 3;
            this.edStep.Location = new System.Drawing.Point(144, 108);
            this.edStep.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.edStep.Name = "edStep";
            this.edStep.Size = new System.Drawing.Size(120, 26);
            this.edStep.TabIndex = 8;
            this.edStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // edSpeed
            // 
            this.edSpeed.Location = new System.Drawing.Point(144, 75);
            this.edSpeed.Name = "edSpeed";
            this.edSpeed.Size = new System.Drawing.Size(120, 26);
            this.edSpeed.TabIndex = 7;
            this.edSpeed.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // edAngle
            // 
            this.edAngle.Location = new System.Drawing.Point(144, 42);
            this.edAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.edAngle.Name = "edAngle";
            this.edAngle.Size = new System.Drawing.Size(120, 26);
            this.edAngle.TabIndex = 6;
            this.edAngle.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // edHeight
            // 
            this.edHeight.Location = new System.Drawing.Point(144, 9);
            this.edHeight.Name = "edHeight";
            this.edHeight.Size = new System.Drawing.Size(120, 26);
            this.edHeight.TabIndex = 5;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(536, 16);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(160, 77);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "Запуск!";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // Step
            // 
            this.Step.AutoSize = true;
            this.Step.Location = new System.Drawing.Point(25, 105);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(38, 20);
            this.Step.TabIndex = 3;
            this.Step.Text = "Шаг";
            // 
            // Speed
            // 
            this.Speed.AutoSize = true;
            this.Speed.Location = new System.Drawing.Point(25, 69);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(81, 20);
            this.Speed.TabIndex = 2;
            this.Speed.Text = "Скорость";
            // 
            // Angel
            // 
            this.Angel.AutoSize = true;
            this.Angel.Location = new System.Drawing.Point(25, 39);
            this.Angel.Name = "Angel";
            this.Angel.Size = new System.Drawing.Size(45, 20);
            this.Angel.TabIndex = 1;
            this.Angel.Text = "Угол";
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Location = new System.Drawing.Point(25, 9);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(66, 20);
            this.Height.TabIndex = 0;
            this.Height.Text = "Высота";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
            this.chart1.Location = new System.Drawing.Point(0, 136);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Name = "Series1";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Name = "Series2";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Name = "Series3";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Name = "Series4";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(1063, 418);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "Graphic";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TableView1
            // 
            this.TableView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TableView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeStep,
            this.Distance,
            this.maxHeight,
            this.SpeedPoint});
            this.TableView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.TableView1.Location = new System.Drawing.Point(0, 554);
            this.TableView1.Name = "TableView1";
            this.TableView1.RowHeadersWidth = 62;
            this.TableView1.RowTemplate.Height = 28;
            this.TableView1.Size = new System.Drawing.Size(1063, 150);
            this.TableView1.TabIndex = 13;
            // 
            // timeStep
            // 
            this.timeStep.HeaderText = "Time Step";
            this.timeStep.MinimumWidth = 8;
            this.timeStep.Name = "timeStep";
            this.timeStep.Width = 150;
            // 
            // Distance
            // 
            this.Distance.HeaderText = "Distance";
            this.Distance.MinimumWidth = 8;
            this.Distance.Name = "Distance";
            this.Distance.Width = 150;
            // 
            // maxHeight
            // 
            this.maxHeight.HeaderText = "Max Height";
            this.maxHeight.MinimumWidth = 8;
            this.maxHeight.Name = "maxHeight";
            this.maxHeight.Width = 150;
            // 
            // SpeedPoint
            // 
            this.SpeedPoint.HeaderText = "Speed at the end point";
            this.SpeedPoint.MinimumWidth = 8;
            this.SpeedPoint.Name = "SpeedPoint";
            this.SpeedPoint.Width = 150;
            // 
            // Lab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 704);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TableView1);
            this.Name = "Lab1";
            this.Text = "Lab1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Speed;
        private System.Windows.Forms.Label Angel;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label Step;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown edStep;
        private System.Windows.Forms.NumericUpDown edSpeed;
        private System.Windows.Forms.NumericUpDown edAngle;
        private System.Windows.Forms.NumericUpDown edHeight;
        private System.Windows.Forms.NumericUpDown edWeight;
        private System.Windows.Forms.NumericUpDown edSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView TableView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distance;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpeedPoint;
    }
}


namespace Lab1
{
    partial class OptimisationMethods
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
            this.tabControlMethods = new System.Windows.Forms.TabControl();
            this.tabPageBisection = new System.Windows.Forms.TabPage();
            this.buttonBfind = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBepsilon = new System.Windows.Forms.TextBox();
            this.textBoxDelta = new System.Windows.Forms.TextBox();
            this.tabPageGoldenSection = new System.Windows.Forms.TabPage();
            this.buttonGSfind = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxGSepsilon = new System.Windows.Forms.TextBox();
            this.tabPageParabols = new System.Windows.Forms.TabPage();
            this.buttonParabolas = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPEpsilon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFunc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxFmin = new System.Windows.Forms.TextBox();
            this.chart = new ZedGraph.ZedGraphControl();
            this.tabControlMethods.SuspendLayout();
            this.tabPageBisection.SuspendLayout();
            this.tabPageGoldenSection.SuspendLayout();
            this.tabPageParabols.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMethods
            // 
            this.tabControlMethods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMethods.Controls.Add(this.tabPageBisection);
            this.tabControlMethods.Controls.Add(this.tabPageGoldenSection);
            this.tabControlMethods.Controls.Add(this.tabPageParabols);
            this.tabControlMethods.Location = new System.Drawing.Point(0, 60);
            this.tabControlMethods.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlMethods.Name = "tabControlMethods";
            this.tabControlMethods.SelectedIndex = 0;
            this.tabControlMethods.Size = new System.Drawing.Size(710, 74);
            this.tabControlMethods.TabIndex = 0;
            // 
            // tabPageBisection
            // 
            this.tabPageBisection.Controls.Add(this.buttonBfind);
            this.tabPageBisection.Controls.Add(this.label6);
            this.tabPageBisection.Controls.Add(this.label5);
            this.tabPageBisection.Controls.Add(this.textBoxBepsilon);
            this.tabPageBisection.Controls.Add(this.textBoxDelta);
            this.tabPageBisection.Location = new System.Drawing.Point(4, 22);
            this.tabPageBisection.Name = "tabPageBisection";
            this.tabPageBisection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBisection.Size = new System.Drawing.Size(702, 48);
            this.tabPageBisection.TabIndex = 0;
            this.tabPageBisection.Text = "Метод деления отрезка пополам";
            this.tabPageBisection.UseVisualStyleBackColor = true;
            // 
            // buttonBfind
            // 
            this.buttonBfind.Location = new System.Drawing.Point(190, 14);
            this.buttonBfind.Name = "buttonBfind";
            this.buttonBfind.Size = new System.Drawing.Size(108, 23);
            this.buttonBfind.TabIndex = 5;
            this.buttonBfind.Text = "Искать корень";
            this.buttonBfind.UseVisualStyleBackColor = true;
            this.buttonBfind.Click += new System.EventHandler(this.buttonBfind_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(95, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "ε =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(8, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "δ =";
            // 
            // textBoxBepsilon
            // 
            this.textBoxBepsilon.Location = new System.Drawing.Point(125, 16);
            this.textBoxBepsilon.Name = "textBoxBepsilon";
            this.textBoxBepsilon.Size = new System.Drawing.Size(43, 20);
            this.textBoxBepsilon.TabIndex = 4;
            // 
            // textBoxDelta
            // 
            this.textBoxDelta.Location = new System.Drawing.Point(38, 15);
            this.textBoxDelta.Name = "textBoxDelta";
            this.textBoxDelta.Size = new System.Drawing.Size(43, 20);
            this.textBoxDelta.TabIndex = 4;
            // 
            // tabPageGoldenSection
            // 
            this.tabPageGoldenSection.Controls.Add(this.buttonGSfind);
            this.tabPageGoldenSection.Controls.Add(this.label7);
            this.tabPageGoldenSection.Controls.Add(this.textBoxGSepsilon);
            this.tabPageGoldenSection.Location = new System.Drawing.Point(4, 22);
            this.tabPageGoldenSection.Name = "tabPageGoldenSection";
            this.tabPageGoldenSection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGoldenSection.Size = new System.Drawing.Size(702, 48);
            this.tabPageGoldenSection.TabIndex = 1;
            this.tabPageGoldenSection.Text = "Метод золотого сечения";
            this.tabPageGoldenSection.UseVisualStyleBackColor = true;
            // 
            // buttonGSfind
            // 
            this.buttonGSfind.Location = new System.Drawing.Point(103, 14);
            this.buttonGSfind.Name = "buttonGSfind";
            this.buttonGSfind.Size = new System.Drawing.Size(108, 23);
            this.buttonGSfind.TabIndex = 8;
            this.buttonGSfind.Text = "Искать корень";
            this.buttonGSfind.UseVisualStyleBackColor = true;
            this.buttonGSfind.Click += new System.EventHandler(this.buttonGSfind_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(8, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "ε =";
            // 
            // textBoxGSepsilon
            // 
            this.textBoxGSepsilon.Location = new System.Drawing.Point(38, 16);
            this.textBoxGSepsilon.Name = "textBoxGSepsilon";
            this.textBoxGSepsilon.Size = new System.Drawing.Size(43, 20);
            this.textBoxGSepsilon.TabIndex = 7;
            // 
            // tabPageParabols
            // 
            this.tabPageParabols.Controls.Add(this.buttonParabolas);
            this.tabPageParabols.Controls.Add(this.label8);
            this.tabPageParabols.Controls.Add(this.textBoxPEpsilon);
            this.tabPageParabols.Location = new System.Drawing.Point(4, 22);
            this.tabPageParabols.Name = "tabPageParabols";
            this.tabPageParabols.Size = new System.Drawing.Size(702, 48);
            this.tabPageParabols.TabIndex = 2;
            this.tabPageParabols.Text = "Метод парабол";
            this.tabPageParabols.UseVisualStyleBackColor = true;
            // 
            // buttonParabolas
            // 
            this.buttonParabolas.Location = new System.Drawing.Point(103, 14);
            this.buttonParabolas.Name = "buttonParabolas";
            this.buttonParabolas.Size = new System.Drawing.Size(108, 23);
            this.buttonParabolas.TabIndex = 8;
            this.buttonParabolas.Text = "Искать корень";
            this.buttonParabolas.UseVisualStyleBackColor = true;
            this.buttonParabolas.Click += new System.EventHandler(this.buttonParabolas_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(8, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "ε =";
            // 
            // textBoxPEpsilon
            // 
            this.textBoxPEpsilon.Location = new System.Drawing.Point(38, 16);
            this.textBoxPEpsilon.Name = "textBoxPEpsilon";
            this.textBoxPEpsilon.Size = new System.Drawing.Size(43, 20);
            this.textBoxPEpsilon.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "f(x) =";
            // 
            // textBoxFunc
            // 
            this.textBoxFunc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFunc.Location = new System.Drawing.Point(42, 6);
            this.textBoxFunc.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.textBoxFunc.Name = "textBoxFunc";
            this.textBoxFunc.Size = new System.Drawing.Size(656, 20);
            this.textBoxFunc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Отрезок: [";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(77, 37);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(43, 20);
            this.textBoxA.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = ",";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(142, 37);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(43, 20);
            this.textBoxB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "min = ";
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(42, 137);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.ReadOnly = true;
            this.textBoxMin.Size = new System.Drawing.Size(94, 20);
            this.textBoxMin.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "f(min) = ";
            // 
            // textBoxFmin
            // 
            this.textBoxFmin.Location = new System.Drawing.Point(52, 163);
            this.textBoxFmin.Name = "textBoxFmin";
            this.textBoxFmin.ReadOnly = true;
            this.textBoxFmin.Size = new System.Drawing.Size(84, 20);
            this.textBoxFmin.TabIndex = 4;
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart.IsShowPointValues = false;
            this.chart.Location = new System.Drawing.Point(142, 136);
            this.chart.Name = "chart";
            this.chart.PointValueFormat = "G";
            this.chart.Size = new System.Drawing.Size(556, 403);
            this.chart.TabIndex = 5;
            // 
            // OptimisationMethods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 551);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxFmin);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFunc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControlMethods);
            this.MaximizeBox = false;
            this.Name = "OptimisationMethods";
            this.Text = "Методы оптимизации";
            this.tabControlMethods.ResumeLayout(false);
            this.tabPageBisection.ResumeLayout(false);
            this.tabPageBisection.PerformLayout();
            this.tabPageGoldenSection.ResumeLayout(false);
            this.tabPageGoldenSection.PerformLayout();
            this.tabPageParabols.ResumeLayout(false);
            this.tabPageParabols.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMethods;
        private System.Windows.Forms.TabPage tabPageBisection;
        private System.Windows.Forms.TabPage tabPageGoldenSection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFunc;
        private System.Windows.Forms.Button buttonBfind;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBepsilon;
        private System.Windows.Forms.TextBox textBoxDelta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageParabols;
        private System.Windows.Forms.Button buttonGSfind;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxGSepsilon;
        private System.Windows.Forms.Button buttonParabolas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPEpsilon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxFmin;
        private ZedGraph.ZedGraphControl chart;
    }
}


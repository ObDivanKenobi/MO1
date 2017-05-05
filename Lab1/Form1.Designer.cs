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
            this.tabControlOneDimentionalMethods = new System.Windows.Forms.TabControl();
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
            this.tabControlMethods = new System.Windows.Forms.TabControl();
            this.tabPageOneDImentional = new System.Windows.Forms.TabPage();
            this.tabPageMultidimentionalMethods = new System.Windows.Forms.TabPage();
            this.buttonMillingStepsMethod = new System.Windows.Forms.Button();
            this.buttonNewtonsMethod = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxEpsilonMultidimentional = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridViewVariables = new System.Windows.Forms.DataGridView();
            this.Variable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageNewton = new System.Windows.Forms.TabPage();
            this.buttonSingledimantionalNewtonsMethod = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxNewtonEpsilon = new System.Windows.Forms.TextBox();
            this.textBoxNewtonsX = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxMultidimentionalFx = new System.Windows.Forms.TextBox();
            this.textBoxMultidimentionalX = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonSpeedestDescent = new System.Windows.Forms.Button();
            this.tabControlOneDimentionalMethods.SuspendLayout();
            this.tabPageBisection.SuspendLayout();
            this.tabPageGoldenSection.SuspendLayout();
            this.tabPageParabols.SuspendLayout();
            this.tabControlMethods.SuspendLayout();
            this.tabPageOneDImentional.SuspendLayout();
            this.tabPageMultidimentionalMethods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVariables)).BeginInit();
            this.tabPageNewton.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlOneDimentionalMethods
            // 
            this.tabControlOneDimentionalMethods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlOneDimentionalMethods.Controls.Add(this.tabPageBisection);
            this.tabControlOneDimentionalMethods.Controls.Add(this.tabPageGoldenSection);
            this.tabControlOneDimentionalMethods.Controls.Add(this.tabPageParabols);
            this.tabControlOneDimentionalMethods.Controls.Add(this.tabPageNewton);
            this.tabControlOneDimentionalMethods.Location = new System.Drawing.Point(6, 39);
            this.tabControlOneDimentionalMethods.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlOneDimentionalMethods.Name = "tabControlOneDimentionalMethods";
            this.tabControlOneDimentionalMethods.SelectedIndex = 0;
            this.tabControlOneDimentionalMethods.Size = new System.Drawing.Size(914, 74);
            this.tabControlOneDimentionalMethods.TabIndex = 3;
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
            this.tabPageBisection.Size = new System.Drawing.Size(906, 48);
            this.tabPageBisection.TabIndex = 0;
            this.tabPageBisection.Text = "Метод деления отрезка пополам";
            this.tabPageBisection.UseVisualStyleBackColor = true;
            // 
            // buttonBfind
            // 
            this.buttonBfind.Location = new System.Drawing.Point(190, 14);
            this.buttonBfind.Name = "buttonBfind";
            this.buttonBfind.Size = new System.Drawing.Size(108, 23);
            this.buttonBfind.TabIndex = 3;
            this.buttonBfind.Text = "Искать минимум";
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
            this.textBoxBepsilon.TabIndex = 2;
            this.textBoxBepsilon.Leave += new System.EventHandler(this.ReplacingDots);
            // 
            // textBoxDelta
            // 
            this.textBoxDelta.Location = new System.Drawing.Point(38, 15);
            this.textBoxDelta.Name = "textBoxDelta";
            this.textBoxDelta.Size = new System.Drawing.Size(43, 20);
            this.textBoxDelta.TabIndex = 1;
            this.textBoxDelta.Leave += new System.EventHandler(this.ReplacingDots);
            // 
            // tabPageGoldenSection
            // 
            this.tabPageGoldenSection.Controls.Add(this.buttonGSfind);
            this.tabPageGoldenSection.Controls.Add(this.label7);
            this.tabPageGoldenSection.Controls.Add(this.textBoxGSepsilon);
            this.tabPageGoldenSection.Location = new System.Drawing.Point(4, 22);
            this.tabPageGoldenSection.Name = "tabPageGoldenSection";
            this.tabPageGoldenSection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGoldenSection.Size = new System.Drawing.Size(906, 48);
            this.tabPageGoldenSection.TabIndex = 1;
            this.tabPageGoldenSection.Text = "Метод золотого сечения";
            this.tabPageGoldenSection.UseVisualStyleBackColor = true;
            // 
            // buttonGSfind
            // 
            this.buttonGSfind.Location = new System.Drawing.Point(103, 14);
            this.buttonGSfind.Name = "buttonGSfind";
            this.buttonGSfind.Size = new System.Drawing.Size(108, 23);
            this.buttonGSfind.TabIndex = 2;
            this.buttonGSfind.Text = "Искать минимум";
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
            this.textBoxGSepsilon.TabIndex = 1;
            this.textBoxGSepsilon.Leave += new System.EventHandler(this.ReplacingDots);
            // 
            // tabPageParabols
            // 
            this.tabPageParabols.Controls.Add(this.buttonParabolas);
            this.tabPageParabols.Controls.Add(this.label8);
            this.tabPageParabols.Controls.Add(this.textBoxPEpsilon);
            this.tabPageParabols.Location = new System.Drawing.Point(4, 22);
            this.tabPageParabols.Name = "tabPageParabols";
            this.tabPageParabols.Size = new System.Drawing.Size(906, 48);
            this.tabPageParabols.TabIndex = 2;
            this.tabPageParabols.Text = "Метод парабол";
            this.tabPageParabols.UseVisualStyleBackColor = true;
            // 
            // buttonParabolas
            // 
            this.buttonParabolas.Location = new System.Drawing.Point(103, 14);
            this.buttonParabolas.Name = "buttonParabolas";
            this.buttonParabolas.Size = new System.Drawing.Size(108, 23);
            this.buttonParabolas.TabIndex = 2;
            this.buttonParabolas.Text = "Искать минимум";
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
            this.textBoxPEpsilon.TabIndex = 1;
            this.textBoxPEpsilon.Leave += new System.EventHandler(this.ReplacingDots);
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
            this.textBoxFunc.Size = new System.Drawing.Size(907, 20);
            this.textBoxFunc.TabIndex = 0;
            this.textBoxFunc.Leave += new System.EventHandler(this.ParseExpression);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Отрезок: [";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(71, 14);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(43, 20);
            this.textBoxA.TabIndex = 1;
            this.textBoxA.Leave += new System.EventHandler(this.ReplacingDots);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = ",";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(136, 14);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(43, 20);
            this.textBoxB.TabIndex = 2;
            this.textBoxB.Leave += new System.EventHandler(this.ReplacingDots);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "min = ";
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(39, 116);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.ReadOnly = true;
            this.textBoxMin.Size = new System.Drawing.Size(94, 20);
            this.textBoxMin.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "f(min) = ";
            // 
            // textBoxFmin
            // 
            this.textBoxFmin.Location = new System.Drawing.Point(49, 142);
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
            this.chart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chart.IsShowPointValues = false;
            this.chart.Location = new System.Drawing.Point(294, 115);
            this.chart.Name = "chart";
            this.chart.PointValueFormat = "G";
            this.chart.Size = new System.Drawing.Size(622, 359);
            this.chart.TabIndex = 5;
            // 
            // tabControlMethods
            // 
            this.tabControlMethods.Controls.Add(this.tabPageOneDImentional);
            this.tabControlMethods.Controls.Add(this.tabPageMultidimentionalMethods);
            this.tabControlMethods.Location = new System.Drawing.Point(15, 32);
            this.tabControlMethods.Name = "tabControlMethods";
            this.tabControlMethods.SelectedIndex = 0;
            this.tabControlMethods.Size = new System.Drawing.Size(934, 507);
            this.tabControlMethods.TabIndex = 1;
            // 
            // tabPageOneDImentional
            // 
            this.tabPageOneDImentional.Controls.Add(this.tabControlOneDimentionalMethods);
            this.tabPageOneDImentional.Controls.Add(this.textBoxFmin);
            this.tabPageOneDImentional.Controls.Add(this.chart);
            this.tabPageOneDImentional.Controls.Add(this.textBoxMin);
            this.tabPageOneDImentional.Controls.Add(this.label10);
            this.tabPageOneDImentional.Controls.Add(this.label2);
            this.tabPageOneDImentional.Controls.Add(this.label9);
            this.tabPageOneDImentional.Controls.Add(this.textBoxB);
            this.tabPageOneDImentional.Controls.Add(this.label4);
            this.tabPageOneDImentional.Controls.Add(this.label3);
            this.tabPageOneDImentional.Controls.Add(this.textBoxA);
            this.tabPageOneDImentional.Location = new System.Drawing.Point(4, 22);
            this.tabPageOneDImentional.Name = "tabPageOneDImentional";
            this.tabPageOneDImentional.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOneDImentional.Size = new System.Drawing.Size(926, 481);
            this.tabPageOneDImentional.TabIndex = 0;
            this.tabPageOneDImentional.Text = "Одномерная оптимизация";
            this.tabPageOneDImentional.UseVisualStyleBackColor = true;
            // 
            // tabPageMultidimentionalMethods
            // 
            this.tabPageMultidimentionalMethods.Controls.Add(this.buttonSpeedestDescent);
            this.tabPageMultidimentionalMethods.Controls.Add(this.textBoxMultidimentionalFx);
            this.tabPageMultidimentionalMethods.Controls.Add(this.textBoxMultidimentionalX);
            this.tabPageMultidimentionalMethods.Controls.Add(this.label15);
            this.tabPageMultidimentionalMethods.Controls.Add(this.label16);
            this.tabPageMultidimentionalMethods.Controls.Add(this.buttonMillingStepsMethod);
            this.tabPageMultidimentionalMethods.Controls.Add(this.buttonNewtonsMethod);
            this.tabPageMultidimentionalMethods.Controls.Add(this.label12);
            this.tabPageMultidimentionalMethods.Controls.Add(this.textBoxEpsilonMultidimentional);
            this.tabPageMultidimentionalMethods.Controls.Add(this.label11);
            this.tabPageMultidimentionalMethods.Controls.Add(this.dataGridViewVariables);
            this.tabPageMultidimentionalMethods.Location = new System.Drawing.Point(4, 22);
            this.tabPageMultidimentionalMethods.Name = "tabPageMultidimentionalMethods";
            this.tabPageMultidimentionalMethods.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMultidimentionalMethods.Size = new System.Drawing.Size(926, 481);
            this.tabPageMultidimentionalMethods.TabIndex = 1;
            this.tabPageMultidimentionalMethods.Text = "Многомерная оптимизация";
            this.tabPageMultidimentionalMethods.UseVisualStyleBackColor = true;
            this.tabPageMultidimentionalMethods.Enter += new System.EventHandler(this.tabPageMultidimantionalMethods_Enter);
            this.tabPageMultidimentionalMethods.Leave += new System.EventHandler(this.tabPageMultidimantionalMethods_Enter);
            // 
            // buttonMillingStepsMethod
            // 
            this.buttonMillingStepsMethod.Location = new System.Drawing.Point(432, 16);
            this.buttonMillingStepsMethod.Name = "buttonMillingStepsMethod";
            this.buttonMillingStepsMethod.Size = new System.Drawing.Size(159, 23);
            this.buttonMillingStepsMethod.TabIndex = 3;
            this.buttonMillingStepsMethod.Text = "Метод дробления шага";
            this.buttonMillingStepsMethod.UseVisualStyleBackColor = true;
            this.buttonMillingStepsMethod.Click += new System.EventHandler(this.buttonMillingStepsMethod_Click);
            // 
            // buttonNewtonsMethod
            // 
            this.buttonNewtonsMethod.Location = new System.Drawing.Point(284, 17);
            this.buttonNewtonsMethod.Name = "buttonNewtonsMethod";
            this.buttonNewtonsMethod.Size = new System.Drawing.Size(142, 23);
            this.buttonNewtonsMethod.TabIndex = 2;
            this.buttonNewtonsMethod.Text = "Метод Ньютона";
            this.buttonNewtonsMethod.UseVisualStyleBackColor = true;
            this.buttonNewtonsMethod.Click += new System.EventHandler(this.buttonNewtonsMethod_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(190, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 18);
            this.label12.TabIndex = 8;
            this.label12.Text = "ε =";
            // 
            // textBoxEpsilonMultidimentional
            // 
            this.textBoxEpsilonMultidimentional.Location = new System.Drawing.Point(220, 19);
            this.textBoxEpsilonMultidimentional.Name = "textBoxEpsilonMultidimentional";
            this.textBoxEpsilonMultidimentional.Size = new System.Drawing.Size(43, 20);
            this.textBoxEpsilonMultidimentional.TabIndex = 1;
            this.textBoxEpsilonMultidimentional.Leave += new System.EventHandler(this.ReplacingDots);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Начальная точка:";
            // 
            // dataGridViewVariables
            // 
            this.dataGridViewVariables.AllowUserToAddRows = false;
            this.dataGridViewVariables.AllowUserToDeleteRows = false;
            this.dataGridViewVariables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVariables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Variable,
            this.Value});
            this.dataGridViewVariables.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewVariables.Name = "dataGridViewVariables";
            this.dataGridViewVariables.RowHeadersVisible = false;
            this.dataGridViewVariables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVariables.Size = new System.Drawing.Size(162, 456);
            this.dataGridViewVariables.TabIndex = 0;
            // 
            // Variable
            // 
            this.Variable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Variable.HeaderText = "Переменная";
            this.Variable.Name = "Variable";
            this.Variable.ReadOnly = true;
            this.Variable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Variable.Width = 77;
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Value.HeaderText = "Значение";
            this.Value.Name = "Value";
            this.Value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tabPageNewton
            // 
            this.tabPageNewton.Controls.Add(this.buttonSingledimantionalNewtonsMethod);
            this.tabPageNewton.Controls.Add(this.label14);
            this.tabPageNewton.Controls.Add(this.label13);
            this.tabPageNewton.Controls.Add(this.textBoxNewtonsX);
            this.tabPageNewton.Controls.Add(this.textBoxNewtonEpsilon);
            this.tabPageNewton.Location = new System.Drawing.Point(4, 22);
            this.tabPageNewton.Name = "tabPageNewton";
            this.tabPageNewton.Size = new System.Drawing.Size(906, 48);
            this.tabPageNewton.TabIndex = 3;
            this.tabPageNewton.Text = "Метод Ньютона";
            this.tabPageNewton.UseVisualStyleBackColor = true;
            // 
            // buttonSingledimantionalNewtonsMethod
            // 
            this.buttonSingledimantionalNewtonsMethod.Location = new System.Drawing.Point(194, 12);
            this.buttonSingledimantionalNewtonsMethod.Name = "buttonSingledimantionalNewtonsMethod";
            this.buttonSingledimantionalNewtonsMethod.Size = new System.Drawing.Size(108, 23);
            this.buttonSingledimantionalNewtonsMethod.TabIndex = 3;
            this.buttonSingledimantionalNewtonsMethod.Text = "Искать минимум";
            this.buttonSingledimantionalNewtonsMethod.UseVisualStyleBackColor = true;
            this.buttonSingledimantionalNewtonsMethod.Click += new System.EventHandler(this.buttonSingledimantionalNewtonsMethod_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(9, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 18);
            this.label13.TabIndex = 6;
            this.label13.Text = "ε =";
            // 
            // textBoxNewtonEpsilon
            // 
            this.textBoxNewtonEpsilon.Location = new System.Drawing.Point(39, 14);
            this.textBoxNewtonEpsilon.Name = "textBoxNewtonEpsilon";
            this.textBoxNewtonEpsilon.Size = new System.Drawing.Size(43, 20);
            this.textBoxNewtonEpsilon.TabIndex = 1;
            this.textBoxNewtonEpsilon.Leave += new System.EventHandler(this.ReplacingDots);
            // 
            // textBoxNewtonsX
            // 
            this.textBoxNewtonsX.Location = new System.Drawing.Point(142, 14);
            this.textBoxNewtonsX.Name = "textBoxNewtonsX";
            this.textBoxNewtonsX.Size = new System.Drawing.Size(43, 20);
            this.textBoxNewtonsX.TabIndex = 2;
            this.textBoxNewtonsX.Leave += new System.EventHandler(this.ReplacingDots);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(96, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 18);
            this.label14.TabIndex = 6;
            this.label14.Text = "x_0 =";
            // 
            // textBoxMultidimentionalFx
            // 
            this.textBoxMultidimentionalFx.Location = new System.Drawing.Point(231, 92);
            this.textBoxMultidimentionalFx.Name = "textBoxMultidimentionalFx";
            this.textBoxMultidimentionalFx.ReadOnly = true;
            this.textBoxMultidimentionalFx.Size = new System.Drawing.Size(84, 20);
            this.textBoxMultidimentionalFx.TabIndex = 11;
            // 
            // textBoxMultidimentionalX
            // 
            this.textBoxMultidimentionalX.Location = new System.Drawing.Point(221, 66);
            this.textBoxMultidimentionalX.Name = "textBoxMultidimentionalX";
            this.textBoxMultidimentionalX.ReadOnly = true;
            this.textBoxMultidimentionalX.Size = new System.Drawing.Size(699, 20);
            this.textBoxMultidimentionalX.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(191, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "f(min) = ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(191, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "min = ";
            // 
            // buttonSpeedestDescent
            // 
            this.buttonSpeedestDescent.Location = new System.Drawing.Point(597, 16);
            this.buttonSpeedestDescent.Name = "buttonSpeedestDescent";
            this.buttonSpeedestDescent.Size = new System.Drawing.Size(187, 23);
            this.buttonSpeedestDescent.TabIndex = 4;
            this.buttonSpeedestDescent.Text = "Метод наискорейшего спуска";
            this.buttonSpeedestDescent.UseVisualStyleBackColor = true;
            this.buttonSpeedestDescent.Click += new System.EventHandler(this.buttonSpeedestDescentMethod_Click);
            // 
            // OptimisationMethods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 551);
            this.Controls.Add(this.tabControlMethods);
            this.Controls.Add(this.textBoxFunc);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "OptimisationMethods";
            this.Text = "Методы оптимизации";
            this.tabControlOneDimentionalMethods.ResumeLayout(false);
            this.tabPageBisection.ResumeLayout(false);
            this.tabPageBisection.PerformLayout();
            this.tabPageGoldenSection.ResumeLayout(false);
            this.tabPageGoldenSection.PerformLayout();
            this.tabPageParabols.ResumeLayout(false);
            this.tabPageParabols.PerformLayout();
            this.tabControlMethods.ResumeLayout(false);
            this.tabPageOneDImentional.ResumeLayout(false);
            this.tabPageOneDImentional.PerformLayout();
            this.tabPageMultidimentionalMethods.ResumeLayout(false);
            this.tabPageMultidimentionalMethods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVariables)).EndInit();
            this.tabPageNewton.ResumeLayout(false);
            this.tabPageNewton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlOneDimentionalMethods;
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
        private System.Windows.Forms.TabControl tabControlMethods;
        private System.Windows.Forms.TabPage tabPageOneDImentional;
        private System.Windows.Forms.TabPage tabPageMultidimentionalMethods;
        private System.Windows.Forms.DataGridView dataGridViewVariables;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Variable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxEpsilonMultidimentional;
        private System.Windows.Forms.Button buttonNewtonsMethod;
        private System.Windows.Forms.Button buttonMillingStepsMethod;
        private System.Windows.Forms.TabPage tabPageNewton;
        private System.Windows.Forms.Button buttonSingledimantionalNewtonsMethod;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxNewtonEpsilon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxNewtonsX;
        private System.Windows.Forms.TextBox textBoxMultidimentionalFx;
        private System.Windows.Forms.TextBox textBoxMultidimentionalX;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonSpeedestDescent;
    }
}


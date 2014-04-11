namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.краткийОтчётОВыборкеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётОВсехВыборкахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сравнениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxSel = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRemoveSel = new System.Windows.Forms.Button();
            this.buttonEditSel = new System.Windows.Forms.Button();
            this.buttonNewSel = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.labelNameOfSel = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelTypeOfLeafs = new System.Windows.Forms.Label();
            this.labelGradeValue = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelCommentValue = new System.Windows.Forms.Label();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelPlaceValue = new System.Windows.Forms.Label();
            this.labelComment = new System.Windows.Forms.Label();
            this.labelDateValue = new System.Windows.Forms.Label();
            this.labelGrade = new System.Windows.Forms.Label();
            this.labelTypeOfLeafsValue = new System.Windows.Forms.Label();
            this.labelNameOfSelValue = new System.Windows.Forms.Label();
            this.labelCountValue = new System.Windows.Forms.Label();
            this.labelQuality = new System.Windows.Forms.Label();
            this.labelQualityValue = new System.Windows.Forms.Label();
            this.labelSigma = new System.Windows.Forms.Label();
            this.labelSigmaValue = new System.Windows.Forms.Label();
            this.comboBoxSels = new System.Windows.Forms.ComboBox();
            this.groupBoxLeaf = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAddLeaf = new System.Windows.Forms.Button();
            this.buttonEditLeaf = new System.Windows.Forms.Button();
            this.buttonRemoveLeaf = new System.Windows.Forms.Button();
            this.dataGridViewLeafs = new System.Windows.Forms.DataGridView();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBoxSel.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBoxLeaf.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeafs)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.отчётыToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(362, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.краткийОтчётОВыборкеToolStripMenuItem,
            this.отчётОВсехВыборкахToolStripMenuItem,
            this.сравнениеToolStripMenuItem});
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.отчётыToolStripMenuItem.Text = "Дополнительно";
            // 
            // краткийОтчётОВыборкеToolStripMenuItem
            // 
            this.краткийОтчётОВыборкеToolStripMenuItem.Name = "краткийОтчётОВыборкеToolStripMenuItem";
            this.краткийОтчётОВыборкеToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.краткийОтчётОВыборкеToolStripMenuItem.Text = "Отчёт о текущей выборке";
            this.краткийОтчётОВыборкеToolStripMenuItem.Click += new System.EventHandler(this.краткийОтчётОВыборкеToolStripMenuItem_Click);
            // 
            // отчётОВсехВыборкахToolStripMenuItem
            // 
            this.отчётОВсехВыборкахToolStripMenuItem.Name = "отчётОВсехВыборкахToolStripMenuItem";
            this.отчётОВсехВыборкахToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.отчётОВсехВыборкахToolStripMenuItem.Text = "Отчёт о всех выборках";
            // 
            // сравнениеToolStripMenuItem
            // 
            this.сравнениеToolStripMenuItem.Name = "сравнениеToolStripMenuItem";
            this.сравнениеToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.сравнениеToolStripMenuItem.Text = "Сравнение";
            this.сравнениеToolStripMenuItem.Click += new System.EventHandler(this.сравнениеToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // groupBoxSel
            // 
            this.groupBoxSel.Controls.Add(this.tableLayoutPanel4);
            this.groupBoxSel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSel.Enabled = false;
            this.groupBoxSel.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSel.Name = "groupBoxSel";
            this.groupBoxSel.Size = new System.Drawing.Size(356, 263);
            this.groupBoxSel.TabIndex = 14;
            this.groupBoxSel.TabStop = false;
            this.groupBoxSel.Text = "Выборки";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.comboBoxSels, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(350, 244);
            this.tableLayoutPanel4.TabIndex = 29;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.buttonRemoveSel, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.buttonEditSel, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.buttonNewSel, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(344, 29);
            this.tableLayoutPanel5.TabIndex = 30;
            // 
            // buttonRemoveSel
            // 
            this.buttonRemoveSel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRemoveSel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveSel.Location = new System.Drawing.Point(231, 3);
            this.buttonRemoveSel.Name = "buttonRemoveSel";
            this.buttonRemoveSel.Size = new System.Drawing.Size(110, 23);
            this.buttonRemoveSel.TabIndex = 21;
            this.buttonRemoveSel.Text = "Удалить";
            this.buttonRemoveSel.UseVisualStyleBackColor = true;
            this.buttonRemoveSel.Click += new System.EventHandler(this.buttonRemoveSel_Click);
            // 
            // buttonEditSel
            // 
            this.buttonEditSel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEditSel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditSel.Location = new System.Drawing.Point(117, 3);
            this.buttonEditSel.Name = "buttonEditSel";
            this.buttonEditSel.Size = new System.Drawing.Size(108, 23);
            this.buttonEditSel.TabIndex = 20;
            this.buttonEditSel.Text = "Изменить";
            this.buttonEditSel.UseVisualStyleBackColor = true;
            this.buttonEditSel.Click += new System.EventHandler(this.buttonEditSel_Click);
            // 
            // buttonNewSel
            // 
            this.buttonNewSel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNewSel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewSel.Location = new System.Drawing.Point(3, 3);
            this.buttonNewSel.Name = "buttonNewSel";
            this.buttonNewSel.Size = new System.Drawing.Size(108, 23);
            this.buttonNewSel.TabIndex = 19;
            this.buttonNewSel.Text = "Новая выборка";
            this.buttonNewSel.UseVisualStyleBackColor = true;
            this.buttonNewSel.Click += new System.EventHandler(this.buttonNewSel_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.labelNameOfSel, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.labelCount, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.labelTypeOfLeafs, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.labelGradeValue, 1, 6);
            this.tableLayoutPanel6.Controls.Add(this.labelDate, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.labelCommentValue, 1, 5);
            this.tableLayoutPanel6.Controls.Add(this.labelPlace, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.labelPlaceValue, 1, 4);
            this.tableLayoutPanel6.Controls.Add(this.labelComment, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.labelDateValue, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.labelGrade, 0, 6);
            this.tableLayoutPanel6.Controls.Add(this.labelTypeOfLeafsValue, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.labelNameOfSelValue, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.labelCountValue, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.labelQuality, 0, 7);
            this.tableLayoutPanel6.Controls.Add(this.labelQualityValue, 1, 7);
            this.tableLayoutPanel6.Controls.Add(this.labelSigma, 0, 8);
            this.tableLayoutPanel6.Controls.Add(this.labelSigmaValue, 1, 8);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 73);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 9;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(344, 168);
            this.tableLayoutPanel6.TabIndex = 31;
            // 
            // labelNameOfSel
            // 
            this.labelNameOfSel.AutoSize = true;
            this.labelNameOfSel.Location = new System.Drawing.Point(3, 0);
            this.labelNameOfSel.Name = "labelNameOfSel";
            this.labelNameOfSel.Size = new System.Drawing.Size(63, 13);
            this.labelNameOfSel.TabIndex = 12;
            this.labelNameOfSel.Text = "Название: ";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(3, 15);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(110, 13);
            this.labelCount.TabIndex = 13;
            this.labelCount.Text = "Количество листьев";
            // 
            // labelTypeOfLeafs
            // 
            this.labelTypeOfLeafs.AutoSize = true;
            this.labelTypeOfLeafs.Location = new System.Drawing.Point(3, 30);
            this.labelTypeOfLeafs.Name = "labelTypeOfLeafs";
            this.labelTypeOfLeafs.Size = new System.Drawing.Size(76, 13);
            this.labelTypeOfLeafs.TabIndex = 14;
            this.labelTypeOfLeafs.Text = "Вид растения";
            // 
            // labelGradeValue
            // 
            this.labelGradeValue.AutoSize = true;
            this.labelGradeValue.Location = new System.Drawing.Point(153, 90);
            this.labelGradeValue.Name = "labelGradeValue";
            this.labelGradeValue.Size = new System.Drawing.Size(0, 13);
            this.labelGradeValue.TabIndex = 28;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(3, 45);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(66, 13);
            this.labelDate.TabIndex = 15;
            this.labelDate.Text = "Дата сбора";
            // 
            // labelCommentValue
            // 
            this.labelCommentValue.AutoSize = true;
            this.labelCommentValue.Location = new System.Drawing.Point(153, 75);
            this.labelCommentValue.Name = "labelCommentValue";
            this.labelCommentValue.Size = new System.Drawing.Size(0, 13);
            this.labelCommentValue.TabIndex = 27;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(3, 60);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(72, 13);
            this.labelPlace.TabIndex = 16;
            this.labelPlace.Text = "Место сбора";
            // 
            // labelPlaceValue
            // 
            this.labelPlaceValue.AutoSize = true;
            this.labelPlaceValue.Location = new System.Drawing.Point(153, 60);
            this.labelPlaceValue.Name = "labelPlaceValue";
            this.labelPlaceValue.Size = new System.Drawing.Size(0, 13);
            this.labelPlaceValue.TabIndex = 26;
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(3, 75);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(77, 13);
            this.labelComment.TabIndex = 17;
            this.labelComment.Text = "Комментарий";
            // 
            // labelDateValue
            // 
            this.labelDateValue.AutoSize = true;
            this.labelDateValue.Location = new System.Drawing.Point(153, 45);
            this.labelDateValue.Name = "labelDateValue";
            this.labelDateValue.Size = new System.Drawing.Size(0, 13);
            this.labelDateValue.TabIndex = 25;
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Location = new System.Drawing.Point(3, 90);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(136, 26);
            this.labelGrade.TabIndex = 18;
            this.labelGrade.Text = "Степень флуктуирующей асимметрии";
            // 
            // labelTypeOfLeafsValue
            // 
            this.labelTypeOfLeafsValue.AutoSize = true;
            this.labelTypeOfLeafsValue.Location = new System.Drawing.Point(153, 30);
            this.labelTypeOfLeafsValue.Name = "labelTypeOfLeafsValue";
            this.labelTypeOfLeafsValue.Size = new System.Drawing.Size(0, 13);
            this.labelTypeOfLeafsValue.TabIndex = 24;
            // 
            // labelNameOfSelValue
            // 
            this.labelNameOfSelValue.AutoSize = true;
            this.labelNameOfSelValue.Location = new System.Drawing.Point(153, 0);
            this.labelNameOfSelValue.Name = "labelNameOfSelValue";
            this.labelNameOfSelValue.Size = new System.Drawing.Size(0, 13);
            this.labelNameOfSelValue.TabIndex = 22;
            // 
            // labelCountValue
            // 
            this.labelCountValue.AutoSize = true;
            this.labelCountValue.Location = new System.Drawing.Point(153, 15);
            this.labelCountValue.Name = "labelCountValue";
            this.labelCountValue.Size = new System.Drawing.Size(0, 13);
            this.labelCountValue.TabIndex = 23;
            // 
            // labelQuality
            // 
            this.labelQuality.AutoSize = true;
            this.labelQuality.Location = new System.Drawing.Point(3, 120);
            this.labelQuality.Name = "labelQuality";
            this.labelQuality.Size = new System.Drawing.Size(89, 13);
            this.labelQuality.TabIndex = 29;
            this.labelQuality.Text = "Качество среды";
            // 
            // labelQualityValue
            // 
            this.labelQualityValue.AutoSize = true;
            this.labelQualityValue.Location = new System.Drawing.Point(153, 120);
            this.labelQualityValue.Name = "labelQualityValue";
            this.labelQualityValue.Size = new System.Drawing.Size(0, 13);
            this.labelQualityValue.TabIndex = 30;
            // 
            // labelSigma
            // 
            this.labelSigma.AutoSize = true;
            this.labelSigma.Location = new System.Drawing.Point(3, 140);
            this.labelSigma.Name = "labelSigma";
            this.labelSigma.Size = new System.Drawing.Size(138, 26);
            this.labelSigma.TabIndex = 31;
            this.labelSigma.Text = "Среднее квадратическое отклонение σ ";
            // 
            // labelSigmaValue
            // 
            this.labelSigmaValue.AutoSize = true;
            this.labelSigmaValue.Location = new System.Drawing.Point(153, 140);
            this.labelSigmaValue.Name = "labelSigmaValue";
            this.labelSigmaValue.Size = new System.Drawing.Size(0, 13);
            this.labelSigmaValue.TabIndex = 32;
            // 
            // comboBoxSels
            // 
            this.comboBoxSels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSels.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.comboBoxSels.Location = new System.Drawing.Point(3, 38);
            this.comboBoxSels.Name = "comboBoxSels";
            this.comboBoxSels.Size = new System.Drawing.Size(344, 21);
            this.comboBoxSels.TabIndex = 0;
            this.comboBoxSels.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBoxLeaf
            // 
            this.groupBoxLeaf.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxLeaf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxLeaf.Enabled = false;
            this.groupBoxLeaf.Location = new System.Drawing.Point(3, 272);
            this.groupBoxLeaf.Name = "groupBoxLeaf";
            this.groupBoxLeaf.Size = new System.Drawing.Size(356, 335);
            this.groupBoxLeaf.TabIndex = 15;
            this.groupBoxLeaf.TabStop = false;
            this.groupBoxLeaf.Text = "Листья";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewLeafs, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(350, 316);
            this.tableLayoutPanel2.TabIndex = 25;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.buttonAddLeaf, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonEditLeaf, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonRemoveLeaf, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(344, 29);
            this.tableLayoutPanel3.TabIndex = 26;
            // 
            // buttonAddLeaf
            // 
            this.buttonAddLeaf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddLeaf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddLeaf.Location = new System.Drawing.Point(3, 3);
            this.buttonAddLeaf.Name = "buttonAddLeaf";
            this.buttonAddLeaf.Size = new System.Drawing.Size(108, 23);
            this.buttonAddLeaf.TabIndex = 22;
            this.buttonAddLeaf.Text = "Добавить лист";
            this.buttonAddLeaf.UseVisualStyleBackColor = true;
            this.buttonAddLeaf.Click += new System.EventHandler(this.buttonAddLeaf_Click);
            // 
            // buttonEditLeaf
            // 
            this.buttonEditLeaf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEditLeaf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditLeaf.Location = new System.Drawing.Point(117, 3);
            this.buttonEditLeaf.Name = "buttonEditLeaf";
            this.buttonEditLeaf.Size = new System.Drawing.Size(108, 23);
            this.buttonEditLeaf.TabIndex = 23;
            this.buttonEditLeaf.Text = "Изменить лист";
            this.buttonEditLeaf.UseVisualStyleBackColor = true;
            this.buttonEditLeaf.Click += new System.EventHandler(this.buttonEditLeaf_Click);
            // 
            // buttonRemoveLeaf
            // 
            this.buttonRemoveLeaf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRemoveLeaf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveLeaf.Location = new System.Drawing.Point(231, 3);
            this.buttonRemoveLeaf.Name = "buttonRemoveLeaf";
            this.buttonRemoveLeaf.Size = new System.Drawing.Size(110, 23);
            this.buttonRemoveLeaf.TabIndex = 24;
            this.buttonRemoveLeaf.Text = "Удалить лист";
            this.buttonRemoveLeaf.UseVisualStyleBackColor = true;
            this.buttonRemoveLeaf.Click += new System.EventHandler(this.buttonRemoveLeaf_Click);
            // 
            // dataGridViewLeafs
            // 
            this.dataGridViewLeafs.AllowUserToAddRows = false;
            this.dataGridViewLeafs.AllowUserToDeleteRows = false;
            this.dataGridViewLeafs.AllowUserToResizeColumns = false;
            this.dataGridViewLeafs.AllowUserToResizeRows = false;
            this.dataGridViewLeafs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeafs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.ColumnGrade,
            this.ColumnComment});
            this.dataGridViewLeafs.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewLeafs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLeafs.Location = new System.Drawing.Point(3, 38);
            this.dataGridViewLeafs.MultiSelect = false;
            this.dataGridViewLeafs.Name = "dataGridViewLeafs";
            this.dataGridViewLeafs.ReadOnly = true;
            this.dataGridViewLeafs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewLeafs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLeafs.Size = new System.Drawing.Size(344, 275);
            this.dataGridViewLeafs.TabIndex = 16;
            this.dataGridViewLeafs.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewLeafs_RowPrePaint);
            this.dataGridViewLeafs.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.FillWeight = 50F;
            this.ColumnNumber.HeaderText = "#";
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.ReadOnly = true;
            this.ColumnNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnNumber.Visible = false;
            this.ColumnNumber.Width = 20;
            // 
            // ColumnGrade
            // 
            this.ColumnGrade.HeaderText = "%";
            this.ColumnGrade.Name = "ColumnGrade";
            this.ColumnGrade.ReadOnly = true;
            this.ColumnGrade.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnComment
            // 
            this.ColumnComment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnComment.HeaderText = "!";
            this.ColumnComment.Name = "ColumnComment";
            this.ColumnComment.ReadOnly = true;
            this.ColumnComment.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxSel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxLeaf, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.26229F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.73771F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(362, 610);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "K:\\Универ\\Научная\\5\\Help.chm";
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.DefaultExt = "xls";
            this.saveFileDialog2.Filter = "*.xls|xls";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 634);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(350, 500);
            this.Name = "Form1";
            this.Text = "Анализатор флуктуирующей асимметрии v0.4-alpfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxSel.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.groupBoxLeaf.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeafs)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxSel;
        private System.Windows.Forms.Label labelNameOfSel;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTypeOfLeafs;
        private System.Windows.Forms.GroupBox groupBoxLeaf;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button buttonNewSel;
        private System.Windows.Forms.Button buttonRemoveSel;
        private System.Windows.Forms.Button buttonEditSel;
        private System.Windows.Forms.Button buttonAddLeaf;
        private System.Windows.Forms.Button buttonRemoveLeaf;
        private System.Windows.Forms.Button buttonEditLeaf;
        private System.Windows.Forms.ComboBox comboBoxSels;
        private System.Windows.Forms.Label labelCommentValue;
        private System.Windows.Forms.Label labelPlaceValue;
        private System.Windows.Forms.Label labelDateValue;
        private System.Windows.Forms.Label labelTypeOfLeafsValue;
        private System.Windows.Forms.Label labelCountValue;
        private System.Windows.Forms.Label labelNameOfSelValue;
        private System.Windows.Forms.Label labelGradeValue;
        private System.Windows.Forms.DataGridView dataGridViewLeafs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem краткийОтчётОВыборкеToolStripMenuItem;
        private System.Windows.Forms.Label labelQuality;
        private System.Windows.Forms.Label labelQualityValue;
        private System.Windows.Forms.Label labelSigma;
        private System.Windows.Forms.Label labelSigmaValue;
        private System.Windows.Forms.ToolStripMenuItem сравнениеToolStripMenuItem;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnComment;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.ToolStripMenuItem отчётОВсехВыборкахToolStripMenuItem;
    }
}


namespace UserStory_Airoport
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Pravka = new System.Windows.Forms.ToolStripMenuItem();
            this.pravka_add = new System.Windows.Forms.ToolStripMenuItem();
            this.pravka_change = new System.Windows.Forms.ToolStripMenuItem();
            this.pravka_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Add = new System.Windows.Forms.ToolStripButton();
            this.Change = new System.Windows.Forms.ToolStripButton();
            this.Delete = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.reisi_count = new System.Windows.Forms.ToolStripStatusLabel();
            this.allpas = new System.Windows.Forms.ToolStripStatusLabel();
            this.allek = new System.Windows.Forms.ToolStripStatusLabel();
            this.allmoney = new System.Windows.Forms.ToolStripStatusLabel();
            this.number_reisa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_prib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passangiers_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_passangiers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countCrewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price4CrewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procDopColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Pravka,
            this.about});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(48, 20);
            this.File.Text = "Файл";
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(109, 22);
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Pravka
            // 
            this.Pravka.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pravka_add,
            this.pravka_change,
            this.pravka_delete});
            this.Pravka.Name = "Pravka";
            this.Pravka.Size = new System.Drawing.Size(59, 20);
            this.Pravka.Text = "Правка";
            // 
            // pravka_add
            // 
            this.pravka_add.Name = "pravka_add";
            this.pravka_add.Size = new System.Drawing.Size(128, 22);
            this.pravka_add.Text = "Добавить";
            this.pravka_add.Click += new System.EventHandler(this.AddTool_Click);
            // 
            // pravka_change
            // 
            this.pravka_change.Enabled = false;
            this.pravka_change.Name = "pravka_change";
            this.pravka_change.Size = new System.Drawing.Size(128, 22);
            this.pravka_change.Text = "Изменить";
            this.pravka_change.Click += new System.EventHandler(this.ChangeTool_Click);
            // 
            // pravka_delete
            // 
            this.pravka_delete.Enabled = false;
            this.pravka_delete.Name = "pravka_delete";
            this.pravka_delete.Size = new System.Drawing.Size(128, 22);
            this.pravka_delete.Text = "Удалить";
            this.pravka_delete.Click += new System.EventHandler(this.DeleteTool_Click);
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(94, 20);
            this.about.Text = "О программе";
            this.about.Click += new System.EventHandler(this.About_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add,
            this.Change,
            this.Delete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(884, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Add
            // 
            this.Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(63, 22);
            this.Add.Text = "Добавить";
            this.Add.Click += new System.EventHandler(this.AddTool_Click);
            // 
            // Change
            // 
            this.Change.Enabled = false;
            this.Change.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(65, 22);
            this.Change.Text = "Изменить";
            this.Change.Click += new System.EventHandler(this.ChangeTool_Click);
            // 
            // Delete
            // 
            this.Delete.Enabled = false;
            this.Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(55, 22);
            this.Delete.Text = "Удалить";
            this.Delete.Click += new System.EventHandler(this.DeleteTool_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number_reisa,
            this.type,
            this.time_prib,
            this.passangiers_count,
            this.price_passangiers,
            this.countCrewColumn,
            this.price4CrewColumn,
            this.procDopColumn,
            this.sumColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 49);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(884, 412);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.FlightsDGV_SelectionChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reisi_count,
            this.allpas,
            this.allek,
            this.allmoney});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // reisi_count
            // 
            this.reisi_count.Name = "reisi_count";
            this.reisi_count.Size = new System.Drawing.Size(136, 17);
            this.reisi_count.Text = "Количествово рейсов 0";
            // 
            // allpas
            // 
            this.allpas.Name = "allpas";
            this.allpas.Size = new System.Drawing.Size(117, 17);
            this.allpas.Text = "Всего пассажиров 0";
            // 
            // allek
            // 
            this.allek.Name = "allek";
            this.allek.Size = new System.Drawing.Size(97, 17);
            this.allek.Text = "Всего экипажа 0";
            // 
            // allmoney
            // 
            this.allmoney.Name = "allmoney";
            this.allmoney.Size = new System.Drawing.Size(105, 17);
            this.allmoney.Text = "Общая выручка 0";
            // 
            // number_reisa
            // 
            this.number_reisa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.number_reisa.DataPropertyName = "nomer_reisa";
            dataGridViewCellStyle1.NullValue = null;
            this.number_reisa.DefaultCellStyle = dataGridViewCellStyle1;
            this.number_reisa.HeaderText = "Номер рейса";
            this.number_reisa.Name = "number_reisa";
            this.number_reisa.ReadOnly = true;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.type.DataPropertyName = "Type";
            this.type.HeaderText = "Тип";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // time_prib
            // 
            this.time_prib.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time_prib.DataPropertyName = "prib_time";
            dataGridViewCellStyle2.NullValue = null;
            this.time_prib.DefaultCellStyle = dataGridViewCellStyle2;
            this.time_prib.HeaderText = "Время прибытия";
            this.time_prib.Name = "time_prib";
            this.time_prib.ReadOnly = true;
            // 
            // passangiers_count
            // 
            this.passangiers_count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.passangiers_count.DataPropertyName = "passagiers_count";
            this.passangiers_count.HeaderText = "Количество пассажиров";
            this.passangiers_count.Name = "passangiers_count";
            this.passangiers_count.ReadOnly = true;
            // 
            // price_passangiers
            // 
            this.price_passangiers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price_passangiers.DataPropertyName = "ppassagiers__price";
            this.price_passangiers.HeaderText = "Сбор на пассажира";
            this.price_passangiers.Name = "price_passangiers";
            this.price_passangiers.ReadOnly = true;
            // 
            // countCrewColumn
            // 
            this.countCrewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.countCrewColumn.DataPropertyName = "ek_count";
            this.countCrewColumn.HeaderText = "Коичество экипажа";
            this.countCrewColumn.Name = "countCrewColumn";
            this.countCrewColumn.ReadOnly = true;
            // 
            // price4CrewColumn
            // 
            this.price4CrewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price4CrewColumn.DataPropertyName = "ek_price";
            dataGridViewCellStyle3.NullValue = null;
            this.price4CrewColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.price4CrewColumn.HeaderText = "Сбор на экипаж";
            this.price4CrewColumn.Name = "price4CrewColumn";
            this.price4CrewColumn.ReadOnly = true;
            // 
            // procDopColumn
            // 
            this.procDopColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.procDopColumn.DataPropertyName = "procent";
            this.procDopColumn.HeaderText = "процент надбавки за обс.";
            this.procDopColumn.Name = "procDopColumn";
            this.procDopColumn.ReadOnly = true;
            // 
            // sumColumn
            // 
            this.sumColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sumColumn.DataPropertyName = "allmoney";
            this.sumColumn.HeaderText = "Выручка";
            this.sumColumn.Name = "sumColumn";
            this.sumColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "Form1";
            this.Text = "Аэропорт";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Add;
        private System.Windows.Forms.ToolStripButton Change;
        private System.Windows.Forms.ToolStripButton Delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel reisi_count;
        private System.Windows.Forms.ToolStripStatusLabel allmoney;
        private System.Windows.Forms.ToolStripStatusLabel allpas;
        private System.Windows.Forms.ToolStripStatusLabel allek;
        private System.Windows.Forms.ToolStripMenuItem Pravka;
        private System.Windows.Forms.ToolStripMenuItem pravka_add;
        private System.Windows.Forms.ToolStripMenuItem pravka_change;
        private System.Windows.Forms.ToolStripMenuItem pravka_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_reisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_prib;
        private System.Windows.Forms.DataGridViewTextBoxColumn passangiers_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_passangiers;
        private System.Windows.Forms.DataGridViewTextBoxColumn countCrewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn price4CrewColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procDopColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumColumn;
    }
}


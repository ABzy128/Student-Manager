namespace Abzal_s
{
    partial class Main
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
            this.Grid = new System.Windows.Forms.DataGridView();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.языкDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.возрастDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsDataSet = new Abzal_s.StudentsDataSet();
            this.tableTableAdapter = new Abzal_s.StudentsDataSetTableAdapters.tableTableAdapter();
            this.AddButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.EditButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DeleteButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SaveButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.HelpButton = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AutoGenerateColumns = false;
            this.Grid.BackgroundColor = System.Drawing.Color.White;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.имяDataGridViewTextBoxColumn,
            this.языкDataGridViewTextBoxColumn,
            this.возрастDataGridViewTextBoxColumn,
            this.категорияDataGridViewTextBoxColumn});
            this.Grid.DataSource = this.tableBindingSource;
            this.Grid.Location = new System.Drawing.Point(9, 67);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersWidth = 51;
            this.Grid.RowTemplate.Height = 24;
            this.Grid.Size = new System.Drawing.Size(578, 227);
            this.Grid.TabIndex = 0;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.ReadOnly = true;
            this.имяDataGridViewTextBoxColumn.Width = 150;
            // 
            // языкDataGridViewTextBoxColumn
            // 
            this.языкDataGridViewTextBoxColumn.DataPropertyName = "Язык";
            this.языкDataGridViewTextBoxColumn.HeaderText = "Языки";
            this.языкDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.языкDataGridViewTextBoxColumn.Name = "языкDataGridViewTextBoxColumn";
            this.языкDataGridViewTextBoxColumn.ReadOnly = true;
            this.языкDataGridViewTextBoxColumn.Width = 175;
            // 
            // возрастDataGridViewTextBoxColumn
            // 
            this.возрастDataGridViewTextBoxColumn.DataPropertyName = "Возраст";
            this.возрастDataGridViewTextBoxColumn.HeaderText = "Возраст";
            this.возрастDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.возрастDataGridViewTextBoxColumn.Name = "возрастDataGridViewTextBoxColumn";
            this.возрастDataGridViewTextBoxColumn.ReadOnly = true;
            this.возрастDataGridViewTextBoxColumn.Width = 75;
            // 
            // категорияDataGridViewTextBoxColumn
            // 
            this.категорияDataGridViewTextBoxColumn.DataPropertyName = "Категория";
            this.категорияDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.категорияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.категорияDataGridViewTextBoxColumn.Name = "категорияDataGridViewTextBoxColumn";
            this.категорияDataGridViewTextBoxColumn.ReadOnly = true;
            this.категорияDataGridViewTextBoxColumn.Width = 125;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "table";
            this.tableBindingSource.DataSource = this.studentsDataSet;
            // 
            // studentsDataSet
            // 
            this.studentsDataSet.DataSetName = "StudentsDataSet";
            this.studentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.Depth = 0;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.AddButton.Icon = null;
            this.AddButton.Location = new System.Drawing.Point(36, 299);
            this.AddButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddButton.Name = "AddButton";
            this.AddButton.Primary = true;
            this.AddButton.Size = new System.Drawing.Size(113, 36);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.AutoSize = true;
            this.EditButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditButton.Depth = 0;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.EditButton.Icon = null;
            this.EditButton.Location = new System.Drawing.Point(155, 299);
            this.EditButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditButton.Name = "EditButton";
            this.EditButton.Primary = true;
            this.EditButton.Size = new System.Drawing.Size(115, 36);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.Depth = 0;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.DeleteButton.Icon = null;
            this.DeleteButton.Location = new System.Drawing.Point(276, 299);
            this.DeleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Primary = true;
            this.DeleteButton.Size = new System.Drawing.Size(103, 36);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.AutoSize = true;
            this.SaveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.Depth = 0;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.SaveButton.Icon = null;
            this.SaveButton.Location = new System.Drawing.Point(385, 299);
            this.SaveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Primary = true;
            this.SaveButton.Size = new System.Drawing.Size(124, 36);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.AutoSize = true;
            this.HelpButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HelpButton.Depth = 0;
            this.HelpButton.Icon = null;
            this.HelpButton.Location = new System.Drawing.Point(515, 299);
            this.HelpButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Primary = true;
            this.HelpButton.Size = new System.Drawing.Size(30, 36);
            this.HelpButton.TabIndex = 5;
            this.HelpButton.Text = "?";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 347);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Grid);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid;
        private StudentsDataSet studentsDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private StudentsDataSetTableAdapters.tableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn языкDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn возрастDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn категорияDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialRaisedButton AddButton;
        private MaterialSkin.Controls.MaterialRaisedButton EditButton;
        private MaterialSkin.Controls.MaterialRaisedButton DeleteButton;
        private MaterialSkin.Controls.MaterialRaisedButton SaveButton;
        private MaterialSkin.Controls.MaterialRaisedButton HelpButton;
    }
}


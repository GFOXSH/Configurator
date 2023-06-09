﻿namespace Configurator
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OgseLink = new System.Windows.Forms.LinkLabel();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Nickname = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.RichTextBox();
            this.lang_pic_en = new System.Windows.Forms.PictureBox();
            this.lang_pic_ru = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.OtherTabs = new System.Windows.Forms.TabControl();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.search_update = new System.Windows.Forms.Button();
            this.size_of_file = new System.Windows.Forms.Label();
            this.updating = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.Opisanie = new System.Windows.Forms.RichTextBox();
            this.check_update = new System.Windows.Forms.CheckBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.saves = new System.Windows.Forms.ComboBox();
            this.send = new System.Windows.Forms.Button();
            this.load_log = new System.Windows.Forms.CheckBox();
            this.button6 = new System.Windows.Forms.Button();
            this.file1 = new System.Windows.Forms.TextBox();
            this.file_sav_label = new System.Windows.Forms.Label();
            this.terms_label = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.RichTextBox();
            this.RU = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_day = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.StartGameButton64 = new System.Windows.Forms.Button();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.savePicture = new System.Windows.Forms.PictureBox();
            this.SavesList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.tabpage = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.lang_pic_en)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lang_pic_ru)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.OtherTabs.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_day)).BeginInit();
            this.tabPage12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.savePicture)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabpage.SuspendLayout();
            this.SuspendLayout();
            // 
            // OgseLink
            // 
            resources.ApplyResources(this.OgseLink, "OgseLink");
            this.OgseLink.Name = "OgseLink";
            this.OgseLink.TabStop = true;
            this.OgseLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OgseLinkLinkClicked);
            // 
            // ApplyButton
            // 
            resources.ApplyResources(this.ApplyButton, "ApplyButton");
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButtonClick);
            // 
            // CloseButton
            // 
            resources.ApplyResources(this.CloseButton, "CloseButton");
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 600;
            this.toolTip1.AutoPopDelay = 8000;
            this.toolTip1.InitialDelay = 600;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 120;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // Nickname
            // 
            resources.ApplyResources(this.Nickname, "Nickname");
            this.Nickname.Name = "Nickname";
            this.toolTip1.SetToolTip(this.Nickname, resources.GetString("Nickname.ToolTip"));
            // 
            // name
            // 
            resources.ApplyResources(this.name, "name");
            this.name.Name = "name";
            this.toolTip1.SetToolTip(this.name, resources.GetString("name.ToolTip"));
            // 
            // lang_pic_en
            // 
            resources.ApplyResources(this.lang_pic_en, "lang_pic_en");
            this.lang_pic_en.Name = "lang_pic_en";
            this.lang_pic_en.TabStop = false;
            this.toolTip1.SetToolTip(this.lang_pic_en, resources.GetString("lang_pic_en.ToolTip"));
            this.lang_pic_en.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lang_pic_ru
            // 
            resources.ApplyResources(this.lang_pic_ru, "lang_pic_ru");
            this.lang_pic_ru.Name = "lang_pic_ru";
            this.lang_pic_ru.TabStop = false;
            this.toolTip1.SetToolTip(this.lang_pic_ru, resources.GetString("lang_pic_ru.ToolTip"));
            this.lang_pic_ru.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.toolTip1.SetToolTip(this.button4, resources.GetString("button4.ToolTip"));
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.OtherTabs);
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            // 
            // OtherTabs
            // 
            this.OtherTabs.Controls.Add(this.tabPage8);
            this.OtherTabs.Controls.Add(this.tabPage9);
            resources.ApplyResources(this.OtherTabs, "OtherTabs");
            this.OtherTabs.Name = "OtherTabs";
            this.OtherTabs.SelectedIndex = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.White;
            this.tabPage8.Controls.Add(this.search_update);
            this.tabPage8.Controls.Add(this.size_of_file);
            this.tabPage8.Controls.Add(this.updating);
            this.tabPage8.Controls.Add(this.progressBar1);
            this.tabPage8.Controls.Add(this.label29);
            this.tabPage8.Controls.Add(this.label28);
            this.tabPage8.Controls.Add(this.Opisanie);
            this.tabPage8.Controls.Add(this.check_update);
            resources.ApplyResources(this.tabPage8, "tabPage8");
            this.tabPage8.Name = "tabPage8";
            // 
            // search_update
            // 
            resources.ApplyResources(this.search_update, "search_update");
            this.search_update.Name = "search_update";
            this.search_update.UseVisualStyleBackColor = true;
            // 
            // size_of_file
            // 
            resources.ApplyResources(this.size_of_file, "size_of_file");
            this.size_of_file.Name = "size_of_file";
            // 
            // updating
            // 
            resources.ApplyResources(this.updating, "updating");
            this.updating.Name = "updating";
            this.updating.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            // 
            // Opisanie
            // 
            resources.ApplyResources(this.Opisanie, "Opisanie");
            this.Opisanie.Name = "Opisanie";
            this.Opisanie.ReadOnly = true;
            // 
            // check_update
            // 
            resources.ApplyResources(this.check_update, "check_update");
            this.check_update.Name = "check_update";
            this.check_update.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.Color.White;
            this.tabPage9.Controls.Add(this.button8);
            this.tabPage9.Controls.Add(this.saves);
            this.tabPage9.Controls.Add(this.send);
            this.tabPage9.Controls.Add(this.load_log);
            this.tabPage9.Controls.Add(this.button6);
            this.tabPage9.Controls.Add(this.file1);
            this.tabPage9.Controls.Add(this.file_sav_label);
            this.tabPage9.Controls.Add(this.terms_label);
            this.tabPage9.Controls.Add(this.text);
            this.tabPage9.Controls.Add(this.name);
            this.tabPage9.Controls.Add(this.Nickname);
            resources.ApplyResources(this.tabPage9, "tabPage9");
            this.tabPage9.Name = "tabPage9";
            // 
            // button8
            // 
            resources.ApplyResources(this.button8, "button8");
            this.button8.Name = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // saves
            // 
            this.saves.FormattingEnabled = true;
            resources.ApplyResources(this.saves, "saves");
            this.saves.Name = "saves";
            this.saves.SelectedIndexChanged += new System.EventHandler(this.saves_SelectedIndexChanged);
            // 
            // send
            // 
            resources.ApplyResources(this.send, "send");
            this.send.Name = "send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.button5_Click);
            // 
            // load_log
            // 
            resources.ApplyResources(this.load_log, "load_log");
            this.load_log.Name = "load_log";
            this.load_log.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button_Click);
            // 
            // file1
            // 
            resources.ApplyResources(this.file1, "file1");
            this.file1.Name = "file1";
            // 
            // file_sav_label
            // 
            resources.ApplyResources(this.file_sav_label, "file_sav_label");
            this.file_sav_label.Name = "file_sav_label";
            // 
            // terms_label
            // 
            resources.ApplyResources(this.terms_label, "terms_label");
            this.terms_label.Name = "terms_label";
            // 
            // text
            // 
            resources.ApplyResources(this.text, "text");
            this.text.Name = "text";
            // 
            // RU
            // 
            resources.ApplyResources(this.RU, "RU");
            this.RU.Name = "RU";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // pictureBox_day
            // 
            resources.ApplyResources(this.pictureBox_day, "pictureBox_day");
            this.pictureBox_day.BackColor = System.Drawing.Color.Black;
            this.pictureBox_day.Image = global::Configurator.Properties.Resources.Title_logo;
            this.pictureBox_day.Name = "pictureBox_day";
            this.pictureBox_day.TabStop = false;
            this.pictureBox_day.Click += new System.EventHandler(this.pictureBox_day_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.AddExtension = false;
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // StartGameButton64
            // 
            resources.ApplyResources(this.StartGameButton64, "StartGameButton64");
            this.StartGameButton64.Name = "StartGameButton64";
            this.StartGameButton64.UseVisualStyleBackColor = true;
            this.StartGameButton64.Click += new System.EventHandler(this.StartGameClick64);
            // 
            // tabPage12
            // 
            this.tabPage12.Controls.Add(this.button4);
            this.tabPage12.Controls.Add(this.savePicture);
            this.tabPage12.Controls.Add(this.SavesList);
            resources.ApplyResources(this.tabPage12, "tabPage12");
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.UseVisualStyleBackColor = true;
            this.tabPage12.Click += new System.EventHandler(this.tabPage12_Click);
            // 
            // savePicture
            // 
            resources.ApplyResources(this.savePicture, "savePicture");
            this.savePicture.Name = "savePicture";
            this.savePicture.TabStop = false;
            // 
            // SavesList
            // 
            resources.ApplyResources(this.SavesList, "SavesList");
            this.SavesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.SavesList.FullRowSelect = true;
            this.SavesList.GridLines = true;
            this.SavesList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.SavesList.HideSelection = false;
            this.SavesList.MultiSelect = false;
            this.SavesList.Name = "SavesList";
            this.SavesList.UseCompatibleStateImageBehavior = false;
            this.SavesList.View = System.Windows.Forms.View.Details;
            this.SavesList.SelectedIndexChanged += new System.EventHandler(this.SavesList_SelectedIndexChanged);
            this.SavesList.DoubleClick += new System.EventHandler(this.SavesListDoubleClick);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.propertyGrid1);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // propertyGrid1
            // 
            resources.ApplyResources(this.propertyGrid1, "propertyGrid1");
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.propertyGrid1.ToolbarVisible = false;
            this.propertyGrid1.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid1_PropertyValueChanged);
            // 
            // tabpage
            // 
            resources.ApplyResources(this.tabpage, "tabpage");
            this.tabpage.Controls.Add(this.tabPage2);
            this.tabpage.Controls.Add(this.tabPage12);
            this.tabpage.Name = "tabpage";
            this.tabpage.SelectedIndex = 0;
            this.tabpage.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabpage_Selected);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StartGameButton64);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RU);
            this.Controls.Add(this.lang_pic_en);
            this.Controls.Add(this.lang_pic_ru);
            this.Controls.Add(this.pictureBox_day);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.OgseLink);
            this.Controls.Add(this.tabpage);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lang_pic_en)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lang_pic_ru)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.OtherTabs.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_day)).EndInit();
            this.tabPage12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.savePicture)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabpage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel OgseLink;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.PictureBox pictureBox_day;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabControl OtherTabs;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Button search_update;
        private System.Windows.Forms.Label size_of_file;
        private System.Windows.Forms.Button updating;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.RichTextBox Opisanie;
        private System.Windows.Forms.CheckBox check_update;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox saves;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.CheckBox load_log;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox file1;
        private System.Windows.Forms.Label file_sav_label;
        private System.Windows.Forms.Label terms_label;
        private System.Windows.Forms.RichTextBox text;
        private System.Windows.Forms.RichTextBox name;
        private System.Windows.Forms.Label Nickname;
        private System.Windows.Forms.PictureBox lang_pic_ru;
        private System.Windows.Forms.PictureBox lang_pic_en;
        private System.Windows.Forms.Label RU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button StartGameButton64;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox savePicture;
        private System.Windows.Forms.ListView SavesList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.TabControl tabpage;
    }
}


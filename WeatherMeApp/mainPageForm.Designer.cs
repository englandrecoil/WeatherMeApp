﻿namespace WeatherMeApp
{
    partial class mainPageForm
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
            this.weatherInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.weatherInfoCurrent = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.favoriteIcon = new System.Windows.Forms.PictureBox();
            this.buttonRecommendations = new System.Windows.Forms.Button();
            this.visibilityInfo = new System.Windows.Forms.Label();
            this.VisibilityLabel = new System.Windows.Forms.Label();
            this.humidityInfo = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.cloudinessInfo = new System.Windows.Forms.Label();
            this.cloudinessLabel = new System.Windows.Forms.Label();
            this.pressureInfo = new System.Windows.Forms.Label();
            this.pressureLabel = new System.Windows.Forms.Label();
            this.sunSetInfo = new System.Windows.Forms.Label();
            this.sunsetLabel = new System.Windows.Forms.Label();
            this.sunRiseInfo = new System.Windows.Forms.Label();
            this.sunriseLabel = new System.Windows.Forms.Label();
            this.windDirInfo = new System.Windows.Forms.Label();
            this.windDirLabel = new System.Windows.Forms.Label();
            this.windspeedInfo = new System.Windows.Forms.Label();
            this.windspeedLabel = new System.Windows.Forms.Label();
            this.feelsLikeInfo = new System.Windows.Forms.Label();
            this.feelsLikeLabel = new System.Windows.Forms.Label();
            this.temperatureInfo = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.datetimeInfo = new System.Windows.Forms.Label();
            this.datetimeLabel = new System.Windows.Forms.Label();
            this.cityInfo = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.pictureIcon = new System.Windows.Forms.PictureBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.cityField = new System.Windows.Forms.TextBox();
            this.cityFieldTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.favoritesGroupBox = new System.Windows.Forms.GroupBox();
            this.favoritesGroup = new System.Windows.Forms.GroupBox();
            this.listViewFavorites = new System.Windows.Forms.ListView();
            this.columnCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTemperature = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.recommendationLabelText = new System.Windows.Forms.Label();
            this.appName = new System.Windows.Forms.Label();
            this.sunPicture = new System.Windows.Forms.PictureBox();
            this.weatherInfoGroupBox.SuspendLayout();
            this.weatherInfoCurrent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.favoriteIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).BeginInit();
            this.cityFieldTableLayout.SuspendLayout();
            this.favoritesGroupBox.SuspendLayout();
            this.favoritesGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sunPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // weatherInfoGroupBox
            // 
            this.weatherInfoGroupBox.BackColor = System.Drawing.Color.Gainsboro;
            this.weatherInfoGroupBox.Controls.Add(this.weatherInfoCurrent);
            this.weatherInfoGroupBox.Location = new System.Drawing.Point(93, 210);
            this.weatherInfoGroupBox.Name = "weatherInfoGroupBox";
            this.weatherInfoGroupBox.Size = new System.Drawing.Size(534, 567);
            this.weatherInfoGroupBox.TabIndex = 0;
            this.weatherInfoGroupBox.TabStop = false;
            // 
            // weatherInfoCurrent
            // 
            this.weatherInfoCurrent.Controls.Add(this.addButton);
            this.weatherInfoCurrent.Controls.Add(this.favoriteIcon);
            this.weatherInfoCurrent.Controls.Add(this.buttonRecommendations);
            this.weatherInfoCurrent.Controls.Add(this.visibilityInfo);
            this.weatherInfoCurrent.Controls.Add(this.VisibilityLabel);
            this.weatherInfoCurrent.Controls.Add(this.humidityInfo);
            this.weatherInfoCurrent.Controls.Add(this.humidityLabel);
            this.weatherInfoCurrent.Controls.Add(this.cloudinessInfo);
            this.weatherInfoCurrent.Controls.Add(this.cloudinessLabel);
            this.weatherInfoCurrent.Controls.Add(this.pressureInfo);
            this.weatherInfoCurrent.Controls.Add(this.pressureLabel);
            this.weatherInfoCurrent.Controls.Add(this.sunSetInfo);
            this.weatherInfoCurrent.Controls.Add(this.sunsetLabel);
            this.weatherInfoCurrent.Controls.Add(this.sunRiseInfo);
            this.weatherInfoCurrent.Controls.Add(this.sunriseLabel);
            this.weatherInfoCurrent.Controls.Add(this.windDirInfo);
            this.weatherInfoCurrent.Controls.Add(this.windDirLabel);
            this.weatherInfoCurrent.Controls.Add(this.windspeedInfo);
            this.weatherInfoCurrent.Controls.Add(this.windspeedLabel);
            this.weatherInfoCurrent.Controls.Add(this.feelsLikeInfo);
            this.weatherInfoCurrent.Controls.Add(this.feelsLikeLabel);
            this.weatherInfoCurrent.Controls.Add(this.temperatureInfo);
            this.weatherInfoCurrent.Controls.Add(this.temperatureLabel);
            this.weatherInfoCurrent.Controls.Add(this.datetimeInfo);
            this.weatherInfoCurrent.Controls.Add(this.datetimeLabel);
            this.weatherInfoCurrent.Controls.Add(this.cityInfo);
            this.weatherInfoCurrent.Controls.Add(this.cityLabel);
            this.weatherInfoCurrent.Controls.Add(this.pictureIcon);
            this.weatherInfoCurrent.Location = new System.Drawing.Point(27, 19);
            this.weatherInfoCurrent.Name = "weatherInfoCurrent";
            this.weatherInfoCurrent.Size = new System.Drawing.Size(481, 532);
            this.weatherInfoCurrent.TabIndex = 0;
            this.weatherInfoCurrent.TabStop = false;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(406, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 28);
            this.addButton.TabIndex = 26;
            this.addButton.Text = "FAVORITES";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // favoriteIcon
            // 
            this.favoriteIcon.BackColor = System.Drawing.Color.Transparent;
            this.favoriteIcon.Image = global::WeatherMeApp.Properties.Resources.favorite_icon;
            this.favoriteIcon.Location = new System.Drawing.Point(372, 5);
            this.favoriteIcon.Name = "favoriteIcon";
            this.favoriteIcon.Size = new System.Drawing.Size(0, 0);
            this.favoriteIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.favoriteIcon.TabIndex = 25;
            this.favoriteIcon.TabStop = false;
            // 
            // buttonRecommendations
            // 
            this.buttonRecommendations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRecommendations.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRecommendations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRecommendations.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonRecommendations.FlatAppearance.BorderSize = 0;
            this.buttonRecommendations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonRecommendations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecommendations.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRecommendations.ForeColor = System.Drawing.Color.Transparent;
            this.buttonRecommendations.Location = new System.Drawing.Point(117, 490);
            this.buttonRecommendations.Name = "buttonRecommendations";
            this.buttonRecommendations.Size = new System.Drawing.Size(244, 36);
            this.buttonRecommendations.TabIndex = 1;
            this.buttonRecommendations.Text = "CHECK RECOMMENDATIONS";
            this.buttonRecommendations.UseVisualStyleBackColor = false;
            this.buttonRecommendations.Click += new System.EventHandler(this.buttonRecommendations_Click);
            // 
            // visibilityInfo
            // 
            this.visibilityInfo.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visibilityInfo.Location = new System.Drawing.Point(345, 365);
            this.visibilityInfo.Name = "visibilityInfo";
            this.visibilityInfo.Size = new System.Drawing.Size(156, 36);
            this.visibilityInfo.TabIndex = 24;
            this.visibilityInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VisibilityLabel
            // 
            this.VisibilityLabel.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VisibilityLabel.Location = new System.Drawing.Point(256, 365);
            this.VisibilityLabel.Name = "VisibilityLabel";
            this.VisibilityLabel.Size = new System.Drawing.Size(97, 36);
            this.VisibilityLabel.TabIndex = 23;
            this.VisibilityLabel.Text = "Visibility:";
            this.VisibilityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // humidityInfo
            // 
            this.humidityInfo.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.humidityInfo.Location = new System.Drawing.Point(93, 365);
            this.humidityInfo.Name = "humidityInfo";
            this.humidityInfo.Size = new System.Drawing.Size(133, 36);
            this.humidityInfo.TabIndex = 22;
            this.humidityInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // humidityLabel
            // 
            this.humidityLabel.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.humidityLabel.Location = new System.Drawing.Point(-6, 365);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(106, 36);
            this.humidityLabel.TabIndex = 21;
            this.humidityLabel.Text = "Humidity:";
            this.humidityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cloudinessInfo
            // 
            this.cloudinessInfo.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cloudinessInfo.Location = new System.Drawing.Point(377, 301);
            this.cloudinessInfo.Name = "cloudinessInfo";
            this.cloudinessInfo.Size = new System.Drawing.Size(96, 36);
            this.cloudinessInfo.TabIndex = 20;
            this.cloudinessInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cloudinessLabel
            // 
            this.cloudinessLabel.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cloudinessLabel.Location = new System.Drawing.Point(256, 301);
            this.cloudinessLabel.Name = "cloudinessLabel";
            this.cloudinessLabel.Size = new System.Drawing.Size(121, 36);
            this.cloudinessLabel.TabIndex = 19;
            this.cloudinessLabel.Text = "Cloudiness:";
            this.cloudinessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pressureInfo
            // 
            this.pressureInfo.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pressureInfo.Location = new System.Drawing.Point(88, 301);
            this.pressureInfo.Name = "pressureInfo";
            this.pressureInfo.Size = new System.Drawing.Size(127, 36);
            this.pressureInfo.TabIndex = 18;
            this.pressureInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pressureLabel
            // 
            this.pressureLabel.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pressureLabel.Location = new System.Drawing.Point(-6, 301);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(106, 36);
            this.pressureLabel.TabIndex = 17;
            this.pressureLabel.Text = "Pressure:";
            this.pressureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sunSetInfo
            // 
            this.sunSetInfo.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sunSetInfo.Location = new System.Drawing.Point(334, 236);
            this.sunSetInfo.Name = "sunSetInfo";
            this.sunSetInfo.Size = new System.Drawing.Size(136, 36);
            this.sunSetInfo.TabIndex = 16;
            this.sunSetInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sunsetLabel
            // 
            this.sunsetLabel.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sunsetLabel.Location = new System.Drawing.Point(256, 236);
            this.sunsetLabel.Name = "sunsetLabel";
            this.sunsetLabel.Size = new System.Drawing.Size(83, 36);
            this.sunsetLabel.TabIndex = 15;
            this.sunsetLabel.Text = "Sunset:";
            this.sunsetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sunRiseInfo
            // 
            this.sunRiseInfo.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sunRiseInfo.Location = new System.Drawing.Point(79, 236);
            this.sunRiseInfo.Name = "sunRiseInfo";
            this.sunRiseInfo.Size = new System.Drawing.Size(129, 36);
            this.sunRiseInfo.TabIndex = 14;
            this.sunRiseInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sunriseLabel
            // 
            this.sunriseLabel.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sunriseLabel.Location = new System.Drawing.Point(-6, 236);
            this.sunriseLabel.Name = "sunriseLabel";
            this.sunriseLabel.Size = new System.Drawing.Size(97, 36);
            this.sunriseLabel.TabIndex = 13;
            this.sunriseLabel.Text = "Sunrise:";
            this.sunriseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // windDirInfo
            // 
            this.windDirInfo.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.windDirInfo.Location = new System.Drawing.Point(360, 169);
            this.windDirInfo.Name = "windDirInfo";
            this.windDirInfo.Size = new System.Drawing.Size(121, 36);
            this.windDirInfo.TabIndex = 12;
            this.windDirInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // windDirLabel
            // 
            this.windDirLabel.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.windDirLabel.Location = new System.Drawing.Point(256, 169);
            this.windDirLabel.Name = "windDirLabel";
            this.windDirLabel.Size = new System.Drawing.Size(105, 36);
            this.windDirLabel.TabIndex = 11;
            this.windDirLabel.Text = "Wind Dir:";
            this.windDirLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // windspeedInfo
            // 
            this.windspeedInfo.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.windspeedInfo.Location = new System.Drawing.Point(117, 169);
            this.windspeedInfo.Name = "windspeedInfo";
            this.windspeedInfo.Size = new System.Drawing.Size(109, 36);
            this.windspeedInfo.TabIndex = 10;
            this.windspeedInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // windspeedLabel
            // 
            this.windspeedLabel.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.windspeedLabel.Location = new System.Drawing.Point(-6, 169);
            this.windspeedLabel.Name = "windspeedLabel";
            this.windspeedLabel.Size = new System.Drawing.Size(127, 36);
            this.windspeedLabel.TabIndex = 9;
            this.windspeedLabel.Text = "Windspeed:";
            this.windspeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // feelsLikeInfo
            // 
            this.feelsLikeInfo.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feelsLikeInfo.Location = new System.Drawing.Point(360, 104);
            this.feelsLikeInfo.Name = "feelsLikeInfo";
            this.feelsLikeInfo.Size = new System.Drawing.Size(121, 36);
            this.feelsLikeInfo.TabIndex = 8;
            this.feelsLikeInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // feelsLikeLabel
            // 
            this.feelsLikeLabel.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feelsLikeLabel.Location = new System.Drawing.Point(256, 104);
            this.feelsLikeLabel.Name = "feelsLikeLabel";
            this.feelsLikeLabel.Size = new System.Drawing.Size(110, 36);
            this.feelsLikeLabel.TabIndex = 7;
            this.feelsLikeLabel.Text = "Feels Like:";
            this.feelsLikeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // temperatureInfo
            // 
            this.temperatureInfo.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.temperatureInfo.Location = new System.Drawing.Point(134, 104);
            this.temperatureInfo.Name = "temperatureInfo";
            this.temperatureInfo.Size = new System.Drawing.Size(92, 36);
            this.temperatureInfo.TabIndex = 6;
            this.temperatureInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.temperatureLabel.Location = new System.Drawing.Point(-6, 104);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(145, 36);
            this.temperatureLabel.TabIndex = 5;
            this.temperatureLabel.Text = "Temperature:";
            this.temperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // datetimeInfo
            // 
            this.datetimeInfo.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datetimeInfo.Location = new System.Drawing.Point(232, 44);
            this.datetimeInfo.Name = "datetimeInfo";
            this.datetimeInfo.Size = new System.Drawing.Size(238, 36);
            this.datetimeInfo.TabIndex = 4;
            this.datetimeInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // datetimeLabel
            // 
            this.datetimeLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datetimeLabel.Location = new System.Drawing.Point(113, 44);
            this.datetimeLabel.Name = "datetimeLabel";
            this.datetimeLabel.Size = new System.Drawing.Size(124, 36);
            this.datetimeLabel.TabIndex = 3;
            this.datetimeLabel.Text = "Datetime:";
            this.datetimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cityInfo
            // 
            this.cityInfo.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityInfo.Location = new System.Drawing.Point(171, 0);
            this.cityInfo.Name = "cityInfo";
            this.cityInfo.Size = new System.Drawing.Size(223, 36);
            this.cityInfo.TabIndex = 2;
            this.cityInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cityLabel
            // 
            this.cityLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityLabel.Location = new System.Drawing.Point(113, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(68, 36);
            this.cityLabel.TabIndex = 1;
            this.cityLabel.Text = "City:";
            this.cityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureIcon
            // 
            this.pictureIcon.BackColor = System.Drawing.Color.Silver;
            this.pictureIcon.Location = new System.Drawing.Point(0, 0);
            this.pictureIcon.Name = "pictureIcon";
            this.pictureIcon.Size = new System.Drawing.Size(91, 91);
            this.pictureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureIcon.TabIndex = 0;
            this.pictureIcon.TabStop = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(505, 138);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(122, 56);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // cityField
            // 
            this.cityField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cityField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cityField.Font = new System.Drawing.Font("Yu Gothic", 15.75F);
            this.cityField.Location = new System.Drawing.Point(4, 11);
            this.cityField.Name = "cityField";
            this.cityField.Size = new System.Drawing.Size(372, 34);
            this.cityField.TabIndex = 0;
            this.cityField.Enter += new System.EventHandler(this.cityField_Enter);
            this.cityField.Leave += new System.EventHandler(this.cityField_Leave);
            // 
            // cityFieldTableLayout
            // 
            this.cityFieldTableLayout.BackColor = System.Drawing.SystemColors.Window;
            this.cityFieldTableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.cityFieldTableLayout.ColumnCount = 1;
            this.cityFieldTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cityFieldTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cityFieldTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cityFieldTableLayout.Controls.Add(this.cityField, 0, 0);
            this.cityFieldTableLayout.Location = new System.Drawing.Point(93, 138);
            this.cityFieldTableLayout.Name = "cityFieldTableLayout";
            this.cityFieldTableLayout.RowCount = 1;
            this.cityFieldTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cityFieldTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cityFieldTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cityFieldTableLayout.Size = new System.Drawing.Size(380, 56);
            this.cityFieldTableLayout.TabIndex = 3;
            // 
            // favoritesGroupBox
            // 
            this.favoritesGroupBox.Controls.Add(this.favoritesGroup);
            this.favoritesGroupBox.Location = new System.Drawing.Point(806, 138);
            this.favoritesGroupBox.Name = "favoritesGroupBox";
            this.favoritesGroupBox.Size = new System.Drawing.Size(533, 639);
            this.favoritesGroupBox.TabIndex = 4;
            this.favoritesGroupBox.TabStop = false;
            // 
            // favoritesGroup
            // 
            this.favoritesGroup.Controls.Add(this.listViewFavorites);
            this.favoritesGroup.Controls.Add(this.buttonRefresh);
            this.favoritesGroup.Controls.Add(this.deleteButton);
            this.favoritesGroup.Controls.Add(this.recommendationLabelText);
            this.favoritesGroup.Location = new System.Drawing.Point(27, 19);
            this.favoritesGroup.Name = "favoritesGroup";
            this.favoritesGroup.Size = new System.Drawing.Size(479, 604);
            this.favoritesGroup.TabIndex = 1;
            this.favoritesGroup.TabStop = false;
            // 
            // listViewFavorites
            // 
            this.listViewFavorites.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listViewFavorites.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFavorites.BackColor = System.Drawing.Color.White;
            this.listViewFavorites.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCity,
            this.columnTemperature});
            this.listViewFavorites.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewFavorites.FullRowSelect = true;
            this.listViewFavorites.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewFavorites.HideSelection = false;
            this.listViewFavorites.Location = new System.Drawing.Point(36, 72);
            this.listViewFavorites.Name = "listViewFavorites";
            this.listViewFavorites.Size = new System.Drawing.Size(395, 462);
            this.listViewFavorites.TabIndex = 30;
            this.listViewFavorites.UseCompatibleStateImageBehavior = false;
            this.listViewFavorites.View = System.Windows.Forms.View.Details;
            // 
            // columnCity
            // 
            this.columnCity.Text = "City";
            this.columnCity.Width = 218;
            // 
            // columnTemperature
            // 
            this.columnTemperature.Text = "Temperature";
            this.columnTemperature.Width = 169;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.Transparent;
            this.buttonRefresh.Location = new System.Drawing.Point(117, 562);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(244, 36);
            this.buttonRefresh.TabIndex = 29;
            this.buttonRefresh.Text = "REFRESH";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(382, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(97, 30);
            this.deleteButton.TabIndex = 28;
            this.deleteButton.Text = "Delete selected";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // recommendationLabelText
            // 
            this.recommendationLabelText.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold);
            this.recommendationLabelText.Location = new System.Drawing.Point(-3, 0);
            this.recommendationLabelText.Name = "recommendationLabelText";
            this.recommendationLabelText.Size = new System.Drawing.Size(231, 37);
            this.recommendationLabelText.TabIndex = 0;
            this.recommendationLabelText.Text = "Your favorites here:";
            // 
            // appName
            // 
            this.appName.BackColor = System.Drawing.Color.Transparent;
            this.appName.Font = new System.Drawing.Font("Yu Gothic Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appName.ForeColor = System.Drawing.Color.White;
            this.appName.Location = new System.Drawing.Point(655, 34);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(197, 33);
            this.appName.TabIndex = 9;
            this.appName.Text = "WeatherMe";
            // 
            // sunPicture
            // 
            this.sunPicture.BackColor = System.Drawing.Color.Transparent;
            this.sunPicture.Image = global::WeatherMeApp.Properties.Resources.sun_icon_final__1_;
            this.sunPicture.Location = new System.Drawing.Point(583, 17);
            this.sunPicture.Name = "sunPicture";
            this.sunPicture.Size = new System.Drawing.Size(67, 67);
            this.sunPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sunPicture.TabIndex = 8;
            this.sunPicture.TabStop = false;
            // 
            // mainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WeatherMeApp.Properties.Resources.background_final;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1424, 912);
            this.Controls.Add(this.appName);
            this.Controls.Add(this.sunPicture);
            this.Controls.Add(this.favoritesGroupBox);
            this.Controls.Add(this.cityFieldTableLayout);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.weatherInfoGroupBox);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "mainPageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainPageForm";
            this.weatherInfoGroupBox.ResumeLayout(false);
            this.weatherInfoCurrent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.favoriteIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).EndInit();
            this.cityFieldTableLayout.ResumeLayout(false);
            this.cityFieldTableLayout.PerformLayout();
            this.favoritesGroupBox.ResumeLayout(false);
            this.favoritesGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sunPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox weatherInfoGroupBox;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox cityField;
        private System.Windows.Forms.TableLayoutPanel cityFieldTableLayout;
        private System.Windows.Forms.GroupBox weatherInfoCurrent;
        private System.Windows.Forms.PictureBox pictureIcon;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label datetimeInfo;
        private System.Windows.Forms.Label datetimeLabel;
        private System.Windows.Forms.Label cityInfo;
        private System.Windows.Forms.Label temperatureInfo;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.Label visibilityInfo;
        private System.Windows.Forms.Label VisibilityLabel;
        private System.Windows.Forms.Label humidityInfo;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.Label cloudinessInfo;
        private System.Windows.Forms.Label cloudinessLabel;
        private System.Windows.Forms.Label pressureInfo;
        private System.Windows.Forms.Label pressureLabel;
        private System.Windows.Forms.Label sunSetInfo;
        private System.Windows.Forms.Label sunsetLabel;
        private System.Windows.Forms.Label sunRiseInfo;
        private System.Windows.Forms.Label sunriseLabel;
        private System.Windows.Forms.Label windDirInfo;
        private System.Windows.Forms.Label windDirLabel;
        private System.Windows.Forms.Label windspeedInfo;
        private System.Windows.Forms.Label windspeedLabel;
        private System.Windows.Forms.Label feelsLikeInfo;
        private System.Windows.Forms.Label feelsLikeLabel;
        private System.Windows.Forms.Button buttonRecommendations;
        private System.Windows.Forms.GroupBox favoritesGroupBox;
        private System.Windows.Forms.PictureBox favoriteIcon;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox favoritesGroup;
        private System.Windows.Forms.Label recommendationLabelText;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.ListView listViewFavorites;
        private System.Windows.Forms.ColumnHeader columnCity;
        private System.Windows.Forms.ColumnHeader columnTemperature;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.PictureBox sunPicture;
    }
}
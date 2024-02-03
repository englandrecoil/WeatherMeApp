namespace WeatherMeApp
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.cityField = new System.Windows.Forms.TextBox();
            this.cityFieldTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.weatherInfoCurrent = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityInfo = new System.Windows.Forms.Label();
            this.datetimeInfo = new System.Windows.Forms.Label();
            this.datetimeLabel = new System.Windows.Forms.Label();
            this.temperatureInfo = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.feelsLikeInfo = new System.Windows.Forms.Label();
            this.feelsLikeLabel = new System.Windows.Forms.Label();
            this.windDirInfo = new System.Windows.Forms.Label();
            this.windDirLabel = new System.Windows.Forms.Label();
            this.windspeedInfo = new System.Windows.Forms.Label();
            this.windspeedLabel = new System.Windows.Forms.Label();
            this.sunSetInfo = new System.Windows.Forms.Label();
            this.sunsetLabel = new System.Windows.Forms.Label();
            this.sunriseInfo = new System.Windows.Forms.Label();
            this.sunriseLabel = new System.Windows.Forms.Label();
            this.uvIndexInfo = new System.Windows.Forms.Label();
            this.uvIndexLabel = new System.Windows.Forms.Label();
            this.pressureInfo = new System.Windows.Forms.Label();
            this.pressureLabel = new System.Windows.Forms.Label();
            this.visibilityInfo = new System.Windows.Forms.Label();
            this.VisibilityLabel = new System.Windows.Forms.Label();
            this.airQualityInfo = new System.Windows.Forms.Label();
            this.airQualityLabel = new System.Windows.Forms.Label();
            this.buttonRecommendations = new System.Windows.Forms.Button();
            this.weatherInfoGroupBox.SuspendLayout();
            this.cityFieldTableLayout.SuspendLayout();
            this.weatherInfoCurrent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // weatherInfoGroupBox
            // 
            this.weatherInfoGroupBox.Controls.Add(this.weatherInfoCurrent);
            this.weatherInfoGroupBox.Location = new System.Drawing.Point(93, 210);
            this.weatherInfoGroupBox.Name = "weatherInfoGroupBox";
            this.weatherInfoGroupBox.Size = new System.Drawing.Size(534, 567);
            this.weatherInfoGroupBox.TabIndex = 0;
            this.weatherInfoGroupBox.TabStop = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(505, 138);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(122, 56);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
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
            // weatherInfoCurrent
            // 
            this.weatherInfoCurrent.Controls.Add(this.buttonRecommendations);
            this.weatherInfoCurrent.Controls.Add(this.visibilityInfo);
            this.weatherInfoCurrent.Controls.Add(this.VisibilityLabel);
            this.weatherInfoCurrent.Controls.Add(this.airQualityInfo);
            this.weatherInfoCurrent.Controls.Add(this.airQualityLabel);
            this.weatherInfoCurrent.Controls.Add(this.uvIndexInfo);
            this.weatherInfoCurrent.Controls.Add(this.uvIndexLabel);
            this.weatherInfoCurrent.Controls.Add(this.pressureInfo);
            this.weatherInfoCurrent.Controls.Add(this.pressureLabel);
            this.weatherInfoCurrent.Controls.Add(this.sunSetInfo);
            this.weatherInfoCurrent.Controls.Add(this.sunsetLabel);
            this.weatherInfoCurrent.Controls.Add(this.sunriseInfo);
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
            this.weatherInfoCurrent.Controls.Add(this.pictureBox1);
            this.weatherInfoCurrent.Location = new System.Drawing.Point(27, 19);
            this.weatherInfoCurrent.Name = "weatherInfoCurrent";
            this.weatherInfoCurrent.Size = new System.Drawing.Size(481, 532);
            this.weatherInfoCurrent.TabIndex = 0;
            this.weatherInfoCurrent.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 71);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // cityInfo
            // 
            this.cityInfo.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityInfo.Location = new System.Drawing.Point(181, 0);
            this.cityInfo.Name = "cityInfo";
            this.cityInfo.Size = new System.Drawing.Size(273, 36);
            this.cityInfo.TabIndex = 2;
            this.cityInfo.Text = "N/A";
            this.cityInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // datetimeInfo
            // 
            this.datetimeInfo.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datetimeInfo.Location = new System.Drawing.Point(243, 44);
            this.datetimeInfo.Name = "datetimeInfo";
            this.datetimeInfo.Size = new System.Drawing.Size(156, 36);
            this.datetimeInfo.TabIndex = 4;
            this.datetimeInfo.Text = "N/A";
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
            // temperatureInfo
            // 
            this.temperatureInfo.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.temperatureInfo.Location = new System.Drawing.Point(161, 104);
            this.temperatureInfo.Name = "temperatureInfo";
            this.temperatureInfo.Size = new System.Drawing.Size(65, 36);
            this.temperatureInfo.TabIndex = 6;
            this.temperatureInfo.Text = "N/A";
            this.temperatureInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.temperatureLabel.Location = new System.Drawing.Point(-6, 104);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(161, 36);
            this.temperatureLabel.TabIndex = 5;
            this.temperatureLabel.Text = "Temperature:";
            this.temperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // feelsLikeInfo
            // 
            this.feelsLikeInfo.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feelsLikeInfo.Location = new System.Drawing.Point(394, 104);
            this.feelsLikeInfo.Name = "feelsLikeInfo";
            this.feelsLikeInfo.Size = new System.Drawing.Size(87, 36);
            this.feelsLikeInfo.TabIndex = 8;
            this.feelsLikeInfo.Text = "N/A";
            this.feelsLikeInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // feelsLikeLabel
            // 
            this.feelsLikeLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feelsLikeLabel.Location = new System.Drawing.Point(256, 104);
            this.feelsLikeLabel.Name = "feelsLikeLabel";
            this.feelsLikeLabel.Size = new System.Drawing.Size(132, 36);
            this.feelsLikeLabel.TabIndex = 7;
            this.feelsLikeLabel.Text = "Feels Like:";
            this.feelsLikeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // windDirInfo
            // 
            this.windDirInfo.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.windDirInfo.Location = new System.Drawing.Point(383, 169);
            this.windDirInfo.Name = "windDirInfo";
            this.windDirInfo.Size = new System.Drawing.Size(98, 36);
            this.windDirInfo.TabIndex = 12;
            this.windDirInfo.Text = "N/A";
            this.windDirInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // windDirLabel
            // 
            this.windDirLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.windDirLabel.Location = new System.Drawing.Point(256, 169);
            this.windDirLabel.Name = "windDirLabel";
            this.windDirLabel.Size = new System.Drawing.Size(121, 36);
            this.windDirLabel.TabIndex = 11;
            this.windDirLabel.Text = "Wind Dir:";
            this.windDirLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // windspeedInfo
            // 
            this.windspeedInfo.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.windspeedInfo.Location = new System.Drawing.Point(145, 169);
            this.windspeedInfo.Name = "windspeedInfo";
            this.windspeedInfo.Size = new System.Drawing.Size(81, 36);
            this.windspeedInfo.TabIndex = 10;
            this.windspeedInfo.Text = "N/A";
            this.windspeedInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // windspeedLabel
            // 
            this.windspeedLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.windspeedLabel.Location = new System.Drawing.Point(-6, 169);
            this.windspeedLabel.Name = "windspeedLabel";
            this.windspeedLabel.Size = new System.Drawing.Size(145, 36);
            this.windspeedLabel.TabIndex = 9;
            this.windspeedLabel.Text = "Windspeed:";
            this.windspeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sunSetInfo
            // 
            this.sunSetInfo.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sunSetInfo.Location = new System.Drawing.Point(355, 236);
            this.sunSetInfo.Name = "sunSetInfo";
            this.sunSetInfo.Size = new System.Drawing.Size(126, 36);
            this.sunSetInfo.TabIndex = 16;
            this.sunSetInfo.Text = "N/A";
            this.sunSetInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sunsetLabel
            // 
            this.sunsetLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sunsetLabel.Location = new System.Drawing.Point(256, 236);
            this.sunsetLabel.Name = "sunsetLabel";
            this.sunsetLabel.Size = new System.Drawing.Size(93, 36);
            this.sunsetLabel.TabIndex = 15;
            this.sunsetLabel.Text = "Sunset:";
            this.sunsetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sunriseInfo
            // 
            this.sunriseInfo.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sunriseInfo.Location = new System.Drawing.Point(109, 236);
            this.sunriseInfo.Name = "sunriseInfo";
            this.sunriseInfo.Size = new System.Drawing.Size(117, 36);
            this.sunriseInfo.TabIndex = 14;
            this.sunriseInfo.Text = "N/A";
            this.sunriseInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sunriseLabel
            // 
            this.sunriseLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sunriseLabel.Location = new System.Drawing.Point(-6, 236);
            this.sunriseLabel.Name = "sunriseLabel";
            this.sunriseLabel.Size = new System.Drawing.Size(109, 36);
            this.sunriseLabel.TabIndex = 13;
            this.sunriseLabel.Text = "Sunrise:";
            this.sunriseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uvIndexInfo
            // 
            this.uvIndexInfo.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uvIndexInfo.Location = new System.Drawing.Point(383, 301);
            this.uvIndexInfo.Name = "uvIndexInfo";
            this.uvIndexInfo.Size = new System.Drawing.Size(98, 36);
            this.uvIndexInfo.TabIndex = 20;
            this.uvIndexInfo.Text = "N/A";
            this.uvIndexInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uvIndexLabel
            // 
            this.uvIndexLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uvIndexLabel.Location = new System.Drawing.Point(256, 301);
            this.uvIndexLabel.Name = "uvIndexLabel";
            this.uvIndexLabel.Size = new System.Drawing.Size(121, 36);
            this.uvIndexLabel.TabIndex = 19;
            this.uvIndexLabel.Text = "UV index:";
            this.uvIndexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pressureInfo
            // 
            this.pressureInfo.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pressureInfo.Location = new System.Drawing.Point(161, 301);
            this.pressureInfo.Name = "pressureInfo";
            this.pressureInfo.Size = new System.Drawing.Size(76, 36);
            this.pressureInfo.TabIndex = 18;
            this.pressureInfo.Text = "N/A";
            this.pressureInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pressureLabel
            // 
            this.pressureLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pressureLabel.Location = new System.Drawing.Point(-6, 301);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(166, 36);
            this.pressureLabel.TabIndex = 17;
            this.pressureLabel.Text = "Pressure(mb):";
            this.pressureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // visibilityInfo
            // 
            this.visibilityInfo.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visibilityInfo.Location = new System.Drawing.Point(372, 365);
            this.visibilityInfo.Name = "visibilityInfo";
            this.visibilityInfo.Size = new System.Drawing.Size(109, 36);
            this.visibilityInfo.TabIndex = 24;
            this.visibilityInfo.Text = "N/A";
            this.visibilityInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VisibilityLabel
            // 
            this.VisibilityLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VisibilityLabel.Location = new System.Drawing.Point(256, 365);
            this.VisibilityLabel.Name = "VisibilityLabel";
            this.VisibilityLabel.Size = new System.Drawing.Size(110, 36);
            this.VisibilityLabel.TabIndex = 23;
            this.VisibilityLabel.Text = "Visibility:";
            this.VisibilityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // airQualityInfo
            // 
            this.airQualityInfo.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.airQualityInfo.Location = new System.Drawing.Point(129, 365);
            this.airQualityInfo.Name = "airQualityInfo";
            this.airQualityInfo.Size = new System.Drawing.Size(97, 36);
            this.airQualityInfo.TabIndex = 22;
            this.airQualityInfo.Text = "N/A";
            this.airQualityInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // airQualityLabel
            // 
            this.airQualityLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.airQualityLabel.Location = new System.Drawing.Point(-6, 365);
            this.airQualityLabel.Name = "airQualityLabel";
            this.airQualityLabel.Size = new System.Drawing.Size(145, 36);
            this.airQualityLabel.TabIndex = 21;
            this.airQualityLabel.Text = "Air Quality:";
            this.airQualityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonRecommendations
            // 
            this.buttonRecommendations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRecommendations.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRecommendations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRecommendations.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonRecommendations.FlatAppearance.BorderSize = 0;
            this.buttonRecommendations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecommendations.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRecommendations.ForeColor = System.Drawing.Color.Transparent;
            this.buttonRecommendations.Location = new System.Drawing.Point(117, 490);
            this.buttonRecommendations.Name = "buttonRecommendations";
            this.buttonRecommendations.Size = new System.Drawing.Size(244, 36);
            this.buttonRecommendations.TabIndex = 1;
            this.buttonRecommendations.Text = "CHECK RECOMMENDATIONS";
            this.buttonRecommendations.UseVisualStyleBackColor = false;
            // 
            // mainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WeatherMeApp.Properties.Resources.background_final;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1424, 912);
            this.Controls.Add(this.cityFieldTableLayout);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.weatherInfoGroupBox);
            this.MaximizeBox = false;
            this.Name = "mainPageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainPageForm";
            this.weatherInfoGroupBox.ResumeLayout(false);
            this.cityFieldTableLayout.ResumeLayout(false);
            this.cityFieldTableLayout.PerformLayout();
            this.weatherInfoCurrent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox weatherInfoGroupBox;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox cityField;
        private System.Windows.Forms.TableLayoutPanel cityFieldTableLayout;
        private System.Windows.Forms.GroupBox weatherInfoCurrent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label datetimeInfo;
        private System.Windows.Forms.Label datetimeLabel;
        private System.Windows.Forms.Label cityInfo;
        private System.Windows.Forms.Label temperatureInfo;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.Label visibilityInfo;
        private System.Windows.Forms.Label VisibilityLabel;
        private System.Windows.Forms.Label airQualityInfo;
        private System.Windows.Forms.Label airQualityLabel;
        private System.Windows.Forms.Label uvIndexInfo;
        private System.Windows.Forms.Label uvIndexLabel;
        private System.Windows.Forms.Label pressureInfo;
        private System.Windows.Forms.Label pressureLabel;
        private System.Windows.Forms.Label sunSetInfo;
        private System.Windows.Forms.Label sunsetLabel;
        private System.Windows.Forms.Label sunriseInfo;
        private System.Windows.Forms.Label sunriseLabel;
        private System.Windows.Forms.Label windDirInfo;
        private System.Windows.Forms.Label windDirLabel;
        private System.Windows.Forms.Label windspeedInfo;
        private System.Windows.Forms.Label windspeedLabel;
        private System.Windows.Forms.Label feelsLikeInfo;
        private System.Windows.Forms.Label feelsLikeLabel;
        private System.Windows.Forms.Button buttonRecommendations;
    }
}

namespace BookStoreManagement.Managements
{
    partial class Music
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Music));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.txt_chose = new System.Windows.Forms.Button();
            this.txt_start = new System.Windows.Forms.Button();
            this.txt_stop = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.ListBox();
            this.txt_choseplaylist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(57, 28);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(389, 288);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // txt_chose
            // 
            this.txt_chose.Location = new System.Drawing.Point(498, 51);
            this.txt_chose.Name = "txt_chose";
            this.txt_chose.Size = new System.Drawing.Size(75, 38);
            this.txt_chose.TabIndex = 1;
            this.txt_chose.Text = "Chose File";
            this.txt_chose.UseVisualStyleBackColor = true;
            this.txt_chose.Click += new System.EventHandler(this.txt_chose_Click);
            // 
            // txt_start
            // 
            this.txt_start.Location = new System.Drawing.Point(617, 28);
            this.txt_start.Name = "txt_start";
            this.txt_start.Size = new System.Drawing.Size(113, 38);
            this.txt_start.TabIndex = 2;
            this.txt_start.Text = "Start";
            this.txt_start.UseVisualStyleBackColor = true;
            this.txt_start.Click += new System.EventHandler(this.txt_start_Click);
            // 
            // txt_stop
            // 
            this.txt_stop.Location = new System.Drawing.Point(617, 72);
            this.txt_stop.Name = "txt_stop";
            this.txt_stop.Size = new System.Drawing.Size(113, 39);
            this.txt_stop.TabIndex = 3;
            this.txt_stop.Text = "Stop";
            this.txt_stop.UseVisualStyleBackColor = true;
            this.txt_stop.Click += new System.EventHandler(this.txt_stop_Click);
            // 
            // List
            // 
            this.List.FormattingEnabled = true;
            this.List.Location = new System.Drawing.Point(486, 131);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(261, 121);
            this.List.TabIndex = 5;
            this.List.SelectedIndexChanged += new System.EventHandler(this.List_SelectedIndexChanged);
            // 
            // txt_choseplaylist
            // 
            this.txt_choseplaylist.Location = new System.Drawing.Point(581, 286);
            this.txt_choseplaylist.Name = "txt_choseplaylist";
            this.txt_choseplaylist.Size = new System.Drawing.Size(81, 30);
            this.txt_choseplaylist.TabIndex = 6;
            this.txt_choseplaylist.Text = "Chose Playlist";
            this.txt_choseplaylist.UseVisualStyleBackColor = true;
            this.txt_choseplaylist.Click += new System.EventHandler(this.txt_choseplaylist_Click);
            // 
            // Music
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_choseplaylist);
            this.Controls.Add(this.List);
            this.Controls.Add(this.txt_stop);
            this.Controls.Add(this.txt_start);
            this.Controls.Add(this.txt_chose);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Music";
            this.Size = new System.Drawing.Size(783, 373);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button txt_chose;
        private System.Windows.Forms.Button txt_start;
        private System.Windows.Forms.Button txt_stop;
        private System.Windows.Forms.ListBox List;
        private System.Windows.Forms.Button txt_choseplaylist;
    }
}

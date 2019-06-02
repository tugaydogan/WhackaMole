namespace WhackAMole.UI
{
    partial class MoleGameForm
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
            this.components = new System.ComponentModel.Container();
            this.btn_Start = new System.Windows.Forms.Button();
            this.grp_Game = new System.Windows.Forms.GroupBox();
            this.menuStrip_Mole = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmr_Game = new System.Windows.Forms.Timer(this.components);
            this.tmr_Open = new System.Windows.Forms.Timer(this.components);
            this.tmr_Close = new System.Windows.Forms.Timer(this.components);
            this.lbl_Player = new System.Windows.Forms.Label();
            this.menuStrip_Mole.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(267, 71);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // grp_Game
            // 
            this.grp_Game.Location = new System.Drawing.Point(12, 100);
            this.grp_Game.Name = "grp_Game";
            this.grp_Game.Size = new System.Drawing.Size(582, 504);
            this.grp_Game.TabIndex = 1;
            this.grp_Game.TabStop = false;
            // 
            // menuStrip_Mole
            // 
            this.menuStrip_Mole.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip_Mole.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Mole.Name = "menuStrip_Mole";
            this.menuStrip_Mole.Size = new System.Drawing.Size(606, 24);
            this.menuStrip_Mole.TabIndex = 2;
            this.menuStrip_Mole.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // tmr_Game
            // 
            this.tmr_Game.Tick += new System.EventHandler(this.tmr_Game_Tick);
            // 
            // tmr_Open
            // 
            this.tmr_Open.Tick += new System.EventHandler(this.tmr_Open_Tick);
            // 
            // tmr_Close
            // 
            this.tmr_Close.Interval = 2000;
            this.tmr_Close.Tick += new System.EventHandler(this.tmr_Close_Tick);
            // 
            // lbl_Player
            // 
            this.lbl_Player.AutoSize = true;
            this.lbl_Player.Location = new System.Drawing.Point(504, 71);
            this.lbl_Player.Name = "lbl_Player";
            this.lbl_Player.Size = new System.Drawing.Size(0, 13);
            this.lbl_Player.TabIndex = 3;
            // 
            // MoleGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 616);
            this.Controls.Add(this.lbl_Player);
            this.Controls.Add(this.grp_Game);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.menuStrip_Mole);
            this.MainMenuStrip = this.menuStrip_Mole;
            this.Name = "MoleGameForm";
            this.Text = "Whack a Mole";
            this.menuStrip_Mole.ResumeLayout(false);
            this.menuStrip_Mole.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.GroupBox grp_Game;
        private System.Windows.Forms.MenuStrip menuStrip_Mole;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer tmr_Game;
        private System.Windows.Forms.Timer tmr_Open;
        private System.Windows.Forms.Timer tmr_Close;
        private System.Windows.Forms.Label lbl_Player;
    }
}
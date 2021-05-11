
namespace pong
{
    partial class main
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
            this.player1 = new System.Windows.Forms.Panel();
            this.player2 = new System.Windows.Forms.Panel();
            this.score_label = new System.Windows.Forms.Label();
            this.player1_coord_label = new System.Windows.Forms.Label();
            this.fps_label = new System.Windows.Forms.Label();
            this.ball_position_label = new System.Windows.Forms.Label();
            this.debug_panel = new System.Windows.Forms.Panel();
            this.debug_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.White;
            this.player1.Location = new System.Drawing.Point(0, 189);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(26, 152);
            this.player1.TabIndex = 0;
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.White;
            this.player2.Location = new System.Drawing.Point(803, 189);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(26, 152);
            this.player2.TabIndex = 1;
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.BackColor = System.Drawing.Color.Transparent;
            this.score_label.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.score_label.Location = new System.Drawing.Point(286, 201);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(256, 128);
            this.score_label.TabIndex = 2;
            this.score_label.Text = "0 - 0";
            // 
            // player1_coord_label
            // 
            this.player1_coord_label.AutoSize = true;
            this.player1_coord_label.BackColor = System.Drawing.Color.Transparent;
            this.player1_coord_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1_coord_label.Location = new System.Drawing.Point(3, 9);
            this.player1_coord_label.Name = "player1_coord_label";
            this.player1_coord_label.Size = new System.Drawing.Size(77, 17);
            this.player1_coord_label.TabIndex = 3;
            this.player1_coord_label.Text = "player: (X,Y)";
            // 
            // fps_label
            // 
            this.fps_label.AutoSize = true;
            this.fps_label.BackColor = System.Drawing.Color.Transparent;
            this.fps_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fps_label.Location = new System.Drawing.Point(123, 9);
            this.fps_label.Name = "fps_label";
            this.fps_label.Size = new System.Drawing.Size(29, 17);
            this.fps_label.TabIndex = 4;
            this.fps_label.Text = "fps:";
            // 
            // ball_position_label
            // 
            this.ball_position_label.AutoSize = true;
            this.ball_position_label.BackColor = System.Drawing.Color.Transparent;
            this.ball_position_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ball_position_label.Location = new System.Drawing.Point(3, 33);
            this.ball_position_label.Name = "ball_position_label";
            this.ball_position_label.Size = new System.Drawing.Size(62, 17);
            this.ball_position_label.TabIndex = 5;
            this.ball_position_label.Text = "ball: (X,Y)";
            // 
            // debug_panel
            // 
            this.debug_panel.BackColor = System.Drawing.Color.Transparent;
            this.debug_panel.Controls.Add(this.player1_coord_label);
            this.debug_panel.Controls.Add(this.fps_label);
            this.debug_panel.Controls.Add(this.ball_position_label);
            this.debug_panel.Location = new System.Drawing.Point(0, 0);
            this.debug_panel.Name = "debug_panel";
            this.debug_panel.Size = new System.Drawing.Size(240, 80);
            this.debug_panel.TabIndex = 6;
            this.debug_panel.Visible = false;
            this.debug_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.debug_panel_Paint);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(828, 531);
            this.Controls.Add(this.debug_panel);
            this.Controls.Add(this.score_label);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.main_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCircle);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.main_MouseDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.main_PreviewKeyDown);
            this.debug_panel.ResumeLayout(false);
            this.debug_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel player1;
        private System.Windows.Forms.Panel player2;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Label player1_coord_label;
        private System.Windows.Forms.Label fps_label;
        private System.Windows.Forms.Label ball_position_label;
        private System.Windows.Forms.Panel debug_panel;
    }
}


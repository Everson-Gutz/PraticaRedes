namespace TrocaMensagens
{
    partial class frmTrocaMensagens
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
            this.grdUsuarios = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vitórias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbMessage = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbcChats = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFinishRound = new System.Windows.Forms.Button();
            this.btnGetCard = new System.Windows.Forms.Button();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.txbGameLog = new System.Windows.Forms.RichTextBox();
            this.grdPlayers = new System.Windows.Forms.DataGridView();
            this.IdPlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // grdUsuarios
            // 
            this.grdUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Vitórias});
            this.grdUsuarios.Location = new System.Drawing.Point(565, 12);
            this.grdUsuarios.Name = "grdUsuarios";
            this.grdUsuarios.ReadOnly = true;
            this.grdUsuarios.Size = new System.Drawing.Size(444, 269);
            this.grdUsuarios.TabIndex = 5;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Vitórias
            // 
            this.Vitórias.HeaderText = "Vitórias";
            this.Vitórias.Name = "Vitórias";
            this.Vitórias.ReadOnly = true;
            // 
            // txbMessage
            // 
            this.txbMessage.Location = new System.Drawing.Point(13, 230);
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.Size = new System.Drawing.Size(450, 51);
            this.txbMessage.TabIndex = 6;
            this.txbMessage.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(469, 230);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(91, 51);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbcChats
            // 
            this.tbcChats.Location = new System.Drawing.Point(13, 13);
            this.tbcChats.Name = "tbcChats";
            this.tbcChats.SelectedIndex = 0;
            this.tbcChats.Size = new System.Drawing.Size(546, 211);
            this.tbcChats.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.grdPlayers);
            this.panel1.Controls.Add(this.btnFinishRound);
            this.panel1.Controls.Add(this.btnGetCard);
            this.panel1.Controls.Add(this.btnStartStop);
            this.panel1.Controls.Add(this.txbGameLog);
            this.panel1.Location = new System.Drawing.Point(12, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 236);
            this.panel1.TabIndex = 9;
            // 
            // btnFinishRound
            // 
            this.btnFinishRound.Enabled = false;
            this.btnFinishRound.Location = new System.Drawing.Point(454, 182);
            this.btnFinishRound.Name = "btnFinishRound";
            this.btnFinishRound.Size = new System.Drawing.Size(85, 46);
            this.btnFinishRound.TabIndex = 3;
            this.btnFinishRound.Text = "Terminar rodada";
            this.btnFinishRound.UseVisualStyleBackColor = true;
            this.btnFinishRound.Click += new System.EventHandler(this.btnFinishRound_Click);
            // 
            // btnGetCard
            // 
            this.btnGetCard.Enabled = false;
            this.btnGetCard.Location = new System.Drawing.Point(455, 93);
            this.btnGetCard.Name = "btnGetCard";
            this.btnGetCard.Size = new System.Drawing.Size(85, 46);
            this.btnGetCard.TabIndex = 2;
            this.btnGetCard.Text = "Pegar uma carta";
            this.btnGetCard.UseVisualStyleBackColor = true;
            this.btnGetCard.Click += new System.EventHandler(this.btnGetCard_Click);
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(455, 4);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(85, 46);
            this.btnStartStop.TabIndex = 1;
            this.btnStartStop.Text = "Iniciar";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // txbGameLog
            // 
            this.txbGameLog.Location = new System.Drawing.Point(4, 4);
            this.txbGameLog.Name = "txbGameLog";
            this.txbGameLog.ReadOnly = true;
            this.txbGameLog.Size = new System.Drawing.Size(444, 225);
            this.txbGameLog.TabIndex = 0;
            this.txbGameLog.Text = "";
            // 
            // grdPlayers
            // 
            this.grdPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPlayer,
            this.PlayerStatus});
            this.grdPlayers.Location = new System.Drawing.Point(553, -2);
            this.grdPlayers.Name = "grdPlayers";
            this.grdPlayers.ReadOnly = true;
            this.grdPlayers.Size = new System.Drawing.Size(444, 236);
            this.grdPlayers.TabIndex = 10;
            // 
            // IdPlayer
            // 
            this.IdPlayer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdPlayer.FillWeight = 25F;
            this.IdPlayer.HeaderText = "ID";
            this.IdPlayer.Name = "IdPlayer";
            this.IdPlayer.ReadOnly = true;
            // 
            // PlayerStatus
            // 
            this.PlayerStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PlayerStatus.HeaderText = "Status";
            this.PlayerStatus.Name = "PlayerStatus";
            this.PlayerStatus.ReadOnly = true;
            // 
            // frmTrocaMensagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbcChats);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txbMessage);
            this.Controls.Add(this.grdUsuarios);
            this.Name = "frmTrocaMensagens";
            this.Text = "Troca de mensagens";
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPlayers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView grdUsuarios;
        private System.Windows.Forms.RichTextBox txbMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TabControl tbcChats;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vitórias;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGetCard;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.RichTextBox txbGameLog;
        private System.Windows.Forms.DataGridView grdPlayers;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerStatus;
        private System.Windows.Forms.Button btnFinishRound;
    }
}


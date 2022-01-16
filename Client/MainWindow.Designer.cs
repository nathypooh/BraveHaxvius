using System.Windows.Forms;

namespace Client
{
    partial class MainWindow
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.injectionTab = new System.Windows.Forms.TabPage();
            this.injectDataGrid = new System.Windows.Forms.DataGridView();
            this.injectSearchInput = new System.Windows.Forms.TextBox();
            this.injectButton = new System.Windows.Forms.Button();
            this.unitHunterTab = new System.Windows.Forms.TabPage();
            this.sell4Star = new System.Windows.Forms.CheckBox();
            this.sell5Star = new System.Windows.Forms.CheckBox();
            this.sell3Star = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.unitSelect = new System.Windows.Forms.ComboBox();
            this.summonButton = new System.Windows.Forms.Button();
            this.missionsTab = new System.Windows.Forms.TabPage();
            this.energyButton = new System.Windows.Forms.Button();
            this.addToQueueBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.startQueuedMissions = new System.Windows.Forms.Button();
            this.queuedMissions = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.raidPartySelect = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.partySelect = new System.Windows.Forms.ComboBox();
            this.RaidMissionLabel = new System.Windows.Forms.Label();
            this.RaidMissionSelect = new System.Windows.Forms.ComboBox();
            this.Do_Raid = new System.Windows.Forms.CheckBox();
            this.Do_Arena = new System.Windows.Forms.CheckBox();
            this.CBIsParadeMissionEnd = new System.Windows.Forms.CheckBox();
            this.RepeatMission = new System.Windows.Forms.NumericUpDown();
            this.StartMission = new System.Windows.Forms.Button();
            this.RepeatLabel = new System.Windows.Forms.Label();
            this.RBAmazon = new System.Windows.Forms.RadioButton();
            this.RBAndroid = new System.Windows.Forms.RadioButton();
            this.RBiOS = new System.Windows.Forms.RadioButton();
            this.LBLevel = new System.Windows.Forms.TextBox();
            this.LBLabel = new System.Windows.Forms.Label();
            this.CBExplore = new System.Windows.Forms.CheckBox();
            this.CBUnits = new System.Windows.Forms.CheckBox();
            this.CBLoot = new System.Windows.Forms.CheckBox();
            this.CBChallenge = new System.Windows.Forms.CheckBox();
            this.CBTrophies = new System.Windows.Forms.CheckBox();
            this.CBFriends = new System.Windows.Forms.CheckBox();
            this.MissionIdLabel = new System.Windows.Forms.Label();
            this.missionSelect = new System.Windows.Forms.ComboBox();
            this.levelingTab = new System.Windows.Forms.TabPage();
            this.arenaButton = new System.Windows.Forms.Button();
            this.rankUpButton = new System.Windows.Forms.Button();
            this.levelStatus = new System.Windows.Forms.RichTextBox();
            this.levelPartyButton = new System.Windows.Forms.Button();
            this.sellTab = new System.Windows.Forms.TabPage();
            this.sellItemSelect = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sellButton = new System.Windows.Forms.Button();
            this.jpSummonTab = new System.Windows.Forms.TabPage();
            this.JPGachaTicket = new System.Windows.Forms.ComboBox();
            this.JPLogin = new System.Windows.Forms.Button();
            this.GachaSummon = new System.Windows.Forms.Button();
            this.JPGacha = new System.Windows.Forms.ComboBox();
            this.newMailTab = new System.Windows.Forms.TabPage();
            this.mailDataGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.NewdataGrid = new System.Windows.Forms.DataGridView();
            this.weaponTab = new System.Windows.Forms.TabPage();
            this.Equip_Pic = new System.Windows.Forms.PictureBox();
            this.IWGrid = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.consoleLog = new System.Windows.Forms.RichTextBox();
            this.ProxyPort = new System.Windows.Forms.TextBox();
            this.ProxyIP = new System.Windows.Forms.TextBox();
            this.fbtokenInput = new System.Windows.Forms.TextBox();
            this.fbidInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.injectionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.injectDataGrid)).BeginInit();
            this.unitHunterTab.SuspendLayout();
            this.missionsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RepeatMission)).BeginInit();
            this.levelingTab.SuspendLayout();
            this.sellTab.SuspendLayout();
            this.jpSummonTab.SuspendLayout();
            this.newMailTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mailDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewdataGrid)).BeginInit();
            this.weaponTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Equip_Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IWGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.injectionTab);
            this.tabControl1.Controls.Add(this.unitHunterTab);
            this.tabControl1.Controls.Add(this.missionsTab);
            this.tabControl1.Controls.Add(this.levelingTab);
            this.tabControl1.Controls.Add(this.sellTab);
            this.tabControl1.Controls.Add(this.jpSummonTab);
            this.tabControl1.Controls.Add(this.newMailTab);
            this.tabControl1.Controls.Add(this.weaponTab);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(905, 343);
            this.tabControl1.TabIndex = 2;
            // 
            // injectionTab
            // 
            this.injectionTab.Controls.Add(this.injectDataGrid);
            this.injectionTab.Controls.Add(this.injectSearchInput);
            this.injectionTab.Controls.Add(this.injectButton);
            this.injectionTab.Location = new System.Drawing.Point(4, 22);
            this.injectionTab.Name = "injectionTab";
            this.injectionTab.Padding = new System.Windows.Forms.Padding(3);
            this.injectionTab.Size = new System.Drawing.Size(897, 317);
            this.injectionTab.TabIndex = 0;
            this.injectionTab.Text = "Injection";
            this.injectionTab.UseVisualStyleBackColor = true;
            // 
            // injectDataGrid
            // 
            this.injectDataGrid.AllowUserToAddRows = false;
            this.injectDataGrid.AllowUserToDeleteRows = false;
            this.injectDataGrid.AllowUserToResizeRows = false;
            this.injectDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.injectDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.injectDataGrid.Location = new System.Drawing.Point(3, 3);
            this.injectDataGrid.Name = "injectDataGrid";
            this.injectDataGrid.RowHeadersVisible = false;
            this.injectDataGrid.Size = new System.Drawing.Size(772, 165);
            this.injectDataGrid.TabIndex = 3;
            // 
            // injectSearchInput
            // 
            this.injectSearchInput.Location = new System.Drawing.Point(3, 182);
            this.injectSearchInput.Name = "injectSearchInput";
            this.injectSearchInput.Size = new System.Drawing.Size(253, 20);
            this.injectSearchInput.TabIndex = 2;
            this.injectSearchInput.Text = "search";
            this.injectSearchInput.TextChanged += new System.EventHandler(this.InjectSearchInput_TextChanged);
            // 
            // injectButton
            // 
            this.injectButton.Enabled = false;
            this.injectButton.Location = new System.Drawing.Point(698, 176);
            this.injectButton.Name = "injectButton";
            this.injectButton.Size = new System.Drawing.Size(77, 23);
            this.injectButton.TabIndex = 1;
            this.injectButton.Text = "inject";
            this.injectButton.UseVisualStyleBackColor = true;
            this.injectButton.Click += new System.EventHandler(this.InjectButton_Click);
            // 
            // unitHunterTab
            // 
            this.unitHunterTab.Controls.Add(this.sell4Star);
            this.unitHunterTab.Controls.Add(this.sell5Star);
            this.unitHunterTab.Controls.Add(this.sell3Star);
            this.unitHunterTab.Controls.Add(this.label5);
            this.unitHunterTab.Controls.Add(this.unitSelect);
            this.unitHunterTab.Controls.Add(this.summonButton);
            this.unitHunterTab.Location = new System.Drawing.Point(4, 22);
            this.unitHunterTab.Name = "unitHunterTab";
            this.unitHunterTab.Padding = new System.Windows.Forms.Padding(3);
            this.unitHunterTab.Size = new System.Drawing.Size(897, 317);
            this.unitHunterTab.TabIndex = 1;
            this.unitHunterTab.Text = "Unit Hunter";
            this.unitHunterTab.UseVisualStyleBackColor = true;
            // 
            // sell4Star
            // 
            this.sell4Star.AutoSize = true;
            this.sell4Star.Checked = true;
            this.sell4Star.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sell4Star.Location = new System.Drawing.Point(56, 57);
            this.sell4Star.Name = "sell4Star";
            this.sell4Star.Size = new System.Drawing.Size(56, 17);
            this.sell4Star.TabIndex = 7;
            this.sell4Star.Text = "Sell 4*";
            this.sell4Star.UseVisualStyleBackColor = true;
            // 
            // sell5Star
            // 
            this.sell5Star.AutoSize = true;
            this.sell5Star.Location = new System.Drawing.Point(56, 80);
            this.sell5Star.Name = "sell5Star";
            this.sell5Star.Size = new System.Drawing.Size(56, 17);
            this.sell5Star.TabIndex = 6;
            this.sell5Star.Text = "Sell 5*";
            this.sell5Star.UseVisualStyleBackColor = true;
            // 
            // sell3Star
            // 
            this.sell3Star.AutoSize = true;
            this.sell3Star.Checked = true;
            this.sell3Star.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sell3Star.Location = new System.Drawing.Point(56, 34);
            this.sell3Star.Name = "sell3Star";
            this.sell3Star.Size = new System.Drawing.Size(56, 17);
            this.sell3Star.TabIndex = 5;
            this.sell3Star.Text = "Sell 3*";
            this.sell3Star.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Unit";
            // 
            // unitSelect
            // 
            this.unitSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.unitSelect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.unitSelect.FormattingEnabled = true;
            this.unitSelect.Location = new System.Drawing.Point(56, 6);
            this.unitSelect.Name = "unitSelect";
            this.unitSelect.Size = new System.Drawing.Size(169, 21);
            this.unitSelect.TabIndex = 3;
            // 
            // summonButton
            // 
            this.summonButton.Location = new System.Drawing.Point(696, 176);
            this.summonButton.Name = "summonButton";
            this.summonButton.Size = new System.Drawing.Size(79, 23);
            this.summonButton.TabIndex = 2;
            this.summonButton.Text = "summon";
            this.summonButton.UseVisualStyleBackColor = true;
            this.summonButton.Click += new System.EventHandler(this.SummonButton_Click);
            // 
            // missionsTab
            // 
            this.missionsTab.Controls.Add(this.energyButton);
            this.missionsTab.Controls.Add(this.addToQueueBtn);
            this.missionsTab.Controls.Add(this.button3);
            this.missionsTab.Controls.Add(this.startQueuedMissions);
            this.missionsTab.Controls.Add(this.queuedMissions);
            this.missionsTab.Controls.Add(this.label8);
            this.missionsTab.Controls.Add(this.raidPartySelect);
            this.missionsTab.Controls.Add(this.label7);
            this.missionsTab.Controls.Add(this.partySelect);
            this.missionsTab.Controls.Add(this.RaidMissionLabel);
            this.missionsTab.Controls.Add(this.RaidMissionSelect);
            this.missionsTab.Controls.Add(this.Do_Raid);
            this.missionsTab.Controls.Add(this.Do_Arena);
            this.missionsTab.Controls.Add(this.CBIsParadeMissionEnd);
            this.missionsTab.Controls.Add(this.RepeatMission);
            this.missionsTab.Controls.Add(this.StartMission);
            this.missionsTab.Controls.Add(this.RepeatLabel);
            this.missionsTab.Controls.Add(this.RBAmazon);
            this.missionsTab.Controls.Add(this.RBAndroid);
            this.missionsTab.Controls.Add(this.RBiOS);
            this.missionsTab.Controls.Add(this.LBLevel);
            this.missionsTab.Controls.Add(this.LBLabel);
            this.missionsTab.Controls.Add(this.CBExplore);
            this.missionsTab.Controls.Add(this.CBUnits);
            this.missionsTab.Controls.Add(this.CBLoot);
            this.missionsTab.Controls.Add(this.CBChallenge);
            this.missionsTab.Controls.Add(this.CBTrophies);
            this.missionsTab.Controls.Add(this.CBFriends);
            this.missionsTab.Controls.Add(this.MissionIdLabel);
            this.missionsTab.Controls.Add(this.missionSelect);
            this.missionsTab.Location = new System.Drawing.Point(4, 22);
            this.missionsTab.Name = "missionsTab";
            this.missionsTab.Size = new System.Drawing.Size(897, 317);
            this.missionsTab.TabIndex = 4;
            this.missionsTab.Text = "Missions";
            this.missionsTab.UseVisualStyleBackColor = true;
            // 
            // energyButton
            // 
            this.energyButton.Location = new System.Drawing.Point(819, 10);
            this.energyButton.Name = "energyButton";
            this.energyButton.Size = new System.Drawing.Size(75, 23);
            this.energyButton.TabIndex = 31;
            this.energyButton.Text = "Energy: ";
            this.energyButton.UseVisualStyleBackColor = true;
            this.energyButton.Click += new System.EventHandler(this.energyButton_Click);
            // 
            // addToQueueBtn
            // 
            this.addToQueueBtn.Location = new System.Drawing.Point(451, 6);
            this.addToQueueBtn.Name = "addToQueueBtn";
            this.addToQueueBtn.Size = new System.Drawing.Size(86, 23);
            this.addToQueueBtn.TabIndex = 30;
            this.addToQueueBtn.Text = "Add to Queue";
            this.addToQueueBtn.UseVisualStyleBackColor = true;
            this.addToQueueBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCoral;
            this.button3.Location = new System.Drawing.Point(819, 289);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "End Missions";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // startQueuedMissions
            // 
            this.startQueuedMissions.BackColor = System.Drawing.Color.Yellow;
            this.startQueuedMissions.Location = new System.Drawing.Point(733, 260);
            this.startQueuedMissions.Name = "startQueuedMissions";
            this.startQueuedMissions.Size = new System.Drawing.Size(75, 23);
            this.startQueuedMissions.TabIndex = 28;
            this.startQueuedMissions.Text = "Start Queue";
            this.startQueuedMissions.UseVisualStyleBackColor = false;
            this.startQueuedMissions.Click += new System.EventHandler(this.startQueuedMissions_Click);
            // 
            // queuedMissions
            // 
            this.queuedMissions.FormattingEnabled = true;
            this.queuedMissions.Location = new System.Drawing.Point(177, 135);
            this.queuedMissions.Name = "queuedMissions";
            this.queuedMissions.Size = new System.Drawing.Size(430, 173);
            this.queuedMissions.TabIndex = 26;
            this.queuedMissions.SelectedIndexChanged += new System.EventHandler(this.queuedMissions_SelectedIndexChanged);
            this.queuedMissions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.queuedMissions_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Raid Party";
            // 
            // raidPartySelect
            // 
            this.raidPartySelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.raidPartySelect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.raidPartySelect.FormattingEnabled = true;
            this.raidPartySelect.Location = new System.Drawing.Point(74, 159);
            this.raidPartySelect.Name = "raidPartySelect";
            this.raidPartySelect.Size = new System.Drawing.Size(73, 21);
            this.raidPartySelect.TabIndex = 24;
            this.raidPartySelect.SelectedIndexChanged += new System.EventHandler(this.raidPartySelect_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Select Party";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // partySelect
            // 
            this.partySelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.partySelect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.partySelect.FormattingEnabled = true;
            this.partySelect.Location = new System.Drawing.Point(75, 132);
            this.partySelect.Name = "partySelect";
            this.partySelect.Size = new System.Drawing.Size(72, 21);
            this.partySelect.TabIndex = 22;
            this.partySelect.SelectedIndexChanged += new System.EventHandler(this.partySelect_SelectedIndexChanged);
            // 
            // RaidMissionLabel
            // 
            this.RaidMissionLabel.AutoSize = true;
            this.RaidMissionLabel.Location = new System.Drawing.Point(317, 84);
            this.RaidMissionLabel.Name = "RaidMissionLabel";
            this.RaidMissionLabel.Size = new System.Drawing.Size(81, 13);
            this.RaidMissionLabel.TabIndex = 21;
            this.RaidMissionLabel.Text = "Raid Mission ID";
            // 
            // RaidMissionSelect
            // 
            this.RaidMissionSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.RaidMissionSelect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.RaidMissionSelect.FormattingEnabled = true;
            this.RaidMissionSelect.Location = new System.Drawing.Point(404, 79);
            this.RaidMissionSelect.Name = "RaidMissionSelect";
            this.RaidMissionSelect.Size = new System.Drawing.Size(380, 21);
            this.RaidMissionSelect.TabIndex = 20;
            // 
            // Do_Raid
            // 
            this.Do_Raid.AutoSize = true;
            this.Do_Raid.Location = new System.Drawing.Point(405, 57);
            this.Do_Raid.Name = "Do_Raid";
            this.Do_Raid.Size = new System.Drawing.Size(65, 17);
            this.Do_Raid.TabIndex = 19;
            this.Do_Raid.Text = "Do Raid";
            this.Do_Raid.UseVisualStyleBackColor = true;
            this.Do_Raid.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Do_Arena
            // 
            this.Do_Arena.AutoSize = true;
            this.Do_Arena.Location = new System.Drawing.Point(405, 35);
            this.Do_Arena.Name = "Do_Arena";
            this.Do_Arena.Size = new System.Drawing.Size(71, 17);
            this.Do_Arena.TabIndex = 18;
            this.Do_Arena.Text = "Do Arena";
            this.Do_Arena.UseVisualStyleBackColor = true;
            this.Do_Arena.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CBIsParadeMissionEnd
            // 
            this.CBIsParadeMissionEnd.AutoSize = true;
            this.CBIsParadeMissionEnd.Location = new System.Drawing.Point(482, 35);
            this.CBIsParadeMissionEnd.Name = "CBIsParadeMissionEnd";
            this.CBIsParadeMissionEnd.Size = new System.Drawing.Size(125, 17);
            this.CBIsParadeMissionEnd.TabIndex = 17;
            this.CBIsParadeMissionEnd.Text = "Is PadareMissionEnd";
            this.CBIsParadeMissionEnd.UseVisualStyleBackColor = true;
            // 
            // RepeatMission
            // 
            this.RepeatMission.Location = new System.Drawing.Point(201, 77);
            this.RepeatMission.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.RepeatMission.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RepeatMission.Name = "RepeatMission";
            this.RepeatMission.Size = new System.Drawing.Size(100, 20);
            this.RepeatMission.TabIndex = 16;
            this.RepeatMission.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // StartMission
            // 
            this.StartMission.BackColor = System.Drawing.Color.PaleGreen;
            this.StartMission.Location = new System.Drawing.Point(733, 289);
            this.StartMission.Name = "StartMission";
            this.StartMission.Size = new System.Drawing.Size(75, 23);
            this.StartMission.TabIndex = 4;
            this.StartMission.Text = "Start";
            this.StartMission.UseVisualStyleBackColor = false;
            this.StartMission.Click += new System.EventHandler(this.StartMission_Click);
            // 
            // RepeatLabel
            // 
            this.RepeatLabel.AutoSize = true;
            this.RepeatLabel.Location = new System.Drawing.Point(153, 80);
            this.RepeatLabel.Name = "RepeatLabel";
            this.RepeatLabel.Size = new System.Drawing.Size(42, 13);
            this.RepeatLabel.TabIndex = 15;
            this.RepeatLabel.Text = "Repeat";
            // 
            // RBAmazon
            // 
            this.RBAmazon.AutoSize = true;
            this.RBAmazon.Location = new System.Drawing.Point(177, 103);
            this.RBAmazon.Name = "RBAmazon";
            this.RBAmazon.Size = new System.Drawing.Size(63, 17);
            this.RBAmazon.TabIndex = 14;
            this.RBAmazon.Text = "Amazon";
            this.RBAmazon.UseVisualStyleBackColor = true;
            this.RBAmazon.CheckedChanged += new System.EventHandler(this.RBOS_CheckedChanged);
            // 
            // RBAndroid
            // 
            this.RBAndroid.AutoSize = true;
            this.RBAndroid.Location = new System.Drawing.Point(114, 103);
            this.RBAndroid.Name = "RBAndroid";
            this.RBAndroid.Size = new System.Drawing.Size(61, 17);
            this.RBAndroid.TabIndex = 13;
            this.RBAndroid.Text = "Android";
            this.RBAndroid.UseVisualStyleBackColor = true;
            this.RBAndroid.CheckedChanged += new System.EventHandler(this.RBOS_CheckedChanged);
            // 
            // RBiOS
            // 
            this.RBiOS.AutoSize = true;
            this.RBiOS.Checked = true;
            this.RBiOS.Location = new System.Drawing.Point(65, 103);
            this.RBiOS.Name = "RBiOS";
            this.RBiOS.Size = new System.Drawing.Size(42, 17);
            this.RBiOS.TabIndex = 12;
            this.RBiOS.TabStop = true;
            this.RBiOS.Text = "iOS";
            this.RBiOS.UseVisualStyleBackColor = true;
            this.RBiOS.CheckedChanged += new System.EventHandler(this.RBOS_CheckedChanged);
            // 
            // LBLevel
            // 
            this.LBLevel.Location = new System.Drawing.Point(65, 77);
            this.LBLevel.Name = "LBLevel";
            this.LBLevel.Size = new System.Drawing.Size(82, 20);
            this.LBLevel.TabIndex = 11;
            // 
            // LBLabel
            // 
            this.LBLabel.AutoSize = true;
            this.LBLabel.Location = new System.Drawing.Point(39, 80);
            this.LBLabel.Name = "LBLabel";
            this.LBLabel.Size = new System.Drawing.Size(20, 13);
            this.LBLabel.TabIndex = 10;
            this.LBLabel.Text = "LB";
            // 
            // CBExplore
            // 
            this.CBExplore.AutoSize = true;
            this.CBExplore.Location = new System.Drawing.Point(273, 57);
            this.CBExplore.Name = "CBExplore";
            this.CBExplore.Size = new System.Drawing.Size(128, 17);
            this.CBExplore.TabIndex = 9;
            this.CBExplore.Text = "Exploration Treasures";
            this.CBExplore.UseVisualStyleBackColor = true;
            // 
            // CBUnits
            // 
            this.CBUnits.AutoSize = true;
            this.CBUnits.Location = new System.Drawing.Point(153, 57);
            this.CBUnits.Name = "CBUnits";
            this.CBUnits.Size = new System.Drawing.Size(85, 17);
            this.CBUnits.TabIndex = 8;
            this.CBUnits.Text = "Collect Units";
            this.CBUnits.UseVisualStyleBackColor = true;
            // 
            // CBLoot
            // 
            this.CBLoot.AutoSize = true;
            this.CBLoot.Location = new System.Drawing.Point(65, 57);
            this.CBLoot.Name = "CBLoot";
            this.CBLoot.Size = new System.Drawing.Size(82, 17);
            this.CBLoot.TabIndex = 7;
            this.CBLoot.Text = "Collect Loot";
            this.CBLoot.UseVisualStyleBackColor = true;
            // 
            // CBChallenge
            // 
            this.CBChallenge.AutoSize = true;
            this.CBChallenge.Enabled = false;
            this.CBChallenge.Location = new System.Drawing.Point(273, 34);
            this.CBChallenge.Name = "CBChallenge";
            this.CBChallenge.Size = new System.Drawing.Size(125, 17);
            this.CBChallenge.TabIndex = 6;
            this.CBChallenge.Text = "Complete Challenges";
            this.CBChallenge.UseVisualStyleBackColor = true;
            // 
            // CBTrophies
            // 
            this.CBTrophies.AutoSize = true;
            this.CBTrophies.Location = new System.Drawing.Point(153, 34);
            this.CBTrophies.Name = "CBTrophies";
            this.CBTrophies.Size = new System.Drawing.Size(114, 17);
            this.CBTrophies.TabIndex = 5;
            this.CBTrophies.Text = "Complete Trophies";
            this.CBTrophies.UseVisualStyleBackColor = true;
            this.CBTrophies.CheckedChanged += new System.EventHandler(this.CBTrophies_CheckedChanged);
            // 
            // CBFriends
            // 
            this.CBFriends.AutoSize = true;
            this.CBFriends.Location = new System.Drawing.Point(65, 34);
            this.CBFriends.Name = "CBFriends";
            this.CBFriends.Size = new System.Drawing.Size(82, 17);
            this.CBFriends.TabIndex = 3;
            this.CBFriends.Text = "Use Friends";
            this.CBFriends.UseVisualStyleBackColor = true;
            // 
            // MissionIdLabel
            // 
            this.MissionIdLabel.AutoSize = true;
            this.MissionIdLabel.Location = new System.Drawing.Point(3, 10);
            this.MissionIdLabel.Name = "MissionIdLabel";
            this.MissionIdLabel.Size = new System.Drawing.Size(56, 13);
            this.MissionIdLabel.TabIndex = 2;
            this.MissionIdLabel.Text = "Mission ID";
            // 
            // missionSelect
            // 
            this.missionSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.missionSelect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.missionSelect.FormattingEnabled = true;
            this.missionSelect.Location = new System.Drawing.Point(65, 7);
            this.missionSelect.Name = "missionSelect";
            this.missionSelect.Size = new System.Drawing.Size(380, 21);
            this.missionSelect.TabIndex = 1;
            this.missionSelect.SelectedIndexChanged += new System.EventHandler(this.missionSelect_SelectedIndexChanged);
            // 
            // levelingTab
            // 
            this.levelingTab.Controls.Add(this.arenaButton);
            this.levelingTab.Controls.Add(this.rankUpButton);
            this.levelingTab.Controls.Add(this.levelStatus);
            this.levelingTab.Controls.Add(this.levelPartyButton);
            this.levelingTab.Location = new System.Drawing.Point(4, 22);
            this.levelingTab.Name = "levelingTab";
            this.levelingTab.Size = new System.Drawing.Size(897, 317);
            this.levelingTab.TabIndex = 2;
            this.levelingTab.Text = "Leveling";
            this.levelingTab.UseVisualStyleBackColor = true;
            // 
            // arenaButton
            // 
            this.arenaButton.Location = new System.Drawing.Point(335, 155);
            this.arenaButton.Name = "arenaButton";
            this.arenaButton.Size = new System.Drawing.Size(75, 23);
            this.arenaButton.TabIndex = 3;
            this.arenaButton.Text = "do arena";
            this.arenaButton.UseVisualStyleBackColor = true;
            this.arenaButton.Click += new System.EventHandler(this.arenaButton_Click);
            // 
            // rankUpButton
            // 
            this.rankUpButton.Location = new System.Drawing.Point(432, 155);
            this.rankUpButton.Name = "rankUpButton";
            this.rankUpButton.Size = new System.Drawing.Size(75, 23);
            this.rankUpButton.TabIndex = 2;
            this.rankUpButton.Text = "rank up";
            this.rankUpButton.UseVisualStyleBackColor = true;
            this.rankUpButton.Click += new System.EventHandler(this.RankUpButton_Click);
            // 
            // levelStatus
            // 
            this.levelStatus.Location = new System.Drawing.Point(4, 4);
            this.levelStatus.Name = "levelStatus";
            this.levelStatus.ReadOnly = true;
            this.levelStatus.Size = new System.Drawing.Size(774, 124);
            this.levelStatus.TabIndex = 1;
            this.levelStatus.Text = "status...";
            // 
            // levelPartyButton
            // 
            this.levelPartyButton.Location = new System.Drawing.Point(238, 155);
            this.levelPartyButton.Name = "levelPartyButton";
            this.levelPartyButton.Size = new System.Drawing.Size(75, 23);
            this.levelPartyButton.TabIndex = 0;
            this.levelPartyButton.Text = "level party";
            this.levelPartyButton.UseVisualStyleBackColor = true;
            this.levelPartyButton.Click += new System.EventHandler(this.LevelPartyButton_Click);
            // 
            // sellTab
            // 
            this.sellTab.Controls.Add(this.sellItemSelect);
            this.sellTab.Controls.Add(this.label6);
            this.sellTab.Controls.Add(this.sellButton);
            this.sellTab.Location = new System.Drawing.Point(4, 22);
            this.sellTab.Name = "sellTab";
            this.sellTab.Size = new System.Drawing.Size(897, 317);
            this.sellTab.TabIndex = 5;
            this.sellTab.Text = "Sell";
            this.sellTab.UseVisualStyleBackColor = true;
            // 
            // sellItemSelect
            // 
            this.sellItemSelect.FormattingEnabled = true;
            this.sellItemSelect.Location = new System.Drawing.Point(53, 12);
            this.sellItemSelect.Name = "sellItemSelect";
            this.sellItemSelect.Size = new System.Drawing.Size(317, 21);
            this.sellItemSelect.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Item";
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(699, 178);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(75, 23);
            this.sellButton.TabIndex = 6;
            this.sellButton.Text = "login";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // jpSummonTab
            // 
            this.jpSummonTab.Controls.Add(this.JPGachaTicket);
            this.jpSummonTab.Controls.Add(this.JPLogin);
            this.jpSummonTab.Controls.Add(this.GachaSummon);
            this.jpSummonTab.Controls.Add(this.JPGacha);
            this.jpSummonTab.Location = new System.Drawing.Point(4, 22);
            this.jpSummonTab.Name = "jpSummonTab";
            this.jpSummonTab.Size = new System.Drawing.Size(897, 317);
            this.jpSummonTab.TabIndex = 3;
            this.jpSummonTab.Text = "JP Summon";
            this.jpSummonTab.UseVisualStyleBackColor = true;
            // 
            // JPGachaTicket
            // 
            this.JPGachaTicket.FormattingEnabled = true;
            this.JPGachaTicket.Location = new System.Drawing.Point(389, 35);
            this.JPGachaTicket.Name = "JPGachaTicket";
            this.JPGachaTicket.Size = new System.Drawing.Size(88, 21);
            this.JPGachaTicket.TabIndex = 5;
            // 
            // JPLogin
            // 
            this.JPLogin.Location = new System.Drawing.Point(703, 179);
            this.JPLogin.Name = "JPLogin";
            this.JPLogin.Size = new System.Drawing.Size(75, 23);
            this.JPLogin.TabIndex = 4;
            this.JPLogin.Text = "Login";
            this.JPLogin.UseVisualStyleBackColor = true;
            this.JPLogin.Click += new System.EventHandler(this.JPLogin_Click);
            // 
            // GachaSummon
            // 
            this.GachaSummon.Enabled = false;
            this.GachaSummon.Location = new System.Drawing.Point(703, 35);
            this.GachaSummon.Name = "GachaSummon";
            this.GachaSummon.Size = new System.Drawing.Size(75, 23);
            this.GachaSummon.TabIndex = 1;
            this.GachaSummon.Text = "Summon";
            this.GachaSummon.UseVisualStyleBackColor = true;
            this.GachaSummon.Click += new System.EventHandler(this.GachaSummon_Click);
            // 
            // JPGacha
            // 
            this.JPGacha.FormattingEnabled = true;
            this.JPGacha.Location = new System.Drawing.Point(3, 35);
            this.JPGacha.Name = "JPGacha";
            this.JPGacha.Size = new System.Drawing.Size(380, 21);
            this.JPGacha.TabIndex = 0;
            // 
            // newMailTab
            // 
            this.newMailTab.Controls.Add(this.mailDataGrid);
            this.newMailTab.Controls.Add(this.button1);
            this.newMailTab.Controls.Add(this.NewdataGrid);
            this.newMailTab.Location = new System.Drawing.Point(4, 22);
            this.newMailTab.Name = "newMailTab";
            this.newMailTab.Padding = new System.Windows.Forms.Padding(3);
            this.newMailTab.Size = new System.Drawing.Size(897, 317);
            this.newMailTab.TabIndex = 6;
            this.newMailTab.Text = "New/Mail";
            this.newMailTab.UseVisualStyleBackColor = true;
            // 
            // mailDataGrid
            // 
            this.mailDataGrid.AllowUserToAddRows = false;
            this.mailDataGrid.AllowUserToDeleteRows = false;
            this.mailDataGrid.AllowUserToResizeRows = false;
            this.mailDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mailDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mailDataGrid.Location = new System.Drawing.Point(369, 0);
            this.mailDataGrid.Name = "mailDataGrid";
            this.mailDataGrid.ReadOnly = true;
            this.mailDataGrid.RowHeadersVisible = false;
            this.mailDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mailDataGrid.Size = new System.Drawing.Size(412, 151);
            this.mailDataGrid.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(703, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewdataGrid
            // 
            this.NewdataGrid.AllowUserToAddRows = false;
            this.NewdataGrid.AllowUserToDeleteRows = false;
            this.NewdataGrid.AllowUserToResizeRows = false;
            this.NewdataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NewdataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NewdataGrid.Location = new System.Drawing.Point(0, 3);
            this.NewdataGrid.Name = "NewdataGrid";
            this.NewdataGrid.ReadOnly = true;
            this.NewdataGrid.RowHeadersVisible = false;
            this.NewdataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NewdataGrid.Size = new System.Drawing.Size(354, 196);
            this.NewdataGrid.TabIndex = 0;
            this.NewdataGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NewdataGrid_CellContentClick);
            // 
            // weaponTab
            // 
            this.weaponTab.Controls.Add(this.Equip_Pic);
            this.weaponTab.Controls.Add(this.IWGrid);
            this.weaponTab.Controls.Add(this.button2);
            this.weaponTab.Location = new System.Drawing.Point(4, 22);
            this.weaponTab.Name = "weaponTab";
            this.weaponTab.Padding = new System.Windows.Forms.Padding(3);
            this.weaponTab.Size = new System.Drawing.Size(897, 317);
            this.weaponTab.TabIndex = 7;
            this.weaponTab.Text = "Weapon";
            this.weaponTab.UseVisualStyleBackColor = true;
            // 
            // Equip_Pic
            // 
            this.Equip_Pic.Location = new System.Drawing.Point(659, 34);
            this.Equip_Pic.Name = "Equip_Pic";
            this.Equip_Pic.Size = new System.Drawing.Size(116, 136);
            this.Equip_Pic.TabIndex = 2;
            this.Equip_Pic.TabStop = false;
            // 
            // IWGrid
            // 
            this.IWGrid.AllowUserToAddRows = false;
            this.IWGrid.AllowUserToDeleteRows = false;
            this.IWGrid.AllowUserToResizeRows = false;
            this.IWGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.IWGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IWGrid.Location = new System.Drawing.Point(7, 4);
            this.IWGrid.Name = "IWGrid";
            this.IWGrid.RowHeadersVisible = false;
            this.IWGrid.Size = new System.Drawing.Size(645, 195);
            this.IWGrid.TabIndex = 1;
            this.IWGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NewdataGrid_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(700, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Load Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // consoleLog
            // 
            this.consoleLog.Location = new System.Drawing.Point(8, 439);
            this.consoleLog.Name = "consoleLog";
            this.consoleLog.ReadOnly = true;
            this.consoleLog.Size = new System.Drawing.Size(910, 272);
            this.consoleLog.TabIndex = 3;
            this.consoleLog.Text = "";
            // 
            // ProxyPort
            // 
            this.ProxyPort.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Client.Properties.Settings.Default, "ProxyPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ProxyPort.Location = new System.Drawing.Point(194, 413);
            this.ProxyPort.Name = "ProxyPort";
            this.ProxyPort.Size = new System.Drawing.Size(203, 20);
            this.ProxyPort.TabIndex = 6;
            this.ProxyPort.Text = global::Client.Properties.Settings.Default.ProxyPort;
            this.ProxyPort.TextChanged += new System.EventHandler(this.ProxyPort_TextChanged);
            // 
            // ProxyIP
            // 
            this.ProxyIP.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Client.Properties.Settings.Default, "ProxyIP", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ProxyIP.Location = new System.Drawing.Point(13, 413);
            this.ProxyIP.Name = "ProxyIP";
            this.ProxyIP.Size = new System.Drawing.Size(178, 20);
            this.ProxyIP.TabIndex = 5;
            this.ProxyIP.Text = global::Client.Properties.Settings.Default.ProxyIP;
            this.ProxyIP.TextChanged += new System.EventHandler(this.ProxyIP_TextChanged);
            // 
            // fbtokenInput
            // 
            this.fbtokenInput.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Client.Properties.Settings.Default, "fbtokenInput", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.fbtokenInput.Location = new System.Drawing.Point(194, 374);
            this.fbtokenInput.Name = "fbtokenInput";
            this.fbtokenInput.Size = new System.Drawing.Size(203, 20);
            this.fbtokenInput.TabIndex = 1;
            this.fbtokenInput.Text = global::Client.Properties.Settings.Default.fbtokenInput;
            this.fbtokenInput.TextChanged += new System.EventHandler(this.fbtokenInput_TextChanged);
            // 
            // fbidInput
            // 
            this.fbidInput.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Client.Properties.Settings.Default, "fbidInput", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.fbidInput.Location = new System.Drawing.Point(13, 374);
            this.fbidInput.Name = "fbidInput";
            this.fbidInput.Size = new System.Drawing.Size(178, 20);
            this.fbidInput.TabIndex = 0;
            this.fbidInput.Text = global::Client.Properties.Settings.Default.fbidInput;
            this.fbidInput.TextChanged += new System.EventHandler(this.FbidInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "FB ID/Email or type google";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "FB Token/Password or Google Name Profile";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Proxy IP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Proxy Port:";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 723);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProxyPort);
            this.Controls.Add(this.ProxyIP);
            this.Controls.Add(this.consoleLog);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.fbtokenInput);
            this.Controls.Add(this.fbidInput);
            this.Name = "MainWindow";
            this.Text = "Shalzuth\'s Brave Haxvius";
            this.tabControl1.ResumeLayout(false);
            this.injectionTab.ResumeLayout(false);
            this.injectionTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.injectDataGrid)).EndInit();
            this.unitHunterTab.ResumeLayout(false);
            this.unitHunterTab.PerformLayout();
            this.missionsTab.ResumeLayout(false);
            this.missionsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RepeatMission)).EndInit();
            this.levelingTab.ResumeLayout(false);
            this.sellTab.ResumeLayout(false);
            this.sellTab.PerformLayout();
            this.jpSummonTab.ResumeLayout(false);
            this.newMailTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mailDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewdataGrid)).EndInit();
            this.weaponTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Equip_Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IWGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void queuedMissions_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var mission = QueuedMissions.Find(x => x.Name == queuedMissions.SelectedItem.ToString());
                QueuedMissions.Remove(mission);
                queuedMissions.Items.Remove(queuedMissions.SelectedItem);
            }
        }

        private void NewdataGrid_DataSourceChanged(object sender, System.EventArgs e)
        {
            this.NewdataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        }

        #endregion

        private System.Windows.Forms.TextBox fbidInput;
        private System.Windows.Forms.TextBox fbtokenInput;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage injectionTab;
        private System.Windows.Forms.DataGridView injectDataGrid;
        private System.Windows.Forms.TextBox injectSearchInput;
        private System.Windows.Forms.Button injectButton;
        private System.Windows.Forms.TabPage unitHunterTab;
        private System.Windows.Forms.Button summonButton;
        private System.Windows.Forms.RichTextBox consoleLog;
        private System.Windows.Forms.TabPage levelingTab;
        private System.Windows.Forms.Button levelPartyButton;
        private System.Windows.Forms.RichTextBox levelStatus;
        private System.Windows.Forms.TabPage jpSummonTab;
        private System.Windows.Forms.Button GachaSummon;
        private System.Windows.Forms.ComboBox JPGacha;
        private System.Windows.Forms.Button JPLogin;
        private System.Windows.Forms.ComboBox JPGachaTicket;
        private System.Windows.Forms.Button rankUpButton;
        private System.Windows.Forms.TabPage missionsTab;
        private System.Windows.Forms.ComboBox missionSelect;
        private System.Windows.Forms.CheckBox CBFriends;
        private System.Windows.Forms.Label MissionIdLabel;
        private System.Windows.Forms.Button StartMission;
        private System.Windows.Forms.CheckBox CBTrophies;
        private System.Windows.Forms.CheckBox CBChallenge;
        private System.Windows.Forms.CheckBox CBLoot;
        private System.Windows.Forms.CheckBox CBUnits;
        private System.Windows.Forms.CheckBox CBExplore;
        private System.Windows.Forms.TextBox LBLevel;
        private System.Windows.Forms.Label LBLabel;
        private System.Windows.Forms.RadioButton RBAndroid;
        private System.Windows.Forms.RadioButton RBiOS;
        private System.Windows.Forms.RadioButton RBAmazon;
        private System.Windows.Forms.TextBox ProxyIP;
        private System.Windows.Forms.TextBox ProxyPort;
        private System.Windows.Forms.NumericUpDown RepeatMission;
        private System.Windows.Forms.Label RepeatLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button arenaButton;
        private System.Windows.Forms.CheckBox sell4Star;
        private System.Windows.Forms.CheckBox sell5Star;
        private System.Windows.Forms.CheckBox sell3Star;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox unitSelect;
        private System.Windows.Forms.TabPage sellTab;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.ComboBox sellItemSelect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage newMailTab;
        private System.Windows.Forms.DataGridView NewdataGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView mailDataGrid;
        private System.Windows.Forms.TabPage weaponTab;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView IWGrid;
        private System.Windows.Forms.CheckBox CBIsParadeMissionEnd;
        private System.Windows.Forms.PictureBox Equip_Pic;
        private System.Windows.Forms.CheckBox Do_Arena;
        private System.Windows.Forms.CheckBox Do_Raid;
        private System.Windows.Forms.Label RaidMissionLabel;
        private System.Windows.Forms.ComboBox RaidMissionSelect;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox raidPartySelect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox partySelect;
        private System.Windows.Forms.Button energyButton;
        private System.Windows.Forms.Button addToQueueBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button startQueuedMissions;
        private System.Windows.Forms.ListBox queuedMissions;
    }
}


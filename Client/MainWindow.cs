using BraveHaxvius;
using BraveHaxvius.Data;
using Client.Properties;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Client
{
    public partial class MainWindow : Form
    {
        BraveExvius client = new BraveExvius();
        DataTable injectDataTable = new DataTable();
        JToken Gachas;
        DataTable IWTable = new DataTable();
        DataTable newsTable = new DataTable();
        DataTable mailTable = new DataTable();
        bool StopForArena = false;
        bool StopForRaid = false;
        public int ChangeParty = -1;
        public int RaidParty = -1;
        int RunMissionCount = 0;
        List<Mission> QueuedMissions = new List<Mission>();

        public MainWindow()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            InitStaticItems();
            if (fbidInput.Text.ToLower() == "google")
            {
                client.P_GOOGLE_ID= fbidInput.Text;
                client.P_GOOGLE_TOKEN = fbtokenInput.Text;
            }
            else
            {
                client.FacebookUserId = fbidInput.Text;
                client.FacebookToken = fbtokenInput.Text;
                client.P_GOOGLE_ID = null;
                client.P_GOOGLE_TOKEN = null;
            }
            
            client.ProxyIpAddr = ProxyIP.Text;
            if (!String.IsNullOrWhiteSpace(ProxyIP.Text))
                client.ProxyPort = int.Parse(ProxyPort.Text);
            Logger.LogHook = Hook;
        }
        public void Hook(String s)
        {
            consoleLog.Focus();
            consoleLog.AppendText(s + "\r\n");
            consoleLog.ScrollToCaret();
        }
        private void InitStaticItems()
        {
            
            IWTable.Columns.Add("Name");
            IWTable.Columns.Add("EquipID");
            IWTable.Columns.Add("Unique EquipID");
            IWTable.Columns.Add("Current Abilities 1");
            IWTable.Columns.Add("Current Abilities 2");
            for (var i = 0; i < 10; i++)
                IWTable.Rows.Add(" ", " ", " ", " ", " ");

            IWGrid.DataSource = IWTable;
            
            IWGrid.EditMode = DataGridViewEditMode.EditOnF2;

            mailTable.Columns.Add("Title");
            mailTable.Columns.Add("Discription");
            for (var i = 0; i < 10; i++)
                mailTable.Rows.Add(" ", " ");
            mailDataGrid.DataSource = mailTable;
            newsTable.Columns.Add("Text");
            newsTable.Columns.Add("Link");
            for(var i = 0; i < 10; i++) 
            newsTable.Rows.Add(" ", " ");
            NewdataGrid.DataSource = newsTable;
            

            injectDataTable.Columns.Add("Count");
            injectDataTable.Columns.Add("Type");
            injectDataTable.Columns.Add("Name");
            injectDataTable.Columns.Add("ID");
            Item.Items.FindAll(i => i.Description != null).ForEach(i => injectDataTable.Rows.Add(0, "item", i.Name, i.ItemId));
            Equipment.Equipments.FindAll(i => i.Description != null).ForEach(i => injectDataTable.Rows.Add(0, "equip", i.Name, i.EquipId));
            Materia.Materias.FindAll(i => i.Description != null).ForEach(i => injectDataTable.Rows.Add(0, "materia", i.Name, i.MateriaId));
            injectDataGrid.DataSource = injectDataTable;

            Unit.Units.FindAll(u => u.Description != null && u.IsSummonable == "1" && u.UnitId == u.BaseUnitId);
            List<Mission> missionList = new List<Mission>();
            Mission.Missions.FindAll(i => i.Description != null).ForEach(i => { i.Description = string.Format("{0} ({1} {2})", i.Name, i.Energy, i.MissionId); missionList.Add(i); });

            unitSelect.DataSource = Unit.Units.FindAll(u => u.Description != null && u.IsSummonable == "1" && u.UnitId == u.BaseUnitId);
            unitSelect.DisplayMember = "Name";

            missionSelect.DataSource = missionList;
            missionSelect.DisplayMember = "Description";

            missionSelect.SelectedItem = missionList.Find(x => x.MissionId == "11420201");

            var raidList = missionList.FindAll(i => i.Raid == "1");
            raidList.Reverse();
            RaidMissionSelect.DataSource = raidList;
            RaidMissionSelect.DisplayMember = "Name";

            partySelect.DataSource = new List<int>() { 0, 1, 2, 3, 4, 5 };
            raidPartySelect.DataSource = new List<int>() { 0, 1, 2, 3, 4, 5 };

        }
        private void InitGacha(BraveExvius b)
        {
            Gachas = b.GetUserInfo[GameObject.GachaScheduleMst];

            foreach (var gacha in b.GachaId)
                JPGacha.Items.Add(gacha);

            JPGacha.SelectedIndex = 0;

            foreach (var ticket in Ticket.Tickets)
                JPGachaTicket.Items.Add(ticket.Name);

            JPGachaTicket.SelectedIndex = 0;
        }
        private void InjectSearchInput_TextChanged(object sender, EventArgs e)
        {
            injectDataTable.DefaultView.RowFilter = string.Format("Name LIKE '%{0}%'", injectSearchInput.Text);
        }
        private void InjectButton_Click(object sender, EventArgs e)
        {
            //Injection is not working.
            var t = new Thread(() =>
            {
                injectButton.Enabled = false;
                var itemHax = String.Join(",", injectDataTable.Rows.Cast<DataRow>().ToList().FindAll(i => i.ItemArray[1].ToString() == "item" && i.ItemArray[0].ToString() != "0").Select(i => "20:" + i.ItemArray[3] + ":" + i.ItemArray[0]));
                var equipmentHax = String.Join(",", injectDataTable.Rows.Cast<DataRow>().ToList().FindAll(i => i.ItemArray[1].ToString() == "equip" && i.ItemArray[0].ToString() != "0").Select(i => "21:" + i.ItemArray[3] + ":" + i.ItemArray[0]));
                var materiaHax = String.Join(",", injectDataTable.Rows.Cast<DataRow>().ToList().FindAll(i => i.ItemArray[1].ToString() == "materia" && i.ItemArray[0].ToString() != "0").Select(i => "22:" + i.ItemArray[3] + ":" + i.ItemArray[0]));
                client.Login();
                client.DoMission(Mission.AirshipDeck, false, itemHax, equipmentHax, materiaHax);
                injectButton.Enabled = true;
            });
            t.IsBackground = true;
            t.Start();
        }
        private void SummonButton_Click(object sender, EventArgs e)
        {
            var t = new Thread(() =>
            {
                Func<int, int> iteration = i =>
                {
                    summonButton.Text = (i + 1).ToString() + "...";
                    return 1;
                };
                summonButton.Enabled = false;
                var unit = unitSelect.SelectedItem as Unit;
                client.Login();
                client.UnitHunterNew(unit, sell3Star.Checked, sell4Star.Checked, sell5Star.Checked, iteration);
                summonButton.Text = "summon";
                summonButton.Enabled = true;
            });
            t.IsBackground = true;
            t.Start();
        }
        private void GitHubButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/shalzuth/BraveHaxvius");
        }
        private void DonateButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=shal.zuth@gmail.com&lc=US&currency_code=USD&bn=PP%2dDonationsBF");
        }
        private void LevelPartyButton_Click(object sender, EventArgs e)
        {
            var t = new Thread(() =>
            {
                Func<string, int> update = i =>
                {
                    levelStatus.Text = i;
                    return 1;
                };
                levelPartyButton.Enabled = false;
                client.Login();
                client.LevelPartyNew(update);
                levelPartyButton.Enabled = true;
            });
            t.IsBackground = true;
            t.Start();
        }
        private void RankUpButton_Click(object sender, EventArgs e)
        {
            var t = new Thread(() =>
            {
                Func<string, int> update = i =>
                {
                    levelStatus.Text = i;
                    return 1;
                };
                rankUpButton.Enabled = false;
                client.Login();
                while (true)
                {
                    var result = client.DoMission(Mission.PortCityLodin, false, null, null, null, false, false, false, false, false, null, 15000);
                    var level = result[GameObject.UserTeamInfo].First()[Variable.Level].ToString();
                    var experience = result[GameObject.UserTeamInfo].First()[Variable.Experience].ToString();
                    levelStatus.Text = "Rank " + level + " : experience = " + experience;
                    if (level == "150")
                        break;
                    Thread.Sleep(3000);
                }
                rankUpButton.Enabled = true;
            });
            t.IsBackground = true;
            t.Start();
        }

        private void JPLogin_Click(object sender, EventArgs e)
        {
            var t = new Thread(() =>
            {
                JPLogin.Enabled = false;
                client.LoginJapan();
                InitGacha(client);
                JPLogin.Enabled = true;
                GachaSummon.Enabled = true;
            });
            t.IsBackground = true;
            t.Start();
        }

        private void GachaSummon_Click(object sender, EventArgs e)
        {
            var t = new Thread(() =>
            {
                GachaSummon.Enabled = false;

                var GachaId = JPGacha.Text.Split(':').Select(p => p.Trim()).ToList().First();
                var Gacha = Gachas.First(g => g[Variable.GachaId].ToString() == GachaId);
                var GachaTicket = Ticket.Tickets.First(x => x.Name == JPGachaTicket.Text).ImportantId;
                var GachaSubId = Gacha[Variable.Options].ToString().Split(',').Last();
                client.Summon(Gacha[Variable.GachaId].ToString(), GachaSubId, "1", GachaTicket);

                GachaSummon.Enabled = true;
            });
            t.IsBackground = true;
            t.Start();
        }

        private void StartMission_Click(object sender, EventArgs e, bool queued = false)
        {
            var t = new Thread(() => RunMission(queued));
            /*{
                StartMission.Enabled = false;
                client.Device = RBiOS.Checked ? "iPhone9,3" : "XT890";
                client.OperatingSystem = RBiOS.Checked ? "ios10.2.1" : RBAndroid.Checked ? "android4.4.2" : "amazon";
                client.Login();
                var mission = missionSelect.SelectedItem as Mission;
                client.DoMission(mission, CBFriends.Checked, null, null, null, CBTrophies.Checked, CBChallenge.Checked, CBLoot.Checked, CBUnits.Checked, CBExplore.Checked, LBLevel.Text, 3000,CBIsParadeMissionEnd.Checked);
                var count = 1;
                while (!String.IsNullOrEmpty(RepeatMission.Text.Replace(" ", "")) && count < Int32.Parse(RepeatMission.Text.Replace(" ", "")))
                {
                    client.DoMission(mission, CBFriends.Checked, null, null, null, CBTrophies.Checked, CBChallenge.Checked, CBLoot.Checked, CBUnits.Checked, CBExplore.Checked, LBLevel.Text, 3000, CBIsParadeMissionEnd.Checked);
                    count++;
                    Thread.Sleep(3000);
                }
                StartMission.Enabled = true;
            });*/
            t.IsBackground = true;
            t.Start();
        }

        private void StartMission_Click(object sender, EventArgs e)
        {
            StartMission_Click(sender, e, false);
        }

        private void RunMission(bool queuedMission = false)
        {
            StartMission.Enabled = false;
            startQueuedMissions.Enabled = false;
            client.Device = RBiOS.Checked ? "iPhone9,3" : "XT890";
            client.OperatingSystem = RBiOS.Checked ? "ios10.2.1" : RBAndroid.Checked ? "android4.4.2" : "amazon";
            client.Login();
            //if (Verbose)
            client.UpdateCurrentParty();
            var mission = missionSelect.SelectedItem as Mission;
            //client.DoMission(mission, CBFriends.Checked, null, null, null, CBTrophies.Checked, CBChallenge.Checked, CBLoot.Checked, CBUnits.Checked, CBExplore.Checked, LBLevel.Text, 3000);
            RunMissionCount = 0;
            var TotalErrors = 0;
            var runTotal = RepeatMission.Text.Replace(" ", "") ?? "1";
            while (RunMissionCount < Int32.Parse(runTotal) && TotalErrors < 3)
            {
                if (queuedMission && QueuedMissions.Count > 0)
                {
                    mission = QueuedMissions.FirstOrDefault();
                    QueuedMissions.Remove(mission);
                    queuedMissions.Items.RemoveAt(queuedMissions.Items.IndexOf(mission.Name));
                }
                try
                {
                    var iterationInfo = $"Doing run ... {mission.Name} {(++RunMissionCount).ToString()}/{runTotal} With party: {client.MyCurrentParty.CurrentPartyNames}";
                    Logger.Out(iterationInfo);
                    var missionResult = client.DoMission(mission, CBFriends.Checked, null, null, null, CBTrophies.Checked, CBChallenge.Checked, CBLoot.Checked, CBUnits.Checked, CBExplore.Checked, LBLevel.Text, 1500, CBIsParadeMissionEnd.Checked);

                    client.ArenaOrbs = UInt16.Parse(missionResult[GameObject.UserTeamInfo][0][Variable.ColosseumOrb].ToString());
                    client.RaidOrbs = UInt16.Parse(missionResult[GameObject.UserTeamInfo][0][Variable.RaidOrb].ToString());
                    var currentEnergy = Int32.Parse(missionResult[GameObject.UserTeamInfo][0][Variable.Energy].ToString());

                    Thread.Sleep(1500);
                    if (StopForArena && client.ArenaOrbs > 0)// && (RunMissionCount % 20 == 0))
                    {
                        client.ClearArena();
                    }
                    if (StopForRaid && client.RaidOrbs > 0)//&& (RunMissionCount % 20 == 0))
                    {
                        client.ClearRaid(RaidMissionSelect.SelectedItem as Mission, RaidParty);
                    }

                    if (RunMissionCount % 5 == 0)
                    {
                        client.UpdateCurrentParty(missionResult);

                        /*client.MyCurrentParty.MyPartyUnits.ForEach(x =>
                        {
                            if (x.TMR == 100 || (x.TMR > 0 && x.TMR > x.LastTMR))
                            {
                                Logger.Out(x.Name + " Gained " + (x.TMR - x.LastTMR) + " points.");
                            }

                            if (x.LastLevel < x.Level)
                            {
                                Logger.Out($"{x.Name} Leveld up! Now Level {x.Level}");
                            }
                        });*/

                    }

                    /*if (Verbose && currentEnergy > 195)
                    {
                        Logger.Out("Warning: Excess Energy " + client.TotalEnergy);
                    }*/

                    if (ChangeParty >= 0 && ChangeParty < 5 && client.MyCurrentParty.MyPartyId != ChangeParty)
                    {
                        client.ChangeParty(ChangeParty);
                    }

                    // Get fresh data every x runs
                    if (RunMissionCount > 1 && RunMissionCount % 100 == 0)
                    {
                        client.UpdateGetUserInfo();
                    }
                }
                catch (Exception ex)
                {
                    Logger.Out(ex.Message);
                    Console.WriteLine(ex.InnerException);
                    TotalErrors++;
                }
            }
            StartMission.Enabled = true;

            Logger.Out("Run Complete!");
        }

        private void RBOS_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void FbidInput_TextChanged(object sender, EventArgs e)
        {
            fbidInput.Text = fbidInput.Text.Replace(" ", "");
            if (fbidInput.Text.ToLower() == "google")
            {
                client.P_GOOGLE_ID = fbidInput.Text;
                client.FacebookUserId = null;
            }
            else {
                client.FacebookUserId = fbidInput.Text;
                client.P_GOOGLE_ID = null;
            }
            Settings.Default.fbidInput = fbidInput.Text;
            Settings.Default.Save();
        }

        private void fbtokenInput_TextChanged(object sender, EventArgs e)
        {
            fbtokenInput.Text = fbtokenInput.Text.Replace(" ", "");
            if (fbidInput.Text.ToLower() == "google")
            { 
                client.P_GOOGLE_TOKEN = fbtokenInput.Text;
                client.FacebookToken = null;
            }
            else
            {
                client.FacebookToken = fbtokenInput.Text;
                client.P_GOOGLE_TOKEN = null;
            }
            Settings.Default.fbtokenInput = fbtokenInput.Text;
            Settings.Default.Save();
        }

        private void ProxyIP_TextChanged(object sender, EventArgs e)
        {
            client.ProxyIpAddr = ProxyIP.Text;
            Settings.Default.ProxyIP = ProxyIP.Text;
            Settings.Default.Save();
        }

        private void ProxyPort_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ProxyPort.Text))
            client.ProxyPort = int.Parse(ProxyPort.Text);
            Settings.Default.ProxyPort = ProxyPort.Text;
            Settings.Default.Save();
        }
        private void CBTrophies_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            if (cb.Checked)
            {
                LBLevel.Text = "";
                LBLevel.Enabled = false;
                CBChallenge.Checked = false;
                CBChallenge.Enabled = false;
            }
            else
            {
                LBLevel.Enabled = true;
            }
        }
        private void arenaButton_Click(object sender, EventArgs e)
        {
            var t = new Thread(() =>
            {
                Func<string, int> update = i =>
                {
                    levelStatus.Text = i;
                    return 1;
                };
                arenaButton.Enabled = false;
                client.Login();
                client.ClearArena();
                arenaButton.Enabled = true;
            });
            t.IsBackground = true;
            t.Start();
        }

        public class Sell
        {
            public String ItemName;
            public String id;
            public String type;
            public int count;
            public int price;
            public override string ToString()
            {
                return ItemName + " : " + count;
            }
        }
        private void sellButton_Click(object sender, EventArgs e)
        {
            var t = new Thread(() =>
            {
                if (sellButton.Text == "login")
                {
                    sellButton.Enabled = false;
                    client.Login();
                    var items = client.GetUserInfo[GameObject.UserItemInfo_4rC0aLkA].First()[Variable.ItemList].ToString().Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    var equips = client.GetUserInfo[GameObject.UserEquipItemInfo_w83oV9uP].First()[Variable.ItemList].ToString().Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    var materias = client.GetUserInfo[GameObject.UserMateriaInfo_aS39Eshy].First()[Variable.ItemList].ToString().Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                    List<Sell> sellable = new List<Sell>();
                    foreach (var itemInfo in items)
                    {
                        var id = itemInfo.Split(new char[1] { ':' })[0];
                        var count = itemInfo.Split(new char[1] { ':' })[1];
                        var item = Item.Items.First(i => i.ItemId == id);
                        sellable.Add(new Sell { ItemName = item.Name, count = int.Parse(count), id = id, price = int.Parse(item.ItemSellPrice), type = "20:" });//, ItemNameAndCount = item.Name + " : " + count });
                    }
                    foreach (var itemInfo in equips)
                    {
                        var id = itemInfo.Split(new char[1] { ':' })[0];
                        var count = itemInfo.Split(new char[1] { ':' })[1];
                        var item = Equipment.Equipments.First(i => i.EquipId == id);
                        sellable.Add(new Sell { ItemName = item.Name, count = int.Parse(count), id = id, price = int.Parse(item.ItemSellPrice), type = "21:" });//, ItemNameAndCount = item.Name + " : " + count });
                    }
                    foreach (var itemInfo in materias)
                    {
                        var id = itemInfo.Split(new char[1] { ':' })[0];
                        var count = itemInfo.Split(new char[1] { ':' })[1];
                        var item = Materia.Materias.First(i => i.MateriaId == id);
                        sellable.Add(new Sell { ItemName = item.Name, count = int.Parse(count), id = id, price = int.Parse(item.ItemSellPrice), type = "22:" });//, ItemNameAndCount = item.Name + " : " + count });
                    }
                    sellable = sellable.OrderByDescending(s => s.count).ToList();
                    sellButton.Text = "sell";
                    sellItemSelect.DataSource = sellable;
                    sellButton.Enabled = true;
                }
                else if (sellButton.Text == "sell")
                {
                    sellButton.Enabled = false;
                    var item = (sellItemSelect.SelectedItem as Sell);
                    while ((UInt64)item.count * (UInt64)item.price > 999999999)
                    {
                        var maxSell = 999999999 / item.price;
                        client.Network.SendPacket(Request.ItemSell, new JProperty(Variable.ItemSell, new JArray(new JObject(
                            new JProperty(Variable.StoreItemSellId, item.type + item.id + ":" + maxSell),
                            new JProperty(Variable.StoreItemSellPrice, ((UInt64)item.price * (UInt64)maxSell).ToString())))));
                        item.count -= maxSell;
                        Thread.Sleep(3000);
                    }
                    client.Network.SendPacket(Request.ItemSell, new JProperty(Variable.ItemSell, new JArray(new JObject(
                        new JProperty(Variable.StoreItemSellId, item.type + item.id + ":" + item.count),
                        new JProperty(Variable.StoreItemSellPrice, (item.price * item.count).ToString())))));
                    sellButton.Enabled = true;
                }
            });
            t.IsBackground = true;
            t.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var t = new Thread(() =>
            {
                
                if (client.GetUserInfo2 == null)
                    client.Login();
                //client.UpdateNews();
            mailTable.Clear();
            client.Mail.ForEach(m =>
            //mails.ForEach(m =>
            {
            if (m.Title.StartsWith("Expe")) {
                Console.WriteLine("DD");
            }

            var unitList = m.Items.ToString().Split(new char[1] { ',' });
            var itemsAndTickets = new List<String>();

            foreach (var unitToken in unitList)
            {
                var parts = unitToken.Split(new char[1] { ':' });
                Boolean addx = (UInt16.Parse((parts.Count() > 2) ? parts[2] : "0") > 1);
                switch (parts[0])
                {
                    case "10":
                        var selectedTurstMoggle = Unit.Units.FirstOrDefault(u => u.UnitId.ToString() == parts[1]).Name;
                        if (selectedTurstMoggle.Contains("Moogle"))
                        {
                            addx = false;
                            if (parts[6].Contains("100000001"))
                                selectedTurstMoggle += " 5%";
                            if (parts[6].Contains("100000008"))
                                selectedTurstMoggle += " 50%";
                            if (parts[6].Contains("100000005"))
                                selectedTurstMoggle += " 1%";
                                //if (selectedTurstMoggle.StartsWith("20"))
                                //    selectedTurstMoggleContain = Item.Items.First(i => i.ItemId == parts[6]).Name;
                                //if (selectedTurstMoggle.StartsWith("21"))
                                //    selectedTurstMoggleContain = Equipment.Equipments.First(i => i.EquipId == parts[6]).Name;
                            }
                        itemsAndTickets.Add(string.Join(" ", selectedTurstMoggle + (addx ? " X " + parts[2] : "")));
                        break;
                    case "20":
                        itemsAndTickets.Add(Item.Items.First(i => i.ItemId == parts[1]).Name + (addx ? " X " + parts[2] : ""));
                        break;
                    case "22":
                        itemsAndTickets.Add(Materia.Materias.First(ma => ma.MateriaId == parts[1]).Name);
                        break;
                    case "23":
                        itemsAndTickets.Add(ImportantItem.ImportantItems.First(i => i.ImportantId == parts[1]).Name + (addx ? " X " + parts[2] : ""));
                        break;
                    case "27":
                        itemsAndTickets.Add(VisionCard.VisionCards.First(v => v.VisionCardID == parts[1]).Name + (addx ? " X " + parts[2] : ""));
                        break;
                        case "30":
                        itemsAndTickets.Add(string.Join(" ", parts[1] + " Gils"));
                        break;
                    case "50":
                        itemsAndTickets.Add(string.Join(" ", parts[2] + " lapiz?"));
                        break;
                    case "60": itemsAndTickets.Add("Recipe for " + Recipe.Recipes.FindAll(i => i.RecipeBookId != null).First(i => parts[1].Contains(i.RecipeBookId)).Name);
                        break;
                    default:
                              itemsAndTickets.Add("Default case");
                          break;
                        }
                    }
                if (m.Title.Contains("_MAIL_"))
                    m.Title = BraveHaxvius.Data.Text.Texts.ContainsKey(m.Title) ? BraveHaxvius.Data.Text.Texts[m.Title] : "No Name";

                    mailTable.Rows.Add(m.Title, string.Join(",", itemsAndTickets.ToList()) );
                //Logger.Out(m.Title);

            });

                newsTable.Clear();
                client.News.ForEach(n =>
                {
                    newsTable.Rows.Add(n.Translation, n.Link);
                });
                


            });
            t.IsBackground = true;
            t.Start();

        }

        private void NewdataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            var dd= IWGrid.Rows[e.RowIndex].Cells[1].Value;
            var temp = IconImg.IconImgs.First(i => i.ItemIdClone.ToString() == dd.ToString().Trim()).IconFile;
            Equip_Pic.ImageLocation = $@"./img/item/{temp}";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var t = new Thread(() =>
            {


                if (client.GetUserInfo3 == null)
                    client.Login();
                IWTable.Clear();
                client.GetUserInfo3[GameObject.UserCustomEquipItemInfo].ToList().FindAll(f =>
                       f[Variable.IWEquipId] != null).ForEach(f =>
                        IWTable.Rows.Add(Equipment.Equipments.First(i => i.EquipId == f[Variable.EquipId].ToString()).Name, " " + f[Variable.EquipId].ToString(), " " + f[Variable.IWEquipId].ToString(), string.Join(", ", f["nM63Zvtp"].ToString().Split(new char[1] { ',' }).ToList().FindAll(w => w.Contains("24:")).ToList().Select(w => Ability.Abilitys.First(a => a.AbilityId == w?.Split(new char[1] { ':' })[1].ToString()).Name).ToList().Select(d => String.Format("{0}", d.Trim()))), string.Join(", ", f["2p9qywBL"].ToString().Split(new char[1] { ',' }).ToList().FindAll(w => w.Contains("24:")).ToList().Select(w => Ability.Abilitys.First(a => a.AbilityId == w?.Split(new char[1] { ':' })[1].ToString()).Name).ToList().Select(d => String.Format("{0}", d.Trim())))));
                client.GetUserInfo[GameObject.UserEquipItemInfo_w83oV9uP].First.First.First.ToString().Split(new char[1] { ',' }).ToList().Select(e1 =>
                {
                    string output = "";
                    var equiplookup = Equipment.Equipments.First(e2 => e2.EquipId == e1.Split(new char[1] { ':' })[0].ToString());
                    if (int.Parse(equiplookup.EquipmentTypeId) <= 16)
                        output= $"{equiplookup.Name},{equiplookup.EquipId},You Have: { e1.Split(new char[1] { ':' })[1]}";
                    return output;
                }).ToList().ForEach(e3 => {
                    if(!string.IsNullOrEmpty(e3))
                        IWTable.Rows.Add(e3.Split(new char[1] { ',' })[0],e3.Split(new char[1] { ',' })[1],$"{e3.Split(new char[1] { ',' })[2]} Without Enhancement Abilities");
                } );
                
                IWGrid.Refresh();

            });
            t.IsBackground = true;
            t.Start();

        }

        private void missionSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            StopForArena = cb.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            StopForRaid = cb.Checked;
        }

        private void RepeatMission_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void partySelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ChangeParty = int.Parse(this.partySelect.SelectedValue.ToString()) - 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void raidPartySelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                RaidParty = int.Parse(this.raidPartySelect.SelectedValue.ToString()) - 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var mission = missionSelect.SelectedItem as Mission;
            if (!QueuedMissions.Contains(mission))
            {
                QueuedMissions.Add(mission);
                queuedMissions.Items.Add(mission.Name);
            }
        }

        private void startQueuedMissions_Click(object sender, EventArgs e)
        {
            var mission = QueuedMissions.FirstOrDefault();
            if (!String.IsNullOrEmpty(mission?.Name))
            {
                missionSelect.SelectedItem = missionSelect.FindStringExact(mission.Name);
                RepeatMission.Value = QueuedMissions.Count;
                StartMission_Click(sender, e, true);
            }
            else
            {
                Logger.Out("No Missions in Queue");
            }
        }

        private void queuedMissions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Logger.Out("Ending after Next Mission is Completed...");
            RunMissionCount = Int32.Parse(RepeatMission.Text.Replace(" ", ""));
            //client.UpdateGetUserInfo();
        }

        private void energyButton_Click(object sender, EventArgs e)
        {
            if (client.LoggedIn == false)
                client.Login();            
            if (client.GetUserInfo != null)
                energyButton.Text = client.TotalEnergy;
            Logger.Out("Energy Retrieval Complete!");
        }
    }
}

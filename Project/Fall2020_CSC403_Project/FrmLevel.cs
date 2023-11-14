using Fall2020_CSC403_Project.code;
using MyGameLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel : Form
    {
        private Player player;
        private string characterselection;
        const int PADDING = 7;

        private Enemy enemyPoisonPacket;
        private Enemy bossKoolaid;
        private Enemy enemyCheeto;
        private Projectile arrow;
        private Projectile cheetoArrow;
        private Projectile poisonArrow;
        private Character[] walls;
        private Character level2door;
        public string playerDirection = "right";
        private DateTime timeBegin;
        private FrmBattle frmBattle;
        private List<Item> itemsList;
        private List<Enemy> enemyList;
        private int rng;
        Vector2 cheetoArrowDirection;
        Vector2 poisonArrowDirection;
        private bool showLevel;

        public FrmLevel(string selection)
        {
            InitializeComponent();
            characterselection = selection;

        }


    private void FrmLevel_Load(object sender, EventArgs e) {
            const int PADDING = 7;
            const int ARROW_PADDING = 2;
            const int NUM_WALLS = 13;

            player = new Player(CreatePosition(characterSelected(characterselection)), CreateCollider(characterSelected(characterselection), PADDING), 1.0f);
            bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING), 0.25f);
            enemyList = new List<Enemy>();
            enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING), 0.5f);
            enemyList.Add(enemyPoisonPacket);
            enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING), 0.5f);
            enemyList.Add(enemyCheeto);
            enemyCheeto.setupEnemy();
            enemyPoisonPacket.setupEnemy();


            // character projectile attack
            arrow = new Projectile(CreatePosition(picPlayer), CreateCollider(picArrow, ARROW_PADDING));
            picArrow.Hide();

            // cheeto projectile attack
            cheetoArrow = new Projectile(CreatePosition(picEnemyCheeto), CreateCollider(picCheetoArrow, ARROW_PADDING));
            picCheetoArrow.Hide();

            // poison projectile attack
            poisonArrow = new Projectile(CreatePosition(picEnemyPoisonPacket), CreateCollider(picPoisonArrow, ARROW_PADDING));
            picPoisonArrow.Hide();

            // hide shield on start
            picShield.Hide();

            bossKoolaid.Img = picBossKoolAid.BackgroundImage;
            picBossKoolAid.Hide();
            bossHealthBar.Hide();
            enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
            enemyCheeto.Img = picEnemyCheeto.BackgroundImage;

            player.inventory.image = inventoryboard.BackgroundImage;
            inventoryboard.Hide();
            selector.Parent = inventoryboard;
            selector.Hide();

            bossKoolaid.Color = Color.Red;
            enemyPoisonPacket.Color = Color.Green;
            enemyCheeto.Color = Color.FromArgb(255, 245, 161);

            walls = new Character[NUM_WALLS];
            for (int w = 0; w < NUM_WALLS; w++)
            {
                PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
                walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING), 0.0f);
            }

            PictureBox door = Controls.Find("nextleveldoor", true)[0] as PictureBox;
            level2door = new Character(CreatePosition(door), CreateCollider(door, PADDING), 0.0f);

            itemsList = new List<Item>();
            try
            {
                int w = 0;
                while (true)
                {
                    string itemname = "LVL1potion" + w.ToString();
                    PictureBox item = Controls.Find(itemname, true)[0] as PictureBox;
                    itemsList.Add(new Item(CreatePosition(item), CreateCollider(item, PADDING), "health", itemname));
                    item.Show();
                    w = w + 1;
                }
            }
            catch (Exception ex)
            { }

            PictureBox sugaritem = Controls.Find("ItemPoisonPack", true)[0] as PictureBox;
            itemsList.Add(new Item(CreatePosition(sugaritem), CreateCollider(sugaritem, PADDING), "sugar", "ItemPoisonPack"));
            sugaritem.Hide();

            foreach (string itemname in player.inventory.itemstorage)
            {
                PictureBox inventoryItem = Controls.Find(itemname, true)[0] as PictureBox;
                inventoryItem.Hide();
                // Sets inventory Item as child to always display item images on top of the inventory board.
                inventoryItem.Parent = this.inventoryboard;
            }
            showLevel = true;
            Game.player = player;
            timeBegin = DateTime.Now;
        }

        private PictureBox characterSelected(string selection)
        {
            if (selection == "mrpeanut")
            {
                return picPlayer;
            }
            else
            {
                return picPlayer2;
            }
        }

        private Vector2 CreatePosition(PictureBox pic)
        {
            return new Vector2(pic.Location.X, pic.Location.Y);
        }

        /// <summary>
        /// runs arrow picturebox on its own
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrArrowMove_Tick(object sender, EventArgs e)
        {
            // check if projectile hits a wall
            if (ArrowHitAWall(arrow))
            {
                arrow.inFlight = false;
                arrow.returnArrow(player);
                picArrow.Location = new Point((int)player.Position.x, (int)player.Position.y);
                picArrow.Hide();
            }

            //check if projectile hits an enemy
            if (enemyPoisonPacket.showEnemy)
            {
                if (ProjHitAEnemy(arrow, enemyPoisonPacket))
                {
                    arrow.inFlight = false;
                    enemyPoisonPacket.AlterHealth(arrow.Damage);
                    arrow.returnArrow(player);
                    picArrow.Location = new Point((int)player.Position.x, (int)player.Position.y);
                    picArrow.Hide();
                    if (enemyPoisonPacket.Health <= 0)
                    {
                        // Remove Sprite Collider and Images
                        enemyList.Remove(enemyPoisonPacket);
                        picEnemyPoisonPacket.Hide();
                        enemyPoisonPacket.Collider.Deactivate();
                        poisonHealthBar.Hide();                        
                        enemyList.Remove(enemyPoisonPacket);
                        enemyPoisonPacket.removeEnemy();

                        PictureBox itemPoisonPack = Controls.Find("ItemPoisonPack", true)[0] as PictureBox;
                        itemPoisonPack.Show();
                        if (enemyList.Count == 0)
                        {
                            bossKoolaid.setupEnemy();
                            picBossKoolAid.Show();
                            bossHealthBar.Show();
                        }
                    }
                }
            }
            else if (enemyCheeto.showEnemy)
            {
                if (ProjHitAEnemy(arrow, enemyCheeto))
                {
                    arrow.inFlight = false;
                    enemyCheeto.AlterHealth(arrow.Damage);
                    arrow.returnArrow(player);
                    picArrow.Location = new Point((int)player.Position.x, (int)player.Position.y);
                    picArrow.Hide();
                    if (enemyCheeto.Health <= 0)
                    {
                        // Remove Sprite Collider and Images
                        picEnemyCheeto.Hide();
                        enemyCheeto.Collider.Deactivate();
                        cheetoHealthBar.Hide();
                        enemyList.Remove(enemyCheeto);
                        enemyList.Remove(enemyCheeto);
                        enemyCheeto.removeEnemy();
                        if (enemyList.Count == 0)
                        {
                            bossKoolaid.setupEnemy();
                            picBossKoolAid.Show();
                            bossHealthBar.Show();
                        }
                    }
                }
            }
            else if (bossKoolaid.showEnemy)
            {
                if (ProjHitAEnemy(arrow, bossKoolaid))
                {
                    arrow.inFlight = false;
                    bossKoolaid.AlterHealth(arrow.Damage);
                    arrow.returnArrow(player);
                    picArrow.Location = new Point((int)player.Position.x, (int)player.Position.y);
                    picArrow.Hide();

                    // Remove Boss Collider and Sprite Images
                    if (bossKoolaid.Health <= 0)
                    {
                        picBossKoolAid.Hide();
                        bossKoolaid.Collider.Deactivate();
                        bossHealthBar.Hide();
                    }
                }
            }

            // update position if object is inFlight
            if (arrow.inFlight)
            {
                arrow.arrowMove(playerDirection);
                picArrow.Location = new Point((int)arrow.Position.x, (int)arrow.Position.y);
            }
            else
            {
                picArrow.Location = new Point((int)player.Position.x, (int)player.Position.y);
            }
        }

        private void tmrUpdateInGameTime_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - timeBegin;
            string time = span.ToString(@"hh\:mm\:ss");
            lblInGameTime.Text = "Time: " + time.ToString();
        }

        private void tmrPlayerMove_Tick(object sender, EventArgs e)
        {
            // move player
            player.Move();

            // check collision with walls
            if (HitAWall(player) && player.walls)
            {
                player.MoveBack();
            }

            if (HitADoor(player) && showLevel)
            {
                // Create NextLevel and show it
                NextLevel nextlevel = new NextLevel();
                nextlevel.Show();
                // Whenever NextLevel is closed, execute onFormClosed method
                // nextlevel.FormClosed += nextlevel.OnFormClosed;
                Hide();
                showLevel = false;
            }

            // check collision with enemies and projectiles
            if (HitAChar(player, enemyPoisonPacket) && enemyPoisonPacket.showEnemy)
            {
                // enemyPoisonPacket.ResetMoveSpeed();
                // enemyPoisonPacket.MoveBack();
                Fight(enemyPoisonPacket);
            }
            else if (HitAChar(player, enemyCheeto) && enemyCheeto.showEnemy)
            {
                // enemyCheeto.ResetMoveSpeed();
                // enemyCheeto.MoveBack();
                Fight(enemyCheeto);
            }
            if (HitAChar(player, bossKoolaid) && bossKoolaid.showEnemy)
            {
                Fight(bossKoolaid);
            }

            // check collision with item(s)
            if (HitAnItem(player))
            {
                Item itemHit = null;
                for (int w = 0; w < itemsList.Count; w++)
                {
                    if (player.Collider.Intersects(itemsList[w].Collider))
                    {
                        itemHit = itemsList[w];
                        itemsList.Remove(itemHit);
                        break;
                    }
                }
                StoreItem(itemHit);
            }

            // update player's picture box, health bar, and health
            picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y + 15);
            playerHealthBar.Location = new Point((int)player.Position.x, (int)player.Position.y);
            picShield.Location = new Point((int)player.Position.x + 54, (int)player.Position.y + 15);
            UpdatePlayerHealthBars(player);
        }

        private Collider CreateCollider(PictureBox pic, int padding)
        {
            Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
            return new Collider(rect);
        }

        private void FrmLevel_KeyUp(object sender, KeyEventArgs e)
    {
        player.ResetMoveSpeed();

            switch (e.KeyCode)
            {
                case Keys.B:
                    player.toughness = 0.5f;
                    picShield.Hide();
                    break;
            }
    }

        /// <summary>
        /// decides if arrow collides with a wall, return arrow to player
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private bool ArrowHitAWall(Projectile p)
        {
            bool hitAWall = false;
            for (int w = 0; w < walls.Length; w++)
            {
                if (p.Collider.Intersects(walls[w].Collider))
                {
                    hitAWall = true;
                    break;
                }
            }
            return hitAWall;
        }

        private bool HitAWall(Character c)
        {
            bool hitAWall = false;
            for (int w = 0; w < walls.Length; w++)
            {
                if (c.Collider.Intersects(walls[w].Collider))
                {
                    hitAWall = true;
                    break;
                }
            }
            return hitAWall;
        }
        private bool HitADoor(Character c)
        {
            bool hitADoor = false;
            
            if (c.Collider.Intersects(level2door.Collider))
            {
                hitADoor = true;
            }

            return hitADoor;
        }

        private bool HitAnItem(Character c)
        {
            bool hitAnItem = false;
            for (int w = 0; w < itemsList.Count; w++)
            {
                if (c.Collider.Intersects(itemsList[w].Collider))
                {
                    hitAnItem = true;
                    break;
                }
            }
            return hitAnItem;
        }

        private bool HitAChar(Character you, Character other)
        {
            return you.Collider.Intersects(other.Collider);
        }

        private bool ProjHitAEnemy(Projectile p, Character other)
        {
            return p.Collider.Intersects(other.Collider);
        }


        private void Fight(Enemy enemy)
        {
            /*
            player.ResetMoveSpeed();
            player.MoveBack();
            frmBattle = FrmBattle.GetInstance(enemy);
            frmBattle.Show();
            if (enemy == bossKoolaid)
            {
                frmBattle.SetupForBossBattle();
            }
            */
            player.AlterHealth(-1);
        }

        private void StoreItem(Item item)
        {
            player.inventory.addHealthItem(item);
            PictureBox pic = Controls.Find(item.NAME, true)[0] as PictureBox;
            pic.Hide();
            pic.Parent = this.inventoryboard;
        }

        private void FrmLevel_KeyDown(object sender, KeyEventArgs e)
        {
            if (player.inventory.visible)
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                    case Keys.A:
                        if (player.inventory.selectedItem > 0)
                        {
                            player.inventory.selectedItem -= 1;
                            selectedItem();
                        }
                        break;

                    case Keys.Right:
                    case Keys.D:
                        if (player.inventory.selectedItem < player.inventory.itemstorage.Count - 1)
                        {
                            player.inventory.selectedItem += 1;
                            selectedItem();
                        }
                        break;

                    case Keys.P:
                        InGameSettingsPage inGameSettingsPage = new InGameSettingsPage();
                        inGameSettingsPage.Show();
                        break;

                    case Keys.I:
                        Inventory_Close();
                        break;

                    case Keys.U:
                        string itemToUseName = player.inventory.itemstorage[player.inventory.selectedItem];
                        PictureBox itempic = Controls.Find(itemToUseName, true)[0] as PictureBox;

                        player.inventory.itemDictionary[itemToUseName].useItem(player);
                        player.inventory.itemstorage.Remove(itemToUseName);
                        itempic.Dispose();

                        if (player.inventory.selectedItem > 0)
                        {
                            player.inventory.selectedItem -= 1;
                            selectedItem();
                        }
                        break;

                    default:
                        player.ResetMoveSpeed();
                        break;
                }
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.Space:
                        if (!arrow.inFlight)
                        {
                            picArrow.Show();
                            picArrow.Location = new Point((int)player.Position.x, (int)player.Position.y);
                            arrow.Position = new Vector2(player.Position.x, player.Position.y);
                            arrow.arrowMove(playerDirection);
                            arrow.inFlight = true;
                        }
                        break;

                    case Keys.Left:
                    case Keys.A:
                        player.GoLeft();
                        if (!arrow.inFlight)
                            playerDirection = "left";
                        break;

                    case Keys.Right:
                    case Keys.D:
                        player.GoRight();
                        if (!arrow.inFlight)
                            playerDirection = "right";
                        break;

                    case Keys.Up:
                    case Keys.W:
                        player.GoUp();
                        if (!arrow.inFlight)
                            playerDirection = "up";
                        break;

                    case Keys.Down:
                    case Keys.S:
                        player.GoDown();
                        if (!arrow.inFlight)
                            playerDirection = "down";
                        break;

                    case Keys.P:
                        InGameSettingsPage inGameSettingsPage = new InGameSettingsPage();
                        inGameSettingsPage.Show();
                        break;

                    case Keys.I:
                        Inventory_Open();
                        break;

                    case Keys.B:
                        player.toughness = 0.0f;
                        picShield.Show();
                        break;

                    default:
                        player.ResetMoveSpeed();
                        break;
                }
            }
            // update player's picture box
            picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y + 15);
            playerHealthBar.Location = new Point((int)player.Position.x, (int)player.Position.y);
            picShield.Location = new Point((int)player.Position.x + 54, (int)player.Position.y + 15);
        }

        public void Inventory_Close()
        {
            this.inventoryboard.Hide();
            selector.Hide();
            foreach (string itemname in player.inventory.itemstorage)
            {
                PictureBox inventoryItem = Controls.Find(itemname, true)[0] as PictureBox;
                inventoryItem.Hide();
            }

            player.inventory.setVisible(!player.inventory.visible);

        }

        public void Inventory_Open()
        {
            this.inventoryboard.Show();

            int x_pos = player.inventory.PADDING;
            int y_pos = player.inventory.PADDING;
            foreach (string itemname in player.inventory.itemstorage)
            {
                PictureBox inventoryItem = Controls.Find(itemname, true)[0] as PictureBox;
                if ((inventoryItem.Width + x_pos) > (inventoryboard.Location.X + inventoryboard.Width - player.inventory.PADDING))
                {
                    x_pos = player.inventory.PADDING;
                    y_pos = y_pos + (inventoryboard.Height * (1 / 3));
                }
                inventoryItem.Location = new Point(x_pos, y_pos);
                inventoryItem.Show();

                x_pos = x_pos + player.inventory.PADDING + inventoryItem.Width;
            }

            player.inventory.setVisible(!player.inventory.visible);
            player.inventory.selectedItem = 0;
            selectedItem();
        }

        public void selectedItem()
        {
            if (player.inventory.itemstorage.Count > 0)
            {
                selector.Show();
                string itemname = player.inventory.itemstorage[player.inventory.selectedItem];
                PictureBox item = Controls.Find(itemname, true)[0] as PictureBox;
                selector.Location = new Point(item.Location.X, item.Location.Y + item.Height);
                selector.Width = item.Width;
                selector.Height = player.inventory.PADDING / 2;
            }
        }

        private void lblInGameTime_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Closes the application when FrmLevel is closed 
        /// </summary>
        public void onFormClosed(object sender, FormClosedEventArgs e)
        {

            System.Windows.Forms.Application.Exit();
        }

        private void tmrCheetoMove_Tick(object sender, EventArgs e)
        {
            /*
            if (enemyCheeto.Health > 0)
            {
                enemyCheeto.Move();

                if (HitAWall(enemyCheeto))
                {
                    enemyCheeto.MoveBack();
                }
                else
                {
                    Random rnd = new Random();
                    rng = rnd.Next(4);

                    switch (rng)
                    {
                        case 0:
                            enemyCheeto.GoLeft();
                            break;

                        case 1:
                            enemyCheeto.GoRight();
                            break;

                        case 2:
                            enemyCheeto.GoUp();
                            break;

                        case 3:
                            enemyCheeto.GoDown();
                            break;

                    }

                }
            */
            picEnemyCheeto.Location = new Point((int)enemyCheeto.Position.x, (int)enemyCheeto.Position.y);
            cheetoHealthBar.Location = new Point((int)enemyCheeto.Position.x, (int)enemyCheeto.Position.y - 15);
            UpdateCheetoHealthBars(enemyCheeto);
            //}
        }

        private void tmrPoisonMove_Tick(object sender, EventArgs e)
        {
            /*
            if (enemyPoisonPacket.Health > 0)
            {
                enemyPoisonPacket.Move();

                if (HitAWall(enemyPoisonPacket))
                {
                    enemyPoisonPacket.MoveBack();
                }
                else
                {
                    Random rnd = new Random();
                    rng = rnd.Next(4);

                    switch (rng)
                    {
                        case 0:
                            enemyPoisonPacket.GoLeft();
                            break;

                        case 1:
                            enemyPoisonPacket.GoRight();
                            break;

                        case 2:
                            enemyPoisonPacket.GoUp();
                            break;

                        case 3:
                            enemyPoisonPacket.GoDown();
                            break;

                    }

                }
            */
            picEnemyPoisonPacket.Location = new Point((int)enemyPoisonPacket.Position.x, (int)enemyPoisonPacket.Position.y);
            poisonHealthBar.Location = new Point((int)enemyPoisonPacket.Position.x, (int)enemyPoisonPacket.Position.y - 18);
            UpdatePoisonHealthBars(enemyPoisonPacket);
            //}
        }

        private void tmrBoss_Tick(object sender, EventArgs e)
        {
            UpdateBossHealthBars(bossKoolaid);
        }

        /// <summary>
        /// Update label size relative to remaining enemy health
        /// </summary>
        /// <param name="enemy"></param>
        private void UpdatePoisonHealthBars(Enemy enemy)
        {
            float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;
            const int MAX_HEALTHBAR_WIDTH = 65;
            poisonHealthBar.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);
        }
        /// <summary>
        /// Update label size relative to remaining enemy health
        /// </summary>
        /// <param name="enemy"></param>
        /// 
        private bool isPlayerDead = false; 
        private void UpdatePlayerHealthBars(Player p)
        {
            if (isPlayerDead) return; 

            float playerHealthPer = p.Health / (float)p.MaxHealth;
            const int MAX_HEALTHBAR_WIDTH = 55;
            playerHealthBar.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
            if (player.Health == 0)
            {
                // Setting flag
                isPlayerDead = true;
                player.AlterHealth(-10);
                DeathScreen deathScreen = new DeathScreen();
                deathScreen.Show();
                this.Hide();
            }
        }
        /// <summary>
        /// Update label size relative to remaining enemy health
        /// </summary>
        /// <param name="enemy"></param>
        private void UpdateCheetoHealthBars(Enemy enemy)
        {
            float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;
            const int MAX_HEALTHBAR_WIDTH = 68;
            cheetoHealthBar.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);
        }
        /// <summary>
        /// Update label size relative to remaining enemy health
        /// </summary>
        /// <param name="enemy"></param>
        private void UpdateBossHealthBars(Enemy enemy)
        {
            float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;
            const int MAX_HEALTHBAR_WIDTH = 196;
            bossHealthBar.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);
        }

        private void tmrCheetoArrowMove_Tick(object sender, EventArgs e)
        {

                if (ArrowHitAWall(cheetoArrow))
                {
                    cheetoArrow.inFlight = false;
                    cheetoArrow.returnArrow(enemyCheeto);
                    picCheetoArrow.Location = new Point((int)enemyCheeto.Position.x, (int)enemyCheeto.Position.y);
                    cheetoArrowDirection = new Vector2(0, 0);
                    picCheetoArrow.Hide();
                }

                if (ProjHitAEnemy(cheetoArrow, player))
                {
                    cheetoArrow.inFlight = false;
                    player.AlterHealth(cheetoArrow.Damage);
                    cheetoArrow.returnArrow(enemyCheeto);
                    picCheetoArrow.Location = new Point((int)enemyCheeto.Position.x, (int)enemyCheeto.Position.y);
                    cheetoArrowDirection = new Vector2(0, 0);
                    picCheetoArrow.Hide();
                    if (player.Health < 0)
                    {
                        var tempHealth = (player.Health * -1);
                        player.AlterHealth(tempHealth);
                    }
                }

                if (!cheetoArrow.inFlight)
                {
                    if (enemyCheeto.Health > 0)
                    {
                        cheetoArrowDirection = cheetoArrow.calcDirection(player.Position, enemyCheeto.Position);
                        picCheetoArrow.Location = new Point((int)enemyCheeto.Position.x, (int)enemyCheeto.Position.y);
                        cheetoArrow.inFlight = true;
                        picCheetoArrow.Show();
                    } else
                {
                    cheetoArrow.inFlight = false;
                }
                }
                else
                {
                    cheetoArrow.enemyArrowMove(cheetoArrowDirection);
                    picCheetoArrow.Location = new Point((int)cheetoArrow.Position.x, (int)cheetoArrow.Position.y);
                }
        }

        private void tmrPoisonArrowMove_Tick(object sender, EventArgs e)
        {
            if (ArrowHitAWall(poisonArrow))
            {
                poisonArrow.inFlight = false;
                poisonArrow.returnArrow(enemyPoisonPacket);
                picPoisonArrow.Location = new Point((int)enemyPoisonPacket.Position.x, (int)enemyPoisonPacket.Position.y);
                poisonArrowDirection = new Vector2(0, 0);
                picPoisonArrow.Hide();
            }

            if (ProjHitAEnemy(poisonArrow, player))
            {
                poisonArrow.inFlight = false;
                player.AlterHealth(poisonArrow.Damage);
                poisonArrow.returnArrow(enemyPoisonPacket);
                picPoisonArrow.Location = new Point((int)enemyPoisonPacket.Position.x, (int)enemyPoisonPacket.Position.y);
                poisonArrowDirection = new Vector2(0, 0);
                picPoisonArrow.Hide();
                if (player.Health < 0)
                {
                    var tempHealth = (player.Health * -1);
                    player.AlterHealth(tempHealth);
                }
            }

            if (!poisonArrow.inFlight)
            {
                if (enemyPoisonPacket.Health > 0)
                {
                    poisonArrowDirection = poisonArrow.calcDirection(player.Position, enemyPoisonPacket.Position);
                    picPoisonArrow.Location = new Point((int)enemyPoisonPacket.Position.x, (int)enemyPoisonPacket.Position.y);
                    poisonArrow.inFlight = true;
                    picPoisonArrow.Show();
                }
                else
                {
                    poisonArrow.inFlight = false;
                }
            }
            else
            {
                poisonArrow.enemyArrowMove(poisonArrowDirection);
                picPoisonArrow.Location = new Point((int)poisonArrow.Position.x, (int)poisonArrow.Position.y);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}


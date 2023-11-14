using Fall2020_CSC403_Project.code;
using MyGameLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Fall2020_CSC403_Project
{
    public partial class Level2 : Form
    {
        private Player player2;

        private Enemy enemyPoisonPacket2;
        private Enemy bossKoolaid2;
        private Enemy enemyCheeto2;
        private Projectile arrow2;
        private Sword pacifier;
        private Character[] walls2;
        public string playerDirection = "right";
        private List<Item> itemsList2;

        private DateTime timeBegin2;
        private FrmBattle frmBattle2;

        public Level2()
        {
            InitializeComponent();
        }

        private void Level2_Load(object sender, EventArgs e)
        {
            const int PADDING = 7;
            const int ARROW_PADDING = 2;
            const int NUM_WALLS = 13;

            player2 = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING), 1.0f);
            player2.image = picPlayer.BackgroundImage;
            bossKoolaid2 = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING), 0.25f);
            enemyPoisonPacket2 = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING), 0.5f);
            enemyCheeto2 = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING), 0.5f);

            // character projectile attack
            arrow2 = new Projectile(CreatePosition(picPlayer), CreateCollider(picArrow2, ARROW_PADDING));
            picArrow2.Hide();
            pacifier = new Sword(CreatePosition(picPacifier), CreateCollider(picPacifier, PADDING));
            picPacifier.Image = RotateImage(picPacifier.Image, pacifier.calcPointDirection(enemyCheeto2, player2));
            bossKoolaid2.Img = picBossKoolAid.BackgroundImage;
            enemyPoisonPacket2.Img = picEnemyPoisonPacket.BackgroundImage;
            enemyCheeto2.Img = picEnemyCheeto.BackgroundImage;
            
            player2.inventory.image = inventoryboard.BackgroundImage;
            inventoryboard.Hide();
            selector.Parent = inventoryboard;
            selector.Hide();

            bossKoolaid2.Color = Color.Red;
            enemyPoisonPacket2.Color = Color.Green;
            enemyCheeto2.Color = Color.FromArgb(255, 245, 161);

            walls2 = new Character[NUM_WALLS];
            for (int w = 0; w < NUM_WALLS; w++)
            {
                PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
                walls2[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING), 0.0f);
            }

            itemsList2 = new List<Item>();
            try
            {
                int w = 0;
                while (true)
                {
                    string itemname = "LVL2potion" + w.ToString();
                    PictureBox item = Controls.Find(itemname, true)[0] as PictureBox;
                    itemsList2.Add(new Item(CreatePosition(item), CreateCollider(item, PADDING), "health", itemname));
                    w = w + 1;
                }
            }
            catch (Exception ex)
            { }

            foreach (string itemname in player2.inventory.itemstorage)
            {
                PictureBox inventoryItem = Controls.Find(itemname, true)[0] as PictureBox;
                inventoryItem.Hide();
                // Sets inventory Item as child to always display item images on top of the inventory board.S
                inventoryItem.Parent = this.inventoryboard;
            }

            Game.player = player2;
            timeBegin2 = DateTime.Now;
        }

        private Vector2 CreatePosition(PictureBox pic)
        {
            return new Vector2(pic.Location.X, pic.Location.Y);
        }

        /// <summary>
        /// runs arrow2picturebox on its own
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrArrowMove_Tick(object sender, EventArgs e)
        {
            // check if projectile hits a wall
            if (ArrowHitAWall(arrow2))
            {
                arrow2.inFlight = false;
                arrow2.returnArrow(player2);
                picArrow2.Location = new Point((int)player2.Position.x, (int)player2.Position.y);
                picArrow2.Hide();
            }

            //check if projectile hits an enemy
            if (ProjHitAEnemy(arrow2, enemyPoisonPacket2))
            {
                arrow2.inFlight = false;
                enemyPoisonPacket2.AlterHealth(arrow2.Damage);
                arrow2.returnArrow(player2);
                picArrow2.Location = new Point((int)player2.Position.x, (int)player2.Position.y);
                picArrow2.Hide();
            }
            else if (ProjHitAEnemy(arrow2, enemyCheeto2))
            {
                arrow2.inFlight = false;
                enemyCheeto2.AlterHealth(arrow2.Damage);
                arrow2.returnArrow(player2);
                picArrow2.Location = new Point((int)player2.Position.x, (int)player2.Position.y);
                picArrow2.Hide();
            }
            else if (ProjHitAEnemy(arrow2, bossKoolaid2))
            {
                arrow2.inFlight = false;
                bossKoolaid2.AlterHealth(arrow2.Damage);
                arrow2.returnArrow(player2);
                picArrow2.Location = new Point((int)player2.Position.x, (int)player2.Position.y);
                picArrow2.Hide();
            }

            // update position if object is inFlight
            if (arrow2.inFlight)
            {
                arrow2.arrowMove(playerDirection);
                picArrow2.Location = new Point((int)arrow2.Position.x, (int)arrow2.Position.y);
            }
            else
            {
                picArrow2.Location = new Point((int)player2.Position.x, (int)player2.Position.y);
            }
        }


        private Collider CreateCollider(PictureBox pic, int padding)
        {
            Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
            return new Collider(rect);
        }

        private void FrmLevel_KeyUp(object sender, KeyEventArgs e)
        {
            player2.ResetMoveSpeed();
        }

        private void tmrUpdateInGameTime_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - timeBegin2;
            string time = span.ToString(@"hh\:mm\:ss");
            lblInGameTime.Text = "Time: " + time.ToString();
        }

        private void tmrPlayerMove_Tick(object sender, EventArgs e)
        {
            // move player
            player2.Move();

            // check collision with walls
            if (HitAWall(player2))
            {
                player2.MoveBack();
            }

            // check collision with enemies
            if (HitAChar(player2, enemyPoisonPacket2))
            {
                Fight(enemyPoisonPacket2);
            }
            else if (HitAChar(player2, enemyCheeto2))
            {
                Fight(enemyCheeto2);
            }
            if (HitAChar(player2, bossKoolaid2))
            {
                Fight(bossKoolaid2);
            }

            // check collision with item(s)
            if (HitAnItem(player2))
            {
                Item itemHit = null;
                for (int w = 0; w < itemsList2.Count; w++)
                {
                    if (player2.Collider.Intersects(itemsList2[w].Collider))
                    {
                        itemHit = itemsList2[w];
                        itemsList2.Remove(itemHit);
                        break;
                    }
                }
                StoreItem(itemHit);
            }

            // update player's picture box, health bar, and health
            picPlayer.Location = new Point((int)player2.Position.x, (int)player2.Position.y);
            playerHealthBar.Location = new Point((int)player2.Position.x, (int)player2.Position.y);
            //picShield.Location = new Point((int)player2.Position.x + 54, (int)player2.Position.y + 15);
            UpdatePlayerHealthBars(player2);
            float angle = pacifier.calcPointDirection(enemyCheeto2, player2);
            picPacifier.Image = RotateImage(picPacifier.Image, angle);
            picPacifier.Location = new Point((int)player2.Position.x + (player2.image.Width / 2), (int)player2.Position.y + (player2.image.Height / 2));
        }

        /// <summary>
        /// decides if arrow collides with a wall, return arrow to player
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private bool ArrowHitAWall(Projectile p)
        {
            bool hitAWall = false;
            for (int w = 0; w < walls2.Length; w++)
            {
                if (p.Collider.Intersects(walls2[w].Collider))
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
            for (int w = 0; w < walls2.Length; w++)
            {
                if (c.Collider.Intersects(walls2[w].Collider))
                {
                    hitAWall = true;
                    break;
                }
            }
            return hitAWall;
        }

        private bool HitAnItem(Character c)
        {
            bool hitAnItem = false;
            for (int w = 0; w < itemsList2.Count; w++)
            {
                if (c.Collider.Intersects(itemsList2[w].Collider))
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
            //player2.ResetMoveSpeed();
            //player2.MoveBack();
            //frmBattle2 = FrmBattle.GetInstance(enemy);
            //frmBattle2.Show();

            //if (enemy == bossKoolaid2)
            //{
            //    frmBattle2.SetupForBossBattle();
            //}
            player2.AlterHealth(-1);
        }

        private void StoreItem(Item item)
        {
            player2.inventory.addHealthItem(item);
            PictureBox pic = Controls.Find(item.NAME, true)[0] as PictureBox;
            pic.Hide();
            pic.Parent = this.inventoryboard;
        }

        private void FrmLevel_KeyDown(object sender, KeyEventArgs e)
        {
            if (player2.inventory.visible)
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                    case Keys.A:
                        if (player2.inventory.selectedItem > 0)
                        {
                            player2.inventory.selectedItem -= 1;
                            selectedItem();
                        }
                        break;

                    case Keys.Right:
                    case Keys.D:
                        if (player2.inventory.selectedItem < player2.inventory.itemstorage.Count - 1)
                        {
                            player2.inventory.selectedItem += 1;
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
                        string itemToUseName = player2.inventory.itemstorage[player2.inventory.selectedItem];
                        PictureBox itempic = Controls.Find(itemToUseName, true)[0] as PictureBox;

                        player2.inventory.itemDictionary[itemToUseName].useItem(player2);
                        player2.inventory.itemstorage.Remove(itemToUseName);
                        itempic.Dispose();

                        if (player2.inventory.selectedItem > 0)
                        {
                            player2.inventory.selectedItem -= 1;
                            selectedItem();
                        }
                        Inventory_Open();
                        break;

                    default:
                        player2.ResetMoveSpeed();
                        break;
                }
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.Space:
                        if (!arrow2.inFlight)
                        {
                            picArrow2.Show();
                            picArrow2.Location = new Point((int)player2.Position.x, (int)player2.Position.y);
                            arrow2.Position = new Vector2(player2.Position.x, player2.Position.y);
                            arrow2.arrowMove(playerDirection);
                            arrow2.inFlight = true;
                        }
                        break;

                    case Keys.Left:
                    case Keys.A:
                        player2.GoLeft();
                        if (!arrow2.inFlight)
                            playerDirection = "left";
                        break;

                    case Keys.Right:
                    case Keys.D:
                        player2.GoRight();
                        if (!arrow2.inFlight)
                            playerDirection = "right";
                        break;

                    case Keys.Up:
                    case Keys.W:
                        player2.GoUp();
                        if (!arrow2.inFlight)
                            playerDirection = "up";
                        break;

                    case Keys.Down:
                    case Keys.S:
                        player2.GoDown();
                        if (!arrow2.inFlight)
                            playerDirection = "down";
                        break;

                    case Keys.P:
                        InGameSettingsPage inGameSettingsPage = new InGameSettingsPage();
                        inGameSettingsPage.Show();
                        break;

                    case Keys.I:
                        Inventory_Open();
                        break;

                    default:
                        player2.ResetMoveSpeed();
                        break;
                }
                // check collision with item(s)
                if (HitAnItem(player2))
                {
                    Item itemHit = null;
                    for (int w = 0; w < itemsList2.Count; w++)
                    {
                        if (player2.Collider.Intersects(itemsList2[w].Collider))
                        {
                            itemHit = itemsList2[w];
                            itemsList2.Remove(itemHit);
                            break;
                        }
                    }
                    StoreItem(itemHit);
                }
            }
            // update player's picture box
            picPlayer.Location = new Point((int)player2.Position.x, (int)player2.Position.y + 15);
            playerHealthBar.Location = new Point((int)player2.Position.x, (int)player2.Position.y);
        }

        public void Inventory_Close()
        {
            this.inventoryboard.Hide();
            selector.Hide();
            foreach (string itemname in player2.inventory.itemstorage)
            {
                PictureBox inventoryItem = Controls.Find(itemname, true)[0] as PictureBox;
                inventoryItem.Hide();
            }

            player2.inventory.setVisible(!player2.inventory.visible);
        }

        public void Inventory_Open()
        {
            this.inventoryboard.Show();

            int x_pos = player2.inventory.PADDING;
            int y_pos = player2.inventory.PADDING;
            foreach (string itemname in player2.inventory.itemstorage)
            {
                PictureBox inventoryItem = Controls.Find(itemname, true)[0] as PictureBox;
                if ((inventoryItem.Width + x_pos) > (inventoryboard.Location.X + inventoryboard.Width - player2.inventory.PADDING))
                {
                    x_pos = player2.inventory.PADDING;
                    y_pos = y_pos + (inventoryboard.Height * (1 / 3));
                }
                inventoryItem.Location = new Point(x_pos, y_pos);
                inventoryItem.Show();

                x_pos = x_pos + player2.inventory.PADDING;
            }

            player2.inventory.setVisible(!player2.inventory.visible);
            player2.inventory.selectedItem = 0;
            selectedItem();
        }

        public void selectedItem()
        {
            if (player2.inventory.itemstorage.Count > 0)
            {
                selector.Show();
                string itemname = player2.inventory.itemstorage[player2.inventory.selectedItem];
                PictureBox item = Controls.Find(itemname, true)[0] as PictureBox;
                selector.Location = new Point(item.Location.X, item.Location.Y + item.Height);
                selector.Width = item.Width;
                selector.Height = player2.inventory.PADDING / 2;
            }
        }

        private void lblInGameTime_Click(object sender, EventArgs e)
        {

        }

        private void FrmLevel_Load_1(object sender, EventArgs e)
        {

        }

        private void picWall3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Closes the application when Level2 is closed 
        /// </summary>
        public void OnFormClosed(object sender, FormClosedEventArgs e)
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
            picEnemyCheeto.Location = new Point((int)enemyCheeto2.Position.x, (int)enemyCheeto2.Position.y);
            cheetoHealthBar.Location = new Point((int)enemyCheeto2.Position.x, (int)enemyCheeto2.Position.y - 15);
            UpdateCheetoHealthBars(enemyCheeto2);
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
            picEnemyPoisonPacket.Location = new Point((int)enemyPoisonPacket2.Position.x, (int)enemyPoisonPacket2.Position.y);
            poisonHealthBar.Location = new Point((int)enemyPoisonPacket2.Position.x, (int)enemyPoisonPacket2.Position.y - 18);
            UpdatePoisonHealthBars(enemyPoisonPacket2);
            //}
        }

        //private void tmrBoss_Tick(object sender, EventArgs e)
        //{
        //    UpdateBossHealthBars(bossKoolaid2);
        //}

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
        private void UpdatePlayerHealthBars(Player p)
        {
            float playerHealthPer = p.Health / (float)p.MaxHealth;
            const int MAX_HEALTHBAR_WIDTH = 55;
            playerHealthBar.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
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
        //private void UpdateBossHealthBars(Enemy enemy)
        //{
        //    float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;
        //    const int MAX_HEALTHBAR_WIDTH = 196;
        //    bossHealthBar.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);
        //}

        public Image RotateImage(Image img, float rotationAngle)
        {
            //create an empty Bitmap image
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            //turn the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp);

            //now we set the rotation point to the center of our image
            //gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

            //now rotate the image
            gfx.RotateTransform(rotationAngle);

            //gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

            //set the InterpolationMode to HighQualityBicubic so to ensure a high
            //quality image once it is transformed to the specified size
            gfx.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            //now draw our new image onto the graphics object
            gfx.DrawImage(img, new Point(0, 0));

            //dispose of our Graphics object
            gfx.Dispose();

            //return the image
            return bmp;
        }
    } 
}


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fall2020_CSC403_Project.code
{
    public class Player : BattleCharacter
    {
        public bool walls;

        public Inventory inventory;
        public Player(Vector2 initPos, Collider collider, float toughness) : base(initPos, collider, toughness)
        {
            inventory = new Inventory();
            walls = true;
        }

        public void turnOffWalls()
        {
            walls = false;
        }

        public void turnOnWalls()
        {
            walls = true;
        }
    }
}

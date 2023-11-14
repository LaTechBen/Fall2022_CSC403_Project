using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameLibrary
{
    public class Sword
    {
        public bool swing = false;
        public int damage = -10;
        private float current_angle = 0.00f;

        public Vector2 Position { get; set; }
        public Collider Collider { get; set; }
        public Sword(Vector2 initPosition, Collider collider)
        {
            Position = initPosition;
            Collider = collider;
        }

        public float calcPointDirection(Enemy enemy, Player player)
        {
            float enemy_x = enemy.Position.x;
            float enemy_y = enemy.Position.y;

            float player_x = player.Position.x;
            float player_y = player.Position.y;

            float x_diff = player_x - enemy_x;
            float y_diff = player_y - enemy_y;

            float angle = (float)(Math.Atan2(y_diff, x_diff) * 180.0 / Math.PI);
            float angle_diff = current_angle - angle;
            Console.Write(angle_diff);

            current_angle = angle;
            return angle_diff;
        }
    }
}

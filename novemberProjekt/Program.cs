using System;
using Raylib_cs;
using System.Numerics;

namespace novemberProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            int screenWidth = 1500;
            int screenHeight = 900;

            Raylib.InitWindow(screenWidth, screenHeight, "HOUSE");

            //all textures and images
            Texture2D woodFloor = Raylib.LoadTexture(@"woodenFloor.png");
            Image characterImage = Raylib.LoadImage(@"character.png");
            Texture2D character = Raylib.LoadTextureFromImage(characterImage);


            Rectangle playField = new Rectangle((screenWidth / 2 - 1200 / 2), (screenHeight / 2 - 600 / 2), 1200, 600);

            //selfmade colors
            Color shade = new Color(0, 0, 0, 128);
            Color light = new Color(255, 255, 220, 80);
            Color deepBrown = new Color(50, 30, 20, 255);
            Color darkGray = new Color(66, 66, 66, 255);


            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.BLACK);


                //MASTER BEDROOM
                Raylib.DrawRectangle((screenWidth / 2 - 1300 / 2), (screenHeight / 2 - 700 / 2), 1300, 700, Color.DARKGRAY);
                Raylib.DrawRectangle((screenWidth / 2 - 1250 / 2), (screenHeight / 2 - 650 / 2), 1250, 650, Color.BLACK);
                Raylib.DrawRectangleRec(playField, Color.BROWN);

                Raylib.DrawRectangle((screenWidth - 500), (screenHeight / 2 - 150), 500, 300, Color.BLACK);

                //woodenfloor
                Raylib.DrawTexture(woodFloor, (int)playField.x, (int)playField.y, Color.WHITE);

                //bed
                Raylib.DrawRectangle((int)playField.x + 150, (int)playField.y, 350, 450, Color.GRAY);
                //pillows
                Raylib.DrawRectangle((int)playField.x + 180, (int)playField.y + 20, 120, 70, Color.WHITE);
                Raylib.DrawRectangle((int)playField.x + 350, (int)playField.y + 20, 120, 70, Color.WHITE);
                //blanket
                Raylib.DrawRectangle((int)playField.x + 150, (int)playField.y + 110, 350, 360, Color.DARKGREEN);
                //fold
                Raylib.DrawRectangle((int)playField.x + 150, (int)playField.y + 110, 350, 60, Color.WHITE);

                //Drawers
                Raylib.DrawRectangle((int)playField.x + 20, (int)playField.y + 10, 110, 80, deepBrown);
                Raylib.DrawRectangle((int)playField.x + 520, (int)playField.y + 10, 110, 80, deepBrown);
                Raylib.DrawRectangle((int)playField.x + 750, (int)playField.y + 480, 400, 100, deepBrown);
                //lamps
                Raylib.DrawCircle((int)playField.x + 90, (int)playField.y + 50, 25, Color.GOLD);
                Raylib.DrawCircle((int)playField.x + 560, (int)playField.y + 50, 25, Color.GOLD);
                Raylib.DrawCircle((int)playField.x + 810, (int)playField.y + 530, 25, Color.GOLD);

                //carpet
                Raylib.DrawRectangle((int)playField.x + 620, (int)playField.y + 120, 500, 300, darkGray);

                //shade
                Raylib.DrawRectangle((int)playField.x, (int)playField.y, 100, 600, shade);
                Raylib.DrawRectangle((int)playField.x + 100, (int)(playField.y + playField.height - 100), (int)playField.width - 100, 100, shade);

                //light
                Raylib.DrawCircle((int)playField.x + 560, (int)playField.y + 50, 125, light);
                Raylib.DrawCircle((int)playField.x + 810, (int)playField.y + 530, 150, light);

                //character spawn
                Raylib.DrawTexture(character, (int)playField.x + 700, (int)playField.y + 180, Color.WHITE);


                if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
                {

                }




                Raylib.EndDrawing();
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Gamejam
{
  class Food : Entity
  {
    public Food()
    {
      int iRandomFood = Gamejam.rnd.Next(6) + 1;
      SetTexture("Food/Enemy_" + iRandomFood + ".png");
      ent_vVelocity.X = (float)Gamejam.rnd.NextDouble() * 3.0f + 1.0f;
      ent_vVelocity.Y = 1;
    }

    public override void Update()
    {
      if (ent_vPosition.X > Gamejam.gam_fScreenWidth)
      {
        ToggleDirection();
      }
      else if (ent_vPosition.X < 0)
      {
        ToggleDirection();
      }

      base.Update();
    }

    private void ToggleDirection()
    {
      ent_vVelocity.X = -ent_vVelocity.X;
    }

    public override void Render()
    {
      Gamejam.SpriteBatch.Draw(ent_texTexture,
        GetCollision(), Color.White);

      base.Render();
    }
  }
}

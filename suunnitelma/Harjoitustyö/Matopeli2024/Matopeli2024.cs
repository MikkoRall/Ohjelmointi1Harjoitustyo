using System;
using System.Collections.Generic;
using Jypeli;
using Jypeli.Assets;
using Jypeli.Controls;
using Jypeli.Widgets;

namespace Matopeli2024;

/// @author Omanimi
/// @version 10.02.2024
/// <summary>
/// 
/// </summary>
public class Matopeli2024 : PhysicsGame
{
    public override void Begin()
    {
        // Kirjoita ohjelmakoodisi tähän

        PhoneBackButton.Listen(ConfirmExit, "Lopeta peli");
        Keyboard.Listen(Key.Escape, ButtonState.Pressed, ConfirmExit, "Lopeta peli");
    }
}
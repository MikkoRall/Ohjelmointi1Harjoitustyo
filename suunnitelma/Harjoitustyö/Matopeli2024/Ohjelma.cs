#region Using Statements

using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace Matopeli2024
{
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using var game = new Matopeli2024();
            game.Run();
        }
    }
}
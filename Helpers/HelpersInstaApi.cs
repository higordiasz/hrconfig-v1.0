using InstagramApiSharp.API;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRConfig.Helpers
{
  public static class HelpersInstaApi
  {
    public static IInstaApi InstaApi { get; set; }
    
    public static void WriteFullLine(string value, ConsoleColor color = ConsoleColor.DarkGreen)
    {
      //
      // This method writes an entire line to the console with the string.
      //
      Console.ForegroundColor = color;
      Console.Write(value);
      Console.ResetColor();
      Console.WriteLine();
    }

    public static void ClearConsole(ConsoleColor color = ConsoleColor.Green)
    {
      Console.Clear();
      Console.ForegroundColor = color;
      Console.Write("[+]Bot para o site GanharNoInsta! \n[+]Creado por: Dias\n[+]Loja: Insta Store\n[+]Servidor: https://discord.gg/sYeya7g \n[+]Developer Discord: Dias#1869");
      Console.WriteLine();
      Console.ResetColor();
      Console.WriteLine();
    }

  }
}

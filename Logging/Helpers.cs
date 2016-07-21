#define LOGING

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

using Viluru.Utilities.Loging;

namespace Viluru.Utilities.Loging
{
// +------------------------------------------------------------------------------+
//      CLASS:  CHelpers
//      AUTHOR: Viktor Podlipsky
//      REVISION: INITIAL
//      FUNC: Some needed and helping functions. Static Class.
// +-TODO-------------------------------------------------------------------------+
//      * 
// +-REV---------------------------------------------------------------------------+
//      REVISION 1/ xx-10-09 
//
//      INITIAL REVISION 29-10-09
//      Implemented support for the loging. ( more: CLoging class )
// +------------------------------------------------------------------------------+

    public static class Helpers
    {
#region VARIABLES
#if LOGING
        public static Loging log;
#endif

#endregion VARIABLES

#if LOGING     
 #region FUNCTIONS FOR LOGING

        public static void INITLOG(string FileName, bool OnFile, bool OnScreen, bool Append, SpriteFont font, SpriteBatch sb) { log = new Loging(FileName, OnFile, OnScreen, Append, font, sb); }
           // --- INTEGER ---
            public static void LOG(int i) { log.Write(i); }
            public static void LOG(int i, int x, int y) { log.Write(i, x, y); }
            public static void LOGS(int i) { log.WriteScreen(i); }
            public static void LOGS(int i, int x, int y) { log.WriteScreen(i, x, y); }
            public static void LOGF(int i) { log.WriteFile(i); }
           // --- FLOAT ---
            public static void LOG(float f) { log.Write(f); }
            public static void LOG(float f, int x, int y) { log.Write(f, x, y); }
           // --- STRING ---
            public static void LOG(string message) { log.Write(message); }
            public static void LOG(string message, int x, int y) { log.Write(message, x, y);  }

            //public static void LOG(string message, int x, int y) { log.Write(message, x, y); }

            public static void LOG(string message, int i) { log.Write(message, i); }
            public static void LOG(string message, float i) { log.Write(message, i); } 
        public static void ENDLOG() { log.End(); }

#endregion FUNCTIONS FOR LOGING
#endif

    }//END OF CLASS

}// END OF NAMESPACE

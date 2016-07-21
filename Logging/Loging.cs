#define LOGING

#if LOGING

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace Viluru.Utilities.Loging
{
    // +-INFO-------------------------------------------------------------------------+
    //      CLASS:  CLoging
    //      AUTHOR: Viktor Podlipsky
    //      REVISION: INITIAL
    //      FUNC: Logging support for both to file and to screen loging.
    // +-TODO-------------------------------------------------------------------------+
    //      * Add support for writing oScreen, using spriteFont and spriteBatch.DrawString
    // +-REV---------------------------------------------------------------------------+
    //      REVISION 1/ xx-10-09 
    //
    //      INITIAL REVISION 29-10-09
    //      Implements the loging support for the game loging.
    //      Constructor, which opens the log file. Proc End end the loging.
    //      Overloade proc Write writes into th file.
    // +------------------------------------------------------------------------------+

    public class Loging
    {

        private StreamWriter file;
        private DateTime time;
        private bool OnFile;
        private bool OnScreen;

        private SpriteFont font;
        private SpriteBatch spritebatch;

        Microsoft.Xna.Framework.Vector2 defaultPosition = Microsoft.Xna.Framework.Vector2.Zero;
        private Microsoft.Xna.Framework.Vector2 position;

        #region CONSTRUCTOR
        public Loging(string filename, bool OnFile, bool OnScreen, bool Append, SpriteFont f, SpriteBatch sb)
        {
            this.spritebatch = sb;
            this.font = f;
            this.OnFile = OnFile;
            this.OnScreen = OnScreen;
            this.position.X = 0; this.position.Y = 0;
            file = new System.IO.StreamWriter(@filename, Append); // true - for APPEND, false - for REWRITE file
            file.AutoFlush = true;
            time = new DateTime(); time = DateTime.Now;

            if (OnFile)
            {
                file.WriteLine("-------------------------------------");
                file.WriteLine(" LOG STARTED AT [" + time + "].");
                file.WriteLine("-------------------------------------");
                file.WriteLine();
            }


        }//END OF FUNCTION       
        #endregion CONSTRUCTOR

        #region FUNCTIONS

        #region END LOGING
        public void End()
        {
            if (OnFile)
            {
                file.WriteLine();
                time = DateTime.Now;
                file.WriteLine("-------------------------------------");
                file.WriteLine(" LOG ENDED AT [" + time + "].");
                file.WriteLine("-------------------------------------");
            }
            file.Close();
        }//END OF FUNCTION
        #endregion END LOGING

        #region INTEGER WRITER
        public void Write(int i)
        {
            if (OnFile)
            {
                time = DateTime.Now;
                file.WriteLine("   [" + time + "]:  " + i);
            }

            if (OnScreen)
            {
                time = DateTime.Now;

                spritebatch.Begin();
                spritebatch.DrawString(font, "[" + time + "]:  " + i.ToString(), defaultPosition, Color.White);
                spritebatch.End();

            }
        }//END OF FUNCTION
        public void Write(int i, int x, int y)
        {
            if (OnFile)
            {
                time = DateTime.Now;
                file.WriteLine("   [" + time + "]:  " + i);
            }

            if (OnScreen)
            {
                time = DateTime.Now;
                position.X = x; position.Y = y;

                spritebatch.Begin();
                spritebatch.DrawString(font, "[" + time + "]:  " + i.ToString(), position, Color.White);
                spritebatch.End();

            }

        }// END OF FUNCTION
        public void WriteScreen(int i)
        {
            time = DateTime.Now;

            spritebatch.Begin();
            spritebatch.DrawString(font, "[" + time + "]:  " + i.ToString(), defaultPosition, Color.White);
            spritebatch.End();

        }//END OF FUNCTION
        public void WriteScreen(int i, int x, int y)
        {
            time = DateTime.Now;
            position.X = x; position.Y = y;

            spritebatch.Begin();
            spritebatch.DrawString(font, "[" + time + "]:  " + i.ToString(), position, Color.White);
            spritebatch.End();

        }//END OF FUNCTION
        public void WriteFile(int i)
        {
            time = DateTime.Now;
            file.WriteLine("   [" + time + "]:  " + i);
        }//END OF FUNCTION
        #endregion INTEGER WRITER

        #region FLOAT WRITER
        public void Write(float f)
        {
            if (OnFile)
            {
                time = DateTime.Now;
                file.WriteLine("   [" + time + "]:  " + f);
            }

            if (OnScreen)
            {
                time = DateTime.Now;

                spritebatch.Begin();
                spritebatch.DrawString(font, "[" + time + "]:  " + f.ToString(), defaultPosition, Color.White);
                spritebatch.End();

            }
        }//END OF FUNCTION
        public void Write(float f, int x, int y)
        {
            if (OnFile)
            {
                time = DateTime.Now;
                file.WriteLine("   [" + time + "]:  " + f);
            }

            if (OnScreen)
            {
                time = DateTime.Now;
                position.X = x; position.Y = y;

                spritebatch.Begin();
                spritebatch.DrawString(font, "[" + time + "]:  " + f.ToString(), position, Color.White);
                spritebatch.End();

            }
        }//END OF FUNCTION
        #endregion FLOAT WRITER

        #region STRING WRITER
        public void Write(string message)
        {
            if (OnFile)
            {
                time = DateTime.Now;
                file.WriteLine("   [" + time + "]:  " + message);
            }

            if (OnScreen)
            {
                time = DateTime.Now;

                spritebatch.Begin();
                spritebatch.DrawString(font, "[" + time + "]:  " + message, defaultPosition, Color.White);
                spritebatch.End();

            }

        }//END OF FUNCTION
        public void Write(string message, int x, int y)
        {
            if (OnFile)
            {
                time = DateTime.Now;
                file.WriteLine("   [" + time + "]:  " + message);
            }

            if (OnScreen)
            {
                time = DateTime.Now;
                position.X = x; position.Y = y;

                spritebatch.Begin();
                spritebatch.DrawString(font, "[" + time + "]:  " + message, position, Color.White);
                spritebatch.End();

            }

        }// END OF FUNCTION
        #endregion STRING WRITER

        // write a STRING and INTEGER
        public void Write(string message, int i)
        {
            if (OnFile)
            {
                time = DateTime.Now;
                file.WriteLine("   [" + time + "]:  " + message + " " + i);
            }
            if (OnScreen)
            {
                time = DateTime.Now;
                spritebatch.Begin();
                spritebatch.DrawString(font, "[" + time + "]:  " + message + " " + i.ToString(), position, Color.White);
                spritebatch.End();
            }
        }

        // write a STRING and FLOAT
        public void Write(string message, float i)
        {
            if (OnFile)
            {
                time = DateTime.Now;
                file.WriteLine("   [" + time + "]:  " + message + " " + i);
            }
            if (OnScreen)
            {
                /* NOT YET IMPLEMENTED FOR GRAPHICAL */

            }
        }


        // write a STRING

        #endregion FUNCTIONS

    }// END OF CLASS

}// END OF NAMESPACE

#endif
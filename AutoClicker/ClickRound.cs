using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClicker
{
    internal class ClickRound
    {
        JObject jobj = null;
        JToken[] firstX = null;
        JToken[] secondX = null;
        JToken[] thirdX = null;
        JToken[] fourthX = null;
        JToken[] fifthX = null;
        JToken[] firstY = null;
        JToken[] secondY = null;
        JToken[] thirdY = null;
        JToken[] fourthY = null;
        JToken[] fifthY = null;
        //MouseEvent mouseEvent = null;
        //KeyBoardEvent keyBoardEvent = null;
        public ClickRound()
        {
            jobj = ReadJson();
            firstX = jobj["first"].Values("X").ToArray();
            secondX = jobj["second"].Values("X").ToArray();
            thirdX = jobj["third"].Values("X").ToArray();
            fourthX = jobj["fourth"].Values("X").ToArray();
            fifthX = jobj["fifth"].Values("X").ToArray();
            firstY = jobj["first"].Values("Y").ToArray();
            secondY = jobj["second"].Values("Y").ToArray();
            thirdY = jobj["third"].Values("Y").ToArray();
            fourthY = jobj["fourth"].Values("Y").ToArray();
            fifthY = jobj["fifth"].Values("Y").ToArray();
            //mouseEvent = new MouseEvent();
            //keyBoardEvent = new KeyBoardEvent();
        }
        private static JObject ReadJson()
        {
            string filepath = @"C:\Coordinates.json";
            string result = string.Empty;
            using (StreamReader r = new StreamReader(filepath))
            {
                var json = r.ReadToEnd();
                return JObject.Parse(json);
            }
        }
        public void FirstRound()
        {
            Clipboard.Clear();
            MouseEvent.ScrollDown();
            Thread.Sleep(50);
            Cursor.Position = new Point()
            {
                X = Convert.ToInt32(firstX[0].ToString()),
                Y = Convert.ToInt32(firstY[0].ToString())
            };
            Thread.Sleep(100);
            MouseEvent.LeftClick();
            Thread.Sleep(10);
            Cursor.Position = new Point()
            {
                X = Convert.ToInt32(firstX[1].ToString()),
                Y = Convert.ToInt32(firstY[1].ToString())
            };
            Thread.Sleep(100);
            MouseEvent.LeftClick();
            Thread.Sleep(10);
            Cursor.Position = new Point()
            {
                X = Convert.ToInt32(firstX[2].ToString()),
                Y = Convert.ToInt32(firstY[2].ToString())
            };
            Thread.Sleep(100);
            MouseEvent.LeftClick();
            Thread.Sleep(10);
            Cursor.Position = new Point()
            {
                X = Convert.ToInt32(firstX[3].ToString()),
                Y = Convert.ToInt32(firstY[3].ToString())
            };
            Thread.Sleep(100);
            MouseEvent.LeftClick();
            Thread.Sleep(10);
            for (int i = 0; i < 6; i++)
            {
                KeyBoardEvent.PressControlPlus();
                //Thread.Sleep(10);
            }

            MouseEvent.ScrollDown();
            KeyBoardEvent.PressAltTAB();
            Clipboard.SetText("passed1");
        }

        public void SecondRound(string text)
        {
            Clipboard.Clear();

            Cursor.Position = new Point()
            {
                X = Convert.ToInt32(secondX[0].ToString()),
                Y = Convert.ToInt32(secondY[0].ToString())
            };
            Thread.Sleep(100);
            MouseEvent.LeftClick();
            Thread.Sleep(10);
            for (int i = 0; i < 6; i++)
            {
                KeyBoardEvent.PressControlMinus();
                //Thread.Sleep(50);
            }

            Clipboard.SetText(text);
            Thread.Sleep(20);
            Cursor.Position = new Point()
            {
                X = Convert.ToInt32(secondX[1].ToString()),
                Y = Convert.ToInt32(secondY[1].ToString())
            };
            Thread.Sleep(100);
            MouseEvent.LeftClick();
            //Thread.Sleep(10);
            KeyBoardEvent.PressControlAndV();
            Thread.Sleep(20);
            Cursor.Position = new Point()
            {
                X = Convert.ToInt32(secondX[2].ToString()),
                Y = Convert.ToInt32(secondY[2].ToString())
            };
            Thread.Sleep(100);
            MouseEvent.LeftClick();
            Thread.Sleep(10);
            Clipboard.Clear();
            KeyBoardEvent.PressAltTAB();
            Clipboard.SetText("passed2");
        }
        public void ThirdRound()
        {
            Clipboard.Clear();
            MouseEvent.ScrollDown();
            Thread.Sleep(20);
            MouseEvent.ScrollDown();
            Thread.Sleep(20);
            Cursor.Position = new Point()
            {
                X = Convert.ToInt32(thirdX[0].ToString()),
                Y = Convert.ToInt32(thirdY[0].ToString())
            };
            Thread.Sleep(100);
            MouseEvent.LeftClick();
            Thread.Sleep(10);
            for (int i = 0; i < 6; i++)
            {
                KeyBoardEvent.PressControlPlus();
                //Thread.Sleep(50);
            }
            MouseEvent.ScrollDown();
            Thread.Sleep(20);
            KeyBoardEvent.PressAltTAB();
            Clipboard.SetText("passed3");
        }

        public void FourthRound(string text)
        {
            Clipboard.Clear();
            Clipboard.SetText(text);
            Cursor.Position = new Point()
            {
                X = Convert.ToInt32(fourthX[0].ToString()),
                Y = Convert.ToInt32(fourthY[0].ToString())
            };
            Thread.Sleep(100);
            MouseEvent.LeftClick();
            Thread.Sleep(10);
            KeyBoardEvent.PressControlAndV();
            Cursor.Position = new Point()
            {
                X = Convert.ToInt32(fourthX[1].ToString()),
                Y = Convert.ToInt32(fourthY[1].ToString())
            };
            Thread.Sleep(100);
            MouseEvent.LeftClick();
            Thread.Sleep(10);
            for (int i = 0; i < 6; i++)
            {
                KeyBoardEvent.PressControlMinus();
                //Thread.Sleep(50);
            }
            KeyBoardEvent.PressAltTAB();
            Clipboard.Clear();
            Clipboard.SetText("passed4");
        }

        public void FifthRound()
        {
            Clipboard.Clear();
            MouseEvent.ScrollDown();
            Thread.Sleep(20);
            Cursor.Position = new Point()
            {
                X = Convert.ToInt32(fifthX[0].ToString()),
                Y = Convert.ToInt32(fifthY[0].ToString())
            };
            Thread.Sleep(100);
            MouseEvent.LeftClick();
            Clipboard.SetText("passed5");
        }
    }
}

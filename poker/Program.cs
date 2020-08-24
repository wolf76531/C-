using System;
using System.Collections.Generic;


namespace poker
{
    class Program
    {
        class PaperCard
        {
            public string Type { get; set; }
            public string Number { get; set; }
            public PaperCard(string strType, string strNumber)
            {
                Type = strType;
                Number = strNumber;
            }
        }

        

        static void Main(string[] args)
        {
            string[] strType = { "spare", "hearts", "diamond", "clubs"};
            string[] strNumber = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13" };
            List<PaperCard> cards = new List<PaperCard>();


            for (int i = 0; i < strNumber.Length; i++)
            {
                for (int j = 0; j < strType.Length; j++)
                {
                    cards.Add(new PaperCard(strType[j], strNumber[i]));
                }
            }

            string[] shuffleCrads = new string[52];
            Random r = new Random();
            
            while (cards.Count > 0)
            {
                int i = r.Next(0, cards.Count);
                shuffleCrads[(52 - cards.Count)] = cards[i].Number + " " + cards[i].Type;
                cards.RemoveAt(i);
            }

            string[][] User = new string[4][];
            //string[] user1 = new string[13];
            //string[] user2 = new string[13];
            //string[] user3 = new string[13];
            //string[] user4 = new string[13];
            User[0] = new string[13];
            User[1] = new string[13];
            User[2] = new string[13];
            User[3] = new string[13];

            for (int i=0; i<shuffleCrads.Length; i++)
            {
                if (i % 4 == 1)
                {
                    //user1[i/4] = shuffleCrads[i];
                    User[1][i / 4] = shuffleCrads[i];
                }
                else if(i % 4 ==2)
                {
                    //user2[i/4] = shuffleCrads[i];
                    User[2][i / 4] = shuffleCrads[i];
                }
                else if (i % 4 == 3)
                {
                    //user3[i/4] = shuffleCrads[i];
                    User[3][i / 4] = shuffleCrads[i];
                }
                else
                {
                    //user4[i/4] = shuffleCrads[i];
                    User[0][i / 4] = shuffleCrads[i];
                }

            }

            int key;
            for (int k   = 0; k < 4; k++)
            {
                for (int i = 0; i < User[k].Length; i++)
                {
                    string poke = User[k][i];
                    key = int.Parse(poke.Substring(0, 2));
                    int j = i - 1;
                    while (j >= 0 && key < int.Parse(User[k][j].Substring(0, 2)))
                    {
                        User[k][j +1] = User[k][j];
                        j--;
                    }
                    User[k][j + 1] = poke;
                }
            }



            //int key;
            //for (int i = 0; i < user1.Length; i++)
            //{
            //    string poke = user1[i];
            //    key = int.Parse(poke.Substring(0, 2));
            //    int j = i - 1;
            //    while (j >= 0 && key < int.Parse(user1[j].Substring(0, 2)))
            //    {
            //        user1[j + 1] = user1[j];
            //        j--;
            //    }
            //    user1[j + 1] = poke;
            //}

            //for (int i = 0; i < user2.Length; i++)
            //{
            //    string poke = user2[i];
            //    key = int.Parse(poke.Substring(0, 2));
            //    int j = i - 1;
            //    while (j >= 0 && key < int.Parse(user2[j].Substring(0, 2)))
            //    {
            //        user2[j + 1] = user2[j];
            //        j--;
            //    }
            //    user2[j + 1] = poke;
            //}

            //for (int i = 0; i < user3.Length; i++)
            //{
            //    string poke = user3[i];
            //    key = int.Parse(poke.Substring(0, 2));
            //    int j = i - 1;
            //    while (j >= 0 && key < int.Parse(user3[j].Substring(0, 2)))
            //    {
            //        user3[j + 1] = user3[j];
            //        j--;
            //    }
            //    user3[j + 1] = poke;
            //}

            //for (int i = 0; i < user4.Length; i++)
            //{
            //    string poke = user4[i];
            //    key = int.Parse(poke.Substring(0, 2));
            //    int j = i - 1;
            //    while (j >= 0 && key < int.Parse(user4[j].Substring(0, 2)))
            //    {
            //        user4[j + 1] = user4[j];
            //        j--;
            //    }
            //    user4[j + 1] = poke;
            //}

            /*Array.Sort(user1);
            Array.Sort(user2);
            Array.Sort(user3);
            Array.Sort(user4);*/

            //Console.WriteLine("USER1 的牌:{0}", string.Join(" ", User[0]));
            //Console.WriteLine("USER2 的牌:{0}", string.Join(" ", User[1]));
            //Console.WriteLine("USER3 的牌:{0}", string.Join(" ", User[2]));
            //Console.WriteLine("USER4 的牌:{0}", string.Join(" ", User[3]));

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("USER" + (i+1).ToString() + " 的牌:{0}", string.Join(" ", User[i]));
                if (Array.IndexOf(User[i], "2 spare") >= 0)
                {
                    Console.WriteLine("黑桃2 在 第 " + (i+1).ToString() + " 個人手上");
                }
            }

            //if (Array.IndexOf(user1, "2 spare") >= 0)
            //{
            //    Console.WriteLine("黑桃2 在 第 1 個人手上");
            //}
            //else if (Array.IndexOf(user2, "2 spare") >= 0)
            //{
            //    Console.WriteLine("黑桃2 在 第 2 個人手上");
            //}
            //else if (Array.IndexOf(user3, "2 spare") >= 0)
            //{
            //    Console.WriteLine("黑桃2 在 第 3 個人手上");
            //}
            //else
            //{
            //    Console.WriteLine("黑桃2 在 第 4 個人手上");
            //}
            Console.ReadKey();
        }
    }

}

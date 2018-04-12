using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.將所有號碼放入List中
            List<int> randNum = new List<int>();

            // 利用迴圈將號碼放入List之中
            for (int i = 0 ; i <= 10 ; i++) { 
                randNum.Add(i);
            }

            Random rand = new Random();
           
            for (int j = 0 ; j <= 6; j++)
            {
            // 由於被移除掉的randNum[r]會讓List少掉一個號碼 所以用Count直接取得List中的號碼數量 這樣就不會出BUG(吧?)
                int r = rand.Next(1, randNum.Count);

            // 2.從LIST中隨機挑出一個(沒人要的小孩)亂數並印出
                Console.WriteLine(randNum[r]);  
            
            // 3.將(沒人要的小孩)亂數從List中"刪去"
                randNum.RemoveAt(r);
            }
            // 4.利用for迴圈重複(上述慘無人道的)第2,3步驟"6次"

            Console.ReadKey();
        }
    }
}

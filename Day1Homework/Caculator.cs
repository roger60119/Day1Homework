using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Homework
{
    public class Caculator
    {
        /// <summary>
        /// 計算所選欄位加總集合
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="list">串列</param>
        /// <param name="amount">數量</param>
        /// <param name="column">欄位</param>
        /// <returns></returns>
        public IEnumerable<int> Sum<T>(IEnumerable<T> list, int amount, string column)
        {
            var count = list.Count() % amount == 0 ? list.Count() / amount : list.Count() / amount + 1;

            for (int i = 0; i < count; i++)
            {
                yield return 
                    list.Skip(amount * i)
                    .Take(amount)
                    .Sum(x => Convert.ToInt32(x.GetType().GetProperty(column).GetValue(x)));
            }
        }
    }
}

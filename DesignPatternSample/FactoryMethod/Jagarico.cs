using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.FactoryMethod
{
	public class Jagarico : Product
	{
		private string taste;

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="taste"></param>
		public Jagarico(string taste)
		{
			Console.WriteLine("{0}味のじゃがりこを作ります!!!", taste);
			this.taste = taste;
		}

		/// <summary>
		/// 食す
		/// </summary>
		public override void Eat()
		{
			Console.WriteLine("もぐもぐ、{0}旨い!!!" , taste);
		}

		/// <summary>
		/// 味の取得
		/// </summary>
		/// <returns></returns>
		public string GetTaste()
		{
			return taste;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.TemplateMethod
{
	public class ConcreteCookingImp : CookingImp
	{
		/// <summary>
		/// 料理する
		/// </summary>
		public override void RawCut()
		{
			Console.WriteLine("切ります。");
		}

		/// <summary>
		/// 食べる
		/// </summary>
		public override void RawFly()
		{
			Console.WriteLine("炒めます。");
		}

		/// <summary>
		/// 片付ける
		/// </summary>
		public override void RawMix()
		{
			Console.WriteLine("混ぜます。");
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.TemplateMethod
{
	public class ExtendCooking : Cooking
	{
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="imp"></param>
		public ExtendCooking(CookingImp imp) : base(imp)
		{
		}

		/// <summary>
		/// 野菜スティック
		/// </summary>
		public void VegetableStick()
		{
			Console.WriteLine("野菜スティック作るよ!!!");
			for (int i = 0; i < 3; i++)
			{
				this.Cut();
			}
			Console.WriteLine("野菜スティックできたよ!!!");
		}
	}
}

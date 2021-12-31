using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.TemplateMethod
{
	abstract public class CookingImp
	{
		/// <summary>
		/// 切る
		/// </summary>
		public abstract void RawCut();

		/// <summary>
		/// 炒める
		/// </summary>
		public abstract void RawFly();

		/// <summary>
		/// 混ぜる
		/// </summary>
		public abstract void RawMix();
	}
}
